Public Class ShowAllUsers
    Dim dbconnobj As DBConnUser

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        Dim i = DataGridView1.CurrentRow.Index
        Dim img_sel As Image
        Dim img_test As Image
        lblShowAllError.Text = ""
        'name, email, aadhar, mobile, photo, joining, active
        Try
            txtName.Text = DataGridView1.Item(1, i).Value
            txtEmail.Text = DataGridView1.Item(2, i).Value
            txtAadhar.Text = DataGridView1.Item(3, i).Value
            txtMobile.Text = DataGridView1.Item(4, i).Value
            joiningDate.Text = DataGridView1.Item(5, i).Value
            lblUserID.Text = DataGridView1.Item(0, i).Value

        Catch exc As Exception
            lblShowAllError.Text = "Please selected add user tab to insert new user"
        End Try

        Try
            Dim str_pic As String = DataGridView1.Item(0, i).Value
            Dim path As String = Application.StartupPath & "\photo\" & str_pic & ".jpeg"
            If System.IO.File.Exists(path) Then
                img_test = Image.FromFile(path)
                img_sel = New Bitmap(img_test, New Size(PictureBox1.Width, PictureBox1.Height))
                PictureBox1.Image = img_sel
            Else
                PictureBox1.Image = Nothing
                lblShowAllError.Text = "Image not Found"
            End If
        Catch ex As Exception
            MsgBox("Something went wrong contact administrator " & ex.Message)
        End Try
    End Sub


    Private Sub ShowAllUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconnobj = New DBConnUser()
        DataGridView1.DataSource = dbconnobj.getUserDS().Tables(0).DefaultView
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ReadOnly = True

        txtAadhar.ReadOnly = True
        txtEmail.ReadOnly = True
        txtMobile.ReadOnly = True
        txtName.ReadOnly = True

    End Sub

End Class