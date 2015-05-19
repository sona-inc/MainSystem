Imports Cms.SqlCms
Imports System.Data.SqlClient
Imports SonaFramework

Public Class frmStaff : Inherits SonaFramework.Forms.SonaForm
    Public cms As New Systemdb
    Dim bytImage As Byte()
    Private _p1 As Integer

    'Sub New(p1 As Integer)
    '    InitializeComponent()
    '    _p1 = p1
    'End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim chk As Boolean
        bytImage = ConvertImageToByte(PictureBox1)
        ErrorProvider1.Dispose()
        chk = checkError(ErrorProvider1, New Control() {txtName, cboGender, dtpbirthdate, cboStatus, txtPhone, txtAddress, dtphireddate, txtSalary, cbostopwork, cboPosition},
                                        New String() {"name", "gender", "birth date", "status", "phone", "address", "hireddate", "salary", "status of work", "position"})
        If chk = True Then Exit Sub

        Dim na As String = txtName.Text.Trim()
        Dim gen As String = cboGender.Text
        Dim bir As Date = dtpbirthdate.Text
        Dim mar As String = cboStatus.Text
        Dim phone As String = txtPhone.Text.Trim()
        Dim adr As String = txtAddress.Text.Trim()
        Dim hire As Date = dtphireddate.Text
        Dim sto As String = cbostopwork.Text
        Dim sal As String = txtSalary.Text.Trim()
        Dim posi As String = cboPosition.SelectedValue
        Dim id As Integer = lstStaff.SelectedValue

        Dim n As Integer = cms.Exec_Perform("InsertStaff", New List(Of Object)({"@name", na, "@gen", gen, "@Birt", bir, "@mar", mar, "@phone", phone, "@adr", adr, "@hire", hire, "@sal", sal, "@sto", sto, "@posi", posi, "@photo", bytImage}))
        If n > 0 Then
            MessageInformation("One record has been added.")
            'cms.Exec_logs("InsertLogs", _p1, "user id " & _p1 & " has been add new staff at " & Date.Now)
        End If
        clearControl(Me)
        frmStaff_Load(Nothing, Nothing)

    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        PictureBox1.Image = Nothing
        clearControl(Me)
        txtID.ReadOnly = True
        txtID.Text = "Auto Number"
        txtName.Focus()
        btnUpdate.Enabled = False
        btnSave.Enabled = True
        PictureBox1.Image = My.Resources.photo
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub frmStaff_Load(sender As Object, e As EventArgs) Handles Me.Load
        WinAPI.AnimateWindow(Me.Handle, 100, WinAPI.AW_BLEND)
        lstStaff.DataSource = cms.Execute("SelectAllStaff", Nothing, "select")
        lstStaff.ValueMember = "StaffID"
        lstStaff.DisplayMember = "StaffName"
        cboPosition.DataSource = cms.Execute("SelectAllPosition", Nothing, "select")
        cboPosition.ValueMember = "PositionID"
        cboPosition.DisplayMember = "Position"
        btnNew.Select()
        btnSave.Enabled = False
        btnUpdate.Enabled = False
    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        lstStaff.DataSource = cms.Execute("SearchStaff", New List(Of Object)({"@name", "%" & txtSearch.Text & "%"}), "Select")
        lstStaff.ValueMember = "StaffID"
        lstStaff.DisplayMember = "StaffName"
    End Sub

    Private Sub cboGender_KeyDown(sender As Object, e As KeyEventArgs) Handles cboGender.KeyDown
        cboGender.DroppedDown = True
    End Sub

    Private Sub cboPosition_KeyDown(sender As Object, e As KeyEventArgs) Handles cboPosition.KeyDown
        cboPosition.DroppedDown = True
    End Sub

    Private Sub cboStatus_KeyDown(sender As Object, e As KeyEventArgs) Handles cboStatus.KeyDown
        cboStatus.DroppedDown = True
    End Sub

    Private Sub cbostopwork_KeyDown(sender As Object, e As KeyEventArgs) Handles cbostopwork.KeyDown
        cbostopwork.DroppedDown = True
    End Sub

    Private Sub lstStaff_Click(sender As Object, e As EventArgs) Handles lstStaff.Click
        Dim dr As SqlDataReader
        Dim st As SqlDataReader
        Dim i As Integer
        dr = cms.Exec_reader("SelectStaffbyID", New List(Of Object)({"@id", lstStaff.SelectedValue}))
        While dr.Read()
            txtID.Text = dr.Item(0)
            txtID.ReadOnly = True
            txtName.Text = dr.Item(1)
            cboGender.Text = dr.Item(2)
            dtpbirthdate.Text = dr.Item(3)
            cboStatus.Text = dr.Item(4)
            txtPhone.Text = dr.Item(5)
            txtAddress.Text = dr.Item(6)
            dtphireddate.Text = dr.Item(7)
            txtSalary.Text = dr.Item(8)
            cbostopwork.Text = dr.Item(9)
            i = dr.Item(10)
            PictureBox1.Image = ConvertImageToBitmap(dr.Item(11))
        End While
        dr.Close()
        st = cms.Exec_reader("SelectPositionbyID", New List(Of Object)({"@id", i}))
        While st.Read()
            cboPosition.Text = st.Item(1)
        End While

        st.Close()
        btnSave.Enabled = False
        btnUpdate.Enabled = True

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim chk As Boolean
        ErrorProvider1.Dispose()
        chk = checkError(ErrorProvider1, New Control() {txtName, cboGender, dtpbirthdate, cboStatus, txtPhone, txtAddress, dtphireddate, txtSalary, cbostopwork, cboPosition},
                                        New String() {"name", "gender", "birth date", "status", "phone", "address", "hireddate", "salary", "status of work", "position"})
        If chk = True Then Exit Sub
        bytImage = ConvertImageToByte(PictureBox1)
        Dim na As String = txtName.Text.Trim()
        Dim gen As String = cboGender.Text
        Dim bir As Date = dtpbirthdate.Text
        Dim mar As String = cboStatus.Text
        Dim phone As String = txtPhone.Text.Trim()
        Dim adr As String = txtAddress.Text.Trim()
        Dim hire As Date = dtphireddate.Text
        Dim sto As String = cbostopwork.Text
        Dim sal As String = txtSalary.Text.Trim()
        Dim posi As String = cboPosition.SelectedValue
        Dim id As Integer = lstStaff.SelectedValue

        Dim n As Integer = cms.Exec_Perform("UpdateStaff", New List(Of Object)({"@name", na, "@gen", gen, "@Birt", bir, "@mar", mar, "@phone", phone, "@adr", adr, "@hire", hire, "@sal", sal, "@sto", sto, "@posi", posi, "@photo", bytImage, "@id", lstStaff.SelectedValue}))
        If n > 0 Then
            MessageInformation("One record has been updated.")
        End If
        clearControl(Me)
        frmStaff_Load(Nothing, Nothing)
    End Sub


    Private Sub btnBrowse_Click1(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileImage(PictureBox1)
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseForm(Me)
    End Sub
End Class