Imports MySql.Data.MySqlClient

Public Class StudentMasterList
    Private Sub StudentMasterList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentData()
    End Sub
    Private Sub LoadStudentData()
        dbconn.Open()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim dt As New DataTable

        cmd.Connection = Conn
        cmd.CommandText = "SELECT s.idstudent, s.LName, s.FName, s.MName, s.Gender, s.DOB, s.ParentName, s.Address, s.ContactNo, (SELECT CONCAT(year,' ', sem, ' semester') as sem FROM schoolyear_sem WHERE idsy = sc.idsy) as Current_Sem, (SELECT course_code FROM course where idcourse = sc.idcourse) as Course, sc.year_level, sc.status FROM student as s JOIN stud_course as sc WHERE s.idstudent = sc.idstudent;"
        dr = cmd.ExecuteReader

        dt.Load(dr)
        dgvStudentViewer.DataSource = dt

        dbconn.Close()

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim sa As New StudentForm()
        sa.ShowDialog()
        LoadStudentData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Dim su As New StudentForm()
        su.Text = "Update Student"
        su.btnAdd.Text = "Update Record"
        su.tempid = dgvStudentViewer.CurrentRow.Cells(0).Value.ToString
        su.tbLN.Text = dgvStudentViewer.CurrentRow.Cells(1).Value.ToString
        su.tbFN.Text = dgvStudentViewer.CurrentRow.Cells(2).Value.ToString
        su.tbMN.Text = dgvStudentViewer.CurrentRow.Cells(3).Value.ToString
        If dgvStudentViewer.CurrentRow.Cells(4).Value.ToString = "Male" Then
            su.rbMale.Checked = True
        ElseIf dgvStudentViewer.CurrentRow.Cells(4).Value.ToString = "Female" Then
            su.rbFemale.Checked = True
        End If
        su.dtpDOB.Value = dgvStudentViewer.CurrentRow.Cells(5).Value
        su.tbPN.Text = dgvStudentViewer.CurrentRow.Cells(6).Value.ToString
        su.tbAddress.Text = dgvStudentViewer.CurrentRow.Cells(7).Value.ToString
        su.tbCN.Text = dgvStudentViewer.CurrentRow.Cells(8).Value.ToString
        su.ShowDialog()
        LoadStudentData()


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim TempID As String = dgvStudentViewer.CurrentRow.Cells(0).Value.ToString
        Dim m As DialogResult = MessageBox.Show("Are you sure you want to delete record with Student ID: " +
                                                TempID, "Delete Confimation", MessageBoxButtons.OKCancel)
        If m = DialogResult.OK Then
            Dim s As New StudentClass
            s.DeleteStudent(Integer.Parse(TempID))
            LoadStudentData()
        End If
    End Sub
End Class