﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(340, 49)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(83, 53)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(179, 13)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(108, 22)
        Me.lblMain.TabIndex = 1
        Me.lblMain.Text = "User Login"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(42, 49)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(78, 15)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(42, 75)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(75, 15)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password:"
        '
        'tbUsername
        '
        Me.tbUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsername.Location = New System.Drawing.Point(128, 49)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(206, 23)
        Me.tbUsername.TabIndex = 4
        Me.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbPassword
        '
        Me.tbPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(128, 75)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.tbPassword.Size = New System.Drawing.Size(206, 23)
        Me.tbPassword.TabIndex = 5
        Me.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.Transparent
        Me.btnRegister.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(128, 126)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(71, 26)
        Me.btnRegister.TabIndex = 7
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnAdmin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.Location = New System.Drawing.Point(205, 126)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(129, 26)
        Me.btnAdmin.TabIndex = 8
        Me.btnAdmin.Text = "Login as Admin"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(462, 165)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents lblMain As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnAdmin As Button
End Class
