﻿Imports MySql.Data.MySqlClient

Public Class StudentMasterList
    Public Admin As Boolean = False
    Private Sub StudentMasterList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog

        LoadStudentData()
        If Not Admin Then
            btnDelete.Enabled = False
        End If
    End Sub
    Private Sub LoadStudentData()
        dbconn.Open()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim dt As New DataTable

        cmd.Connection = Conn
        cmd.CommandText = "SELECT s.idstudent as 'Student ID', s.LName as 'Last Name', s.FName as 'First Name'
                           , s.MName as 'Middle Name', s.Gender as 'Gender', s.DOB as 'Birthday', 
                           s.ParentName as 'Parent Name', s.Address as 'Address', s.ContactNo as 'Cellphone Number'
                           , (SELECT CONCAT(year,' ', sem, ' Semester') as sem FROM schoolyear_sem WHERE idsy = sc.idsy) as Current_Sem, 
                           (SELECT course_code FROM course where idcourse = sc.idcourse) as Course, sc.year_level as 'Year Level', 
                           sc.status as 'Status' FROM student as s JOIN stud_course as sc WHERE s.idstudent = sc.idstudent;"
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
        If dgvStudentViewer.Rows.Count <> 0 Then
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
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvStudentViewer.Rows.Count <> 0 Then
            Dim TempID As String = dgvStudentViewer.CurrentRow.Cells(0).Value.ToString
            Dim m As DialogResult = MessageBox.Show("Are you sure you want to delete record with Student ID: " +
                                                    TempID, "Delete Confimation", MessageBoxButtons.OKCancel)
            If m = DialogResult.OK Then
                Dim s As New StudentClass
                s.DeleteStudent(Integer.Parse(TempID))
                LoadStudentData()
            End If
        End If
    End Sub

    Private Sub btnManageSubjects_Click(sender As Object, e As EventArgs) Handles btnManageSubjects.Click
        If dgvStudentViewer.Rows.Count <> 0 Then
            Dim ssmf As New StudentSubjectManagementForm
            ssmf.StudentID = dgvStudentViewer.CurrentRow.Cells(0).Value
            ssmf.StudentName = dgvStudentViewer.CurrentRow.Cells(2).Value + " " + dgvStudentViewer.CurrentRow.Cells(3).Value + " " + dgvStudentViewer.CurrentRow.Cells(1).Value
            ssmf.ShowDialog()
        End If
    End Sub
End Class