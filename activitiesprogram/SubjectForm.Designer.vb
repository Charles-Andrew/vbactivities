<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubjectForm
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
        Me.tbSubjectName = New System.Windows.Forms.TextBox()
        Me.lblSubjectName = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.numericUnits = New System.Windows.Forms.NumericUpDown()
        CType(Me.numericUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbSubjectName
        '
        Me.tbSubjectName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSubjectName.Location = New System.Drawing.Point(139, 26)
        Me.tbSubjectName.Multiline = True
        Me.tbSubjectName.Name = "tbSubjectName"
        Me.tbSubjectName.Size = New System.Drawing.Size(250, 60)
        Me.tbSubjectName.TabIndex = 0
        '
        'lblSubjectName
        '
        Me.lblSubjectName.AutoSize = True
        Me.lblSubjectName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectName.Location = New System.Drawing.Point(25, 26)
        Me.lblSubjectName.Name = "lblSubjectName"
        Me.lblSubjectName.Size = New System.Drawing.Size(108, 20)
        Me.lblSubjectName.TabIndex = 2
        Me.lblSubjectName.Text = "Subject Name:"
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnits.Location = New System.Drawing.Point(85, 102)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(48, 20)
        Me.lblUnits.TabIndex = 3
        Me.lblUnits.Text = "Units:"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(120, 151)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(142, 31)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add Subject"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'numericUnits
        '
        Me.numericUnits.DecimalPlaces = 1
        Me.numericUnits.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericUnits.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numericUnits.Location = New System.Drawing.Point(139, 95)
        Me.numericUnits.Name = "numericUnits"
        Me.numericUnits.Size = New System.Drawing.Size(120, 27)
        Me.numericUnits.TabIndex = 5
        '
        'SubjectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 194)
        Me.Controls.Add(Me.numericUnits)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblSubjectName)
        Me.Controls.Add(Me.tbSubjectName)
        Me.Name = "SubjectForm"
        Me.Text = "Subject Form"
        CType(Me.numericUnits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbSubjectName As TextBox
    Friend WithEvents lblSubjectName As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents numericUnits As NumericUpDown
End Class
