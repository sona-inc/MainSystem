<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits SonaFramework.Forms.SonaForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SonaPanel1 = New SonaFramework.Controls.SonaPanel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SonaButton1 = New SonaFramework.Controls.SonaButton()
        Me.SonaTile1 = New SonaFramework.Controls.SonaTile()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.HtmlPanel1 = New SonaFramework.Drawing.Html.HtmlPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.HtmlLabel1 = New SonaFramework.Drawing.Html.HtmlLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SonaButton2 = New SonaFramework.Controls.SonaButton()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SonaPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.HtmlPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SonaPanel1
        '
        Me.SonaPanel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.SonaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SonaPanel1.Controls.Add(Me.LinkLabel1)
        Me.SonaPanel1.HorizontalScrollbarBarColor = True
        Me.SonaPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.SonaPanel1.HorizontalScrollbarSize = 10
        Me.SonaPanel1.Location = New System.Drawing.Point(-2, 675)
        Me.SonaPanel1.Name = "SonaPanel1"
        Me.SonaPanel1.Size = New System.Drawing.Size(1308, 58)
        Me.SonaPanel1.Style = SonaFramework.SonaColorStyle.Green
        Me.SonaPanel1.TabIndex = 3
        Me.SonaPanel1.UseCustomBackColor = True
        Me.SonaPanel1.UseCustomForeColor = True
        Me.SonaPanel1.UseStyleColors = True
        Me.SonaPanel1.VerticalScrollbarBarColor = True
        Me.SonaPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.SonaPanel1.VerticalScrollbarSize = 10
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(587, 10)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(110, 22)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Any issue?"
        '
        'TextBox1
        '
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.CausesValidation = False
        Me.TextBox1.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBox1.Location = New System.Drawing.Point(37, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(257, 39)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Username"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.CausesValidation = False
        Me.TextBox2.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBox2.Location = New System.Drawing.Point(37, 95)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(257, 39)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "Password"
        '
        'SonaButton1
        '
        Me.SonaButton1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.SonaButton1.DisplayFocus = True
        Me.SonaButton1.FontSize = SonaFramework.SonaButtonSize.Tall
        Me.SonaButton1.ForeColor = System.Drawing.Color.White
        Me.SonaButton1.Location = New System.Drawing.Point(37, 149)
        Me.SonaButton1.Name = "SonaButton1"
        Me.SonaButton1.Size = New System.Drawing.Size(257, 45)
        Me.SonaButton1.Style = SonaFramework.SonaColorStyle.Bisque
        Me.SonaButton1.TabIndex = 2
        Me.SonaButton1.Text = "Login"
        Me.SonaButton1.UseCustomBackColor = True
        Me.SonaButton1.UseCustomForeColor = True
        Me.SonaButton1.UseSelectable = True
        Me.SonaButton1.UseStyleColors = True
        '
        'SonaTile1
        '
        Me.SonaTile1.ActiveControl = Nothing
        Me.SonaTile1.Location = New System.Drawing.Point(37, 25)
        Me.SonaTile1.Name = "SonaTile1"
        Me.SonaTile1.Size = New System.Drawing.Size(257, 26)
        Me.SonaTile1.TabIndex = 4
        Me.SonaTile1.Text = "SonaTile1"
        Me.SonaTile1.TileTextFontWeight = SonaFramework.SonaTileTextWeight.Bold
        Me.SonaTile1.UseCustomBackColor = True
        Me.SonaTile1.UseCustomForeColor = True
        Me.SonaTile1.UseSelectable = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(303, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(40, 203)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(161, 24)
        Me.LinkLabel2.TabIndex = 6
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Forgot password?"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LinkLabel2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.SonaTile1)
        Me.Panel1.Controls.Add(Me.SonaButton1)
        Me.Panel1.Location = New System.Drawing.Point(844, 176)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(356, 249)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(228, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 55)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Welcome to Cms."
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.HtmlPanel1)
        Me.Panel2.Location = New System.Drawing.Point(844, 431)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(356, 213)
        Me.Panel2.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(97, 19)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(213, 26)
        Me.TextBox3.TabIndex = 0
        '
        'HtmlPanel1
        '
        Me.HtmlPanel1.AutoScroll = True
        Me.HtmlPanel1.AutoScrollMinSize = New System.Drawing.Size(330, 77)
        Me.HtmlPanel1.BackColor = System.Drawing.SystemColors.Window
        Me.HtmlPanel1.Controls.Add(Me.Panel3)
        Me.HtmlPanel1.Controls.Add(Me.LinkLabel3)
        Me.HtmlPanel1.Location = New System.Drawing.Point(15, 90)
        Me.HtmlPanel1.Name = "HtmlPanel1"
        Me.HtmlPanel1.Size = New System.Drawing.Size(330, 160)
        Me.HtmlPanel1.TabIndex = 3
        Me.HtmlPanel1.Text = "<p>We will send you with yours password by this email.<i>Please check out your Em" & _
    "ail</i> and then</p>"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.TextBox4)
        Me.Panel3.Controls.Add(Me.HtmlLabel1)
        Me.Panel3.Location = New System.Drawing.Point(-12, 58)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(353, 65)
        Me.Panel3.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(234, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 26)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Submit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(15, 27)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(213, 26)
        Me.TextBox4.TabIndex = 4
        '
        'HtmlLabel1
        '
        Me.HtmlLabel1.AutoScroll = True
        Me.HtmlLabel1.AutoScrollMinSize = New System.Drawing.Size(106, 23)
        Me.HtmlLabel1.AutoSize = False
        Me.HtmlLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.HtmlLabel1.Location = New System.Drawing.Point(15, 3)
        Me.HtmlLabel1.Name = "HtmlLabel1"
        Me.HtmlLabel1.Size = New System.Drawing.Size(324, 23)
        Me.HtmlLabel1.TabIndex = 5
        Me.HtmlLabel1.Text = "<span> Pase code bellow :</span>"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(279, 42)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(54, 13)
        Me.LinkLabel3.TabIndex = 0
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Click here"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email :"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(120, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 38)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.SonaButton2)
        Me.Panel4.Controls.Add(Me.TextBox6)
        Me.Panel4.Controls.Add(Me.TextBox5)
        Me.Panel4.Location = New System.Drawing.Point(2, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(354, 218)
        Me.Panel4.TabIndex = 4
        '
        'SonaButton2
        '
        Me.SonaButton2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.SonaButton2.DisplayFocus = True
        Me.SonaButton2.FontSize = SonaFramework.SonaButtonSize.Tall
        Me.SonaButton2.ForeColor = System.Drawing.Color.White
        Me.SonaButton2.Location = New System.Drawing.Point(50, 147)
        Me.SonaButton2.Name = "SonaButton2"
        Me.SonaButton2.Size = New System.Drawing.Size(257, 45)
        Me.SonaButton2.Style = SonaFramework.SonaColorStyle.Bisque
        Me.SonaButton2.TabIndex = 7
        Me.SonaButton2.Text = "Change"
        Me.SonaButton2.UseCustomBackColor = True
        Me.SonaButton2.UseCustomForeColor = True
        Me.SonaButton2.UseSelectable = True
        Me.SonaButton2.UseStyleColors = True
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.CausesValidation = False
        Me.TextBox6.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBox6.Location = New System.Drawing.Point(50, 89)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(257, 39)
        Me.TextBox6.TabIndex = 8
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.CausesValidation = False
        Me.TextBox5.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBox5.Location = New System.Drawing.Point(50, 32)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(257, 39)
        Me.TextBox5.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(316, 319)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(380, 263)
        Me.DataGridView1.TabIndex = 10
        '
        'Login
        '
        Me.ApplyImageInvert = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackImage = Global.CMS_Project.My.Resources.Resources._240FC90E00000578_2874678_image_a_44_1418659635115
        Me.BackMaxSize = 1288
        Me.BorderStyle = SonaFramework.Forms.SonaFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1286, 720)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SonaPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.Opacity = 0.97R
        Me.Resizable = False
        Me.ShadowType = SonaFramework.Forms.SonaFormShadowType.DropShadow
        Me.Style = SonaFramework.SonaColorStyle.Azure
        Me.TopMost = True
        Me.SonaPanel1.ResumeLayout(False)
        Me.SonaPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.HtmlPanel1.ResumeLayout(False)
        Me.HtmlPanel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SonaPanel1 As SonaFramework.Controls.SonaPanel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Private WithEvents SonaButton1 As SonaFramework.Controls.SonaButton
    Friend WithEvents SonaTile1 As SonaFramework.Controls.SonaTile
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents HtmlPanel1 As SonaFramework.Drawing.Html.HtmlPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents HtmlLabel1 As SonaFramework.Drawing.Html.HtmlLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Private WithEvents SonaButton2 As SonaFramework.Controls.SonaButton
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
