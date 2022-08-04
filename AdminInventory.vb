Public Class AdminInventory
    Private Sub AddStockButton_Click(sender As Object, e As EventArgs) Handles AddStockButton.Click
        Form1.PageAdmin.LoadAdminAddInventoryPage()
    End Sub

    Private Sub AdminInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MedicineModule.LoadInventoryData()
        Dim CurrentItem = 0
        For Each Medicine As MedicineStockModel In MedicineModule.MedicineInventory
            MedicineInventoryList.Items.Add(Medicine.Id)
            MedicineInventoryList.Items(CurrentItem).SubItems.Add(Medicine.Name)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each Medicine As MedicineStockModel In MedicineModule.MedicineInventory
            MedicineInventoryList.Items(CurrentItem).SubItems.Add(Medicine.Stock)
            CurrentItem += 1
        Next
    End Sub
End Class
