<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnSM = New System.Windows.Forms.Button()
        Me.btnCM = New System.Windows.Forms.Button()
        Me.btnTML = New System.Windows.Forms.Button()
        Me.btnSML = New System.Windows.Forms.Button()
        Me.btnSchoolYear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSM
        '
        Me.btnSM.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSM.Image = Global.activitiesprogram.My.Resources.Resources.bookshelf
        Me.btnSM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSM.Location = New System.Drawing.Point(171, 252)
        Me.btnSM.Name = "btnSM"
        Me.btnSM.Size = New System.Drawing.Size(173, 74)
        Me.btnSM.TabIndex = 3
        Me.btnSM.Text = "Subject Management"
        Me.btnSM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSM.UseVisualStyleBackColor = True
        '
        'btnCM
        '
        Me.btnCM.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCM.Image = Global.activitiesprogram.My.Resources.Resources.education
        Me.btnCM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCM.Location = New System.Drawing.Point(171, 172)
        Me.btnCM.Name = "btnCM"
        Me.btnCM.Size = New System.Drawing.Size(173, 74)
        Me.btnCM.TabIndex = 2
        Me.btnCM.Text = "Course Management"
        Me.btnCM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCM.UseVisualStyleBackColor = True
        '
        'btnTML
        '
        Me.btnTML.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTML.Image = Global.activitiesprogram.My.Resources.Resources.male
        Me.btnTML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTML.Location = New System.Drawing.Point(171, 92)
        Me.btnTML.Name = "btnTML"
        Me.btnTML.Size = New System.Drawing.Size(173, 74)
        Me.btnTML.TabIndex = 1
        Me.btnTML.Text = "Teacher Master List"
        Me.btnTML.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTML.UseVisualStyleBackColor = True
        '
        'btnSML
        '
        Me.btnSML.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSML.Image = Global.activitiesprogram.My.Resources.Resources.reading
        Me.btnSML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSML.Location = New System.Drawing.Point(171, 12)
        Me.btnSML.Name = "btnSML"
        Me.btnSML.Size = New System.Drawing.Size(173, 74)
        Me.btnSML.TabIndex = 0
        Me.btnSML.Text = "Student Master List"
        Me.btnSML.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSML.UseVisualStyleBackColor = True
        '
        'btnSchoolYear
        '
        Me.btnSchoolYear.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSchoolYear.Image = Global.activitiesprogram.My.Resources.Resources.bookshelf
        Me.btnSchoolYear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSchoolYear.Location = New System.Drawing.Point(171, 332)
        Me.btnSchoolYear.Name = "btnSchoolYear"
        Me.btnSchoolYear.Size = New System.Drawing.Size(173, 74)
        Me.btnSchoolYear.TabIndex = 4
        Me.btnSchoolYear.Text = "Add New School Year"
        Me.btnSchoolYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSchoolYear.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 410)
        Me.Controls.Add(Me.btnSchoolYear)
        Me.Controls.Add(Me.btnSM)
        Me.Controls.Add(Me.btnCM)
        Me.Controls.Add(Me.btnTML)
        Me.Controls.Add(Me.btnSML)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSML As Button
    Friend WithEvents btnTML As Button
    Friend WithEvents btnCM As Button
    Friend WithEvents btnSM As Button
    Friend WithEvents btnSchoolYear As Button
End Class
