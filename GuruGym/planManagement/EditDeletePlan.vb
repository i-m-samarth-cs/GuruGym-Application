Public Class EditDeletePlan

    Dim dbConnObj As DBConnPlan
    Dim ds As DataSet
    Dim selectedPlan() As DataRow

    Private Sub EditDeletePlan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dbConnObj = New DBConnPlan()
        ds = dbConnObj.getPlanDS()
        Panel1.Enabled = False
        cmdID.DataSource = ds.Tables(0)
        cmdID.DisplayMember = "ID"
        cmdID.SelectedIndex = -1

        cmdName.DataSource = ds.Tables(0)
        cmdName.DisplayMember = "Name"
        cmdName.SelectedIndex = -1

    End Sub

    Private Sub btnName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName.Click
        Panel1.Enabled = True
        Try
            Dim name As String
            name = cmdName.Text

            selectedPlan = ds.Tables(0).Select("name='" & name & "'")
            If selectedPlan.Length > 0 Then
                assignValues(selectedPlan(0))
            Else
                MsgBox("No user Found with Name=" & name)
            End If
        Catch ex As Exception
            MsgBox("Something Went Wrong")
        End Try
    End Sub

    Private Sub assignValues(ByVal row As DataRow)
        txtAmount.Text = row("amount")
        txtMonths.Text = row("months")
        txtName.Text = row("name")
        If row("active") = True Then
            rbtnActive.Checked = True
        ElseIf row("active") = False Then
            rbtnInactive.Checked = True
        End If

    End Sub

    Private Sub btnID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnID.Click
        Panel1.Enabled = True
        Try
            Dim id As Integer
            id = cmdID.Text
            selectedPlan = ds.Tables(0).Select("id=" & id)
            If selectedPlan.Length > 0 Then
                assignValues(selectedPlan(0))
            Else
                MsgBox("No user Found with ID=" & id)
            End If
        Catch ex As Exception
            MsgBox("Something Went Wrong")
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim id As Integer = selectedPlan(0)("id")
        Dim details As planDetail
        details.name = txtName.Text
        details.amount = txtAmount.Text
        details.months = txtMonths.Text
        If rbtnActive.Checked = True Then
            details.active = True
        ElseIf rbtnInactive.Checked = True Then
            details.active = False
        End If

        If Not Validation.name(details.name) Then
            lblOutput.Text = "Enter valid Name"
            Return
        ElseIf details.months > Constants.MAX_PLAN_MONTHS Then
            lblOutput.Text = "Months greter than MAX Months"
        ElseIf details.amount > Constants.MAX_PLAN_AMOUNT Then
            lblOutput.Text = "Amount greter than MAX Amount"
        End If

        Dim result As DialogResult = MessageBox.Show("Really want to update details", "Confirmation", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then

            Dim output As String = dbConnObj.updateData(details, id)
            ds = dbConnObj.getPlanDS()
            lblOutput.Text = output
        End If


    End Sub


    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        Validation.txtNumbersOnly(e)
    End Sub


    Private Sub txtMonths_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonths.KeyPress
        Validation.txtNumbersOnly(e)
    End Sub


    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        Validation.txtName(e)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If selectedPlan.Length > 0 Then
            Dim id As Integer = selectedPlan(0)("id")
            Dim output As String = dbConnObj.deletePlanWithID(id)
            lblOutput.Text = output
            ds = dbConnObj.getPlanDS()
        End If
    End Sub
End Class