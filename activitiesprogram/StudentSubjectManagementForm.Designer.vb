<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentSubjectManagementForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.dgvStudentSubjects = New System.Windows.Forms.DataGridView()
        Me.lblEnrolledSubjects = New System.Windows.Forms.Label()
        Me.btnUnenroll = New System.Windows.Forms.Button()
        Me.btnEnroll = New System.Windows.Forms.Button()
        Me.lblListOfAvailableSubjects = New System.Windows.Forms.Label()
        Me.cbAvailableSubjects = New System.Windows.Forms.ComboBox()
        CType(Me.dgvStudentSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(13, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(54, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.Location = New System.Drawing.Point(73, 13)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(53, 20)
        Me.lblStudentName.TabIndex = 1
        Me.lblStudentName.Text = "Label2"
        '
        'dgvStudentSubjects
        '
        Me.dgvStudentSubjects.AllowUserToAddRows = False
        Me.dgvStudentSubjects.AllowUserToDeleteRows = False
        Me.dgvStudentSubjects.AllowUserToResizeRows = False
        Me.dgvStudentSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStudentSubjects.BackgroundColor = System.Drawing.Color.White
        Me.dgvStudentSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStudentSubjects.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStudentSubjects.Location = New System.Drawing.Point(17, 131)
        Me.dgvStudentSubjects.Name = "dgvStudentSubjects"
        Me.dgvStudentSubjects.ReadOnly = True
        Me.dgvStudentSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudentSubjects.Size = New System.Drawing.Size(771, 150)
        Me.dgvStudentSubjects.TabIndex = 2
        '
        'lblEnrolledSubjects
        '
        Me.lblEnrolledSubjects.AutoSize = True
        Me.lblEnrolledSubjects.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnrolledSubjects.Location = New System.Drawing.Point(13, 108)
        Me.lblEnrolledSubjects.Name = "lblEnrolledSubjects"
        Me.lblEnrolledSubjects.Size = New System.Drawing.Size(130, 20)
        Me.lblEnrolledSubjects.TabIndex = 3
        Me.lblEnrolledSubjects.Text = "Enrolled Subjects:"
        '
        'btnUnenroll
        '
        Me.btnUnenroll.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnenroll.Location = New System.Drawing.Point(713, 284)
        Me.btnUnenroll.Name = "btnUnenroll"
        Me.btnUnenroll.Size = New System.Drawing.Size(75, 28)
        Me.btnUnenroll.TabIndex = 7
        Me.btnUnenroll.Text = "Unenroll"
        Me.btnUnenroll.UseVisualStyleBackColor = True
        '
        'btnEnroll
        '
        Me.btnEnroll.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnroll.Location = New System.Drawing.Point(692, 66)
        Me.btnEnroll.Name = "btnEnroll"
        Me.btnEnroll.Size = New System.Drawing.Size(96, 28)
        Me.btnEnroll.TabIndex = 10
        Me.btnEnroll.Text = "Enroll Subject"
        Me.btnEnroll.UseVisualStyleBackColor = True
        '
        'lblListOfAvailableSubjects
        '
        Me.lblListOfAvailableSubjects.AutoSize = True
        Me.lblListOfAvailableSubjects.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListOfAvailableSubjects.Location = New System.Drawing.Point(13, 44)
        Me.lblListOfAvailableSubjects.Name = "lblListOfAvailableSubjects"
        Me.lblListOfAvailableSubjects.Size = New System.Drawing.Size(136, 20)
        Me.lblListOfAvailableSubjects.TabIndex = 9
        Me.lblListOfAvailableSubjects.Text = "Available Subjects:"
        '
        'cbAvailableSubjects
        '
        Me.cbAvailableSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAvailableSubjects.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAvailableSubjects.FormattingEnabled = True
        Me.cbAvailableSubjects.Location = New System.Drawing.Point(17, 67)
        Me.cbAvailableSubjects.Name = "cbAvailableSubjects"
        Me.cbAvailableSubjects.Size = New System.Drawing.Size(669, 28)
        Me.cbAvailableSubjects.TabIndex = 8
        '
        'StudentSubjectManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 322)
        Me.Controls.Add(Me.btnEnroll)
        Me.Controls.Add(Me.lblListOfAvailableSubjects)
        Me.Controls.Add(Me.cbAvailableSubjects)
        Me.Controls.Add(Me.btnUnenroll)
        Me.Controls.Add(Me.lblEnrolledSubjects)
        Me.Controls.Add(Me.dgvStudentSubjects)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "StudentSubjectManagementForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Subject Management"
        CType(Me.dgvStudentSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents dgvStudentSubjects As DataGridView
    Friend WithEvents lblEnrolledSubjects As Label
    Friend WithEvents btnUnenroll As Button
    Friend WithEvents btnEnroll As Button
    Friend WithEvents lblListOfAvailableSubjects As Label
    Friend WithEvents cbAvailableSubjects As ComboBox
End Class
