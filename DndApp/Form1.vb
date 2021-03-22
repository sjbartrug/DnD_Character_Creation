Public Class CharacterSheetForm

    ' Constants
    Const DIE_ROLLS_TOTAL As Integer = 6

    ' Class-level variables
    Dim CharacterName As String
    Dim CharacterRace As Integer
    Dim CharacterClass As Integer
    Dim StrMod As Integer
    Dim DexMod As Integer
    Dim ConMod As Integer
    Dim IntMod As Integer
    Dim WisMod As Integer
    Dim ChaMod As Integer
    Dim characterProficiencyBonus As Integer = L1_PROFICIENCY_BONUS
    Dim currentDieRollCount As Integer = 0
    Dim currentDieSum As Integer
    Dim dieRollSums As New List(Of Integer)
    Dim lastAssignedAttributeStack As New Stack(Of AssignedAttribute)
    Dim lastAssignedSkillStack As New Stack(Of AssignedProficiencies)
    Dim finalizedAttributes(NUM_OF_ATTRIBUTES) As Integer
    Dim savingThrows(NUM_OF_ATTRIBUTES) As Integer
    Dim skillProficiencies(NUM_OF_SKILLS) As Boolean
    Dim lastAssignedSkill As New Stack(Of String)

    Private Sub CharacterSheetForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub NameSubmitButton_Click(sender As Object, e As EventArgs) Handles NameSubmitButton.Click
        If (NameTextField.Text IsNot "") Then
            CharacterName = NameTextField.Text
            NameTextField.Enabled = False
            NameSubmitButton.Enabled = False 'Disable this action once it's finalized
            RaceLabel.Visible = True
            RaceGroupBox.Visible = True
            RaceSubmitButton.Visible = True
            RaceHelpBox.Visible = True
        End If

    End Sub

    Private Sub RaceSubmitButton_Click(sender As Object, e As EventArgs) Handles RaceSubmitButton.Click
        If ElfRadioButton.Checked = True Then
            SubraceLabel.Visible = True
            SubraceGroupBox.Visible = True
            SubraceSubmitButton.Visible = True
            SubraceHelpBox.Visible = True

        ElseIf TieflingRadioButton.Checked = True Then
            CharacterRace = DndRace.TIEFLING
            ClassLabel.Visible = True
            ClassGroupBox.Visible = True
            ClassSubmitButton.Visible = True
            RaceSubmitButton.Enabled = False
            RaceGroupBox.Enabled = False
            ClassHelpBox.Visible = True

        ElseIf HumanRadioButton.Checked = True Then
            CharacterRace = DndRace.HUMAN
            ClassLabel.Visible = True
            ClassGroupBox.Visible = True
            ClassSubmitButton.Visible = True
            RaceSubmitButton.Enabled = False
            RaceGroupBox.Enabled = False
            ClassHelpBox.Visible = True
        End If

    End Sub

    Private Sub SubraceSubmitButton_Click(sender As Object, e As EventArgs) Handles SubraceSubmitButton.Click
        If HighElfRadioButton.Checked = True Then
            CharacterRace = DndRace.HIGH_ELF
        Else
            CharacterRace = DndRace.WOOD_ELF
        End If

        If (HighElfRadioButton.Checked = True Or WoodElfRadioButton.Checked = True) Then
            SubraceGroupBox.Enabled = False
            SubraceSubmitButton.Enabled = False
            ClassLabel.Visible = True
            ClassGroupBox.Visible = True
            ClassSubmitButton.Visible = True
            ClassHelpBox.Visible = True
        End If
    End Sub

    Private Sub ClassSubmitButton_Click(sender As Object, e As EventArgs) Handles ClassSubmitButton.Click
        If BarbarianRadioButton.Checked = True Then
            CharacterClass = DndClass.BARBARIAN
        ElseIf MonkRadioButton.Checked = True Then
            CharacterClass = DndClass.MONK
        ElseIf FighterRadioButton.Checked = True Then
            CharacterClass = DndClass.FIGHTER
        End If

        If BarbarianRadioButton.Checked = True Or MonkRadioButton.Checked = True Or FighterRadioButton.Checked = True Then
            ClassGroupBox.Enabled = False
            ClassSubmitButton.Enabled = False
            StatRollLabel.Visible = True
            rollDiceButton.Visible = True
            DiceRollGroupBox.Visible = True
            rollValueSubmitButton.Visible = True
            rollValueSubmitButton.Enabled = False
            StatHelpBox.Visible = True
        End If

    End Sub

    Private Sub RollDiceButton_Click(sender As Object, e As EventArgs) Handles rollDiceButton.Click
        Dim firstDieRoll As Integer
        Dim secondDieRoll As Integer
        Dim thirdDieRoll As Integer

        firstDieRoll = RollDndDice(DndDice.ONE_D_SIX) ' Calls (random.nextInt(6) + 1)
        secondDieRoll = RollDndDice(DndDice.ONE_D_SIX)
        thirdDieRoll = RollDndDice(DndDice.ONE_D_SIX)
        RollOneTextField.Text = firstDieRoll.ToString()
        RollTwoTextField.Text = secondDieRoll.ToString()
        RollThreeTextField.Text = thirdDieRoll.ToString()

        currentDieSum = firstDieRoll + secondDieRoll + thirdDieRoll

        rollValueSubmitButton.Enabled = True 'Enable the submit button
        rollDiceButton.Enabled = False 'Don't allow a reroll until the current roll is submitted
        If currentDieRollCount = 0 Then
            AttributeAllocationLabel.Visible = True
            RollListBox.Visible = True
        End If
    End Sub

    Private Sub RollValueSubmitButton_Click(sender As Object, e As EventArgs) Handles rollValueSubmitButton.Click
        rollValueSubmitButton.Enabled = False

        dieRollSums.Add(currentDieSum) 'Add the sum of the last three die rolls to the list and list box
        RollListBox.Items.Add(dieRollSums.Item(currentDieRollCount).ToString())

        currentDieRollCount += 1 'Keep track of die rolls

        RollOneTextField.Clear() 'Clear the text fields for the next die rolls
        RollTwoTextField.Clear()
        RollThreeTextField.Clear()

        ' In VB, <> means not equal to
        If currentDieRollCount <> DIE_ROLLS_TOTAL Then
            rollDiceButton.Enabled = True 'If 6 rolls have not been made, allow another roll
        Else
            AllocateAttributeButton.Visible = True 'Once 6 rolls are made, enable the allocate button in the next section
            AttributeListBox.Visible = True
            AttributesGroupBox.Visible = True
            CharacterAttributesLabel.Visible = True
            RollListBox.SelectedIndex = 0 'And select the first indices of both lists
            AttributeListBox.SelectedIndex = 0
            AllocationHelpBox.Visible = True
        End If
    End Sub

    Private Sub AllocateAttributeButton_Click(sender As Object, e As EventArgs) Handles AllocateAttributeButton.Click
        ' Keep track of the currently assigned attribute name, point value, and their indices on their lists
        Dim selectedAttributeIndex As Integer = AttributeListBox.SelectedIndex
        Dim selectedAttributeName As String = AttributeListBox.Items(selectedAttributeIndex).ToString()
        Dim selectedRollIndex As Integer = RollListBox.SelectedIndex
        Dim selectedRollValue As Integer = dieRollSums.Item(selectedRollIndex)

        ' Push this data onto a stack to enable easy reversal of actions
        lastAssignedAttributeStack.Push(New AssignedAttribute(selectedAttributeIndex, selectedAttributeName,
                                                         selectedRollIndex, dieRollSums.Item(selectedRollIndex)))

        'Find the name of the currently assigned attribute And set its points label to the assigned value
        Select Case selectedAttributeName
            Case "Strength"
                labelStrValue.Text = (selectedRollValue + GetRacialBonus(CharacterRace, DndAttribute.STRENGTH))
                StrMod = Convert.ToInt32(((selectedRollValue + GetRacialBonus(CharacterRace, DndAttribute.STRENGTH)) - 10) / 2)
            Case "Dexterity"
                labelDexValue.Text = (selectedRollValue + GetRacialBonus(CharacterRace, DndAttribute.DEXTERITY))
                DexMod = Convert.ToInt32(((selectedRollValue + GetRacialBonus(CharacterRace, DndAttribute.DEXTERITY)) - 10) / 2)
            Case "Constitution"
                labelConValue.Text = (selectedRollValue + GetRacialBonus(CharacterRace, DndAttribute.CONSTITUTION))
                ConMod = Convert.ToInt32(((selectedRollValue + GetRacialBonus(CharacterRace, DndAttribute.CONSTITUTION)) - 10) / 2)
            Case "Intelligence"
                labelIntValue.Text = (selectedRollValue + GetRacialBonus(CharacterRace, DndAttribute.INTELLIGENCE))
                IntMod = Convert.ToInt32(((selectedRollValue + GetRacialBonus(CharacterRace, DndAttribute.INTELLIGENCE)) - 10) / 2)
            Case "Wisdom"
                labelWisValue.Text = (selectedRollValue + GetRacialBonus(CharacterRace, DndAttribute.WISDOM))
                WisMod = Convert.ToInt32(((selectedRollValue + GetRacialBonus(CharacterRace, DndAttribute.WISDOM)) - 10) / 2)
            Case "Charisma"
                labelChaValue.Text = (selectedRollValue + GetRacialBonus(CharacterRace, DndAttribute.CHARISMA))
                ChaMod = Convert.ToInt32(((selectedRollValue + GetRacialBonus(CharacterRace, DndAttribute.CHARISMA)) - 10) / 2)
        End Select

        ' Remove the currently selected items from the list boxes and list
        AttributeListBox.Items.RemoveAt(selectedAttributeIndex)
        RollListBox.Items.RemoveAt(selectedRollIndex)
        dieRollSums.RemoveAt(selectedRollIndex)

        UndoAttributeButton.Visible = True
        UndoAttributeButton.Enabled = True

        If AttributeListBox.Items.Count = 0 And RollListBox.Items.Count = 0 Then
            AllocateAttributeButton.Enabled = False ' If both lists are now empty, disable the allocate button
            FinalizeAttributeButton.Visible = True
            UndoAttributeButton.Enabled = True
            AttributeHelpButton.Visible = True
        Else
            RollListBox.SelectedIndex = 0 ' Reset the selected indices to 0
            AttributeListBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub UndoAttributeButton_Click(sender As Object, e As EventArgs) Handles UndoAttributeButton.Click
        Dim lastAttributeIndex As Integer = lastAssignedAttributeStack.Peek().IndexOfLastAttribute
        Dim lastAttributeName As String = lastAssignedAttributeStack.Peek().NameOfLastAttribute
        Dim lastRollIndex As Integer = lastAssignedAttributeStack.Peek().IndexOfLastRoll
        Dim lastRollValue As Integer = lastAssignedAttributeStack.Peek().ValueOfLastRoll

        If AttributeListBox.Items.Count = 0 And RollListBox.Items.Count = 0 Then
            AllocateAttributeButton.Enabled = True 'If the lists were empty, re-enable the allocate button
            FinalizeAttributeButton.Enabled = False 'and disable the finalize button
        End If

        'Find the name of the last assigned attribute and set the points label back to zero
        Select Case lastAttributeName
            Case "Strength"
                labelStrValue.Text = 0
            Case "Dexterity"
                labelDexValue.Text = 0
            Case "Constitution"
                labelConValue.Text = 0
            Case "Intelligence"
                labelIntValue.Text = 0
            Case "Wisdom"
                labelWisValue.Text = 0
            Case "Charisma"
                labelChaValue.Text = 0
        End Select

        ' Add the last selected items back into their list boxes and list at the appropriate indices
        AttributeListBox.Items.Insert(lastAttributeIndex, lastAttributeName)
        RollListBox.Items.Insert(lastRollIndex, lastRollValue.ToString())
        dieRollSums.Insert(lastRollIndex, lastRollValue)

        lastAssignedAttributeStack.Pop() ' Pop this set of attributes off the stack

        RollListBox.SelectedIndex = 0 ' Reset the selected indices in the list boxes to 0
        AttributeListBox.SelectedIndex = 0

        If lastAssignedAttributeStack.Count = 0 Then
            UndoAttributeButton.Enabled = False ' If the stack is now empty, disable the undo button
        End If
    End Sub

    Private Sub FinalizeAttributeButton_Click(sender As Object, e As EventArgs) Handles FinalizeAttributeButton.Click
        Dim skillNames As String()

        AllocateAttributeButton.Enabled = False ' Disable all allocation buttons after finalizing assigned attributes
        UndoAttributeButton.Enabled = False
        FinalizeAttributeButton.Enabled = False

        Do While lastAssignedAttributeStack.Count > 0
            Select Case lastAssignedAttributeStack.Peek().NameOfLastAttribute
                Case "Strength"
                    finalizedAttributes(DndAttribute.STRENGTH) = lastAssignedAttributeStack.Peek().ValueOfLastRoll + GetRacialBonus(CharacterRace, DndAttribute.STRENGTH)
                    If StrMod >= 0 Then
                        labelStr.Text += "(+" + StrMod.ToString + ")"
                    Else
                        labelStr.Text += "(" + StrMod.ToString + ")"
                    End If
                Case "Dexterity"
                    finalizedAttributes(DndAttribute.DEXTERITY) = lastAssignedAttributeStack.Peek().ValueOfLastRoll + GetRacialBonus(CharacterRace, DndAttribute.DEXTERITY)
                    If DexMod >= 0 Then
                        labelDex.Text += "(+" + DexMod.ToString + ")"
                    Else
                        labelDex.Text += "(" + DexMod.ToString + ")"
                    End If
                Case "Constitution"
                    finalizedAttributes(DndAttribute.CONSTITUTION) = lastAssignedAttributeStack.Peek().ValueOfLastRoll + GetRacialBonus(CharacterRace, DndAttribute.CONSTITUTION)
                    If ConMod >= 0 Then
                        labelCon.Text += "(+" + ConMod.ToString + ")"
                    Else
                        labelCon.Text += "(" + ConMod.ToString + ")"
                    End If
                Case "Intelligence"
                    finalizedAttributes(DndAttribute.INTELLIGENCE) = lastAssignedAttributeStack.Peek().ValueOfLastRoll + GetRacialBonus(CharacterRace, DndAttribute.INTELLIGENCE)
                    If IntMod >= 0 Then
                        labelInt.Text += "(+" + IntMod.ToString + ")"
                    Else
                        labelInt.Text += "(" + IntMod.ToString + ")"
                    End If
                Case "Wisdom"
                    finalizedAttributes(DndAttribute.WISDOM) = lastAssignedAttributeStack.Peek().ValueOfLastRoll + GetRacialBonus(CharacterRace, DndAttribute.WISDOM)
                    If WisMod >= 0 Then
                        labelWis.Text += "(+" + WisMod.ToString + ")"
                    Else
                        labelWis.Text += "(" + WisMod.ToString + ")"
                    End If
                Case "Charisma"
                    finalizedAttributes(DndAttribute.CHARISMA) = lastAssignedAttributeStack.Peek().ValueOfLastRoll + GetRacialBonus(CharacterRace, DndAttribute.CHARISMA)
                    If ChaMod >= 0 Then
                        labelCha.Text += "(+" + ChaMod.ToString + ")"
                    Else
                        labelCha.Text += "(" + ChaMod.ToString + ")"
                    End If
            End Select
            ProficienciesHelpBox.Visible = True
            ProficientSkillsLabel.Visible = True
            SkillsListBox.Visible = True
            AssignedSkillsListBox.Visible = True
            AllocateSkillsButton.Visible = True
            UndoSkillsButton.Visible = True
            FinalizeSkillsButton.Visible = True
            lastAssignedAttributeStack.Pop()
        Loop

        skillNames = GetClassSkillList(CharacterClass)

        For currentIndex = 0 To skillNames.Length - 1
            SkillsListBox.Items.Add(skillNames(currentIndex))
        Next

        SkillsListBox.SelectedIndex = 0
    End Sub

    Private Sub AllocateSkillsButton_Click(sender As Object, e As EventArgs) Handles AllocateSkillsButton.Click
        If AssignedSkillsListBox.Items.Count() < 2 Then
            Dim currentSkill As String = SkillsListBox.Items(SkillsListBox.SelectedIndex).ToString()

            Dim selectedSkillIndex As Integer = SkillsListBox.SelectedIndex
            Dim selectedSkillName As String = SkillsListBox.Items(selectedSkillIndex).ToString()

            ' Push this data onto a stack to enable easy reversal of actions
            lastAssignedSkillStack.Push(New AssignedProficiencies(selectedSkillIndex, selectedSkillName))

            SkillsListBox.Items.RemoveAt(SkillsListBox.SelectedIndex)
            SkillsListBox.SelectedIndex = 0
            AssignedSkillsListBox.Items.Add(currentSkill)
            UndoSkillsButton.Enabled = True

        End If
    End Sub

    Private Sub UndoSkillsButton_Click(sender As Object, e As EventArgs) Handles UndoSkillsButton.Click
        Dim lastSkillIndex As Integer = lastAssignedSkillStack.Peek().IndexOfLastProficiency
        Dim lastSkillName As String = lastAssignedSkillStack.Peek().NameOfLastProficiency

        If SkillsListBox.Items.Count = 0 And AssignedSkillsListBox.Items.Count = 0 Then
            AllocateSkillsButton.Enabled = False 'If the lists were empty, re-enable the allocate button
            FinalizeSkillsButton.Enabled = True 'and disable the finalize button
        End If
        ' Add the last selected items back into their list boxes and list at the appropriate indices
        SkillsListBox.Items.Insert(lastSkillIndex, lastSkillName)

        lastAssignedSkillStack.Pop() ' Pop this set of attributes off the stack

        SkillsListBox.SelectedIndex = 0 ' Reset the selected indices in the list boxes to 0

        AssignedSkillsListBox.Items.RemoveAt(0)

        If AssignedSkillsListBox.Items.Count = 0 Then
            UndoSkillsButton.Enabled = False ' If the stack is now empty, disable the undo button
        End If
    End Sub

    Private Sub FinalizeSkillsButton_Click(sender As Object, e As EventArgs) Handles FinalizeSkillsButton.Click
        AllocateSkillsButton.Enabled = False
        UndoSkillsButton.Enabled = False
        FinalizeSkillsButton.Enabled = False
    End Sub

    Private Sub NameHelpBox_Click(sender As Object, e As EventArgs) Handles NameHelpBox.Click
        If HelpFormNumberInteger = 0 Then
            HelpFormNumberInteger += 1
            Dim NameHelpForm As New HelpForm 'Create an instance of a new attribute help form
            NameHelpForm.HelpTitleLabel.Text = "How to Enter Name"
            NameHelpForm.HelpTextBox.Text = "Pick a name for your Dungeons & Dragons character. This is your blank slate to express yourself.
