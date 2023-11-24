<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasicAPI
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTestConnection = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtUserName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtDatabase = New MetroFramework.Controls.MetroTextBox()
        Me.txtIPAddress = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.chkProcedures = New System.Windows.Forms.CheckedListBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnGenerateCode = New MetroFramework.Controls.MetroButton()
        Me.rdoPost = New MetroFramework.Controls.MetroRadioButton()
        Me.rdoGet = New MetroFramework.Controls.MetroRadioButton()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.txtResult = New MetroFramework.Controls.MetroTextBox()
        Me.txtResultMethod = New MetroFramework.Controls.MetroTextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblClear = New MetroFramework.Controls.MetroLink()
        Me.lblSelectedProcedures = New MetroFramework.Controls.MetroLabel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnTestConnection)
        Me.Panel1.Controls.Add(Me.MetroLabel4)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.MetroLabel3)
        Me.Panel1.Controls.Add(Me.txtUserName)
        Me.Panel1.Controls.Add(Me.MetroLabel2)
        Me.Panel1.Controls.Add(Me.txtDatabase)
        Me.Panel1.Controls.Add(Me.txtIPAddress)
        Me.Panel1.Controls.Add(Me.MetroLabel1)
        Me.Panel1.Controls.Add(Me.lblConnection)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(20, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(894, 64)
        Me.Panel1.TabIndex = 0
        '
        'btnTestConnection
        '
        Me.btnTestConnection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTestConnection.Location = New System.Drawing.Point(767, 20)
        Me.btnTestConnection.Name = "btnTestConnection"
        Me.btnTestConnection.Size = New System.Drawing.Size(111, 23)
        Me.btnTestConnection.TabIndex = 33
        Me.btnTestConnection.Text = "Test Connection"
        Me.btnTestConnection.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(463, 7)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel4.TabIndex = 32
        Me.MetroLabel4.Text = "Password"
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.CustomButton.Image = Nothing
        Me.txtPassword.CustomButton.Location = New System.Drawing.Point(108, 1)
        Me.txtPassword.CustomButton.Name = ""
        Me.txtPassword.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPassword.CustomButton.TabIndex = 1
        Me.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPassword.CustomButton.UseSelectable = True
        Me.txtPassword.CustomButton.Visible = False
        Me.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPassword.Lines = New String(-1) {}
        Me.txtPassword.Location = New System.Drawing.Point(463, 26)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.ShortcutsEnabled = True
        Me.txtPassword.Size = New System.Drawing.Size(130, 23)
        Me.txtPassword.TabIndex = 31
        Me.txtPassword.UseSelectable = True
        Me.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(313, 7)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel3.TabIndex = 30
        Me.MetroLabel3.Text = "User Name"
        '
        'txtUserName
        '
        '
        '
        '
        Me.txtUserName.CustomButton.Image = Nothing
        Me.txtUserName.CustomButton.Location = New System.Drawing.Point(108, 1)
        Me.txtUserName.CustomButton.Name = ""
        Me.txtUserName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUserName.CustomButton.TabIndex = 1
        Me.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUserName.CustomButton.UseSelectable = True
        Me.txtUserName.CustomButton.Visible = False
        Me.txtUserName.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtUserName.Lines = New String(-1) {}
        Me.txtUserName.Location = New System.Drawing.Point(313, 26)
        Me.txtUserName.MaxLength = 32767
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUserName.SelectedText = ""
        Me.txtUserName.SelectionLength = 0
        Me.txtUserName.SelectionStart = 0
        Me.txtUserName.ShortcutsEnabled = True
        Me.txtUserName.Size = New System.Drawing.Size(130, 23)
        Me.txtUserName.TabIndex = 29
        Me.txtUserName.UseSelectable = True
        Me.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUserName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(165, 7)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel2.TabIndex = 28
        Me.MetroLabel2.Text = "Database"
        '
        'txtDatabase
        '
        Me.txtDatabase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtDatabase.CustomButton.Image = Nothing
        Me.txtDatabase.CustomButton.Location = New System.Drawing.Point(108, 1)
        Me.txtDatabase.CustomButton.Name = ""
        Me.txtDatabase.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDatabase.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDatabase.CustomButton.TabIndex = 1
        Me.txtDatabase.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDatabase.CustomButton.UseSelectable = True
        Me.txtDatabase.CustomButton.Visible = False
        Me.txtDatabase.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtDatabase.Lines = New String(-1) {}
        Me.txtDatabase.Location = New System.Drawing.Point(165, 26)
        Me.txtDatabase.MaxLength = 32767
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDatabase.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDatabase.SelectedText = ""
        Me.txtDatabase.SelectionLength = 0
        Me.txtDatabase.SelectionStart = 0
        Me.txtDatabase.ShortcutsEnabled = True
        Me.txtDatabase.Size = New System.Drawing.Size(130, 23)
        Me.txtDatabase.TabIndex = 27
        Me.txtDatabase.UseSelectable = True
        Me.txtDatabase.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDatabase.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtIPAddress
        '
        '
        '
        '
        Me.txtIPAddress.CustomButton.Image = Nothing
        Me.txtIPAddress.CustomButton.Location = New System.Drawing.Point(112, 1)
        Me.txtIPAddress.CustomButton.Name = ""
        Me.txtIPAddress.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtIPAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtIPAddress.CustomButton.TabIndex = 1
        Me.txtIPAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtIPAddress.CustomButton.UseSelectable = True
        Me.txtIPAddress.CustomButton.Visible = False
        Me.txtIPAddress.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtIPAddress.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtIPAddress.Lines = New String(-1) {}
        Me.txtIPAddress.Location = New System.Drawing.Point(14, 26)
        Me.txtIPAddress.MaxLength = 32767
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIPAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIPAddress.SelectedText = ""
        Me.txtIPAddress.SelectionLength = 0
        Me.txtIPAddress.SelectionStart = 0
        Me.txtIPAddress.ShortcutsEnabled = True
        Me.txtIPAddress.Size = New System.Drawing.Size(134, 23)
        Me.txtIPAddress.TabIndex = 26
        Me.txtIPAddress.UseSelectable = True
        Me.txtIPAddress.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtIPAddress.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(14, 7)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel1.TabIndex = 25
        Me.MetroLabel1.Text = "IP Address"
        '
        'lblConnection
        '
        Me.lblConnection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblConnection.AutoSize = True
        Me.lblConnection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnection.Location = New System.Drawing.Point(768, 48)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(111, 13)
        Me.lblConnection.TabIndex = 24
        Me.lblConnection.Text = "Connection Status"
        Me.lblConnection.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(20, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(894, 405)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.SplitContainer1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(894, 405)
        Me.Panel4.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkProcedures)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel5)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(894, 405)
        Me.SplitContainer1.SplitterDistance = 226
        Me.SplitContainer1.TabIndex = 0
        '
        'chkProcedures
        '
        Me.chkProcedures.CheckOnClick = True
        Me.chkProcedures.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkProcedures.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.chkProcedures.FormattingEnabled = True
        Me.chkProcedures.Location = New System.Drawing.Point(0, 0)
        Me.chkProcedures.Name = "chkProcedures"
        Me.chkProcedures.Size = New System.Drawing.Size(226, 305)
        Me.chkProcedures.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblClear)
        Me.Panel5.Controls.Add(Me.lblSelectedProcedures)
        Me.Panel5.Controls.Add(Me.btnGenerateCode)
        Me.Panel5.Controls.Add(Me.rdoPost)
        Me.Panel5.Controls.Add(Me.rdoGet)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 305)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(226, 100)
        Me.Panel5.TabIndex = 2
        '
        'btnGenerateCode
        '
        Me.btnGenerateCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerateCode.Location = New System.Drawing.Point(14, 57)
        Me.btnGenerateCode.Name = "btnGenerateCode"
        Me.btnGenerateCode.Size = New System.Drawing.Size(195, 23)
        Me.btnGenerateCode.TabIndex = 2
        Me.btnGenerateCode.Text = "Generate Code"
        Me.btnGenerateCode.UseSelectable = True
        '
        'rdoPost
        '
        Me.rdoPost.AutoSize = True
        Me.rdoPost.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.rdoPost.Location = New System.Drawing.Point(97, 26)
        Me.rdoPost.Name = "rdoPost"
        Me.rdoPost.Size = New System.Drawing.Size(51, 19)
        Me.rdoPost.TabIndex = 1
        Me.rdoPost.Text = "Post"
        Me.rdoPost.UseSelectable = True
        '
        'rdoGet
        '
        Me.rdoGet.AutoSize = True
        Me.rdoGet.Checked = True
        Me.rdoGet.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.rdoGet.Location = New System.Drawing.Point(14, 26)
        Me.rdoGet.Name = "rdoGet"
        Me.rdoGet.Size = New System.Drawing.Size(47, 19)
        Me.rdoGet.TabIndex = 0
        Me.rdoGet.TabStop = True
        Me.rdoGet.Text = "Get"
        Me.rdoGet.UseSelectable = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtResult)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtResultMethod)
        Me.SplitContainer2.Size = New System.Drawing.Size(664, 405)
        Me.SplitContainer2.SplitterDistance = 313
        Me.SplitContainer2.TabIndex = 0
        '
        'txtResult
        '
        '
        '
        '
        Me.txtResult.CustomButton.Image = Nothing
        Me.txtResult.CustomButton.Location = New System.Drawing.Point(-91, 1)
        Me.txtResult.CustomButton.Name = ""
        Me.txtResult.CustomButton.Size = New System.Drawing.Size(403, 403)
        Me.txtResult.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtResult.CustomButton.TabIndex = 1
        Me.txtResult.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtResult.CustomButton.UseSelectable = True
        Me.txtResult.CustomButton.Visible = False
        Me.txtResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtResult.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtResult.Lines = New String(-1) {}
        Me.txtResult.Location = New System.Drawing.Point(0, 0)
        Me.txtResult.MaxLength = 32767
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResult.SelectedText = ""
        Me.txtResult.SelectionLength = 0
        Me.txtResult.SelectionStart = 0
        Me.txtResult.ShortcutsEnabled = True
        Me.txtResult.Size = New System.Drawing.Size(313, 405)
        Me.txtResult.TabIndex = 0
        Me.txtResult.UseSelectable = True
        Me.txtResult.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtResult.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtResultMethod
        '
        '
        '
        '
        Me.txtResultMethod.CustomButton.Image = Nothing
        Me.txtResultMethod.CustomButton.Location = New System.Drawing.Point(-57, 1)
        Me.txtResultMethod.CustomButton.Name = ""
        Me.txtResultMethod.CustomButton.Size = New System.Drawing.Size(403, 403)
        Me.txtResultMethod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtResultMethod.CustomButton.TabIndex = 1
        Me.txtResultMethod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtResultMethod.CustomButton.UseSelectable = True
        Me.txtResultMethod.CustomButton.Visible = False
        Me.txtResultMethod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtResultMethod.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtResultMethod.Lines = New String(-1) {}
        Me.txtResultMethod.Location = New System.Drawing.Point(0, 0)
        Me.txtResultMethod.MaxLength = 32767
        Me.txtResultMethod.Multiline = True
        Me.txtResultMethod.Name = "txtResultMethod"
        Me.txtResultMethod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResultMethod.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResultMethod.SelectedText = ""
        Me.txtResultMethod.SelectionLength = 0
        Me.txtResultMethod.SelectionStart = 0
        Me.txtResultMethod.ShortcutsEnabled = True
        Me.txtResultMethod.Size = New System.Drawing.Size(347, 405)
        Me.txtResultMethod.TabIndex = 1
        Me.txtResultMethod.UseSelectable = True
        Me.txtResultMethod.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtResultMethod.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblClear
        '
        Me.lblClear.Location = New System.Drawing.Point(148, 4)
        Me.lblClear.Name = "lblClear"
        Me.lblClear.Size = New System.Drawing.Size(75, 23)
        Me.lblClear.TabIndex = 6
        Me.lblClear.Text = "Clear"
        Me.lblClear.UseSelectable = True
        '
        'lblSelectedProcedures
        '
        Me.lblSelectedProcedures.AutoSize = True
        Me.lblSelectedProcedures.Location = New System.Drawing.Point(3, 4)
        Me.lblSelectedProcedures.Name = "lblSelectedProcedures"
        Me.lblSelectedProcedures.Size = New System.Drawing.Size(150, 19)
        Me.lblSelectedProcedures.TabIndex = 5
        Me.lblSelectedProcedures.Text = "No Procedures Selected"
        '
        'BasicAPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 549)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BasicAPI"
        Me.Text = "BasicAPI"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIPAddress As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblConnection As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtUserName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDatabase As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents chkProcedures As System.Windows.Forms.CheckedListBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtResult As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtResultMethod As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnGenerateCode As MetroFramework.Controls.MetroButton
    Friend WithEvents rdoPost As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rdoGet As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents btnTestConnection As MetroFramework.Controls.MetroButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblClear As MetroFramework.Controls.MetroLink
    Friend WithEvents lblSelectedProcedures As MetroFramework.Controls.MetroLabel
End Class
