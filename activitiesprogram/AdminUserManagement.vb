Public Class AdminUserManagement
    Dim id As Integer = 0
    Private Sub AdminUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CheckExistAdmin() Then
        Else
            btnLogin.Text = "Set"
            tbAdminUsername.PasswordChar = Nothing
            tbAdminPassword.PasswordChar = Nothing
        End If
    End Sub


    Public Sub LoadUsers()
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        Dim dr = db.dr
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT iduser as 'User ID#', username as 'Username', password as 'Password', email as 'Email' FROM users"
        dr = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(dr)
        dgvUsers.DataSource = dt
        db.Close()
    End Sub
    Private Function CheckExistAdmin() As Boolean
        Dim db As New DBClass
        db.Open()

        Dim cmd = db.cmd
        Dim dr = db.dr
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT COUNT(*) as c FROM admin"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                If dr("c") <> 0 Then
                    Return True
                Else
                    Return False
                End If
            End While
        End If
        Return False
        db.Close()
    End Function


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If tbUser.Text <> "" AndAlso tbPassword.Text <> "" Then
            If dgvUsers.Rows.Count <> 0 Then
                Dim u As New UserClass
                u.User = tbUser.Text
                u.Pass = tbPassword.Text
                u.UpdateUser(dgvUsers.CurrentRow.Cells(0).Value)
                LoadUsers()
                tbUser.Clear()
                tbPassword.Clear()
                tbUser.Enabled = False
                tbPassword.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvUsers.Rows.Count <> 0 Then
            Dim u As New UserClass
            u.DeleteUser(dgvUsers.CurrentRow.Cells(0).Value)
            LoadUsers()
            tbUser.Clear()
            tbPassword.Clear()
            tbUser.Enabled = False
            tbPassword.Enabled = False
        End If
    End Sub

    Private Sub dgvUsers_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvUsers.MouseClick
        tbUser.Enabled = True
        tbPassword.Enabled = True
        tbUser.Text = dgvUsers.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tbAdminUsername.Text <> "" AndAlso tbAdminPassword.Text <> "" Then
            If btnLogin.Text = "Set" Then
                Dim en As New encryptClass
                en.hashProp = tbAdminPassword.Text
                Dim a As New AdminClass
                a.AdminUsername = tbAdminUsername.Text
                a.AdminPassword = en.hashProp
                a.SetAdmin()
                AfterAdminSet()
            Else
                Dim en As New encryptClass
                en.hashProp = tbAdminPassword.Text
                Dim a As New AdminClass
                a.AdminUsername = tbAdminUsername.Text
                a.AdminPassword = en.hashProp
                id = a.AdminLogin()
                If id <> 0 Then
                    a.SetLoginIndicator(id)
                    LoadUsers()
                    gbLogin.Visible = False
                    gbHidden.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub AfterAdminSet()
        tbAdminPassword.Clear()
        tbAdminPassword.PasswordChar = "?"
        tbAdminUsername.PasswordChar = "?"
        tbAdminUsername.Clear()
        btnLogin.Text = "Login"
    End Sub

    Private Sub AdminUserManagement_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If id <> 0 Then
            Dim a As New AdminClass
            a.SetLogoutIndicator()
        End If
    End Sub
End Class