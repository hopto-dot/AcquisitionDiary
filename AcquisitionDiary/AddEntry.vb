Imports System.IO

Public Class AddEntry
    Private Sub btnToday_Click(sender As Object, e As EventArgs)
        'dtpEntryDate.Value = System.DateTime.Today
    End Sub
    Private Sub btnAddEntry_Click(sender As Object, e As EventArgs) Handles btnAddEntry.Click
        Dim EntryDate As String = CStr(System.DateTime.Today)
        EntryDate = EntryDate.Replace("/", "-")

        'EntryDate = Strings.Left(EntryDate, EntryDate.IndexOf(" "))

        If File.Exists("Entries\" & EntryDate) = False Then
            File.Create("Entries\" & EntryDate).Dispose()
        End If

        Dim FileWriter As System.IO.StreamWriter
        FileWriter = My.Computer.FileSystem.OpenTextFileWriter("Entries\" & EntryDate, True)
        FileWriter.WriteLine("|")
        FileWriter.WriteLine("¬Type::" & cbbEntryType.Text)
        FileWriter.WriteLine("¬Explain::" & tbxExplain.Text)
        FileWriter.WriteLine("¬Duration::" & tbxDuration.Text)
        FileWriter.WriteLine("¬Rating::" & tbRating.Value)
        FileWriter.Close()

    End Sub

    Private Sub AddEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.GetAllEntries()
        dtEntryDate.Value = DateTime.Today
        cbbEntryType.Text = "Anki"
    End Sub

    Private Sub cbbEntryType_Click(sender As Object, e As EventArgs)
        cbbEntryType.DroppedDown = True
    End Sub

    Private Sub AddEntry_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        ActiveControl = Label1
    End Sub
    Private Sub tbxDuration_TextChanged(sender As Object, e As EventArgs) Handles tbxDuration.TextChanged
        If IsNumeric(tbxDuration.Text) = True Then
            If tbxDuration.Text.Contains(".") And tbxDuration.Text.Length >= 3 Then
                tbxDuration.Text = CDbl(tbxDuration.Text) * 60
            End If
        Else
            tbxDuration.Text = tbxDuration.Text.Replace("h", "")
            If IsNumeric(tbxDuration.Text) = True Then
                tbxDuration.Text = CDbl(tbxDuration.Text) * 60
            Else
                tbxDuration.Text = ""
            End If


        End If
    End Sub

End Class