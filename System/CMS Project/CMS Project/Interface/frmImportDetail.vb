Imports System.Data.SqlClient
Imports Cms.SqlCms
Public Class frmImport : Inherits SonaFramework.Forms.SonaForm
    Public cms As New Systemdb
    Public stSupplier As String


    Private Sub frmImport_Load(sender As Object, e As EventArgs) Handles Me.Load, MyBase.Click
        txtImportID.Text = "Auto Number"
        cboSupplier.DataSource = cms.Execute("SelectAllSupplier", Nothing, "select")
        cboSupplier.DisplayMember = "Name"
        cboSupplier.ValueMember = "SupID"

        cboStaff.DataSource = cms.Execute("SelectAllStaff", Nothing, "select")
        cboStaff.DisplayMember = "staffName"
        cboStaff.ValueMember = "staffID"

        cboEType.DataSource = cms.Execute("SelectAllType", Nothing, "select")
        cboEType.DisplayMember = "EquipType"
        cboEName.DataSource = cms.Execute("SelectAllEquipment", Nothing, "select")
        cboEName.DisplayMember = "EquipName"
        cboEName.ValueMember = "EquipID"
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click

        If btnSupplier.Text = "New S&upplier" Then
            btnSupplier.Text = "Old S&upplier"
            cboSupplier.DataSource = Nothing
            cboSupplier.Focus()
            txtSupplierID.Text = "Auto Number"
            txtAddress.Text = ""
            txtPhone.Text = ""
            txtAddress.ReadOnly = False
            txtPhone.ReadOnly = False
            stSupplier = "New"
        ElseIf btnSupplier.Text = "Old S&upplier" Then
            btnSupplier.Text = "New S&upplier"
            cboSupplier.DataSource = cms.Execute("SelectAllSupplier", Nothing, "select")
            cboSupplier.DisplayMember = "Name"
            cboSupplier.ValueMember = "SupID"
            stSupplier = "Old"
        End If

    End Sub


    Private Sub cboSupplier_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboSupplier.SelectionChangeCommitted
        Dim dr As SqlDataReader
        Dim id As Byte = cboSupplier.SelectedValue
        dr = cms.Exec_reader("SelectSupplierbyID", New List(Of Object)({"@id", id}))
        While dr.Read()
            txtSupplierID.Text = dr.Item(0)
            txtPhone.Text = dr.Item(2)
            txtAddress.Text = dr.Item(3)
        End While
        dr.Close()
        txtPhone.ReadOnly = True
        txtAddress.ReadOnly = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sn As String = cboSupplier.Text.Trim()
        Dim ph As String = txtPhone.Text.Trim()
        Dim ad As String = txtAddress.Text.Trim()
        If stSupplier = "New" Then
            Dim n As Integer = cms.Exec_Perform("InsertSupplier", New List(Of Object)({"@name", sn, "@phone", ph, "@address", ad}))
            If n > 0 Then
                MessageInformation("New supplier has been added.")
            End If
            frmImport_Load(Nothing, Nothing)
            clearControl(Me)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ErrorProvider1.Dispose()
        Dim chk As Boolean
        chk = checkError(ErrorProvider1, New Control() {txtQuantity, txtUnitPrice}, New String() {"quantity", "unitprice"})
        If chk = True Then Exit Sub
        Dim amount As Double
        Dim eqn As String = cboEName.Text.Trim()
        Dim ty As String = cboEType.Text.Trim()
        Dim qty As Byte = Integer.Parse(txtQuantity.Text)
        Dim pr As Double = Double.Parse(txtUnitPrice.Text)
        Dim exd As Date = txtExpireDate.Text.Trim()
        Dim id As Integer = cboEName.SelectedValue
        amount = qty * pr
        With LvImport.Items.Add(id)
            .SubItems.Add(eqn)
            .SubItems.Add(ty)
            .SubItems.Add(exd)
            .SubItems.Add(qty)
            .SubItems.Add(pr.ToString("C"))
            .SubItems.Add(amount.ToString("C"))
        End With
        Dim TotalSum As Double = 0
        For Each item As ListViewItem In LvImport.Items
            TotalSum += CDbl(item.SubItems.Item(6).Text)
        Next
        txtTotal.Text = TotalSum.ToString("C")
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        For Each i As ListViewItem In LvImport.SelectedItems
            LvImport.Items.Remove(i)
        Next
        Dim TotalSum As Double = 0
        For Each item As ListViewItem In LvImport.Items
            TotalSum += CDbl(item.SubItems.Item(6).Text)
        Next
        txtTotal.Text = TotalSum.ToString("C")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseForm(Me)
    End Sub
End Class