Imports MySql.Data.MySqlClient

Public Class DBClass
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public Sub Open()
        Close()
        conn.ConnectionString = "server=localhost;user id=root;password='';database=activitydb;"
        conn.Open()
    End Sub
    Public Sub Close()
        conn.Close()
    End Sub
End Class
