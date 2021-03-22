<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttributeHelpForm
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
        Me.attributeHelpTextBox = New System.Windows.Forms.TextBox()
        Me.closeAttributeHelpButton = New System.Windows.Forms.Button()
        Me.attributeHelpTitleLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'attributeHelpTextBox
        '
        Me.attributeHelpTextBox.Location = New System.Drawing.Point(27, 76)
        Me.attributeHelpTextBox.Multiline = True
        Me.attributeHelpTextBox.Name = "attributeHelpTextBox"
        Me.attributeHelpTextBox.ReadOnly = True
        Me.attributeHelpTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.attributeHelpTextBox.Size = New System.Drawing.Size(546, 251)
        Me.attributeHelpTextBox.TabIndex = 1
        Me.attributeHelpTextBox.Text = "It's over anakin! I have the high ground" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "... you underestimate my power" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Don't try it!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Noooooooooooooooooooooo"
        '
        'closeAttributeHelpButton
        '
        Me.closeAttributeHelpButton.Location = New System.Drawing.Point(250, 343)
        Me.closeAttributeHelpButton.Name = "closeAttributeHelpButton"
        Me.closeAttributeHelpButton.Size = New System.Drawing.Size(94, 29)
        Me.closeAttributeHelpButton.TabIndex = 0
        Me.closeAttributeHelpButton.Text = "Close"
        Me.closeAttributeHelpButton.UseVisualStyleBackColor = True
        '
        'attributeHelpTitleLabel
        '
        Me.attributeHelpTitleLabel.AutoSize = True
        Me.attributeHelpTitleLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.attributeHelpTitleLabel.Location = New System.Drawing.Point(86, 21)
        Me.attributeHelpTitleLabel.Name = "attributeHelpTitleLabel"
        Me.attributeHelpTitleLabel.Size = New System.Drawing.Size(419, 38)
        Me.attributeHelpTitleLabel.TabIndex = 32
        Me.attributeHelpTitleLabel.Text = "How to Assign Attributes"
        '
        'AttributeHelpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 394)
        Me.Controls.Add(Me.attributeHelpTitleLabel)
        Me.Controls.Add(Me.closeAttributeHelpButton)
        Me.Controls.Add(Me.attributeHelpTextBox)
        Me.Name = "AttributeHelpForm"
        Me.Text = "AttributeHelpForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents attributeHelpTextBox As TextBox
    Friend WithEvents closeAttributeHelpButton As Button
    Friend WithEvents attributeHelpTitleLabel As Label
End Class
