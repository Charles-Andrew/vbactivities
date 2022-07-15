Imports MySql.Data.MySqlClient

Module dbconn
    Public Conn As New MySqlConnection

    Public Sub Open()
        Try
            Close()
            Conn.ConnectionString = "server=localhost;user id=root;password='';database=activitydb;"
            Conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Close()
        Try
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Module
