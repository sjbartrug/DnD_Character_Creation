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
		Me.attributeFinalizeButton = New System.Windows.Forms.Button()
		Me.buttonUndoAllocation = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.labelStr = New System.Windows.Forms.Label()
		Me.labelDex = New System.Windows.Forms.Label()
		Me.labelCon = New System.Windows.Forms.Label()
		Me.labelInt = New System.Windows.Forms.Label()
		Me.labelWis = New System.Windows.Forms.Label()
		Me.labelCha = New System.Windows.Forms.Label()
		Me.labelStrValue = New System.Windows.Forms.Label()
		Me.labelDexValue = New System.Windows.Forms.Label()
		Me.labelConValue = New System.Windows.Forms.Label()
		Me.labelIntValue = New System.Windows.Forms.Label()
		Me.labelWisValue = New System.Windows.Forms.Label()
		Me.labelChaValue = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'nameTextField
		'
		Me.nameTextField.Location = New System.Drawing.Point(14, 151)
		Me.nameTextField.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.nameTextField.Name = "nameTextField"
		Me.nameTextField.PlaceholderText = "Insert Name Here"
		Me.nameTextField.Size = New System.Drawing.Size(237, 27)
		Me.nameTextField.TabIndex = 0
		'
		'nameSubmitButton
		'
		Me.nameSubmitButton.Location = New System.Drawing.Point(275, 152)
		Me.nameSubmitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.nameSubmitButton.Name = "nameSubmitButton"
		Me.nameSubmitButton.Size = New System.Drawing.Size(86, 29)
		Me.nameSubmitButton.TabIndex = 1
		Me.nameSubmitButton.Text = "Submit"
		Me.nameSubmitButton.UseVisualStyleBackColor = True
		'
		'humanRadioButton
		'
		Me.humanRadioButton.AutoSize = True
		Me.humanRadioButton.Location = New System.Drawing.Point(14, 273)
		Me.humanRadioButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.humanRadioButton.Name = "humanRadioButton"
		Me.humanRadioButton.Size = New System.Drawing.Size(82, 24)
		Me.humanRadioButton.TabIndex = 2
		Me.humanRadioButton.TabStop = True
		Me.humanRadioButton.Text = "Human "
		Me.humanRadioButton.UseVisualStyleBackColor = True
		'
		'elfRadioButton
		'
		Me.elfRadioButton.AutoSize = True
		Me.elfRadioButton.Location = New System.Drawing.Point(119, 273)
		Me.elfRadioButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.elfRadioButton.Name = "elfRadioButton"
		Me.elfRadioButton.Size = New System.Drawing.Size(47, 24)
		Me.elfRadioButton.TabIndex = 3
		Me.elfRadioButton.TabStop = True
		Me.elfRadioButton.Text = "Elf"
		Me.elfRadioButton.UseVisualStyleBackColor = True
		'
		'tieflingRadioButton
		'
		Me.tieflingRadioButton.AutoSize = True
		Me.tieflingRadioButton.Location = New System.Drawing.Point(178, 271)
		Me.tieflingRadioButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.tieflingRadioButton.Name = "tieflingRadioButton"
		Me.tieflingRadioButton.Size = New System.Drawing.Size(80, 24)
		Me.tieflingRadioButton.TabIndex = 4
		Me.tieflingRadioButton.TabStop = True
		Me.tieflingRadioButton.Text = "Tiefling"
		Me.tieflingRadioButton.UseVisualStyleBackColor = True
		'
		'raceSubmitButton
		'
		Me.raceSubmitButton.Location = New System.Drawing.Point(275, 271)
		Me.raceSubmitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.raceSubmitButton.Name = "raceSubmitButton"
		Me.raceSubmitButton.Size = New System.Drawing.Size(86, 31)
		Me.raceSubmitButton.TabIndex = 5
		Me.raceSubmitButton.Text = "Submit"
		Me.raceSubmitButton.UseVisualStyleBackColor = True
		'
		'fighterRadioButton
		'
		Me.fighterRadioButton.AutoSize = True
		Me.fighterRadioButton.Location = New System.Drawing.Point(169, 545)
		Me.fighterRadioButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.fighterRadioButton.Name = "fighterRadioButton"
		Me.fighterRadioButton.Size = New System.Drawing.Size(76, 24)
		Me.fighterRadioButton.TabIndex = 6
		Me.fighterRadioButton.TabStop = True
		Me.fighterRadioButton.Text = "Fighter"
		Me.fighterRadioButton.UseVisualStyleBackColor = True
		'
		'barbarianRadioButton
		'
		Me.barbarianRadioButton.AutoSize = True
		Me.barbarianRadioButton.Location = New System.Drawing.Point(14, 545)
		Me.barbarianRadioButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.barbarianRadioButton.Name = "barbarianRadioButton"
		Me.barbarianRadioButton.Size = New System.Drawing.Size(94, 24)
		Me.barbarianRadioButton.TabIndex = 7
		Me.barbarianRadioButton.TabStop = True
		Me.barbarianRadioButton.Text = "Barbarian"
		Me.barbarianRadioButton.UseVisualStyleBackColor = True
		'
		'monkRadioButton
		'
		Me.monkRadioButton.AutoSize = True
		Me.monkRadioButton.Location = New System.Drawing.Point(98, 545)
		Me.monkRadioButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.monkRadioButton.Name = "monkRadioButton"
		Me.monkRadioButton.Size = New System.Drawing.Size(67, 24)
		Me.monkRadioButton.TabIndex = 8
		Me.monkRadioButton.TabStop = True
		Me.monkRadioButton.Text = "Monk"
		Me.monkRadioButton.UseVisualStyleBackColor = True
		'
		'classSubmitButton
		'
		Me.classSubmitButton.Location = New System.Drawing.Point(275, 540)
		Me.classSubmitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.classSubmitButton.Name = "classSubmitButton"
		Me.classSubmitButton.Size = New System.Drawing.Size(86, 31)
		Me.classSubmitButton.TabIndex = 9
		Me.classSubmitButton.Text = "Submit"
		Me.classSubmitButton.UseVisualStyleBackColor = True
		'
		'highElfRadioButton
		'
		Me.highElfRadioButton.AutoSize = True
		Me.highElfRadioButton.Location = New System.Drawing.Point(40, 413)
		Me.highElfRadioButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.highElfRadioButton.Name = "highElfRadioButton"
		Me.highElfRadioButton.Size = New System.Drawing.Size(83, 24)
		Me.highElfRadioButton.TabIndex = 10
		Me.highElfRadioButton.TabStop = True
		Me.highElfRadioButton.Text = "High Elf"
		Me.highElfRadioButton.UseVisualStyleBackColor = True
		'
		'woodElfRadioButton
		'
		Me.woodElfRadioButton.AutoSize = True
		Me.woodElfRadioButton.Location = New System.Drawing.Point(141, 411)
		Me.woodElfRadioButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.woodElfRadioButton.Name = "woodElfRadioButton"
		Me.woodElfRadioButton.Size = New System.Drawing.Size(91, 24)
		Me.woodElfRadioButton.TabIndex = 11
		Me.woodElfRadioButton.TabStop = True
		Me.woodElfRadioButton.Text = "Wood Elf"
		Me.woodElfRadioButton.UseVisualStyleBackColor = True
		'
		'subraceSubmitButton
		'
		Me.subraceSubmitButton.Location = New System.Drawing.Point(275, 408)
		Me.subraceSubmitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.subraceSubmitButton.Name = "subraceSubmitButton"
		Me.subraceSubmitButton.Size = New System.Drawing.Size(86, 31)
		Me.subraceSubmitButton.TabIndex = 12
		Me.subraceSubmitButton.Text = "Submit"
		Me.subraceSubmitButton.UseVisualStyleBackColor = True
		'
		'subrace
		'
		Me.subrace.AutoSize = True
		Me.subrace.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
		Me.subrace.Location = New System.Drawing.Point(63, 337)
		Me.subrace.Name = "subrace"
		Me.subrace.Size = New System.Drawing.Size(148, 38)
		Me.subrace.TabIndex = 13
		Me.subrace.Text = "Subrace"
		'
		'raceLabel
		'
		Me.raceLabel.AutoSize = True
		Me.raceLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
		Me.raceLabel.Location = New System.Drawing.Point(88, 209)
		Me.raceLabel.Name = "raceLabel"
		Me.raceLabel.Size = New System.Drawing.Size(95, 38)
		Me.raceLabel.TabIndex = 14
		Me.raceLabel.Text = "Race"
		'
		'nameLabel
		'
		Me.nameLabel.AutoSize = True
		Me.nameLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
		Me.nameLabel.Location = New System.Drawing.Point(88, 89)
		Me.nameLabel.Name = "nameLabel"
		Me.nameLabel.Size = New System.Drawing.Size(108, 38)
		Me.nameLabel.TabIndex = 15
		Me.nameLabel.Text = "Name"
		'
		'classLabel
		'
		Me.classLabel.AutoSize = True
		Me.classLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
		Me.classLabel.Location = New System.Drawing.Point(73, 481)
		Me.classLabel.Name = "classLabel"
		Me.classLabel.Size = New System.Drawing.Size(108, 38)
		Me.classLabel.TabIndex = 16
		Me.classLabel.Text = "Class"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
		Me.Label1.Location = New System.Drawing.Point(6, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(0, 22)
		Me.Label1.TabIndex = 17
		'
		'dndLabel
		'
		Me.dndLabel.AutoSize = True
		Me.dndLabel.Cursor = System.Windows.Forms.Cursors.Default
		Me.dndLabel.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
		Me.dndLabel.Location = New System.Drawing.Point(6, 12)
		Me.dndLabel.Name = "dndLabel"
		Me.dndLabel.Size = New System.Drawing.Size(257, 24)
		Me.dndLabel.TabIndex = 18
		Me.dndLabel.Text = "Dungeons And Dragons"
		'
		'statRollLabel
		'
		Me.statRollLabel.AutoSize = True
		Me.statRollLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
		Me.statRollLabel.Location = New System.Drawing.Point(521, 49)
		Me.statRollLabel.Name = "statRollLabel"
		Me.statRollLabel.Size = New System.Drawing.Size(151, 38)
		Me.statRollLabel.TabIndex = 19
		Me.statRollLabel.Text = "Stat Roll"
		'
		'rollOneTextField
		'
		Me.rollOneTextField.Location = New System.Drawing.Point(486, 152)
		Me.rollOneTextField.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.rollOneTextField.Name = "rollOneTextField"
		Me.rollOneTextField.PlaceholderText = "Roll 1"
		Me.rollOneTextField.Size = New System.Drawing.Size(66, 27)
		Me.rollOneTextField.TabIndex = 20
		'
		'rollTwoTextField
		'
		Me.rollTwoTextField.Location = New System.Drawing.Point(559, 153)
		Me.rollTwoTextField.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.rollTwoTextField.Name = "rollTwoTextField"
		Me.rollTwoTextField.PlaceholderText = "Roll 2"
		Me.rollTwoTextField.Size = New System.Drawing.Size(66, 27)
		Me.rollTwoTextField.TabIndex = 21
		'
		'rollThreeTextField
		'
		Me.rollThreeTextField.Location = New System.Drawing.Point(632, 153)
		Me.rollThreeTextField.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.rollThreeTextField.Name = "rollThreeTextField"
		Me.rollThreeTextField.PlaceholderText = "Roll 3"
		Me.rollThreeTextField.Size = New System.Drawing.Size(66, 27)
		Me.rollThreeTextField.TabIndex = 22
		'
		'rollDiceButton
		'
		Me.rollDiceButton.Location = New System.Drawing.Point(559, 101)
		Me.rollDiceButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.rollDiceButton.Name = "rollDiceButton"
		Me.rollDiceButton.Size = New System.Drawing.Size(66, 31)
		Me.rollDiceButton.TabIndex = 23
		Me.rollDiceButton.Text = "Roll"
		Me.rollDiceButton.UseVisualStyleBackColor = True
		'
		'rollValueSubmitButton
		'
		Me.rollValueSubmitButton.Location = New System.Drawing.Point(722, 153)
		Me.rollValueSubmitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.rollValueSubmitButton.Name = "rollValueSubmitButton"
		Me.rollValueSubmitButton.Size = New System.Drawing.Size(86, 31)
		Me.rollValueSubmitButton.TabIndex = 24
		Me.rollValueSubmitButton.Text = "Submit"
		Me.rollValueSubmitButton.UseVisualStyleBackColor = True
		'
		'attributeAllocationLabel
		'
		Me.attributeAllocationLabel.AutoSize = True
		Me.attributeAllocationLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
		Me.attributeAllocationLabel.Location = New System.Drawing.Point(446, 225)
		Me.attributeAllocationLabel.Name = "attributeAllocationLabel"
		Me.attributeAllocationLabel.Size = New System.Drawing.Size(321, 38)
		Me.attributeAllocationLabel.TabIndex = 25
		Me.attributeAllocationLabel.Text = "Attribute Allocation"
		'
		'attributeListBox
		'
		Me.attributeListBox.FormattingEnabled = True
		Me.attributeListBox.ItemHeight = 20
		Me.attributeListBox.Items.AddRange(New Object() {"Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma"})
		Me.attributeListBox.Location = New System.Drawing.Point(601, 295)
		Me.attributeListBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.attributeListBox.Name = "attributeListBox"
		Me.attributeListBox.Size = New System.Drawing.Size(86, 124)
		Me.attributeListBox.TabIndex = 26
		'
		'rollListBox
		'
		Me.rollListBox.FormattingEnabled = True
		Me.rollListBox.ItemHeight = 20
		Me.rollListBox.Location = New System.Drawing.Point(486, 295)
		Me.rollListBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.rollListBox.Name = "rollListBox"
		Me.rollListBox.Size = New System.Drawing.Size(85, 124)
		Me.rollListBox.TabIndex = 27
		'
		'allocateButton
		'
		Me.allocateButton.Location = New System.Drawing.Point(485, 456)
		Me.allocateButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.allocateButton.Name = "allocateButton"
		Me.allocateButton.Size = New System.Drawing.Size(86, 31)
		Me.allocateButton.TabIndex = 28
		Me.allocateButton.Text = "Allocate"
		Me.allocateButton.UseVisualStyleBackColor = True
		'
		'attributeFinalizeButton
		'
		Me.attributeFinalizeButton.Location = New System.Drawing.Point(539, 513)
		Me.attributeFinalizeButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.attributeFinalizeButton.Name = "attributeFinalizeButton"
		Me.attributeFinalizeButton.Size = New System.Drawing.Size(86, 31)
		Me.attributeFinalizeButton.TabIndex = 29
		Me.attributeFinalizeButton.Text = "Finalize"
		Me.attributeFinalizeButton.UseVisualStyleBackColor = True
		'
		'buttonUndoAllocation
		'
		Me.buttonUndoAllocation.Location = New System.Drawing.Point(593, 458)
		Me.buttonUndoAllocation.Name = "buttonUndoAllocation"
		Me.buttonUndoAllocation.Size = New System.Drawing.Size(94, 29)
		Me.buttonUndoAllocation.TabIndex = 30
		Me.buttonUndoAllocation.Text = "Undo"
		Me.buttonUndoAllocation.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
		Me.Label2.Location = New System.Drawing.Point(859, 49)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(343, 38)
		Me.Label2.TabIndex = 31
		Me.Label2.Text = "Character Attributes"
		'
		'labelStr
		'
		Me.labelStr.AutoSize = True
		Me.labelStr.Location = New System.Drawing.Point(859, 112)
		Me.labelStr.Name = "labelStr"
		Me.labelStr.Size = New System.Drawing.Size(65, 20)
		Me.labelStr.TabIndex = 32
		Me.labelStr.Text = "Strength"
		'
		'labelDex
		'
		Me.labelDex.AutoSize = True
		Me.labelDex.Location = New System.Drawing.Point(1005, 112)
		Me.labelDex.Name = "labelDex"
		Me.labelDex.Size = New System.Drawing.Size(69, 20)
		Me.labelDex.TabIndex = 33
		Me.labelDex.Text = "Dexterity"
		'
		'labelCon
		'
		Me.labelCon.AutoSize = True
		Me.labelCon.Location = New System.Drawing.Point(1149, 112)
		Me.labelCon.Name = "labelCon"
		Me.labelCon.Size = New System.Drawing.Size(89, 20)
		Me.labelCon.TabIndex = 34
		Me.labelCon.Text = "Constitution"
		'
		'labelInt
		'
		Me.labelInt.AutoSize = True
		Me.labelInt.Location = New System.Drawing.Point(859, 200)
		Me.labelInt.Name = "labelInt"
		Me.labelInt.Size = New System.Drawing.Size(86, 20)
		Me.labelInt.TabIndex = 35
		Me.labelInt.Text = "Intelligence"
		'
		'labelWis
		'
		Me.labelWis.AutoSize = True
		Me.labelWis.Location = New System.Drawing.Point(1005, 200)
		Me.labelWis.Name = "labelWis"
		Me.labelWis.Size = New System.Drawing.Size(64, 20)
		Me.labelWis.TabIndex = 36
		Me.labelWis.Text = "Wisdom"
		'
		'labelCha
		'
		Me.labelCha.AutoSize = True
		Me.labelCha.Location = New System.Drawing.Point(1149, 200)
		Me.labelCha.Name = "labelCha"
		Me.labelCha.Size = New System.Drawing.Size(70, 20)
		Me.labelCha.TabIndex = 37
		Me.labelCha.Text = "Charisma"
		'
		'labelStrValue
		'
		Me.labelStrValue.AutoSize = True
		Me.labelStrValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.labelStrValue.Location = New System.Drawing.Point(859, 152)
		Me.labelStrValue.Name = "labelStrValue"
		Me.labelStrValue.Size = New System.Drawing.Size(23, 28)
		Me.labelStrValue.TabIndex = 38
		Me.labelStrValue.Text = "0"
		'
		'labelDexValue
		'
		Me.labelDexValue.AutoSize = True
		Me.labelDexValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.labelDexValue.Location = New System.Drawing.Point(1005, 153)
		Me.labelDexValue.Name = "labelDexValue"
		Me.labelDexValue.Size = New System.Drawing.Size(23, 28)
		Me.labelDexValue.TabIndex = 39
		Me.labelDexValue.Text = "0"
		'
		'labelConValue
		'
		Me.labelConValue.AutoSize = True
		Me.labelConValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.labelConValue.Location = New System.Drawing.Point(1149, 156)
		Me.labelConValue.Name = "labelConValue"
		Me.labelConValue.Size = New System.Drawing.Size(23, 28)
		Me.labelConValue.TabIndex = 40
		Me.labelConValue.Text = "0"
		'
		'labelIntValue
		'
		Me.labelIntValue.AutoSize = True
		Me.labelIntValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.labelIntValue.Location = New System.Drawing.Point(859, 245)
		Me.labelIntValue.Name = "labelIntValue"
		Me.labelIntValue.Size = New System.Drawing.Size(23, 28)
		Me.labelIntValue.TabIndex = 41
		Me.labelIntValue.Text = "0"
		'
		'labelWisValue
		'
		Me.labelWisValue.AutoSize = True
		Me.labelWisValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.labelWisValue.Location = New System.Drawing.Point(1005, 245)
		Me.labelWisValue.Name = "labelWisValue"
		Me.labelWisValue.Size = New System.Drawing.Size(23, 28)
		Me.labelWisValue.TabIndex = 42
		Me.labelWisValue.Text = "0"
		'
		'labelChaValue
		'
		Me.labelChaValue.AutoSize = True
		Me.labelChaValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.labelChaValue.Location = New System.Drawing.Point(1149, 245)
		Me.labelChaValue.Name = "labelChaValue"
		Me.labelChaValue.Size = New System.Drawing.Size(23, 28)
		Me.labelChaValue.TabIndex = 43
		Me.labelChaValue.Text = "0"
		'
		'characterSheetForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1280, 637)
		Me.Controls.Add(Me.labelChaValue)
		Me.Controls.Add(Me.labelWisValue)
		Me.Controls.Add(Me.labelIntValue)
		Me.Controls.Add(Me.labelConValue)
		Me.Controls.Add(Me.labelDexValue)
		Me.Controls.Add(Me.labelStrValue)
		Me.Controls.Add(Me.labelCha)
		Me.Controls.Add(Me.labelWis)
		Me.Controls.Add(Me.labelInt)
		Me.Controls.Add(Me.labelCon)
		Me.Controls.Add(Me.labelDex)
		Me.Controls.Add(Me.labelStr)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.buttonUndoAllocation)
		Me.Controls.Add(Me.attributeFinalizeButton)
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
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "characterSheetForm"
		Me.Text = "Character Attributes"
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
    Friend WithEvents attributeFinalizeButton As Button
	Friend WithEvents buttonUndoAllocation As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents labelStr As Label
	Friend WithEvents labelDex As Label
	Friend WithEvents labelCon As Label
	Friend WithEvents labelInt As Label
	Friend WithEvents labelWis As Label
	Friend WithEvents labelCha As Label
	Friend WithEvents labelStrValue As Label
	Friend WithEvents labelDexValue As Label
	Friend WithEvents labelConValue As Label
	Friend WithEvents labelIntValue As Label
	Friend WithEvents labelWisValue As Label
	Friend WithEvents labelChaValue As Label
End Class
