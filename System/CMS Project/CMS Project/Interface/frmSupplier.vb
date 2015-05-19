Imports Cms.SqlCms
Imports System.Data.SqlClient
Public Class frmSupplier : Inherits SonaFramework.Forms.SonaForm
    Public cms As New Systemdb

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListBox.DataSource = cms.Execute("SelectAllSupplier", Nothing, "select")
        ListBox.ValueMember = "SupID"
        ListBox.DisplayMember = "Name"

        btnNew.Select()
        btnSubmit.Enabled = False
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim chek As Boolean
        ErrorProvider1.Dispose()
        chek = checkError(ErrorProvider1, New Control() {txtName, txtPhone, txtAddress}, New String() {"Name", "Phone", "Address"})
        If chek = True Then Exit Sub

        Dim name As String = txtName.Text.Trim()
        Dim phone As String = txtPhone.Text.Trim()
        Dim addr As String = txtAddress.Text.Trim()

        Dim n As Integer = cms.Exec_Perform("InsertSupplier", New List(Of Object)({"@name", name, "@phone", phone, "@address", addr}))
        If n > 0 Then
            MessageInformation("One record has been added.")
        End If
        clearControl(Me)
        Form2_Load(Nothing, Nothing)

    End Sub

    Private Sub ListBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBox.Click
        Dim rd As SqlDataReader
        Dim id As Integer = ListBox.SelectedValue
        rd = cms.Exec_reader("SelectSupplierbyID", New List(Of Object)({"@id", id}))
        While rd.Read()
            txtID.Text = rd.Item(0)
            txtID.Enabled = False
            txtName.Text = rd.Item(1)
            txtPhone.Text = rd.Item(2)
            txtAddress.Text = rd.Item(3)
        End While
        rd.Close()
        btnSubmit.Enabled = False
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtID.ReadOnly = True
        clearControl(Me)
        txtName.Focus()
        txtID.Text = "Auto Number"
        btnSubmit.Enabled = True
        btnUpdate.Enabled = False
    End Sub



    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        '---------->*Way 1* Search in listbox then call DisplayData()
        'Dim index = ListBox.FindString(txtSearch.Text)
        'Dim dt As DataTable
        'If index = -1 Then
        '    dt = ListBox.DataSource
        '    ListBox.DataSource = Nothing
        '    Return
        'End If
        'ListBox.SetSelected(index, True)
        'Call DisplayData()
        '---------->*Way 2* Search in server with T-SQL then Select workers who has the name as Wildcard filter
        ListBox.DataSource = cms.Execute("SearchSupplier", New List(Of Object)({"@name", "%" & txtSearch.Text & "%"}), "Select")
        ListBox.ValueMember = "SupID"
        ListBox.DisplayMember = "Name"
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim chek As Boolean
        ErrorProvider1.Dispose()
        chek = checkError(ErrorProvider1, New Control() {txtName, txtPhone, txtAddress}, New String() {"Name", "Phone", "Address"})
        If chek = True Then Exit Sub

        Dim name As String = txtName.Text.Trim()
        Dim phone As String = txtPhone.Text.Trim()
        Dim addr As String = txtAddress.Text.Trim()
        Dim id As Integer = ListBox.SelectedValue

        Dim n As Integer = cms.Exec_Perform("UpdateSupplier", New List(Of Object)({"@name", name, "@phone", phone, "@address", addr, "@id", id}))
        If n > 0 Then
            MessageInformation("One record has been Updated.")
        End If
        clearControl(Me)
        Form2_Load(Nothing, Nothing)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseForm(Me)
    End Sub
End Class
