﻿Public Class TeacherClassManagementClass
    Private SubjectID As Integer
    Public Property COSubjectID() As Integer
        Get
            Return SubjectID
        End Get
        Set(ByVal value As Integer)
            SubjectID = value
        End Set
    End Property

    Private SchoolYearID As Integer
    Public Property COSchoolYear() As Integer
        Get
            Return SchoolYearID
        End Get
        Set(ByVal value As Integer)
            SchoolYearID = value
        End Set
    End Property

    Private TeacherID As Integer
    Public Property COTeacherID() As Integer
        Get
            Return TeacherID
        End Get
        Set(ByVal value As Integer)
            TeacherID = value
        End Set
    End Property

    Private Day As String
    Public Property CODay() As String
        Get
            Return Day
        End Get
        Set(ByVal value As String)
            Day = value
        End Set
    End Property

    Private Time As String
    Public Property COTime() As String
        Get
            Return Time
        End Get
        Set(ByVal value As String)
            Time = value
        End Set
    End Property

    Private Room As String
    Public Property CORoom() As String
        Get
            Return Room
        End Get
        Set(ByVal value As String)
            Room = value
        End Set
    End Property

    Public Sub AddClass()
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn

        cmd.CommandText = "INSERT INTO class_offering (idsubject, idsy, idteacher, day, time, room)
                              VALUES (@idsubject, @idsy, @idteacher, @day, @time, @room)"
        cmd.Parameters.AddWithValue("@idsubject", COSubjectID)
        cmd.Parameters.AddWithValue("@idsy", COSchoolYear)
        cmd.Parameters.AddWithValue("@idteacher", COTeacherID)
        cmd.Parameters.AddWithValue("@day", CODay)
        cmd.Parameters.AddWithValue("@time", COTime)
        cmd.Parameters.AddWithValue("@room", CORoom)
        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("New class created successfully.")
        End If
        db.Close()
    End Sub

    Public Sub UpdateClass(id As Integer)
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn

        cmd.CommandText = "UPDATE class_offering SET idsubject = @idsubject, idsy = @idsy, 
                           idteacher = @idteacher, day = @day, time = @time, room = @room WHERE 
                           idclass_offering = @id"
        cmd.Parameters.AddWithValue("@idsubject", COSubjectID)
        cmd.Parameters.AddWithValue("@idsy", COSchoolYear)
        cmd.Parameters.AddWithValue("@idteacher", COTeacherID)
        cmd.Parameters.AddWithValue("@day", CODay)
        cmd.Parameters.AddWithValue("@time", COTime)
        cmd.Parameters.AddWithValue("@room", CORoom)
        cmd.Parameters.AddWithValue("@id", id)
        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("Successfully updated selected class.")
        End If
        db.Close()
    End Sub

    Public Sub DeleteClass(id As Integer)
        Try
            Dim db As New DBClass
            db.Open()
            Dim cmd = db.cmd
            cmd.Connection = db.conn

            cmd.CommandText = "DELETE FROM class_offering WHERE idclass_offering = @id"
            cmd.Parameters.AddWithValue("@id", id)
            If cmd.ExecuteNonQuery() Then
                MessageBox.Show("Successfully deleted selected class.")
            End If
            db.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
