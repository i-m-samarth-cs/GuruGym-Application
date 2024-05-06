<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeeManagement
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
        Me.btnCollectFee = New System.Windows.Forms.Button()
        Me.btnEditDeleteFee = New System.Windows.Forms.Button()
        Me.btnFeeHistory = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCollectFee
        '
        Me.btnCollectFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCollectFee.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCollectFee.Location = New System.Drawing.Point(64, 83)
        Me.btnCollectFee.Name = "btnCollectFee"
        Me.btnCollectFee.Size = New System.Drawing.Size(171, 95)
        Me.btnCollectFee.TabIndex = 5
        Me.btnCollectFee.Text = "Collect Fee"
        Me.btnCollectFee.UseVisualStyleBackColor = True
        '
        'btnEditDeleteFee
        '
        Me.btnEditDeleteFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditDeleteFee.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnEditDeleteFee.Location = New System.Drawing.Point(299, 83)
        Me.btnEditDeleteFee.Name = "btnEditDeleteFee"
        Me.btnEditDeleteFee.Size = New System.Drawing.Size(171, 95)
        Me.btnEditDeleteFee.TabIndex = 6
        Me.btnEditDeleteFee.Text = "Edit/Delete Collected Fee"
        Me.btnEditDeleteFee.UseVisualStyleBackColor = True
        '
        'btnFeeHistory
        '
        Me.btnFeeHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFeeHistory.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnFeeHistory.Location = New System.Drawing.Point(172, 246)
        Me.btnFeeHistory.Name = "btnFeeHistory"
        Me.btnFeeHistory.Size = New System.Drawing.Size(171, 95)
        Me.btnFeeHistory.TabIndex = 7
        Me.btnFeeHistory.Text = "Fee History"
        Me.btnFeeHistory.UseVisualStyleBackColor = True
        '
        'FeeManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 425)
        Me.Controls.Add(Me.btnFeeHistory)
        Me.Controls.Add(Me.btnEditDeleteFee)
        Me.Controls.Add(Me.btnCollectFee)
        Me.Name = "FeeManagement"
        Me.Text = "FeeManagement"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCollectFee As System.Windows.Forms.Button
    Friend WithEvents btnEditDeleteFee As System.Windows.Forms.Button
    Friend WithEvents btnFeeHistory As System.Windows.Forms.Button
End Class
