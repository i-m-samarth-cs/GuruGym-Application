<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanManagement
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
        Me.btnShowAllPlan = New System.Windows.Forms.Button()
        Me.btnEditDeletePlan = New System.Windows.Forms.Button()
        Me.btnAddPlan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShowAllPlan
        '
        Me.btnShowAllPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAllPlan.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnShowAllPlan.Location = New System.Drawing.Point(228, 268)
        Me.btnShowAllPlan.Name = "btnShowAllPlan"
        Me.btnShowAllPlan.Size = New System.Drawing.Size(171, 95)
        Me.btnShowAllPlan.TabIndex = 6
        Me.btnShowAllPlan.Text = "Show All Plan"
        Me.btnShowAllPlan.UseVisualStyleBackColor = True
        '
        'btnEditDeletePlan
        '
        Me.btnEditDeletePlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditDeletePlan.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnEditDeletePlan.Location = New System.Drawing.Point(377, 91)
        Me.btnEditDeletePlan.Name = "btnEditDeletePlan"
        Me.btnEditDeletePlan.Size = New System.Drawing.Size(171, 95)
        Me.btnEditDeletePlan.TabIndex = 5
        Me.btnEditDeletePlan.Text = "Edit/Delete Plan"
        Me.btnEditDeletePlan.UseVisualStyleBackColor = True
        '
        'btnAddPlan
        '
        Me.btnAddPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPlan.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAddPlan.Location = New System.Drawing.Point(85, 91)
        Me.btnAddPlan.Name = "btnAddPlan"
        Me.btnAddPlan.Size = New System.Drawing.Size(171, 95)
        Me.btnAddPlan.TabIndex = 4
        Me.btnAddPlan.Text = "Add Plan"
        Me.btnAddPlan.UseVisualStyleBackColor = True
        '
        'PlanManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 455)
        Me.Controls.Add(Me.btnShowAllPlan)
        Me.Controls.Add(Me.btnEditDeletePlan)
        Me.Controls.Add(Me.btnAddPlan)
        Me.Name = "PlanManagement"
        Me.Text = "PlanManagement"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnShowAllPlan As System.Windows.Forms.Button
    Friend WithEvents btnEditDeletePlan As System.Windows.Forms.Button
    Friend WithEvents btnAddPlan As System.Windows.Forms.Button
End Class
