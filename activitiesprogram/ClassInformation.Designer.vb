<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassInformation
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvStudentView = New System.Windows.Forms.DataGridView()
        Me.lblClassName = New System.Windows.Forms.Label()
        Me.lblDaySched = New System.Windows.Forms.Label()
        Me.lblTimeSched = New System.Windows.Forms.Label()
        Me.lblValTime = New System.Windows.Forms.Label()
        Me.lblValSched = New System.Windows.Forms.Label()
        Me.lblValName = New System.Windows.Forms.Label()
        Me.lblStudentCount = New System.Windows.Forms.Label()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnDrop = New System.Windows.Forms.Button()
        CType(Me.dgvStudentView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvStudentView
        '
        Me.dgvStudentView.AllowUserToAddRows = False
        Me.dgvStudentView.AllowUserToDeleteRows = False
        Me.dgvStudentView.AllowUserToResizeRows = False
        Me.dgvStudentView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudentView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStudentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStudentView.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStudentView.Location = New System.Drawing.Point(12, 89)
        Me.dgvStudentView.Name = "dgvStudentView"
        Me.dgvStudentView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudentView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStudentView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudentView.Size = New System.Drawing.Size(776, 190)
        Me.dgvStudentView.TabIndex = 0
        '
        'lblClassName
        '
        Me.lblClassName.AutoSize = True
        Me.lblClassName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassName.Location = New System.Drawing.Point(12, 9)
        Me.lblClassName.Name = "lblClassName"
        Me.lblClassName.Size = New System.Drawing.Size(121, 21)
        Me.lblClassName.TabIndex = 1
        Me.lblClassName.Text = "Subject Name:"
        '
        'lblDaySched
        '
        Me.lblDaySched.AutoSize = True
        Me.lblDaySched.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaySched.Location = New System.Drawing.Point(13, 30)
        Me.lblDaySched.Name = "lblDaySched"
        Me.lblDaySched.Size = New System.Drawing.Size(67, 17)
        Me.lblDaySched.TabIndex = 2
        Me.lblDaySched.Text = "Schedule:"
        '
        'lblTimeSched
        '
        Me.lblTimeSched.AutoSize = True
        Me.lblTimeSched.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeSched.Location = New System.Drawing.Point(13, 47)
        Me.lblTimeSched.Name = "lblTimeSched"
        Me.lblTimeSched.Size = New System.Drawing.Size(43, 17)
        Me.lblTimeSched.TabIndex = 3
        Me.lblTimeSched.Text = "Time:"
        '
        'lblValTime
        '
        Me.lblValTime.AutoSize = True
        Me.lblValTime.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValTime.Location = New System.Drawing.Point(140, 47)
        Me.lblValTime.Name = "lblValTime"
        Me.lblValTime.Size = New System.Drawing.Size(43, 17)
        Me.lblValTime.TabIndex = 6
        Me.lblValTime.Text = "Time:"
        '
        'lblValSched
        '
        Me.lblValSched.AutoSize = True
        Me.lblValSched.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValSched.Location = New System.Drawing.Point(140, 30)
        Me.lblValSched.Name = "lblValSched"
        Me.lblValSched.Size = New System.Drawing.Size(67, 17)
        Me.lblValSched.TabIndex = 5
        Me.lblValSched.Text = "Schedule:"
        '
        'lblValName
        '
        Me.lblValName.AutoSize = True
        Me.lblValName.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValName.Location = New System.Drawing.Point(139, 9)
        Me.lblValName.Name = "lblValName"
        Me.lblValName.Size = New System.Drawing.Size(121, 21)
        Me.lblValName.TabIndex = 4
        Me.lblValName.Text = "Subject Name:"
        '
        'lblStudentCount
        '
        Me.lblStudentCount.AutoSize = True
        Me.lblStudentCount.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentCount.Location = New System.Drawing.Point(618, 69)
        Me.lblStudentCount.Name = "lblStudentCount"
        Me.lblStudentCount.Size = New System.Drawing.Size(45, 17)
        Me.lblStudentCount.TabIndex = 8
        Me.lblStudentCount.Text = "Count"
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Location = New System.Drawing.Point(230, 289)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(162, 43)
        Me.btnModify.TabIndex = 9
        Me.btnModify.Text = "Update"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnDrop
        '
        Me.btnDrop.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrop.Location = New System.Drawing.Point(398, 289)
        Me.btnDrop.Name = "btnDrop"
        Me.btnDrop.Size = New System.Drawing.Size(162, 43)
        Me.btnDrop.TabIndex = 10
        Me.btnDrop.Text = "Drop"
        Me.btnDrop.UseVisualStyleBackColor = True
        '
        'ClassInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 344)
        Me.Controls.Add(Me.btnDrop)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.lblStudentCount)
        Me.Controls.Add(Me.lblValTime)
        Me.Controls.Add(Me.lblValSched)
        Me.Controls.Add(Me.lblValName)
        Me.Controls.Add(Me.lblTimeSched)
        Me.Controls.Add(Me.lblDaySched)
        Me.Controls.Add(Me.lblClassName)
        Me.Controls.Add(Me.dgvStudentView)
        Me.Name = "ClassInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Class Information"
        CType(Me.dgvStudentView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvStudentView As DataGridView
    Friend WithEvents lblClassName As Label
    Friend WithEvents lblDaySched As Label
    Friend WithEvents lblTimeSched As Label
    Friend WithEvents lblValTime As Label
    Friend WithEvents lblValSched As Label
    Friend WithEvents lblValName As Label
    Friend WithEvents lblStudentCount As Label
    Friend WithEvents btnModify As Button
    Friend WithEvents btnDrop As Button
End Class
