<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagement
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
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.btnEditDeleteUser = New System.Windows.Forms.Button()
        Me.btnShowAllUser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddUser
        '
        Me.btnAddUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAddUser.Location = New System.Drawing.Point(108, 109)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(171, 95)
        Me.btnAddUser.TabIndex = 1
        Me.btnAddUser.Text = "Add User"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'btnEditDeleteUser
        '
        Me.btnEditDeleteUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditDeleteUser.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnEditDeleteUser.Location = New System.Drawing.Point(400, 109)
        Me.btnEditDeleteUser.Name = "btnEditDeleteUser"
        Me.btnEditDeleteUser.Size = New System.Drawing.Size(171, 95)
        Me.btnEditDeleteUser.TabIndex = 2
        Me.btnEditDeleteUser.Text = "Edit/Delete User"
        Me.btnEditDeleteUser.UseVisualStyleBackColor = True
        '
        'btnShowAllUser
        '
        Me.btnShowAllUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAllUser.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnShowAllUser.Location = New System.Drawing.Point(263, 286)
        Me.btnShowAllUser.Name = "btnShowAllUser"
        Me.btnShowAllUser.Size = New System.Drawing.Size(171, 95)
        Me.btnShowAllUser.TabIndex = 3
        Me.btnShowAllUser.Text = "Show All User"
        Me.btnShowAllUser.UseVisualStyleBackColor = True
        '
        'UserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 477)
        Me.Controls.Add(Me.btnShowAllUser)
        Me.Controls.Add(Me.btnEditDeleteUser)
        Me.Controls.Add(Me.btnAddUser)
        Me.Name = "UserManagement"
        Me.Text = "UserManagement"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents btnEditDeleteUser As System.Windows.Forms.Button
    Friend WithEvents btnShowAllUser As System.Windows.Forms.Button
End Class
