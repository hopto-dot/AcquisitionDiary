﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbRating = New System.Windows.Forms.TrackBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAddEntry = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtEntryDate = New MetroFramework.Controls.MetroDateTime()
        Me.cbbEntryType = New MetroFramework.Controls.MetroComboBox()
        Me.tbxDuration = New MetroFramework.Controls.MetroTextBox()
        Me.tbxExplain = New MetroFramework.Controls.MetroTextBox()
        CType(Me.tbRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbRating
        '
        Me.tbRating.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRating.LargeChange = 1
        Me.tbRating.Location = New System.Drawing.Point(6, 237)
        Me.tbRating.Name = "tbRating"
        Me.tbRating.Size = New System.Drawing.Size(535, 45)
        Me.tbRating.TabIndex = 2
        Me.tbRating.Value = 5
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(12, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "0"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(518, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "10"
        '
        'btnAddEntry
        '
        Me.btnAddEntry.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnAddEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEntry.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddEntry.Location = New System.Drawing.Point(12, 286)
        Me.btnAddEntry.Name = "btnAddEntry"
        Me.btnAddEntry.Size = New System.Drawing.Size(524, 24)
        Me.btnAddEntry.TabIndex = 3
        Me.btnAddEntry.Text = "Add Entry"
        Me.btnAddEntry.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Tell me more!"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Which day are you adding an entry for?"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Rating"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "What did you do?"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(378, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Duration"
        '
        'dtEntryDate
        '
        Me.dtEntryDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtEntryDate.Checked = False
        Me.dtEntryDate.Location = New System.Drawing.Point(12, 36)
        Me.dtEntryDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtEntryDate.Name = "dtEntryDate"
        Me.dtEntryDate.Size = New System.Drawing.Size(523, 29)
        Me.dtEntryDate.TabIndex = 9
        Me.dtEntryDate.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'cbbEntryType
        '
        Me.cbbEntryType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbEntryType.FormattingEnabled = True
        Me.cbbEntryType.ItemHeight = 23
        Me.cbbEntryType.Items.AddRange(New Object() {"Anki", "Reading", "Watching", "Listening", "Studying", "Gaming", "Speaking", "Writing"})
        Me.cbbEntryType.Location = New System.Drawing.Point(12, 99)
        Me.cbbEntryType.Name = "cbbEntryType"
        Me.cbbEntryType.Size = New System.Drawing.Size(359, 29)
        Me.cbbEntryType.TabIndex = 10
        Me.cbbEntryType.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cbbEntryType.UseSelectable = True
        '
        'tbxDuration
        '
        Me.tbxDuration.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbxDuration.CustomButton.Image = Nothing
        Me.tbxDuration.CustomButton.Location = New System.Drawing.Point(125, 1)
        Me.tbxDuration.CustomButton.Name = ""
        Me.tbxDuration.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbxDuration.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbxDuration.CustomButton.TabIndex = 1
        Me.tbxDuration.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbxDuration.CustomButton.UseSelectable = True
        Me.tbxDuration.CustomButton.Visible = False
        Me.tbxDuration.Lines = New String(-1) {}
        Me.tbxDuration.Location = New System.Drawing.Point(382, 99)
        Me.tbxDuration.MaxLength = 32767
        Me.tbxDuration.Name = "tbxDuration"
        Me.tbxDuration.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxDuration.PromptText = "Duration in minutes"
        Me.tbxDuration.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbxDuration.SelectedText = ""
        Me.tbxDuration.SelectionLength = 0
        Me.tbxDuration.SelectionStart = 0
        Me.tbxDuration.ShortcutsEnabled = True
        Me.tbxDuration.Size = New System.Drawing.Size(153, 29)
        Me.tbxDuration.TabIndex = 11
        Me.tbxDuration.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tbxDuration.UseSelectable = True
        Me.tbxDuration.WaterMark = "Duration in minutes"
        Me.tbxDuration.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbxDuration.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tbxExplain
        '
        Me.tbxExplain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbxExplain.CustomButton.Image = Nothing
        Me.tbxExplain.CustomButton.Location = New System.Drawing.Point(495, 1)
        Me.tbxExplain.CustomButton.Name = ""
        Me.tbxExplain.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbxExplain.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbxExplain.CustomButton.TabIndex = 1
        Me.tbxExplain.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbxExplain.CustomButton.UseSelectable = True
        Me.tbxExplain.CustomButton.Visible = False
        Me.tbxExplain.Lines = New String(-1) {}
        Me.tbxExplain.Location = New System.Drawing.Point(12, 171)
        Me.tbxExplain.MaxLength = 32767
        Me.tbxExplain.Name = "tbxExplain"
        Me.tbxExplain.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxExplain.PromptText = "What did you do?"
        Me.tbxExplain.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbxExplain.SelectedText = ""
        Me.tbxExplain.SelectionLength = 0
        Me.tbxExplain.SelectionStart = 0
        Me.tbxExplain.ShortcutsEnabled = True
        Me.tbxExplain.Size = New System.Drawing.Size(523, 29)
        Me.tbxExplain.TabIndex = 11
        Me.tbxExplain.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tbxExplain.UseSelectable = True
        Me.tbxExplain.WaterMark = "What did you do?"
        Me.tbxExplain.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbxExplain.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'AddEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(548, 330)
        Me.Controls.Add(Me.tbxExplain)
        Me.Controls.Add(Me.tbxDuration)
        Me.Controls.Add(Me.cbbEntryType)
        Me.Controls.Add(Me.dtEntryDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddEntry)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbRating)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(311, 330)
        Me.Name = "AddEntry"
        Me.Text = "AddEntry"
        CType(Me.tbRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbRating As TrackBar
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAddEntry As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtEntryDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cbbEntryType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents tbxDuration As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbxExplain As MetroFramework.Controls.MetroTextBox
End Class
