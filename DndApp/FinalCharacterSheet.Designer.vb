<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalCharacterSheet
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
        Me.DnDLogoImage = New System.Windows.Forms.PictureBox()
        Me.FinalPlayerNameLabel = New System.Windows.Forms.Label()
        Me.FinalPlayerRaceLabel = New System.Windows.Forms.Label()
        Me.FinalPlayerClassLabel = New System.Windows.Forms.Label()
        Me.AttributesGroupBox = New System.Windows.Forms.GroupBox()
        Me.labelStr = New System.Windows.Forms.Label()
        Me.labelDex = New System.Windows.Forms.Label()
        Me.labelCon = New System.Windows.Forms.Label()
        Me.labelInt = New System.Windows.Forms.Label()
        Me.labelWis = New System.Windows.Forms.Label()
        Me.labelCha = New System.Windows.Forms.Label()
        Me.FinallabelStrValue = New System.Windows.Forms.Label()
        Me.FinallabelDexValue = New System.Windows.Forms.Label()
        Me.FinallabelConValue = New System.Windows.Forms.Label()
        Me.FinallabelIntValue = New System.Windows.Forms.Label()
        Me.FinallabelWisValue = New System.Windows.Forms.Label()
        Me.FinallabelChaValue = New System.Windows.Forms.Label()
        Me.FinalAssignedSkillsListBox = New System.Windows.Forms.ListBox()
        Me.FinalProficienciesLabel = New System.Windows.Forms.Label()
        Me.CantripLabel = New System.Windows.Forms.Label()
        Me.PlayerNameLabel = New System.Windows.Forms.Label()
        Me.PlayerRaceLabel = New System.Windows.Forms.Label()
        Me.PlayerClassLabel = New System.Windows.Forms.Label()
        Me.SpellLabel = New System.Windows.Forms.Label()
        CType(Me.DnDLogoImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AttributesGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DnDLogoImage
        '
        Me.DnDLogoImage.Image = Global.DndApp.My.Resources.Resources.Dungeon_and_Dragons_Logo
        Me.DnDLogoImage.Location = New System.Drawing.Point(3, 3)
        Me.DnDLogoImage.Name = "DnDLogoImage"
        Me.DnDLogoImage.Size = New System.Drawing.Size(326, 120)
        Me.DnDLogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.DnDLogoImage.TabIndex = 56
        Me.DnDLogoImage.TabStop = False
        '
        'FinalPlayerNameLabel
        '
        Me.FinalPlayerNameLabel.AutoSize = True
        Me.FinalPlayerNameLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FinalPlayerNameLabel.Location = New System.Drawing.Point(335, 11)
        Me.FinalPlayerNameLabel.Name = "FinalPlayerNameLabel"
        Me.FinalPlayerNameLabel.Size = New System.Drawing.Size(66, 25)
        Me.FinalPlayerNameLabel.TabIndex = 57
        Me.FinalPlayerNameLabel.Text = "Name:"
        '
        'FinalPlayerRaceLabel
        '
        Me.FinalPlayerRaceLabel.AutoSize = True
        Me.FinalPlayerRaceLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FinalPlayerRaceLabel.Location = New System.Drawing.Point(345, 43)
        Me.FinalPlayerRaceLabel.Name = "FinalPlayerRaceLabel"
        Me.FinalPlayerRaceLabel.Size = New System.Drawing.Size(56, 25)
        Me.FinalPlayerRaceLabel.TabIndex = 58
        Me.FinalPlayerRaceLabel.Text = "Race:"
        '
        'FinalPlayerClassLabel
        '
        Me.FinalPlayerClassLabel.AutoSize = True
        Me.FinalPlayerClassLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FinalPlayerClassLabel.Location = New System.Drawing.Point(342, 75)
        Me.FinalPlayerClassLabel.Name = "FinalPlayerClassLabel"
        Me.FinalPlayerClassLabel.Size = New System.Drawing.Size(59, 25)
        Me.FinalPlayerClassLabel.TabIndex = 59
        Me.FinalPlayerClassLabel.Text = "Class:"
        '
        'AttributesGroupBox
        '
        Me.AttributesGroupBox.Controls.Add(Me.labelStr)
        Me.AttributesGroupBox.Controls.Add(Me.labelDex)
        Me.AttributesGroupBox.Controls.Add(Me.labelCon)
        Me.AttributesGroupBox.Controls.Add(Me.labelInt)
        Me.AttributesGroupBox.Controls.Add(Me.labelWis)
        Me.AttributesGroupBox.Controls.Add(Me.labelCha)
        Me.AttributesGroupBox.Controls.Add(Me.FinallabelStrValue)
        Me.AttributesGroupBox.Controls.Add(Me.FinallabelDexValue)
        Me.AttributesGroupBox.Controls.Add(Me.FinallabelConValue)
        Me.AttributesGroupBox.Controls.Add(Me.FinallabelIntValue)
        Me.AttributesGroupBox.Controls.Add(Me.FinallabelWisValue)
        Me.AttributesGroupBox.Controls.Add(Me.FinallabelChaValue)
        Me.AttributesGroupBox.Location = New System.Drawing.Point(12, 129)
        Me.AttributesGroupBox.Name = "AttributesGroupBox"
        Me.AttributesGroupBox.Size = New System.Drawing.Size(389, 165)
        Me.AttributesGroupBox.TabIndex = 63
        Me.AttributesGroupBox.TabStop = False
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
        'FinallabelStrValue
        '
        Me.FinallabelStrValue.AutoSize = True
        Me.FinallabelStrValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FinallabelStrValue.Location = New System.Drawing.Point(20, 49)
        Me.FinallabelStrValue.Name = "FinallabelStrValue"
        Me.FinallabelStrValue.Size = New System.Drawing.Size(19, 21)
        Me.FinallabelStrValue.TabIndex = 38
        Me.FinallabelStrValue.Text = "0"
        '
        'FinallabelDexValue
        '
        Me.FinallabelDexValue.AutoSize = True
        Me.FinallabelDexValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FinallabelDexValue.Location = New System.Drawing.Point(147, 50)
        Me.FinallabelDexValue.Name = "FinallabelDexValue"
        Me.FinallabelDexValue.Size = New System.Drawing.Size(19, 21)
        Me.FinallabelDexValue.TabIndex = 39
        Me.FinallabelDexValue.Text = "0"
        '
        'FinallabelConValue
        '
        Me.FinallabelConValue.AutoSize = True
        Me.FinallabelConValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FinallabelConValue.Location = New System.Drawing.Point(273, 52)
        Me.FinallabelConValue.Name = "FinallabelConValue"
        Me.FinallabelConValue.Size = New System.Drawing.Size(19, 21)
        Me.FinallabelConValue.TabIndex = 40
        Me.FinallabelConValue.Text = "0"
        '
        'FinallabelIntValue
        '
        Me.FinallabelIntValue.AutoSize = True
        Me.FinallabelIntValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FinallabelIntValue.Location = New System.Drawing.Point(20, 119)
        Me.FinallabelIntValue.Name = "FinallabelIntValue"
        Me.FinallabelIntValue.Size = New System.Drawing.Size(19, 21)
        Me.FinallabelIntValue.TabIndex = 41
        Me.FinallabelIntValue.Text = "0"
        '
        'FinallabelWisValue
        '
        Me.FinallabelWisValue.AutoSize = True
        Me.FinallabelWisValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FinallabelWisValue.Location = New System.Drawing.Point(147, 119)
        Me.FinallabelWisValue.Name = "FinallabelWisValue"
        Me.FinallabelWisValue.Size = New System.Drawing.Size(19, 21)
        Me.FinallabelWisValue.TabIndex = 42
        Me.FinallabelWisValue.Text = "0"
        '
        'FinallabelChaValue
        '
        Me.FinallabelChaValue.AutoSize = True
        Me.FinallabelChaValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FinallabelChaValue.Location = New System.Drawing.Point(273, 119)
        Me.FinallabelChaValue.Name = "FinallabelChaValue"
        Me.FinallabelChaValue.Size = New System.Drawing.Size(19, 21)
        Me.FinallabelChaValue.TabIndex = 43
        Me.FinallabelChaValue.Text = "0"
        '
        'FinalAssignedSkillsListBox
        '
        Me.FinalAssignedSkillsListBox.FormattingEnabled = True
        Me.FinalAssignedSkillsListBox.ItemHeight = 15
        Me.FinalAssignedSkillsListBox.Location = New System.Drawing.Point(12, 360)
        Me.FinalAssignedSkillsListBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FinalAssignedSkillsListBox.Name = "FinalAssignedSkillsListBox"
        Me.FinalAssignedSkillsListBox.Size = New System.Drawing.Size(221, 79)
        Me.FinalAssignedSkillsListBox.TabIndex = 64
        '
        'FinalProficienciesLabel
        '
        Me.FinalProficienciesLabel.AutoSize = True
        Me.FinalProficienciesLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FinalProficienciesLabel.Location = New System.Drawing.Point(12, 326)
        Me.FinalProficienciesLabel.Name = "FinalProficienciesLabel"
        Me.FinalProficienciesLabel.Size = New System.Drawing.Size(119, 21)
        Me.FinalProficienciesLabel.TabIndex = 65
        Me.FinalProficienciesLabel.Text = "Proficient Skills:"
        '
        'CantripLabel
        '
        Me.CantripLabel.AutoSize = True
        Me.CantripLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CantripLabel.Location = New System.Drawing.Point(262, 377)
        Me.CantripLabel.Name = "CantripLabel"
        Me.CantripLabel.Size = New System.Drawing.Size(85, 30)
        Me.CantripLabel.TabIndex = 66
        Me.CantripLabel.Text = "Cantrip:"
        Me.CantripLabel.Visible = False
        '
        'PlayerNameLabel
        '
        Me.PlayerNameLabel.AutoSize = True
        Me.PlayerNameLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PlayerNameLabel.Location = New System.Drawing.Point(408, 11)
        Me.PlayerNameLabel.Name = "PlayerNameLabel"
        Me.PlayerNameLabel.Size = New System.Drawing.Size(0, 25)
        Me.PlayerNameLabel.TabIndex = 68
        '
        'PlayerRaceLabel
        '
        Me.PlayerRaceLabel.AutoSize = True
        Me.PlayerRaceLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PlayerRaceLabel.Location = New System.Drawing.Point(408, 43)
        Me.PlayerRaceLabel.Name = "PlayerRaceLabel"
        Me.PlayerRaceLabel.Size = New System.Drawing.Size(0, 25)
        Me.PlayerRaceLabel.TabIndex = 69
        '
        'PlayerClassLabel
        '
        Me.PlayerClassLabel.AutoSize = True
        Me.PlayerClassLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PlayerClassLabel.Location = New System.Drawing.Point(408, 75)
        Me.PlayerClassLabel.Name = "PlayerClassLabel"
        Me.PlayerClassLabel.Size = New System.Drawing.Size(0, 25)
        Me.PlayerClassLabel.TabIndex = 70
        '
        'SpellLabel
        '
        Me.SpellLabel.AutoSize = True
        Me.SpellLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SpellLabel.Location = New System.Drawing.Point(353, 382)
        Me.SpellLabel.Name = "SpellLabel"
        Me.SpellLabel.Size = New System.Drawing.Size(0, 25)
        Me.SpellLabel.TabIndex = 71
        '
        'FinalCharacterSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 450)
        Me.Controls.Add(Me.SpellLabel)
        Me.Controls.Add(Me.PlayerClassLabel)
        Me.Controls.Add(Me.PlayerRaceLabel)
        Me.Controls.Add(Me.PlayerNameLabel)
        Me.Controls.Add(Me.CantripLabel)
        Me.Controls.Add(Me.FinalProficienciesLabel)
        Me.Controls.Add(Me.FinalAssignedSkillsListBox)
        Me.Controls.Add(Me.AttributesGroupBox)
        Me.Controls.Add(Me.FinalPlayerClassLabel)
        Me.Controls.Add(Me.FinalPlayerRaceLabel)
        Me.Controls.Add(Me.FinalPlayerNameLabel)
        Me.Controls.Add(Me.DnDLogoImage)
        Me.Name = "FinalCharacterSheet"
        Me.Text = "CharacterSheet"
        CType(Me.DnDLogoImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AttributesGroupBox.ResumeLayout(False)
        Me.AttributesGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DnDLogoImage As PictureBox
    Friend WithEvents FinalPlayerNameLabel As Label
    Friend WithEvents FinalPlayerRaceLabel As Label
    Friend WithEvents FinalPlayerClassLabel As Label
    Friend WithEvents AttributesGroupBox As GroupBox
    Friend WithEvents labelStr As Label
    Friend WithEvents labelDex As Label
    Friend WithEvents labelCon As Label
    Friend WithEvents labelInt As Label
    Friend WithEvents labelWis As Label
    Friend WithEvents labelCha As Label
    Friend WithEvents FinallabelStrValue As Label
    Friend WithEvents FinallabelDexValue As Label
    Friend WithEvents FinallabelConValue As Label
    Friend WithEvents FinallabelIntValue As Label
    Friend WithEvents FinallabelWisValue As Label
    Friend WithEvents FinallabelChaValue As Label
    Friend WithEvents FinalAssignedSkillsListBox As ListBox
    Friend WithEvents FinalProficienciesLabel As Label
    Friend WithEvents CantripLabel As Label
    Friend WithEvents PlayerNameLabel As Label
    Friend WithEvents PlayerRaceLabel As Label
    Friend WithEvents PlayerClassLabel As Label
    Friend WithEvents SpellLabel As Label
End Class
