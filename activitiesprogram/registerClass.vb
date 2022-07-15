Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class registerClass
    Private Username As String
    Private Password As String
    Private Email As String
    Public Property UsernameProp() As String
        Get
            Return Username
        End Get
        Set(ByVal value As String)
            Username = value
        End Set
    End Property
    Public Property PasswordProp() As String
        Get
            Return Password
        End Get
        Set(ByVal value As String)
            Password = value
        End Set
    End Property

    Public Property EmailProp() As String
        Get
            Return Email
        End Get
        Set(ByVal value As String)
            Email = value
        End Set
    End Property

    Public Sub Register()

        dbconn.Open()
        Dim cmd As New MySqlCommand
        cmd.Connection = Conn
        cmd.CommandText = "INSERT INTO users (username, password, email) VALUES (@un, @pw, @em)"
        cmd.Parameters.AddWithValue("@un", UsernameProp)
        Dim h As New encryptClass
        h.hashProp = PasswordProp
        cmd.Parameters.AddWithValue("@pw", h.hashProp)
        cmd.Parameters.AddWithValue("@em", EmailProp)
        If cmd.ExecuteNonQuery Then
            MessageBox.Show("New user has successfully registered. Please login.")
        Else
            MessageBox.Show("Something went wrong. Please try again.")
        End If
        dbconn.Close()
    End Sub

End Class
