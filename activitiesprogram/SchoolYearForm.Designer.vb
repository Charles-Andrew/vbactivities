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
        'SchoolYearForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 131)
        Me.Controls.Add(Me.tbSYTo)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.numericFrom)
        Me.Name = "SchoolYearForm"
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
End Class
