Public Class AdminClass
    Private username As String
    Public Property AdminUsername() As String
        Get
            Return username
        End Get
        Set(ByVal value As String)
            username = value
        End Set
    End Property

    Private password As String
    Public Property AdminPassword() As String
        Get
            Return password
        End Get
        Set(ByVal value As String)
            password = value
        End Set
    End Property


    Public Sub SetAdmin()
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "INSERT INTO admin (username, password) VALUES (@UN, @PW)"
        cmd.Parameters.AddWithValue("@UN", AdminUsername)
        cmd.Parameters.AddWithValue("@PW", AdminPassword)
        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("Admin was successfuly set.")
        End If
        db.Close()
    End Sub

    Public Function AdminLogin() As Integer
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        Dim dr = db.dr
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT * FROM admin WHERE username=@UN AND password=@PW"
        cmd.Parameters.AddWithValue("@UN", AdminUsername)
        cmd.Parameters.AddWithValue("@PW", AdminPassword)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                Return dr("idadmin")
            End While
        Else
            MessageBox.Show("Incorrect admin credentials.")
            Return 0
        End If
        Return 0
        db.Close()
    End Function

    Public Sub SetLoginIndicator(id As Integer)
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "UPDATE admin SET isloggedin = 1 WHERE idadmin = @ID"
        cmd.Parameters.AddWithValue("@ID", id)
        cmd.ExecuteNonQuery()
        db.Close()
    End Sub
    Public Sub SetLogoutIndicator()
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "UPDATE admin SET isloggedin = 0 WHERE isloggedin = 1"
        cmd.ExecuteNonQuery()
        db.Close()
    End Sub
End Class
