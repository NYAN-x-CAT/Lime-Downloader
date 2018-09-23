<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.HuraForm1 = New Builder.HuraForm()
        Me.HuraControlBox2 = New Builder.HuraControlBox()
        Me.HuraTabControl1 = New Builder.HuraTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtURL = New System.Windows.Forms.RichTextBox()
        Me.Layer1 = New Builder.HuraTextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.HuraGroupBox3 = New Builder.HuraGroupBox()
        Me.chkInstall = New Builder.HuraCheckBox()
        Me.txtAssembly = New Builder.HuraTextBox()
        Me.btnAssembly = New Builder.HuraButton()
        Me.txtIcon = New Builder.HuraTextBox()
        Me.btnIcon = New Builder.HuraButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.HuraGroupBox2 = New Builder.HuraGroupBox()
        Me.txtLog = New System.Windows.Forms.RichTextBox()
        Me.chkObfuscation = New Builder.HuraCheckBox()
        Me.btnBuild = New Builder.HuraButton()
        Me.txtLogs = New Builder.HuraTextBox()
        Me.HuraForm1.SuspendLayout()
        Me.HuraTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.HuraGroupBox3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.HuraGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HuraForm1.ColorScheme = Builder.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.HuraControlBox2)
        Me.HuraForm1.Controls.Add(Me.HuraTabControl1)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(782, 389)
        Me.HuraForm1.TabIndex = 0
        Me.HuraForm1.Text = "Lime Downloader v3"
        '
        'HuraControlBox2
        '
        Me.HuraControlBox2.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.HuraControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HuraControlBox2.BackColor = System.Drawing.Color.Black
        Me.HuraControlBox2.ColorScheme = Builder.HuraControlBox.ColorSchemes.Dark
        Me.HuraControlBox2.ForeColor = System.Drawing.Color.Black
        Me.HuraControlBox2.Location = New System.Drawing.Point(623, 12)
        Me.HuraControlBox2.Name = "HuraControlBox2"
        Me.HuraControlBox2.Size = New System.Drawing.Size(100, 30)
        Me.HuraControlBox2.TabIndex = 2
        Me.HuraControlBox2.Text = "HuraControlBox2"
        '
        'HuraTabControl1
        '
        Me.HuraTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.HuraTabControl1.Controls.Add(Me.TabPage1)
        Me.HuraTabControl1.Controls.Add(Me.TabPage4)
        Me.HuraTabControl1.Controls.Add(Me.TabPage3)
        Me.HuraTabControl1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraTabControl1.ItemSize = New System.Drawing.Size(0, 30)
        Me.HuraTabControl1.Location = New System.Drawing.Point(12, 68)
        Me.HuraTabControl1.Name = "HuraTabControl1"
        Me.HuraTabControl1.SelectedIndex = 0
        Me.HuraTabControl1.Size = New System.Drawing.Size(758, 309)
        Me.HuraTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.txtURL)
        Me.TabPage1.Controls.Add(Me.Layer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(750, 271)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Select URL"
        '
        'txtURL
        '
        Me.txtURL.BackColor = System.Drawing.Color.Black
        Me.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtURL.DetectUrls = False
        Me.txtURL.ForeColor = System.Drawing.Color.Gray
        Me.txtURL.Location = New System.Drawing.Point(18, 17)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(717, 197)
        Me.txtURL.TabIndex = 1
        Me.txtURL.Text = "https://uploader.net/rat.exe" & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.website1.com/payload.exe" & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.site." &
    "com/folder/payload.exe"
        Me.txtURL.WordWrap = False
        '
        'Layer1
        '
        Me.Layer1.BackColor = System.Drawing.Color.Transparent
        Me.Layer1.BackgroundColour = System.Drawing.Color.Black
        Me.Layer1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Layer1.Location = New System.Drawing.Point(5, 5)
        Me.Layer1.MaxLength = 32767
        Me.Layer1.Multiline = True
        Me.Layer1.Name = "Layer1"
        Me.Layer1.ReadOnly = False
        Me.Layer1.Size = New System.Drawing.Size(741, 225)
        Me.Layer1.Style = Builder.HuraTextBox.Styles.Normal
        Me.Layer1.TabIndex = 0
        Me.Layer1.Text = " "
        Me.Layer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Layer1.TextColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Layer1.UseSystemPasswordChar = False
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.HuraGroupBox3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 34)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(750, 271)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Settings"
        '
        'HuraGroupBox3
        '
        Me.HuraGroupBox3.BackColor = System.Drawing.Color.Black
        Me.HuraGroupBox3.Controls.Add(Me.chkInstall)
        Me.HuraGroupBox3.Controls.Add(Me.txtAssembly)
        Me.HuraGroupBox3.Controls.Add(Me.btnAssembly)
        Me.HuraGroupBox3.Controls.Add(Me.txtIcon)
        Me.HuraGroupBox3.Controls.Add(Me.btnIcon)
        Me.HuraGroupBox3.Location = New System.Drawing.Point(5, 5)
        Me.HuraGroupBox3.Name = "HuraGroupBox3"
        Me.HuraGroupBox3.Size = New System.Drawing.Size(741, 225)
        Me.HuraGroupBox3.TabIndex = 1
        Me.HuraGroupBox3.Text = "HuraGroupBox3"
        '
        'chkInstall
        '
        Me.chkInstall.BaseColour = System.Drawing.Color.Black
        Me.chkInstall.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.chkInstall.Checked = False
        Me.chkInstall.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.chkInstall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkInstall.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.chkInstall.Location = New System.Drawing.Point(12, 26)
        Me.chkInstall.Name = "chkInstall"
        Me.chkInstall.Size = New System.Drawing.Size(180, 22)
        Me.chkInstall.TabIndex = 6
        Me.chkInstall.Text = "Hidden Startup"
        '
        'txtAssembly
        '
        Me.txtAssembly.BackColor = System.Drawing.Color.Transparent
        Me.txtAssembly.BackgroundColour = System.Drawing.Color.Black
        Me.txtAssembly.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.txtAssembly.Location = New System.Drawing.Point(224, 145)
        Me.txtAssembly.MaxLength = 32767
        Me.txtAssembly.Multiline = False
        Me.txtAssembly.Name = "txtAssembly"
        Me.txtAssembly.ReadOnly = False
        Me.txtAssembly.Size = New System.Drawing.Size(500, 38)
        Me.txtAssembly.Style = Builder.HuraTextBox.Styles.Normal
        Me.txtAssembly.TabIndex = 5
        Me.txtAssembly.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAssembly.TextColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.txtAssembly.UseSystemPasswordChar = False
        '
        'btnAssembly
        '
        Me.btnAssembly.BackColor = System.Drawing.Color.Transparent
        Me.btnAssembly.BaseColour = System.Drawing.Color.Black
        Me.btnAssembly.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnAssembly.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnAssembly.HoverColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAssembly.Location = New System.Drawing.Point(12, 145)
        Me.btnAssembly.Name = "btnAssembly"
        Me.btnAssembly.PressedColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnAssembly.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAssembly.Size = New System.Drawing.Size(194, 38)
        Me.btnAssembly.TabIndex = 4
        Me.btnAssembly.Text = "Clone Assembly"
        '
        'txtIcon
        '
        Me.txtIcon.BackColor = System.Drawing.Color.Transparent
        Me.txtIcon.BackgroundColour = System.Drawing.Color.Black
        Me.txtIcon.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.txtIcon.Location = New System.Drawing.Point(224, 80)
        Me.txtIcon.MaxLength = 32767
        Me.txtIcon.Multiline = False
        Me.txtIcon.Name = "txtIcon"
        Me.txtIcon.ReadOnly = False
        Me.txtIcon.Size = New System.Drawing.Size(500, 38)
        Me.txtIcon.Style = Builder.HuraTextBox.Styles.Normal
        Me.txtIcon.TabIndex = 3
        Me.txtIcon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIcon.TextColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.txtIcon.UseSystemPasswordChar = False
        '
        'btnIcon
        '
        Me.btnIcon.BackColor = System.Drawing.Color.Transparent
        Me.btnIcon.BaseColour = System.Drawing.Color.Black
        Me.btnIcon.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnIcon.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnIcon.HoverColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnIcon.Location = New System.Drawing.Point(12, 80)
        Me.btnIcon.Name = "btnIcon"
        Me.btnIcon.PressedColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnIcon.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnIcon.Size = New System.Drawing.Size(194, 38)
        Me.btnIcon.TabIndex = 1
        Me.btnIcon.Text = "Clone Icon"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.HuraGroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(750, 271)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Build"
        '
        'HuraGroupBox2
        '
        Me.HuraGroupBox2.BackColor = System.Drawing.Color.Black
        Me.HuraGroupBox2.Controls.Add(Me.txtLog)
        Me.HuraGroupBox2.Controls.Add(Me.chkObfuscation)
        Me.HuraGroupBox2.Controls.Add(Me.btnBuild)
        Me.HuraGroupBox2.Controls.Add(Me.txtLogs)
        Me.HuraGroupBox2.Location = New System.Drawing.Point(5, 5)
        Me.HuraGroupBox2.Name = "HuraGroupBox2"
        Me.HuraGroupBox2.Size = New System.Drawing.Size(741, 225)
        Me.HuraGroupBox2.TabIndex = 0
        Me.HuraGroupBox2.Text = "HuraGroupBox2"
        '
        'txtLog
        '
        Me.txtLog.BackColor = System.Drawing.Color.Black
        Me.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.txtLog.Location = New System.Drawing.Point(5, 76)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(723, 146)
        Me.txtLog.TabIndex = 4
        Me.txtLog.Text = "..."
        '
        'chkObfuscation
        '
        Me.chkObfuscation.BaseColour = System.Drawing.Color.Black
        Me.chkObfuscation.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.chkObfuscation.Checked = False
        Me.chkObfuscation.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.chkObfuscation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkObfuscation.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.chkObfuscation.Location = New System.Drawing.Point(547, 27)
        Me.chkObfuscation.Name = "chkObfuscation"
        Me.chkObfuscation.Size = New System.Drawing.Size(181, 22)
        Me.chkObfuscation.TabIndex = 3
        Me.chkObfuscation.Text = "Obfuscation"
        '
        'btnBuild
        '
        Me.btnBuild.BackColor = System.Drawing.Color.Transparent
        Me.btnBuild.BaseColour = System.Drawing.Color.Black
        Me.btnBuild.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnBuild.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnBuild.HoverColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuild.Location = New System.Drawing.Point(18, 15)
        Me.btnBuild.Name = "btnBuild"
        Me.btnBuild.PressedColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnBuild.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBuild.Size = New System.Drawing.Size(187, 34)
        Me.btnBuild.TabIndex = 2
        Me.btnBuild.Text = "Build"
        '
        'txtLogs
        '
        Me.txtLogs.BackColor = System.Drawing.Color.Transparent
        Me.txtLogs.BackgroundColour = System.Drawing.Color.Black
        Me.txtLogs.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.txtLogs.Location = New System.Drawing.Point(0, 72)
        Me.txtLogs.MaxLength = 32767
        Me.txtLogs.Multiline = True
        Me.txtLogs.Name = "txtLogs"
        Me.txtLogs.ReadOnly = True
        Me.txtLogs.Size = New System.Drawing.Size(741, 153)
        Me.txtLogs.Style = Builder.HuraTextBox.Styles.Normal
        Me.txtLogs.TabIndex = 0
        Me.txtLogs.Text = "..."
        Me.txtLogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLogs.TextColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.txtLogs.UseSystemPasswordChar = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 389)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Opacity = 0.95R
        Me.Text = "Form1"
        Me.HuraForm1.ResumeLayout(False)
        Me.HuraTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.HuraGroupBox3.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.HuraGroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HuraForm1 As HuraForm
    Friend WithEvents HuraTabControl1 As HuraTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents HuraGroupBox3 As HuraGroupBox
    Friend WithEvents btnIcon As HuraButton
    Friend WithEvents txtAssembly As HuraTextBox
    Friend WithEvents btnAssembly As HuraButton
    Friend WithEvents txtIcon As HuraTextBox
    Friend WithEvents chkInstall As HuraCheckBox
    Friend WithEvents HuraGroupBox2 As HuraGroupBox
    Friend WithEvents btnBuild As HuraButton
    Friend WithEvents txtLogs As HuraTextBox
    Friend WithEvents Layer1 As HuraTextBox
    Friend WithEvents chkObfuscation As HuraCheckBox
    Friend WithEvents HuraControlBox2 As HuraControlBox
    Friend WithEvents txtLog As RichTextBox
    Friend WithEvents txtURL As RichTextBox
End Class
