Imports MySql.Data.MySqlClient

Public Class CourseClass
    Private Name As String
    Public Property CourseName() As String
        Get
            Return Name
        End Get
        Set(ByVal value As String)
            Name = value
        End Set
    End Property

    Private Code As String
    Public Property CourseCode() As String
        Get
            Return Code
        End Get
        Set(ByVal value As String)
            Code = value
        End Set
    End Property

    Public Function AddCourse() As Integer
        dbconn.Open()
        Dim cmd As New MySqlCommand
        cmd.Connection = Conn
        cmd.CommandText = "INSERT INTO course (course_name, course_code) VALUES (@CN, @CC)"
        cmd.Parameters.AddWithValue("@CN", Name)
        cmd.Parameters.AddWithValue("@CC", Code.ToUpper)
        If cmd.ExecuteNonQuery Then
            MessageBox.Show("New course added.")
            Return 1
        Else
            MessageBox.Show("Something went wrong. Try again.")
            Return 0
        End If

        dbconn.Close()
    End Function

    Public Function EditCourse(ccc As String) As Integer
        dbconn.Open()
        Dim cmd As New MySqlCommand
        cmd.Connection = Conn
        cmd.CommandText = "UPDATE course SET course_name = @CN, course_code = @CC WHERE course_code = @CCC"
        cmd.Parameters.AddWithValue("@CN", Name)
        cmd.Parameters.AddWithValue("@CC", Code.ToUpper)
        cmd.Parameters.AddWithValue("@CCC", ccc)
        If cmd.ExecuteNonQuery Then
            MessageBox.Show("Course details successfully updated.")
            Return 1
        Else
            MessageBox.Show("Something went wrong. Try again.")
            Return 0
        End If

        dbconn.Close()
    End Function

    Public Function DeleteCourse(ccc As String) As Integer
        dbconn.Open()
        Dim cmd As New MySqlCommand
        cmd.Connection = Conn
        cmd.CommandText = "DELETE FROM course WHERE course_code = @CCC"

        cmd.Parameters.AddWithValue("@CCC", ccc)
        If cmd.ExecuteNonQuery Then
            MessageBox.Show("Course successfully deleted.")
            Return 1
        Else
            MessageBox.Show("Something went wrong. Try again.")
            Return 0
        End If

        dbconn.Close()
    End Function
End Class
