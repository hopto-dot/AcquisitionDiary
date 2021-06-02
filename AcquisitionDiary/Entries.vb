Public Class Entries
    Private Sub Entries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flpEntries.Controls.Clear()
        Dim I As Integer = 1
        For Each AddEntry In Form1.AllEntries
            Dim EntryControl As New Entry

            If Form1.FormLanguage = "Japanese" Then
                Select Case AddEntry.EDate.Date
                    Case DateTime.Now.Date
                        EntryControl.lblEntryDate.Text = AddEntry.EDate & " (今日)"
                    Case DateTime.Now.AddDays(-1).Date
                        EntryControl.lblEntryDate.Text = AddEntry.EDate & " (昨日)"
                    Case DateTime.Now.AddDays(-1).Date
                        EntryControl.lblEntryDate.Text = AddEntry.EDate & " (一昨日)"
                    Case DateTime.Now.AddDays(-7).Date
                        EntryControl.lblEntryDate.Text = AddEntry.EDate & " (１週間前)"
                    Case DateTime.Now.AddDays(-30).Date
                        EntryControl.lblEntryDate.Text = AddEntry.EDate & " (１ヶ月前)"
                    Case DateTime.Now.AddDays(-30).Date
                        EntryControl.lblEntryDate.Text = AddEntry.EDate & " (１年前)"
                    Case Else
                        EntryControl.lblEntryDate.Text = AddEntry.EDate
                End Select
            Else
                Select Case AddEntry.EDate.Date
                    Case DateTime.Now.Date
                        EntryControl.lblEntryDate.Text = AddEntry.EDate & " (Today)"
                    Case DateTime.Now.AddDays(-1).Date
                        EntryControl.lblEntryDate.Text = AddEntry.EDate & " (Yesterday)"
                    Case DateTime.Now.AddDays(-1).Date
                        EntryControl.lblEntryDate.Text = AddEntry.EDate & " (Two days ago)"
                    Case DateTime.Now.AddDays(-7).Date
                        EntryControl.lblEntryDate.Text = AddEntry.EDate & " (A week ago)"
                    Case DateTime.Now.AddDays(-30).Date
                        EntryControl.lblEntryDate.Text = AddEntry.EDate & " (A month ago)"
                    Case DateTime.Now.AddDays(-30).Date
                        EntryControl.lblEntryDate.Text = AddEntry.EDate & " (A year ago)"
                    Case Else
                        EntryControl.lblEntryDate.Text = AddEntry.EDate
                End Select
            End If

            For Each EntryLog In AddEntry.ELogs
                Dim LogControl As New log
                LogControl.Width = EntryControl.Width - 25
                LogControl.lblLogText.Text = EntryLog.LType & " (" & EntryLog.LDuration & " mins, rating: " & EntryLog.LRating & ")" & ": " & EntryLog.LExplain
                EntryControl.flpEntries.Controls.Add(LogControl)
            Next
            flpEntries.Controls.Add(EntryControl)
            I += 1
        Next
        Debug.WriteLine("Finished showing all entries")
        Refresh()
    End Sub
End Class