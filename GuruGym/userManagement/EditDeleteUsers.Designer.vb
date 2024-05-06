<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDeleteUsers
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabUserID = New System.Windows.Forms.TabPage()
        Me.cmbUserID = New System.Windows.Forms.ComboBox()
        Me.btnUserID = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabName = New System.Windows.Forms.TabPage()
        Me.btnPrevName = New System.Windows.Forms.Button()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.btnNextName = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabMobileNumber = New System.Windows.Forms.TabPage()
        Me.cmbMobileNumber = New System.Windows.Forms.ComboBox()
        Me.btnMobileNumber = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabAadhar = New System.Windows.Forms.TabPage()
        Me.cmbAadhar = New System.Windows.Forms.ComboBox()
        Me.btnAadhar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.rbtnInActive = New System.Windows.Forms.RadioButton()
        Me.rbtnActive = New System.Windows.Forms.RadioButton()
        Me.btnAddChangePhoto = New System.Windows.Forms.Button()
        Me.btnUpdateDetails = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.joiningDate = New System.Windows.Forms.DateTimePicker()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAadhar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblUID = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabUserID.SuspendLayout()
        Me.tabName.SuspendLayout()
        Me.tabMobileNumber.SuspendLayout()
        Me.tabAadhar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TabControl1.Controls.Add(Me.tabUserID)
        Me.TabControl1.Controls.Add(Me.tabName)
        Me.TabControl1.Controls.Add(Me.tabMobileNumber)
        Me.TabControl1.Controls.Add(Me.tabAadhar)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(121, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(424, 163)
        Me.TabControl1.TabIndex = 0
        '
        'tabUserID
        '
        Me.tabUserID.Controls.Add(Me.cmbUserID)
        Me.tabUserID.Controls.Add(Me.btnUserID)
        Me.tabUserID.Controls.Add(Me.Label1)
        Me.tabUserID.Location = New System.Drawing.Point(4, 27)
        Me.tabUserID.Name = "tabUserID"
        Me.tabUserID.Padding = New System.Windows.Forms.Padding(3)
        Me.tabUserID.Size = New System.Drawing.Size(416, 132)
        Me.tabUserID.TabIndex = 0
        Me.tabUserID.Text = "User ID"
        Me.tabUserID.UseVisualStyleBackColor = True
        '
        'cmbUserID
        '
        Me.cmbUserID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbUserID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUserID.FormattingEnabled = True
        Me.cmbUserID.Location = New System.Drawing.Point(219, 36)
        Me.cmbUserID.Name = "cmbUserID"
        Me.cmbUserID.Size = New System.Drawing.Size(95, 32)
        Me.cmbUserID.TabIndex = 3
        '
        'btnUserID
        '
        Me.btnUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserID.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnUserID.Location = New System.Drawing.Point(219, 85)
        Me.btnUserID.Name = "btnUserID"
        Me.btnUserID.Size = New System.Drawing.Size(95, 36)
        Me.btnUserID.TabIndex = 2
        Me.btnUserID.Text = "Find"
        Me.btnUserID.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(102, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User ID:"
        '
        'tabName
        '
        Me.tabName.Controls.Add(Me.btnPrevName)
        Me.tabName.Controls.Add(Me.cmbName)
        Me.tabName.Controls.Add(Me.btnNextName)
        Me.tabName.Controls.Add(Me.Label2)
        Me.tabName.Location = New System.Drawing.Point(4, 27)
        Me.tabName.Name = "tabName"
        Me.tabName.Padding = New System.Windows.Forms.Padding(3)
        Me.tabName.Size = New System.Drawing.Size(416, 132)
        Me.tabName.TabIndex = 1
        Me.tabName.Text = "Name"
        Me.tabName.UseVisualStyleBackColor = True
        '
        'btnPrevName
        '
        Me.btnPrevName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevName.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnPrevName.Location = New System.Drawing.Point(279, 84)
        Me.btnPrevName.Name = "btnPrevName"
        Me.btnPrevName.Size = New System.Drawing.Size(95, 36)
        Me.btnPrevName.TabIndex = 5
        Me.btnPrevName.Text = "Find Prev"
        Me.btnPrevName.UseVisualStyleBackColor = True
        '
        'cmbName
        '
        Me.cmbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.Location = New System.Drawing.Point(169, 35)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(205, 32)
        Me.cmbName.TabIndex = 4
        '
        'btnNextName
        '
        Me.btnNextName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextName.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnNextName.Location = New System.Drawing.Point(129, 84)
        Me.btnNextName.Name = "btnNextName"
        Me.btnNextName.Size = New System.Drawing.Size(95, 36)
        Me.btnNextName.TabIndex = 3
        Me.btnNextName.Text = "Find Next"
        Me.btnNextName.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(96, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'tabMobileNumber
        '
        Me.tabMobileNumber.Controls.Add(Me.cmbMobileNumber)
        Me.tabMobileNumber.Controls.Add(Me.btnMobileNumber)
        Me.tabMobileNumber.Controls.Add(Me.Label3)
        Me.tabMobileNumber.Location = New System.Drawing.Point(4, 27)
        Me.tabMobileNumber.Name = "tabMobileNumber"
        Me.tabMobileNumber.Size = New System.Drawing.Size(416, 132)
        Me.tabMobileNumber.TabIndex = 2
        Me.tabMobileNumber.Text = "Mobile Number"
        Me.tabMobileNumber.UseVisualStyleBackColor = True
        '
        'cmbMobileNumber
        '
        Me.cmbMobileNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMobileNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMobileNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMobileNumber.FormattingEnabled = True
        Me.cmbMobileNumber.Location = New System.Drawing.Point(176, 35)
        Me.cmbMobileNumber.Name = "cmbMobileNumber"
        Me.cmbMobileNumber.Size = New System.Drawing.Size(205, 32)
        Me.cmbMobileNumber.TabIndex = 5
        '
        'btnMobileNumber
        '
        Me.btnMobileNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMobileNumber.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnMobileNumber.Location = New System.Drawing.Point(229, 82)
        Me.btnMobileNumber.Name = "btnMobileNumber"
        Me.btnMobileNumber.Size = New System.Drawing.Size(95, 36)
        Me.btnMobileNumber.TabIndex = 3
        Me.btnMobileNumber.Text = "Find"
        Me.btnMobileNumber.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(51, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mobile Number:"
        '
        'tabAadhar
        '
        Me.tabAadhar.Controls.Add(Me.cmbAadhar)
        Me.tabAadhar.Controls.Add(Me.btnAadhar)
        Me.tabAadhar.Controls.Add(Me.Label4)
        Me.tabAadhar.Location = New System.Drawing.Point(4, 27)
        Me.tabAadhar.Name = "tabAadhar"
        Me.tabAadhar.Size = New System.Drawing.Size(416, 132)
        Me.tabAadhar.TabIndex = 3
        Me.tabAadhar.Text = "Aadhar"
        Me.tabAadhar.UseVisualStyleBackColor = True
        '
        'cmbAadhar
        '
        Me.cmbAadhar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAadhar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAadhar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAadhar.FormattingEnabled = True
        Me.cmbAadhar.Location = New System.Drawing.Point(161, 35)
        Me.cmbAadhar.Name = "cmbAadhar"
        Me.cmbAadhar.Size = New System.Drawing.Size(205, 32)
        Me.cmbAadhar.TabIndex = 6
        '
        'btnAadhar
        '
        Me.btnAadhar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAadhar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnAadhar.Location = New System.Drawing.Point(212, 78)
        Me.btnAadhar.Name = "btnAadhar"
        Me.btnAadhar.Size = New System.Drawing.Size(95, 36)
        Me.btnAadhar.TabIndex = 3
        Me.btnAadhar.Text = "Find"
        Me.btnAadhar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(69, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Aadhar:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblOutput)
        Me.Panel1.Controls.Add(Me.rbtnInActive)
        Me.Panel1.Controls.Add(Me.btnDeleteUser)
        Me.Panel1.Controls.Add(Me.rbtnActive)
        Me.Panel1.Controls.Add(Me.btnAddChangePhoto)
        Me.Panel1.Controls.Add(Me.btnUpdateDetails)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.joiningDate)
        Me.Panel1.Controls.Add(Me.txtMobile)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtAadhar)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(27, 176)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 294)
        Me.Panel1.TabIndex = 1
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblOutput.Location = New System.Drawing.Point(439, 259)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 20)
        Me.lblOutput.TabIndex = 3
        '
        'rbtnInActive
        '
        Me.rbtnInActive.AutoSize = True
        Me.rbtnInActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnInActive.Location = New System.Drawing.Point(310, 218)
        Me.rbtnInActive.Name = "rbtnInActive"
        Me.rbtnInActive.Size = New System.Drawing.Size(120, 24)
        Me.rbtnInActive.TabIndex = 56
        Me.rbtnInActive.TabStop = True
        Me.rbtnInActive.Text = "Inactive User"
        Me.rbtnInActive.UseVisualStyleBackColor = True
        '
        'rbtnActive
        '
        Me.rbtnActive.AutoSize = True
        Me.rbtnActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnActive.Location = New System.Drawing.Point(171, 217)
        Me.rbtnActive.Name = "rbtnActive"
        Me.rbtnActive.Size = New System.Drawing.Size(108, 24)
        Me.rbtnActive.TabIndex = 55
        Me.rbtnActive.TabStop = True
        Me.rbtnActive.Text = "Active User"
        Me.rbtnActive.UseVisualStyleBackColor = True
        '
        'btnAddChangePhoto
        '
        Me.btnAddChangePhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddChangePhoto.Location = New System.Drawing.Point(581, 183)
        Me.btnAddChangePhoto.Name = "btnAddChangePhoto"
        Me.btnAddChangePhoto.Size = New System.Drawing.Size(115, 57)
        Me.btnAddChangePhoto.TabIndex = 54
        Me.btnAddChangePhoto.Text = "Add/Change Photo"
        Me.btnAddChangePhoto.UseVisualStyleBackColor = True
        '
        'btnUpdateDetails
        '
        Me.btnUpdateDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateDetails.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnUpdateDetails.Location = New System.Drawing.Point(125, 247)
        Me.btnUpdateDetails.Name = "btnUpdateDetails"
        Me.btnUpdateDetails.Size = New System.Drawing.Size(180, 40)
        Me.btnUpdateDetails.TabIndex = 53
        Me.btnUpdateDetails.Text = "Update Changes"
        Me.btnUpdateDetails.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(70, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 18)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Joining Date"
        '
        'joiningDate
        '
        Me.joiningDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.joiningDate.Location = New System.Drawing.Point(194, 178)
        Me.joiningDate.Name = "joiningDate"
        Me.joiningDate.Size = New System.Drawing.Size(270, 24)
        Me.joiningDate.TabIndex = 49
        '
        'txtMobile
        '
        Me.txtMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobile.Location = New System.Drawing.Point(196, 129)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(268, 24)
        Me.txtMobile.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(67, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 18)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Mobile Number"
        '
        'txtAadhar
        '
        Me.txtAadhar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAadhar.Location = New System.Drawing.Point(196, 86)
        Me.txtAadhar.Name = "txtAadhar"
        Me.txtAadhar.Size = New System.Drawing.Size(268, 24)
        Me.txtAadhar.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(67, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 18)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Aadhar"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(196, 45)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(268, 24)
        Me.txtEmail.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(67, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 18)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Email"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(196, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(268, 24)
        Me.txtName.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(67, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 18)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(550, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(173, 161)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 24)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Find By"
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteUser.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnDeleteUser.Location = New System.Drawing.Point(334, 247)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(180, 40)
        Me.btnDeleteUser.TabIndex = 57
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(573, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 24)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "UID:"
        '
        'lblUID
        '
        Me.lblUID.AutoSize = True
        Me.lblUID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUID.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblUID.Location = New System.Drawing.Point(632, 69)
        Me.lblUID.Name = "lblUID"
        Me.lblUID.Size = New System.Drawing.Size(0, 24)
        Me.lblUID.TabIndex = 59
        '
        'EditDeleteUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 538)
        Me.Controls.Add(Me.lblUID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "EditDeleteUsers"
        Me.Text = "EditMember"
        Me.TabControl1.ResumeLayout(False)
        Me.tabUserID.ResumeLayout(False)
        Me.tabUserID.PerformLayout()
        Me.tabName.ResumeLayout(False)
        Me.tabName.PerformLayout()
        Me.tabMobileNumber.ResumeLayout(False)
        Me.tabMobileNumber.PerformLayout()
        Me.tabAadhar.ResumeLayout(False)
        Me.tabAadhar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabUserID As System.Windows.Forms.TabPage
    Friend WithEvents tabName As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUserID As System.Windows.Forms.Button
    Friend WithEvents tabMobileNumber As System.Windows.Forms.TabPage
    Friend WithEvents tabAadhar As System.Windows.Forms.TabPage
    Friend WithEvents btnNextName As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnMobileNumber As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAadhar As System.Windows.Forms.Button
    Friend WithEvents cmbName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMobileNumber As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAadhar As System.Windows.Forms.ComboBox
    Friend WithEvents cmbUserID As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnUpdateDetails As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents joiningDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAadhar As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddChangePhoto As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnPrevName As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents rbtnInActive As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnActive As System.Windows.Forms.RadioButton
    Friend WithEvents btnDeleteUser As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblUID As System.Windows.Forms.Label
End Class
