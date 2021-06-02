Imports System.IO

Public Class AddEntry
    Private Sub btnToday_Click(sender As Object, e As EventArgs)
        'dtpEntryDate.Value = System.DateTime.Today
    End Sub
    Private Sub btnAddEntry_Click(sender As Object, e As EventArgs) Handles btnAddEntry.Click
        Dim EntryDate As String = CStr(System.DateTime.Today)

        If tbxDuration.Text = "" Or tbxExplain.Text = "" Then
            If Form1.FormLanguage = "Japanese" Then
                MsgBox("すべての項目を入力するのが必要です。")
            Else
                MsgBox("You must fill in all fields")
            End If

            Exit Sub
        End If

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

        If Form1.FormLanguage = "Japanese" Then
            MsgBox("エントリーが追加されました！")
        Else
            MsgBox("Entry has been added!")
        End If
    End Sub

    Private Sub AddEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.GetAllEntries()
        dtEntryDate.Value = DateTime.Today
        cbbEntryType.Text = "Anki"

        If Form1.FormLanguage = "Japanese" Then
            lblWhichDay.Text = "何日？"
            lblWhatDid.Text = "何をやった？"
            lblWhatDuration.Text = "どのぐらいの間"
            tbxDuration.WaterMark = "分単位で"
            lblTellMeMore.Text = "他に教えて！"
            tbxExplain.WaterMark = "何をやった？"
            lblRating.Text = "評価"

            btnAddEntry.Text = "追加"
        End If
    End Sub

    Private Sub cbbEntryType_Click(sender As Object, e As EventArgs)
        cbbEntryType.DroppedDown = True
    End Sub

    Private Sub AddEntry_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        ActiveControl = lblTellMeMore
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