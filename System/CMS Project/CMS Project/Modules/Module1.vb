Module Module1
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
    Public Sub clearControl(ByVal F As Form)
        Dim c As Control
        For Each c In F.Controls
            If TypeOf c Is TextBox Or TypeOf c Is ComboBox Or TypeOf c Is MaskedTextBox Then
                If c.Tag = "" Then c.Text = ""
            End If
        Next
    End Sub
    Public Sub CloseForm(ByVal frm As Form)
        Dim y As Byte
        y = MsgBox("Do you want to close?", vbYesNo + vbQuestion, "Close Form")
        If y = vbYes Then
            frm.Close()
        End If
    End Sub

    Public Sub MessageInformation(ByVal st As String)
        MessageBox.Show(st, "Construction Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Module
