Imports MySql.Data.MySqlClient

Public Class Form1

    Public LoggedInUserName As String

    Public DbConnection As MySqlConnection

    Dim PageAddAdmin As AddAdmin
    Dim PageAdminLogin As AdminLogin
    Public PageAdmin As Admin

    Dim PagePharmacistLogin As PharmacistLogin
    Public PagePharmacist As Pharmacist

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDbConnection()
        LoadInitailPage()
    End Sub

    Private Sub InitDbConnection()
        Dim ConnectionString = "server=127.0.0.1;uid=root;pwd=admin;database=epharma"
        DbConnection = New MySqlConnection With {
            .ConnectionString = ConnectionString
        }

        ' Create tables
        DbHelper.CreateTables()
    End Sub

    Private Sub LoadInitailPage()
        UserModule.IsUsersExists()
        If UserModule.UserExists = True Then
            LoadPharmacistLoginPage()
        Else
            LoadAddAdminPage()
        End If
    End Sub

    Public Sub LoadAddAdminPage()
        PageAddAdmin = New AddAdmin With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        PageAddAdmin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)

        PanelApp.Controls.Clear()
        PanelApp.Controls.Add(PageAddAdmin)

        PageAddAdmin.Show()
    End Sub

    Public Sub LoadAdminLoginPage()
        PageAdminLogin = New AdminLogin With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        PageAdminLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)

        PanelApp.Controls.Clear()
        PanelApp.Controls.Add(PageAdminLogin)

        PageAdminLogin.Show()
    End Sub

    Public Sub LoadAdminPage()
        PageAdmin = New Admin With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        PageAdmin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)

        PanelApp.Controls.Clear()
        PanelApp.Controls.Add(PageAdmin)
        PageAdmin.Show()
    End Sub

    Public Sub LoadPharmacistLoginPage()
        PagePharmacistLogin = New PharmacistLogin With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        PagePharmacistLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)

        PanelApp.Controls.Clear()
        PanelApp.Controls.Add(PagePharmacistLogin)
        PagePharmacistLogin.Show()
    End Sub

    Public Sub LoadPharmacistPage()
        PagePharmacist = New Pharmacist With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        PagePharmacist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)

        PanelApp.Controls.Clear()
        PanelApp.Controls.Add(PagePharmacist)
        PagePharmacist.Show()
    End Sub
End Class
