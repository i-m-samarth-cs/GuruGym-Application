Public Class UserManagement

    Private Sub btnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUser.Click
        AddUsers.Show()
    End Sub

    Private Sub btnEditDeleteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditDeleteUser.Click
        EditDeleteUsers.Show()
    End Sub

    Private Sub btnShowAllUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAllUser.Click
        ShowAllUsers.Show()
    End Sub

End Class