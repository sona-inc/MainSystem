Imports Cms.SqlCms
Imports System.Data.SqlClient
Public Class frmPosition : Inherits SonaFramework.Forms.SonaForm
    Public cms As New Systemdb
    Public cn As SqlClient.SqlConnection
    Public id As Long
    Public objDataAdapter As SqlClient.SqlDataAdapter
    Public objDataTable As DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListBox1.DataSource = cms.Execute("SelectAllPosition", Nothing, "select")
        ListBox1.ValueMember = "PositionID"
        ListBox1.DisplayMember = "Position"
        btnNew.Select()
        btnSubmit.Enabled = False
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnStore_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim chek As Boolean
        ErrorProvider1.Dispose()
        chek = checkError(ErrorProvider1, New Control() {txtName, txtDes}, New String() {"Position", "Description"})
        If chek = True Then Exit Sub

        Dim na As String = txtName.Text.Trim()
        Dim de As String = txtDes.Text.Trim()
        Dim n As Integer = cms.Exec_Perform("InsertPosition", New List(Of Object)({"@name", na, "@de", de}))
        If n > 0 Then
            MessageInformation("One record has been added.")
            clearControl(Me)
        End If
        Form1_Load(Nothing, Nothing)

    End Sub

    Private Sub ListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBox1.Click
        Dim rd As SqlDataReader
        Dim id As Integer = ListBox1.SelectedValue
        rd = cms.Exec_reader("selectPositionbyID", New List(Of Object)({"@id", id}))
        While rd.Read()
            txtID.Text = rd.Item(0)
            txtID.Enabled = False
            txtName.Text = rd.Item(1)
            txtDes.Text = rd.Item(2)
        End While
        rd.Close()
        btnSubmit.Enabled = False
        btnUpdate.Enabled = True
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtID.Enabled = False
        txtID.Text = "Auto Number"
        txtName.Focus()
        txtName.Clear()
        txtDes.Clear()
        btnSubmit.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim na As String = txtName.Text.Trim()
        Dim em As String = txtDes.Text.Trim()
        Dim id As Integer = ListBox1.SelectedValue

        Dim chk As Boolean
        ErrorProvider1.Dispose()
        chk = checkError(ErrorProvider1, New Control() {txtName, txtDes}, New String() {"Position", "Description"})
        If chk = True Then Exit Sub

        Dim n As Integer = cms.Exec_Perform("UpdatePosition", New List(Of Object)({"@name", na, "@de", em, "@id", id}))
        If n > 0 Then
            MessageInformation("One has been updated.")
            clearControl(Me)
        End If
        Form1_Load(Nothing, Nothing)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseForm(Me)
    End Sub
End Class
