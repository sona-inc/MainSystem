Imports System.Data.SqlClient
Imports System.Deployment.Internal.CodeSigning
Imports System.IO
Imports System.Web.Security
Imports SonaFramework
Imports SonaFramework.Controls
Imports SonaFramework.Forms
Imports SonaFramework.Encrype

Public Class MainForm : Inherits SonaFramework.Forms.SonaForm
    Private bool As Boolean = True
    Private _p1 As Integer
    Private _byte As Byte()

    Sub New(p1 As Integer)
        InitializeComponent()
        ' TODO: Complete member initialization 
        _p1 = p1
    End Sub


    Private cms As New Cms.SqlCms.Systemdb

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.DataSource = cms.Execute("SelectAllAdminSchema", Nothing, "select")
        ListBox1.DisplayMember = "username"
        ListBox1.DisplayMember = "email"
        DataGridView1.DataSource = cms.query("select s.username,s.email,l.per_date,l.actions from tbLogs l,tbAdminSchema s where l.Ascm_id =s.id")
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        cms.Exec_logs("InsertLogs", _p1, "Has been loged in System at " & Date.Now)
        Dim gp As New System.Drawing.Drawing2D.GraphicsPath()
        gp.AddEllipse(0, 0, PictureBox1.Width - 3, PictureBox1.Height - 3)
        Dim rg As New Region(gp)
        PictureBox1.Region = rg
        Dim rd As SqlDataReader
        rd = cms.Exec_reader("SelectAllAdminShema", New List(Of Object)({"@id", _p1}))
        If rd.Read() Then
            _byte = rd.Item("Photo")
            Label6.Text = rd.Item("username")
            ToolStripButton2.Image = ConvertImageToBitmap(_byte)
            ToolStripButton2.Size = New Size(500, 50)
            ToolStripButton2.Text = rd.Item("username")
            PictureBox1.Image = ConvertImageToBitmap(_byte)
        End If
        rd.Close()

        Setting = True
        Try
            RunCreateStoredProcedure()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       
        AddHandler Ev_Event, AddressOf PerFormSetting
    End Sub

    Private Sub PerFormSetting()
        If bool Then
            'cms.connection()
            SonaComboBox1.DataSource = cms.Execute("SelectIDNAMEUserRight", Nothing)
            SonaComboBox1.DisplayMember = "Name"
            SonaComboBox1.ValueMember = "id"

            SonaComboBox2.DataSource = cms.Execute("SelectAllStaff", Nothing, "select")
            SonaComboBox2.DisplayMember = "StaffName"
            SonaComboBox2.ValueMember = "StaffID"
            SonaTabControl1.Show()
            bool = False
        Else
            SonaTabControl1.Hide()
            bool = True
        End If

    End Sub

    'Private Sub Clickick(sender As object ,e As EventArgs ) Handles s

    Private Sub ToolStaff_Click(sender As Object, e As EventArgs) Handles ToolStaff.Click
        'Dim frm As New frmStaff(_p1)
        ' frm.MdiParent = Me
        'frm.Show()
        frmStaff.Show()
    End Sub

    Private Sub ToolPosition_Click(sender As Object, e As EventArgs) Handles ToolPosition.Click
        frmPosition.MdiParent = Me
        frmPosition.Visible = True
    End Sub

    Private Sub ToolWorker_Click(sender As Object, e As EventArgs) Handles ToolWorker.Click
        frmWorker.MdiParent = Me
        frmWorker.Show()
    End Sub

    Private Sub ToolWorkerGroup_Click(sender As Object, e As EventArgs) Handles ToolWorkerGroup.Click
        frmWorkerGroup.MdiParent = Me
        frmWorkerGroup.Show()
    End Sub

    Private Sub ToolImport_Click(sender As Object, e As EventArgs) Handles ToolImport.Click
        frmImport.MdiParent = Me
        frmImport.Show()
    End Sub

    Private Sub ToolEquipment_Click(sender As Object, e As EventArgs) Handles ToolEquipment.Click
        frmEquipment.MdiParent = Me
        frmEquipment.Show()
    End Sub

    Private Sub ToolSupplier_Click(sender As Object, e As EventArgs) Handles ToolSupplier.Click
        frmSupplier.MdiParent = Me
        frmSupplier.Show()
    End Sub



    Private Sub ElementHost1_ChildChanged(sender As Object, e As Integration.ChildChangedEventArgs)

    End Sub

    Private Sub SonaTabPage3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSumitReg.Click


        Dim en As New EncrypeTo
        Dim es As String
        Dim g As Guid
        Dim password As String = Membership.GeneratePassword(8, 0)
        ' g = Guid.NewGuid()
        es = en.Encrypt(txtPassword.Text.Trim, password, 5)

        Dim n As Integer = Await cms.RunNonQueryScalar("InsertAdminSchema", New List(Of Object)({"@Staff_id", SonaComboBox2.SelectedValue, "@ur_id", SonaComboBox1.SelectedValue,
                                                                     "@username", txtUsername.Text.Trim,
                                                                     "@email", txtEmail.Text.Trim,
                                                                     "@pass_word", es, "@reg_code", password, "@date_reg", Date.Now}))
        Dim message As String = String.Empty
        Select Case n

            Case -1
                message = "Username already exists.\nPlease choose a different username."

                Exit Select
            Case -2
                message = "Email address has already been used."
                Exit Select
            Case Else
                message = "Registration successful. Activation email has been sent."
                Exit Select

        End Select
        MessageBox.Show(message)


    End Sub


    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

    End Sub

    Private Sub SonaTabPage2_Click(sender As Object, e As EventArgs)

    End Sub
End Class
