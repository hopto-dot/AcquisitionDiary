Public Class Entries
    Private Sub Entries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each AddEntry In Form1.AllEntries
            Dim EntryControl As New Entry
            EntryControl.lblEntryDate.Text = AddEntry.EDate
            For Each EntryLog In AddEntry.ELogs
                Dim LogControl As New log
                LogControl.Width = EntryControl.Width - 25
                LogControl.lblLogText.Text = EntryLog.LType & ": " & EntryLog.LExplain & " (" & EntryLog.LDuration & " mins, rating: " & EntryLog.LRating & ")"
                EntryControl.flpEntries.Controls.Add(LogControl)
            Next
            flpEntries.Controls.Add(EntryControl)
        Next
        Debug.WriteLine("Finished showing all entries")
        Refresh()
    End Sub
End Class