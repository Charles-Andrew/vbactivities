Public Class StudentSubjectManagementForm
    Public StudentID As Integer = 0
    Public StudentName As String = ""
    Private Sub StudentSubjectManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog

        LoadInitItems()
        If cbAvailableSubjects.Text = "" Then
            btnEnroll.Enabled = False
        End If
    End Sub
    Private Sub LoadInitItems()
        LoadName()
        LoadAvailableClass()
        LoadEnrolledClass()
    End Sub
    Private Sub LoadName()
        If StudentName <> "" Then
            lblStudentName.Text = StudentName
        End If
    End Sub
    Private Sub LoadEnrolledClass()
        'Error with retrieving not enrolled class
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        Dim dr = db.dr
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT co.idclass_offering as 'Class ID', CONCAT(s.subject_name, ' (',s.units,') Units ') as 'Subject Details', 
                           co.day as 'Day', sec.midterm_grade as 'Midterm Grade', sec.finals_grade as 'Finals Grade', 
                           sec.FinalGrade as 'Final Grade', sec.remarks as 'Remarks' FROM class_offering as co JOIN subject as s 
                           JOIN teacher as t JOIN student_enroll_class as sec WHERE co.idsubject = s.idsubject AND co.idteacher = t.idteacher 
                           AND sec.idclass_offering = co.idclass_offering AND sec.idstudent = @idstudent AND co.idsy = (SELECT * FROM active_sy)"
        cmd.Parameters.AddWithValue("@idstudent", StudentID)
        dr = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(dr)

        dgvStudentSubjects.DataSource = dt

        db.Close()
    End Sub
    Private Sub LoadAvailableClass()
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        Dim dr = db.dr
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT co.idclass_offering, CONCAT(s.subject_name, ' (',s.units,') Units ', co.day, ' (Room ', co.room,')') as SD 
                           FROM class_offering as co JOIN subject as s JOIN teacher as t WHERE co.idsubject = s.idsubject AND co.idteacher = t.idteacher
                           AND co.idclass_offering NOT IN (SELECT idclass_offering FROM student_enroll_class WHERE idstudent = @idstudent) AND s.idsubject NOT IN 
                           (SELECT s.idsubject FROM class_offering as co JOIN subject as s 
                           JOIN teacher as t JOIN student_enroll_class as sec WHERE co.idsubject = s.idsubject AND co.idteacher = t.idteacher 
                           AND sec.idclass_offering = co.idclass_offering AND sec.idstudent = @idstudent) AND co.idsy = (SELECT * FROM active_sy)"
        cmd.Parameters.AddWithValue("@idstudent", StudentID)
        dr = cmd.ExecuteReader

        Dim dt As New DataTable
        dt.Load(dr)
        cbAvailableSubjects.DataSource = dt
        cbAvailableSubjects.DisplayMember = "SD"
        cbAvailableSubjects.ValueMember = "idclass_offering"
        db.Close()
        lblTotalUnits.Text = "Total Units: " + ShowTotalUnits().ToString
    End Sub

    Private Function ShowTotalUnits() As Double
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        Dim dr = db.dr
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT sum(s.units) as TU FROM class_offering as co JOIN subject as s 
                           JOIN teacher as t JOIN student_enroll_class as sec WHERE co.idsubject = s.idsubject AND co.idteacher = t.idteacher 
                           AND sec.idclass_offering = co.idclass_offering AND sec.idstudent = @idstudent"
        cmd.Parameters.AddWithValue("@idstudent", StudentID)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                Return dr("TU")
            End While
        End If
        Return 0.0
    End Function

    Private Function RestrictOnUnits() As Boolean
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        Dim dr = db.dr
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT * FROM class_offering as co JOIN subject as s WHERE co.idsubject = s.idsubject AND idclass_offering = @IDCO"
        cmd.Parameters.AddWithValue("@IDCO", cbAvailableSubjects.SelectedValue)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                If dr("units") >= (31 - ShowTotalUnits()) Then
                Else
                    btnEnroll.Enabled = True
                    Return True
                End If
            End While
        End If
        Return False
        db.Close()
    End Function

    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
        If RestrictOnUnits() Then
            Dim ssmc As New StudentSubjectManagementClass
            ssmc.StudentID = StudentID
            ssmc.ClassOfferID = cbAvailableSubjects.SelectedValue
            ssmc.Enroll()
            LoadAvailableClass()
            LoadEnrolledClass()
        Else
            MessageBox.Show("A student only have a maximum of 31 units per semester.")
        End If
    End Sub

    Private Sub btnUnenroll_Click(sender As Object, e As EventArgs) Handles btnUnenroll.Click
        If dgvStudentSubjects.Rows.Count <> 0 Then
            Dim m As DialogResult = MessageBox.Show("Are you sure you want to unenroll this subject?", "Removal Confimation", MessageBoxButtons.OKCancel)
            If m = DialogResult.OK Then
                Dim ItemtoDelete = dgvStudentSubjects.CurrentRow.Cells(0).Value
                Dim ssmc As New StudentSubjectManagementClass
                ssmc.StudentID = StudentID
                ssmc.ClassOfferID = ItemtoDelete
                ssmc.UnEnroll()
                LoadAvailableClass()
                LoadEnrolledClass()
            End If
        End If
    End Sub
End Class