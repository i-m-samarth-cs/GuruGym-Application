
Public Class Dashboard

    Private Sub btnUserMan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserMan.Click
        UserManagement.Show()
    End Sub

    Private Sub btnExpiredNAMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpiredNAMember.Click
        ExpiredInactive.Show()
    End Sub

    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPlanMan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlanMan.Click
        PlanManagement.Show()
    End Sub

    Private Sub btnCollectFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCollectFee.Click
        FeeManagement.Show()
    End Sub
End Class
