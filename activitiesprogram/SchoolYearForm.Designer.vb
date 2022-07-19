<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SchoolYearForm
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
        Me.numericFrom = New System.Windows.Forms.NumericUpDown()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.tbSYTo = New System.Windows.Forms.TextBox()
        Me.lblSetSY = New System.Windows.Forms.Label()
        Me.lblActiveSY = New System.Windows.Forms.Label()
        Me.cbSY = New System.Windows.Forms.ComboBox()
        Me.btnSetSY = New System.Windows.Forms.Button()
        CType(Me.numericFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'numericFrom
        '
        Me.numericFrom.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericFrom.Location = New System.Drawing.Point(88, 40)
        Me.numericFrom.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.numericFrom.Name = "numericFrom"
        Me.numericFrom.Size = New System.Drawing.Size(120, 27)
        Me.numericFrom.TabIndex = 0
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(13, 13)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(94, 20)
        Me.lblMain.TabIndex = 2
        Me.lblMain.Text = "School Year:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(224, 42)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 20)
        Me.lblTo.TabIndex = 3
        Me.lblTo.Text = "to"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(145, 92)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(164, 31)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add School Year"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(159, 74)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(150, 15)
        Me.lblInfo.TabIndex = 5
        Me.lblInfo.Text = "School Year already added."
        Me.lblInfo.Visible = False
        '
        'tbSYTo
        '
        Me.tbSYTo.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSYTo.Location = New System.Drawing.Point(253, 40)
        Me.tbSYTo.Name = "tbSYTo"
        Me.tbSYTo.ReadOnly = True
        Me.tbSYTo.Size = New System.Drawing.Size(77, 27)
        Me.tbSYTo.TabIndex = 6
        '
        'lblSetSY
        '
        Me.lblSetSY.AutoSize = True
        Me.lblSetSY.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetSY.Location = New System.Drawing.Point(13, 181)
        Me.lblSetSY.Name = "lblSetSY"
        Me.lblSetSY.Size = New System.Drawing.Size(165, 20)
        Me.lblSetSY.TabIndex = 7
        Me.lblSetSY.Text = "Set Active School Year:"
        '
        'lblActiveSY
        '
        Me.lblActiveSY.AutoSize = True
        Me.lblActiveSY.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveSY.Location = New System.Drawing.Point(12, 152)
        Me.lblActiveSY.Name = "lblActiveSY"
        Me.lblActiveSY.Size = New System.Drawing.Size(240, 21)
        Me.lblActiveSY.TabIndex = 8
        Me.lblActiveSY.Text = "Active School Year - Semester:"
        '
        'cbSY
        '
        Me.cbSY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSY.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSY.FormattingEnabled = True
        Me.cbSY.Location = New System.Drawing.Point(184, 176)
        Me.cbSY.Name = "cbSY"
        Me.cbSY.Size = New System.Drawing.Size(245, 25)
        Me.cbSY.TabIndex = 9
        '
        'btnSetSY
        '
        Me.btnSetSY.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetSY.Location = New System.Drawing.Point(184, 216)
        Me.btnSetSY.Name = "btnSetSY"
        Me.btnSetSY.Size = New System.Drawing.Size(79, 41)
        Me.btnSetSY.TabIndex = 10
        Me.btnSetSY.Text = "Set"
        Me.btnSetSY.UseVisualStyleBackColor = True
        '
        'SchoolYearForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 269)
        Me.Controls.Add(Me.btnSetSY)
        Me.Controls.Add(Me.cbSY)
        Me.Controls.Add(Me.lblActiveSY)
        Me.Controls.Add(Me.lblSetSY)
        Me.Controls.Add(Me.tbSYTo)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.numericFrom)
        Me.Name = "SchoolYearForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "School Year Form"
        CType(Me.numericFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents numericFrom As NumericUpDown
    Friend WithEvents lblMain As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents tbSYTo As TextBox
    Friend WithEvents lblSetSY As Label
    Friend WithEvents lblActiveSY As Label
    Friend WithEvents cbSY As ComboBox
    Friend WithEvents btnSetSY As Button
End Class
