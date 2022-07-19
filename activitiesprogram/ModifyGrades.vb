Public Class ModifyGrades
    Public StudentID As Integer = 0
    Public ClassID As Integer = 0
    Public NameOfUser As String = ""
    Private Sub ModifyGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog

        If NameOfUser <> "" Then
            lblValName.Text = NameOfUser
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim mg As New ModifyGradeClass
        mg.Midterm = Integer.Parse(tbMt.Text)
        mg.Final = Integer.Parse(tbFg.Text)
        mg.StudentRemarks = tbRemarks.Text
        mg.UpdateGrade(StudentID, ClassID)
        Me.Dispose()
    End Sub
End Class