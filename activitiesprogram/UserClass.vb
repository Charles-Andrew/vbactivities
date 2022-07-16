Public Class UserClass
    Private username As String
    Public Property User() As String
        Get
            Return username
        End Get
        Set(ByVal value As String)
            username = value
        End Set
    End Property

    Private password As String
    Public Property Pass() As String
        Get
            Dim en As New encryptClass
            en.hashProp = password
            Return en.hashProp
        End Get
        Set(ByVal value As String)
            password = value
        End Set
    End Property

    Public Sub UpdateUser(id As Integer)
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "UPDATE users SET username = @UN, password = @PW WHERE iduser = @ID"
        cmd.Parameters.AddWithValue("@UN", User)
        cmd.Parameters.AddWithValue("@PW", Pass)
        cmd.Parameters.AddWithValue("@ID", id)

        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("User updated.")
        Else
            MessageBox.Show("Something went wrong :(")
        End If
        db.Close()
    End Sub
    Public Sub DeleteUser(id As Integer)
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "DELETE FROM users WHERE iduser = @ID"
        cmd.Parameters.AddWithValue("@ID", id)

        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("User deleted.")
        Else
            MessageBox.Show("Something went wrong :(")
        End If
        db.Close()
    End Sub
End Class
