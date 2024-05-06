<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpiredInactive
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
        Me.tabControlExpiredNotActive = New System.Windows.Forms.TabControl()
        Me.tabpExpired = New System.Windows.Forms.TabPage()
        Me.tabpInactive = New System.Windows.Forms.TabPage()
        Me.tabControlExpiredNotActive.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControlExpiredNotActive
        '
        Me.tabControlExpiredNotActive.Controls.Add(Me.tabpExpired)
        Me.tabControlExpiredNotActive.Controls.Add(Me.tabpInactive)
        Me.tabControlExpiredNotActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControlExpiredNotActive.Location = New System.Drawing.Point(12, 21)
        Me.tabControlExpiredNotActive.Name = "tabControlExpiredNotActive"
        Me.tabControlExpiredNotActive.SelectedIndex = 0
        Me.tabControlExpiredNotActive.Size = New System.Drawing.Size(639, 420)
        Me.tabControlExpiredNotActive.TabIndex = 0
        '
        'tabpExpired
        '
        Me.tabpExpired.Location = New System.Drawing.Point(4, 33)
        Me.tabpExpired.Name = "tabpExpired"
        Me.tabpExpired.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpExpired.Size = New System.Drawing.Size(631, 383)
        Me.tabpExpired.TabIndex = 0
        Me.tabpExpired.Text = "Expired Member"
        Me.tabpExpired.UseVisualStyleBackColor = True
        '
        'tabpInactive
        '
        Me.tabpInactive.Location = New System.Drawing.Point(4, 33)
        Me.tabpInactive.Name = "tabpInactive"
        Me.tabpInactive.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpInactive.Size = New System.Drawing.Size(631, 383)
        Me.tabpInactive.TabIndex = 1
        Me.tabpInactive.Text = "Inactive Member"
        Me.tabpInactive.UseVisualStyleBackColor = True
        '
        'ExpiredNotActive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 460)
        Me.Controls.Add(Me.tabControlExpiredNotActive)
        Me.Name = "ExpiredNotActive"
        Me.Text = "Expired and Not Active Member"
        Me.tabControlExpiredNotActive.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabControlExpiredNotActive As System.Windows.Forms.TabControl
    Friend WithEvents tabpExpired As System.Windows.Forms.TabPage
    Friend WithEvents tabpInactive As System.Windows.Forms.TabPage
End Class
