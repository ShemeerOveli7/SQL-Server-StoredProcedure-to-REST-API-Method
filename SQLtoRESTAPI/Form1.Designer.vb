<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkProcedures = New System.Windows.Forms.CheckedListBox()
        Me.btnTestConnection = New System.Windows.Forms.Button()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.rdoGET = New System.Windows.Forms.RadioButton()
        Me.rdoPOST = New System.Windows.Forms.RadioButton()
        Me.txtResultMethod = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(245, 441)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(330, 82)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResult.Size = New System.Drawing.Size(331, 382)
        Me.txtResult.TabIndex = 3
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Location = New System.Drawing.Point(12, 32)
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(156, 20)
        Me.txtIPAddress.TabIndex = 5
        Me.txtIPAddress.Text = "103.122.182.18"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "IP Address"
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(174, 32)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(146, 20)
        Me.txtDatabase.TabIndex = 7
        Me.txtDatabase.Text = "KOSHRM2020"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(175, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Database"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(326, 32)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(146, 20)
        Me.txtUserName.TabIndex = 9
        Me.txtUserName.Text = "koshrm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(327, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "UserName"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(478, 32)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(146, 20)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.Text = "koshrm@123"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(479, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Password"
        '
        'chkProcedures
        '
        Me.chkProcedures.CheckOnClick = True
        Me.chkProcedures.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProcedures.FormattingEnabled = True
        Me.chkProcedures.Location = New System.Drawing.Point(12, 82)
        Me.chkProcedures.Name = "chkProcedures"
        Me.chkProcedures.Size = New System.Drawing.Size(308, 346)
        Me.chkProcedures.TabIndex = 12
        '
        'btnTestConnection
        '
        Me.btnTestConnection.Location = New System.Drawing.Point(652, 28)
        Me.btnTestConnection.Name = "btnTestConnection"
        Me.btnTestConnection.Size = New System.Drawing.Size(107, 23)
        Me.btnTestConnection.TabIndex = 13
        Me.btnTestConnection.Text = "Test Connection"
        Me.btnTestConnection.UseVisualStyleBackColor = True
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnection.Location = New System.Drawing.Point(649, 54)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(111, 13)
        Me.lblConnection.TabIndex = 14
        Me.lblConnection.Text = "Connection Status"
        '
        'rdoGET
        '
        Me.rdoGET.AutoSize = True
        Me.rdoGET.Checked = True
        Me.rdoGET.Location = New System.Drawing.Point(16, 447)
        Me.rdoGET.Name = "rdoGET"
        Me.rdoGET.Size = New System.Drawing.Size(42, 17)
        Me.rdoGET.TabIndex = 15
        Me.rdoGET.TabStop = True
        Me.rdoGET.Text = "Get"
        Me.rdoGET.UseVisualStyleBackColor = True
        '
        'rdoPOST
        '
        Me.rdoPOST.AutoSize = True
        Me.rdoPOST.Location = New System.Drawing.Point(87, 447)
        Me.rdoPOST.Name = "rdoPOST"
        Me.rdoPOST.Size = New System.Drawing.Size(46, 17)
        Me.rdoPOST.TabIndex = 16
        Me.rdoPOST.Text = "Post"
        Me.rdoPOST.UseVisualStyleBackColor = True
        '
        'txtResultMethod
        '
        Me.txtResultMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultMethod.Location = New System.Drawing.Point(676, 82)
        Me.txtResultMethod.Multiline = True
        Me.txtResultMethod.Name = "txtResultMethod"
        Me.txtResultMethod.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResultMethod.Size = New System.Drawing.Size(331, 382)
        Me.txtResultMethod.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 509)
        Me.Controls.Add(Me.txtResultMethod)
        Me.Controls.Add(Me.rdoPOST)
        Me.Controls.Add(Me.rdoGET)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.btnTestConnection)
        Me.Controls.Add(Me.chkProcedures)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIPAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnGenerate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents txtIPAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkProcedures As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnTestConnection As System.Windows.Forms.Button
    Friend WithEvents lblConnection As System.Windows.Forms.Label
    Friend WithEvents rdoGET As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPOST As System.Windows.Forms.RadioButton
    Friend WithEvents txtResultMethod As System.Windows.Forms.TextBox

End Class
