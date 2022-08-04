<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PharmacistSales
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ResetBillButtton = New System.Windows.Forms.Button()
        Me.TotalAmountLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BillView = New System.Windows.Forms.DataGridView()
        Me.ItemColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PriceColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AmountColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CheckoutButton = New System.Windows.Forms.Button()
        Me.AddToBillButton = New System.Windows.Forms.Button()
        Me.QuantityInput = New System.Windows.Forms.NumericUpDown()
        Me.MedicineSelector = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        CType(Me.BillView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ResetBillButtton)
        Me.Panel1.Controls.Add(Me.TotalAmountLabel)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BillView)
        Me.Panel1.Controls.Add(Me.CheckoutButton)
        Me.Panel1.Controls.Add(Me.AddToBillButton)
        Me.Panel1.Controls.Add(Me.QuantityInput)
        Me.Panel1.Controls.Add(Me.MedicineSelector)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 450)
        Me.Panel1.TabIndex = 0
        '
        'ResetBillButtton
        '
        Me.ResetBillButtton.Location = New System.Drawing.Point(51, 240)
        Me.ResetBillButtton.Name = "ResetBillButtton"
        Me.ResetBillButtton.Size = New System.Drawing.Size(86, 28)
        Me.ResetBillButtton.TabIndex = 9
        Me.ResetBillButtton.Text = "Reset Bill"
        Me.ResetBillButtton.UseVisualStyleBackColor = True
        '
        'TotalAmountLabel
        '
        Me.TotalAmountLabel.AutoSize = True
        Me.TotalAmountLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TotalAmountLabel.Location = New System.Drawing.Point(101, 301)
        Me.TotalAmountLabel.Name = "TotalAmountLabel"
        Me.TotalAmountLabel.Size = New System.Drawing.Size(19, 21)
        Me.TotalAmountLabel.TabIndex = 8
        Me.TotalAmountLabel.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(3, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total (Rs.)  :"
        '
        'BillView
        '
        Me.BillView.AllowUserToAddRows = False
        Me.BillView.AllowUserToDeleteRows = False
        Me.BillView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.BillView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BillView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemColumn, Me.PriceColumn, Me.QuantityColumn, Me.AmountColumn})
        Me.BillView.Location = New System.Drawing.Point(192, 76)
        Me.BillView.Name = "BillView"
        Me.BillView.ReadOnly = True
        Me.BillView.RowTemplate.Height = 25
        Me.BillView.Size = New System.Drawing.Size(405, 323)
        Me.BillView.TabIndex = 6
        '
        'ItemColumn
        '
        Me.ItemColumn.HeaderText = "Item"
        Me.ItemColumn.Name = "ItemColumn"
        Me.ItemColumn.ReadOnly = True
        '
        'PriceColumn
        '
        Me.PriceColumn.HeaderText = "Price"
        Me.PriceColumn.Name = "PriceColumn"
        Me.PriceColumn.ReadOnly = True
        '
        'QuantityColumn
        '
        Me.QuantityColumn.HeaderText = "Quantity"
        Me.QuantityColumn.Name = "QuantityColumn"
        Me.QuantityColumn.ReadOnly = True
        Me.QuantityColumn.Width = 60
        '
        'AmountColumn
        '
        Me.AmountColumn.HeaderText = "Amount (Rs.)"
        Me.AmountColumn.Name = "AmountColumn"
        Me.AmountColumn.ReadOnly = True
        '
        'CheckoutButton
        '
        Me.CheckoutButton.Location = New System.Drawing.Point(51, 339)
        Me.CheckoutButton.Name = "CheckoutButton"
        Me.CheckoutButton.Size = New System.Drawing.Size(91, 37)
        Me.CheckoutButton.TabIndex = 5
        Me.CheckoutButton.Text = "Checkout"
        Me.CheckoutButton.UseVisualStyleBackColor = True
        '
        'AddToBillButton
        '
        Me.AddToBillButton.Location = New System.Drawing.Point(51, 187)
        Me.AddToBillButton.Name = "AddToBillButton"
        Me.AddToBillButton.Size = New System.Drawing.Size(86, 26)
        Me.AddToBillButton.TabIndex = 4
        Me.AddToBillButton.Text = "Add to Bill"
        Me.AddToBillButton.UseVisualStyleBackColor = True
        '
        'QuantityInput
        '
        Me.QuantityInput.Location = New System.Drawing.Point(50, 138)
        Me.QuantityInput.Name = "QuantityInput"
        Me.QuantityInput.Size = New System.Drawing.Size(87, 23)
        Me.QuantityInput.TabIndex = 3
        Me.QuantityInput.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MedicineSelector
        '
        Me.MedicineSelector.FormattingEnabled = True
        Me.MedicineSelector.Location = New System.Drawing.Point(3, 100)
        Me.MedicineSelector.Name = "MedicineSelector"
        Me.MedicineSelector.Size = New System.Drawing.Size(183, 23)
        Me.MedicineSelector.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(17, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sale"
        '
        'UserModelBindingSource
        '
        Me.UserModelBindingSource.DataSource = GetType(ePharma.UserModel)
        '
        'PrintDocument1
        '
        '
        'PharmacistSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PharmacistSales"
        Me.Size = New System.Drawing.Size(600, 450)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BillView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BillView As DataGridView
    Friend WithEvents CheckoutButton As Button
    Friend WithEvents AddToBillButton As Button
    Friend WithEvents QuantityInput As NumericUpDown
    Friend WithEvents MedicineSelector As ComboBox
    Friend WithEvents UserModelBindingSource As BindingSource
    Friend WithEvents TotalAmountLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ItemColumn As DataGridViewButtonColumn
    Friend WithEvents PriceColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityColumn As DataGridViewButtonColumn
    Friend WithEvents AmountColumn As DataGridViewButtonColumn
    Friend WithEvents ResetBillButtton As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
