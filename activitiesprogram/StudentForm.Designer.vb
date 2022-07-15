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
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblIDlabel = New System.Windows.Forms.Label()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
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
        Me.btnAdd.Location = New System.Drawing.Point(551, 174)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(107, 23)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add Record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(59, 183)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 21)
        Me.lblID.TabIndex = 18
        Me.lblID.Visible = False
        '
        'lblIDlabel
        '
        Me.lblIDlabel.AutoSize = True
        Me.lblIDlabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDlabel.Location = New System.Drawing.Point(15, 184)
        Me.lblIDlabel.Name = "lblIDlabel"
        Me.lblIDlabel.Size = New System.Drawing.Size(38, 20)
        Me.lblIDlabel.TabIndex = 19
        Me.lblIDlabel.Text = "ID#:"
        Me.lblIDlabel.Visible = False
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
        'StudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(670, 209)
        Me.Controls.Add(Me.rbFemale)
        Me.Controls.Add(Me.rbMale)
        Me.Controls.Add(Me.lblIDlabel)
        Me.Controls.Add(Me.lblID)
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
    Friend WithEvents lblID As Label
    Friend WithEvents lblIDlabel As Label
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFemale As RadioButton
End Class
