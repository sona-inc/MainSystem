Imports Cms.SqlCms
Imports System.Data.SqlClient
Public Class frmWorkerGroup : Inherits SonaFramework.Forms.SonaForm
    Public cms As New Systemdb

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox.DataSource = cms.Execute("SelectAllWorkerGroup", Nothing, "select")
        ListBox.ValueMember = "id"
        ListBox.DisplayMember = "groupname"

        cboStaffID.DataSource = cms.Execute("SelectAllStaff", Nothing, "select")
        cboStaffID.ValueMember = "Staffid"
        cboStaffID.DisplayMember = "StaffName"
        btnNew.Select()
        btnSubmit.Enabled = False
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim chek As Boolean
        ErrorProvider1.Dispose()
        chek = checkError(ErrorProvider1, New Control() {txtGName, cboStaffID, txtDescrption, txtAmount}, New String() {"GroupName", "Staff Name", "Descrption", "Amount"})
        If chek = True Then Exit Sub

        Dim gname As String = txtGName.Text.Trim()
        Dim sfid As Integer = cboStaffID.SelectedValue
        Dim descr As String = txtDescrption.Text.Trim()
        Dim am As String = txtAmount.Text
        Dim dt As String = txtCreate_date.Text

        Dim n As Integer = cms.Exec_Perform("InsertWorkerGroup", New List(Of Object)({"@name", gname, "@staffid", sfid, "@descr", descr, "@amount", am, "@date", dt}))
        If n > 0 Then
            MessageInformation("One record has been added.")
        End If
        clearControl(Me)
        Form2_Load(Nothing, Nothing)

    End Sub

    Private Sub ListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBox.Click
        Dim rd As SqlDataReader
        Dim st As SqlDataReader
        Static i As Integer
        Dim id As Integer = ListBox.SelectedValue
        rd = cms.Exec_reader("selectWorkerGroupbyID", New List(Of Object)({"@id", id}))
        While rd.Read()
            txtID.Text = rd.Item(0)
            txtID.Enabled = False
            txtGName.Text = rd.Item(1)
            i = rd.Item(2)
            txtDescrption.Text = rd.Item(3)
            txtAmount.Text = rd.Item(4)
            txtCreate_date.Text = rd.Item(5)
        End While
        rd.Close()

        st = cms.Exec_reader("SelectStaffbyID", New List(Of Object)({"@id", i}))
        While st.Read()
            cboStaffID.Text = st.Item(1)
        End While
        st.Close()

        btnSubmit.Enabled = False
        btnUpdate.Enabled = True
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtID.Enabled = False
        txtID.Text = "Auto Number"
        txtGName.Focus()
        txtGName.Clear()
        'cboStaffID.Clear()
        txtDescrption.Clear()
        txtAmount.Clear()
        btnSubmit.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim gname As String = txtGName.Text.Trim()
        Dim sfid As Integer = cboStaffID.SelectedValue
        Dim descr As String = txtDescrption.Text.Trim()
        Dim am As String = txtAmount.Text.Trim()
        Dim dt As String = txtCreate_date.Text
        Dim id As Integer = ListBox.SelectedValue
        Dim chek As Boolean
        ErrorProvider1.Dispose()
        chek = checkError(ErrorProvider1, New Control() {txtGName, cboStaffID, txtDescrption, txtAmount}, New String() {"GroupName", "Staff Name", "Descrption", "Amount"})
        If chek = True Then Exit Sub

        Dim n As Integer = cms.Exec_Perform("UpdateWorkerGroup", New List(Of Object)({"@name", gname, "@staffid", sfid, "@descr", descr, "@amount", am, "@date", dt, "@id", id}))
        If n > 0 Then
            MessageInformation("One record has been updated.")
        End If
        clearControl(Me)
        Form2_load(Nothing, Nothing)

    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        ListBox.DataSource = cms.Execute("SearchWorkerGroup", New List(Of Object)({"@name", "%" & txtSearch.Text & "%"}), "Select")
        ListBox.DisplayMember = "groupname"
        ListBox.ValueMember = "id"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseForm(Me)
    End Sub
End Class
