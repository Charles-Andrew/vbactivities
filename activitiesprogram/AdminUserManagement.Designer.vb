<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminUserManagement
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
        Me.lblLoginUsername = New System.Windows.Forms.Label()
        Me.tbAdminUsername = New System.Windows.Forms.TextBox()
        Me.gbHidden = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.tbAdminPassword = New System.Windows.Forms.TextBox()
        Me.lblLoginPassword = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.gbLogin = New System.Windows.Forms.GroupBox()
        Me.gbHidden.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLoginUsername
        '
        Me.lblLoginUsername.AutoSize = True
        Me.lblLoginUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginUsername.Location = New System.Drawing.Point(7, 15)
        Me.lblLoginUsername.Name = "lblLoginUsername"
        Me.lblLoginUsername.Size = New System.Drawing.Size(78, 15)
        Me.lblLoginUsername.TabIndex = 0
        Me.lblLoginUsername.Text = "Username:"
        '
        'tbAdminUsername
        '
        Me.tbAdminUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAdminUsername.Location = New System.Drawing.Point(97, 13)
        Me.tbAdminUsername.Name = "tbAdminUsername"
        Me.tbAdminUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.tbAdminUsername.Size = New System.Drawing.Size(118, 23)
        Me.tbAdminUsername.TabIndex = 1
        Me.tbAdminUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbHidden
        '
        Me.gbHidden.Controls.Add(Me.btnDelete)
        Me.gbHidden.Controls.Add(Me.btnUpdate)
        Me.gbHidden.Controls.Add(Me.tbPassword)
        Me.gbHidden.Controls.Add(Me.Label2)
        Me.gbHidden.Controls.Add(Me.tbUser)
        Me.gbHidden.Controls.Add(Me.lblUsername)
        Me.gbHidden.Controls.Add(Me.dgvUsers)
        Me.gbHidden.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHidden.Location = New System.Drawing.Point(17, 19)
        Me.gbHidden.Name = "gbHidden"
        Me.gbHidden.Size = New System.Drawing.Size(517, 317)
        Me.gbHidden.TabIndex = 2
        Me.gbHidden.TabStop = False
        Me.gbHidden.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(288, 251)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(135, 49)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(147, 251)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(135, 49)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'tbPassword
        '
        Me.tbPassword.Enabled = False
        Me.tbPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(96, 218)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.tbPassword.Size = New System.Drawing.Size(415, 23)
        Me.tbPassword.TabIndex = 6
        Me.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password:"
        '
        'tbUser
        '
        Me.tbUser.Enabled = False
        Me.tbUser.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUser.Location = New System.Drawing.Point(96, 185)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(415, 23)
        Me.tbUser.TabIndex = 4
        Me.tbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(6, 192)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(78, 15)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "Username:"
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.AllowUserToResizeRows = False
        Me.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsers.BackgroundColor = System.Drawing.Color.White
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(6, 19)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsers.Size = New System.Drawing.Size(505, 160)
        Me.dgvUsers.TabIndex = 0
        '
        'tbAdminPassword
        '
        Me.tbAdminPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAdminPassword.Location = New System.Drawing.Point(310, 13)
        Me.tbAdminPassword.Name = "tbAdminPassword"
        Me.tbAdminPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.tbAdminPassword.Size = New System.Drawing.Size(118, 23)
        Me.tbAdminPassword.TabIndex = 4
        Me.tbAdminPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLoginPassword
        '
        Me.lblLoginPassword.AutoSize = True
        Me.lblLoginPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginPassword.Location = New System.Drawing.Point(226, 15)
        Me.lblLoginPassword.Name = "lblLoginPassword"
        Me.lblLoginPassword.Size = New System.Drawing.Size(75, 15)
        Me.lblLoginPassword.TabIndex = 3
        Me.lblLoginPassword.Text = "Password:"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(441, 10)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 27)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'gbLogin
        '
        Me.gbLogin.Controls.Add(Me.tbAdminPassword)
        Me.gbLogin.Controls.Add(Me.btnLogin)
        Me.gbLogin.Controls.Add(Me.lblLoginUsername)
        Me.gbLogin.Controls.Add(Me.tbAdminUsername)
        Me.gbLogin.Controls.Add(Me.lblLoginPassword)
        Me.gbLogin.Location = New System.Drawing.Point(12, 12)
        Me.gbLogin.Name = "gbLogin"
        Me.gbLogin.Size = New System.Drawing.Size(522, 49)
        Me.gbLogin.TabIndex = 6
        Me.gbLogin.TabStop = False
        '
        'AdminUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(546, 348)
        Me.Controls.Add(Me.gbLogin)
        Me.Controls.Add(Me.gbHidden)
        Me.Name = "AdminUserManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Management"
        Me.gbHidden.ResumeLayout(False)
        Me.gbHidden.PerformLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLogin.ResumeLayout(False)
        Me.gbLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblLoginUsername As Label
    Friend WithEvents tbAdminUsername As TextBox
    Friend WithEvents gbHidden As GroupBox
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbUser As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents tbAdminPassword As TextBox
    Friend WithEvents lblLoginPassword As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents gbLogin As GroupBox
End Class
