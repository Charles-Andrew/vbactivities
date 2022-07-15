Imports MySql.Data.MySqlClient
Public Class SchoolYearClass
    Private SchoolYear As String
    Public Property SchoolYearProp() As String
        Get
            Return SchoolYear
        End Get
        Set(ByVal value As String)
            SchoolYear = value
        End Set
    End Property

    Public Sub AddSchoolYear()
        dbconn.Open()
        Dim cmd As New MySqlCommand
        cmd.Connection = Conn

        cmd.CommandText = "INSERT INTO schoolyear_sem (year, sem) VALUES (@y1, @s1)"
        cmd.Parameters.AddWithValue("@y1", SchoolYearProp)
        cmd.Parameters.AddWithValue("@s1", "1st")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "INSERT INTO schoolyear_sem (year, sem) VALUES (@y2, @s2)"
        cmd.Parameters.AddWithValue("@y2", SchoolYearProp)
        cmd.Parameters.AddWithValue("@s2", "2nd")
        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("School year specified was successfully added.")
        Else
            MessageBox.Show("Something went wrong. Please try again.")
        End If

        dbconn.Close()
    End Sub
End Class
