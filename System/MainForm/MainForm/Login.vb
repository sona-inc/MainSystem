Public Class Login
    Public cms As New sqlCms.sqlCms.Systemdb() ' Object Systemdb in sqlcms
    Dim image As String() = {"test.png", "image.jpg"}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.BackColor = Color.White
        SonaButton1.BackColor = Color.Blue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
