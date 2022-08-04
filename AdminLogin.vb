Public Class AdminLogin
    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim Username = UsernameInput.Text
        Dim Password = PasswordInput.Text

        AdminModule.LoginAdmin(Username, Password)
    End Sub

    Private Sub GoToPharmacistLoginButton_Click(sender As Object, e As EventArgs) Handles GoToPharmacistLoginButton.Click
        Form1.LoadPharmacistLoginPage()
    End Sub
End Class