Public Class SubjectForm
    Public tempid As Integer = 0
    Private Sub SubjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog


    End Sub

    Private Sub ValidateFields()
        If tbSubjectName.Text.Trim = "" Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Edit Subject" Then
            Dim sc As New SubjectClass
            sc.SubjectName = tbSubjectName.Text.Trim
            sc.SubjectUnits = numericUnits.Value
            sc.EditSubject(tempid)
        Else
            Dim sc As New SubjectClass
            sc.SubjectName = tbSubjectName.Text.Trim
            sc.SubjectUnits = numericUnits.Value
            If sc.AddSubject() Then
                tbSubjectName.Text = ""
                numericUnits.Value = 0.0
            End If
        End If
    End Sub

    Private Sub tbSubjectName_TextChanged(sender As Object, e As EventArgs) Handles tbSubjectName.TextChanged

    End Sub
End Class