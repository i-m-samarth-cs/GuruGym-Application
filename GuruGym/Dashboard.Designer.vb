<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.btnUserMan = New System.Windows.Forms.Button()
        Me.btnExpiredNAMember = New System.Windows.Forms.Button()
        Me.btnExpiring1_5days = New System.Windows.Forms.Button()
        Me.btnCollectFee = New System.Windows.Forms.Button()
        Me.btnPlanMan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnUserMan
        '
        Me.btnUserMan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserMan.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnUserMan.Location = New System.Drawing.Point(165, 138)
        Me.btnUserMan.Name = "btnUserMan"
        Me.btnUserMan.Size = New System.Drawing.Size(171, 95)
        Me.btnUserMan.TabIndex = 0
        Me.btnUserMan.Text = "User Management"
        Me.btnUserMan.UseVisualStyleBackColor = True
        '
        'btnExpiredNAMember
        '
        Me.btnExpiredNAMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpiredNAMember.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnExpiredNAMember.Location = New System.Drawing.Point(398, 138)
        Me.btnExpiredNAMember.Name = "btnExpiredNAMember"
        Me.btnExpiredNAMember.Size = New System.Drawing.Size(171, 95)
        Me.btnExpiredNAMember.TabIndex = 1
        Me.btnExpiredNAMember.Text = "Expired and Inactive Member"
        Me.btnExpiredNAMember.UseVisualStyleBackColor = True
        '
        'btnExpiring1_5days
        '
        Me.btnExpiring1_5days.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpiring1_5days.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnExpiring1_5days.Location = New System.Drawing.Point(165, 261)
        Me.btnExpiring1_5days.Name = "btnExpiring1_5days"
        Me.btnExpiring1_5days.Size = New System.Drawing.Size(171, 95)
        Me.btnExpiring1_5days.TabIndex = 2
        Me.btnExpiring1_5days.Text = "Expiring in 1-5 days"
        Me.btnExpiring1_5days.UseVisualStyleBackColor = True
        '
        'btnCollectFee
        '
        Me.btnCollectFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCollectFee.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCollectFee.Location = New System.Drawing.Point(398, 261)
        Me.btnCollectFee.Name = "btnCollectFee"
        Me.btnCollectFee.Size = New System.Drawing.Size(171, 95)
        Me.btnCollectFee.TabIndex = 3
        Me.btnCollectFee.Text = "Fee Management"
        Me.btnCollectFee.UseVisualStyleBackColor = True
        '
        'btnPlanMan
        '
        Me.btnPlanMan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlanMan.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnPlanMan.Location = New System.Drawing.Point(281, 388)
        Me.btnPlanMan.Name = "btnPlanMan"
        Me.btnPlanMan.Size = New System.Drawing.Size(171, 95)
        Me.btnPlanMan.TabIndex = 4
        Me.btnPlanMan.Text = "Plan Management"
        Me.btnPlanMan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 38)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Guru Fitness Heath Club"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 527)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPlanMan)
        Me.Controls.Add(Me.btnCollectFee)
        Me.Controls.Add(Me.btnExpiring1_5days)
        Me.Controls.Add(Me.btnExpiredNAMember)
        Me.Controls.Add(Me.btnUserMan)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUserMan As System.Windows.Forms.Button
    Friend WithEvents btnExpiredNAMember As System.Windows.Forms.Button
    Friend WithEvents btnExpiring1_5days As System.Windows.Forms.Button
    Friend WithEvents btnCollectFee As System.Windows.Forms.Button
    Friend WithEvents btnPlanMan As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
