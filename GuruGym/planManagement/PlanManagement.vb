Public Class PlanManagement

    Private Sub btnAddPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPlan.Click
        AddPlan.Show()
    End Sub

    Private Sub btnEditDeletePlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditDeletePlan.Click
        EditDeletePlan.Show()
    End Sub

    Private Sub btnShowAllPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAllPlan.Click
        ShowAllPlan.Show()
    End Sub
End Class