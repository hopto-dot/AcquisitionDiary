<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class log
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblLogText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLogText
        '
        Me.lblLogText.AutoSize = True
        Me.lblLogText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogText.ForeColor = System.Drawing.Color.White
        Me.lblLogText.Location = New System.Drawing.Point(3, 9)
        Me.lblLogText.Name = "lblLogText"
        Me.lblLogText.Size = New System.Drawing.Size(49, 16)
        Me.lblLogText.TabIndex = 0
        Me.lblLogText.Text = "Label1"
        '
        'log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Controls.Add(Me.lblLogText)
        Me.Name = "log"
        Me.Size = New System.Drawing.Size(380, 36)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLogText As Label
End Class
