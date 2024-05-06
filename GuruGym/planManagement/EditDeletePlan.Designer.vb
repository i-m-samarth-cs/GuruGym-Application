<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDeletePlan
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabName = New System.Windows.Forms.TabPage()
        Me.btnName = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdName = New System.Windows.Forms.ComboBox()
        Me.tabID = New System.Windows.Forms.TabPage()
        Me.btnID = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdID = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.rbtnInactive = New System.Windows.Forms.RadioButton()
        Me.rbtnActive = New System.Windows.Forms.RadioButton()
        Me.txtMonths = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabName.SuspendLayout()
        Me.tabID.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 24)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Find By"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabName)
        Me.TabControl1.Controls.Add(Me.tabID)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(134, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(390, 171)
        Me.TabControl1.TabIndex = 4
        '
        'tabName
        '
        Me.tabName.Controls.Add(Me.btnName)
        Me.tabName.Controls.Add(Me.Label1)
        Me.tabName.Controls.Add(Me.cmdName)
        Me.tabName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabName.Location = New System.Drawing.Point(4, 29)
        Me.tabName.Name = "tabName"
        Me.tabName.Padding = New System.Windows.Forms.Padding(3)
        Me.tabName.Size = New System.Drawing.Size(382, 138)
        Me.tabName.TabIndex = 0
        Me.tabName.Text = "Name"
        Me.tabName.UseVisualStyleBackColor = True
        '
        'btnName
        '
        Me.btnName.Location = New System.Drawing.Point(139, 84)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(101, 44)
        Me.btnName.TabIndex = 2
        Me.btnName.Text = "Find"
        Me.btnName.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'cmdName
        '
        Me.cmdName.FormattingEnabled = True
        Me.cmdName.Location = New System.Drawing.Point(115, 36)
        Me.cmdName.Name = "cmdName"
        Me.cmdName.Size = New System.Drawing.Size(189, 32)
        Me.cmdName.TabIndex = 0
        '
        'tabID
        '
        Me.tabID.Controls.Add(Me.btnID)
        Me.tabID.Controls.Add(Me.Label2)
        Me.tabID.Controls.Add(Me.cmdID)
        Me.tabID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabID.Location = New System.Drawing.Point(4, 29)
        Me.tabID.Name = "tabID"
        Me.tabID.Padding = New System.Windows.Forms.Padding(3)
        Me.tabID.Size = New System.Drawing.Size(382, 138)
        Me.tabID.TabIndex = 1
        Me.tabID.Text = "ID"
        Me.tabID.UseVisualStyleBackColor = True
        '
        'btnID
        '
        Me.btnID.Location = New System.Drawing.Point(141, 72)
        Me.btnID.Name = "btnID"
        Me.btnID.Size = New System.Drawing.Size(89, 41)
        Me.btnID.TabIndex = 2
        Me.btnID.Text = "Find"
        Me.btnID.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID:"
        '
        'cmdID
        '
        Me.cmdID.FormattingEnabled = True
        Me.cmdID.Location = New System.Drawing.Point(127, 27)
        Me.cmdID.Name = "cmdID"
        Me.cmdID.Size = New System.Drawing.Size(121, 32)
        Me.cmdID.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.rbtnInactive)
        Me.Panel1.Controls.Add(Me.rbtnActive)
        Me.Panel1.Controls.Add(Me.txtMonths)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(41, 201)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 273)
        Me.Panel1.TabIndex = 5
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(298, 213)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(114, 36)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(147, 213)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(114, 36)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'rbtnInactive
        '
        Me.rbtnInactive.AutoSize = True
        Me.rbtnInactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnInactive.Location = New System.Drawing.Point(334, 165)
        Me.rbtnInactive.Name = "rbtnInactive"
        Me.rbtnInactive.Size = New System.Drawing.Size(90, 24)
        Me.rbtnInactive.TabIndex = 15
        Me.rbtnInactive.TabStop = True
        Me.rbtnInactive.Text = "Inactive"
        Me.rbtnInactive.UseVisualStyleBackColor = True
        '
        'rbtnActive
        '
        Me.rbtnActive.AutoSize = True
        Me.rbtnActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnActive.Location = New System.Drawing.Point(168, 165)
        Me.rbtnActive.Name = "rbtnActive"
        Me.rbtnActive.Size = New System.Drawing.Size(76, 24)
        Me.rbtnActive.TabIndex = 14
        Me.rbtnActive.TabStop = True
        Me.rbtnActive.Text = "Active"
        Me.rbtnActive.UseVisualStyleBackColor = True
        '
        'txtMonths
        '
        Me.txtMonths.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonths.Location = New System.Drawing.Point(268, 72)
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.Size = New System.Drawing.Size(156, 26)
        Me.txtMonths.TabIndex = 13
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(268, 117)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(156, 26)
        Me.txtAmount.TabIndex = 12
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(268, 29)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(156, 26)
        Me.txtName.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(124, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Amount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(137, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Month:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(139, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Name:"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.ForeColor = System.Drawing.Color.Red
        Me.lblOutput.Location = New System.Drawing.Point(115, 486)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 24)
        Me.lblOutput.TabIndex = 6
        '
        'EditDeletePlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 517)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "EditDeletePlan"
        Me.Text = "EditPlan"
        Me.TabControl1.ResumeLayout(False)
        Me.tabName.ResumeLayout(False)
        Me.tabName.PerformLayout()
        Me.tabID.ResumeLayout(False)
        Me.tabID.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabName As System.Windows.Forms.TabPage
    Friend WithEvents tabID As System.Windows.Forms.TabPage
    Friend WithEvents cmdName As System.Windows.Forms.ComboBox
    Friend WithEvents cmdID As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnName As System.Windows.Forms.Button
    Friend WithEvents btnID As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtMonths As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbtnInactive As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnActive As System.Windows.Forms.RadioButton
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label
End Class
