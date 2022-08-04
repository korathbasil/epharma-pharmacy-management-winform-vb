Public Class AdminAddInventory
    Dim MedicineOptionsselectedIndex As Integer

    Private Sub AdminAddInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MedicineModule.LoadMedicinesData()
        MedicineOptions.Items.Clear()

        For Each Medicine As MedicineStockModel In MedicineModule.MedicineInventory
            MedicineOptions.Items.Add(Medicine.Name)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (MedicineOptions.SelectedIndex < 0) Then
            MessageBox.Show("No medicine selected")
        Else
            MedicineModule.LoadMedicinesData()

            Dim SelectedMedicine = MedicineModule.Medicines.ElementAt(MedicineOptions.SelectedIndex)

            MedicineModule.AddStock(SelectedMedicine.Id, StockInput.Value)

        End If
    End Sub

    Private Sub GoBackInventoryButton_Click_1(sender As Object, e As EventArgs) Handles GoBackInventoryButton.Click
        Form1.PageAdmin.LoadAdminInventoryPage()
    End Sub

End Class
