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
        Me.FinalPlayerClassTextBox = New System.Windows.Forms.TextBox()
        Me.FinalPlayerRaceTextBox = New System.Windows.Forms.TextBox()
        Me.FinalPlayerNameTextBox = New System.Windows.Forms.TextBox()
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
        Me.FinalPlayerNameLabel.Location = New System.Drawing.Point(336, 3)
        Me.FinalPlayerNameLabel.Name = "FinalPlayerNameLabel"
        Me.FinalPlayerNameLabel.Size = New System.Drawing.Size(66, 25)
        Me.FinalPlayerNameLabel.TabIndex = 57
        Me.FinalPlayerNameLabel.Text = "Name:"
        '
        'FinalPlayerRaceLabel
        '
        Me.FinalPlayerRaceLabel.AutoSize = True
        Me.FinalPlayerRaceLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FinalPlayerRaceLabel.Location = New System.Drawing.Point(336, 35)
        Me.FinalPlayerRaceLabel.Name = "FinalPlayerRaceLabel"
        Me.FinalPlayerRaceLabel.Size = New System.Drawing.Size(56, 25)
        Me.FinalPlayerRaceLabel.TabIndex = 58
        Me.FinalPlayerRaceLabel.Text = "Race:"
        '
        'FinalPlayerClassLabel
        '
        Me.FinalPlayerClassLabel.AutoSize = True
        Me.FinalPlayerClassLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FinalPlayerClassLabel.Location = New System.Drawing.Point(336, 67)
        Me.FinalPlayerClassLabel.Name = "FinalPlayerClassLabel"
        Me.FinalPlayerClassLabel.Size = New System.Drawing.Size(59, 25)
        Me.FinalPlayerClassLabel.TabIndex = 59
        Me.FinalPlayerClassLabel.Text = "Class:"
        '
        'FinalPlayerClassTextBox
        '
        Me.FinalPlayerClassTextBox.Enabled = False
        Me.FinalPlayerClassTextBox.Location = New System.Drawing.Point(408, 71)
        Me.FinalPlayerClassTextBox.Name = "FinalPlayerClassTextBox"
        Me.FinalPlayerClassTextBox.Size = New System.Drawing.Size(100, 23)
        Me.FinalPlayerClassTextBox.TabIndex = 62
        '
        'FinalPlayerRaceTextBox
        '
        Me.FinalPlayerRaceTextBox.Enabled = False
        Me.FinalPlayerRaceTextBox.Location = New System.Drawing.Point(408, 37)
        Me.FinalPlayerRaceTextBox.Name = "FinalPlayerRaceTextBox"
        Me.FinalPlayerRaceTextBox.Size = New System.Drawing.Size(100, 23)
        Me.FinalPlayerRaceTextBox.TabIndex = 61
        '
        'FinalPlayerNameTextBox
        '
        Me.FinalPlayerNameTextBox.Enabled = False
        Me.FinalPlayerNameTextBox.Location = New System.Drawing.Point(408, 3)
        Me.FinalPlayerNameTextBox.Name = "FinalPlayerNameTextBox"
        Me.FinalPlayerNameTextBox.Size = New System.Drawing.Size(100, 23)
        Me.FinalPlayerNameTextBox.TabIndex = 60
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
        Me.AttributesGroupBox.Size = New System.Drawing.Size(362, 165)
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
        'FinalCharacterSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AttributesGroupBox)
        Me.Controls.Add(Me.FinalPlayerClassTextBox)
        Me.Controls.Add(Me.FinalPlayerRaceTextBox)
        Me.Controls.Add(Me.FinalPlayerNameTextBox)
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
    Friend WithEvents FinalPlayerClassTextBox As TextBox
    Friend WithEvents FinalPlayerRaceTextBox As TextBox
    Friend WithEvents FinalPlayerNameTextBox As TextBox
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
End Class
