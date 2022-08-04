<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AdminNameLabel = New System.Windows.Forms.Label()
        Me.InventoryLink = New System.Windows.Forms.Label()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.MedicinesLink = New System.Windows.Forms.Label()
        Me.UsersLink = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelAdminBody = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.AdminNameLabel)
        Me.Panel1.Controls.Add(Me.InventoryLink)
        Me.Panel1.Controls.Add(Me.LogoutButton)
        Me.Panel1.Controls.Add(Me.MedicinesLink)
        Me.Panel1.Controls.Add(Me.UsersLink)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 450)
        Me.Panel1.TabIndex = 4
        '
        'AdminNameLabel
        '
        Me.AdminNameLabel.AutoSize = True
        Me.AdminNameLabel.Location = New System.Drawing.Point(71, 378)
        Me.AdminNameLabel.Name = "AdminNameLabel"
        Me.AdminNameLabel.Size = New System.Drawing.Size(41, 15)
        Me.AdminNameLabel.TabIndex = 6
        Me.AdminNameLabel.Text = "Label2"
        '
        'InventoryLink
        '
        Me.InventoryLink.AutoSize = True
        Me.InventoryLink.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.InventoryLink.Location = New System.Drawing.Point(12, 91)
        Me.InventoryLink.Name = "InventoryLink"
        Me.InventoryLink.Size = New System.Drawing.Size(68, 17)
        Me.InventoryLink.TabIndex = 5
        Me.InventoryLink.Text = "Inventory"
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(54, 407)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(87, 31)
        Me.LogoutButton.TabIndex = 4
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'MedicinesLink
        '
        Me.MedicinesLink.AutoSize = True
        Me.MedicinesLink.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MedicinesLink.Location = New System.Drawing.Point(12, 57)
        Me.MedicinesLink.Name = "MedicinesLink"
        Me.MedicinesLink.Size = New System.Drawing.Size(68, 17)
        Me.MedicinesLink.TabIndex = 3
        Me.MedicinesLink.Text = "Medicines"
        '
        'UsersLink
        '
        Me.UsersLink.AutoSize = True
        Me.UsersLink.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UsersLink.Location = New System.Drawing.Point(12, 127)
        Me.UsersLink.Name = "UsersLink"
        Me.UsersLink.Size = New System.Drawing.Size(41, 17)
        Me.UsersLink.TabIndex = 2
        Me.UsersLink.Text = "Users"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(26, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Panel"
        '
        'PanelAdminBody
        '
        Me.PanelAdminBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelAdminBody.Location = New System.Drawing.Point(200, 0)
        Me.PanelAdminBody.Name = "PanelAdminBody"
        Me.PanelAdminBody.Size = New System.Drawing.Size(600, 450)
        Me.PanelAdminBody.TabIndex = 5
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelAdminBody)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MedicinesLink As Label
    Friend WithEvents UsersLink As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelAdminBody As Panel
    Friend WithEvents LogoutButton As Button
    Friend WithEvents InventoryLink As Label
    Friend WithEvents AdminNameLabel As Label
End Class
