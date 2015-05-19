Imports Cms.SqlCms
Imports System.Data.SqlClient
Public Class frmWorkerAttendance : Inherits SonaFramework.Forms.SonaForm
    Public cms As New Systemdb

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        cms.CreateStoreProcedure("insert into tbWorkerAttendance(WorkerID,Date,Present)values(@WorkerID,@Date,@Prestent)", "@WorkerID int,@Date date, @Present bit", "InsertToWorkerAttendance")
        cms.CreateStoreProcedure("select ID,wa.WorkerID,w.WorkerName from tbWorkerAttendance wa INNER JOIN tbWorker w ON wa.WorkerID = w.WorkerID where date=@date order by WorkerName", "@date date", "SelectWorkerAttendance")
        cms.CreateStoreProcedure("select ID,WorkerName,Date,Present from tbWorkerAttendance wa INNER JOIN tbWorker w ON wa.WorkerID = w.WorkerID where id=@id", "@id int", "SelectAWorkerAttendance")
        cms.CreateStoreProcedure("Update tbWorkerAttendance set Present=@Present where ID=@ID", "@Present bit,@id int", "UpdateWorkerAttendance1")
        cms.CreateStoreProcedure("select WorkerID,WorkerName from tbWorker order by WorkerID", Nothing, "SelectAllWorker")

        cboWorkerID.DataSource = cms.Execute("SelectAllWorker", Nothing, "select")
        cboWorkerID.ValueMember = "WorkerID"
        cboWorkerID.DisplayMember = "WorkerName"

        Dim dat As Date = Today
        ListBox1.DataSource = cms.Execute("SelectWorkerAttendance", New List(Of Object)({"@date", dat}), "select")
        ListBox1.ValueMember = "ID"
        ListBox1.DisplayMember = "WorkerName"

        btnNew.Select()
        cboWorkerID.SelectedIndex = -1

    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtID.Enabled = False
        txtID.Text = "Auto Number"
        cboWorkerID.Focus()
        cboWorkerID.SelectedIndex = -1
        DateTimePicker1.Text = Today
        cboPresent.SelectedIndex = -1
        cboWorkerID.Enabled = True
        DateTimePicker1.Enabled = True
        btnSubmit.Enabled = True
        btnUpdate.Enabled = False
        ListBox1.SelectedIndex = -1


    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim chek As Boolean
        ErrorProvider1.Dispose()
        chek = checkError(ErrorProvider1, New Control() {cboWorkerID, DateTimePicker1, cboPresent}, New String() {"WorkerID", "Date", "Present"})
        If chek = True Then Exit Sub
        Dim wi As Integer = cboWorkerID.SelectedValue
        Dim dtp As String
        dtp = DateTimePicker1.Value.ToString("dd-MMM-yyyy")
        Dim pr As Boolean = cboPresent.SelectedValue
        Dim n As Integer = 0
        n = cms.Exec_Perform("InsertToWorkerAttendance", New List(Of Object)({"@WorkerID", wi, "@Date", dtp, "@Present", pr}))
        If n > 0 Then
            MessageBox.Show("A record has been added.")
        End If
        Form1_Load(Nothing, Nothing)
    End Sub


    Private Sub ListBox1_Selected(sender As Object, e As EventArgs) Handles ListBox1.Click
        Dim rd As SqlDataReader
        Dim i As Integer = ListBox1.SelectedValue
        Dim id As Integer = ListBox1.SelectedValue
        rd = cms.Exec_reader("SelectAWorkerAttendance", New List(Of Object)({"@id", i}))
        While rd.Read()
            txtID.Text = rd.Item(0)
            txtID.Enabled = False
            cboWorkerID.Text = rd.Item(1)
            DateTimePicker1.Text = rd.Item(2)
            cboPresent.Text = rd.Item(3)
        End While
        rd.Close()

        btnSubmit.Enabled = False
        btnUpdate.Enabled = True
        cboWorkerID.Enabled = False
        DateTimePicker1.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Dim da As Date = DateTimePicker1.Text
        Dim pr As Boolean = cboPresent.SelectedIndex
        Dim id As Integer = ListBox1.SelectedValue
        ' Dim wi As Integer = cboWorkerID.SelectedValue
        Dim check As Boolean
        ErrorProvider1.Dispose()
        check = checkError(ErrorProvider1, New Control() {cboPresent}, New String() {"Present"})
        If check = True Then Exit Sub

        Dim n As Integer = cms.Exec_Perform("UpdateWorkerAttendance1", New List(Of Object)({"@Present", pr, "@id", id}))
        If n > 0 Then
            MessageInformation("A record has been updated.")
        End If
    End Sub

    'Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
    '    DateFormat()
    'End Sub
    'Private Sub DateFormat()
    '    DateTimePicker1.Format = DateTimePickerFormat.Custom
    '    DateTimePicker1.CustomFormat = "dd-MMM-yyyy"
    'End Sub



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseForm(Me)
    End Sub
End Class
