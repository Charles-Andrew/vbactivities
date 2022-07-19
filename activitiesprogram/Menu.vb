Public Class Menu
    Public Admin As Boolean = False
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    Private Sub btnSML_Click(sender As Object, e As EventArgs) Handles btnSML.Click
        Dim syf As New SchoolYearForm
        If syf.HaveActiveSY Then
            Dim s As New StudentMasterList
            Me.Hide()
            s.Admin = Admin
            s.ShowDialog()
            Me.Show()
        Else
            MessageBox.Show("No active school year at the moment. Please Contact the admin.")
        End If
    End Sub

    Private Sub btnTML_Click(sender As Object, e As EventArgs) Handles btnTML.Click
        Dim syf As New SchoolYearForm
        If syf.HaveActiveSY Then
            Dim t As New TeacherMasterList
            Me.Hide()
            t.Admin = Admin
            t.ShowDialog()
            Me.Show()
        Else
            MessageBox.Show("No active school year at the moment. Please Contact the admin.")
        End If
    End Sub

    Private Sub btnCM_Click(sender As Object, e As EventArgs) Handles btnCM.Click
        Dim cm As New CourseManagement
        Me.Hide()
        cm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnSM_Click(sender As Object, e As EventArgs) Handles btnSM.Click
        Dim sm As New SubjectManagement
        Me.Hide()
        sm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnSchoolYear_Click(sender As Object, e As EventArgs) Handles btnSchoolYear.Click
        If Admin Then
            Dim syf As New SchoolYearForm
            Me.Hide()
            syf.ShowDialog()
            Me.Show()
        Else
            MessageBox.Show("Only Administrator can access the school year tab.")
        End If
    End Sub

    Private Sub lblLogout_DoubleClick(sender As Object, e As EventArgs) Handles lblLogout.DoubleClick
        Logout()
    End Sub

    Private Sub Menu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Logout()
    End Sub

    Private Sub Logout()
        If Admin Then
            Dim a As New AdminClass
            a.SetLogoutIndicator()
        End If
        Dim l As New Login
        l.Show()
        Me.Dispose()
    End Sub
End Class