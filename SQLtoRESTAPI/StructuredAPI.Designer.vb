<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StructuredAPI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StructuredAPI))
        Me.btnTestConnection = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtUserName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtDatabase = New MetroFramework.Controls.MetroTextBox()
        Me.txtIPAddress = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.txtStructureAndValidator = New MetroFramework.Controls.MetroTextBox()
        Me.txtBusinessLayer = New MetroFramework.Controls.MetroTextBox()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.txtDataLayer = New MetroFramework.Controls.MetroTextBox()
        Me.txtPresentationLayer = New MetroFramework.Controls.MetroTextBox()
        Me.btnGenerateCode = New MetroFramework.Controls.MetroButton()
        Me.rdoPost = New MetroFramework.Controls.MetroRadioButton()
        Me.rdoGet = New MetroFramework.Controls.MetroRadioButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.lblClear = New MetroFramework.Controls.MetroLink()
        Me.lblSelectedProcedures = New MetroFramework.Controls.MetroLabel()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chkProcedures = New System.Windows.Forms.CheckedListBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTestConnection
        '
        Me.btnTestConnection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTestConnection.Location = New System.Drawing.Point(1006, 20)
        Me.btnTestConnection.Name = "btnTestConnection"
        Me.btnTestConnection.Size = New System.Drawing.Size(111, 23)
        Me.btnTestConnection.TabIndex = 4
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
        Me.txtPassword.TabIndex = 3
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
        Me.txtUserName.TabIndex = 2
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
        Me.txtDatabase.TabIndex = 1
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
        Me.txtIPAddress.TabIndex = 0
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
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer2.Size = New System.Drawing.Size(886, 427)
        Me.SplitContainer2.SplitterDistance = 417
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtStructureAndValidator)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.txtBusinessLayer)
        Me.SplitContainer3.Size = New System.Drawing.Size(417, 427)
        Me.SplitContainer3.SplitterDistance = 220
        Me.SplitContainer3.TabIndex = 0
        '
        'txtStructureAndValidator
        '
        '
        '
        '
        Me.txtStructureAndValidator.CustomButton.Image = Nothing
        Me.txtStructureAndValidator.CustomButton.Location = New System.Drawing.Point(199, 2)
        Me.txtStructureAndValidator.CustomButton.Name = ""
        Me.txtStructureAndValidator.CustomButton.Size = New System.Drawing.Size(215, 215)
        Me.txtStructureAndValidator.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStructureAndValidator.CustomButton.TabIndex = 1
        Me.txtStructureAndValidator.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStructureAndValidator.CustomButton.UseSelectable = True
        Me.txtStructureAndValidator.CustomButton.Visible = False
        Me.txtStructureAndValidator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtStructureAndValidator.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtStructureAndValidator.Lines = New String(-1) {}
        Me.txtStructureAndValidator.Location = New System.Drawing.Point(0, 0)
        Me.txtStructureAndValidator.MaxLength = 32767
        Me.txtStructureAndValidator.Multiline = True
        Me.txtStructureAndValidator.Name = "txtStructureAndValidator"
        Me.txtStructureAndValidator.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStructureAndValidator.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStructureAndValidator.SelectedText = ""
        Me.txtStructureAndValidator.SelectionLength = 0
        Me.txtStructureAndValidator.SelectionStart = 0
        Me.txtStructureAndValidator.ShortcutsEnabled = True
        Me.txtStructureAndValidator.Size = New System.Drawing.Size(417, 220)
        Me.txtStructureAndValidator.TabIndex = 1
        Me.txtStructureAndValidator.UseSelectable = True
        Me.txtStructureAndValidator.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStructureAndValidator.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBusinessLayer
        '
        '
        '
        '
        Me.txtBusinessLayer.CustomButton.Image = Nothing
        Me.txtBusinessLayer.CustomButton.Location = New System.Drawing.Point(215, 1)
        Me.txtBusinessLayer.CustomButton.Name = ""
        Me.txtBusinessLayer.CustomButton.Size = New System.Drawing.Size(201, 201)
        Me.txtBusinessLayer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBusinessLayer.CustomButton.TabIndex = 1
        Me.txtBusinessLayer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBusinessLayer.CustomButton.UseSelectable = True
        Me.txtBusinessLayer.CustomButton.Visible = False
        Me.txtBusinessLayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBusinessLayer.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtBusinessLayer.Lines = New String(-1) {}
        Me.txtBusinessLayer.Location = New System.Drawing.Point(0, 0)
        Me.txtBusinessLayer.MaxLength = 32767
        Me.txtBusinessLayer.Multiline = True
        Me.txtBusinessLayer.Name = "txtBusinessLayer"
        Me.txtBusinessLayer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusinessLayer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBusinessLayer.SelectedText = ""
        Me.txtBusinessLayer.SelectionLength = 0
        Me.txtBusinessLayer.SelectionStart = 0
        Me.txtBusinessLayer.ShortcutsEnabled = True
        Me.txtBusinessLayer.Size = New System.Drawing.Size(417, 203)
        Me.txtBusinessLayer.TabIndex = 1
        Me.txtBusinessLayer.UseSelectable = True
        Me.txtBusinessLayer.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBusinessLayer.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.txtDataLayer)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.txtPresentationLayer)
        Me.SplitContainer4.Size = New System.Drawing.Size(465, 427)
        Me.SplitContainer4.SplitterDistance = 219
        Me.SplitContainer4.TabIndex = 0
        '
        'txtDataLayer
        '
        '
        '
        '
        Me.txtDataLayer.CustomButton.Image = Nothing
        Me.txtDataLayer.CustomButton.Location = New System.Drawing.Point(247, 1)
        Me.txtDataLayer.CustomButton.Name = ""
        Me.txtDataLayer.CustomButton.Size = New System.Drawing.Size(217, 217)
        Me.txtDataLayer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDataLayer.CustomButton.TabIndex = 1
        Me.txtDataLayer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDataLayer.CustomButton.UseSelectable = True
        Me.txtDataLayer.CustomButton.Visible = False
        Me.txtDataLayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDataLayer.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtDataLayer.Lines = New String(-1) {}
        Me.txtDataLayer.Location = New System.Drawing.Point(0, 0)
        Me.txtDataLayer.MaxLength = 32767
        Me.txtDataLayer.Multiline = True
        Me.txtDataLayer.Name = "txtDataLayer"
        Me.txtDataLayer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDataLayer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDataLayer.SelectedText = ""
        Me.txtDataLayer.SelectionLength = 0
        Me.txtDataLayer.SelectionStart = 0
        Me.txtDataLayer.ShortcutsEnabled = True
        Me.txtDataLayer.Size = New System.Drawing.Size(465, 219)
        Me.txtDataLayer.TabIndex = 1
        Me.txtDataLayer.UseSelectable = True
        Me.txtDataLayer.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDataLayer.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPresentationLayer
        '
        '
        '
        '
        Me.txtPresentationLayer.CustomButton.Image = Nothing
        Me.txtPresentationLayer.CustomButton.Location = New System.Drawing.Point(263, 2)
        Me.txtPresentationLayer.CustomButton.Name = ""
        Me.txtPresentationLayer.CustomButton.Size = New System.Drawing.Size(199, 199)
        Me.txtPresentationLayer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPresentationLayer.CustomButton.TabIndex = 1
        Me.txtPresentationLayer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPresentationLayer.CustomButton.UseSelectable = True
        Me.txtPresentationLayer.CustomButton.Visible = False
        Me.txtPresentationLayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPresentationLayer.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPresentationLayer.Lines = New String(-1) {}
        Me.txtPresentationLayer.Location = New System.Drawing.Point(0, 0)
        Me.txtPresentationLayer.MaxLength = 32767
        Me.txtPresentationLayer.Multiline = True
        Me.txtPresentationLayer.Name = "txtPresentationLayer"
        Me.txtPresentationLayer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPresentationLayer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPresentationLayer.SelectedText = ""
        Me.txtPresentationLayer.SelectionLength = 0
        Me.txtPresentationLayer.SelectionStart = 0
        Me.txtPresentationLayer.ShortcutsEnabled = True
        Me.txtPresentationLayer.Size = New System.Drawing.Size(465, 204)
        Me.txtPresentationLayer.TabIndex = 1
        Me.txtPresentationLayer.UseSelectable = True
        Me.txtPresentationLayer.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPresentationLayer.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnGenerateCode
        '
        Me.btnGenerateCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerateCode.Location = New System.Drawing.Point(14, 92)
        Me.btnGenerateCode.Name = "btnGenerateCode"
        Me.btnGenerateCode.Size = New System.Drawing.Size(214, 23)
        Me.btnGenerateCode.TabIndex = 2
        Me.btnGenerateCode.Text = "Generate Code"
        Me.btnGenerateCode.UseSelectable = True
        '
        'rdoPost
        '
        Me.rdoPost.AutoSize = True
        Me.rdoPost.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.rdoPost.Location = New System.Drawing.Point(97, 64)
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
        Me.rdoGet.Location = New System.Drawing.Point(14, 64)
        Me.rdoGet.Name = "rdoGet"
        Me.rdoGet.Size = New System.Drawing.Size(47, 19)
        Me.rdoGet.TabIndex = 0
        Me.rdoGet.TabStop = True
        Me.rdoGet.Text = "Get"
        Me.rdoGet.UseSelectable = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtSearch)
        Me.Panel5.Controls.Add(Me.lblClear)
        Me.Panel5.Controls.Add(Me.lblSelectedProcedures)
        Me.Panel5.Controls.Add(Me.btnGenerateCode)
        Me.Panel5.Controls.Add(Me.rdoPost)
        Me.Panel5.Controls.Add(Me.rdoGet)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 292)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(243, 135)
        Me.Panel5.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtSearch.CustomButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSearch.CustomButton.Image = Nothing
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(192, 1)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Text = "ok"
        Me.txtSearch.CustomButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(14, 6)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PromptText = "Search Here"
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.ShowButton = True
        Me.txtSearch.Size = New System.Drawing.Size(214, 23)
        Me.txtSearch.TabIndex = 5
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMark = "Search Here"
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblClear
        '
        Me.lblClear.Location = New System.Drawing.Point(165, 40)
        Me.lblClear.Name = "lblClear"
        Me.lblClear.Size = New System.Drawing.Size(75, 23)
        Me.lblClear.TabIndex = 4
        Me.lblClear.Text = "Clear"
        Me.lblClear.UseSelectable = True
        '
        'lblSelectedProcedures
        '
        Me.lblSelectedProcedures.AutoSize = True
        Me.lblSelectedProcedures.Location = New System.Drawing.Point(14, 40)
        Me.lblSelectedProcedures.Name = "lblSelectedProcedures"
        Me.lblSelectedProcedures.Size = New System.Drawing.Size(150, 19)
        Me.lblSelectedProcedures.TabIndex = 3
        Me.lblSelectedProcedures.Text = "No Procedures Selected"
        '
        'lblConnection
        '
        Me.lblConnection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblConnection.AutoSize = True
        Me.lblConnection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnection.Location = New System.Drawing.Point(1007, 48)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(111, 13)
        Me.lblConnection.TabIndex = 24
        Me.lblConnection.Text = "Connection Status"
        Me.lblConnection.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel5)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1133, 427)
        Me.SplitContainer1.SplitterDistance = 243
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.chkProcedures)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(243, 292)
        Me.Panel3.TabIndex = 4
        '
        'chkProcedures
        '
        Me.chkProcedures.CheckOnClick = True
        Me.chkProcedures.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkProcedures.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.chkProcedures.FormattingEnabled = True
        Me.chkProcedures.Location = New System.Drawing.Point(0, 0)
        Me.chkProcedures.Name = "chkProcedures"
        Me.chkProcedures.Size = New System.Drawing.Size(243, 292)
        Me.chkProcedures.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.SplitContainer1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1133, 427)
        Me.Panel4.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(20, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1133, 427)
        Me.Panel2.TabIndex = 3
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
        Me.Panel1.Size = New System.Drawing.Size(1133, 64)
        Me.Panel1.TabIndex = 2
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'StructuredAPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 571)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StructuredAPI"
        Me.Text = "Structured API"
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTestConnection As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtUserName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDatabase As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtIPAddress As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnGenerateCode As MetroFramework.Controls.MetroButton
    Friend WithEvents rdoPost As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rdoGet As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblConnection As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents chkProcedures As System.Windows.Forms.CheckedListBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtStructureAndValidator As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBusinessLayer As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDataLayer As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPresentationLayer As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblSelectedProcedures As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblClear As MetroFramework.Controls.MetroLink
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
End Class
