Imports MySql.Data.MySqlClient

Public Class TeacherMasterList

    Private Sub TeacherMasterList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecords()
    End Sub

    Private Sub LoadRecords()
        dbconn.Open()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim dt As New DataTable

        cmd.Connection = Conn
        cmd.CommandText = "SELECT * FROM teacher"
        dr = cmd.ExecuteReader
        dt.Load(dr)
        dgvTeacherViewer.DataSource = dt

        dbconn.Close()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim tf As New TeacherForm
        tf.lblHeader.Text = "Add Teacher"
        tf.ShowDialog()
        LoadRecords()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim te As New TeacherForm
        te.lblHeader.Text = "Update Teacher"
        te.lblID.Text = dgvTeacherViewer.CurrentRow.Cells(0).Value.ToString
        te.lblID.Visible = True
        te.lblIDlabel.Visible = True
        te.tbFN.Text = dgvTeacherViewer.CurrentRow.Cells(1).Value.ToString
        te.tbMN.Text = dgvTeacherViewer.CurrentRow.Cells(2).Value.ToString
        te.tbLN.Text = dgvTeacherViewer.CurrentRow.Cells(3).Value.ToString
        te.btnAdd.Text = "Update Record"
        te.ShowDialog()
        LoadRecords()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim TempID As String = dgvTeacherViewer.CurrentRow.Cells(0).Value.ToString
        Dim m As DialogResult = MessageBox.Show("Are you sure you want to delete record with Teacher ID: " +
                                                TempID, "Delete Confimation", MessageBoxButtons.OKCancel)
        If m = DialogResult.OK Then
            Dim t As New TeacherClass
            t.DeleteTeacher(Integer.Parse(TempID))
            LoadRecords()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tcmf As New TeacherClassManagementForm
        tcmf.TeacherID = dgvTeacherViewer.CurrentRow.Cells(0).Value.ToString
        tcmf.ShowDialog()
    End Sub
End Class