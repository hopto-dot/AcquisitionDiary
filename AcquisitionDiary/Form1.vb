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

    Public FormLanguage As String = "English"

    Public AllEntries As New List(Of Entry)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "/Settings.txt") = False Then
            File.Create("Settings.txt").Dispose()
            Dim FileWriter As System.IO.StreamWriter
            Try
                FileWriter = My.Computer.FileSystem.OpenTextFileWriter("Settings.txt", True)
                FileWriter.WriteLine("Language:English")
                FileWriter.WriteLine("Theme:Dark")
                FileWriter.Close()
            Catch ex As Exception
                MsgBox("The settings file could not be created, this may be because it is being used by another process", MsgBoxStyle.Critical)
            End Try
        End If
        LoadSettings()

        If Not Directory.Exists("Entries") Then
            Directory.CreateDirectory("Entries")
        End If

        plMain.Controls.Clear()

        With AddEntry
            .TopLevel = False
            .Dock = DockStyle.Fill
            plMain.Controls.Add(AddEntry)
            .BringToFront()
            .Show()
        End With

        If FormLanguage = "Japanese" Then
            btnAddEntry.Text = "追加"
            btnEntries.Text = "日記"
            btnStats.Text = "統計"
            btnSettings.Text = "設定"
            btnBackup.Text = "バックアップ"
        End If

    End Sub
    Public Sub GetAllEntries()
        AllEntries.Clear()
        Dim FileText As String = ""
        Dim LogParam As String = ""
        Dim LogValue As String = ""
        Dim FinishedLog As Boolean = False
        Dim FileNames As New List(Of DateTime)
        For Each EntryName In Directory.GetFiles("Entries")
            FileNames.Add(DateTime.Parse(EntryName.Replace("Entries\", "")))
        Next
        FileNames.Sort()
        FileNames.Reverse()

        For Each EntryName In FileNames
            Dim NewEntry As New Entry
            NewEntry.EDate = DateTime.Parse(EntryName)
            'NewEntry.EDate = DateTime.Parse("25/2/21") 'dd/mm/yy
            FileText = My.Computer.FileSystem.ReadAllText("Entries\" & CStr(EntryName).Replace("/", "-"))
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
    Public Sub LoadSettings()
        Dim SettingsFile As String = ""
        Try
            SettingsFile = My.Computer.FileSystem.ReadAllText("Settings.txt")
        Catch ex As Exception
            MsgBox("Settings could not be read", MsgBoxStyle.Critical)
        End Try
        Dim SettingLines As List(Of String) = SettingsFile.Trim.Split(vbCrLf).ToList

        For Each Setting In SettingLines
            Setting = Setting.Replace(vbCrLf, "")
            Dim LineParts As List(Of String) = Setting.Trim.Split(":").ToList
            Select Case LineParts(0)
                Case "Language"
                    Select Case LineParts(1)
                        Case "English"
                            FormLanguage = "English"
                        Case "Japanese"
                            FormLanguage = "Japanese"
                    End Select
            End Select
        Next

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
        GetAllEntries()
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
        If FormLanguage = "Japanese" Then
            MsgBox("この機能はまだ実装されていません。")
        Else
            MsgBox("This feature hasn't been added yet!")
        End If
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
        If FormLanguage = "Japanese" Then
            MsgBox("この機能はまだ実装されていません。")
        Else
            MsgBox("This feature hasn't been added yet!")
        End If
    End Sub
    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        plMain.Controls.Clear()
        My.Computer.FileSystem.CreateDirectory("Backups")
        My.Computer.FileSystem.CopyDirectory("Entries", "Backups\" & CStr(DateTime.Now.Date).Replace("/", "-"), True)
        If FormLanguage = "Japanese" Then
            If MsgBox("バックアップが正常に作成されました。" & vbNewLine & vbNewLine & "ご覧しますか？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Process.Start("Backups\" & CStr(DateTime.Now.Date).Replace("/", "-"))
            End If
        Else
            If MsgBox("Backup created successfully!" & vbNewLine & vbNewLine & "Would you like to view the backup?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Process.Start("Backups\" & CStr(DateTime.Now.Date).Replace("/", "-"))
            End If
        End If

    End Sub
End Class
