Public Class SelectAPI
    Inherits MetroFramework.Forms.MetroForm


    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click

        BasicAPI.Show()

    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click

        StructuredAPI.Show()

    End Sub

   

    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs) Handles MetroLabel1.Click

        End

    End Sub

    Private Sub lblCompanyName_Click(sender As Object, e As EventArgs) Handles lblCompanyName.Click

        System.Diagnostics.Process.Start("https://www.aabasoft.com")

    End Sub

    Private Sub SelectAPI_Load(sender As Object, e As EventArgs) Handles Me.Load

      

    End Sub

End Class