Imports MySql.Data.MySqlClient

Public Class TeacherClassManagementForm
    Public TeacherID As Integer = 0
    Dim Daystring As String = ""
    Private Sub TeacherClassManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadItems()
        btnAddClass.Enabled = False
    End Sub
    Private Sub loadItems()
        clbDay.Items.Add("Monday")
        clbDay.Items.Add("Tuesday")
        clbDay.Items.Add("Wednesday")
        clbDay.Items.Add("Thursday")
        clbDay.Items.Add("Friday")
        clbDay.Items.Add("Saturday")
        clbDay.Items.Add("Sunday")
        LoadSubjectsAndSY()
        LoadName()
        LoadExistingItems()
    End Sub
    Private Sub LoadSubjectsAndSY()
        Dim db As New DBClass
        db.Open()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim tb As New DataTable

        cmd.Connection = db.conn
        cmd.CommandText = "SELECT * FROM subject ORDER BY subject_name ASC"
        dr = cmd.ExecuteReader
        tb.Load(dr)

        cbSubjects.DataSource = tb
        cbSubjects.DisplayMember = "subject_name"
        cbSubjects.ValueMember = "idsubject"

        db.Close()

        Dim _db As New DBClass
        _db.Open()
        Dim _cmd = _db.cmd
        _cmd.Connection = _db.conn
        _cmd.CommandText = "SELECT idsy, CONCAT(year,' ', sem, ' Semester') as Sem FROM schoolyear_sem ORDER BY year ASC"
        Dim _dr = _db.dr
        _dr = _cmd.ExecuteReader()
        Dim _tb As New DataTable
        _tb.Load(_dr)

        cbSchoolYear.DataSource = _tb
        cbSchoolYear.DisplayMember = "Sem"
        cbSchoolYear.ValueMember = "idsy"

        _db.Close()

    End Sub
    Private Sub LoadName()
        Dim db As New DBClass
        db.Open()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        cmd.Connection = db.conn
        cmd.CommandText = "SELECT CONCAT(FName,' ',MName,' ',LName) as FN FROM teacher WHERE idteacher = @idteacher"
        cmd.Parameters.AddWithValue("@idteacher", TeacherID)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                lblTeacherName.Text = dr("FN").ToString
            End While
        End If
        cbExistingDay.Items.Add("All")
        cbExistingDay.Items.Add("Monday")
        cbExistingDay.Items.Add("Tuesday")
        cbExistingDay.Items.Add("Wednesday")
        cbExistingDay.Items.Add("Thursday")
        cbExistingDay.Items.Add("Friday")
        cbExistingDay.Items.Add("Saturday")
        cbExistingDay.Items.Add("Sunday")
        cbExistingDay.SelectedIndex = 0
        db.Close()
    End Sub

    Private Sub LoadExistingItems()
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        Dim dr = db.dr

        cmd.Connection = db.conn
        cmd.CommandText = "SELECT schoolyear_sem.idsy, CONCAT(year,' ', sem, ' Semester') as'SY' 
                           FROM class_offering JOIN schoolyear_sem WHERE class_offering.idsy = schoolyear_sem.idsy 
                           AND class_offering.idteacher=@idteacher"
        cmd.Parameters.AddWithValue("@idteacher", TeacherID)
        dr = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(dr)
        cbExistingSY.DataSource = dt
        cbExistingSY.DisplayMember = "SY"
        cbExistingSY.ValueMember = "idsy"
        db.Close()
        LoadCBItems()
    End Sub

    Private Sub LoadCBItems()
        Dim db As New DBClass
        db.Open()
        Dim cmd = db.cmd
        cmd.Connection = db.conn

        If Not cbExistingDay.Text = "All" Then
            cmd.CommandText = "SELECT *, CONCAT(s.subject_name,' (',co.day,') - ',co.time) as SN FROM class_offering as co JOIN subject as s JOIN schoolyear_sem as ss 
                           WHERE s.idsubject = co.idsubject AND ss.idsy = co.idsy AND co.day LIKE '%%' 
                           AND ss.idsy = @cbid"
            cmd.Parameters.AddWithValue("@cbid", cbExistingSY.SelectedValue)
        Else
            cmd.CommandText = "SELECT *, CONCAT(s.subject_name,' (',co.day,') - ',co.time) as SN FROM class_offering as co JOIN subject as s JOIN schoolyear_sem as ss 
                           WHERE s.idsubject = co.idsubject AND ss.idsy = co.idsy AND co.day LIKE '%@tst%' 
                           AND ss.idsy = @cbid"
            cmd.Parameters.AddWithValue("@tst", cbExistingDay.SelectedValue)
            cmd.Parameters.AddWithValue("@cbid", cbExistingSY.SelectedValue)
        End If
        Dim dr = db.dr
        dr = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(dr)
        cbExistingClass.DataSource = dt
        cbExistingClass.DisplayMember = "SN"
        cbExistingClass.ValueMember = "idclass_offering"

        db.Close()
    End Sub
    Private Sub ValidateForm()
        If cbSubjects.Text = "" OrElse tbRoom.Text = "" OrElse tbTime.Text = "" Then
            btnAddClass.Enabled = False
        Else
            If clbDay.CheckedItems.Count <> 0 Then
                btnAddClass.Enabled = True
            Else
                btnAddClass.Enabled = False
            End If
        End If
    End Sub
    Private Sub btnAddClass_Click(sender As Object, e As EventArgs) Handles btnAddClass.Click
        Daystring = ""
        Dim c As Integer = 0
        For Each item As String In clbDay.CheckedItems
            If item <> "" Then
                If c = 0 Then
                    Daystring += item
                Else
                    Daystring += "-" + item
                End If
                c += 1
            End If
        Next
        Dim tcmc As New TeacherClassManagementClass
        tcmc.COSubjectID = cbSubjects.SelectedValue
        tcmc.COSchoolYear = cbSchoolYear.SelectedValue
        tcmc.COTeacherID = TeacherID
        tcmc.CODay = Daystring
        tcmc.COTime = tbTime.Text
        tcmc.CORoom = tbRoom.Text
        tcmc.AddClass()
        ClearFields()

    End Sub
    Private Sub ClearFields()
        tbRoom.Text = ""
        tbTime.Text = ""
        cbSchoolYear.SelectedIndex = 0
        cbSubjects.SelectedIndex = 0
        For Each item As Integer In clbDay.CheckedIndices
            clbDay.SetItemCheckState(item, False)
        Next
    End Sub
    Private Sub clbDay_SelectedValueChanged(sender As Object, e As EventArgs) Handles clbDay.SelectedValueChanged
        ValidateForm()
    End Sub

    Private Sub tbRoom_TextChanged(sender As Object, e As EventArgs) Handles tbRoom.TextChanged
        ValidateForm()
    End Sub

    Private Sub tbTime_TextChanged(sender As Object, e As EventArgs) Handles tbTime.TextChanged
        ValidateForm()
    End Sub

    Private Sub cbSubjects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSubjects.SelectedIndexChanged
        ValidateForm()
    End Sub

    Private Sub cbExistingSY_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbExistingSY.SelectedValueChanged
        LoadCBItems()
    End Sub

    Private Sub cbExistingDay_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbExistingDay.SelectedValueChanged
        LoadCBItems()
        MessageBox.Show(cbExistingDay.SelectedItem.ToString)
    End Sub
End Class