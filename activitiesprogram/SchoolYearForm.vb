Imports MySql.Data.MySqlClient

Public Class SchoolYearForm
    Private Sub SchoolYearForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog

        numericFrom.Value = DateTime.Now.Year
        btnAdd.Enabled = False
        LoadAllSY()

        If HaveActiveSY() Then
            LoadActiveSY()
        End If
    End Sub
    Private Sub ValidateSY()
        dbconn.Open()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        cmd.Connection = Conn
        cmd.CommandText = "SELECT * FROM schoolyear_sem WHERE year = @yr"
        cmd.Parameters.AddWithValue("@yr", numericFrom.Value.ToString + "-" + tbSYTo.Text)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            btnAdd.Enabled = False
            lblInfo.ForeColor = Color.Red
            lblInfo.Visible = True
        Else
            lblInfo.Visible = False
            btnAdd.Enabled = True
        End If

        dbconn.Close()
    End Sub

    Private Sub LoadActiveSY()
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        Dim dr = db.dr
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT concat(year,' ',sem) as asy FROM schoolyear_sem WHERE idsy = @ID"
        cmd.Parameters.AddWithValue("@ID", cbSY.SelectedValue)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                lblActiveSY.Text = "Active School Year - Semester: " + dr("asy")
            End While
        End If

        db.Close()
    End Sub

    Private Sub LoadAllSY()
        Dim db As New DBClass
        Dim dt As New DataTable
        db.Open()
        Dim cmd = db.cmd
        Dim dr = db.dr
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT idsy, CONCAT(year,' ',sem) as SY FROM schoolyear_sem ORDER BY year DESC"
        dr = cmd.ExecuteReader

        dt.Load(dr)
        cbSY.DataSource = dt
        cbSY.DisplayMember = "SY"
        cbSY.ValueMember = "idsy"
        db.Close()
    End Sub

    Private Sub numericFrom_ValueChanged(sender As Object, e As EventArgs) Handles numericFrom.ValueChanged
        tbSYTo.Text = numericFrom.Value + 1
        ValidateSY()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim sy As New SchoolYearClass
        sy.SchoolYearProp = numericFrom.Value.ToString + "-" + tbSYTo.Text
        sy.AddSchoolYear()
        btnAdd.Enabled = False
        lblInfo.ForeColor = Color.Red
        lblInfo.Visible = True
    End Sub

    Private Sub btnSetSY_Click(sender As Object, e As EventArgs)
        If cbSY.Text <> "" Then
            If Not HaveActiveSY() Then
                Dim db As New DBClass
                db.Open()
                Dim cmd = db.cmd
                cmd.Connection = db.conn
                cmd.CommandText = "INSERT INTO active_sy (idsy) VALUES (@IDSY)"
                cmd.Parameters.AddWithValue("@IDSY", cbSY.SelectedValue)
                cmd.ExecuteNonQuery()
            Else
                Dim db As New DBClass
                db.Open()
                Dim cmd = db.cmd
                cmd.Connection = db.conn
                cmd.CommandText = "UPDATE active_sy SET idsy = @IDSY"
                cmd.Parameters.AddWithValue("@IDSY", cbSY.SelectedValue)
                cmd.ExecuteNonQuery()
            End If
        End If
        LoadActiveSY()
    End Sub

    Public Function HaveActiveSY() As Boolean
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        Dim dr = db.dr
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT * FROM active_sy"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Return True
        Else
            Return False
        End If
    End Function
End Class