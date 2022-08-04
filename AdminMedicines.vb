Public Class AdminMedicines
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.PageAdmin.LoadAdminAddMedicinePage()
    End Sub

    Private Sub AdminMedicines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MedicineModule.LoadMedicinesData()
        Dim CurrentItem = 0
        For Each Medicine As MedicineModel In MedicineModule.Medicines
            MedicineDetailsListView.Items.Add(Medicine.Id)
            MedicineDetailsListView.Items(CurrentItem).SubItems.Add(Medicine.Name)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each Medicine As MedicineModel In MedicineModule.Medicines
            MedicineDetailsListView.Items(CurrentItem).SubItems.Add(Medicine.Formula)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each Medicine As MedicineModel In MedicineModule.Medicines
            MedicineDetailsListView.Items(CurrentItem).SubItems.Add(Medicine.Company)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each Medicine As MedicineModel In MedicineModule.Medicines
            MedicineDetailsListView.Items(CurrentItem).SubItems.Add(Medicine.Price)
            CurrentItem += 1
        Next
    End Sub
End Class
