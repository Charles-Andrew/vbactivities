Imports System.Text.RegularExpressions

Public Class StudentForm
    Private Sub StudentAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False
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
            asc.UpdateStudent(Integer.Parse(lblID.Text))

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
            If asc.AddStudent() = 1 Then
                ClearFields()
            End If
        End If
    End Sub

    Private Sub rbFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbFemale.CheckedChanged
        ValidateFields()
    End Sub

    Private Sub rbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbMale.CheckedChanged
        ValidateFields()
    End Sub
End Class