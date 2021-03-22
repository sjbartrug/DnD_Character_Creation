<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CharacterSheetDisplayForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.characterSheetHeading = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.classLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.raceLabel = New System.Windows.Forms.Label()
        Me.subrace = New System.Windows.Forms.Label()
        Me.attributeAllocationLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'characterSheetHeading
        '
        Me.characterSheetHeading.AutoSize = True
        Me.characterSheetHeading.Cursor = System.Windows.Forms.Cursors.Default
        Me.characterSheetHeading.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.characterSheetHeading.Location = New System.Drawing.Point(584, 26)
        Me.characterSheetHeading.Name = "characterSheetHeading"
        Me.characterSheetHeading.Size = New System.Drawing.Size(173, 24)
        Me.characterSheetHeading.TabIndex = 56
        Me.characterSheetHeading.Text = "Your Character"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(465, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 22)
        Me.Label1.TabIndex = 55
        '
        'classLabel
        '
        Me.classLabel.AutoSize = True
        Me.classLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.classLabel.Location = New System.Drawing.Point(107, 413)
        Me.classLabel.Name = "classLabel"
        Me.classLabel.Size = New System.Drawing.Size(108, 38)
        Me.classLabel.TabIndex = 54
        Me.classLabel.Text = "Class"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.nameLabel.Location = New System.Drawing.Point(107, 56)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(108, 38)
        Me.nameLabel.TabIndex = 53
        Me.nameLabel.Text = "Name"
        '
        'raceLabel
        '
        Me.raceLabel.AutoSize = True
        Me.raceLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.raceLabel.Location = New System.Drawing.Point(107, 175)
        Me.raceLabel.Name = "raceLabel"
        Me.raceLabel.Size = New System.Drawing.Size(95, 38)
        Me.raceLabel.TabIndex = 52
        Me.raceLabel.Text = "Race"
        '
        'subrace
        '
        Me.subrace.AutoSize = True
        Me.subrace.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.subrace.Location = New System.Drawing.Point(107, 294)
        Me.subrace.Name = "subrace"
        Me.subrace.Size = New System.Drawing.Size(148, 38)
        Me.subrace.TabIndex = 51
        Me.subrace.Text = "Subrace"
        '
        'attributeAllocationLabel
        '
        Me.attributeAllocationLabel.AutoSize = True
        Me.attributeAllocationLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.attributeAllocationLabel.Location = New System.Drawing.Point(526, 105)
        Me.attributeAllocationLabel.Name = "attributeAllocationLabel"
        Me.attributeAllocationLabel.Size = New System.Drawing.Size(264, 38)
        Me.attributeAllocationLabel.TabIndex = 57
        Me.attributeAllocationLabel.Text = "Attribute Points"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(526, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 38)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Saving Throws"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(1042, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 38)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Skills"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(1042, 413)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 38)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Spells"
        '
        'CharacterSheetDisplayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1313, 637)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.attributeAllocationLabel)
        Me.Controls.Add(Me.characterSheetHeading)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.classLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.raceLabel)
        Me.Controls.Add(Me.subrace)
        Me.Name = "CharacterSheetDisplayForm"
        Me.Text = "CharacterSheetDisplayForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents characterSheetHeading As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents classLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents raceLabel As Label
    Friend WithEvents subrace As Label
    Friend WithEvents attributeAllocationLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
