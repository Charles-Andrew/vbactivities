Imports System.Text.RegularExpressions

Public Class TeacherForm
    Private Sub TeacherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Update Record" Then
            Dim ta As New TeacherClass
            ta.TeacherFirstName = tbFN.Text.Trim()
            ta.TeacherMiddleName = tbMN.Text.Trim()
            ta.TeacherLastName = tbLN.Text.Trim()
            ta.EditTeacher(Integer.Parse(lblID.Text))

        Else
            Dim ta As New TeacherClass
            ta.TeacherFirstName = tbFN.Text.Trim()
            ta.TeacherMiddleName = tbMN.Text.Trim()
            ta.TeacherLastName = tbLN.Text.Trim()
            If ta.AddTeacher() Then
                tbFN.Text = ""
                tbMN.Text = ""
                tbLN.Text = ""
            End If
        End If

    End Sub

    Private Sub ValidateForm()
        Dim LettersOnly = New Regex("^[a-zA-Z ]+$")
        If Not LettersOnly.IsMatch(tbFN.Text) And Not LettersOnly.IsMatch(tbMN.Text) And Not LettersOnly.IsMatch(tbLN.Text) Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If
    End Sub

    Private Sub tbFN_TextChanged(sender As Object, e As EventArgs) Handles tbFN.TextChanged
        ValidateForm()
    End Sub

    Private Sub tbMN_TextChanged(sender As Object, e As EventArgs) Handles tbMN.TextChanged
        ValidateForm()
    End Sub

    Private Sub tbLN_TextChanged(sender As Object, e As EventArgs) Handles tbLN.TextChanged
        ValidateForm()
    End Sub

End Class