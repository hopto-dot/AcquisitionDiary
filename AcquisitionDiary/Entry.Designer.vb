<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entry
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblEntryDate = New System.Windows.Forms.Label()
        Me.flpEntries = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'lblEntryDate
        '
        Me.lblEntryDate.AutoSize = True
        Me.lblEntryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntryDate.ForeColor = System.Drawing.Color.White
        Me.lblEntryDate.Location = New System.Drawing.Point(3, 4)
        Me.lblEntryDate.Name = "lblEntryDate"
        Me.lblEntryDate.Size = New System.Drawing.Size(110, 24)
        Me.lblEntryDate.TabIndex = 1
        Me.lblEntryDate.Text = "mm/dd/yyyy"
        '
        'flpEntries
        '
        Me.flpEntries.AutoScroll = True
        Me.flpEntries.Location = New System.Drawing.Point(7, 34)
        Me.flpEntries.Name = "flpEntries"
        Me.flpEntries.Size = New System.Drawing.Size(427, 214)
        Me.flpEntries.TabIndex = 2
        '
        'Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Controls.Add(Me.flpEntries)
        Me.Controls.Add(Me.lblEntryDate)
        Me.Name = "Entry"
        Me.Size = New System.Drawing.Size(442, 257)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEntryDate As Label
    Friend WithEvents flpEntries As FlowLayoutPanel
End Class
