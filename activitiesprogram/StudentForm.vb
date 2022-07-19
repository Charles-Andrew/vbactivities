Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class StudentForm
    Public tempid As Integer = 0
    Private Sub StudentAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog

        btnAdd.Enabled = False
        LoadCBItems()
    End Sub
    Private Sub LoadCBItems()
        LoadSy()
        LoadCourse()
        cbYL.Items.Add("1st Year")
        cbYL.Items.Add("2nd Year")
        cbYL.Items.Add("3rd Year")
        cbYL.Items.Add("4th Year")
        cbStatus.Items.Add("Regular")
        cbStatus.Items.Add("Irregular")

        If tempid <> 0 Then
            Dim db As New DBClass
            db.Open()
            Dim cmd As New MySqlCommand
            Dim dr As MySqlDataReader
            cmd.Connection = db.conn
            cmd.CommandText = "SELECT * FROM stud_course WHERE idstudent = @idstudent"
            cmd.Parameters.AddWithValue("@idstudent", tempid)

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    cbSY.SelectedValue = dr("idsy")
                    cbCourse.SelectedValue = dr("idcourse")
                    cbYL.SelectedIndex = cbYL.FindStringExact(dr("year_level"))
                    cbStatus.SelectedIndex = cbStatus.FindStringExact(dr("status"))
                End While
            End If
            db.Close()
        Else
            cbYL.SelectedIndex = 0
            cbStatus.SelectedIndex = 0
        End If


    End Sub
    Private Sub LoadSy()
        dbconn.Open()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim dt As New DataTable
        cmd.Connection = Conn
        cmd.CommandText = "SELECT idsy, CONCAT(year,' - ', sem, ' semester') as sem FROM schoolyear_sem WHERE idsy = (SELECT * FROM active_sy) ORDER BY year DESC;"
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            dt.Load(dr)
            cbSY.DataSource = dt
            cbSY.ValueMember = "idsy"
            cbSY.DisplayMember = "sem"
        End If
        dbconn.Close()
    End Sub
    Private Sub LoadCourse()
        dbconn.Open()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim dt As New DataTable
        cmd.Connection = Conn
        cmd.CommandText = "SELECT * FROM course"
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            dt.Load(dr)
            cbCourse.DataSource = dt
            cbCourse.ValueMember = "idcourse"
            cbCourse.DisplayMember = "course_name"
        End If
        dbconn.Close()
    End Sub

    Private Sub ValidateFields()
        'Dim regexItem = New Regex("^[a-zA-Z0-9 ]+$")
        If tbAddress.Text = "" OrElse tbCN.Text = "" OrElse tbLN.Text = "" OrElse tbFN.Text = "" OrElse tbMN.Text = "" OrElse tbPN.Text = "" OrElse (Not rbMale.Checked And Not rbFemale.Checked) Then
            btnAdd.Enabled = False
        Else
            Dim LettersOnly = New Regex("^[a-zA-Z ]+$")
            If Not LettersOnly.IsMatch(tbFN.Text) OrElse Not LettersOnly.IsMatch(tbMN.Text) OrElse Not LettersOnly.IsMatch(tbLN.Text) OrElse Not LettersOnly.IsMatch(tbPN.Text) Then
                btnAdd.Enabled = False
            Else
                Dim NumbersOnly = New Regex("^[0-9]+$")
                If Not NumbersOnly.IsMatch(tbCN.Text) AndAlso tbCN.Text.Count < 12 Then
                    btnAdd.Enabled = False
                Else
                    If tbCN.Text.Count < 12 AndAlso tbCN.Text.Count > 10 Then
                        btnAdd.Enabled = True
                    Else
                        btnAdd.Enabled = False
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub ClearFields()
        tbFN.Text = ""
        tbMN.Text = ""
        tbLN.Text = ""
        tbPN.Text = ""
        tbAddress.Text = ""
        tbCN.Text = ""
        dtpDOB.Value = DateTime.Now
        rbMale.Checked = False
        rbFemale.Checked = False
    End Sub

    Private Sub tbLN_TextChanged(sender As Object, e As EventArgs) Handles tbLN.TextChanged
        ValidateFields()
    End Sub

    Private Sub tbFN_TextChanged(sender As Object, e As EventArgs) Handles tbFN.TextChanged
        ValidateFields()
    End Sub

    Private Sub tbMN_TextChanged(sender As Object, e As EventArgs) Handles tbMN.TextChanged
        ValidateFields()
    End Sub

    Private Sub tbPN_TextChanged(sender As Object, e As EventArgs) Handles tbPN.TextChanged
        ValidateFields()
    End Sub

    Private Sub tbAddress_TextChanged(sender As Object, e As EventArgs) Handles tbAddress.TextChanged
        ValidateFields()
    End Sub

    Private Sub tbCN_TextChanged(sender As Object, e As EventArgs) Handles tbCN.TextChanged
        ValidateFields()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Tempgender As String = ""
        If rbMale.Checked Then
            Tempgender = rbMale.Text
        ElseIf rbFemale.Checked Then
            Tempgender = rbFemale.Text
        End If

        If btnAdd.Text = "Update Record" Then
            Dim asc As New StudentClass
            asc.FirstNameProp = tbFN.Text.Trim()
            asc.MiddleNameProp = tbMN.Text.Trim()
            asc.LastNameProp = tbLN.Text.Trim()
            asc.GenderProp = Tempgender
            asc.ParentNameProp = tbPN.Text.Trim()
            asc.DOBProp = dtpDOB.Value.Date
            asc.AddressProp = tbAddress.Text.Trim()
            asc.ContactNoProp = tbCN.Text.Trim()
            asc.UpdateStudent(tempid, cbSY.SelectedValue, cbCourse.SelectedValue, cbYL.Text, cbStatus.Text)

        Else
            Dim asc As New StudentClass
            asc.FirstNameProp = tbFN.Text.Trim()
            asc.MiddleNameProp = tbMN.Text.Trim()
            asc.LastNameProp = tbLN.Text.Trim()
            asc.GenderProp = Tempgender
            asc.ParentNameProp = tbPN.Text.Trim()
            asc.DOBProp = dtpDOB.Value.Date
            asc.AddressProp = tbAddress.Text.Trim()
            asc.ContactNoProp = tbCN.Text.Trim()
            asc.AddStudent(cbCourse.SelectedValue, cbSY.SelectedValue, cbYL.Text, cbStatus.Text)
            ClearFields()

        End If
    End Sub

    Private Sub rbFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbFemale.CheckedChanged
        ValidateFields()
    End Sub

    Private Sub rbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbMale.CheckedChanged
        ValidateFields()
    End Sub

    Private Sub cbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged
        ValidateFields()
    End Sub

    Private Sub cbSY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSY.SelectedIndexChanged
        ValidateFields()
    End Sub

    Private Sub cbYL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbYL.SelectedIndexChanged
        ValidateFields()
    End Sub

    Private Sub cbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCourse.SelectedIndexChanged
        ValidateFields()
    End Sub
End Class