<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyGrades
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
        Me.lblValName = New System.Windows.Forms.Label()
        Me.lblMidterm = New System.Windows.Forms.Label()
        Me.lblFinals = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.tbMt = New System.Windows.Forms.TextBox()
        Me.tbFg = New System.Windows.Forms.TextBox()
        Me.tbAvg = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.tbRemarks = New System.Windows.Forms.TextBox()
        Me.lblRemarks = New System.Windows.Forms.Label()
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
        'lblValName
        '
        Me.lblValName.AutoSize = True
        Me.lblValName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValName.Location = New System.Drawing.Point(73, 13)
        Me.lblValName.Name = "lblValName"
        Me.lblValName.Size = New System.Drawing.Size(58, 21)
        Me.lblValName.TabIndex = 1
        Me.lblValName.Text = "Label2"
        '
        'lblMidterm
        '
        Me.lblMidterm.AutoSize = True
        Me.lblMidterm.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMidterm.Location = New System.Drawing.Point(27, 54)
        Me.lblMidterm.Name = "lblMidterm"
        Me.lblMidterm.Size = New System.Drawing.Size(74, 21)
        Me.lblMidterm.TabIndex = 2
        Me.lblMidterm.Text = "Midterm"
        '
        'lblFinals
        '
        Me.lblFinals.AutoSize = True
        Me.lblFinals.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinals.Location = New System.Drawing.Point(262, 54)
        Me.lblFinals.Name = "lblFinals"
        Me.lblFinals.Size = New System.Drawing.Size(50, 21)
        Me.lblFinals.TabIndex = 3
        Me.lblFinals.Text = "Finals"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.Location = New System.Drawing.Point(476, 54)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(71, 21)
        Me.lblAverage.TabIndex = 4
        Me.lblAverage.Text = "Average"
        '
        'tbMt
        '
        Me.tbMt.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMt.Location = New System.Drawing.Point(12, 78)
        Me.tbMt.Name = "tbMt"
        Me.tbMt.Size = New System.Drawing.Size(100, 35)
        Me.tbMt.TabIndex = 5
        Me.tbMt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbFg
        '
        Me.tbFg.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFg.Location = New System.Drawing.Point(234, 78)
        Me.tbFg.Name = "tbFg"
        Me.tbFg.Size = New System.Drawing.Size(100, 35)
        Me.tbFg.TabIndex = 6
        Me.tbFg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbAvg
        '
        Me.tbAvg.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAvg.Location = New System.Drawing.Point(461, 78)
        Me.tbAvg.Name = "tbAvg"
        Me.tbAvg.ReadOnly = True
        Me.tbAvg.Size = New System.Drawing.Size(100, 35)
        Me.tbAvg.TabIndex = 7
        Me.tbAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(189, 208)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(145, 46)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'tbRemarks
        '
        Me.tbRemarks.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRemarks.Location = New System.Drawing.Point(156, 128)
        Me.tbRemarks.Multiline = True
        Me.tbRemarks.Name = "tbRemarks"
        Me.tbRemarks.Size = New System.Drawing.Size(405, 62)
        Me.tbRemarks.TabIndex = 10
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.Location = New System.Drawing.Point(13, 128)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(138, 21)
        Me.lblRemarks.TabIndex = 9
        Me.lblRemarks.Text = "Student Remarks:"
        '
        'ModifyGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(573, 265)
        Me.Controls.Add(Me.tbRemarks)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.tbAvg)
        Me.Controls.Add(Me.tbFg)
        Me.Controls.Add(Me.tbMt)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblFinals)
        Me.Controls.Add(Me.lblMidterm)
        Me.Controls.Add(Me.lblValName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "ModifyGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modify Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblValName As Label
    Friend WithEvents lblMidterm As Label
    Friend WithEvents lblFinals As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents tbMt As TextBox
    Friend WithEvents tbFg As TextBox
    Friend WithEvents tbAvg As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents tbRemarks As TextBox
    Friend WithEvents lblRemarks As Label
End Class
