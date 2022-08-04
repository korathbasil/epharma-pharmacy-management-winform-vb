Public Class Pharmacist
    Dim PagePharmacistSale As PharmacistSales
    Private Sub Pharmacist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PharmacistNameLabel.Text = Form1.LoggedInUserName
        LoadPharmacistSalePage()
    End Sub

    Private Sub LoadPharmacistSalePage()
        PagePharmacistSale = New PharmacistSales
        PanelBody.Controls.Clear()
        PanelBody.Controls.Add(PagePharmacistSale)
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Form1.LoggedInUserName = ""
        Form1.LoadPharmacistLoginPage()
    End Sub
End Class