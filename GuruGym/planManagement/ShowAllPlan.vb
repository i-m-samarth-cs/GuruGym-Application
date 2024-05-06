Public Class ShowAllPlan
    Dim dbconnobj As DBConnPlan

    Private Sub ShowAllPlan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconnobj = New DBConnPlan()

        DataGridView1.DataSource = dbconnobj.getPlanDS().Tables(0).DefaultView
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ReadOnly = False

        txtAmount.ReadOnly = True
        txtID.ReadOnly = True
        txtMonths.ReadOnly = True
        txtName.ReadOnly = True
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        Dim i = DataGridView1.CurrentRow.Index
        Try
            txtID.Text = DataGridView1.Item(0, i).Value
            txtName.Text = DataGridView1.Item(1, i).Value
            txtMonths.Text = DataGridView1.Item(2, i).Value
            txtAmount.Text = DataGridView1.Item(3, i).Value

        Catch ex As Exception
            MsgBox("Something Went Wrong Please check")
        End Try
    End Sub
End Class