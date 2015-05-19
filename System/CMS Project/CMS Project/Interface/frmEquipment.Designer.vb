<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEquipment
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
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtExpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEquipName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEquipID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstEquipment = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboType
        '
        Me.cboType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboType.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(495, 293)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(281, 29)
        Me.cboType.TabIndex = 153
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(342, 129)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(87, 37)
        Me.btnNew.TabIndex = 165
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(459, 129)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 37)
        Me.btnSave.TabIndex = 164
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(41, 134)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(233, 28)
        Me.txtSearch.TabIndex = 163
        '
        'txtExpDate
        '
        Me.txtExpDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtExpDate.CustomFormat = "dd/MMM/yyyy"
        Me.txtExpDate.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtExpDate.Location = New System.Drawing.Point(495, 413)
        Me.txtExpDate.Name = "txtExpDate"
        Me.txtExpDate.Size = New System.Drawing.Size(281, 28)
        Me.txtExpDate.TabIndex = 158
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Tai Le", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(228, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(347, 40)
        Me.Label10.TabIndex = 162
        Me.Label10.Text = "Equipment Information"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(338, 419)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 21)
        Me.Label8.TabIndex = 161
        Me.Label8.Text = "Expire Date:"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUnitPrice.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitPrice.Location = New System.Drawing.Point(495, 375)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(281, 28)
        Me.txtUnitPrice.TabIndex = 156
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(338, 378)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 21)
        Me.Label9.TabIndex = 160
        Me.Label9.Text = "Unit Price:"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(689, 129)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(87, 37)
        Me.btnClose.TabIndex = 159
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(574, 129)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(87, 37)
        Me.btnUpdate.TabIndex = 157
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtQty
        '
        Me.txtQty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(495, 334)
        Me.txtQty.Multiline = True
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(281, 32)
        Me.txtQty.TabIndex = 154
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(338, 337)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 21)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "Qty:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(338, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 21)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Equipment Type:"
        '
        'txtEquipName
        '
        Me.txtEquipName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEquipName.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEquipName.Location = New System.Drawing.Point(495, 251)
        Me.txtEquipName.Name = "txtEquipName"
        Me.txtEquipName.Size = New System.Drawing.Size(281, 28)
        Me.txtEquipName.TabIndex = 151
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(338, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 21)
        Me.Label4.TabIndex = 150
        Me.Label4.Text = "Equipment Name:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 21)
        Me.Label3.TabIndex = 149
        Me.Label3.Text = "Equipment's List"
        '
        'txtEquipID
        '
        Me.txtEquipID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEquipID.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEquipID.Location = New System.Drawing.Point(495, 209)
        Me.txtEquipID.Name = "txtEquipID"
        Me.txtEquipID.ReadOnly = True
        Me.txtEquipID.Size = New System.Drawing.Size(281, 28)
        Me.txtEquipID.TabIndex = 148
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(338, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 21)
        Me.Label2.TabIndex = 147
        Me.Label2.Text = "Equipment ID:"
        '
        'lstEquipment
        '
        Me.lstEquipment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstEquipment.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstEquipment.FormattingEnabled = True
        Me.lstEquipment.ItemHeight = 21
        Me.lstEquipment.Location = New System.Drawing.Point(41, 198)
        Me.lstEquipment.Name = "lstEquipment"
        Me.lstEquipment.Size = New System.Drawing.Size(233, 235)
        Me.lstEquipment.TabIndex = 146
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 21)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "Search By Name:"
        '
        'frmEquipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 505)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtExpDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEquipName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEquipID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstEquipment)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEquipment"
        Me.Style = SonaFramework.SonaColorStyle.Used
        Me.Text = "frmEquipment"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtExpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEquipName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEquipID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstEquipment As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
