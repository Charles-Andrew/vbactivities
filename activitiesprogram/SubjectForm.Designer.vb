﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.tbSubjectName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSubjectName.Location = New System.Drawing.Point(13, 46)
        Me.tbSubjectName.Multiline = True
        Me.tbSubjectName.Name = "tbSubjectName"
        Me.tbSubjectName.Size = New System.Drawing.Size(250, 64)
        Me.tbSubjectName.TabIndex = 0
        '
        'lblSubjectName
        '
        Me.lblSubjectName.AutoSize = True
        Me.lblSubjectName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectName.Location = New System.Drawing.Point(9, 13)
        Me.lblSubjectName.Name = "lblSubjectName"
        Me.lblSubjectName.Size = New System.Drawing.Size(102, 15)
        Me.lblSubjectName.TabIndex = 2
        Me.lblSubjectName.Text = "Subject Name:"
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnits.Location = New System.Drawing.Point(278, 13)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(45, 15)
        Me.lblUnits.TabIndex = 3
        Me.lblUnits.Text = "Units:"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(282, 79)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 31)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add Subject"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'numericUnits
        '
        Me.numericUnits.DecimalPlaces = 1
        Me.numericUnits.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericUnits.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numericUnits.Location = New System.Drawing.Point(282, 46)
        Me.numericUnits.Name = "numericUnits"
        Me.numericUnits.Size = New System.Drawing.Size(120, 23)
        Me.numericUnits.TabIndex = 5
        '
        'SubjectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(412, 122)
        Me.Controls.Add(Me.numericUnits)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblSubjectName)
        Me.Controls.Add(Me.tbSubjectName)
        Me.Name = "SubjectForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
