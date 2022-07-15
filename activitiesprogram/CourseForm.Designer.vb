<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseForm
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
        Me.lblCourseName = New System.Windows.Forms.Label()
        Me.lblCourseCode = New System.Windows.Forms.Label()
        Me.tbCourseName = New System.Windows.Forms.TextBox()
        Me.tbCourseCode = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCourseName
        '
        Me.lblCourseName.AutoSize = True
        Me.lblCourseName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseName.Location = New System.Drawing.Point(13, 13)
        Me.lblCourseName.Name = "lblCourseName"
        Me.lblCourseName.Size = New System.Drawing.Size(108, 21)
        Me.lblCourseName.TabIndex = 0
        Me.lblCourseName.Text = "Course Name"
        '
        'lblCourseCode
        '
        Me.lblCourseCode.AutoSize = True
        Me.lblCourseCode.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseCode.Location = New System.Drawing.Point(12, 82)
        Me.lblCourseCode.Name = "lblCourseCode"
        Me.lblCourseCode.Size = New System.Drawing.Size(108, 21)
        Me.lblCourseCode.TabIndex = 1
        Me.lblCourseCode.Text = "Course Code:"
        '
        'tbCourseName
        '
        Me.tbCourseName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCourseName.Location = New System.Drawing.Point(127, 7)
        Me.tbCourseName.Multiline = True
        Me.tbCourseName.Name = "tbCourseName"
        Me.tbCourseName.Size = New System.Drawing.Size(292, 69)
        Me.tbCourseName.TabIndex = 2
        '
        'tbCourseCode
        '
        Me.tbCourseCode.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCourseCode.Location = New System.Drawing.Point(127, 82)
        Me.tbCourseCode.Name = "tbCourseCode"
        Me.tbCourseCode.Size = New System.Drawing.Size(100, 27)
        Me.tbCourseCode.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(162, 129)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(114, 37)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add Course"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(234, 87)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 15)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Visible = False
        '
        'CourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(431, 178)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.tbCourseCode)
        Me.Controls.Add(Me.tbCourseName)
        Me.Controls.Add(Me.lblCourseCode)
        Me.Controls.Add(Me.lblCourseName)
        Me.Name = "CourseForm"
        Me.Text = "Course Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCourseName As Label
    Friend WithEvents lblCourseCode As Label
    Friend WithEvents tbCourseName As TextBox
    Friend WithEvents tbCourseCode As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblStatus As Label
End Class
