<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherClassManagementForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblTeacherName = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.cbSubjects = New System.Windows.Forms.ComboBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.gbCreateClass = New System.Windows.Forms.GroupBox()
        Me.btnAddClass = New System.Windows.Forms.Button()
        Me.tbRoom = New System.Windows.Forms.TextBox()
        Me.tbTime = New System.Windows.Forms.TextBox()
        Me.clbDay = New System.Windows.Forms.CheckedListBox()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.gbExistingClass = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.cbExistingClass = New System.Windows.Forms.ComboBox()
        Me.lblExistingClass = New System.Windows.Forms.Label()
        Me.cbSchoolYear = New System.Windows.Forms.ComboBox()
        Me.lblSchoolYear = New System.Windows.Forms.Label()
        Me.cbExistingSY = New System.Windows.Forms.ComboBox()
        Me.lblExistingSY = New System.Windows.Forms.Label()
        Me.cbExistingDay = New System.Windows.Forms.ComboBox()
        Me.lblExistingDay = New System.Windows.Forms.Label()
        Me.gbCreateClass.SuspendLayout()
        Me.gbExistingClass.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(13, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(57, 21)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblTeacherName
        '
        Me.lblTeacherName.AutoSize = True
        Me.lblTeacherName.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherName.Location = New System.Drawing.Point(74, 13)
        Me.lblTeacherName.Name = "lblTeacherName"
        Me.lblTeacherName.Size = New System.Drawing.Size(60, 21)
        Me.lblTeacherName.TabIndex = 1
        Me.lblTeacherName.Text = "Label1"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.Location = New System.Drawing.Point(15, 23)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(69, 21)
        Me.lblSubject.TabIndex = 2
        Me.lblSubject.Text = "Subject:"
        '
        'cbSubjects
        '
        Me.cbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubjects.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSubjects.FormattingEnabled = True
        Me.cbSubjects.Location = New System.Drawing.Point(90, 23)
        Me.cbSubjects.Name = "cbSubjects"
        Me.cbSubjects.Size = New System.Drawing.Size(239, 25)
        Me.cbSubjects.TabIndex = 3
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(346, 26)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(41, 21)
        Me.lblDay.TabIndex = 4
        Me.lblDay.Text = "Day:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(15, 91)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(50, 21)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "Time:"
        '
        'gbCreateClass
        '
        Me.gbCreateClass.Controls.Add(Me.cbSchoolYear)
        Me.gbCreateClass.Controls.Add(Me.lblSchoolYear)
        Me.gbCreateClass.Controls.Add(Me.btnAddClass)
        Me.gbCreateClass.Controls.Add(Me.tbRoom)
        Me.gbCreateClass.Controls.Add(Me.tbTime)
        Me.gbCreateClass.Controls.Add(Me.clbDay)
        Me.gbCreateClass.Controls.Add(Me.lblRoom)
        Me.gbCreateClass.Controls.Add(Me.cbSubjects)
        Me.gbCreateClass.Controls.Add(Me.lblTime)
        Me.gbCreateClass.Controls.Add(Me.lblSubject)
        Me.gbCreateClass.Controls.Add(Me.lblDay)
        Me.gbCreateClass.Location = New System.Drawing.Point(17, 46)
        Me.gbCreateClass.Name = "gbCreateClass"
        Me.gbCreateClass.Size = New System.Drawing.Size(610, 171)
        Me.gbCreateClass.TabIndex = 6
        Me.gbCreateClass.TabStop = False
        Me.gbCreateClass.Text = "Create New Class"
        '
        'btnAddClass
        '
        Me.btnAddClass.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddClass.Location = New System.Drawing.Point(502, 140)
        Me.btnAddClass.Name = "btnAddClass"
        Me.btnAddClass.Size = New System.Drawing.Size(102, 25)
        Me.btnAddClass.TabIndex = 10
        Me.btnAddClass.Text = "Add Class"
        Me.btnAddClass.UseVisualStyleBackColor = True
        '
        'tbRoom
        '
        Me.tbRoom.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRoom.Location = New System.Drawing.Point(90, 121)
        Me.tbRoom.Name = "tbRoom"
        Me.tbRoom.Size = New System.Drawing.Size(239, 25)
        Me.tbRoom.TabIndex = 9
        '
        'tbTime
        '
        Me.tbTime.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTime.Location = New System.Drawing.Point(90, 87)
        Me.tbTime.Name = "tbTime"
        Me.tbTime.Size = New System.Drawing.Size(239, 25)
        Me.tbTime.TabIndex = 8
        '
        'clbDay
        '
        Me.clbDay.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbDay.FormattingEnabled = True
        Me.clbDay.Location = New System.Drawing.Point(393, 26)
        Me.clbDay.Name = "clbDay"
        Me.clbDay.Size = New System.Drawing.Size(211, 104)
        Me.clbDay.TabIndex = 7
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoom.Location = New System.Drawing.Point(15, 125)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(58, 21)
        Me.lblRoom.TabIndex = 6
        Me.lblRoom.Text = "Room:"
        '
        'gbExistingClass
        '
        Me.gbExistingClass.Controls.Add(Me.cbExistingSY)
        Me.gbExistingClass.Controls.Add(Me.lblExistingSY)
        Me.gbExistingClass.Controls.Add(Me.btnDelete)
        Me.gbExistingClass.Controls.Add(Me.cbExistingDay)
        Me.gbExistingClass.Controls.Add(Me.btnEdit)
        Me.gbExistingClass.Controls.Add(Me.lblExistingDay)
        Me.gbExistingClass.Controls.Add(Me.btnView)
        Me.gbExistingClass.Controls.Add(Me.cbExistingClass)
        Me.gbExistingClass.Controls.Add(Me.lblExistingClass)
        Me.gbExistingClass.Location = New System.Drawing.Point(12, 223)
        Me.gbExistingClass.Name = "gbExistingClass"
        Me.gbExistingClass.Size = New System.Drawing.Size(610, 171)
        Me.gbExistingClass.TabIndex = 11
        Me.gbExistingClass.TabStop = False
        Me.gbExistingClass.Text = "Manage Existing Class"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(350, 82)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(102, 27)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete Class"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(242, 82)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(102, 27)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Edit Class"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(134, 82)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(102, 27)
        Me.btnView.TabIndex = 10
        Me.btnView.Text = "View Class"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'cbExistingClass
        '
        Me.cbExistingClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbExistingClass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbExistingClass.FormattingEnabled = True
        Me.cbExistingClass.Location = New System.Drawing.Point(71, 51)
        Me.cbExistingClass.Name = "cbExistingClass"
        Me.cbExistingClass.Size = New System.Drawing.Size(533, 25)
        Me.cbExistingClass.TabIndex = 3
        '
        'lblExistingClass
        '
        Me.lblExistingClass.AutoSize = True
        Me.lblExistingClass.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExistingClass.Location = New System.Drawing.Point(15, 51)
        Me.lblExistingClass.Name = "lblExistingClass"
        Me.lblExistingClass.Size = New System.Drawing.Size(50, 21)
        Me.lblExistingClass.TabIndex = 2
        Me.lblExistingClass.Text = "Class:"
        '
        'cbSchoolYear
        '
        Me.cbSchoolYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSchoolYear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSchoolYear.FormattingEnabled = True
        Me.cbSchoolYear.Location = New System.Drawing.Point(121, 54)
        Me.cbSchoolYear.Name = "cbSchoolYear"
        Me.cbSchoolYear.Size = New System.Drawing.Size(208, 25)
        Me.cbSchoolYear.TabIndex = 12
        '
        'lblSchoolYear
        '
        Me.lblSchoolYear.AutoSize = True
        Me.lblSchoolYear.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolYear.Location = New System.Drawing.Point(15, 54)
        Me.lblSchoolYear.Name = "lblSchoolYear"
        Me.lblSchoolYear.Size = New System.Drawing.Size(100, 21)
        Me.lblSchoolYear.TabIndex = 11
        Me.lblSchoolYear.Text = "School Year:"
        '
        'cbExistingSY
        '
        Me.cbExistingSY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbExistingSY.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbExistingSY.FormattingEnabled = True
        Me.cbExistingSY.Location = New System.Drawing.Point(121, 19)
        Me.cbExistingSY.Name = "cbExistingSY"
        Me.cbExistingSY.Size = New System.Drawing.Size(241, 25)
        Me.cbExistingSY.TabIndex = 16
        '
        'lblExistingSY
        '
        Me.lblExistingSY.AutoSize = True
        Me.lblExistingSY.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExistingSY.Location = New System.Drawing.Point(15, 23)
        Me.lblExistingSY.Name = "lblExistingSY"
        Me.lblExistingSY.Size = New System.Drawing.Size(100, 21)
        Me.lblExistingSY.TabIndex = 15
        Me.lblExistingSY.Text = "School Year:"
        '
        'cbExistingDay
        '
        Me.cbExistingDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbExistingDay.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbExistingDay.FormattingEnabled = True
        Me.cbExistingDay.Location = New System.Drawing.Point(465, 19)
        Me.cbExistingDay.Name = "cbExistingDay"
        Me.cbExistingDay.Size = New System.Drawing.Size(139, 25)
        Me.cbExistingDay.TabIndex = 14
        '
        'lblExistingDay
        '
        Me.lblExistingDay.AutoSize = True
        Me.lblExistingDay.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExistingDay.Location = New System.Drawing.Point(418, 23)
        Me.lblExistingDay.Name = "lblExistingDay"
        Me.lblExistingDay.Size = New System.Drawing.Size(41, 21)
        Me.lblExistingDay.TabIndex = 13
        Me.lblExistingDay.Text = "Day:"
        '
        'TeacherClassManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(648, 430)
        Me.Controls.Add(Me.gbExistingClass)
        Me.Controls.Add(Me.gbCreateClass)
        Me.Controls.Add(Me.lblTeacherName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "TeacherClassManagementForm"
        Me.Text = "Class Management"
        Me.gbCreateClass.ResumeLayout(False)
        Me.gbCreateClass.PerformLayout()
        Me.gbExistingClass.ResumeLayout(False)
        Me.gbExistingClass.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblTeacherName As Label
    Friend WithEvents lblSubject As Label
    Friend WithEvents cbSubjects As ComboBox
    Friend WithEvents lblDay As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents gbCreateClass As GroupBox
    Friend WithEvents tbRoom As TextBox
    Friend WithEvents tbTime As TextBox
    Friend WithEvents clbDay As CheckedListBox
    Friend WithEvents lblRoom As Label
    Friend WithEvents btnAddClass As Button
    Friend WithEvents gbExistingClass As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnView As Button
    Friend WithEvents cbExistingClass As ComboBox
    Friend WithEvents lblExistingClass As Label
    Friend WithEvents cbSchoolYear As ComboBox
    Friend WithEvents lblSchoolYear As Label
    Friend WithEvents cbExistingSY As ComboBox
    Friend WithEvents lblExistingSY As Label
    Friend WithEvents cbExistingDay As ComboBox
    Friend WithEvents lblExistingDay As Label
End Class
