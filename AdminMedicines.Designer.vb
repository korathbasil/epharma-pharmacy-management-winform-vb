<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMedicines
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MedicineDetailsListView = New System.Windows.Forms.ListView()
        Me.IdColumn = New System.Windows.Forms.ColumnHeader()
        Me.NameColumn = New System.Windows.Forms.ColumnHeader()
        Me.FormulaColumn = New System.Windows.Forms.ColumnHeader()
        Me.CompanyColumn = New System.Windows.Forms.ColumnHeader()
        Me.PriceColumn = New System.Windows.Forms.ColumnHeader()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MedicineDetailsListView)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 452)
        Me.Panel1.TabIndex = 0
        '
        'MedicineDetailsListView
        '
        Me.MedicineDetailsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdColumn, Me.NameColumn, Me.FormulaColumn, Me.CompanyColumn, Me.PriceColumn})
        Me.MedicineDetailsListView.Location = New System.Drawing.Point(11, 49)
        Me.MedicineDetailsListView.Name = "MedicineDetailsListView"
        Me.MedicineDetailsListView.Size = New System.Drawing.Size(576, 391)
        Me.MedicineDetailsListView.TabIndex = 5
        Me.MedicineDetailsListView.UseCompatibleStateImageBehavior = False
        Me.MedicineDetailsListView.View = System.Windows.Forms.View.Details
        '
        'IdColumn
        '
        Me.IdColumn.Text = "Id"
        '
        'NameColumn
        '
        Me.NameColumn.Text = "Name"
        Me.NameColumn.Width = 200
        '
        'FormulaColumn
        '
        Me.FormulaColumn.Text = "Formula"
        Me.FormulaColumn.Width = 100
        '
        'CompanyColumn
        '
        Me.CompanyColumn.Text = "Company"
        Me.CompanyColumn.Width = 150
        '
        'PriceColumn
        '
        Me.PriceColumn.Text = "Price"
        Me.PriceColumn.Width = 62
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(455, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 27)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Add Medicine"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Medicines"
        '
        'AdminMedicines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AdminMedicines"
        Me.Size = New System.Drawing.Size(600, 452)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MedicineDetailsListView As ListView
    Friend WithEvents IdColumn As ColumnHeader
    Friend WithEvents NameColumn As ColumnHeader
    Friend WithEvents CompanyColumn As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FormulaColumn As ColumnHeader
    Friend WithEvents PriceColumn As ColumnHeader
End Class
