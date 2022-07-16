<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm
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
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.lblMname = New System.Windows.Forms.Label()
        Me.lblParentName = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.tbLN = New System.Windows.Forms.TextBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.tbFN = New System.Windows.Forms.TextBox()
        Me.tbMN = New System.Windows.Forms.TextBox()
        Me.tbPN = New System.Windows.Forms.TextBox()
        Me.tbCN = New System.Windows.Forms.TextBox()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.lblSy = New System.Windows.Forms.Label()
        Me.lblYl = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.cbSY = New System.Windows.Forms.ComboBox()
        Me.cbCourse = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cbYL = New System.Windows.Forms.ComboBox()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLname.Location = New System.Drawing.Point(12, 9)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(75, 17)
        Me.lblLname.TabIndex = 0
        Me.lblLname.Text = "Last Name:"
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFname.Location = New System.Drawing.Point(12, 40)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(77, 17)
        Me.lblFname.TabIndex = 1
        Me.lblFname.Text = "First Name:"
        '
        'lblMname
        '
        Me.lblMname.AutoSize = True
        Me.lblMname.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMname.Location = New System.Drawing.Point(12, 73)
        Me.lblMname.Name = "lblMname"
        Me.lblMname.Size = New System.Drawing.Size(92, 17)
        Me.lblMname.TabIndex = 2
        Me.lblMname.Text = "Middle Name:"
        '
        'lblParentName
        '
        Me.lblParentName.AutoSize = True
        Me.lblParentName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParentName.Location = New System.Drawing.Point(12, 139)
        Me.lblParentName.Name = "lblParentName"
        Me.lblParentName.Size = New System.Drawing.Size(91, 17)
        Me.lblParentName.TabIndex = 5
        Me.lblParentName.Text = "Parent Name:"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(347, 9)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(88, 17)
        Me.lblDOB.TabIndex = 4
        Me.lblDOB.Text = "Date of Birth:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(12, 106)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(56, 17)
        Me.lblGender.TabIndex = 3
        Me.lblGender.Text = "Gender:"
        '
        'tbLN
        '
        Me.tbLN.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLN.Location = New System.Drawing.Point(110, 4)
        Me.tbLN.Name = "tbLN"
        Me.tbLN.Size = New System.Drawing.Size(205, 27)
        Me.tbLN.TabIndex = 6
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(347, 136)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(113, 17)
        Me.lblContact.TabIndex = 8
        Me.lblContact.Text = "Contact Number:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(347, 58)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(60, 17)
        Me.lblAddress.TabIndex = 7
        Me.lblAddress.Text = "Address:"
        '
        'tbFN
        '
        Me.tbFN.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFN.Location = New System.Drawing.Point(110, 37)
        Me.tbFN.Name = "tbFN"
        Me.tbFN.Size = New System.Drawing.Size(205, 27)
        Me.tbFN.TabIndex = 9
        '
        'tbMN
        '
        Me.tbMN.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMN.Location = New System.Drawing.Point(110, 70)
        Me.tbMN.Name = "tbMN"
        Me.tbMN.Size = New System.Drawing.Size(205, 27)
        Me.tbMN.TabIndex = 10
        '
        'tbPN
        '
        Me.tbPN.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPN.Location = New System.Drawing.Point(110, 134)
        Me.tbPN.Name = "tbPN"
        Me.tbPN.Size = New System.Drawing.Size(205, 27)
        Me.tbPN.TabIndex = 12
        '
        'tbCN
        '
        Me.tbCN.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCN.Location = New System.Drawing.Point(466, 136)
        Me.tbCN.Name = "tbCN"
        Me.tbCN.Size = New System.Drawing.Size(191, 27)
        Me.tbCN.TabIndex = 13
        '
        'tbAddress
        '
        Me.tbAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddress.Location = New System.Drawing.Point(413, 58)
        Me.tbAddress.Multiline = True
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(244, 65)
        Me.tbAddress.TabIndex = 14
        '
        'dtpDOB
        '
        Me.dtpDOB.Location = New System.Drawing.Point(350, 32)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(307, 20)
        Me.dtpDOB.TabIndex = 15
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(551, 249)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(107, 46)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add Record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMale.Location = New System.Drawing.Point(110, 106)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(55, 21)
        Me.rbMale.TabIndex = 20
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFemale.Location = New System.Drawing.Point(171, 106)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(69, 21)
        Me.rbFemale.TabIndex = 21
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'lblSy
        '
        Me.lblSy.AutoSize = True
        Me.lblSy.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSy.Location = New System.Drawing.Point(12, 216)
        Me.lblSy.Name = "lblSy"
        Me.lblSy.Size = New System.Drawing.Size(82, 17)
        Me.lblSy.TabIndex = 22
        Me.lblSy.Text = "School Year:"
        '
        'lblYl
        '
        Me.lblYl.AutoSize = True
        Me.lblYl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYl.Location = New System.Drawing.Point(12, 245)
        Me.lblYl.Name = "lblYl"
        Me.lblYl.Size = New System.Drawing.Size(71, 17)
        Me.lblYl.TabIndex = 23
        Me.lblYl.Text = "Year Level:"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.Location = New System.Drawing.Point(13, 185)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(53, 17)
        Me.lblCourse.TabIndex = 24
        Me.lblCourse.Text = "Course:"
        '
        'cbSY
        '
        Me.cbSY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSY.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSY.FormattingEnabled = True
        Me.cbSY.Location = New System.Drawing.Point(110, 208)
        Me.cbSY.Name = "cbSY"
        Me.cbSY.Size = New System.Drawing.Size(205, 25)
        Me.cbSY.TabIndex = 25
        '
        'cbCourse
        '
        Me.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCourse.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCourse.FormattingEnabled = True
        Me.cbCourse.Location = New System.Drawing.Point(110, 177)
        Me.cbCourse.Name = "cbCourse"
        Me.cbCourse.Size = New System.Drawing.Size(325, 25)
        Me.cbCourse.TabIndex = 26
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(12, 278)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(49, 17)
        Me.lblStatus.TabIndex = 27
        Me.lblStatus.Text = "Status:"
        '
        'cbYL
        '
        Me.cbYL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYL.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbYL.FormattingEnabled = True
        Me.cbYL.Location = New System.Drawing.Point(110, 239)
        Me.cbYL.Name = "cbYL"
        Me.cbYL.Size = New System.Drawing.Size(205, 25)
        Me.cbYL.TabIndex = 28
        '
        'cbStatus
        '
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(110, 270)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(205, 25)
        Me.cbStatus.TabIndex = 29
        '
        'StudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(670, 303)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.cbYL)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cbCourse)
        Me.Controls.Add(Me.cbSY)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.lblYl)
        Me.Controls.Add(Me.lblSy)
        Me.Controls.Add(Me.rbFemale)
        Me.Controls.Add(Me.rbMale)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.tbAddress)
        Me.Controls.Add(Me.tbCN)
        Me.Controls.Add(Me.tbPN)
        Me.Controls.Add(Me.tbMN)
        Me.Controls.Add(Me.tbFN)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.tbLN)
        Me.Controls.Add(Me.lblParentName)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblMname)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.lblLname)
        Me.Name = "StudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLname As Label
    Friend WithEvents lblFname As Label
    Friend WithEvents lblMname As Label
    Friend WithEvents lblParentName As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents tbLN As TextBox
    Friend WithEvents lblContact As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents tbFN As TextBox
    Friend WithEvents tbMN As TextBox
    Friend WithEvents tbPN As TextBox
    Friend WithEvents tbCN As TextBox
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents btnAdd As Button
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents lblSy As Label
    Friend WithEvents lblYl As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents cbSY As ComboBox
    Friend WithEvents cbCourse As ComboBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cbYL As ComboBox
    Friend WithEvents cbStatus As ComboBox
End Class
