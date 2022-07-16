<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherForm
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
        Me.tbFN = New System.Windows.Forms.TextBox()
        Me.tbMN = New System.Windows.Forms.TextBox()
        Me.tbLN = New System.Windows.Forms.TextBox()
        Me.btnFname = New System.Windows.Forms.Label()
        Me.lblMname = New System.Windows.Forms.Label()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblIDlabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbFN
        '
        Me.tbFN.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFN.Location = New System.Drawing.Point(123, 67)
        Me.tbFN.Name = "tbFN"
        Me.tbFN.Size = New System.Drawing.Size(213, 27)
        Me.tbFN.TabIndex = 0
        '
        'tbMN
        '
        Me.tbMN.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMN.Location = New System.Drawing.Point(123, 108)
        Me.tbMN.Name = "tbMN"
        Me.tbMN.Size = New System.Drawing.Size(213, 27)
        Me.tbMN.TabIndex = 1
        '
        'tbLN
        '
        Me.tbLN.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLN.Location = New System.Drawing.Point(123, 154)
        Me.tbLN.Name = "tbLN"
        Me.tbLN.Size = New System.Drawing.Size(213, 27)
        Me.tbLN.TabIndex = 2
        '
        'btnFname
        '
        Me.btnFname.AutoSize = True
        Me.btnFname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFname.Location = New System.Drawing.Point(13, 70)
        Me.btnFname.Name = "btnFname"
        Me.btnFname.Size = New System.Drawing.Size(90, 20)
        Me.btnFname.TabIndex = 3
        Me.btnFname.Text = "First Name:"
        '
        'lblMname
        '
        Me.lblMname.AutoSize = True
        Me.lblMname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMname.Location = New System.Drawing.Point(12, 112)
        Me.lblMname.Name = "lblMname"
        Me.lblMname.Size = New System.Drawing.Size(107, 20)
        Me.lblMname.TabIndex = 4
        Me.lblMname.Text = "Middle Name:"
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLname.Location = New System.Drawing.Point(13, 158)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(88, 20)
        Me.lblLname.TabIndex = 5
        Me.lblLname.Text = "Last Name:"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(11, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(121, 25)
        Me.lblHeader.TabIndex = 6
        Me.lblHeader.Text = "Add Teacher"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(135, 208)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 58)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add Record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(293, 9)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(43, 17)
        Me.lblID.TabIndex = 8
        Me.lblID.Text = "TEMP"
        Me.lblID.Visible = False
        '
        'lblIDlabel
        '
        Me.lblIDlabel.AutoSize = True
        Me.lblIDlabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDlabel.Location = New System.Drawing.Point(253, 9)
        Me.lblIDlabel.Name = "lblIDlabel"
        Me.lblIDlabel.Size = New System.Drawing.Size(34, 17)
        Me.lblIDlabel.TabIndex = 9
        Me.lblIDlabel.Text = "ID#:"
        Me.lblIDlabel.Visible = False
        '
        'TeacherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(348, 290)
        Me.Controls.Add(Me.lblIDlabel)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblLname)
        Me.Controls.Add(Me.lblMname)
        Me.Controls.Add(Me.btnFname)
        Me.Controls.Add(Me.tbLN)
        Me.Controls.Add(Me.tbMN)
        Me.Controls.Add(Me.tbFN)
        Me.Name = "TeacherForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teacher Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbFN As TextBox
    Friend WithEvents tbMN As TextBox
    Friend WithEvents tbLN As TextBox
    Friend WithEvents btnFname As Label
    Friend WithEvents lblMname As Label
    Friend WithEvents lblLname As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblID As Label
    Friend WithEvents lblIDlabel As Label
End Class
