Public Class ModifyGradeClass
    Private mgrade As Integer
    Public Property Midterm() As Integer
        Get
            Return mgrade
        End Get
        Set(ByVal value As Integer)
            mgrade = value
        End Set
    End Property
    Private fgrade As Integer
    Public Property Final() As Integer
        Get
            Return fgrade
        End Get
        Set(ByVal value As Integer)
            fgrade = value
        End Set
    End Property
    Private agrade As String
    Public Property Average() As String
        Get
            If Midterm = 0 OrElse Final = 0 Then
                Return agrade
            Else
                Return (Midterm + Final) / 2
            End If
        End Get
        Set(ByVal value As String)
            agrade = value
        End Set
    End Property

    Private remarks As String
    Public Property StudentRemarks() As String
        Get
            Return remarks
        End Get
        Set(ByVal value As String)
            remarks = value
        End Set
    End Property

    Public Sub UpdateGrade(ids As Integer, ico As Integer)
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn
        cmd.CommandText = "UPDATE student_enroll_class SET midterm_grade = @MG, finals_grade = @FG, FinalGrade = @AVG, remarks = @RM
                           WHERE idstudent = @ids AND idclass_offering = @ico"
        cmd.Parameters.AddWithValue("@MG", Midterm)
        cmd.Parameters.AddWithValue("@FG", Final)
        cmd.Parameters.AddWithValue("@AVG", Average)
        cmd.Parameters.AddWithValue("@RM", StudentRemarks)
        cmd.Parameters.AddWithValue("@ids", ids)
        cmd.Parameters.AddWithValue("@ico", ico)
        If cmd.ExecuteNonQuery Then
            MessageBox.Show("Selected student grade successfully updated.")
        Else
            MessageBox.Show("Something went wrong. Please try again.")
        End If

        db.Close()

    End Sub

End Class
