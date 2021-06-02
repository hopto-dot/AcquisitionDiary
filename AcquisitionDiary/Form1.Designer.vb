<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.plMain = New System.Windows.Forms.Panel()
        Me.btnEntries = New System.Windows.Forms.Button()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnAddEntry = New System.Windows.Forms.Button()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'plMain
        '
        Me.plMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.plMain.Dock = System.Windows.Forms.DockStyle.Right
        Me.plMain.Location = New System.Drawing.Point(139, 0)
        Me.plMain.Name = "plMain"
        Me.plMain.Size = New System.Drawing.Size(610, 411)
        Me.plMain.TabIndex = 1
        '
        'btnEntries
        '
        Me.btnEntries.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnEntries.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEntries.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEntries.FlatAppearance.BorderSize = 0
        Me.btnEntries.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnEntries.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntries.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntries.ForeColor = System.Drawing.Color.White
        Me.btnEntries.Location = New System.Drawing.Point(0, 39)
        Me.btnEntries.Name = "btnEntries"
        Me.btnEntries.Size = New System.Drawing.Size(133, 39)
        Me.btnEntries.TabIndex = 1
        Me.btnEntries.Text = "Entries"
        Me.btnEntries.UseVisualStyleBackColor = False
        '
        'btnStats
        '
        Me.btnStats.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnStats.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStats.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStats.FlatAppearance.BorderSize = 0
        Me.btnStats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnStats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStats.ForeColor = System.Drawing.Color.White
        Me.btnStats.Location = New System.Drawing.Point(0, 78)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(133, 39)
        Me.btnStats.TabIndex = 2
        Me.btnStats.Text = "Stats"
        Me.btnStats.UseVisualStyleBackColor = False
        '
        'btnBackup
        '
        Me.btnBackup.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnBackup.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBackup.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBackup.FlatAppearance.BorderSize = 0
        Me.btnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.ForeColor = System.Drawing.Color.White
        Me.btnBackup.Location = New System.Drawing.Point(0, 156)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(133, 39)
        Me.btnBackup.TabIndex = 4
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Location = New System.Drawing.Point(0, 117)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(133, 39)
        Me.btnSettings.TabIndex = 3
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnAddEntry
        '
        Me.btnAddEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnAddEntry.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAddEntry.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddEntry.FlatAppearance.BorderSize = 0
        Me.btnAddEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnAddEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnAddEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEntry.ForeColor = System.Drawing.Color.White
        Me.btnAddEntry.Location = New System.Drawing.Point(0, 0)
        Me.btnAddEntry.Name = "btnAddEntry"
        Me.btnAddEntry.Size = New System.Drawing.Size(133, 39)
        Me.btnAddEntry.TabIndex = 0
        Me.btnAddEntry.Text = "Add Entry"
        Me.btnAddEntry.UseVisualStyleBackColor = False
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlButtons.Controls.Add(Me.btnBackup)
        Me.pnlButtons.Controls.Add(Me.btnSettings)
        Me.pnlButtons.Controls.Add(Me.btnStats)
        Me.pnlButtons.Controls.Add(Me.btnEntries)
        Me.pnlButtons.Controls.Add(Me.btnAddEntry)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlButtons.Location = New System.Drawing.Point(0, 0)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(133, 411)
        Me.pnlButtons.TabIndex = 2
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(133, 0)
        Me.Splitter1.MinExtra = 0
        Me.Splitter1.MinSize = 90
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(8, 411)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(749, 411)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.plMain)
        Me.MinimumSize = New System.Drawing.Size(623, 375)
        Me.Name = "Form1"
        Me.Text = "Acquisition Diary"
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents plMain As Panel
    Friend WithEvents btnEntries As Button
    Friend WithEvents btnStats As Button
    Friend WithEvents btnBackup As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnAddEntry As Button
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents Splitter1 As Splitter
End Class
