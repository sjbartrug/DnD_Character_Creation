<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpForm
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
        Me.HelpTextBox = New System.Windows.Forms.TextBox()
        Me.closeAttributeHelpButton = New System.Windows.Forms.Button()
        Me.HelpTitleLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'HelpTextBox
        '
        Me.HelpTextBox.Location = New System.Drawing.Point(27, 51)
        Me.HelpTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HelpTextBox.Multiline = True
        Me.HelpTextBox.Name = "HelpTextBox"
        Me.HelpTextBox.ReadOnly = True
        Me.HelpTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.HelpTextBox.Size = New System.Drawing.Size(593, 295)
        Me.HelpTextBox.TabIndex = 1
        Me.HelpTextBox.Text = "It's over anakin! I have the high ground" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "... you underestimate my power" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Don't try it!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Noooooooooooooooooooooo"
        '
        'closeAttributeHelpButton
        '
        Me.closeAttributeHelpButton.Location = New System.Drawing.Point(282, 364)
        Me.closeAttributeHelpButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.closeAttributeHelpButton.Name = "closeAttributeHelpButton"
        Me.closeAttributeHelpButton.Size = New System.Drawing.Size(82, 22)
        Me.closeAttributeHelpButton.TabIndex = 0
        Me.closeAttributeHelpButton.Text = "Close"
        Me.closeAttributeHelpButton.UseVisualStyleBackColor = True
        '
        'HelpTitleLabel
        '
        Me.HelpTitleLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.HelpTitleLabel.Location = New System.Drawing.Point(24, 9)
        Me.HelpTitleLabel.Name = "HelpTitleLabel"
        Me.HelpTitleLabel.Size = New System.Drawing.Size(478, 32)
        Me.HelpTitleLabel.TabIndex = 32
        Me.HelpTitleLabel.Text = "Default Title"
        '
        'HelpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 397)
        Me.Controls.Add(Me.HelpTitleLabel)
        Me.Controls.Add(Me.closeAttributeHelpButton)
        Me.Controls.Add(Me.HelpTextBox)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "HelpForm"
        Me.Text = "Help Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HelpTextBox As TextBox
    Friend WithEvents closeAttributeHelpButton As Button
    Friend WithEvents HelpTitleLabel As Label
End Class
