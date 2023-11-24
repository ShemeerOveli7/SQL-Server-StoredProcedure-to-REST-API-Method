Imports System.Data.SqlClient

Public Class BasicAPI
    Inherits MetroFramework.Forms.MetroForm

    Public strConnection As String = Nothing
    Dim sqlConnection As SqlConnection
    Dim chkListCount As Integer = 0

    Private Sub btnGenerateCode_Click(sender As Object, e As EventArgs) Handles btnGenerateCode.Click

        If chkProcedures.CheckedItems.Count = 0 Then
            MsgBox("Please select a procedure from the list", MsgBoxStyle.Information)
            Exit Sub
        End If

        txtResult.Clear()
        txtResultMethod.Clear()

        For lintCount As Integer = 0 To chkProcedures.CheckedItems.Count - 1

            txtResult.AppendText(toGenerateClass(chkProcedures.CheckedItems(lintCount).Split(".").ElementAt(1)))
            txtResult.AppendText(Environment.NewLine & Environment.NewLine)

            txtResultMethod.AppendText(getProcedureStructure(chkProcedures.CheckedItems(lintCount).Split(".").ElementAt(1), chkProcedures.CheckedItems(lintCount).Split(".").ElementAt(0)))
            txtResultMethod.AppendText(Environment.NewLine & Environment.NewLine)

        Next



    End Sub

    Public Function getProcedureStructure(ByVal procedureName As String, schemaName As String) As String

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


            strFirstCodes = "[Http" & strGetorPost & "]" & Environment.NewLine &
        "[Route(""" & procedureName & """)]" & Environment.NewLine &
        "public IHttpActionResult m" & procedureName & "(" & procedureName & " " & procedureName.ToLower() & ")" & Environment.NewLine &
        "{" & Environment.NewLine &
            "try" & Environment.NewLine &
            "{" & Environment.NewLine &
            "sqlcommand = New SqlCommand(""" & schemaName & "." & procedureName & """, lobjConnection.ServerConnection())" & Environment.NewLine &
                    "{" & Environment.NewLine &
            "CommandType = CommandType.StoredProcedure" & Environment.NewLine &
                    "};" & Environment.NewLine

            Dim sqlcommand As New SqlCommand("SELECT * FROM INFORMATION_SCHEMA.PARAMETERS WHERE SPECIFIC_NAME='" & procedureName & "'", ServerConnectionDB)
            sqlcommand.CommandType = CommandType.Text
            sqlReader = sqlcommand.ExecuteReader()

            If sqlReader.HasRows = True Then

                While sqlReader.Read

                    strCode += "sqlCommand.Parameters.AddWithValue(""" & sqlReader!PARAMETER_NAME & """," & procedureName.ToLower() & "." & sqlReader!PARAMETER_NAME.ToString.Replace("@", "") & ")" & Environment.NewLine

                End While

            End If

            strLastCodes = "var dt = new DataTable();" & Environment.NewLine &
                        "using (var sqlAdapter = new SqlDataAdapter(sqlCommand))" & Environment.NewLine &
                        "{" & Environment.NewLine &
                        "sqlAdapter.Fill(dt);" & Environment.NewLine &
                                "return Ok(GetJson(dt));" & Environment.NewLine &
                    "}" & Environment.NewLine &
            "}" & Environment.NewLine &
            "catch (Exception ex)" & Environment.NewLine &
            "{" & Environment.NewLine &
                "throw ex;" & Environment.NewLine &
            "}" & Environment.NewLine &
        "}" & Environment.NewLine

            Return strFirstCodes & strCode & strLastCodes

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

    Private Sub btnTestConnection_Click(sender As Object, e As EventArgs) Handles btnTestConnection.Click

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

            Call FetchProcedureList()

        Else
            lblConnection.Text = "Connection Failed"
            lblConnection.ForeColor = Color.DarkRed
            lblConnection.Visible = True
        End If

    End Sub

    Public Sub FetchProcedureList()

        strConnection = "Data Source=" & txtIPAddress.Text & ";Initial Catalog=" & txtDatabase.Text & ";User ID=" & txtUserName.Text & ";Password=" & txtPassword.Text & ";Pooling=True;Min Pool Size=5;Max Pool Size=5000;Connect Timeout=60;"
        sqlConnection = New SqlConnection(strConnection)

        Dim sqlCommand As SqlCommand
        sqlCommand = New SqlCommand("SELECT SPECIFIC_SCHEMA,SPECIFIC_NAME   FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE' order by SPECIFIC_NAME ", ServerConnectionDB)
        sqlCommand.CommandType = CommandType.Text
        Dim SqlDataAdapter As SqlDataAdapter
        SqlDataAdapter = New SqlDataAdapter(sqlCommand)
        Dim dtTable As New DataTable()
        SqlDataAdapter.Fill(dtTable)

        If dtTable.Rows.Count > 0 Then

            chkProcedures.Items.Clear()
            chkListCount = 0

            For lintCount As Integer = 0 To dtTable.Rows.Count - 1

                chkProcedures.Items.Add(dtTable.Rows(lintCount).Item(0) & "." & dtTable.Rows(lintCount).Item(1))

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

  

    Private Sub BasicAPI_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.WindowState = FormWindowState.Maximized

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

End Class