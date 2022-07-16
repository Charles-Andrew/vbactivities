Public Class StudentSubjectManagementClass
    Private id As Integer
    Public Property StudentID() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property

    Private ClassID As Integer
    Public Property ClassOfferID() As Integer
        Get
            Return ClassID
        End Get
        Set(ByVal value As Integer)
            ClassID = value
        End Set
    End Property

    Public Sub Enroll()
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd

        cmd.Connection = db.conn
        cmd.CommandText = "INSERT INTO student_enroll_class (idstudent, idclass_offering)
                           VALUES (@idstudent, @ico)"
        cmd.Parameters.AddWithValue("@idstudent", StudentID)
        cmd.Parameters.AddWithValue("@ico", ClassOfferID)
        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("Selected subject successfully enrolled.")
        Else
            MessageBox.Show("Something went wrong. Try again.")
        End If
        db.Close()
    End Sub

    Public Sub UnEnroll()
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd

        cmd.Connection = db.conn
        cmd.CommandText = "DELETE FROM student_enroll_class WHERE idstudent = @idstudent AND idclass_offering = @ico"
        cmd.Parameters.AddWithValue("@idstudent", StudentID)
        cmd.Parameters.AddWithValue("@ico", ClassOfferID)
        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("Selected subject successfully unenrolled.")
        Else
            MessageBox.Show("Something went wrong. Try again.")
        End If
        db.Close()
    End Sub

End Class
