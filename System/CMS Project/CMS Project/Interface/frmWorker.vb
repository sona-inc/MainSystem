Imports Cms.SqlCms
Imports System.Data.SqlClient
Public Class frmWorker : Inherits SonaFramework.Forms.SonaForm
    Public cms As New Systemdb

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSubmit.Enabled = False
        btnUpdate.Enabled = False
        ListBox.DataSource = cms.Execute("SelectAllWorker", Nothing, "select")
        ListBox.ValueMember = "workerid"
        ListBox.DisplayMember = "workername"

        cboWGID.DataSource = cms.Execute("SelectAllWorkerGroup", Nothing, "select")
        cboWGID.ValueMember = "id"
        cboWGID.DisplayMember = "groupname"
        btnNew.Select()
    End Sub

    Private Sub btnStore_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim chek As Boolean
        ErrorProvider1.Dispose()
        chek = checkError(ErrorProvider1, New Control() {txtName, cboGender, txtAge, mtbPhone, txtAddress, cboWGID}, New String() {"Name", "Gender", "Age", "Phone", "Address", "WorkerGroupID"})
        If chek = True Then Exit Sub

        Dim na As String = txtName.Text.Trim()
        Dim gder As String = cboGender.Text.Trim()
        Dim age As Integer = Integer.Parse(txtAge.Text.Trim())
        Dim phne As String = mtbPhone.Text.Trim()
        Dim adr As String = txtAddress.Text.Trim()
        Dim wgid As Integer = cboWGID.SelectedValue

        Dim n As Integer = cms.Exec_Perform("InsertWorker", New List(Of Object)({"@name", na, "@gender", gder, "@age", age, "@phone", phne, "@address", adr, "@workergroupid", wgid}))
        If n > 0 Then
            MessageInformation("One record has been added.")
        End If
        clearControl(Me)
        Form1_Load(Nothing, Nothing)

    End Sub

    Private Sub ListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBox.Click
        Dim rd As SqlDataReader
        Dim st As SqlDataReader
        Dim id As Integer = ListBox.SelectedValue
        Static i As Integer
        rd = cms.Exec_reader("SelectWorkerbyID", New List(Of Object)({"@id", id}))
        While rd.Read()
            txtID.Text = rd.Item(0)
            txtID.Enabled = False
            txtName.Text = rd.Item(1)
            cboGender.Text = rd.Item(2)
            txtAge.Text = rd.Item(3)
            mtbPhone.Text = rd.Item(4)
            txtAddress.Text = rd.Item(5)
            i = rd.Item(6)
        End While
        rd.Close()
        st = cms.Exec_reader("SelectWorkerGroupbyID", New List(Of Object)({"@id", i}))
        While st.Read()
            cboWGID.Text = st.Item(1)
        End While
        st.Close()
        btnSubmit.Enabled = False
        btnUpdate.Enabled = True
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtID.Enabled = False
        txtID.Text = "Auto Number"
        txtName.Focus()
        txtName.Clear()
        'cboGender.Clear()
        txtAge.Clear()
        mtbPhone.Clear()
        txtAddress.Clear()
        'cboWGID.clear()
        btnSubmit.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim na As String = txtName.Text.Trim()
        Dim gder As String = cboGender.Text
        Dim age As Integer = Integer.Parse(txtAge.Text.Trim())
        Dim phne As String = mtbPhone.Text.Trim()
        Dim adr As String = txtAddress.Text.Trim()
        Dim wgid As Integer = cboWGID.SelectedValue

        Dim id As Integer = ListBox.SelectedValue

        Dim chek As Boolean
        ErrorProvider1.Dispose()
        chek = checkError(ErrorProvider1, New Control() {txtName, cboGender, txtAge, mtbPhone, txtAddress, cboWGID}, New String() {"Name", "Gender", "Age", "Phone", "Address", "WorkerGroupID"})
        If chek = True Then Exit Sub

        Dim n As Integer = cms.Exec_Perform("UpdateWorker", New List(Of Object)({"@name", na, "@gender", gder, "@age", age, "@phone", phne, "@address", adr, "@workergroupid", wgid, "@id", id}))
        If n > 0 Then
            MessageInformation("One record has been updated.")
        End If
        clearControl(Me)
        Form1_Load(Nothing, Nothing)

    End Sub

    Private Sub cboGender_KeyUp(sender As Object, e As KeyEventArgs) Handles cboGender.KeyUp
        cboGender.DroppedDown = True
    End Sub


    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        ListBox.DataSource = cms.Execute("SearchWorker", New List(Of Object)({"@name", "%" & txtSearch.Text & "%"}), "Select")
        ListBox.DisplayMember = "workername"
        ListBox.ValueMember = "workerid"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseForm(Me)
    End Sub
End Class
