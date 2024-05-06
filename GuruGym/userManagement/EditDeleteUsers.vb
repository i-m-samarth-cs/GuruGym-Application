Public Class EditDeleteUsers
    Dim dbconnobj As DBConnUser
    Dim ds As DataSet
    Dim selectedUsers() As DataRow
    Dim flagPhotoChanged As Boolean = False
    Dim rowCountForNameSearch As Integer = 0 'current row in name search
    Dim currentRowNameSearch As Integer = 0 'for deleting in name search
    Dim selectNameFlag As Boolean = False
    Dim nameToSearch As String
    Dim details As usersDetail

    Private Sub EditUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconnobj = New DBConnUser()
        ds = dbconnobj.getUserDS()
        Panel1.Enabled = False
        cmbAadhar.DataSource = ds.Tables(0)
        cmbMobileNumber.DataSource = ds.Tables(0)
        cmbName.DataSource = ds.Tables(0)
        cmbUserID.DataSource = ds.Tables(0)

        cmbAadhar.DisplayMember = "aadhar"
        cmbMobileNumber.DisplayMember = "mobile"
        cmbName.DisplayMember = "name"
        cmbUserID.DisplayMember = "id"

        cmbAadhar.SelectedIndex = -1
        cmbMobileNumber.SelectedIndex = -1
        cmbName.SelectedIndex = -1
        cmbName.SelectedIndex = -1
        cmbUserID.SelectedIndex = -1

        OpenFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
    End Sub

    Private Sub btnUserID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserID.Click
        Dim uid As String
        Try
            resetForNameSearch()
            uid = cmbUserID.Text

            selectedUsers = ds.Tables(0).Select("id='" & uid & "'")
            If selectedUsers.Length > 0 Then
                assignValueOfRow(selectedUsers(0))
            Else
                MsgBox("User Not Found with user id = " & uid)
            End If
        Catch exc As Exception
            MsgBox("something went wrong")
        End Try
    End Sub

    Private Sub assignValueOfRow(ByVal datarowValue As DataRow)
        Panel1.Enabled = True
        lblUID.Text = datarowValue("id") & ""
        txtAadhar.Text = datarowValue("aadhar")
        txtEmail.Text = datarowValue("email")
        txtMobile.Text = datarowValue("mobile")
        txtName.Text = datarowValue("name")
        joiningDate.Text = datarowValue("joining")

        If datarowValue("active") Then
            rbtnActive.Checked = True
        Else
            rbtnInActive.Checked = True
        End If

        Dim exe_path As String = Application.StartupPath
        Dim photo_path As String = exe_path & "\photo\" & datarowValue("id") & ".jpeg"
        Try
            If System.IO.File.Exists(photo_path) Then
                PictureBox1.Image = New Bitmap(Image.FromFile(photo_path), New Size(PictureBox1.Width, PictureBox1.Height))
            Else
                PictureBox1.Image = Nothing
                lblOutput.Text = "Image Not Available"
            End If
        Catch exc As Exception
            MsgBox(exc.Message)
        End Try
    End Sub

    Private Sub btnMobileNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMobileNumber.Click
        Dim mobileNumber As String
        Try
            resetForNameSearch()
            mobileNumber = cmbMobileNumber.Text

            selectedUsers = ds.Tables(0).Select("mobile='" & mobileNumber & "'")
            If selectedUsers.Length > 0 Then
                assignValueOfRow(selectedUsers(0))
            Else
                MsgBox("User Not Found with mobile Number= " & mobileNumber)
            End If
        Catch exc As Exception
            MsgBox("something went wrong")
        End Try
    End Sub

    Private Sub btnAadhar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAadhar.Click
        Dim aadhar As String
        Try
            resetForNameSearch()
            aadhar = cmbAadhar.Text

            selectedUsers = ds.Tables(0).Select("aadhar='" & aadhar & "'")
            If selectedUsers.Length > 0 Then
                assignValueOfRow(selectedUsers(0))
            Else
                MsgBox("User Not Found with aadhar Number= " & aadhar)
            End If
        Catch exc As Exception
            MsgBox("something went wrong")
        End Try
    End Sub

    Private Sub btnAddChangePhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddChangePhoto.Click
        Dim img As Image

        Try
            If OpenFileDialog1.ShowDialog() <> System.Windows.Forms.DialogResult.Cancel Then
                img = New Bitmap(Image.FromFile(OpenFileDialog1.FileName), New Size(PictureBox1.Width, PictureBox1.Height))
                PictureBox1.Image = img
                flagPhotoChanged = True
            End If
        Catch exc As Exception
            MsgBox("Please check file type and contact Devloper if necessory")
        End Try
    End Sub

    Private Sub btnUpdateDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateDetails.Click

        Dim uid As String = selectedUsers(currentRowNameSearch)("id")

        lblOutput.Text = ""
        details = New usersDetail()

        details.name = txtName.Text
        details.email = txtEmail.Text
        details.aadhar = txtAadhar.Text
        details.mobile = txtMobile.Text
        details.joining = joiningDate.Text

        If rbtnActive.Checked Then
            details.active = True
        ElseIf rbtnInActive.Checked Then
            details.active = False
        End If

        If Not Validation.name(details.name) Then
            lblOutput.Text = "Enter valid Name"
            Return
        ElseIf Not Validation.mobile(details.mobile) Then
            lblOutput.Text = "Enter valid Mobile Number"
            Return
        ElseIf Not Validation.aadhar(details.aadhar) Then
            lblOutput.Text = "Enter valid Aadhar Number"
            Return
        ElseIf Not Validation.joining(details.joining) Then
            lblOutput.Text = "Joining Date should be before Today"
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Really want to update details", "Confirmation", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then

            Dim output As String = dbconnobj.updateData(details, uid)

            If Not IsNothing(PictureBox1.Image) Then
                If flagPhotoChanged Then
                    Dim fileName As String = Application.StartupPath

                    fileName = fileName & "\photo\" & uid & ".jpeg"
                    PictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                End If
            End If

            lblOutput.Text = output
            ds = dbconnobj.getUserDS()
        End If
    End Sub

    Private Sub txtAadhar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAadhar.KeyPress
        Validation.txtNumbersOnly(e)
    End Sub

    Private Sub txtMobile_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobile.KeyPress
        Validation.txtNumbersOnly(e)
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        Validation.txtName(e)
    End Sub

    Private Sub txtEmail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmail.KeyPress
        Validation.txtEmail(e)
    End Sub

    Private Sub btnNextName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextName.Click

        Try
            If Not selectNameFlag Then
                selectNameFlag = True
                nameToSearch = cmbName.Text
                selectedUsers = ds.Tables(0).Select("name='" & nameToSearch & "'")
            End If

            If selectNameFlag Then

                If selectedUsers.Length > 0 Then
                    If rowCountForNameSearch >= selectedUsers.Length Then
                        MsgBox("Search is over find previous")
                        rowCountForNameSearch = selectedUsers.Length - 1
                        Return
                    ElseIf rowCountForNameSearch < 0 Then
                        rowCountForNameSearch = 0
                    End If
                    assignValueOfRow(selectedUsers(rowCountForNameSearch))
                    currentRowNameSearch = rowCountForNameSearch
                    rowCountForNameSearch = rowCountForNameSearch + 1
                Else
                    MsgBox("User Not Found with name = " & nameToSearch)
                End If
            End If
        Catch exc As Exception
            MsgBox("something went wrong" & exc.Message)
        End Try


    End Sub

    Private Sub btnPrevName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevName.Click
        Try
            If Not selectNameFlag Then
                selectNameFlag = True
                nameToSearch = cmbName.Text
                selectedUsers = ds.Tables(0).Select("name='" & nameToSearch & "'")
            End If

            If selectNameFlag Then

                If selectedUsers.Length > 0 Then
                    If rowCountForNameSearch < 0 Then
                        MsgBox("Search is over find Next")
                        rowCountForNameSearch = 0
                        Return
                    ElseIf rowCountForNameSearch >= selectedUsers.Length Then
                        rowCountForNameSearch = selectedUsers.Length - 1
                    End If

                    assignValueOfRow(selectedUsers(rowCountForNameSearch))
                    currentRowNameSearch = rowCountForNameSearch
                    rowCountForNameSearch = rowCountForNameSearch - 1
                Else
                    MsgBox("User Not Found with name = " & nameToSearch)
                End If
            End If
        Catch exc As Exception
            MsgBox("something went wrong " & exc.Message)
        End Try
    End Sub

    Private Sub cmbName_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbName.SelectedValueChanged
        selectNameFlag = False
    End Sub

    Private Sub btnDeleteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteUser.Click
        If Not IsNothing(details) Then
            Dim result As DialogResult = MessageBox.Show("Do You Really Want to delete user ", "Delete Confirmation", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                Dim uid = selectedUsers(currentRowNameSearch)("id")
                Dim output As String = dbconnobj.deleteUserWithID(uid)
                lblOutput.Text = output
                ds = dbconnobj.getUserDS()
            End If

        Else
            lblOutput.Text = "Please Select User"
        End If

        ds = dbconnobj.getUserDS()
    End Sub

    Private Sub resetForNameSearch()
        currentRowNameSearch = 0
        selectNameFlag = False
    End Sub

End Class