Public Class FeeManagement

    Private Sub btnCollectFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCollectFee.Click
        CollectFee.Show()
    End Sub

    Private Sub btnEditDeleteFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditDeleteFee.Click
        EditDeleteFee.Show()
    End Sub

    Private Sub btnFeeHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeeHistory.Click
        FeeHistory.Show()
    End Sub
End Class