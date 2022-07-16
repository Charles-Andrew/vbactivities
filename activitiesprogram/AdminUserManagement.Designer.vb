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
        Me.lblSecretKey = New System.Windows.Forms.Label()
        Me.tbSecretKey = New System.Windows.Forms.TextBox()
        Me.gbHidden = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.gbHidden.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSecretKey
        '
        Me.lblSecretKey.AutoSize = True
        Me.lblSecretKey.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecretKey.Location = New System.Drawing.Point(13, 13)
        Me.lblSecretKey.Name = "lblSecretKey"
        Me.lblSecretKey.Size = New System.Drawing.Size(84, 20)
        Me.lblSecretKey.TabIndex = 0
        Me.lblSecretKey.Text = "Secret Key:"
        '
        'tbSecretKey
        '
        Me.tbSecretKey.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSecretKey.Location = New System.Drawing.Point(103, 6)
        Me.tbSecretKey.Name = "tbSecretKey"
        Me.tbSecretKey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.tbSecretKey.Size = New System.Drawing.Size(396, 27)
        Me.tbSecretKey.TabIndex = 1
        Me.tbSecretKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.gbHidden.Location = New System.Drawing.Point(17, 37)
        Me.gbHidden.Name = "gbHidden"
        Me.gbHidden.Size = New System.Drawing.Size(482, 317)
        Me.gbHidden.TabIndex = 2
        Me.gbHidden.TabStop = False
        Me.gbHidden.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(258, 251)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(135, 49)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(117, 251)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(135, 49)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'tbPassword
        '
        Me.tbPassword.Enabled = False
        Me.tbPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(96, 218)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.tbPassword.Size = New System.Drawing.Size(380, 27)
        Me.tbPassword.TabIndex = 6
        Me.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password:"
        '
        'tbUser
        '
        Me.tbUser.Enabled = False
        Me.tbUser.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUser.Location = New System.Drawing.Point(96, 185)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(380, 27)
        Me.tbUser.TabIndex = 4
        Me.tbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(6, 192)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(82, 20)
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
        Me.dgvUsers.Size = New System.Drawing.Size(470, 160)
        Me.dgvUsers.TabIndex = 0
        '
        'AdminUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(511, 366)
        Me.Controls.Add(Me.gbHidden)
        Me.Controls.Add(Me.tbSecretKey)
        Me.Controls.Add(Me.lblSecretKey)
        Me.Name = "AdminUserManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Management"
        Me.gbHidden.ResumeLayout(False)
        Me.gbHidden.PerformLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSecretKey As Label
    Friend WithEvents tbSecretKey As TextBox
    Friend WithEvents gbHidden As GroupBox
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbUser As TextBox
    Friend WithEvents lblUsername As Label
End Class
