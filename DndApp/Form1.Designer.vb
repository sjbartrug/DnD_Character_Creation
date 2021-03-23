<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CharacterSheetForm
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
        Me.NameTextField = New System.Windows.Forms.TextBox()
        Me.NameSubmitButton = New System.Windows.Forms.Button()
        Me.HumanRadioButton = New System.Windows.Forms.RadioButton()
        Me.ElfRadioButton = New System.Windows.Forms.RadioButton()
        Me.TieflingRadioButton = New System.Windows.Forms.RadioButton()
        Me.RaceSubmitButton = New System.Windows.Forms.Button()
        Me.FighterRadioButton = New System.Windows.Forms.RadioButton()
        Me.BarbarianRadioButton = New System.Windows.Forms.RadioButton()
        Me.MonkRadioButton = New System.Windows.Forms.RadioButton()
        Me.ClassSubmitButton = New System.Windows.Forms.Button()
        Me.HighElfRadioButton = New System.Windows.Forms.RadioButton()
        Me.WoodElfRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubraceSubmitButton = New System.Windows.Forms.Button()
        Me.SubraceLabel = New System.Windows.Forms.Label()
        Me.RaceLabel = New System.Windows.Forms.Label()
        Me.CharacterNameLabel = New System.Windows.Forms.Label()
        Me.ClassLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.StatRollLabel = New System.Windows.Forms.Label()
        Me.rollDiceButton = New System.Windows.Forms.Button()
        Me.rollValueSubmitButton = New System.Windows.Forms.Button()
        Me.AttributeAllocationLabel = New System.Windows.Forms.Label()
        Me.AttributeListBox = New System.Windows.Forms.ListBox()
        Me.RollListBox = New System.Windows.Forms.ListBox()
        Me.AllocateAttributeButton = New System.Windows.Forms.Button()
        Me.FinalizeAttributeButton = New System.Windows.Forms.Button()
        Me.UndoAttributeButton = New System.Windows.Forms.Button()
        Me.CharacterAttributesLabel = New System.Windows.Forms.Label()
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
        Me.AttributeHelpButton = New System.Windows.Forms.PictureBox()
        Me.RaceGroupBox = New System.Windows.Forms.GroupBox()
        Me.SubraceGroupBox = New System.Windows.Forms.GroupBox()
        Me.ClassGroupBox = New System.Windows.Forms.GroupBox()
        Me.ProficientSkillsLabel = New System.Windows.Forms.Label()
        Me.SkillsListBox = New System.Windows.Forms.ListBox()
        Me.AssignedSkillsListBox = New System.Windows.Forms.ListBox()
        Me.UndoSkillsButton = New System.Windows.Forms.Button()
        Me.FinalizeSkillsButton = New System.Windows.Forms.Button()
        Me.AllocateSkillsButton = New System.Windows.Forms.Button()
        Me.DnDLogoImage = New System.Windows.Forms.PictureBox()
        Me.RollThreeTextField = New System.Windows.Forms.TextBox()
        Me.RollTwoTextField = New System.Windows.Forms.TextBox()
        Me.RollOneTextField = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DiceRollGroupBox = New System.Windows.Forms.GroupBox()
        Me.AttributesGroupBox = New System.Windows.Forms.GroupBox()
        Me.NameHelpBox = New System.Windows.Forms.PictureBox()
        Me.RaceHelpBox = New System.Windows.Forms.PictureBox()
        Me.SubraceHelpBox = New System.Windows.Forms.PictureBox()
        Me.ClassHelpBox = New System.Windows.Forms.PictureBox()
        Me.StatHelpBox = New System.Windows.Forms.PictureBox()
        Me.AllocationHelpBox = New System.Windows.Forms.PictureBox()
        Me.ProficienciesHelpBox = New System.Windows.Forms.PictureBox()
        Me.AcidSplashRadioButton = New System.Windows.Forms.RadioButton()
        Me.BladeWardRadioButton = New System.Windows.Forms.RadioButton()
        Me.ChillTouchRadioButton = New System.Windows.Forms.RadioButton()
        Me.DancingLightsRadioButton = New System.Windows.Forms.RadioButton()
        Me.FireBoltRadioButton = New System.Windows.Forms.RadioButton()
        Me.FriendsRadioButton = New System.Windows.Forms.RadioButton()
        Me.LightRadioButton = New System.Windows.Forms.RadioButton()
        Me.MageHandRadioButton = New System.Windows.Forms.RadioButton()
        Me.MendingRadioButton = New System.Windows.Forms.RadioButton()
        Me.MessageRadioButton = New System.Windows.Forms.RadioButton()
        Me.MinorIllusionRadioButton = New System.Windows.Forms.RadioButton()
        Me.PoisonSprayRadioButton = New System.Windows.Forms.RadioButton()
        Me.PrestidigitationRadioButton = New System.Windows.Forms.RadioButton()
        Me.RayofFrostRadioButton = New System.Windows.Forms.RadioButton()
        Me.ShockingGraspRadioButton = New System.Windows.Forms.RadioButton()
        Me.TrueStrikeRadioButton = New System.Windows.Forms.RadioButton()
        Me.HighElfCantripSelectionLabel = New System.Windows.Forms.Label()
        Me.CantripGroupBox = New System.Windows.Forms.GroupBox()
        Me.CantripHelpButton = New System.Windows.Forms.PictureBox()
        Me.FinalSubmitButton = New System.Windows.Forms.Button()
        Me.CantripButton = New System.Windows.Forms.Button()
        CType(Me.AttributeHelpButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RaceGroupBox.SuspendLayout()
        Me.SubraceGroupBox.SuspendLayout()
        Me.ClassGroupBox.SuspendLayout()
        CType(Me.DnDLogoImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DiceRollGroupBox.SuspendLayout()
        Me.AttributesGroupBox.SuspendLayout()
        CType(Me.NameHelpBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RaceHelpBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubraceHelpBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassHelpBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatHelpBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllocationHelpBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProficienciesHelpBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CantripGroupBox.SuspendLayout()
        CType(Me.CantripHelpButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameTextField
        '
        Me.NameTextField.Location = New System.Drawing.Point(12, 169)
        Me.NameTextField.Name = "NameTextField"
        Me.NameTextField.PlaceholderText = "Insert Your Characters Name Here"
        Me.NameTextField.Size = New System.Drawing.Size(208, 23)
        Me.NameTextField.TabIndex = 0
        '
        'NameSubmitButton
        '
        Me.NameSubmitButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.NameSubmitButton.ForeColor = System.Drawing.Color.DarkRed
        Me.NameSubmitButton.Location = New System.Drawing.Point(226, 170)
        Me.NameSubmitButton.Name = "NameSubmitButton"
        Me.NameSubmitButton.Size = New System.Drawing.Size(75, 22)
        Me.NameSubmitButton.TabIndex = 1
        Me.NameSubmitButton.Text = "Submit"
        Me.NameSubmitButton.UseVisualStyleBackColor = False
        '
        'HumanRadioButton
        '
        Me.HumanRadioButton.AutoSize = True
        Me.HumanRadioButton.Location = New System.Drawing.Point(5, 20)
        Me.HumanRadioButton.Name = "HumanRadioButton"
        Me.HumanRadioButton.Size = New System.Drawing.Size(68, 19)
        Me.HumanRadioButton.TabIndex = 2
        Me.HumanRadioButton.Text = "Human "
        Me.HumanRadioButton.UseVisualStyleBackColor = True
        '
        'ElfRadioButton
        '
        Me.ElfRadioButton.AutoSize = True
        Me.ElfRadioButton.Location = New System.Drawing.Point(82, 20)
        Me.ElfRadioButton.Name = "ElfRadioButton"
        Me.ElfRadioButton.Size = New System.Drawing.Size(38, 19)
        Me.ElfRadioButton.TabIndex = 3
        Me.ElfRadioButton.Text = "Elf"
        Me.ElfRadioButton.UseVisualStyleBackColor = True
        '
        'TieflingRadioButton
        '
        Me.TieflingRadioButton.AutoSize = True
        Me.TieflingRadioButton.Location = New System.Drawing.Point(129, 20)
        Me.TieflingRadioButton.Name = "TieflingRadioButton"
        Me.TieflingRadioButton.Size = New System.Drawing.Size(64, 19)
        Me.TieflingRadioButton.TabIndex = 4
        Me.TieflingRadioButton.Text = "Tiefling"
        Me.TieflingRadioButton.UseVisualStyleBackColor = True
        '
        'RaceSubmitButton
        '
        Me.RaceSubmitButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.RaceSubmitButton.ForeColor = System.Drawing.Color.DarkRed
        Me.RaceSubmitButton.Location = New System.Drawing.Point(237, 268)
        Me.RaceSubmitButton.Name = "RaceSubmitButton"
        Me.RaceSubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.RaceSubmitButton.TabIndex = 5
        Me.RaceSubmitButton.Text = "Submit"
        Me.RaceSubmitButton.UseVisualStyleBackColor = False
        Me.RaceSubmitButton.Visible = False
        '
        'FighterRadioButton
        '
        Me.FighterRadioButton.AutoSize = True
        Me.FighterRadioButton.Location = New System.Drawing.Point(157, 20)
        Me.FighterRadioButton.Name = "FighterRadioButton"
        Me.FighterRadioButton.Size = New System.Drawing.Size(62, 19)
        Me.FighterRadioButton.TabIndex = 6
        Me.FighterRadioButton.TabStop = True
        Me.FighterRadioButton.Text = "Fighter"
        Me.FighterRadioButton.UseVisualStyleBackColor = True
        '
        'BarbarianRadioButton
        '
        Me.BarbarianRadioButton.AutoSize = True
        Me.BarbarianRadioButton.Location = New System.Drawing.Point(5, 20)
        Me.BarbarianRadioButton.Name = "BarbarianRadioButton"
        Me.BarbarianRadioButton.Size = New System.Drawing.Size(75, 19)
        Me.BarbarianRadioButton.TabIndex = 7
        Me.BarbarianRadioButton.TabStop = True
        Me.BarbarianRadioButton.Text = "Barbarian"
        Me.BarbarianRadioButton.UseVisualStyleBackColor = True
        '
        'MonkRadioButton
        '
        Me.MonkRadioButton.AutoSize = True
        Me.MonkRadioButton.Location = New System.Drawing.Point(93, 20)
        Me.MonkRadioButton.Name = "MonkRadioButton"
        Me.MonkRadioButton.Size = New System.Drawing.Size(56, 19)
        Me.MonkRadioButton.TabIndex = 8
        Me.MonkRadioButton.TabStop = True
        Me.MonkRadioButton.Text = "Monk"
        Me.MonkRadioButton.UseVisualStyleBackColor = True
        '
        'ClassSubmitButton
        '
        Me.ClassSubmitButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClassSubmitButton.ForeColor = System.Drawing.Color.DarkRed
        Me.ClassSubmitButton.Location = New System.Drawing.Point(248, 492)
        Me.ClassSubmitButton.Name = "ClassSubmitButton"
        Me.ClassSubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.ClassSubmitButton.TabIndex = 9
        Me.ClassSubmitButton.Text = "Submit"
        Me.ClassSubmitButton.UseVisualStyleBackColor = False
        Me.ClassSubmitButton.Visible = False
        '
        'HighElfRadioButton
        '
        Me.HighElfRadioButton.AutoSize = True
        Me.HighElfRadioButton.Location = New System.Drawing.Point(5, 20)
        Me.HighElfRadioButton.Name = "HighElfRadioButton"
        Me.HighElfRadioButton.Size = New System.Drawing.Size(67, 19)
        Me.HighElfRadioButton.TabIndex = 10
        Me.HighElfRadioButton.TabStop = True
        Me.HighElfRadioButton.Text = "High Elf"
        Me.HighElfRadioButton.UseVisualStyleBackColor = True
        '
        'WoodElfRadioButton
        '
        Me.WoodElfRadioButton.AutoSize = True
        Me.WoodElfRadioButton.Location = New System.Drawing.Point(83, 20)
        Me.WoodElfRadioButton.Name = "WoodElfRadioButton"
        Me.WoodElfRadioButton.Size = New System.Drawing.Size(73, 19)
        Me.WoodElfRadioButton.TabIndex = 11
        Me.WoodElfRadioButton.TabStop = True
        Me.WoodElfRadioButton.Text = "Wood Elf"
        Me.WoodElfRadioButton.UseVisualStyleBackColor = True
        '
        'SubraceSubmitButton
        '
        Me.SubraceSubmitButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.SubraceSubmitButton.ForeColor = System.Drawing.Color.DarkRed
        Me.SubraceSubmitButton.Location = New System.Drawing.Point(253, 381)
        Me.SubraceSubmitButton.Name = "SubraceSubmitButton"
        Me.SubraceSubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubraceSubmitButton.TabIndex = 12
        Me.SubraceSubmitButton.Text = "Submit"
        Me.SubraceSubmitButton.UseVisualStyleBackColor = False
        Me.SubraceSubmitButton.Visible = False
        '
        'SubraceLabel
        '
        Me.SubraceLabel.AutoSize = True
        Me.SubraceLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.SubraceLabel.Location = New System.Drawing.Point(81, 325)
        Me.SubraceLabel.Name = "SubraceLabel"
        Me.SubraceLabel.Size = New System.Drawing.Size(120, 32)
        Me.SubraceLabel.TabIndex = 13
        Me.SubraceLabel.Text = "Subrace"
        Me.SubraceLabel.Visible = False
        '
        'RaceLabel
        '
        Me.RaceLabel.AutoSize = True
        Me.RaceLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.RaceLabel.Location = New System.Drawing.Point(5, 216)
        Me.RaceLabel.Name = "RaceLabel"
        Me.RaceLabel.Size = New System.Drawing.Size(78, 32)
        Me.RaceLabel.TabIndex = 14
        Me.RaceLabel.Text = "Race"
        Me.RaceLabel.Visible = False
        '
        'CharacterNameLabel
        '
        Me.CharacterNameLabel.AutoSize = True
        Me.CharacterNameLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.CharacterNameLabel.Location = New System.Drawing.Point(5, 132)
        Me.CharacterNameLabel.Name = "CharacterNameLabel"
        Me.CharacterNameLabel.Size = New System.Drawing.Size(226, 32)
        Me.CharacterNameLabel.TabIndex = 15
        Me.CharacterNameLabel.Text = "Character Name"
        '
        'ClassLabel
        '
        Me.ClassLabel.AutoSize = True
        Me.ClassLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.ClassLabel.Location = New System.Drawing.Point(12, 442)
        Me.ClassLabel.Name = "ClassLabel"
        Me.ClassLabel.Size = New System.Drawing.Size(85, 32)
        Me.ClassLabel.TabIndex = 16
        Me.ClassLabel.Text = "Class"
        Me.ClassLabel.Visible = False
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
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.TitleLabel.Font = New System.Drawing.Font("Bookman Old Style", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.ForeColor = System.Drawing.Color.Red
        Me.TitleLabel.Location = New System.Drawing.Point(337, 28)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(378, 43)
        Me.TitleLabel.TabIndex = 18
        Me.TitleLabel.Text = "Character Creator"
        '
        'StatRollLabel
        '
        Me.StatRollLabel.AutoSize = True
        Me.StatRollLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.StatRollLabel.Location = New System.Drawing.Point(349, 132)
        Me.StatRollLabel.Name = "StatRollLabel"
        Me.StatRollLabel.Size = New System.Drawing.Size(122, 32)
        Me.StatRollLabel.TabIndex = 19
        Me.StatRollLabel.Text = "Stat Roll"
        Me.StatRollLabel.Visible = False
        '
        'rollDiceButton
        '
        Me.rollDiceButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.rollDiceButton.ForeColor = System.Drawing.Color.DarkRed
        Me.rollDiceButton.Location = New System.Drawing.Point(488, 129)
        Me.rollDiceButton.Name = "rollDiceButton"
        Me.rollDiceButton.Size = New System.Drawing.Size(97, 47)
        Me.rollDiceButton.TabIndex = 23
        Me.rollDiceButton.Text = "Roll"
        Me.rollDiceButton.UseVisualStyleBackColor = False
        Me.rollDiceButton.Visible = False
        '
        'rollValueSubmitButton
        '
        Me.rollValueSubmitButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.rollValueSubmitButton.ForeColor = System.Drawing.Color.DarkRed
        Me.rollValueSubmitButton.Location = New System.Drawing.Point(591, 129)
        Me.rollValueSubmitButton.Name = "rollValueSubmitButton"
        Me.rollValueSubmitButton.Size = New System.Drawing.Size(97, 47)
        Me.rollValueSubmitButton.TabIndex = 24
        Me.rollValueSubmitButton.Text = "Submit"
        Me.rollValueSubmitButton.UseVisualStyleBackColor = False
        Me.rollValueSubmitButton.Visible = False
        '
        'AttributeAllocationLabel
        '
        Me.AttributeAllocationLabel.AutoSize = True
        Me.AttributeAllocationLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.AttributeAllocationLabel.Location = New System.Drawing.Point(419, 325)
        Me.AttributeAllocationLabel.Name = "AttributeAllocationLabel"
        Me.AttributeAllocationLabel.Size = New System.Drawing.Size(260, 32)
        Me.AttributeAllocationLabel.TabIndex = 25
        Me.AttributeAllocationLabel.Text = "Attribute Allocation"
        Me.AttributeAllocationLabel.Visible = False
        '
        'AttributeListBox
        '
        Me.AttributeListBox.FormattingEnabled = True
        Me.AttributeListBox.ItemHeight = 15
        Me.AttributeListBox.Items.AddRange(New Object() {"Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma"})
        Me.AttributeListBox.Location = New System.Drawing.Point(559, 360)
        Me.AttributeListBox.Name = "AttributeListBox"
        Me.AttributeListBox.Size = New System.Drawing.Size(97, 154)
        Me.AttributeListBox.TabIndex = 26
        Me.AttributeListBox.Visible = False
        '
        'RollListBox
        '
        Me.RollListBox.FormattingEnabled = True
        Me.RollListBox.ItemHeight = 15
        Me.RollListBox.Location = New System.Drawing.Point(439, 360)
        Me.RollListBox.Name = "RollListBox"
        Me.RollListBox.Size = New System.Drawing.Size(98, 154)
        Me.RollListBox.TabIndex = 27
        Me.RollListBox.Visible = False
        '
        'AllocateAttributeButton
        '
        Me.AllocateAttributeButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.AllocateAttributeButton.ForeColor = System.Drawing.Color.DarkRed
        Me.AllocateAttributeButton.Location = New System.Drawing.Point(671, 384)
        Me.AllocateAttributeButton.Name = "AllocateAttributeButton"
        Me.AllocateAttributeButton.Size = New System.Drawing.Size(75, 23)
        Me.AllocateAttributeButton.TabIndex = 28
        Me.AllocateAttributeButton.Text = "Allocate"
        Me.AllocateAttributeButton.UseVisualStyleBackColor = False
        Me.AllocateAttributeButton.Visible = False
        '
        'FinalizeAttributeButton
        '
        Me.FinalizeAttributeButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.FinalizeAttributeButton.ForeColor = System.Drawing.Color.DarkRed
        Me.FinalizeAttributeButton.Location = New System.Drawing.Point(671, 461)
        Me.FinalizeAttributeButton.Name = "FinalizeAttributeButton"
        Me.FinalizeAttributeButton.Size = New System.Drawing.Size(75, 23)
        Me.FinalizeAttributeButton.TabIndex = 29
        Me.FinalizeAttributeButton.Text = "Finalize"
        Me.FinalizeAttributeButton.UseVisualStyleBackColor = False
        Me.FinalizeAttributeButton.Visible = False
        '
        'UndoAttributeButton
        '
        Me.UndoAttributeButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.UndoAttributeButton.ForeColor = System.Drawing.Color.DarkRed
        Me.UndoAttributeButton.Location = New System.Drawing.Point(671, 423)
        Me.UndoAttributeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UndoAttributeButton.Name = "UndoAttributeButton"
        Me.UndoAttributeButton.Size = New System.Drawing.Size(75, 22)
        Me.UndoAttributeButton.TabIndex = 30
        Me.UndoAttributeButton.Text = "Undo"
        Me.UndoAttributeButton.UseVisualStyleBackColor = False
        Me.UndoAttributeButton.Visible = False
        '
        'CharacterAttributesLabel
        '
        Me.CharacterAttributesLabel.AutoSize = True
        Me.CharacterAttributesLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.CharacterAttributesLabel.Location = New System.Drawing.Point(786, 36)
        Me.CharacterAttributesLabel.Name = "CharacterAttributesLabel"
        Me.CharacterAttributesLabel.Size = New System.Drawing.Size(277, 32)
        Me.CharacterAttributesLabel.TabIndex = 31
        Me.CharacterAttributesLabel.Text = "Character Attributes"
        Me.CharacterAttributesLabel.Visible = False
        '
        'labelStr
        '
        Me.labelStr.AutoSize = True
        Me.labelStr.Location = New System.Drawing.Point(20, 19)
        Me.labelStr.Name = "labelStr"
        Me.labelStr.Size = New System.Drawing.Size(52, 15)
        Me.labelStr.TabIndex = 32
        Me.labelStr.Text = "Strength"
        '
        'labelDex
        '
        Me.labelDex.AutoSize = True
        Me.labelDex.Location = New System.Drawing.Point(147, 19)
        Me.labelDex.Name = "labelDex"
        Me.labelDex.Size = New System.Drawing.Size(54, 15)
        Me.labelDex.TabIndex = 33
        Me.labelDex.Text = "Dexterity"
        '
        'labelCon
        '
        Me.labelCon.AutoSize = True
        Me.labelCon.Location = New System.Drawing.Point(273, 19)
        Me.labelCon.Name = "labelCon"
        Me.labelCon.Size = New System.Drawing.Size(73, 15)
        Me.labelCon.TabIndex = 34
        Me.labelCon.Text = "Constitution"
        '
        'labelInt
        '
        Me.labelInt.AutoSize = True
        Me.labelInt.Location = New System.Drawing.Point(20, 85)
        Me.labelInt.Name = "labelInt"
        Me.labelInt.Size = New System.Drawing.Size(68, 15)
        Me.labelInt.TabIndex = 35
        Me.labelInt.Text = "Intelligence"
        '
        'labelWis
        '
        Me.labelWis.AutoSize = True
        Me.labelWis.Location = New System.Drawing.Point(147, 85)
        Me.labelWis.Name = "labelWis"
        Me.labelWis.Size = New System.Drawing.Size(51, 15)
        Me.labelWis.TabIndex = 36
        Me.labelWis.Text = "Wisdom"
        '
        'labelCha
        '
        Me.labelCha.AutoSize = True
        Me.labelCha.Location = New System.Drawing.Point(273, 85)
        Me.labelCha.Name = "labelCha"
        Me.labelCha.Size = New System.Drawing.Size(57, 15)
        Me.labelCha.TabIndex = 37
        Me.labelCha.Text = "Charisma"
        '
        'labelStrValue
        '
        Me.labelStrValue.AutoSize = True
        Me.labelStrValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelStrValue.Location = New System.Drawing.Point(20, 49)
        Me.labelStrValue.Name = "labelStrValue"
        Me.labelStrValue.Size = New System.Drawing.Size(19, 21)
        Me.labelStrValue.TabIndex = 38
        Me.labelStrValue.Text = "0"
        '
        'labelDexValue
        '
        Me.labelDexValue.AutoSize = True
        Me.labelDexValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelDexValue.Location = New System.Drawing.Point(147, 50)
        Me.labelDexValue.Name = "labelDexValue"
        Me.labelDexValue.Size = New System.Drawing.Size(19, 21)
        Me.labelDexValue.TabIndex = 39
        Me.labelDexValue.Text = "0"
        '
        'labelConValue
        '
        Me.labelConValue.AutoSize = True
        Me.labelConValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelConValue.Location = New System.Drawing.Point(273, 52)
        Me.labelConValue.Name = "labelConValue"
        Me.labelConValue.Size = New System.Drawing.Size(19, 21)
        Me.labelConValue.TabIndex = 40
        Me.labelConValue.Text = "0"
        '
        'labelIntValue
        '
        Me.labelIntValue.AutoSize = True
        Me.labelIntValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelIntValue.Location = New System.Drawing.Point(20, 119)
        Me.labelIntValue.Name = "labelIntValue"
        Me.labelIntValue.Size = New System.Drawing.Size(19, 21)
        Me.labelIntValue.TabIndex = 41
        Me.labelIntValue.Text = "0"
        '
        'labelWisValue
        '
        Me.labelWisValue.AutoSize = True
        Me.labelWisValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelWisValue.Location = New System.Drawing.Point(147, 119)
        Me.labelWisValue.Name = "labelWisValue"
        Me.labelWisValue.Size = New System.Drawing.Size(19, 21)
        Me.labelWisValue.TabIndex = 42
        Me.labelWisValue.Text = "0"
        '
        'labelChaValue
        '
        Me.labelChaValue.AutoSize = True
        Me.labelChaValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelChaValue.Location = New System.Drawing.Point(273, 119)
        Me.labelChaValue.Name = "labelChaValue"
        Me.labelChaValue.Size = New System.Drawing.Size(19, 21)
        Me.labelChaValue.TabIndex = 43
        Me.labelChaValue.Text = "0"
        '
        'AttributeHelpButton
        '
        Me.AttributeHelpButton.BackgroundImage = Global.DndApp.My.Resources.Resources.dndhelpicon
        Me.AttributeHelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AttributeHelpButton.Location = New System.Drawing.Point(1091, 27)
        Me.AttributeHelpButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AttributeHelpButton.Name = "AttributeHelpButton"
        Me.AttributeHelpButton.Size = New System.Drawing.Size(44, 38)
        Me.AttributeHelpButton.TabIndex = 44
        Me.AttributeHelpButton.TabStop = False
        Me.AttributeHelpButton.Visible = False
        '
        'RaceGroupBox
        '
        Me.RaceGroupBox.Controls.Add(Me.HumanRadioButton)
        Me.RaceGroupBox.Controls.Add(Me.ElfRadioButton)
        Me.RaceGroupBox.Controls.Add(Me.TieflingRadioButton)
        Me.RaceGroupBox.Location = New System.Drawing.Point(12, 250)
        Me.RaceGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RaceGroupBox.Name = "RaceGroupBox"
        Me.RaceGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RaceGroupBox.Size = New System.Drawing.Size(219, 53)
        Me.RaceGroupBox.TabIndex = 45
        Me.RaceGroupBox.TabStop = False
        Me.RaceGroupBox.Visible = False
        '
        'SubraceGroupBox
        '
        Me.SubraceGroupBox.Controls.Add(Me.HighElfRadioButton)
        Me.SubraceGroupBox.Controls.Add(Me.WoodElfRadioButton)
        Me.SubraceGroupBox.Location = New System.Drawing.Point(81, 365)
        Me.SubraceGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SubraceGroupBox.Name = "SubraceGroupBox"
        Me.SubraceGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SubraceGroupBox.Size = New System.Drawing.Size(166, 46)
        Me.SubraceGroupBox.TabIndex = 46
        Me.SubraceGroupBox.TabStop = False
        Me.SubraceGroupBox.Visible = False
        '
        'ClassGroupBox
        '
        Me.ClassGroupBox.Controls.Add(Me.BarbarianRadioButton)
        Me.ClassGroupBox.Controls.Add(Me.MonkRadioButton)
        Me.ClassGroupBox.Controls.Add(Me.FighterRadioButton)
        Me.ClassGroupBox.Location = New System.Drawing.Point(12, 476)
        Me.ClassGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClassGroupBox.Name = "ClassGroupBox"
        Me.ClassGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClassGroupBox.Size = New System.Drawing.Size(230, 48)
        Me.ClassGroupBox.TabIndex = 47
        Me.ClassGroupBox.TabStop = False
        Me.ClassGroupBox.Visible = False
        '
        'ProficientSkillsLabel
        '
        Me.ProficientSkillsLabel.AutoSize = True
        Me.ProficientSkillsLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.ProficientSkillsLabel.Location = New System.Drawing.Point(837, 271)
        Me.ProficientSkillsLabel.Name = "ProficientSkillsLabel"
        Me.ProficientSkillsLabel.Size = New System.Drawing.Size(211, 32)
        Me.ProficientSkillsLabel.TabIndex = 48
        Me.ProficientSkillsLabel.Text = "Proficient Skills"
        Me.ProficientSkillsLabel.Visible = False
        '
        'SkillsListBox
        '
        Me.SkillsListBox.FormattingEnabled = True
        Me.SkillsListBox.ItemHeight = 15
        Me.SkillsListBox.Location = New System.Drawing.Point(837, 345)
        Me.SkillsListBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SkillsListBox.Name = "SkillsListBox"
        Me.SkillsListBox.Size = New System.Drawing.Size(97, 124)
        Me.SkillsListBox.TabIndex = 50
        Me.SkillsListBox.Visible = False
        '
        'AssignedSkillsListBox
        '
        Me.AssignedSkillsListBox.FormattingEnabled = True
        Me.AssignedSkillsListBox.ItemHeight = 15
        Me.AssignedSkillsListBox.Location = New System.Drawing.Point(939, 345)
        Me.AssignedSkillsListBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AssignedSkillsListBox.Name = "AssignedSkillsListBox"
        Me.AssignedSkillsListBox.Size = New System.Drawing.Size(97, 124)
        Me.AssignedSkillsListBox.TabIndex = 51
        Me.AssignedSkillsListBox.Visible = False
        '
        'UndoSkillsButton
        '
        Me.UndoSkillsButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.UndoSkillsButton.Enabled = False
        Me.UndoSkillsButton.ForeColor = System.Drawing.Color.DarkRed
        Me.UndoSkillsButton.Location = New System.Drawing.Point(1048, 398)
        Me.UndoSkillsButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UndoSkillsButton.Name = "UndoSkillsButton"
        Me.UndoSkillsButton.Size = New System.Drawing.Size(75, 22)
        Me.UndoSkillsButton.TabIndex = 54
        Me.UndoSkillsButton.Text = "Undo"
        Me.UndoSkillsButton.UseVisualStyleBackColor = False
        Me.UndoSkillsButton.Visible = False
        '
        'FinalizeSkillsButton
        '
        Me.FinalizeSkillsButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.FinalizeSkillsButton.Enabled = False
        Me.FinalizeSkillsButton.ForeColor = System.Drawing.Color.DarkRed
        Me.FinalizeSkillsButton.Location = New System.Drawing.Point(1048, 434)
        Me.FinalizeSkillsButton.Name = "FinalizeSkillsButton"
        Me.FinalizeSkillsButton.Size = New System.Drawing.Size(75, 23)
        Me.FinalizeSkillsButton.TabIndex = 53
        Me.FinalizeSkillsButton.Text = "Finalize"
        Me.FinalizeSkillsButton.UseVisualStyleBackColor = False
        Me.FinalizeSkillsButton.Visible = False
        '
        'AllocateSkillsButton
        '
        Me.AllocateSkillsButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.AllocateSkillsButton.ForeColor = System.Drawing.Color.DarkRed
        Me.AllocateSkillsButton.Location = New System.Drawing.Point(1048, 360)
        Me.AllocateSkillsButton.Name = "AllocateSkillsButton"
        Me.AllocateSkillsButton.Size = New System.Drawing.Size(75, 23)
        Me.AllocateSkillsButton.TabIndex = 52
        Me.AllocateSkillsButton.Text = "Allocate"
        Me.AllocateSkillsButton.UseVisualStyleBackColor = False
        Me.AllocateSkillsButton.Visible = False
        '
        'DnDLogoImage
        '
        Me.DnDLogoImage.Image = Global.DndApp.My.Resources.Resources.Dungeon_and_Dragons_Logo
        Me.DnDLogoImage.Location = New System.Drawing.Point(5, -3)
        Me.DnDLogoImage.Name = "DnDLogoImage"
        Me.DnDLogoImage.Size = New System.Drawing.Size(326, 120)
        Me.DnDLogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.DnDLogoImage.TabIndex = 55
        Me.DnDLogoImage.TabStop = False
        '
        'RollThreeTextField
        '
        Me.RollThreeTextField.Enabled = False
        Me.RollThreeTextField.Location = New System.Drawing.Point(302, 56)
        Me.RollThreeTextField.Name = "RollThreeTextField"
        Me.RollThreeTextField.PlaceholderText = "Roll 3"
        Me.RollThreeTextField.Size = New System.Drawing.Size(58, 23)
        Me.RollThreeTextField.TabIndex = 22
        '
        'RollTwoTextField
        '
        Me.RollTwoTextField.Enabled = False
        Me.RollTwoTextField.Location = New System.Drawing.Point(172, 56)
        Me.RollTwoTextField.Name = "RollTwoTextField"
        Me.RollTwoTextField.PlaceholderText = "Roll 2"
        Me.RollTwoTextField.Size = New System.Drawing.Size(58, 23)
        Me.RollTwoTextField.TabIndex = 21
        '
        'RollOneTextField
        '
        Me.RollOneTextField.Enabled = False
        Me.RollOneTextField.Location = New System.Drawing.Point(29, 56)
        Me.RollOneTextField.Name = "RollOneTextField"
        Me.RollOneTextField.PlaceholderText = "Roll 1"
        Me.RollOneTextField.Size = New System.Drawing.Size(58, 23)
        Me.RollOneTextField.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 15)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "First Valued Rolled"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(144, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 15)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Second Value Rolled"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(283, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 15)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Third Value Rolled"
        '
        'DiceRollGroupBox
        '
        Me.DiceRollGroupBox.Controls.Add(Me.Label7)
        Me.DiceRollGroupBox.Controls.Add(Me.Label6)
        Me.DiceRollGroupBox.Controls.Add(Me.Label5)
        Me.DiceRollGroupBox.Controls.Add(Me.RollOneTextField)
        Me.DiceRollGroupBox.Controls.Add(Me.RollTwoTextField)
        Me.DiceRollGroupBox.Controls.Add(Me.RollThreeTextField)
        Me.DiceRollGroupBox.Location = New System.Drawing.Point(355, 184)
        Me.DiceRollGroupBox.Name = "DiceRollGroupBox"
        Me.DiceRollGroupBox.Size = New System.Drawing.Size(391, 119)
        Me.DiceRollGroupBox.TabIndex = 56
        Me.DiceRollGroupBox.TabStop = False
        Me.DiceRollGroupBox.Visible = False
        '
        'AttributesGroupBox
        '
        Me.AttributesGroupBox.Controls.Add(Me.labelStr)
        Me.AttributesGroupBox.Controls.Add(Me.labelDex)
        Me.AttributesGroupBox.Controls.Add(Me.labelCon)
        Me.AttributesGroupBox.Controls.Add(Me.labelInt)
        Me.AttributesGroupBox.Controls.Add(Me.labelWis)
        Me.AttributesGroupBox.Controls.Add(Me.labelCha)
        Me.AttributesGroupBox.Controls.Add(Me.labelStrValue)
        Me.AttributesGroupBox.Controls.Add(Me.labelDexValue)
        Me.AttributesGroupBox.Controls.Add(Me.labelConValue)
        Me.AttributesGroupBox.Controls.Add(Me.labelIntValue)
        Me.AttributesGroupBox.Controls.Add(Me.labelWisValue)
        Me.AttributesGroupBox.Controls.Add(Me.labelChaValue)
        Me.AttributesGroupBox.Location = New System.Drawing.Point(773, 72)
        Me.AttributesGroupBox.Name = "AttributesGroupBox"
        Me.AttributesGroupBox.Size = New System.Drawing.Size(362, 165)
        Me.AttributesGroupBox.TabIndex = 57
        Me.AttributesGroupBox.TabStop = False
        Me.AttributesGroupBox.Visible = False
        '
        'NameHelpBox
        '
        Me.NameHelpBox.BackgroundImage = Global.DndApp.My.Resources.Resources.dndhelpicon
        Me.NameHelpBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.NameHelpBox.Location = New System.Drawing.Point(237, 127)
        Me.NameHelpBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NameHelpBox.Name = "NameHelpBox"
        Me.NameHelpBox.Size = New System.Drawing.Size(44, 38)
        Me.NameHelpBox.TabIndex = 58
        Me.NameHelpBox.TabStop = False
        '
        'RaceHelpBox
        '
        Me.RaceHelpBox.BackgroundImage = Global.DndApp.My.Resources.Resources.dndhelpicon
        Me.RaceHelpBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RaceHelpBox.Location = New System.Drawing.Point(81, 216)
        Me.RaceHelpBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RaceHelpBox.Name = "RaceHelpBox"
        Me.RaceHelpBox.Size = New System.Drawing.Size(44, 38)
        Me.RaceHelpBox.TabIndex = 59
        Me.RaceHelpBox.TabStop = False
        Me.RaceHelpBox.Visible = False
        '
        'SubraceHelpBox
        '
        Me.SubraceHelpBox.BackgroundImage = Global.DndApp.My.Resources.Resources.dndhelpicon
        Me.SubraceHelpBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SubraceHelpBox.Location = New System.Drawing.Point(207, 319)
        Me.SubraceHelpBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SubraceHelpBox.Name = "SubraceHelpBox"
        Me.SubraceHelpBox.Size = New System.Drawing.Size(44, 38)
        Me.SubraceHelpBox.TabIndex = 60
        Me.SubraceHelpBox.TabStop = False
        Me.SubraceHelpBox.Visible = False
        '
        'ClassHelpBox
        '
        Me.ClassHelpBox.BackgroundImage = Global.DndApp.My.Resources.Resources.dndhelpicon
        Me.ClassHelpBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClassHelpBox.Location = New System.Drawing.Point(103, 436)
        Me.ClassHelpBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClassHelpBox.Name = "ClassHelpBox"
        Me.ClassHelpBox.Size = New System.Drawing.Size(44, 38)
        Me.ClassHelpBox.TabIndex = 61
        Me.ClassHelpBox.TabStop = False
        Me.ClassHelpBox.Visible = False
        '
        'StatHelpBox
        '
        Me.StatHelpBox.BackgroundImage = Global.DndApp.My.Resources.Resources.dndhelpicon
        Me.StatHelpBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.StatHelpBox.Location = New System.Drawing.Point(702, 129)
        Me.StatHelpBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StatHelpBox.Name = "StatHelpBox"
        Me.StatHelpBox.Size = New System.Drawing.Size(44, 38)
        Me.StatHelpBox.TabIndex = 62
        Me.StatHelpBox.TabStop = False
        Me.StatHelpBox.Visible = False
        '
        'AllocationHelpBox
        '
        Me.AllocationHelpBox.BackgroundImage = Global.DndApp.My.Resources.Resources.dndhelpicon
        Me.AllocationHelpBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AllocationHelpBox.Location = New System.Drawing.Point(685, 325)
        Me.AllocationHelpBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AllocationHelpBox.Name = "AllocationHelpBox"
        Me.AllocationHelpBox.Size = New System.Drawing.Size(44, 38)
        Me.AllocationHelpBox.TabIndex = 63
        Me.AllocationHelpBox.TabStop = False
        Me.AllocationHelpBox.Visible = False
        '
        'ProficienciesHelpBox
        '
        Me.ProficienciesHelpBox.BackgroundImage = Global.DndApp.My.Resources.Resources.dndhelpicon
        Me.ProficienciesHelpBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ProficienciesHelpBox.Location = New System.Drawing.Point(1054, 271)
        Me.ProficienciesHelpBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProficienciesHelpBox.Name = "ProficienciesHelpBox"
        Me.ProficienciesHelpBox.Size = New System.Drawing.Size(44, 38)
        Me.ProficienciesHelpBox.TabIndex = 64
        Me.ProficienciesHelpBox.TabStop = False
        Me.ProficienciesHelpBox.Visible = False
        '
        'AcidSplashRadioButton
        '
        Me.AcidSplashRadioButton.AutoSize = True
        Me.AcidSplashRadioButton.Checked = True
        Me.AcidSplashRadioButton.Location = New System.Drawing.Point(6, 26)
        Me.AcidSplashRadioButton.Name = "AcidSplashRadioButton"
        Me.AcidSplashRadioButton.Size = New System.Drawing.Size(86, 19)
        Me.AcidSplashRadioButton.TabIndex = 65
        Me.AcidSplashRadioButton.TabStop = True
        Me.AcidSplashRadioButton.Text = "Acid Splash"
        Me.AcidSplashRadioButton.UseVisualStyleBackColor = True
        '
        'BladeWardRadioButton
        '
        Me.BladeWardRadioButton.AutoSize = True
        Me.BladeWardRadioButton.Location = New System.Drawing.Point(6, 64)
        Me.BladeWardRadioButton.Name = "BladeWardRadioButton"
        Me.BladeWardRadioButton.Size = New System.Drawing.Size(85, 19)
        Me.BladeWardRadioButton.TabIndex = 66
        Me.BladeWardRadioButton.Text = "Blade Ward"
        Me.BladeWardRadioButton.UseVisualStyleBackColor = True
        '
        'ChillTouchRadioButton
        '
        Me.ChillTouchRadioButton.AutoSize = True
        Me.ChillTouchRadioButton.Location = New System.Drawing.Point(6, 102)
        Me.ChillTouchRadioButton.Name = "ChillTouchRadioButton"
        Me.ChillTouchRadioButton.Size = New System.Drawing.Size(84, 19)
        Me.ChillTouchRadioButton.TabIndex = 67
        Me.ChillTouchRadioButton.Text = "Chill Touch"
        Me.ChillTouchRadioButton.UseVisualStyleBackColor = True
        '
        'DancingLightsRadioButton
        '
        Me.DancingLightsRadioButton.AutoSize = True
        Me.DancingLightsRadioButton.Location = New System.Drawing.Point(6, 140)
        Me.DancingLightsRadioButton.Name = "DancingLightsRadioButton"
        Me.DancingLightsRadioButton.Size = New System.Drawing.Size(104, 19)
        Me.DancingLightsRadioButton.TabIndex = 68
        Me.DancingLightsRadioButton.Text = "Dancing Lights"
        Me.DancingLightsRadioButton.UseVisualStyleBackColor = True
        '
        'FireBoltRadioButton
        '
        Me.FireBoltRadioButton.AutoSize = True
        Me.FireBoltRadioButton.Location = New System.Drawing.Point(6, 178)
        Me.FireBoltRadioButton.Name = "FireBoltRadioButton"
        Me.FireBoltRadioButton.Size = New System.Drawing.Size(68, 19)
        Me.FireBoltRadioButton.TabIndex = 69
        Me.FireBoltRadioButton.Text = "Fire Bolt"
        Me.FireBoltRadioButton.UseVisualStyleBackColor = True
        '
        'FriendsRadioButton
        '
        Me.FriendsRadioButton.AutoSize = True
        Me.FriendsRadioButton.Location = New System.Drawing.Point(6, 216)
        Me.FriendsRadioButton.Name = "FriendsRadioButton"
        Me.FriendsRadioButton.Size = New System.Drawing.Size(63, 19)
        Me.FriendsRadioButton.TabIndex = 70
        Me.FriendsRadioButton.Text = "Friends"
        Me.FriendsRadioButton.UseVisualStyleBackColor = True
        '
        'LightRadioButton
        '
        Me.LightRadioButton.AutoSize = True
        Me.LightRadioButton.Location = New System.Drawing.Point(6, 254)
        Me.LightRadioButton.Name = "LightRadioButton"
        Me.LightRadioButton.Size = New System.Drawing.Size(52, 19)
        Me.LightRadioButton.TabIndex = 71
        Me.LightRadioButton.Text = "Light"
        Me.LightRadioButton.UseVisualStyleBackColor = True
        '
        'MageHandRadioButton
        '
        Me.MageHandRadioButton.AutoSize = True
        Me.MageHandRadioButton.Location = New System.Drawing.Point(6, 292)
        Me.MageHandRadioButton.Name = "MageHandRadioButton"
        Me.MageHandRadioButton.Size = New System.Drawing.Size(87, 19)
        Me.MageHandRadioButton.TabIndex = 72
        Me.MageHandRadioButton.Text = "Mage Hand"
        Me.MageHandRadioButton.UseVisualStyleBackColor = True
        '
        'MendingRadioButton
        '
        Me.MendingRadioButton.AutoSize = True
        Me.MendingRadioButton.Location = New System.Drawing.Point(114, 45)
        Me.MendingRadioButton.Name = "MendingRadioButton"
        Me.MendingRadioButton.Size = New System.Drawing.Size(73, 19)
        Me.MendingRadioButton.TabIndex = 73
        Me.MendingRadioButton.Text = "Mending"
        Me.MendingRadioButton.UseVisualStyleBackColor = True
        '
        'MessageRadioButton
        '
        Me.MessageRadioButton.AutoSize = True
        Me.MessageRadioButton.Location = New System.Drawing.Point(116, 83)
        Me.MessageRadioButton.Name = "MessageRadioButton"
        Me.MessageRadioButton.Size = New System.Drawing.Size(71, 19)
        Me.MessageRadioButton.TabIndex = 74
        Me.MessageRadioButton.Text = "Message"
        Me.MessageRadioButton.UseVisualStyleBackColor = True
        '
        'MinorIllusionRadioButton
        '
        Me.MinorIllusionRadioButton.AutoSize = True
        Me.MinorIllusionRadioButton.Location = New System.Drawing.Point(116, 121)
        Me.MinorIllusionRadioButton.Name = "MinorIllusionRadioButton"
        Me.MinorIllusionRadioButton.Size = New System.Drawing.Size(98, 19)
        Me.MinorIllusionRadioButton.TabIndex = 75
        Me.MinorIllusionRadioButton.Text = "Minor Illusion"
        Me.MinorIllusionRadioButton.UseVisualStyleBackColor = True
        '
        'PoisonSprayRadioButton
        '
        Me.PoisonSprayRadioButton.AutoSize = True
        Me.PoisonSprayRadioButton.Location = New System.Drawing.Point(116, 159)
        Me.PoisonSprayRadioButton.Name = "PoisonSprayRadioButton"
        Me.PoisonSprayRadioButton.Size = New System.Drawing.Size(93, 19)
        Me.PoisonSprayRadioButton.TabIndex = 76
        Me.PoisonSprayRadioButton.Text = "Posion Spray"
        Me.PoisonSprayRadioButton.UseVisualStyleBackColor = True
        '
        'PrestidigitationRadioButton
        '
        Me.PrestidigitationRadioButton.AutoSize = True
        Me.PrestidigitationRadioButton.Location = New System.Drawing.Point(116, 197)
        Me.PrestidigitationRadioButton.Name = "PrestidigitationRadioButton"
        Me.PrestidigitationRadioButton.Size = New System.Drawing.Size(105, 19)
        Me.PrestidigitationRadioButton.TabIndex = 77
        Me.PrestidigitationRadioButton.Text = "Prestidigitation"
        Me.PrestidigitationRadioButton.UseVisualStyleBackColor = True
        '
        'RayofFrostRadioButton
        '
        Me.RayofFrostRadioButton.AutoSize = True
        Me.RayofFrostRadioButton.Location = New System.Drawing.Point(116, 235)
        Me.RayofFrostRadioButton.Name = "RayofFrostRadioButton"
        Me.RayofFrostRadioButton.Size = New System.Drawing.Size(87, 19)
        Me.RayofFrostRadioButton.TabIndex = 78
        Me.RayofFrostRadioButton.Text = "Ray of Frost"
        Me.RayofFrostRadioButton.UseVisualStyleBackColor = True
        '
        'ShockingGraspRadioButton
        '
        Me.ShockingGraspRadioButton.AutoSize = True
        Me.ShockingGraspRadioButton.Location = New System.Drawing.Point(116, 273)
        Me.ShockingGraspRadioButton.Name = "ShockingGraspRadioButton"
        Me.ShockingGraspRadioButton.Size = New System.Drawing.Size(107, 19)
        Me.ShockingGraspRadioButton.TabIndex = 79
        Me.ShockingGraspRadioButton.Text = "Shocking Grasp"
        Me.ShockingGraspRadioButton.UseVisualStyleBackColor = True
        '
        'TrueStrikeRadioButton
        '
        Me.TrueStrikeRadioButton.AutoSize = True
        Me.TrueStrikeRadioButton.Location = New System.Drawing.Point(116, 311)
        Me.TrueStrikeRadioButton.Name = "TrueStrikeRadioButton"
        Me.TrueStrikeRadioButton.Size = New System.Drawing.Size(79, 19)
        Me.TrueStrikeRadioButton.TabIndex = 80
        Me.TrueStrikeRadioButton.Text = "True Strike"
        Me.TrueStrikeRadioButton.UseVisualStyleBackColor = True
        '
        'HighElfCantripSelectionLabel
        '
        Me.HighElfCantripSelectionLabel.AutoSize = True
        Me.HighElfCantripSelectionLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.HighElfCantripSelectionLabel.Location = New System.Drawing.Point(1163, 27)
        Me.HighElfCantripSelectionLabel.Name = "HighElfCantripSelectionLabel"
        Me.HighElfCantripSelectionLabel.Size = New System.Drawing.Size(223, 32)
        Me.HighElfCantripSelectionLabel.TabIndex = 81
        Me.HighElfCantripSelectionLabel.Text = "High Elf Cantrip"
        Me.HighElfCantripSelectionLabel.Visible = False
        '
        'CantripGroupBox
        '
        Me.CantripGroupBox.Controls.Add(Me.ChillTouchRadioButton)
        Me.CantripGroupBox.Controls.Add(Me.AcidSplashRadioButton)
        Me.CantripGroupBox.Controls.Add(Me.MendingRadioButton)
        Me.CantripGroupBox.Controls.Add(Me.TrueStrikeRadioButton)
        Me.CantripGroupBox.Controls.Add(Me.BladeWardRadioButton)
        Me.CantripGroupBox.Controls.Add(Me.ShockingGraspRadioButton)
        Me.CantripGroupBox.Controls.Add(Me.DancingLightsRadioButton)
        Me.CantripGroupBox.Controls.Add(Me.RayofFrostRadioButton)
        Me.CantripGroupBox.Controls.Add(Me.FireBoltRadioButton)
        Me.CantripGroupBox.Controls.Add(Me.PrestidigitationRadioButton)
        Me.CantripGroupBox.Controls.Add(Me.FriendsRadioButton)
        Me.CantripGroupBox.Controls.Add(Me.PoisonSprayRadioButton)
        Me.CantripGroupBox.Controls.Add(Me.LightRadioButton)
        Me.CantripGroupBox.Controls.Add(Me.MinorIllusionRadioButton)
        Me.CantripGroupBox.Controls.Add(Me.MessageRadioButton)
        Me.CantripGroupBox.Controls.Add(Me.MageHandRadioButton)
        Me.CantripGroupBox.Location = New System.Drawing.Point(1165, 72)
        Me.CantripGroupBox.Name = "CantripGroupBox"
        Me.CantripGroupBox.Size = New System.Drawing.Size(236, 339)
        Me.CantripGroupBox.TabIndex = 82
        Me.CantripGroupBox.TabStop = False
        Me.CantripGroupBox.Visible = False
        '
        'CantripHelpButton
        '
        Me.CantripHelpButton.BackgroundImage = Global.DndApp.My.Resources.Resources.dndhelpicon
        Me.CantripHelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CantripHelpButton.Location = New System.Drawing.Point(1407, 27)
        Me.CantripHelpButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CantripHelpButton.Name = "CantripHelpButton"
        Me.CantripHelpButton.Size = New System.Drawing.Size(44, 38)
        Me.CantripHelpButton.TabIndex = 83
        Me.CantripHelpButton.TabStop = False
        Me.CantripHelpButton.Visible = False
        '
        'FinalSubmitButton
        '
        Me.FinalSubmitButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.FinalSubmitButton.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FinalSubmitButton.ForeColor = System.Drawing.Color.DarkRed
        Me.FinalSubmitButton.Location = New System.Drawing.Point(1163, 479)
        Me.FinalSubmitButton.Name = "FinalSubmitButton"
        Me.FinalSubmitButton.Size = New System.Drawing.Size(266, 53)
        Me.FinalSubmitButton.TabIndex = 84
        Me.FinalSubmitButton.Text = "Submit Form"
        Me.FinalSubmitButton.UseVisualStyleBackColor = False
        Me.FinalSubmitButton.Visible = False
        '
        'CantripButton
        '
        Me.CantripButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.CantripButton.ForeColor = System.Drawing.Color.DarkRed
        Me.CantripButton.Location = New System.Drawing.Point(1237, 417)
        Me.CantripButton.Name = "CantripButton"
        Me.CantripButton.Size = New System.Drawing.Size(75, 23)
        Me.CantripButton.TabIndex = 85
        Me.CantripButton.Text = "Finalize"
        Me.CantripButton.UseVisualStyleBackColor = False
        Me.CantripButton.Visible = False
        '
        'CharacterSheetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1478, 541)
        Me.Controls.Add(Me.CantripButton)
        Me.Controls.Add(Me.FinalSubmitButton)
        Me.Controls.Add(Me.CantripHelpButton)
        Me.Controls.Add(Me.CantripGroupBox)
        Me.Controls.Add(Me.HighElfCantripSelectionLabel)
        Me.Controls.Add(Me.ProficienciesHelpBox)
        Me.Controls.Add(Me.AllocationHelpBox)
        Me.Controls.Add(Me.StatHelpBox)
        Me.Controls.Add(Me.ClassHelpBox)
        Me.Controls.Add(Me.SubraceHelpBox)
        Me.Controls.Add(Me.RaceHelpBox)
        Me.Controls.Add(Me.NameHelpBox)
        Me.Controls.Add(Me.AttributesGroupBox)
        Me.Controls.Add(Me.DiceRollGroupBox)
        Me.Controls.Add(Me.DnDLogoImage)
        Me.Controls.Add(Me.UndoSkillsButton)
        Me.Controls.Add(Me.FinalizeSkillsButton)
        Me.Controls.Add(Me.AllocateSkillsButton)
        Me.Controls.Add(Me.AssignedSkillsListBox)
        Me.Controls.Add(Me.SkillsListBox)
        Me.Controls.Add(Me.ProficientSkillsLabel)
        Me.Controls.Add(Me.ClassGroupBox)
        Me.Controls.Add(Me.SubraceGroupBox)
        Me.Controls.Add(Me.RaceGroupBox)
        Me.Controls.Add(Me.AttributeHelpButton)
        Me.Controls.Add(Me.CharacterAttributesLabel)
        Me.Controls.Add(Me.UndoAttributeButton)
        Me.Controls.Add(Me.FinalizeAttributeButton)
        Me.Controls.Add(Me.AllocateAttributeButton)
        Me.Controls.Add(Me.RollListBox)
        Me.Controls.Add(Me.AttributeListBox)
        Me.Controls.Add(Me.AttributeAllocationLabel)
        Me.Controls.Add(Me.rollValueSubmitButton)
        Me.Controls.Add(Me.rollDiceButton)
        Me.Controls.Add(Me.StatRollLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ClassLabel)
        Me.Controls.Add(Me.CharacterNameLabel)
        Me.Controls.Add(Me.RaceLabel)
        Me.Controls.Add(Me.SubraceLabel)
        Me.Controls.Add(Me.SubraceSubmitButton)
        Me.Controls.Add(Me.ClassSubmitButton)
        Me.Controls.Add(Me.RaceSubmitButton)
        Me.Controls.Add(Me.NameSubmitButton)
        Me.Controls.Add(Me.NameTextField)
        Me.Name = "CharacterSheetForm"
        Me.Text = "D&D Character Creation"
        CType(Me.AttributeHelpButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RaceGroupBox.ResumeLayout(False)
        Me.RaceGroupBox.PerformLayout()
        Me.SubraceGroupBox.ResumeLayout(False)
        Me.SubraceGroupBox.PerformLayout()
        Me.ClassGroupBox.ResumeLayout(False)
        Me.ClassGroupBox.PerformLayout()
        CType(Me.DnDLogoImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DiceRollGroupBox.ResumeLayout(False)
        Me.DiceRollGroupBox.PerformLayout()
        Me.AttributesGroupBox.ResumeLayout(False)
        Me.AttributesGroupBox.PerformLayout()
        CType(Me.NameHelpBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RaceHelpBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubraceHelpBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassHelpBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatHelpBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllocationHelpBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProficienciesHelpBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CantripGroupBox.ResumeLayout(False)
        Me.CantripGroupBox.PerformLayout()
        CType(Me.CantripHelpButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameTextField As TextBox
    Friend WithEvents NameSubmitButton As Button
    Friend WithEvents HumanRadioButton As RadioButton
    Friend WithEvents ElfRadioButton As RadioButton
    Friend WithEvents TieflingRadioButton As RadioButton
    Friend WithEvents RaceSubmitButton As Button
    Friend WithEvents FighterRadioButton As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents BarbarianRadioButton As RadioButton
    Friend WithEvents MonkRadioButton As RadioButton
    Friend WithEvents ClassSubmitButton As Button
    Friend WithEvents HighElfRadioButton As RadioButton
    Friend WithEvents WoodElfRadioButton As RadioButton
    Friend WithEvents SubraceSubmitButton As Button
    Friend WithEvents SubraceLabel As Label
    Friend WithEvents RaceLabel As Label
    Friend WithEvents CharacterNameLabel As Label
    Friend WithEvents ClassLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents StatRollLabel As Label
    Friend WithEvents rollDiceButton As Button
    Friend WithEvents rollValueSubmitButton As Button
    Friend WithEvents AttributeAllocationLabel As Label
    Friend WithEvents AttributeListBox As ListBox
    Friend WithEvents RollListBox As ListBox
    Friend WithEvents AllocateAttributeButton As Button
    Friend WithEvents FinalizeAttributeButton As Button
    Friend WithEvents UndoAttributeButton As Button
    Friend WithEvents CharacterAttributesLabel As Label
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
    Friend WithEvents AttributeHelpButton As PictureBox
    Friend WithEvents RaceGroupBox As GroupBox
    Friend WithEvents SubraceGroupBox As GroupBox
    Friend WithEvents ClassGroupBox As GroupBox
    Friend WithEvents ProficientSkillsLabel As Label
    Friend WithEvents SkillsListBox As ListBox
    Friend WithEvents AssignedSkillsListBox As ListBox
    Friend WithEvents UndoSkillsButton As Button
    Friend WithEvents FinalizeSkillsButton As Button
    Friend WithEvents AllocateSkillsButton As Button
    Friend WithEvents DnDLogoImage As PictureBox
    Friend WithEvents RollThreeTextField As TextBox
    Friend WithEvents RollTwoTextField As TextBox
    Friend WithEvents RollOneTextField As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DiceRollGroupBox As GroupBox
    Friend WithEvents AttributesGroupBox As GroupBox
    Friend WithEvents NameHelpBox As PictureBox
    Friend WithEvents RaceHelpBox As PictureBox
    Friend WithEvents SubraceHelpBox As PictureBox
    Friend WithEvents ClassHelpBox As PictureBox
    Friend WithEvents StatHelpBox As PictureBox
    Friend WithEvents AllocationHelpBox As PictureBox
    Friend WithEvents ProficienciesHelpBox As PictureBox
    Friend WithEvents AcidSplashRadioButton As RadioButton
    Friend WithEvents BladeWardRadioButton As RadioButton
    Friend WithEvents ChillTouchRadioButton As RadioButton
    Friend WithEvents DancingLightsRadioButton As RadioButton
    Friend WithEvents FireBoltRadioButton As RadioButton
    Friend WithEvents FriendsRadioButton As RadioButton
    Friend WithEvents LightRadioButton As RadioButton
    Friend WithEvents MageHandRadioButton As RadioButton
    Friend WithEvents MendingRadioButton As RadioButton
    Friend WithEvents MessageRadioButton As RadioButton
    Friend WithEvents MinorIllusionRadioButton As RadioButton
    Friend WithEvents PoisonSprayRadioButton As RadioButton
    Friend WithEvents PrestidigitationRadioButton As RadioButton
    Friend WithEvents RayofFrostRadioButton As RadioButton
    Friend WithEvents ShockingGraspRadioButton As RadioButton
    Friend WithEvents TrueStrikeRadioButton As RadioButton
    Friend WithEvents HighElfCantripSelectionLabel As Label
    Friend WithEvents CantripGroupBox As GroupBox
    Friend WithEvents CantripHelpButton As PictureBox
    Friend WithEvents FinalSubmitButton As Button
    Friend WithEvents CantripButton As Button
End Class
