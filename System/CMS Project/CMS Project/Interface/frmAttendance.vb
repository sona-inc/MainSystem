Imports Cms.SqlCms
Imports System.Data.SqlClient
Public Class frmAttendance : Inherits SonaFramework.Forms.SonaForm
    Public cms As New Systemdb

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        cms.CreateStoreProcedure("insert into tbAttendance(StaffID,Attendance,Date,Reason)values(@StaffID,@Attendance,@Date,@Reason)", "@StaffID smallint,@Attendance varchar(10),@Date date,@Reason varchar(150)", "InsertToAttendance")
        cms.CreateStoreProcedure("select StaffID,StaffName from tbStaff order by StaffName", Nothing, "SelectAllStaff")
        cms.CreateStoreProcedure("select ID,a.StaffID,s.StaffName from tbAttendance a INNER JOIN tbStaff s ON a.StaffID = s.StaffID where Date=@date order by StaffName", "@Date date", "SelectStaffName")
        cms.CreateStoreProcedure("update tbAttendance set Attendance=@Attendance,Reason=@Reason where ID=@ID", "@Attendance varchar(10),@Reason varchar(150),@id int", "UpdateAttendance")
        cms.CreateStoreProcedure("select ID,StaffName,Attendance,Date,Reason from tbAttendance a INNER JOIN tbStaff s ON a.StaffID = s.StaffID where id=@id", "@id int", "SelectAllAttendance")


        cboStaff.DataSource = cms.Execute("SelectAllStaff", Nothing, "select")
        cboStaff.ValueMember = "StaffID"
        cboStaff.DisplayMember = "StaffName"
        Dim dat As Date = Today
        ListBox1.DataSource = cms.Execute("selectStaffName", New List(Of Object)({"@date", dat}), "select")
        ListBox1.ValueMember = "id"
        ListBox1.DisplayMember = "StaffName"
        btnNew.Select()
        DateFormat()
        cboStaff.SelectedIndex = -1
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateFormat()
    End Sub
    Private Sub DateFormat()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd-MMM-yyyy"
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtID.Enabled = False
        txtID.Text = "Auto Number"
        cboStaff.Focus()
        cboStaff.SelectedIndex = -1
        cboStaff.Enabled = True
        DateTimePicker1.Text = Today
        DateTimePicker1.Enabled = True
        txtAttendance.Clear()
        txtReason.Clear()
        btnSubmit.Enabled = True
        btnUpdate.Enabled = False
        ListBox1.SelectedIndex = -1
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim chek As Boolean
        ErrorProvider1.Dispose()
        chek = checkError(ErrorProvider1, New Control() {cboStaff, txtAttendance, DateTimePicker1}, New String() {"StaffID", "Attendance", "Date"})
        If chek = True Then Exit Sub
        Dim si As Int16 = cboStaff.SelectedValue
        Dim at As String = txtAttendance.Text.Trim()
        Dim dtp As Date = DateTimePicker1.Value.ToString("dd-MMM-yyyy")
        Dim re As String = txtReason.Text.Trim()
        Dim n As Integer = 0
        n = cms.Exec_Perform("InsertToAttendance", New List(Of Object)({"@StaffID", si, "@Attendance", at, "@Date", dtp, "@Reason", re}))
        If n > 0 Then
            MessageBox.Show("A record has been added.")
        End If
        Form1_Load(Nothing, Nothing)
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim at As String = txtAttendance.Text.Trim()
        Dim re As String = txtReason.Text.Trim()
        Dim id As Integer = ListBox1.SelectedValue
        Dim chek As Boolean
        ErrorProvider1.Dispose()
        chek = checkError(ErrorProvider1, New Control() {txtAttendance}, New String() {"Attendance"})
        If chek = True Then Exit Sub
        Dim n As Integer = 0
        n = cms.Exec_Perform("UpdateAttendance", New List(Of Object)({"@Attendance", at, "@Reason", re, "@id", id}))
        If n > 0 Then
            MessageBox.Show("A record has been Updated.")
        End If
    End Sub
    Public Function checkError(ByVal ed As System.Windows.Forms.ErrorProvider, ByVal Ctrl() As Control, ByVal str() As String) As Boolean
        Dim i As Integer, b As Boolean
        For i = 0 To UBound(Ctrl)
            If Ctrl(i).Text = "" Then
                ed.SetError(Ctrl(i), "Please input " + str(i))
                Ctrl(0).Focus()
                b = True
            End If
        Next
        Return b
    End Function

    Private Sub ListBox1_Selected(sender As Object, e As EventArgs) Handles ListBox1.Click
        Dim rd As SqlDataReader
        Dim i As Integer = ListBox1.SelectedValue
        rd = cms.Exec_reader("SelectAllAttendance", New List(Of Object)({"@id", i}))
        While rd.Read()
            txtID.Text = rd.Item(0)
            txtID.Enabled = False
            cboStaff.Text = rd.Item(1)
            txtAttendance.Text = rd.Item(2)
            DateTimePicker1.Text = rd.Item(3)
            txtReason.Text = rd.Item(4)
        End While
        rd.Close()

        btnSubmit.Enabled = False
        btnUpdate.Enabled = True
        cboStaff.Enabled = False
        DateTimePicker1.Enabled = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseForm(Me)
    End Sub
End Class
