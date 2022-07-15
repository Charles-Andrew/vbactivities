Imports MySql.Data.MySqlClient

Public Class SubjectManagement
    Private Sub SubjectManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCBitems()
    End Sub
    Private Sub LoadCBitems()
        dbconn.Open()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim dt As New DataTable

        cmd.Connection = Conn
        cmd.CommandText = "SELECT idsubject, CONCAT(subject_name, ' (', units, ' Units)')  AS su FROM subject"
        dr = cmd.ExecuteReader
        dt.Load(dr)

        cbSubject.DataSource = dt
        cbSubject.ValueMember = "idsubject"
        cbSubject.DisplayMember = "su"

        dbconn.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim sf As New SubjectForm
        sf.ShowDialog()
        LoadCBitems()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim TempSubjectName As String = ""
        Dim TempUnits As Double = 0.0
        dbconn.Open()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        cmd.Connection = Conn
        cmd.CommandText = "SELECT * FROM subject WHERE idsubject = @idsubject"
        cmd.Parameters.AddWithValue("@idsubject", cbSubject.SelectedValue.ToString)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                TempSubjectName = dr("subject_name").ToString
                TempUnits = dr("units")
            End While
        End If

        Dim sf As New SubjectForm
        sf.btnAdd.Text = "Edit Subject"
        sf.tbSubjectName.Text = TempSubjectName
        sf.numericUnits.Value = TempUnits
        sf.tempid = Integer.Parse(cbSubject.SelectedValue.ToString)
        sf.ShowDialog()
        LoadCBitems()

        dbconn.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim TempID As String = cbSubject.SelectedValue
        Dim m As DialogResult = MessageBox.Show("Are you sure you want to delete record with Subject ID: " +
                                                TempID, "Delete Confimation", MessageBoxButtons.OKCancel)
        If m = DialogResult.OK Then
            Dim sc As New SubjectClass
            sc.DeleteSubject(TempID)
            LoadCBitems()
        End If

    End Sub
End Class