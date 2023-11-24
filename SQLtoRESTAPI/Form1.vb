Imports System.Data.SqlClient

Public Class Form1

    Public strConnection As String = Nothing
    Dim sqlConnection As SqlConnection

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        txtResult.Clear()

        For lintCount As Integer = 0 To chkProcedures.CheckedItems.Count - 1

            txtResult.AppendText(toGenerateClass(chkProcedures.CheckedItems(lintCount)))
            txtResult.AppendText(Environment.NewLine & Environment.NewLine)

            txtResultMethod.AppendText(getProcedureStructure(chkProcedures.CheckedItems(lintCount)))
            txtResultMethod.AppendText(Environment.NewLine & Environment.NewLine)

        Next



    End Sub


    Public Function getProcedureStructure(ByVal procedureName As String) As String

        Try

            Dim strFirstCodes As String = Nothing
            Dim strLastCodes As String = Nothing
            Dim strGetorPost As String = Nothing

            Dim strCode As String = Nothing
            Dim sqlReader As SqlDataReader = Nothing

            If rdoGET.Checked = True Then
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
            "sqlcommand = New SqlCommand(""" & procedureName & """, lobjConnection.ServerConnection())" & Environment.NewLine &
                    "{" & Environment.NewLine &
            "CommandType = CommandType.StoredProcedure" & Environment.NewLine &
                    "};" & Environment.NewLine

            Dim sqlcommand As New SqlCommand("SELECT * FROM INFORMATION_SCHEMA.PARAMETERS WHERE SPECIFIC_NAME='" & procedureName & "'", ServerConnectionDB)
            sqlcommand.CommandType = CommandType.Text
            sqlReader = sqlcommand.ExecuteReader()

            If sqlReader.HasRows = True Then

                While sqlReader.Read

                    strCode += "sqlCommand.Parameters.AddWithValue(""" & sqlReader!PARAMETER_NAME & """," & procedureName.ToLower() & "." & sqlReader!PARAMETER_NAME.ToString.Replace("@", "") & ")" & Environment.NewLine & Environment.NewLine


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

        strConnection = "Data Source=" & txtIPAddress.Text & ";Initial Catalog=" & txtDatabase.Text & ";User ID=" & txtUserName.Text & ";Password=" & txtPassword.Text & ";Pooling=True;Min Pool Size=5;Max Pool Size=5000;Connect Timeout=60;"
        sqlConnection = New SqlConnection(strConnection)

        If ServerConnection() = True Then
            lblConnection.Text = "Connection Success"
            lblConnection.ForeColor = Color.DarkGreen

            Call FetchProcedureList()

        Else
            lblConnection.Text = "Connection Failed"
            lblConnection.ForeColor = Color.DarkRed
        End If

    End Sub

    Public Function FetchProcedureList() As DataTable
        strConnection = "Data Source=" & txtIPAddress.Text & ";Initial Catalog=" & txtDatabase.Text & ";User ID=" & txtUserName.Text & ";Password=" & txtPassword.Text & ";Pooling=True;Min Pool Size=5;Max Pool Size=5000;Connect Timeout=60;"
        sqlConnection = New SqlConnection(strConnection)

        Dim sqlCommand As SqlCommand
        sqlCommand = New SqlCommand("SELECT SPECIFIC_SCHEMA,SPECIFIC_NAME   FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE'", ServerConnectionDB)
        sqlCommand.CommandType = CommandType.Text
        Dim SqlDataAdapter As SqlDataAdapter
        SqlDataAdapter = New SqlDataAdapter(sqlCommand)
        Dim dtTable As New DataTable()
        SqlDataAdapter.Fill(dtTable)

        If dtTable.Rows.Count > 0 Then

            For lintCount As Integer = 0 To dtTable.Rows.Count - 1

                chkProcedures.Items.Add(dtTable.Rows(lintCount).Item(1))

            Next

        End If

    End Function


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

End Class
