Public Class Admin
    Public LoggedInAdminName As String

    Dim PageAdminDashboard As AdminDashboard

    Dim PageAdminMedicines As AdminMedicines
    Dim PageAdminAddMedicine As AdminAddMedicine

    Dim PageAdminInventory As AdminInventory
    Dim PageAdminAddInventory As AdminAddInventory

    Dim PageAdminUserManagement As AdminUserManagement
    Dim PageAdminAddUser As AdminAddUserPage


    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminNameLabel.Text = Form1.LoggedInUserName
        LoadAdminMedicinesPage()
    End Sub

    Private Sub LoadAdminDashboardPage()
        PageAdminDashboard = New AdminDashboard
        PanelAdminBody.Controls.Clear()
        PanelAdminBody.Controls.Add(PageAdminDashboard)
    End Sub

    Public Sub LoadAdminMedicinesPage()
        PageAdminMedicines = New AdminMedicines
        PanelAdminBody.Controls.Clear()
        PanelAdminBody.Controls.Add(PageAdminMedicines)
    End Sub

    Public Sub LoadAdminAddMedicinePage()
        PageAdminAddMedicine = New AdminAddMedicine
        PanelAdminBody.Controls.Clear()
        PanelAdminBody.Controls.Add(PageAdminAddMedicine)
    End Sub

    Public Sub LoadAdminInventoryPage()
        PageAdminInventory = New AdminInventory
        PanelAdminBody.Controls.Clear()
        PanelAdminBody.Controls.Add(PageAdminInventory)
    End Sub

    Public Sub LoadAdminAddInventoryPage()
        PageAdminAddInventory = New AdminAddInventory
        PanelAdminBody.Controls.Clear()
        PanelAdminBody.Controls.Add(PageAdminAddInventory)
    End Sub

    Public Sub LoadAdminUserManagementPage()
        PageAdminUserManagement = New AdminUserManagement
        PanelAdminBody.Controls.Clear()
        PanelAdminBody.Controls.Add(PageAdminUserManagement)
    End Sub

    Public Sub LoadAdminAddUserPage()
        PageAdminAddUser = New AdminAddUserPage
        PanelAdminBody.Controls.Clear()
        PanelAdminBody.Controls.Add(PageAdminAddUser)
    End Sub

    Private Sub DashboardLink_Click_1(sender As Object, e As EventArgs)
        LoadAdminDashboardPage()
    End Sub

    Private Sub MedicinesLink_Click(sender As Object, e As EventArgs) Handles MedicinesLink.Click
        LoadAdminMedicinesPage()
    End Sub

    Private Sub InventoryLink_Click(sender As Object, e As EventArgs) Handles InventoryLink.Click
        LoadAdminInventoryPage()
    End Sub

    Private Sub UsersLink_Click_1(sender As Object, e As EventArgs) Handles UsersLink.Click
        LoadAdminUserManagementPage()
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Form1.LoggedInUserName = ""
        Form1.LoadPharmacistLoginPage()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class