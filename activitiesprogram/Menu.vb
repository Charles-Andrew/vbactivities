Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSML_Click(sender As Object, e As EventArgs) Handles btnSML.Click
        Dim s As New StudentMasterList
        Me.Hide()
        s.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnTML_Click(sender As Object, e As EventArgs) Handles btnTML.Click
        Dim t As New TeacherMasterList
        Me.Hide()
        t.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnCM_Click(sender As Object, e As EventArgs) Handles btnCM.Click
        Dim cm As New CourseManagement
        cm.ShowDialog()
    End Sub

    Private Sub btnSM_Click(sender As Object, e As EventArgs) Handles btnSM.Click
        Dim sm As New SubjectManagement
        sm.ShowDialog()
    End Sub

    Private Sub btnSchoolYear_Click(sender As Object, e As EventArgs) Handles btnSchoolYear.Click
        Dim syf As New SchoolYearForm
        syf.ShowDialog()
    End Sub
End Class