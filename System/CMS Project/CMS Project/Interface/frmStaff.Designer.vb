<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaff
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
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lstStaff = New System.Windows.Forms.ListBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbostopwork = New System.Windows.Forms.ComboBox()
        Me.dtphireddate = New System.Windows.Forms.DateTimePicker()
        Me.cboPosition = New System.Windows.Forms.ComboBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpbirthdate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPhone
        '
        Me.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(370, 421)
        Me.txtPhone.Mask = "(999) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(294, 28)
        Me.txtPhone.TabIndex = 122
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(464, 131)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(97, 35)
        Me.btnUpdate.TabIndex = 138
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Tai Le", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(343, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(278, 40)
        Me.Label14.TabIndex = 137
        Me.Label14.Text = "Staff's Information"
        '
        'lstStaff
        '
        Me.lstStaff.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstStaff.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStaff.FormattingEnabled = True
        Me.lstStaff.ItemHeight = 21
        Me.lstStaff.Location = New System.Drawing.Point(26, 234)
        Me.lstStaff.Name = "lstStaff"
        Me.lstStaff.Size = New System.Drawing.Size(208, 403)
        Me.lstStaff.TabIndex = 136
        '
        'cboStatus
        '
        Me.cboStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboStatus.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Single", "Married"})
        Me.cboStatus.Location = New System.Drawing.Point(370, 380)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(294, 29)
        Me.cboStatus.TabIndex = 119
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(261, 383)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 21)
        Me.Label13.TabIndex = 135
        Me.Label13.Text = "Marital Status"
        '
        'cbostopwork
        '
        Me.cbostopwork.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbostopwork.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbostopwork.FormattingEnabled = True
        Me.cbostopwork.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbostopwork.Location = New System.Drawing.Point(370, 574)
        Me.cbostopwork.Name = "cbostopwork"
        Me.cbostopwork.Size = New System.Drawing.Size(294, 29)
        Me.cbostopwork.TabIndex = 129
        '
        'dtphireddate
        '
        Me.dtphireddate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtphireddate.CustomFormat = "dd/MMM/yyyy"
        Me.dtphireddate.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtphireddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtphireddate.Location = New System.Drawing.Point(370, 501)
        Me.dtphireddate.Name = "dtphireddate"
        Me.dtphireddate.Size = New System.Drawing.Size(294, 28)
        Me.dtphireddate.TabIndex = 125
        Me.dtphireddate.Value = New Date(2015, 4, 8, 0, 0, 0, 0)
        '
        'cboPosition
        '
        Me.cboPosition.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboPosition.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cboPosition.Location = New System.Drawing.Point(370, 614)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(294, 29)
        Me.cboPosition.TabIndex = 130
        '
        'txtSalary
        '
        Me.txtSalary.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(370, 538)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(294, 28)
        Me.txtSalary.TabIndex = 128
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(370, 464)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(294, 28)
        Me.txtAddress.TabIndex = 123
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(265, 575)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 21)
        Me.Label12.TabIndex = 133
        Me.Label12.Text = "Stop work"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(265, 501)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 21)
        Me.Label11.TabIndex = 131
        Me.Label11.Text = "Hired Date"
        '
        'dtpbirthdate
        '
        Me.dtpbirthdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpbirthdate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpbirthdate.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpbirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpbirthdate.Location = New System.Drawing.Point(370, 341)
        Me.dtpbirthdate.Name = "dtpbirthdate"
        Me.dtpbirthdate.Size = New System.Drawing.Size(294, 28)
        Me.dtpbirthdate.TabIndex = 118
        Me.dtpbirthdate.Value = New Date(2015, 4, 8, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(267, 539)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 21)
        Me.Label10.TabIndex = 127
        Me.Label10.Text = "Salary"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(265, 623)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 21)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = "Position"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(265, 465)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 21)
        Me.Label8.TabIndex = 124
        Me.Label8.Text = "Address"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(265, 421)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 21)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "Phone"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 21)
        Me.Label6.TabIndex = 120
        Me.Label6.Text = "Staff List"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(261, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Birthdate"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(261, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 21)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "Gender"
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtName.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(370, 262)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(294, 28)
        Me.txtName.TabIndex = 114
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(261, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 21)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Staff's Name"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(261, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 21)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Staff's ID"
        '
        'txtID
        '
        Me.txtID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtID.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(370, 216)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(294, 28)
        Me.txtID.TabIndex = 111
        '
        'cboGender
        '
        Me.cboGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboGender.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(370, 299)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(294, 29)
        Me.cboGender.TabIndex = 115
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(695, 131)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(177, 35)
        Me.btnBrowse.TabIndex = 132
        Me.btnBrowse.Text = "&Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(567, 131)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(97, 35)
        Me.btnClose.TabIndex = 110
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(361, 131)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(97, 35)
        Me.btnSave.TabIndex = 109
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(258, 131)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(97, 35)
        Me.btnNew.TabIndex = 108
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(26, 154)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(208, 28)
        Me.txtSearch.TabIndex = 107
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 21)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Search By Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.CMS_Project.My.Resources.Resources.photo
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(695, 184)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 196)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 134
        Me.PictureBox1.TabStop = False
        '
        'frmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 690)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lstStaff)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbostopwork)
        Me.Controls.Add(Me.dtphireddate)
        Me.Controls.Add(Me.cboPosition)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtpbirthdate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStaff"
        Me.Style = SonaFramework.SonaColorStyle.Used
        Me.Text = "frmStaff"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lstStaff As System.Windows.Forms.ListBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbostopwork As System.Windows.Forms.ComboBox
    Friend WithEvents dtphireddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboPosition As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpbirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
