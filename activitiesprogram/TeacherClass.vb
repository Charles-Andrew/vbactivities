Imports MySql.Data.MySqlClient

Public Class TeacherClass
    Private FirstName As String
    Public Property TeacherFirstName() As String
        Get
            Return FirstName
        End Get
        Set(ByVal value As String)
            FirstName = value
        End Set
    End Property

    Private MiddleName As String
    Public Property TeacherMiddleName() As String
        Get
            Return MiddleName
        End Get
        Set(ByVal value As String)
            MiddleName = value
        End Set
    End Property

    Private LastName As String
    Public Property TeacherLastName() As String
        Get
            Return LastName
        End Get
        Set(ByVal value As String)
            LastName = value
        End Set
    End Property


    Public Function AddTeacher() As Integer
        dbconn.Open()
        Dim cmd As New MySqlCommand
        cmd.Connection = Conn
        cmd.CommandText = "INSERT INTO teacher (FName, MName, LName) VALUES (@FN, @MN, @LN)"
        cmd.Parameters.AddWithValue("@FN", TeacherFirstName)
        cmd.Parameters.AddWithValue("@MN", TeacherMiddleName)
        cmd.Parameters.AddWithValue("@LN", TeacherLastName)
        If cmd.ExecuteNonQuery Then
            MessageBox.Show("New record added.")
            Return 1
        Else
            MessageBox.Show("Something went wrong. Try again.")
            Return 0
        End If

        dbconn.Close()
    End Function

    Public Function EditTeacher(id As Integer) As Integer
        dbconn.Open()
        Dim cmd As New MySqlCommand
        cmd.Connection = Conn
        cmd.CommandText = "UPDATE teacher SET FName = @FN, MName = @MN, LName = @LN WHERE idteacher = @id"
        cmd.Parameters.AddWithValue("@FN", TeacherFirstName)
        cmd.Parameters.AddWithValue("@MN", TeacherMiddleName)
        cmd.Parameters.AddWithValue("@LN", TeacherLastName)
        cmd.Parameters.AddWithValue("@id", id)
        If cmd.ExecuteNonQuery Then
            MessageBox.Show("New record updated.")
            Return 1
        Else
            MessageBox.Show("Something went wrong. Try again.")
            Return 0
        End If

        dbconn.Close()
    End Function

    Public Function DeleteTeacher(id As Integer) As Integer
        Try
            dbconn.Open()
            Dim cmd As New MySqlCommand
            cmd.Connection = Conn
            cmd.CommandText = "DELETE FROM teacher WHERE idteacher = @id"
            cmd.Parameters.AddWithValue("@id", id)
            If cmd.ExecuteNonQuery Then
                MessageBox.Show("Selected record was successfully deleted.")
                Return 1
            Else
                MessageBox.Show("Something went wrong. Try again.")
                Return 0
            End If

            dbconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return 0
    End Function
End Class
