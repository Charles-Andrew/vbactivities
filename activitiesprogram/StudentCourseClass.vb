Imports MySql.Data.MySqlClient
Public Class StudentCourseClass
    Private id As Integer
    Public Property StudentID() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property

    Private schoolyear As Integer
    Public Property StudentSY() As Integer
        Get
            Return schoolyear
        End Get
        Set(ByVal value As Integer)
            schoolyear = value
        End Set
    End Property

    Private idcourse As Integer
    Public Property StudentCourse() As Integer
        Get
            Return idcourse
        End Get
        Set(ByVal value As Integer)
            idcourse = value
        End Set
    End Property

    Private yearlevel As String
    Public Property StudentYearLevel() As String
        Get
            Return yearlevel
        End Get
        Set(ByVal value As String)
            yearlevel = value
        End Set
    End Property

    Private status As String
    Public Property StudentStatus() As String
        Get
            Return status
        End Get
        Set(ByVal value As String)
            status = value
        End Set
    End Property

    Public Sub AddStudCourse()
        Dim db As New DBClass
        db.Open()
        Dim cmd As New MySqlCommand
        cmd.Connection = db.conn
        cmd.CommandText = "INSERT INTO stud_course (idstudent, idsy, idcourse, year_level, status)
                           VALUES (@idstudent, @idsy, @idcourse, @yl, @status); "
        cmd.Parameters.AddWithValue("@idstudent", StudentID)
        cmd.Parameters.AddWithValue("@idsy", StudentSY)
        cmd.Parameters.AddWithValue("@idcourse", StudentCourse)
        cmd.Parameters.AddWithValue("@yl", StudentYearLevel)
        cmd.Parameters.AddWithValue("@status", StudentStatus)
        cmd.ExecuteNonQuery()
        db.Close()
    End Sub

    Public Sub EditStudCourse(id As Integer)
        Dim db As New DBClass
        db.Open()
        Dim cmd As New MySqlCommand
        cmd.Connection = db.conn
        cmd.CommandText = "UPDATE stud_course SET idsy = @idsy, idcourse = @idcourse, year_level = @yl, status = @status
                           WHERE idstudent = @idstudent"
        cmd.Parameters.AddWithValue("@idstudent", id)
        cmd.Parameters.AddWithValue("@idsy", StudentSY)
        cmd.Parameters.AddWithValue("@idcourse", StudentCourse)
        cmd.Parameters.AddWithValue("@yl", StudentYearLevel)
        cmd.Parameters.AddWithValue("@status", StudentStatus)
        cmd.ExecuteNonQuery()
        db.Close()
    End Sub
End Class
