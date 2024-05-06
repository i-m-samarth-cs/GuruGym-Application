Imports System.Data.OleDb
Imports System.IO

Public Class AddUsers
    Dim dbconnobj As DBConnUser

    Private Sub btnUploadPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadPhoto.Click
        Dim img As Image

        Try
            If OFDUploadPhoto.ShowDialog() <> System.Windows.Forms.DialogResult.Cancel Then
                img = New Bitmap(Image.FromFile(OFDUploadPhoto.FileName), New Size(picboxUser.Width, picboxUser.Height))
                picboxUser.Image = img

            End If
        Catch exc As Exception
            MsgBox("Please check file type and contact Devloper if necessory")
        End Try

    End Sub

    Private Sub btnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUser.Click
        Dim details As usersDetail

        lblOutput.Text = ""

        details.name = txtName.Text
        details.email = txtEmail.Text
        details.aadhar = txtAadhar.Text
        details.mobile = txtMobile.Text
        details.joining = joiningDate.Text

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

        Dim out As String = dbconnobj.insertData(details)

        If Not String.IsNullOrEmpty(OFDUploadPhoto.FileName) Then
            If OFDUploadPhoto.FileName <> "OpenFileDialog1" Then
                saveImage(details, "jpeg")
            End If
        End If

        lblOutput.Text = out

        If out.Contains("Successfully") Then
            txtAadhar.Text = ""
            txtEmail.Text = ""
            txtMobile.Text = ""
            txtName.Text = ""
        End If
    End Sub

    Private Sub saveImage(ByVal details As usersDetail, ByVal imgType As String)

        Dim ds As DataSet = dbconnobj.getUserDS()
        Dim fileName As String = Application.StartupPath

        Try
            Dim test As Bitmap = Image.FromFile(OFDUploadPhoto.FileName)
            If (Not System.IO.Directory.Exists(fileName & "\photo\")) Then
                System.IO.Directory.CreateDirectory(fileName & "\photo\")
            End If

            Dim uid As String = ds.Tables(0).Select("mobile='" & details.mobile & "'")(0)("id")
            fileName = fileName & "\photo\" & uid & ".jpeg"
            test.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg)
        Catch exc As Exception
            MsgBox("Something went wrong contact administrator")
        End Try

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

    Private Sub UserManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconnobj = New DBConnUser()
        OFDUploadPhoto.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
    End Sub

    Private Sub txtEmail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmail.KeyPress
        Validation.txtEmail(e)
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

    End Sub
End Class