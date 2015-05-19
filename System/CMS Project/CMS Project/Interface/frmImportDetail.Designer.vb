<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImport
    Inherits SonaFramework.Forms.SonaForm

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.LvImport = New System.Windows.Forms.ListView()
        Me.EquipmentID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EquipmentName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EquipmentType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ExpiredDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.UnitPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Amount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtImportDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtImportID = New System.Windows.Forms.TextBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSupplierID = New System.Windows.Forms.TextBox()
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.cboEType = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.cboStaff = New System.Windows.Forms.ComboBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtExpireDate = New System.Windows.Forms.DateTimePicker()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.cboEName = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LvImport
        '
        Me.LvImport.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.EquipmentID, Me.EquipmentName, Me.EquipmentType, Me.ExpiredDate, Me.Quantity, Me.UnitPrice, Me.Amount})
        Me.LvImport.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvImport.FullRowSelect = True
        Me.LvImport.GridLines = True
        Me.LvImport.Location = New System.Drawing.Point(17, 93)
        Me.LvImport.Name = "LvImport"
        Me.LvImport.Size = New System.Drawing.Size(933, 125)
        Me.LvImport.TabIndex = 126
        Me.LvImport.UseCompatibleStateImageBehavior = False
        Me.LvImport.View = System.Windows.Forms.View.Details
        '
        'EquipmentID
        '
        Me.EquipmentID.Text = "EquipmentID"
        Me.EquipmentID.Width = 113
        '
        'EquipmentName
        '
        Me.EquipmentName.Text = "EquipmentName"
        Me.EquipmentName.Width = 157
        '
        'EquipmentType
        '
        Me.EquipmentType.Text = "EquipmentType"
        Me.EquipmentType.Width = 148
        '
        'ExpiredDate
        '
        Me.ExpiredDate.Text = "ExpiredDate"
        Me.ExpiredDate.Width = 136
        '
        'Quantity
        '
        Me.Quantity.Text = "Quantity"
        Me.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Quantity.Width = 109
        '
        'UnitPrice
        '
        Me.UnitPrice.Text = "UnitPrice"
        Me.UnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.UnitPrice.Width = 119
        '
        'Amount
        '
        Me.Amount.Text = "Amount"
        Me.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Amount.Width = 143
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(593, 114)
        Me.txtPhone.Mask = "(000) 000-0009"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(267, 28)
        Me.txtPhone.TabIndex = 150
        '
        'txtImportDate
        '
        Me.txtImportDate.CustomFormat = "dd/MMM/yyyy"
        Me.txtImportDate.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtImportDate.Location = New System.Drawing.Point(153, 160)
        Me.txtImportDate.Name = "txtImportDate"
        Me.txtImportDate.Size = New System.Drawing.Size(255, 28)
        Me.txtImportDate.TabIndex = 146
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(448, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 21)
        Me.Label7.TabIndex = 158
        Me.Label7.Text = "Contact Phone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(448, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 21)
        Me.Label6.TabIndex = 157
        Me.Label6.Text = "Contact Address:"
        '
        'txtImportID
        '
        Me.txtImportID.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImportID.Location = New System.Drawing.Point(153, 117)
        Me.txtImportID.Name = "txtImportID"
        Me.txtImportID.ReadOnly = True
        Me.txtImportID.Size = New System.Drawing.Size(255, 28)
        Me.txtImportID.TabIndex = 145
        Me.txtImportID.TabStop = False
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(863, 48)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(86, 37)
        Me.btnRemove.TabIndex = 125
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(771, 48)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 37)
        Me.btnAdd.TabIndex = 124
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtSupplierID
        '
        Me.txtSupplierID.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplierID.Location = New System.Drawing.Point(153, 203)
        Me.txtSupplierID.Name = "txtSupplierID"
        Me.txtSupplierID.ReadOnly = True
        Me.txtSupplierID.Size = New System.Drawing.Size(255, 28)
        Me.txtSupplierID.TabIndex = 147
        Me.txtSupplierID.TabStop = False
        '
        'cboSupplier
        '
        Me.cboSupplier.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(153, 241)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(255, 29)
        Me.cboSupplier.TabIndex = 149
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 21)
        Me.Label4.TabIndex = 155
        Me.Label4.Text = "Supplier:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 21)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "Supplier ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 21)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "Import NO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 21)
        Me.Label5.TabIndex = 156
        Me.Label5.Text = "Import Date:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(643, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 21)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "UnitPrice"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(525, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 21)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "Quantities:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Tai Le", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(334, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(381, 40)
        Me.Label14.TabIndex = 148
        Me.Label14.Text = "Import Detail Information"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(593, 157)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(267, 74)
        Me.txtAddress.TabIndex = 151
        '
        'cboEType
        '
        Me.cboEType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEType.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEType.FormattingEnabled = True
        Me.cboEType.ItemHeight = 21
        Me.cboEType.Location = New System.Drawing.Point(17, 57)
        Me.cboEType.Margin = New System.Windows.Forms.Padding(4)
        Me.cboEType.Name = "cboEType"
        Me.cboEType.Size = New System.Drawing.Size(154, 29)
        Me.cboEType.TabIndex = 6
        Me.cboEType.Tag = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(448, 244)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 21)
        Me.Label12.TabIndex = 165
        Me.Label12.Text = "Staff Name:"
        '
        'btnPreview
        '
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.Location = New System.Drawing.Point(879, 208)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(122, 44)
        Me.btnPreview.TabIndex = 164
        Me.btnPreview.Text = "&Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(879, 158)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 44)
        Me.btnSave.TabIndex = 163
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSupplier
        '
        Me.btnSupplier.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplier.Location = New System.Drawing.Point(879, 108)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(122, 44)
        Me.btnSupplier.TabIndex = 162
        Me.btnSupplier.Text = "New S&upplier"
        Me.btnSupplier.UseVisualStyleBackColor = True
        '
        'cboStaff
        '
        Me.cboStaff.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStaff.FormattingEnabled = True
        Me.cboStaff.Location = New System.Drawing.Point(593, 241)
        Me.cboStaff.Name = "cboStaff"
        Me.cboStaff.Size = New System.Drawing.Size(267, 29)
        Me.cboStaff.TabIndex = 152
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(802, 560)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(182, 28)
        Me.txtTotal.TabIndex = 160
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(678, 563)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 21)
        Me.Label11.TabIndex = 161
        Me.Label11.Text = "Total Amount"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LvImport)
        Me.GroupBox1.Controls.Add(Me.btnRemove)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cboEType)
        Me.GroupBox1.Controls.Add(Me.txtExpireDate)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.txtUnitPrice)
        Me.GroupBox1.Controls.Add(Me.cboEName)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 309)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(966, 236)
        Me.GroupBox1.TabIndex = 159
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail's Information"
        '
        'txtExpireDate
        '
        Me.txtExpireDate.CustomFormat = "dd/MMM/yyyy"
        Me.txtExpireDate.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtExpireDate.Location = New System.Drawing.Point(370, 57)
        Me.txtExpireDate.Name = "txtExpireDate"
        Me.txtExpireDate.Size = New System.Drawing.Size(154, 28)
        Me.txtExpireDate.TabIndex = 1
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(529, 57)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(114, 28)
        Me.txtQuantity.TabIndex = 8
        Me.txtQuantity.Tag = "*"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitPrice.Location = New System.Drawing.Point(647, 57)
        Me.txtUnitPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(117, 28)
        Me.txtUnitPrice.TabIndex = 9
        Me.txtUnitPrice.Tag = "*"
        '
        'cboEName
        '
        Me.cboEName.AllowDrop = True
        Me.cboEName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEName.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEName.FormattingEnabled = True
        Me.cboEName.ItemHeight = 21
        Me.cboEName.Location = New System.Drawing.Point(177, 57)
        Me.cboEName.Margin = New System.Windows.Forms.Padding(4)
        Me.cboEName.Name = "cboEName"
        Me.cboEName.Size = New System.Drawing.Size(186, 29)
        Me.cboEName.TabIndex = 7
        Me.cboEName.Tag = "*"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(171, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 21)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Equipment:"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(365, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 21)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "Expire Date:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 21)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Equipment Type:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(879, 258)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(122, 44)
        Me.btnClose.TabIndex = 166
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 634)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtImportDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtImportID)
        Me.Controls.Add(Me.txtSupplierID)
        Me.Controls.Add(Me.cboSupplier)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnSupplier)
        Me.Controls.Add(Me.cboStaff)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmImport"
        Me.Style = SonaFramework.SonaColorStyle.Used
        Me.Text = "frmImportDetail"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LvImport As System.Windows.Forms.ListView
    Friend WithEvents EquipmentID As System.Windows.Forms.ColumnHeader
    Friend WithEvents EquipmentName As System.Windows.Forms.ColumnHeader
    Friend WithEvents EquipmentType As System.Windows.Forms.ColumnHeader
    Friend WithEvents ExpiredDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents Quantity As System.Windows.Forms.ColumnHeader
    Friend WithEvents UnitPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents Amount As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtImportDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtImportID As System.Windows.Forms.TextBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtSupplierID As System.Windows.Forms.TextBox
    Friend WithEvents cboSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents cboEType As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSupplier As System.Windows.Forms.Button
    Friend WithEvents cboStaff As System.Windows.Forms.ComboBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtExpireDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents cboEName As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
