Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.FormLanguage = "Japanese" Then
            lblSettings.Text = "設定"
        End If
    End Sub
End Class