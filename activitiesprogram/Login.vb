Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog

        btnLogin.Enabled = False
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
            If CheckAdmin(tbUsername.Text, l.hashProp) Then
                Dim m As New Menu
                m.Admin = True
                m.Show()
                Me.Close()
            Else
                MessageBox.Show("Incorrect details. Please try again.")
            End If
        End If

        rd.Close()
        dbconn.Close()
    End Sub

    Private Function CheckAdmin(u As String, p As String) As Boolean
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        Dim dr = db.dr
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT * FROM admin WHERE username=@u AND password=@p"
        cmd.Parameters.AddWithValue("@u", u)
        cmd.Parameters.AddWithValue("@p", p)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim a As New AdminClass
            While dr.Read
                a.SetLoginIndicator(dr("idadmin"))
            End While
            Return True
        Else
            Return False
        End If
        db.Close()

    End Function

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

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim r As New registration
        r.ShowDialog()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim a As New AdminUserManagement
        Me.Hide()
        a.ShowDialog()
        Me.Show()
    End Sub
End Class
