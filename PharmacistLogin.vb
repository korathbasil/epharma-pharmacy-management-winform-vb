Public Class PharmacistLogin
    Private Sub GoToAdminLoginButton_Click(sender As Object, e As EventArgs) Handles GoToAdminLoginButton.Click
        Form1.LoadAdminLoginPage()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username = UsernameInput.Text
        Dim Password = PasswordInput.Text

        PharmacistModule.PharmacistLogin(Username, Password)
    End Sub
End Class