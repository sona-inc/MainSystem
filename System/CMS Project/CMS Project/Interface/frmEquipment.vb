Imports Cms.SqlCms
Imports System.Data.SqlClient
Public Class frmEquipment : Inherits SonaFramework.Forms.SonaForm
    Public cms As New Systemdb

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstEquipment.DataSource = cms.Execute("SelectAllEquipment", Nothing, "select")
        lstEquipment.ValueMember = "Equipid"
        lstEquipment.DisplayMember = "Equipname"

        btnSave.Enabled = False
        btnUpdate.Enabled = False
        btnNew.Select()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim chek As Boolean
        ErrorProvider1.Dispose()
        chek = checkError(ErrorProvider1, New Control() {txtEquipName, cboType, txtQty, txtUnitPrice, txtExpDate}, New String() {"Name", "EquipType", "Quantity", "UnitPrice", "ExpDate"})
        If chek = True Then Exit Sub

        Dim na As String = txtEquipName.Text.Trim()
        Dim etype As String = cboType.Text.Trim()
        Dim qty As Integer = Integer.Parse(txtQty.Text.Trim())
        Dim unitp As String = Double.Parse(txtUnitPrice.Text.Trim())
        Dim am As String = qty * unitp
        Dim expd As String = txtExpDate.Text.Trim()

        Dim n As Integer = cms.Exec_Perform("InsertEquipment", New List(Of Object)({"@name", na, "@type", etype, "@qty", qty, "@price", unitp, "@amount", am, "@exdate", expd}))
        If n > 0 Then
            MessageInformation("One record has been added.")
        End If
        clearControl(Me)
        Form1_Load(Nothing, Nothing)

    End Sub

    Private Sub ListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstEquipment.Click
        Dim rd As SqlDataReader
        Dim id As Integer = lstEquipment.SelectedValue
        rd = cms.Exec_reader("SelectEquipmentbyID", New List(Of Object)({"@id", id}))
        While rd.Read()
            txtEquipID.Text = rd.Item(0)
            txtEquipID.Enabled = False
            txtEquipName.Text = rd.Item(1)
            cboType.Text = rd.Item(2)
            txtQty.Text = rd.Item(3)
            txtUnitPrice.Text = rd.Item(4)
            txtExpDate.Text = rd.Item(6)
        End While
        rd.Close()
        btnSave.Enabled = False
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtEquipID.Enabled = False
        clearControl(Me)
        txtEquipName.Focus()
        txtEquipID.Text = "Auto Number"
        btnSave.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim chek As Boolean
        ErrorProvider1.Dispose()
        chek = checkError(ErrorProvider1, New Control() {txtEquipName, cboType, txtQty, txtUnitPrice, txtExpDate}, New String() {"Name", "EquipType", "Quantity", "UnitPrice", "ExpDate"})
        If chek = True Then Exit Sub

        Dim na As String = txtEquipName.Text.Trim()
        Dim etype As String = cboType.Text.Trim()
        Dim qty As Integer = Integer.Parse(txtQty.Text.Trim())
        Dim unitp As Double = txtUnitPrice.Text
        Dim am As String = qty * unitp
        Dim expd As String = txtExpDate.Text
        Dim id As Integer = lstEquipment.SelectedValue

        Dim n As Integer = cms.Exec_Perform("UpdateEquipment", New List(Of Object)({"@name", na, "@type", etype, "@qty", qty, "@price", unitp, "@amount", am, "@exdate", expd, "@id", id}))
        If n > 0 Then
            MessageInformation("One record has been updated.")
        End If
        clearControl(Me)
        Form1_Load(Nothing, Nothing)

    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        If txtSearch.Text Is Nothing Then Return
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
        lstEquipment.DataSource = cms.Execute("SearchEquipment", New List(Of Object)({"@name", "%" & txtSearch.Text & "%"}), "Select")
        lstEquipment.ValueMember = "EquipID"
        lstEquipment.DisplayMember = "Equipname"

    End Sub
   
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseForm(Me)
    End Sub
End Class
