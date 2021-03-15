<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class characterSheetForm
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
        Me.nameTextField = New System.Windows.Forms.TextBox()
        Me.nameSubmitButton = New System.Windows.Forms.Button()
        Me.humanRadioButton = New System.Windows.Forms.RadioButton()
        Me.elfRadioButton = New System.Windows.Forms.RadioButton()
        Me.tieflingRadioButton = New System.Windows.Forms.RadioButton()
        Me.raceSubmitButton = New System.Windows.Forms.Button()
        Me.fighterRadioButton = New System.Windows.Forms.RadioButton()
        Me.barbarianRadioButton = New System.Windows.Forms.RadioButton()
        Me.monkRadioButton = New System.Windows.Forms.RadioButton()
        Me.classSubmitButton = New System.Windows.Forms.Button()
        Me.highElfRadioButton = New System.Windows.Forms.RadioButton()
        Me.woodElfRadioButton = New System.Windows.Forms.RadioButton()
        Me.subraceSubmitButton = New System.Windows.Forms.Button()
        Me.subrace = New System.Windows.Forms.Label()
        Me.raceLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.classLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dndLabel = New System.Windows.Forms.Label()
        Me.statRollLabel = New System.Windows.Forms.Label()
        Me.rollOneTextField = New System.Windows.Forms.TextBox()
        Me.rollTwoTextField = New System.Windows.Forms.TextBox()
        Me.rollThreeTextField = New System.Windows.Forms.TextBox()
        Me.rollDiceButton = New System.Windows.Forms.Button()
        Me.rollValueSubmitButton = New System.Windows.Forms.Button()
        Me.attributeAllocationLabel = New System.Windows.Forms.Label()
        Me.attributeListBox = New System.Windows.Forms.ListBox()
        Me.rollListBox = New System.Windows.Forms.ListBox()
        Me.allocateButton = New System.Windows.Forms.Button()
        Me.attributeSubmitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nameTextField
        '
        Me.nameTextField.Location = New System.Drawing.Point(12, 113)
        Me.nameTextField.Name = "nameTextField"
        Me.nameTextField.PlaceholderText = "Insert Name Here"
        Me.nameTextField.Size = New System.Drawing.Size(208, 23)
        Me.nameTextField.TabIndex = 0
        '
        'nameSubmitButton
        '
        Me.nameSubmitButton.Location = New System.Drawing.Point(241, 114)
        Me.nameSubmitButton.Name = "nameSubmitButton"
        Me.nameSubmitButton.Size = New System.Drawing.Size(75, 22)
        Me.nameSubmitButton.TabIndex = 1
        Me.nameSubmitButton.Text = "Submit"
        Me.nameSubmitButton.UseVisualStyleBackColor = True
        '
        'humanRadioButton
        '
        Me.humanRadioButton.AutoSize = True
        Me.humanRadioButton.Location = New System.Drawing.Point(12, 205)
        Me.humanRadioButton.Name = "humanRadioButton"
        Me.humanRadioButton.Size = New System.Drawing.Size(68, 19)
        Me.humanRadioButton.TabIndex = 2
        Me.humanRadioButton.TabStop = True
        Me.humanRadioButton.Text = "Human "
        Me.humanRadioButton.UseVisualStyleBackColor = True
        '
        'elfRadioButton
        '
        Me.elfRadioButton.AutoSize = True
        Me.elfRadioButton.Location = New System.Drawing.Point(104, 205)
        Me.elfRadioButton.Name = "elfRadioButton"
        Me.elfRadioButton.Size = New System.Drawing.Size(38, 19)
        Me.elfRadioButton.TabIndex = 3
        Me.elfRadioButton.TabStop = True
        Me.elfRadioButton.Text = "Elf"
        Me.elfRadioButton.UseVisualStyleBackColor = True
        '
        'tieflingRadioButton
        '
        Me.tieflingRadioButton.AutoSize = True
        Me.tieflingRadioButton.Location = New System.Drawing.Point(156, 203)
        Me.tieflingRadioButton.Name = "tieflingRadioButton"
        Me.tieflingRadioButton.Size = New System.Drawing.Size(64, 19)
        Me.tieflingRadioButton.TabIndex = 4
        Me.tieflingRadioButton.TabStop = True
        Me.tieflingRadioButton.Text = "Tiefling"
        Me.tieflingRadioButton.UseVisualStyleBackColor = True
        '
        'raceSubmitButton
        '
        Me.raceSubmitButton.Location = New System.Drawing.Point(241, 203)
        Me.raceSubmitButton.Name = "raceSubmitButton"
        Me.raceSubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.raceSubmitButton.TabIndex = 5
        Me.raceSubmitButton.Text = "Submit"
        Me.raceSubmitButton.UseVisualStyleBackColor = True
        '
        'fighterRadioButton
        '
        Me.fighterRadioButton.AutoSize = True
        Me.fighterRadioButton.Location = New System.Drawing.Point(148, 409)
        Me.fighterRadioButton.Name = "fighterRadioButton"
        Me.fighterRadioButton.Size = New System.Drawing.Size(62, 19)
        Me.fighterRadioButton.TabIndex = 6
        Me.fighterRadioButton.TabStop = True
        Me.fighterRadioButton.Text = "Fighter"
        Me.fighterRadioButton.UseVisualStyleBackColor = True
        '
        'barbarianRadioButton
        '
        Me.barbarianRadioButton.AutoSize = True
        Me.barbarianRadioButton.Location = New System.Drawing.Point(12, 409)
        Me.barbarianRadioButton.Name = "barbarianRadioButton"
        Me.barbarianRadioButton.Size = New System.Drawing.Size(75, 19)
        Me.barbarianRadioButton.TabIndex = 7
        Me.barbarianRadioButton.TabStop = True
        Me.barbarianRadioButton.Text = "Barbarian"
        Me.barbarianRadioButton.UseVisualStyleBackColor = True
        '
        'monkRadioButton
        '
        Me.monkRadioButton.AutoSize = True
        Me.monkRadioButton.Location = New System.Drawing.Point(86, 409)
        Me.monkRadioButton.Name = "monkRadioButton"
        Me.monkRadioButton.Size = New System.Drawing.Size(56, 19)
        Me.monkRadioButton.TabIndex = 8
        Me.monkRadioButton.TabStop = True
        Me.monkRadioButton.Text = "Monk"
        Me.monkRadioButton.UseVisualStyleBackColor = True
        '
        'classSubmitButton
        '
        Me.classSubmitButton.Location = New System.Drawing.Point(241, 405)
        Me.classSubmitButton.Name = "classSubmitButton"
        Me.classSubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.classSubmitButton.TabIndex = 9
        Me.classSubmitButton.Text = "Submit"
        Me.classSubmitButton.UseVisualStyleBackColor = True
        '
        'highElfRadioButton
        '
        Me.highElfRadioButton.AutoSize = True
        Me.highElfRadioButton.Location = New System.Drawing.Point(35, 310)
        Me.highElfRadioButton.Name = "highElfRadioButton"
        Me.highElfRadioButton.Size = New System.Drawing.Size(67, 19)
        Me.highElfRadioButton.TabIndex = 10
        Me.highElfRadioButton.TabStop = True
        Me.highElfRadioButton.Text = "High Elf"
        Me.highElfRadioButton.UseVisualStyleBackColor = True
        '
        'woodElfRadioButton
        '
        Me.woodElfRadioButton.AutoSize = True
        Me.woodElfRadioButton.Location = New System.Drawing.Point(123, 308)
        Me.woodElfRadioButton.Name = "woodElfRadioButton"
        Me.woodElfRadioButton.Size = New System.Drawing.Size(73, 19)
        Me.woodElfRadioButton.TabIndex = 11
        Me.woodElfRadioButton.TabStop = True
        Me.woodElfRadioButton.Text = "Wood Elf"
        Me.woodElfRadioButton.UseVisualStyleBackColor = True
        '
        'subraceSubmitButton
        '
        Me.subraceSubmitButton.Location = New System.Drawing.Point(241, 306)
        Me.subraceSubmitButton.Name = "subraceSubmitButton"
        Me.subraceSubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.subraceSubmitButton.TabIndex = 12
        Me.subraceSubmitButton.Text = "Submit"
        Me.subraceSubmitButton.UseVisualStyleBackColor = True
        '
        'subrace
        '
        Me.subrace.AutoSize = True
        Me.subrace.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.subrace.Location = New System.Drawing.Point(55, 253)
        Me.subrace.Name = "subrace"
        Me.subrace.Size = New System.Drawing.Size(120, 32)
        Me.subrace.TabIndex = 13
        Me.subrace.Text = "Subrace"
        '
        'raceLabel
        '
        Me.raceLabel.AutoSize = True
        Me.raceLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.raceLabel.Location = New System.Drawing.Point(77, 157)
        Me.raceLabel.Name = "raceLabel"
        Me.raceLabel.Size = New System.Drawing.Size(78, 32)
        Me.raceLabel.TabIndex = 14
        Me.raceLabel.Text = "Race"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.nameLabel.Location = New System.Drawing.Point(77, 67)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(89, 32)
        Me.nameLabel.TabIndex = 15
        Me.nameLabel.Text = "Name"
        '
        'classLabel
        '
        Me.classLabel.AutoSize = True
        Me.classLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.classLabel.Location = New System.Drawing.Point(64, 361)
        Me.classLabel.Name = "classLabel"
        Me.classLabel.Size = New System.Drawing.Size(85, 32)
        Me.classLabel.TabIndex = 16
        Me.classLabel.Text = "Class"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(5, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
        Me.Label1.TabIndex = 17
        '
        'dndLabel
        '
        Me.dndLabel.AutoSize = True
        Me.dndLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.dndLabel.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.dndLabel.Location = New System.Drawing.Point(5, 9)
        Me.dndLabel.Name = "dndLabel"
        Me.dndLabel.Size = New System.Drawing.Size(207, 19)
        Me.dndLabel.TabIndex = 18
        Me.dndLabel.Text = "Dungeons And Dragons"
        '
        'statRollLabel
        '
        Me.statRollLabel.AutoSize = True
        Me.statRollLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.statRollLabel.Location = New System.Drawing.Point(456, 37)
        Me.statRollLabel.Name = "statRollLabel"
        Me.statRollLabel.Size = New System.Drawing.Size(122, 32)
        Me.statRollLabel.TabIndex = 19
        Me.statRollLabel.Text = "Stat Roll"
        '
        'rollOneTextField
        '
        Me.rollOneTextField.Location = New System.Drawing.Point(425, 114)
        Me.rollOneTextField.Name = "rollOneTextField"
        Me.rollOneTextField.PlaceholderText = "Roll 1"
        Me.rollOneTextField.Size = New System.Drawing.Size(58, 23)
        Me.rollOneTextField.TabIndex = 20
        '
        'rollTwoTextField
        '
        Me.rollTwoTextField.Location = New System.Drawing.Point(489, 115)
        Me.rollTwoTextField.Name = "rollTwoTextField"
        Me.rollTwoTextField.PlaceholderText = "Roll 2"
        Me.rollTwoTextField.Size = New System.Drawing.Size(58, 23)
        Me.rollTwoTextField.TabIndex = 21
        '
        'rollThreeTextField
        '
        Me.rollThreeTextField.Location = New System.Drawing.Point(553, 115)
        Me.rollThreeTextField.Name = "rollThreeTextField"
        Me.rollThreeTextField.PlaceholderText = "Roll 3"
        Me.rollThreeTextField.Size = New System.Drawing.Size(58, 23)
        Me.rollThreeTextField.TabIndex = 22
        '
        'rollDiceButton
        '
        Me.rollDiceButton.Location = New System.Drawing.Point(489, 76)
        Me.rollDiceButton.Name = "rollDiceButton"
        Me.rollDiceButton.Size = New System.Drawing.Size(58, 23)
        Me.rollDiceButton.TabIndex = 23
        Me.rollDiceButton.Text = "Roll"
        Me.rollDiceButton.UseVisualStyleBackColor = True
        '
        'rollValueSubmitButton
        '
        Me.rollValueSubmitButton.Location = New System.Drawing.Point(632, 115)
        Me.rollValueSubmitButton.Name = "rollValueSubmitButton"
        Me.rollValueSubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.rollValueSubmitButton.TabIndex = 24
        Me.rollValueSubmitButton.Text = "Submit"
        Me.rollValueSubmitButton.UseVisualStyleBackColor = True
        '
        'attributeAllocationLabel
        '
        Me.attributeAllocationLabel.AutoSize = True
        Me.attributeAllocationLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.attributeAllocationLabel.Location = New System.Drawing.Point(390, 169)
        Me.attributeAllocationLabel.Name = "attributeAllocationLabel"
        Me.attributeAllocationLabel.Size = New System.Drawing.Size(260, 32)
        Me.attributeAllocationLabel.TabIndex = 25
        Me.attributeAllocationLabel.Text = "Attribute Allocation"
        '
        'attributeListBox
        '
        Me.attributeListBox.FormattingEnabled = True
        Me.attributeListBox.ItemHeight = 15
        Me.attributeListBox.Items.AddRange(New Object() {"Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma"})
        Me.attributeListBox.Location = New System.Drawing.Point(526, 221)
        Me.attributeListBox.Name = "attributeListBox"
        Me.attributeListBox.Size = New System.Drawing.Size(76, 94)
        Me.attributeListBox.TabIndex = 26
        '
        'rollListBox
        '
        Me.rollListBox.FormattingEnabled = True
        Me.rollListBox.ItemHeight = 15
        Me.rollListBox.Items.AddRange(New Object() {"Roll One", "Roll Two", "Roll Three"})
        Me.rollListBox.Location = New System.Drawing.Point(425, 221)
        Me.rollListBox.Name = "rollListBox"
        Me.rollListBox.Size = New System.Drawing.Size(75, 94)
        Me.rollListBox.TabIndex = 27
        '
        'allocateButton
        '
        Me.allocateButton.Location = New System.Drawing.Point(472, 341)
        Me.allocateButton.Name = "allocateButton"
        Me.allocateButton.Size = New System.Drawing.Size(75, 23)
        Me.allocateButton.TabIndex = 28
        Me.allocateButton.Text = "Allocate"
        Me.allocateButton.UseVisualStyleBackColor = True
        '
        'attributeSubmitButton
        '
        Me.attributeSubmitButton.Location = New System.Drawing.Point(472, 392)
        Me.attributeSubmitButton.Name = "attributeSubmitButton"
        Me.attributeSubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.attributeSubmitButton.TabIndex = 29
        Me.attributeSubmitButton.Text = "Submit"
        Me.attributeSubmitButton.UseVisualStyleBackColor = True
        '
        'characterSheetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 478)
        Me.Controls.Add(Me.attributeSubmitButton)
        Me.Controls.Add(Me.allocateButton)
        Me.Controls.Add(Me.rollListBox)
        Me.Controls.Add(Me.attributeListBox)
        Me.Controls.Add(Me.attributeAllocationLabel)
        Me.Controls.Add(Me.rollValueSubmitButton)
        Me.Controls.Add(Me.rollDiceButton)
        Me.Controls.Add(Me.rollThreeTextField)
        Me.Controls.Add(Me.rollTwoTextField)
        Me.Controls.Add(Me.rollOneTextField)
        Me.Controls.Add(Me.statRollLabel)
        Me.Controls.Add(Me.dndLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.classLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.raceLabel)
        Me.Controls.Add(Me.subrace)
        Me.Controls.Add(Me.subraceSubmitButton)
        Me.Controls.Add(Me.woodElfRadioButton)
        Me.Controls.Add(Me.highElfRadioButton)
        Me.Controls.Add(Me.classSubmitButton)
        Me.Controls.Add(Me.monkRadioButton)
        Me.Controls.Add(Me.barbarianRadioButton)
        Me.Controls.Add(Me.fighterRadioButton)
        Me.Controls.Add(Me.raceSubmitButton)
        Me.Controls.Add(Me.tieflingRadioButton)
        Me.Controls.Add(Me.elfRadioButton)
        Me.Controls.Add(Me.humanRadioButton)
        Me.Controls.Add(Me.nameSubmitButton)
        Me.Controls.Add(Me.nameTextField)
        Me.Name = "characterSheetForm"
        Me.Text = "D & D Character Sheet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nameTextField As TextBox
    Friend WithEvents nameSubmitButton As Button
    Friend WithEvents humanRadioButton As RadioButton
    Friend WithEvents elfRadioButton As RadioButton
    Friend WithEvents tieflingRadioButton As RadioButton
    Friend WithEvents raceSubmitButton As Button
    Friend WithEvents fighterRadioButton As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents barbarianRadioButton As RadioButton
    Friend WithEvents monkRadioButton As RadioButton
    Friend WithEvents classSubmitButton As Button
    Friend WithEvents highElfRadioButton As RadioButton
    Friend WithEvents woodElfRadioButton As RadioButton
    Friend WithEvents subraceSubmitButton As Button
    Friend WithEvents subrace As Label
    Friend WithEvents raceLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents classLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dndLabel As Label
    Friend WithEvents statRollLabel As Label
    Friend WithEvents rollOneTextField As TextBox
    Friend WithEvents rollTwoTextField As TextBox
    Friend WithEvents rollThreeTextField As TextBox
    Friend WithEvents rollDiceButton As Button
    Friend WithEvents rollValueSubmitButton As Button
    Friend WithEvents attributeAllocationLabel As Label
    Friend WithEvents attributeListBox As ListBox
    Friend WithEvents rollListBox As ListBox
    Friend WithEvents allocateButton As Button
    Friend WithEvents attributeSubmitButton As Button
End Class
