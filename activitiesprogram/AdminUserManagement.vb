Public Class AdminUserManagement
    Private Sub AdminUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tbSecretKey_TextChanged(sender As Object, e As EventArgs) Handles tbSecretKey.TextChanged
        Dim en As New encryptClass
        en.hashProp = tbSecretKey.Text
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        Dim dr = db.dr
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT * FROM secretkey WHERE secretkey = @KEY"
        cmd.Parameters.AddWithValue("@KEY", en.hashProp)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            gbHidden.Visible = True
            LoadUsers()
        Else
            gbHidden.Visible = False
        End If

        db.Close()
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
    Private Function CheckExistKey() As Boolean
        Dim db As New DBClass
        db.Open()

        Dim cmd = db.cmd
        Dim dr = db.dr
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT COUNT(*) as c FROM secretkey"
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

    Private Sub lblSecretKey_DoubleClick(sender As Object, e As EventArgs) Handles lblSecretKey.DoubleClick
        Dim en As New encryptClass
        en.hashProp = tbSecretKey.Text
        If CheckExistKey() Then
            Dim db As New DBClass
            db.Open()
            Dim cmd = db.cmd
            cmd.Connection = db.conn
            cmd.CommandText = "UPDATE secretkey SET secretkey = @KEY"
            cmd.Parameters.AddWithValue("@KEY", en.hashProp)
            cmd.ExecuteNonQuery()
            db.Close()
        Else
            Dim db As New DBClass
            db.Open()
            Dim cmd = db.cmd
            cmd.Connection = db.conn
            cmd.CommandText = "INSERT INTO secretkey (secretkey) VALUES (@KEY)"
            cmd.Parameters.AddWithValue("@KEY", en.hashProp)
            cmd.ExecuteNonQuery()
            db.Close()
        End If
    End Sub

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
End Class