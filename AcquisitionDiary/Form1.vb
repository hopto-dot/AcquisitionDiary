Imports System.IO
Public Class Form1
    Public Class Entry
        Public EDate As DateTime
        Public ELogs As New List(Of DLog)
    End Class
    Public Class DLog
        Public LType As String = ""
        Public LExplain As String = ""
        Public LDuration As Integer = -1
        Public LRating As Integer = -1
    End Class

    Public AllEntries As New List(Of Entry)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Directory.Exists("Entries") Then
            Directory.CreateDirectory("Entries")
        End If

        If My.Computer.FileSystem.FileExists("Settings.txt") = False Then
            File.Create("Settings.txt").Dispose()
        End If

        plMain.Controls.Clear()

        With AddEntry
            .TopLevel = False
            .Dock = DockStyle.Fill
            plMain.Controls.Add(AddEntry)
            .BringToFront()
            .Show()
        End With


    End Sub
    Public Sub GetAllEntries()
        Dim FileText As String = ""
        Dim LogParam As String = ""
        Dim LogValue As String = ""
        Dim FinishedLog As Boolean = False
        For Each EntryName In Directory.GetFiles("Entries")
            Dim NewEntry As New Entry
            NewEntry.EDate = DateTime.Parse(EntryName.Replace("Entries\", ""))
            'NewEntry.EDate = DateTime.Parse("25/2/21") 'dd/mm/yy
            FileText = My.Computer.FileSystem.ReadAllText(EntryName)
            FileText = Mid(FileText, 2)
            Dim Logs() As String = FileText.Split("|")
            For Each EntryLog In Logs
                Dim NewLog As New DLog
                EntryLog = Mid(EntryLog, 4)
                Dim LogParameters() As String = EntryLog.Replace(vbCrLf, "").Split("¬")

                For Each LogParameter In LogParameters
                    LogParam = Strings.Left(LogParameter, LogParameter.IndexOf("::")).Trim
                    LogParameter = Mid(LogParameter, LogParameter.IndexOf("::") + 3)
                    LogValue = LogParameter 'Strings.Left(LogParameter, LogParameter.IndexOf("::")).Trim

                    Select Case LogParam
                        Case "Type"
                            NewLog.LType = LogValue
                        Case "Explain"
                            NewLog.LExplain = LogValue
                        Case "Duration"
                            NewLog.LDuration = LogValue
                        Case "Rating"
                            NewLog.LRating = LogValue
                    End Select
                Next

                NewEntry.ELogs.Add(NewLog)
            Next
            AllEntries.Add(NewEntry)
        Next

        Debug.WriteLine("Finished Loading")
    End Sub




    'Panel Buttons:
    Private Sub btnAddEntry_Click(sender As Object, e As EventArgs) Handles btnAddEntry.Click
        plMain.Controls.Clear()

        With AddEntry
            .TopLevel = False
            .Dock = DockStyle.Fill
            plMain.Controls.Add(AddEntry)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnEntries_Click(sender As Object, e As EventArgs) Handles btnEntries.Click
        plMain.Controls.Clear()

        With Entries
            .TopLevel = False
            .Dock = DockStyle.Fill
            plMain.Controls.Add(Entries)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        plMain.Controls.Clear()

        With EntryStatistics
            .TopLevel = False
            .Dock = DockStyle.Fill
            plMain.Controls.Add(EntryStatistics)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        plMain.Controls.Clear()

        With Settings
            .TopLevel = False
            .Dock = DockStyle.Fill
            plMain.Controls.Add(Settings)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        plMain.Controls.Clear()
    End Sub
End Class
