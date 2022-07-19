Imports MySql.Data.MySqlClient

Public Class CourseForm
    Public ccc As String = ""
    Private Sub CourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog

        btnAdd.Enabled = False
    End Sub
    Private Sub ValidateForms()
        If tbCourseCode.Text.Trim = "" OrElse tbCourseName.Text.Trim = "" Then
            btnAdd.Enabled = False
            lblStatus.Visible = False
        Else
            btnAdd.Enabled = True
            If btnAdd.Text = "Update Course" Then
                If tbCourseCode.Text.Trim.ToLower <> ccc.ToLower And ccc <> "" Then
                    checkExist()
                Else
                    lblStatus.Visible = False
                End If
            Else
                checkExist()
            End If

        End If

    End Sub
    Private Sub checkExist()
        dbconn.Open()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        cmd.Connection = Conn
        cmd.CommandText = "SELECT * FROM course WHERE course_code = @CC"
        cmd.Parameters.AddWithValue("@CC", tbCourseCode.Text.Trim)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            btnAdd.Enabled = False
            lblStatus.Visible = True
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Course code already exists."
        Else
            btnAdd.Enabled = True
            lblStatus.Visible = True
            lblStatus.ForeColor = Color.Green
            lblStatus.Text = "Course code is available."
        End If

        dbconn.Close()
    End Sub

    Private Sub tbCourseName_TextChanged(sender As Object, e As EventArgs) Handles tbCourseName.TextChanged
        ValidateForms()
    End Sub

    Private Sub tbCourseCode_TextChanged(sender As Object, e As EventArgs) Handles tbCourseCode.TextChanged
        ValidateForms()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Update Course" Then
            Dim cc As New CourseClass
            cc.CourseName = tbCourseName.Text.Trim
            cc.CourseCode = tbCourseCode.Text.Trim
            cc.EditCourse(ccc)

        Else
            Dim cc As New CourseClass
            cc.CourseName = tbCourseName.Text.Trim
            cc.CourseCode = tbCourseCode.Text.Trim
            If cc.AddCourse() Then
                tbCourseName.Text = ""
                tbCourseCode.Text = ""
            End If
        End If

    End Sub
End Class