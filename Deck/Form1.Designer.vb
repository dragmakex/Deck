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
        Me.lstDeck = New System.Windows.Forms.ListBox()
        Me.cmdFill = New System.Windows.Forms.Button()
        Me.cmdShuffle = New System.Windows.Forms.Button()
        Me.piccard = New System.Windows.Forms.PictureBox()
        CType(Me.piccard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstDeck
        '
        Me.lstDeck.FormattingEnabled = True
        Me.lstDeck.Location = New System.Drawing.Point(509, 43)
        Me.lstDeck.Name = "lstDeck"
        Me.lstDeck.Size = New System.Drawing.Size(264, 472)
        Me.lstDeck.TabIndex = 0
        '
        'cmdFill
        '
        Me.cmdFill.Location = New System.Drawing.Point(95, 38)
        Me.cmdFill.Name = "cmdFill"
        Me.cmdFill.Size = New System.Drawing.Size(148, 80)
        Me.cmdFill.TabIndex = 1
        Me.cmdFill.Text = "Fill"
        Me.cmdFill.UseVisualStyleBackColor = True
        '
        'cmdShuffle
        '
        Me.cmdShuffle.Location = New System.Drawing.Point(96, 153)
        Me.cmdShuffle.Name = "cmdShuffle"
        Me.cmdShuffle.Size = New System.Drawing.Size(147, 83)
        Me.cmdShuffle.TabIndex = 2
        Me.cmdShuffle.Text = "Shuffle"
        Me.cmdShuffle.UseVisualStyleBackColor = True
        '
        'piccard
        '
        Me.piccard.Location = New System.Drawing.Point(307, 56)
        Me.piccard.Name = "piccard"
        Me.piccard.Size = New System.Drawing.Size(184, 255)
        Me.piccard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.piccard.TabIndex = 3
        Me.piccard.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 587)
        Me.Controls.Add(Me.piccard)
        Me.Controls.Add(Me.cmdShuffle)
        Me.Controls.Add(Me.cmdFill)
        Me.Controls.Add(Me.lstDeck)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.piccard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstDeck As ListBox
    Friend WithEvents cmdFill As Button
    Friend WithEvents cmdShuffle As Button
    Friend WithEvents piccard As PictureBox
End Class
