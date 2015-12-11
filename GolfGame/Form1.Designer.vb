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
        Me.btnPlayGolf = New System.Windows.Forms.Button()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnPlayGolf
        '
        Me.btnPlayGolf.Location = New System.Drawing.Point(216, 12)
        Me.btnPlayGolf.Name = "btnPlayGolf"
        Me.btnPlayGolf.Size = New System.Drawing.Size(75, 23)
        Me.btnPlayGolf.TabIndex = 0
        Me.btnPlayGolf.Text = "Play Golf!"
        Me.btnPlayGolf.UseVisualStyleBackColor = True
        '
        'lstScores
        '
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.Items.AddRange(New Object() {"" & Global.Microsoft.VisualBasic.ChrW(9) & "Hole 1" & Global.Microsoft.VisualBasic.ChrW(9) & "Hole 2" & Global.Microsoft.VisualBasic.ChrW(9) & "Hole 3" & Global.Microsoft.VisualBasic.ChrW(9) & "Hole 4" & Global.Microsoft.VisualBasic.ChrW(9) & "Hole 5" & Global.Microsoft.VisualBasic.ChrW(9) & "Hole 6" & Global.Microsoft.VisualBasic.ChrW(9) & "Hole 7" & Global.Microsoft.VisualBasic.ChrW(9) & "Hole 8" & Global.Microsoft.VisualBasic.ChrW(9) & "Hole 9", "Player 1", "Player 2", "Player 3", "Player 4"})
        Me.lstScores.Location = New System.Drawing.Point(12, 41)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(483, 69)
        Me.lstScores.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 273)
        Me.Controls.Add(Me.lstScores)
        Me.Controls.Add(Me.btnPlayGolf)
        Me.Name = "Form1"
        Me.Text = "Golf Game"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPlayGolf As System.Windows.Forms.Button
    Friend WithEvents lstScores As System.Windows.Forms.ListBox

End Class
