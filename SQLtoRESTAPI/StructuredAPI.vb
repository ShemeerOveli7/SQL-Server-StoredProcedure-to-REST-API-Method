Imports System.Data.SqlClient

Public Class StructuredAPI
    Inherits MetroFramework.Forms.MetroForm

    Public strConnection As String = Nothing
    Dim sqlConnection As SqlConnection
    Dim chkListCount As Integer = 0
    ' Dim procedureList As ArrayList

    Private Sub StructuredAPI_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.WindowState = FormWindowState.Maximized

        Me.Text = "Structured REST API Code Generator by Aabasoft"

        If Len(My.Settings.IPAddress) > 0 Then
            txtIPAddress.Text = My.Settings.IPAddress
        End If

        If Len(My.Settings.Database) > 0 Then
            txtDatabase.Text = My.Settings.Database
        End If

        If Len(My.Settings.UserName) > 0 Then
            txtUserName.Text = My.Settings.UserName
        End If

    End Sub

    Private Sub btnTestConnection_Click(sender As Object, e As EventArgs) Handles btnTestConnection.Click

        Call TestConnection()

    End Sub

    Public Sub TestConnection()


        ErrorProvider1.Clear()

        If Len(Trim(txtIPAddress.Text)) = 0 Then
            ErrorProvider1.SetError(txtIPAddress, "Please enter IP Address")
            Exit Sub
        End If

        If Len(Trim(txtDatabase.Text)) = 0 Then
            ErrorProvider1.SetError(txtDatabase, "Please enter Database Name")
            Exit Sub
        End If

        If Len(Trim(txtUserName.Text)) = 0 Then
            ErrorProvider1.SetError(txtUserName, "Please enter SQL User Name")
            Exit Sub
        End If

        If Len(Trim(txtPassword.Text)) = 0 Then
            ErrorProvider1.SetError(txtPassword, "Please enter SQL Password")
            Exit Sub
        End If

        strConnection = "Data Source=" & txtIPAddress.Text & ";Initial Catalog=" & txtDatabase.Text & ";User ID=" & txtUserName.Text & ";Password=" & txtPassword.Text & ";Pooling=True;Min Pool Size=5;Max Pool Size=5000;Connect Timeout=60;"
        sqlConnection = New SqlConnection(strConnection)

        lblConnection.Visible = False

        If ServerConnection() = True Then
            lblConnection.Text = "Connection Success"
            lblConnection.ForeColor = Color.DarkGreen
            lblConnection.Visible = True

            My.Settings.IPAddress = txtIPAddress.Text
            My.Settings.Database = txtDatabase.Text
            My.Settings.UserName = txtUserName.Text

            Call FetchProcedureList("@#$")

        Else
            lblConnection.Text = "Connection Failed"
            lblConnection.ForeColor = Color.DarkRed
            lblConnection.Visible = True
        End If

    End Sub

    Public Sub FetchProcedureList(ByVal strSearchText As String)

        If strSearchText = "@#$" Then
            strSearchText = " order by SPECIFIC_SCHEMA,SPECIFIC_NAME "
        Else
            strSearchText = " and SPECIFIC_NAME like '%" & strSearchText & "%'  order by SPECIFIC_SCHEMA,SPECIFIC_NAME"
        End If

        strConnection = "Data Source=" & txtIPAddress.Text & ";Initial Catalog=" & txtDatabase.Text & ";User ID=" & txtUserName.Text & ";Password=" & txtPassword.Text & ";Pooling=True;Min Pool Size=5;Max Pool Size=5000;Connect Timeout=60;"
        sqlConnection = New SqlConnection(strConnection)

        'txtStructureAndValidator.Text = "SELECT SPECIFIC_SCHEMA,SPECIFIC_NAME   FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE' " & strSearchText

        'MsgBox("Yes")

        Dim sqlCommand As SqlCommand
        sqlCommand = New SqlCommand("SELECT SPECIFIC_SCHEMA,SPECIFIC_NAME   FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE' " & strSearchText, ServerConnectionDB)
        sqlCommand.CommandType = CommandType.Text
        Dim SqlDataAdapter As SqlDataAdapter
        SqlDataAdapter = New SqlDataAdapter(sqlCommand)
        Dim dtTable As New DataTable()
        SqlDataAdapter.Fill(dtTable)

        ' procedureList = New ArrayList()

        If dtTable.Rows.Count > 0 Then

            chkProcedures.Items.Clear()
            chkListCount = 0

            For lintCount As Integer = 0 To dtTable.Rows.Count - 1

                chkProcedures.Items.Add(dtTable.Rows(lintCount).Item(0) & "." & dtTable.Rows(lintCount).Item(1))
                '  procedureList.Add(dtTable.Rows(lintCount).Item(0) & "." & dtTable.Rows(lintCount).Item(1))

            Next

        End If



    End Sub


    Public Function ServerConnectionDB() As SqlConnection

        Try

            If sqlConnection.State = ConnectionState.Open Then
                sqlConnection.Close()
            End If

            sqlConnection.Open()

            Return sqlConnection

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ServerConnection() As Boolean

        Try

            If sqlConnection.State = ConnectionState.Open Then
                sqlConnection.Close()
            End If

            sqlConnection.Open()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub btnGenerateCode_Click(sender As Object, e As EventArgs) Handles btnGenerateCode.Click

        If chkProcedures.CheckedItems.Count = 0 Then
            MsgBox("Please select a procedure from the list", MsgBoxStyle.Information)
            Exit Sub
        End If

        txtStructureAndValidator.Clear()
        txtBusinessLayer.Clear()
        txtPresentationLayer.Clear()
        txtDataLayer.Clear()

        For lintCount As Integer = 0 To chkProcedures.CheckedItems.Count - 1

            txtStructureAndValidator.AppendText(toGenerateClass(chkProcedures.CheckedItems(lintCount).ToString.Split(".").ElementAt(1)))
            txtStructureAndValidator.AppendText(Environment.NewLine & Environment.NewLine)

            txtStructureAndValidator.AppendText(getValidationClass(chkProcedures.CheckedItems(lintCount).ToString.Split(".").ElementAt(1)))
            txtStructureAndValidator.AppendText(Environment.NewLine & Environment.NewLine)

            txtPresentationLayer.AppendText(getPresentationLayer(chkProcedures.CheckedItems(lintCount).ToString.Split(".").ElementAt(1)))
            txtPresentationLayer.AppendText(Environment.NewLine & Environment.NewLine)

        Next

        txtDataLayer.AppendText(getDataLayerStructure(chkProcedures))
        txtDataLayer.AppendText(Environment.NewLine & Environment.NewLine)

        txtBusinessLayer.AppendText(getBusinessLayerStructure(chkProcedures))
        txtBusinessLayer.AppendText(Environment.NewLine & Environment.NewLine)



    End Sub

    Public Function getDataLayerStructure(ByVal chkProcedureListItems As CheckedListBox) As String

        Try

            Dim strFirstCodes As String = Nothing
            Dim strLastCodes As String = Nothing
            Dim strGetorPost As String = Nothing

            Dim strCode As String = Nothing
            Dim sqlReader As SqlDataReader = Nothing
            Dim sqlcommand As SqlCommand

            If rdoGet.Checked = True Then
                strGetorPost = "Get"
            Else
                strGetorPost = "Post"
            End If

            strFirstCodes = "public interface IModule_" & txtDatabase.Text.Trim & "DALRepository" & Environment.NewLine & "{" & Environment.NewLine

            For lintCount As Integer = 0 To chkProcedureListItems.CheckedItems.Count - 1

                strCode += "Task<Object> " & chkProcedureListItems.CheckedItems(lintCount).ToString.Split(".").ElementAt(1) & "(" & chkProcedureListItems.CheckedItems(lintCount).ToString.Split(".").ElementAt(1) & "Request " & chkProcedureListItems.CheckedItems(lintCount).ToString.Split(".").ElementAt(1).ToLower & "Request);" & Environment.NewLine

            Next

            strCode += "}" & Environment.NewLine

            strCode += "public class Module_" & txtDatabase.Text & "DAL : IModule_" & txtDatabase.Text & "DALRepository" & Environment.NewLine & "{" & Environment.NewLine

            For lintCount As Integer = 0 To chkProcedureListItems.CheckedItems.Count - 1

                strCode += "public async Task<object> " & chkProcedureListItems.CheckedItems(lintCount).ToString.Split(".").ElementAt(1) & "(" & chkProcedureListItems.CheckedItems(lintCount).ToString.Split(".").ElementAt(1) & "Request " & chkProcedureListItems.CheckedItems(lintCount).ToString.Split(".").ElementAt(1).ToLower & "Request)" & Environment.NewLine & "{" & Environment.NewLine & "try" & Environment.NewLine & "{" & Environment.NewLine

                strCode += "sqlcommand = New SqlCommand(""" & chkProcedureListItems.CheckedItems(lintCount).ToString.Split(".").ElementAt(0) & "." & chkProcedureListItems.CheckedItems(lintCount).ToString.Split(".").ElementAt(1) & """, lobjConnection.ServerConnection())" & Environment.NewLine &
                   "{" & Environment.NewLine &
           "CommandType = CommandType.StoredProcedure;" & Environment.NewLine &
                   "};" & Environment.NewLine


                sqlcommand = New SqlCommand("SELECT * FROM INFORMATION_SCHEMA.PARAMETERS WHERE SPECIFIC_NAME='" & chkProcedureListItems.CheckedItems(lintCount).ToString.Split(".").ElementAt(1) & "'", ServerConnectionDB)
                sqlcommand.CommandType = CommandType.Text
                sqlReader = sqlcommand.ExecuteReader()

                If sqlReader.HasRows = True Then

                    While sqlReader.Read

                        strCode += "sqlCommand.Parameters.AddWithValue(""" & sqlReader!PARAMETER_NAME & """," & chkProcedureListItems.CheckedItems(lintCount).ToString.Split(".").ElementAt(1).ToLower() & "." & sqlReader!PARAMETER_NAME.ToString.Replace("@", "") & ");" & Environment.NewLine


                    End While

                End If

                sqlReader.Close()

                strCode += "var dt = new DataTable();" & Environment.NewLine &
                   "using (var sqlAdapter = new SqlDataAdapter(sqlCommand))" & Environment.NewLine &
                   "{" & Environment.NewLine &
                   "sqlAdapter.Fill(dt);" & Environment.NewLine &
                           "return GetJson(dt);" & Environment.NewLine &
               "}" & Environment.NewLine &
       "}" & Environment.NewLine &
       "catch (Exception ex)" & Environment.NewLine &
       "{" & Environment.NewLine &
           "throw ex;" & Environment.NewLine &
       "}" & Environment.NewLine &
         "}" & Environment.NewLine

            Next

            strLastCodes = "}" & Environment.NewLine

            strLastCodes += "// DATA LAYER"

            Return strFirstCodes & strCode & strLastCodes

        Catch exception As Exception
            Throw exception

        End Try

    End Function

    Public Function getBusinessLayerStructure(ByVal chkProcedureListItems As CheckedListBox) As String

        Try

            Dim strFirstCodes As String = Nothing
            Dim strLastCodes As String = Nothing
            Dim strGetorPost As String = Nothing

            Dim strCode As String = Nothing

            If rdoGet.Checked = True Then
                strGetorPost = "Get"
            Else
                strGetorPost = "Post"
            End If



            strFirstCodes = "public interface IModule_" & txtDatabase.Text.Trim & "BLLRepository" & Environment.NewLine & "{" & Environment.NewLine

            For lintCount As Integer = 0 To chkProcedureListItems.CheckedItems.Count - 1

                strCode += "Task<" & txtDatabase.Text & "_API_RESPONSE<string>> " & chkProcedureListItems.CheckedItems(lintCount).ToString.Split(".").ElementAt(1) & "(" & chkProcedureListItems.CheckedItems(lintCount).ToString.Split(".").ElementAt(1) & "Request " & chkProcedureListItems.CheckedItems(lintCount).ToString.Split(".").ElementAt(1).ToLower & "Request);" & Environment.NewLine

            Next

            strCode += "}" & Environment.NewLine

            strCode += "public class " & txtDatabase.Text & "BLL : IModule_" & txtDatabase.Text & "BLLRepository" & Environment.NewLine & "{" & Environment.NewLine

            strCode += "private readonly IModule_" & txtDatabase.Text & "DALRepository _module_" & txtDatabase.Text & "DAL;" & Environment.NewLine

            strCode += "public " & txtDatabase.Text & "BLL(IModule_" & txtDatabase.Text & "DALRepository module_" & txtDatabase.Text & "DAL)" & Environment.NewLine & "{" & Environment.NewLine & " _module_" & txtDatabase.Text & "DAL = module_" & txtDatabase.Text & "DAL;" & Environment.NewLine & "}" & Environment.NewLine

            For lintCount As Integer = 0 To chkProcedureListItems.CheckedItems.Count - 1



                strCode += "public async Task<" & txtDatabase.Text & "_API_RESPONSE<string>> " & chkProcedureListItems.CheckedItems(lintCount).ToString.Split(".").ElementAt(1) & "(" & chkProcedureListItems.CheckedItems(lintCount).ToString.Split(".").ElementAt(1) & "Request " & chkProcedureListItems.CheckedItems(lintCount).ToString.Split(".").ElementAt(1).ToLower & "Request)" & Environment.NewLine & "{" & Environment.NewLine & "var responseFromBLL = new " & txtDatabase.Text & "_API_RESPONSE<string>();" & Environment.NewLine & "try" & Environment.NewLine & "{" & Environment.NewLine

                strCode += "var validator = new " & chkProcedureListItems.CheckedItems(lintCount).ToString.Split(".").ElementAt(1) & "Request_Validator();" & Environment.NewLine
                strCode += "ValidationResult validationResult = await validator.ValidateAsync(" & chkProcedureListItems.CheckedItems(lintCount).ToString.Split(".").ElementAt(1).ToLower & "Request);" & Environment.NewLine

                strCode += "if (!validationResult.IsValid) " & Environment.NewLine
                strCode += "return ValidationBuilder.ValidationResponse<string>(validationResult);" & Environment.NewLine
                strCode += "return _module_" & txtDatabase.Text & "DAL." & chkProcedureListItems.CheckedItems(lintCount).ToString.Split(".").ElementAt(1) & "(" & chkProcedureListItems.CheckedItems(lintCount).ToString.Split(".").ElementAt(1).ToLower & "Request);" & Environment.NewLine & "}" & "catch (Exception ex)" & Environment.NewLine & "{" & Environment.NewLine & "responseFromBLL.responseResult.responseCode = ""GM_001"";" & Environment.NewLine & "responseFromBLL.responseResult.responseDescription = ex.Message;" & Environment.NewLine & "return responseFromBLL;" & Environment.NewLine & "}" & Environment.NewLine & "}" & Environment.NewLine

            Next

            strLastCodes = "}" & Environment.NewLine

            strLastCodes += "// BUSINESS LAYER"

            Return strFirstCodes & strCode & strLastCodes

        Catch exception As Exception
            Throw exception

        End Try

    End Function

    Public Function getBusinessLayerStructureOLD(ByVal procedureName As String) As String

        Try

            Dim strFirstCodes As String = Nothing
            Dim strLastCodes As String = Nothing
            Dim strGetorPost As String = Nothing

            Dim strCode As String = Nothing
            Dim sqlReader As SqlDataReader = Nothing

            If rdoGet.Checked = True Then
                strGetorPost = "Get"
            Else
                strGetorPost = "Post"
            End If



            strCode = "public async Task<" & txtDatabase.Text & "_API_RESPONSE<string>> " & procedureName & "(" & procedureName & " " & procedureName.ToLower & ")" & Environment.NewLine &
"{" & Environment.NewLine &
"var responseFromBLL = new " & txtDatabase.Text & "_API_RESPONSE<string>();" & Environment.NewLine &
            "try" & Environment.NewLine &
              "{" & Environment.NewLine &
                "var validator = new " & procedureName & "_Validator();" & Environment.NewLine &
            "ValidationResult validationResult = await validator.ValidateAsync(validate" & procedureName & ");" & Environment.NewLine &
   "if (!validationResult.IsValid)" & Environment.NewLine &
  "return ValidationBuilder.ValidationResponse<string>(validationResult);" & Environment.NewLine &
  "return  _settingsDAL." & procedureName & "(validate" & procedureName & ");" & Environment.NewLine &
"}" & Environment.NewLine &
"catch (Exception ex)" & Environment.NewLine &
"{" & Environment.NewLine &
"responseFromBLL.responseResult.responseCode = ""GM_001"";" & Environment.NewLine &
"responseFromBLL.responseResult.responseDescription = ex.Message;" & Environment.NewLine &
"return responseFromBLL;" & Environment.NewLine &
"}" & Environment.NewLine &
"}" & Environment.NewLine

            strCode += "// BUSINESS LAYER"

            Return strCode

        Catch exception As Exception
            Throw exception

        End Try

    End Function


    Public Function getPresentationLayer(ByVal procedureName As String) As String

        Try


            Dim strGetorPost As String = Nothing

            Dim strCode As String = Nothing
            Dim sqlReader As SqlDataReader = Nothing

            If rdoGet.Checked = True Then
                strGetorPost = "Get"
            Else
                strGetorPost = "Post"
            End If

            '[HttpPost]
            '[Route("validate_referral_code")]
            '[SwaggerResponse(HttpStatusCode.OK, Type = typeof(GEOMARK_API_RESPONSE<string>))]
            'public async Task<IHttpActionResult> ValidateReferralCode([FromBody] ValidateReferralCodeRequest validateReferralCodeRequest)



            strCode = "[Http" & strGetorPost & "]" & Environment.NewLine &
        "[Route(""" & procedureName & """)]" & Environment.NewLine &
        "public async Task<IHttpActionResult> m" & procedureName & "([FromBody] " & procedureName & " " & procedureName.ToLower() & ")" & Environment.NewLine &
        "{" & Environment.NewLine &
            "try" & Environment.NewLine &
            "{" & Environment.NewLine &
"return Ok(await " & txtDatabase.Text & "BLL." & procedureName & "(" & procedureName & "));" &
            "}" & Environment.NewLine &
            "catch (Exception ex)" & Environment.NewLine &
           "{" & Environment.NewLine &
                "throw ex;" & Environment.NewLine &
             "}" & Environment.NewLine &
           "}" & Environment.NewLine

            strCode += "// PRESENTATION LAYER"

            Return strCode

        Catch exception As Exception
            Throw exception

        End Try

    End Function

    Public Function getValidationClass(ByVal procedureName As String) As String

        Try

            Dim strGetorPost As String = Nothing

            Dim strCode As String = Nothing
            Dim sqlReader As SqlDataReader = Nothing


            If rdoGet.Checked = True Then
                strGetorPost = "Get"
            Else
                strGetorPost = "Post"
            End If

            strCode = "public class " & procedureName & "_Validator : AbstractValidator<" & procedureName & ">" & Environment.NewLine &
        "{" & Environment.NewLine &
        "public " & procedureName & "_Validator() " & Environment.NewLine &
               "{" & Environment.NewLine

            Dim sqlcommand As New SqlCommand("SELECT * FROM INFORMATION_SCHEMA.PARAMETERS WHERE SPECIFIC_NAME='" & procedureName & "'", ServerConnectionDB)
            sqlcommand.CommandType = CommandType.Text
            sqlReader = sqlcommand.ExecuteReader()

            If sqlReader.HasRows = True Then

                While sqlReader.Read
                    'RuleFor(x => x.deviceId).NotEmpty().WithMessage("Required");
                    strCode += "RuleFor(x => x." & sqlReader!PARAMETER_NAME.ToString.Replace("@", "") & ").NotEmpty().WithMessage(""Required"");" & Environment.NewLine

                End While

            End If

            strCode += "}" & Environment.NewLine & "}" & Environment.NewLine

            strCode += "//STRUCTURE AND VALIDATION"

            Return strCode

        Catch exception As Exception
            Throw exception

        End Try

    End Function

    Private Function toGenerateClass(ByVal procedureName As String) As String

        Dim strCode As String = Nothing

        Dim sqlReader As SqlDataReader = Nothing

        Dim sqlcommand As New SqlCommand("SELECT * FROM INFORMATION_SCHEMA.PARAMETERS WHERE SPECIFIC_NAME='" & procedureName & "'", ServerConnectionDB)
        sqlcommand.CommandType = CommandType.Text
        sqlReader = sqlcommand.ExecuteReader()

        strCode += " public class " & procedureName & Environment.NewLine &
          "{" & Environment.NewLine

        If sqlReader.HasRows = True Then

            While sqlReader.Read

                strCode += "public " & sqlReader!DATA_TYPE.ToString.Replace("varchar", "string").Replace("smalldatetime", "date").Replace("datetime", "date") & " " & sqlReader!PARAMETER_NAME.ToString.Replace("@", "") & " " & "{get; set;}" & Environment.NewLine


            End While

        End If

        strCode += "}"



        Return strCode

    End Function

    Private Sub chkProcedures_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chkProcedures.ItemCheck

        If (e.NewValue = CheckState.Checked) Then
            chkListCount += 1
        End If

        If (e.NewValue = CheckState.Unchecked) Then
            chkListCount -= 1
        End If

        lblSelectedProcedures.Text = chkListCount & " selected"

    End Sub

    Private Sub lblClear_Click(sender As Object, e As EventArgs) Handles lblClear.Click

        If chkProcedures.CheckedItems.Count > 0 Then
            chkProcedures.ClearSelected()
            chkListCount = 0
        End If

    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown

        If e.KeyCode = Keys.Enter Then

            Call TestConnection()

        End If

    End Sub

    Private Sub txtPresentationLayer_Click(sender As Object, e As EventArgs) Handles txtPresentationLayer.Click

        If txtPresentationLayer.Text.Trim.Length > 10 Then

            Clipboard.SetText("// Code Generated from SQL to REST API tool powered by Aabasoft." & Environment.NewLine & Environment.NewLine & txtPresentationLayer.Text)

            MessageBox.Show("Presentation Layer Code Copied to Clipboard")

        End If

    End Sub

    Private Sub txtStructureAndValidator_Click(sender As Object, e As EventArgs) Handles txtStructureAndValidator.Click


        If txtStructureAndValidator.Text.Trim.Length > 10 Then

            Clipboard.SetText("// Code Generated from SQL to REST API tool powered by Aabasoft." & Environment.NewLine & Environment.NewLine & txtStructureAndValidator.Text)

            MessageBox.Show("Structure And Validator Code Copied to Clipboard")

        End If

    End Sub

    Private Sub txtDataLayer_Click(sender As Object, e As EventArgs) Handles txtDataLayer.Click


        If txtDataLayer.Text.Trim.Length > 10 Then

            Clipboard.SetText("// Code Generated from SQL to REST API tool powered by Aabasoft." & Environment.NewLine & Environment.NewLine & txtDataLayer.Text)

            MessageBox.Show("DataLayer Code Copied to Clipboard")

        End If

    End Sub

    Private Sub txtBusinessLayer_Click(sender As Object, e As EventArgs) Handles txtBusinessLayer.Click

        If txtBusinessLayer.Text.Trim.Length > 10 Then

            Clipboard.SetText("// Code Generated from SQL to REST API tool powered by Aabasoft." & Environment.NewLine & Environment.NewLine & txtBusinessLayer.Text)

            MessageBox.Show("BusinessLayer Code Copied to Clipboard")

        End If

    End Sub

    Private Sub txtSearch_ButtonClick(sender As Object, e As EventArgs) Handles txtSearch.ButtonClick

        If txtSearch.CustomButton.Text = "ok" Then
            Call FetchProcedureList(txtSearch.Text)
            txtSearch.CustomButton.Text = "X"
            Exit Sub
        End If

        If txtSearch.CustomButton.Text = "X" Then
            Call FetchProcedureList("@#$")
            txtSearch.CustomButton.Text = "ok"
            txtSearch.Text = Nothing
            Exit Sub
        End If

    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown

        If e.KeyCode = Keys.Enter Then

            If txtSearch.CustomButton.Text = "ok" Then
                Call FetchProcedureList(txtSearch.Text)
                txtSearch.CustomButton.Text = "X"
                Exit Sub
            End If

            If txtSearch.CustomButton.Text = "X" Then
                Call FetchProcedureList("@#$")
                txtSearch.CustomButton.Text = "ok"
                txtSearch.Text = Nothing
                Exit Sub
            End If

        End If

    End Sub
End Class