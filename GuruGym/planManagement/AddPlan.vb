Public Class AddPlan

    Dim dbconnObj As DBConnPlan

    Private Sub txtMonths_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonths.KeyPress
        Validation.txtNumbersOnly(e)
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        Validation.txtName(e)
    End Sub

    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        Validation.txtNumbersOnly(e)
    End Sub


    Private Sub btnAddPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPlan.Click

        Dim details As planDetail
        details.name = txtName.Text
        details.amount = txtAmount.Text
        details.months = txtMonths.Text
        details.active = True

        If Not Validation.name(name) Then
            MsgBox("Please enter valide name (greater than 3 letter)")
            Return
        End If

        If details.amount > Constants.MAX_PLAN_AMOUNT Then
            MsgBox("Plan Amount is too high")
            Return
        End If

        If details.months > Constants.MAX_PLAN_MONTHS Then
            MsgBox("Plan Month is too high")
            Return
        End If

        Dim output As String = dbconnObj.insertData(details)

        lblOutput.Text = output

    End Sub

    Private Sub AddPlan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconnObj = New DBConnPlan()
    End Sub
End Class