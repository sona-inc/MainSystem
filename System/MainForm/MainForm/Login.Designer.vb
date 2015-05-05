<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SonaTextBox1 = New SonaFramework.Controls.SonaTextBox()
        Me.SonaTextBox2 = New SonaFramework.Controls.SonaTextBox()
        Me.SonaButton1 = New SonaFramework.Controls.SonaButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(823, 479)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(713, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 41)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SonaTextBox1
        '
        Me.SonaTextBox1.BackColor = System.Drawing.Color.White
        Me.SonaTextBox1.FontSize = SonaFramework.SonaTextBoxSize.Tall
        Me.SonaTextBox1.Icon = Global.MainForm.My.Resources.Resources.free_60_icons_25
        Me.SonaTextBox1.Lines = New String(-1) {}
        Me.SonaTextBox1.Location = New System.Drawing.Point(281, 183)
        Me.SonaTextBox1.MaxLength = 32767
        Me.SonaTextBox1.Name = "SonaTextBox1"
        Me.SonaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SonaTextBox1.PromptText = "Username"
        Me.SonaTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SonaTextBox1.SelectedText = ""
        Me.SonaTextBox1.Size = New System.Drawing.Size(253, 38)
        Me.SonaTextBox1.TabIndex = 2
        Me.SonaTextBox1.UseSelectable = True
        '
        'SonaTextBox2
        '
        Me.SonaTextBox2.BackColor = System.Drawing.Color.White
        Me.SonaTextBox2.FontSize = SonaFramework.SonaTextBoxSize.Tall
        Me.SonaTextBox2.Icon = Global.MainForm.My.Resources.Resources.free_60_icons_25
        Me.SonaTextBox2.Lines = New String(-1) {}
        Me.SonaTextBox2.Location = New System.Drawing.Point(281, 227)
        Me.SonaTextBox2.MaxLength = 32767
        Me.SonaTextBox2.Name = "SonaTextBox2"
        Me.SonaTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(80)
        Me.SonaTextBox2.PromptText = "Password"
        Me.SonaTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SonaTextBox2.SelectedText = ""
        Me.SonaTextBox2.Size = New System.Drawing.Size(253, 38)
        Me.SonaTextBox2.TabIndex = 3
        Me.SonaTextBox2.UseSelectable = True
        '
        'SonaButton1
        '
        Me.SonaButton1.BackColor = System.Drawing.Color.Blue
        Me.SonaButton1.Location = New System.Drawing.Point(294, 285)
        Me.SonaButton1.Name = "SonaButton1"
        Me.SonaButton1.Size = New System.Drawing.Size(228, 52)
        Me.SonaButton1.TabIndex = 4
        Me.SonaButton1.Text = "Login"
        Me.SonaButton1.UseSelectable = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(823, 487)
        Me.Controls.Add(Me.SonaButton1)
        Me.Controls.Add(Me.SonaTextBox2)
        Me.Controls.Add(Me.SonaTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SonaTextBox1 As SonaFramework.Controls.SonaTextBox
    Friend WithEvents SonaTextBox2 As SonaFramework.Controls.SonaTextBox
    Friend WithEvents SonaButton1 As SonaFramework.Controls.SonaButton

End Class
