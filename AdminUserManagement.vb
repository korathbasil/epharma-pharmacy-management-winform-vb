Public Class AdminUserManagement
    Dim SelectedIndex As Integer
    Private Sub AdminUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserModule.LoadUserData()
        Dim CurrentItem = 0
        For Each User As UserModel In UserModule.Users
            UsersListView.Items.Add(User.Id)
            UsersListView.Items(CurrentItem).SubItems.Add(User.Name)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each User As UserModel In UserModule.Users
            UsersListView.Items(CurrentItem).SubItems.Add(User.Username)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each User As UserModel In UserModule.Users
            If User.IsAdmin Then
                UsersListView.Items(CurrentItem).SubItems.Add("Admin")
            Else
                UsersListView.Items(CurrentItem).SubItems.Add("Pharmacist")
            End If
            CurrentItem += 1
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GoToAddUserPageButton.Click
        Form1.PageAdmin.LoadAdminAddUserPage()
    End Sub
End Class
