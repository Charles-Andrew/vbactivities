Imports MySql.Data.MySqlClient

Public Class CourseManagement
    Private Sub CourseManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBLoadData()
    End Sub

    Private Sub CBLoadData()
        dbconn.Open()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim dt As New DataTable

        cmd.Connection = Conn
        cmd.CommandText = "SELECT * FROM course"
        dr = cmd.ExecuteReader

        dt.Load(dr)

        cbCourse.DataSource = dt
        cbCourse.ValueMember = "course_code"
        cbCourse.DisplayMember = "course_name"

        dbconn.Close()
    End Sub

    Private Sub cbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCourse.SelectedIndexChanged
        tbCourseCode.Text = cbCourse.SelectedValue.ToString
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim cf As New CourseForm
        cf.ShowDialog()
        CBLoadData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim cf As New CourseForm
        cf.btnAdd.Text = "Update Course"
        cf.tbCourseName.Text = cbCourse.Text
        cf.tbCourseCode.Text = cbCourse.SelectedValue.ToString
        cf.ccc = cbCourse.SelectedValue.ToString
        cf.ShowDialog()
        CBLoadData()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim TempCode As String = tbCourseCode.Text
            Dim m As DialogResult = MessageBox.Show("Are you sure you want to delete: " +
                                                    cbCourse.Text + " course?", "Delete Confimation", MessageBoxButtons.OKCancel)
            If m = DialogResult.OK Then
                Dim cc As New CourseClass
                cc.DeleteCourse(TempCode)
                CBLoadData()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class