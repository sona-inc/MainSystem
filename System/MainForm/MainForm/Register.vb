Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Imports sqlCms.sqlCms

Public Class Register : Inherits SonaFramework.Forms.SonaForm
    Public cms As New Systemdb() 'Systemdb in sqlcms class
    Dim bytImage() As Byte
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cms.Sqldumper()
    'Create Procedure"
    'GetAllAdminSchema
        cms.CreateStoreProcedure("select id,username from tbAdminSchema", Nothing, "GetAllAdminSchema")
    'InsertAdminSchema
        cms.CreateStoreProcedure("insert into tbAdminSchema(username,pass_word,email,phone,reg_date,photo)values( @username ,@pass_word , @email ,@phone ,@reg_date,@photo )",
                                 "@username varchar(30),@pass_word varchar(60),@email varchar(50), @phone varchar(20), @reg_date date , @photo varbinary(MAX)", "InsertAdminSchema")

        cms.CreateStoreProcedure("select id,username,pass_word,email,phone,reg_date,photo from tbAdminSchema where id=@id", "@id smallint", "RetriveAdminSchema")
        cms.CreateStoreProcedure("update tbAdminSchema set username=@username,pass_word=@pass_word,email=@email,phone=@phone,reg_date=@reg_date, photo=@photo where id =@id",
                                 "@username varchar(30),@pass_word varchar(60),@email varchar(50), @phone varchar(20), @reg_date date , @photo varbinary(MAX), @id smallint", "UpdateAdminSchema")

        ListBox1.DataSource = cms.Execute("GetAllAdminSchema", Nothing, "select")
        ListBox1.ValueMember = "id"
        ListBox1.DisplayMember = "username"
    End Sub

    Private Sub txtSubmit_Click(sender As Object, e As EventArgs) Handles txtSubmit.Click

        Dim ms As New System.IO.MemoryStream
        Dim bmpImage As New Bitmap(PictureBox1.Image)

        bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        bytImage = ms.ToArray()

        ms.Close()

        Dim n As Integer = cms.Exec_Perform("InsertAdminSchema", New List(Of Object)({"@username", txtUsername.Text.Trim(), "@pass_word", txtPassword.Text.Trim(), "@email",
                                                           txtEmail.Text.Trim(), "@phone", txtPhone.Text.Trim(), "@reg_date", Date.Now, "@photo", bytImage}), "insert")

        ListBox1.DataSource = cms.Execute("GetAllAdminSchema", Nothing, "select")
        ListBox1.ValueMember = "id"
        ListBox1.DisplayMember = "username"
        If n > 0 Then
            MessageBox.Show("has been added")
        End If

        cms.CloseConn()

    End Sub
    Private Sub selectedchange(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
    Private Sub click_listbox(sender As Object, e As EventArgs) Handles ListBox1.Click
        Dim rd As SqlDataReader
        Dim id As Integer
        id = ListBox1.SelectedValue
        rd = cms.Exec_reader("RetriveAdminSchema", New List(Of Object)({"id", id}))
        While rd.Read()
            txtUsername.Text = rd.Item(1)
            txtPassword.Text = rd.Item(2)
            txtEmail.Text = rd.Item(3)
            txtPhone.Text = rd.Item(4)
            DateTimePicker1.Value = rd.Item(5)
            Try
                bytImage = CType(rd.Item(6), Byte())
                Dim ms As New System.IO.MemoryStream(bytImage)
                Dim bmImage As New Bitmap(ms)
                ms.Close()

                PictureBox1.Image = bmImage
                PictureBox1.Refresh()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End While
        MessageBox.Show(id)
        rd.Close()

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim file As New OpenFileDialog
        With file
            .InitialDirectory = "C:"
            .Filter = "Only Picture With JPG/JPEG/PNG Extention|*.jpg;*.jpeg;*.png"
            .FileName = Nothing

        End With

        If file.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(file.FileName)
            PictureBox1.Tag = file.FileName
        Else
            file.Tag = ""
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ListBox1.DataSource = cms.Execute("SelectAllAdmin", New List(Of Object)({"@username", TextBox1.Text.Trim}), "select")
        ListBox1.ValueMember = "id"
        ListBox1.DisplayMember = "username"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ms As New System.IO.MemoryStream
        Dim bmpImage As New Bitmap(PictureBox1.Image)

        bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        bytImage = ms.ToArray()

        ms.Close()
        Dim n As Integer = cms.Exec_Perform("UpdateAdminSchema", New List(Of Object)({"@username", txtUsername.Text.Trim,
                                                              "@pass_word", txtPassword.Text.Trim,
                                                              "@email", txtEmail.Text.Trim, "@phone",
                                                              txtPhone.Text.Trim, "@reg_date", Date.Now,
                                                              "@photo", bytImage, "@id", ListBox1.SelectedValue}), "update")
        ListBox1.DataSource = cms.Execute("GetAllAdminSchema", Nothing, "select")
        ListBox1.ValueMember = "id"
        ListBox1.DisplayMember = "username"
        If n > 0 Then

        End If
    End Sub
End Class