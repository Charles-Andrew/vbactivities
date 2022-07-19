Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class registration
    Private Sub registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog

        btnRegister.Enabled = False
        lblInfo.Visible = False
    End Sub
    Private Sub ValidateFields()
        Dim check1, check2, check3, check4 As Boolean
        Dim regexItem = New Regex("^[a-zA-Z0-9 ]+$")

        If InStr(tbUsername.Text, " ") > 0 Or tbUsername.Text.Count < 5 Or Not regexItem.IsMatch(tbUsername.Text) Then
            tbUsername.ForeColor = Color.Red
            lblInfo.Visible = False
            check1 = False
        Else
            If Not Checkexist(tbUsername.Text) Then
                tbUsername.ForeColor = DefaultForeColor
                check1 = True
                lblInfo.Text = "Username Available"
                lblInfo.ForeColor = Color.Green
                lblInfo.Visible = True
            Else
                lblInfo.Text = "Username already exist!"
                lblInfo.ForeColor = Color.Red
                lblInfo.Visible = True
            End If
        End If



        If tbEmail.Text.Contains("@") AndAlso tbEmail.Text.Contains(".com") And tbEmail.Text.Count > 0 Then
            tbEmail.ForeColor = DefaultForeColor
            check2 = True
        Else
            tbEmail.ForeColor = Color.Red
            check2 = False
        End If

        If InStr(tbPassword.Text, " ") > 0 Or tbPassword.Text.Count < 5 Or Not regexItem.IsMatch(tbPassword.Text) Then
            tbPassword.ForeColor = Color.Red
            check3 = False
        Else
            tbPassword.ForeColor = DefaultForeColor
            check3 = True
        End If

        If Not tbConfirmation.Text = tbPassword.Text Then
            check4 = False
            tbConfirmation.ForeColor = Color.Red
        Else
            check4 = True
            tbConfirmation.ForeColor = DefaultForeColor
        End If

        If check1 And check2 And check3 And check4 Then
            btnRegister.Enabled = True
        Else
            btnRegister.Enabled = False
        End If
    End Sub

    Private Function Checkexist(username As String) As Boolean
        dbconn.Open()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        cmd.Connection = Conn
        cmd.CommandText = "SELECT * FROM users WHERE username=@un"
        cmd.Parameters.AddWithValue("@un", username)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            Return True
        Else
            Return False
        End If

        dbconn.Close()

    End Function

    Private Sub tbUsername_TextChanged(sender As Object, e As EventArgs) Handles tbUsername.TextChanged
        ValidateFields()
    End Sub

    Private Sub tbEmail_TextChanged(sender As Object, e As EventArgs) Handles tbEmail.TextChanged
        ValidateFields()
    End Sub

    Private Sub tbPassword_TextChanged(sender As Object, e As EventArgs) Handles tbPassword.TextChanged
        ValidateFields()
    End Sub

    Private Sub tbConfirmation_TextChanged(sender As Object, e As EventArgs) Handles tbConfirmation.TextChanged
        ValidateFields()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim n As New registerClass
        n.UsernameProp = tbUsername.Text.Trim()
        n.PasswordProp = tbPassword.Text.Trim()
        n.EmailProp = tbEmail.Text.Trim()
        n.Register()
        Me.Close()
    End Sub
End Class