You can't change your character's name later on, so make sure to pick a name you really like.
Choose a name that's exemplary, enigmatic, or just personally enjoyable.

Make sure your name is at least two characters long.
Using your mouse, click on the text box to bring it into focus.
Enter your name using your keyboard.
When you are satisfied with your choice, click on the 'Submit' button."
            NameHelpForm.Show() 'Load the attribute help form
        End If
    End Sub

    Private Sub RaceHelpBox_Click(sender As Object, e As EventArgs) Handles RaceHelpBox.Click
        If HelpFormNumberInteger = 0 Then
            HelpFormNumberInteger += 1
            Dim RaceHelpForm As New HelpForm 'Create an instance of a new attribute help form
            RaceHelpForm.HelpTitleLabel.Text = "How to Pick a Race"
            RaceHelpForm.HelpTextBox.Text =
                "Pick a race for your Dungeons & Dragons character. Depending on your choice, your character will
be stronger in certain attributes. They will also have access to different abilities.
Some races have subraces that further affect their abilities. For example, elves have a further
choice between wood elves and high elves.

Humans
Humans are a very versatile race to choose. All of a human's attributes get a small, balanced boost.
Humans are also multilingual, and they can learn common and any second language they wish. Humans
are very much a blank slate in terms of character creation.

Elves
All elves are agile, and they are more suited towards reflex-oriented actions. Elves also have
more sensitive eyesight and are able to see in darker areas and sense items in their surroundings.
Additionally, elves are difficult to influence with magic, and they can't fall asleep from it.
Elves also require less rest than other races. Elves are fluent in common and elvish.

