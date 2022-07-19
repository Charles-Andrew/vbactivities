Public Class ClassInformation
    Public ClassID As Integer = 0
    Private Sub ClassInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ClassID <> 0 Then
            ClassLoad()
            InfoLoad()
        End If
    End Sub
    Private Sub InfoLoad()
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        Dim dr = db.dr

        cmd.Connection = db.conn
        cmd.CommandText = "SELECT * FROM class_offering as co JOIN subject as s WHERE co.idsubject = s.idsubject AND co.idclass_offering =@idco"

        cmd.Parameters.AddWithValue("@idco", ClassID)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                lblValName.Text = dr("subject_name").ToString
                lblValSched.Text = dr("day").ToString
                lblValTime.Text = dr("time").ToString
            End While
        End If

    End Sub
    Private Sub ClassLoad()
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        Dim dr = db.dr

        cmd.Connection = db.conn
        cmd.CommandText = "SELECT s.idstudent as 'Student ID', CONCAT(s.FName,' ',s.MName,' ',s.Lname) as 'Student Name', 
                           c.course_code as 'Course', sc.year_level as 'Year Level', sec.midterm_grade as 'Midterm Grade', 
                           sec.finals_grade as 'Finals Grade', sec.FinalGrade as 'Final Grade', sec.remarks as 'Remarks' 
                           FROM student_enroll_class as sec JOIN class_offering as co JOIN student as s JOIN course as c 
                           JOIN stud_course as sc WHERE sec.idclass_offering = co.idclass_offering AND sec.idstudent = s.idstudent 
                           AND sc.idstudent = s.idstudent AND sc.idcourse = c.idcourse AND co.idclass_offering = @CID;"
        cmd.Parameters.AddWithValue("@CID", ClassID)
        dr = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(dr)
        dgvStudentView.DataSource = dt

        db.Close()

        lblStudentCount.Text = "Total # of student/s: " + dgvStudentView.Rows.Count.ToString

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If dgvStudentView.Rows.Count <> 0 Then
            Dim mg As New ModifyGrades
            mg.StudentID = dgvStudentView.CurrentRow.Cells(0).Value
            mg.NameOfUser = dgvStudentView.CurrentRow.Cells(1).Value.ToString
            mg.tbMt.Text = dgvStudentView.CurrentRow.Cells(4).Value
            mg.tbFg.Text = dgvStudentView.CurrentRow.Cells(5).Value
            mg.tbAvg.Text = dgvStudentView.CurrentRow.Cells(6).Value
            mg.tbRemarks.Text = dgvStudentView.CurrentRow.Cells(7).Value.ToString
            mg.ClassID = ClassID

            mg.ShowDialog()
            ClassLoad()
        End If
    End Sub

    Private Sub btnDrop_Click(sender As Object, e As EventArgs) Handles btnDrop.Click
        If dgvStudentView.Rows.Count <> 0 Then
            Dim m As DialogResult = MessageBox.Show("Are you sure you want to drop the selected student?", "Student Drop Confimation", MessageBoxButtons.YesNo)

            If m = DialogResult.Yes Then
                Dim ssmc As New StudentSubjectManagementClass
                ssmc.StudentID = dgvStudentView.CurrentRow.Cells(0).Value
                ssmc.ClassOfferID = ClassID
                ssmc.UnEnroll()
                ClassLoad()
            End If
        End If
    End Sub
End Class