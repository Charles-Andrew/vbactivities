Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLogin.Enabled = False
        Dim m As New Menu
        m.Show()
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        dbconn.Open()
        Dim cmd As New MySqlCommand
        Dim rd As MySqlDataReader

        cmd.Connection = Conn

        cmd.CommandText = "SELECT * FROM users WHERE username=@username AND password=@password"
        cmd.Parameters.AddWithValue("@username", tbUsername.Text)
        Dim l As New encryptClass
        l.hashProp = tbPassword.Text
        cmd.Parameters.AddWithValue("@password", l.hashProp)
        rd = cmd.ExecuteReader


        If rd.HasRows Then
            Dim m As New Menu
            m.Show()
            Me.Close()
        Else
            MessageBox.Show("Incorrect details. Please try again.")
        End If

        rd.Close()
        dbconn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As New registration
        r.ShowDialog()
    End Sub

    Private Sub CheckEmpty()
        If tbPassword.Text = "" OrElse tbUsername.Text = "" Then
            btnLogin.Enabled = False
        Else
            btnLogin.Enabled = True
        End If
    End Sub

    Private Sub tbUsername_TextChanged(sender As Object, e As EventArgs) Handles tbUsername.TextChanged
        CheckEmpty()
    End Sub

    Private Sub tbPassword_TextChanged(sender As Object, e As EventArgs) Handles tbPassword.TextChanged
        CheckEmpty()
    End Sub
End Class