Tieflings
Tieflings are good at using the power of persuasion on others. They are also quick-witted and
they learn and retain items more effectively. Tieflings have more sensitive eyesight and are
able to see in darker areas and sense items in their surroundings. Tieflings can tolerate heat
better than other races. They are able to use milder magic to affect their surroundings.
Tieflings are fluent in common and infernal."

            RaceHelpForm.Show() 'Load the attribute help form
        End If
    End Sub

    Private Sub SubraceHelpBox_Click(sender As Object, e As EventArgs) Handles SubraceHelpBox.Click
        If HelpFormNumberInteger = 0 Then
            HelpFormNumberInteger += 1
            Dim SubraceHelpForm As New HelpForm 'Create an instance of a new attribute help form
            SubraceHelpForm.HelpTitleLabel.Text = "How to Pick a Subrace"
            SubraceHelpForm.HelpTextBox.Text = "High Elf Subrace
In addition to the above, high elves are more magically inclined. They start off with knowledge
of a spell. They also learn and retain items more effectively. Because of this, they are able
to learn a third language.

Wood Elf Subrace
In addition to the above, wood elves are more sensitive and seasoned to their surroundings. They
move more quickly than other races. They are also good at camoflauging themselves, and they are
able to maintain a low profile in wooded areas, percipitation, and the like."

            SubraceHelpForm.Show() 'Load the attribute help form
        End If
    End Sub

    Private Sub ClassHelpBox_Click(sender As Object, e As EventArgs) Handles ClassHelpBox.Click
        If HelpFormNumberInteger = 0 Then
            HelpFormNumberInteger += 1
            Dim ClassHelpForm As New HelpForm 'Create an instance of a new attribute help form
            ClassHelpForm.HelpTitleLabel.Text = "How to Pick a Class"

            ClassHelpForm.Show() 'Load the attribute help form
        End If
    End Sub

    Private Sub StatHelpBox_Click(sender As Object, e As EventArgs) Handles StatHelpBox.Click
        If HelpFormNumberInteger = 0 Then
            HelpFormNumberInteger += 1
            Dim StatHelpForm As New HelpForm 'Create an instance of a new attribute help form
            StatHelpForm.HelpTitleLabel.Text = "How to Roll for Stats"

            StatHelpForm.Show() 'Load the attribute help form
        End If
    End Sub

    Private Sub AllocationHelpBox_Click(sender As Object, e As EventArgs) Handles AllocationHelpBox.Click
        If HelpFormNumberInteger = 0 Then
            HelpFormNumberInteger += 1
            Dim AllocationHelpForm As New HelpForm 'Create an instance of a new attribute help form
            AllocationHelpForm.HelpTitleLabel.Text = "How to Allocate Stats"

            AllocationHelpForm.Show() 'Load the attribute help form
        End If
    End Sub

    Private Sub AttributeHelpButton_Click(sender As Object, e As EventArgs) Handles AttributeHelpButton.Click
        If HelpFormNumberInteger = 0 Then
            HelpFormNumberInteger += 1
            Dim AttributesHelpForm As New HelpForm 'Create an instance of a new attribute help form
            AttributesHelpForm.HelpTitleLabel.Text = "Character Attributes & What They Mean"

            AttributesHelpForm.Show() 'Load the attribute help form
        End If
    End Sub

    Private Sub ProficienciesHelpBox_Click(sender As Object, e As EventArgs) Handles ProficienciesHelpBox.Click
        If HelpFormNumberInteger = 0 Then
            HelpFormNumberInteger += 1
            Dim ProficienciesHelpForm As New HelpForm 'Create an instance of a new attribute help form
            ProficienciesHelpForm.HelpTitleLabel.Text = "How to Allocate Proficiencies"

            ProficienciesHelpForm.Show() 'Load the attribute help form
        End If
    End Sub

End Class
