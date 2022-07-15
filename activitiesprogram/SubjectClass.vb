Imports MySql.Data.MySqlClient

Public Class SubjectClass
    Private Name As String
    Public Property SubjectName() As String
        Get
            Return Name
        End Get
        Set(ByVal value As String)
            Name = value
        End Set
    End Property

    Private Units As Decimal
    Public Property SubjectUnits() As Decimal
        Get
            Return Units
        End Get
        Set(ByVal value As Decimal)
            Units = value
        End Set
    End Property

    Public Function AddSubject() As Integer
        dbconn.Open()
        Dim cmd As New MySqlCommand
        cmd.Connection = Conn
        cmd.CommandText = "INSERT INTO subject (subject_name, units) VALUES (@SN, @U)"
        cmd.Parameters.AddWithValue("@SN", SubjectName)
        cmd.Parameters.AddWithValue("@U", SubjectUnits)
        If cmd.ExecuteNonQuery Then
            MessageBox.Show("New subject was successfully added.")
            Return 1
        Else
            MessageBox.Show("Something went wrong. Please try again.")
            Return 0
        End If
        dbconn.Close()
    End Function

    Public Function EditSubject(id As Integer) As Integer
        dbconn.Open()
        Dim cmd As New MySqlCommand
        cmd.Connection = Conn
        cmd.CommandText = "UPDATE subject SET subject_name = @SN, units = @U WHERE idsubject = @ID"
        cmd.Parameters.AddWithValue("@SN", SubjectName)
        cmd.Parameters.AddWithValue("@U", SubjectUnits)
        cmd.Parameters.AddWithValue("@ID", id)
        If cmd.ExecuteNonQuery Then
            MessageBox.Show("Selected subject was successfully updated.")
            Return 1
        Else
            MessageBox.Show("Something went wrong. Please try again.")
            Return 0
        End If
        dbconn.Close()
    End Function
    Public Function DeleteSubject(id As Integer) As Integer
        dbconn.Open()
        Dim cmd As New MySqlCommand
        cmd.Connection = Conn
        cmd.CommandText = "DELETE FROM subject WHERE idsubject = @ID"
        cmd.Parameters.AddWithValue("@ID", id)
        If cmd.ExecuteNonQuery Then
            MessageBox.Show("Selected subject was deleted successfully.")
            Return 1
        Else
            MessageBox.Show("Something went wrong. Please try again.")
            Return 0
        End If
        dbconn.Close()
    End Function
End Class
