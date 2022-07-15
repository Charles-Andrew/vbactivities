Imports MySql.Data.MySqlClient

Public Class SchoolYearForm
    Private Sub SchoolYearForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numericFrom.Value = DateTime.Now.Year
        btnAdd.Enabled = False
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
End Class