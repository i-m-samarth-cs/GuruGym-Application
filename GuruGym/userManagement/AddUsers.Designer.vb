<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUsers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            dbconnobj.closeConn()
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
        Me.OFDUploadPhoto = New System.Windows.Forms.OpenFileDialog()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.joiningDate = New System.Windows.Forms.DateTimePicker()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAadhar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.btnUploadPhoto = New System.Windows.Forms.Button()
        Me.picboxUser = New System.Windows.Forms.PictureBox()
        CType(Me.picboxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OFDUploadPhoto
        '
        Me.OFDUploadPhoto.FileName = "OpenFileDialog1"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblOutput.Location = New System.Drawing.Point(246, 381)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblOutput.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(242, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Joining Date"
        '
        'joiningDate
        '
        Me.joiningDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.joiningDate.Location = New System.Drawing.Point(368, 222)
        Me.joiningDate.Name = "joiningDate"
        Me.joiningDate.Size = New System.Drawing.Size(270, 26)
        Me.joiningDate.TabIndex = 26
        '
        'txtMobile
        '
        Me.txtMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobile.Location = New System.Drawing.Point(368, 171)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(270, 26)
        Me.txtMobile.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(239, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Mobile Number"
        '
        'txtAadhar
        '
        Me.txtAadhar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAadhar.Location = New System.Drawing.Point(368, 128)
        Me.txtAadhar.Name = "txtAadhar"
        Me.txtAadhar.Size = New System.Drawing.Size(270, 26)
        Me.txtAadhar.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(239, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Aadhar"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(368, 87)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(270, 26)
        Me.txtEmail.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(239, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Email"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(368, 45)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(270, 26)
        Me.txtName.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Name"
        '
        'btnAddUser
        '
        Me.btnAddUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.Location = New System.Drawing.Point(368, 286)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(155, 57)
        Me.btnAddUser.TabIndex = 17
        Me.btnAddUser.Text = "Submit"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'btnUploadPhoto
        '
        Me.btnUploadPhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadPhoto.Location = New System.Drawing.Point(76, 252)
        Me.btnUploadPhoto.Name = "btnUploadPhoto"
        Me.btnUploadPhoto.Size = New System.Drawing.Size(94, 41)
        Me.btnUploadPhoto.TabIndex = 16
        Me.btnUploadPhoto.Text = "Upload"
        Me.btnUploadPhoto.UseVisualStyleBackColor = True
        '
        'picboxUser
        '
        Me.picboxUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picboxUser.Location = New System.Drawing.Point(54, 40)
        Me.picboxUser.Name = "picboxUser"
        Me.picboxUser.Size = New System.Drawing.Size(160, 195)
        Me.picboxUser.TabIndex = 15
        Me.picboxUser.TabStop = False
        '
        'AddUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 508)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.joiningDate)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAadhar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.btnUploadPhoto)
        Me.Controls.Add(Me.picboxUser)
        Me.Name = "AddUsers"
        Me.Text = "Add User"
        CType(Me.picboxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OFDUploadPhoto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents joiningDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAadhar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents btnUploadPhoto As System.Windows.Forms.Button
    Friend WithEvents picboxUser As System.Windows.Forms.PictureBox
End Class
