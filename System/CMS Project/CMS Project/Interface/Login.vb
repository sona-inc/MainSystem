Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Threading
Imports System.Web.Security
Imports Cms.Grant
Imports Cms.SqlCms
Imports SonaFramework.Forms
Imports SonaFramework.Encrype

Public Class Login : Inherits SonaFramework.Forms.SonaForm
    Public Property Id As Integer
    Private bool As Boolean = True

    Private bty As Byte()
    Private en As New EncrypeTo
    Private s, d As String
    Private text As String
    Private dt As DataTable
    Dim rd As SqlDataReader
    Dim cms As New Cms.SqlCms.Systemdb
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'WinAPI.AnimateWindow(Me, 1000, WinAPI.AW_BLEND)
        Panel4.Hide()
        SonaTile1.Hide()
        Panel2.Hide()
        Try
            RunCreateStoredProcedure()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub mouse(sender As Object, e As EventArgs) Handles Me.MouseDown
        'If bool Then
        '    Me.BackImage = My.Resources._1431471773_hourglass_48
        '    bool = False
        'Else
        '    Me.BackImage = My.Resources._240FC90E00000578_2874678_image_a_44_1418659635115
        '    bool = True
        'End If
    End Sub

    'Private Sub SonaButton1_Click(sender As Object, e As MouseEventArgs) Handles SonaButton1.MouseHover
    '    WinAPI.AnimateWindow(Me.Handle, 10000, WinAPI.AW_BLEND)
    'End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text.Trim = "Username" Then
            TextBox1.Text = ""

        End If
        If TextBox2.Text.Trim Is Nothing Then
            TextBox2.Text = "Password"
            TextBox2.UseSystemPasswordChar = False
        End If

    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text.Trim Is Nothing Then
            TextBox1.Text = "Username"
        End If
    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        If TextBox2.Text.Trim = "Password" Then
            TextBox2.Text = ""
            TextBox2.UseSystemPasswordChar = True
        End If
        If TextBox1.Text.Trim Is Nothing Then
            TextBox1.Text = "Username"
        End If

    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus

        If TextBox2.Text.Trim Is Nothing Then
            TextBox2.Text = "Password"
            TextBox2.UseSystemPasswordChar = False
        End If

    End Sub

    Private Async Sub SonaButton1_Click(sender As Object, e As EventArgs) Handles SonaButton1.Click
        Dim c As New AsynSql

        'Dim worker As New Thread(New ThreadStart(Function()

        '                                             Thread.Sleep(1000)

        '                                             MainForm.Show()
        '                                         End Function))
        'cms.Invoke_Procedure("SelectRgc", New List(Of Object)({"@username", TextBox1.Text.Trim, "@email", TextBox1.Text.Trim}), "select")

        'Dim m As Object = Await c.Invoke("select * from tbAdminSchema")

        Try
            rd = Await c.RunSelect("SelectRgc", New List(Of Object)({"@username", TextBox1.Text.Trim, "@email", TextBox1.Text.Trim}))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If rd.Read() Then
            s = rd.Item("reg_code")

        End If

        Dim m As String = en.Encrypt(TextBox2.Text.Trim, s, 5)
        MessageBox.Show(m)
        Try
            rd = Await c.RunSelect("SelectForLogin", New List(Of Object)({"@username", TextBox1.Text.Trim, "@email", TextBox1.Text.Trim, "@pass_word", m}))
            MessageBox.Show(s)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        If rd.Read Then
            Id = rd.Item("id")
            Dim n As Integer = cms.Exec_logs("InsertLogs", Id, "Has been loged in System at " & Date.Now)
            If n > 0 Then
                MessageBox.Show("hjfjfjfhgj")
            End If
            Me.Hide()
            Me.ShadowType() = SonaFormShadowType.None
            SonaTile1.Hide()
            Dim f As MainForm
            f = New MainForm(Id)
            f.ShowDialog()
            'MainForm.Show()


            'worker.Start()


        Else
            SonaTile1.Text = "Your email or password were incorrect."
            SonaTile1.Show()

            cms.connection()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.KeyUp
        Dim rder As SqlDataReader
        rder = cms.Exec_reader("ShearchAdminSchema", New List(Of Object)({"@username", "%" & TextBox1.Text.Trim & "%", "@email", "%" & TextBox1.Text.Trim & "%"}))
        If rder.Read() Then
            bty = rder.Item("Photo")
            PictureBox1.Image = ConvertImageToBitmap(bty)

        End If
        If TextBox1.Text.Trim.Equals("") Then
            PictureBox1.Image = Nothing
        End If

        rder.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If bool Then
            Panel2.Show()
            bool = False
        Else
            Panel2.Hide()
            bool = True
        End If

    End Sub

    Private Sub SonaPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String = Membership.GeneratePassword(8, 0)
        cms.Exec_Perform("InsertRgc", New List(Of Object)({"@reg_code", s, "@username", TextBox3.Text.Trim, "@email", TextBox3.Text.Trim}))
        Dim rder As SqlDataReader
        rder = cms.Exec_reader("SelectRgc", New List(Of Object)({"@username", TextBox3.Text.Trim, "@email", TextBox3.Text.Trim}))
        If rder.Read() Then
            s = rder.Item("reg_code")
            d = rder.Item("email")
        Else
            MessageBox.Show("Username or Email doesn't exit!!!")
        End If
        rder.Close()
        text = TextBox3.Text.Trim
        cms.sona_SetData(New String() {"@username", text, "@email", TextBox3.Text.Trim})
        en.SendActivationEmail(s, d, "smtp.gmail.com", "inc.sona@gmail.com", en.Decrypt("PgP/JgcCLPSMBQN6Sf6YHw==", "math122reg", 5))

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rder As SqlDataReader
        Dim n As Integer = cms.Exec_Perform("CheckRegCode", New List(Of Object)({"@reg_code", TextBox4.Text.Trim}))
        If n = -1 Then
            Panel4.Show()
        Else
            MessageBox.Show("Can't verify to change your password.")
        End If
    End Sub

    Private Sub SonaButton2_Click(sender As Object, e As EventArgs) Handles SonaButton2.Click
        Dim g As Guid
        g = Guid.NewGuid()
        Dim n As Integer = cms.Exec_Perform("InsertRgcPass", New List(Of Object)({"@reg_code", g.ToString(), "@pass_word", TextBox6.Text.Trim}))
        If n > 0 Then
            MessageBox.Show("Has been change")
        End If

    End Sub
End Class

