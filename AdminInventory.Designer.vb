<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminInventory
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MedicineInventoryList = New System.Windows.Forms.ListView()
        Me.IdColumn = New System.Windows.Forms.ColumnHeader()
        Me.NameColumn = New System.Windows.Forms.ColumnHeader()
        Me.StockColumn = New System.Windows.Forms.ColumnHeader()
        Me.AddStockButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inventory"
        '
        'MedicineInventoryList
        '
        Me.MedicineInventoryList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdColumn, Me.NameColumn, Me.StockColumn})
        Me.MedicineInventoryList.Location = New System.Drawing.Point(10, 47)
        Me.MedicineInventoryList.Name = "MedicineInventoryList"
        Me.MedicineInventoryList.Size = New System.Drawing.Size(580, 393)
        Me.MedicineInventoryList.TabIndex = 1
        Me.MedicineInventoryList.UseCompatibleStateImageBehavior = False
        Me.MedicineInventoryList.View = System.Windows.Forms.View.Details
        '
        'IdColumn
        '
        Me.IdColumn.Text = "Id"
        '
        'NameColumn
        '
        Me.NameColumn.Text = "name"
        Me.NameColumn.Width = 400
        '
        'StockColumn
        '
        Me.StockColumn.Text = "Stock"
        Me.StockColumn.Width = 116
        '
        'AddStockButton
        '
        Me.AddStockButton.Location = New System.Drawing.Point(468, 11)
        Me.AddStockButton.Name = "AddStockButton"
        Me.AddStockButton.Size = New System.Drawing.Size(122, 23)
        Me.AddStockButton.TabIndex = 2
        Me.AddStockButton.Text = "Add Stock"
        Me.AddStockButton.UseVisualStyleBackColor = True
        '
        'AdminInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AddStockButton)
        Me.Controls.Add(Me.MedicineInventoryList)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AdminInventory"
        Me.Size = New System.Drawing.Size(600, 450)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MedicineInventoryList As ListView
    Friend WithEvents IdColumn As ColumnHeader
    Friend WithEvents NameColumn As ColumnHeader
    Friend WithEvents StockColumn As ColumnHeader
    Friend WithEvents AddStockButton As Button
End Class
