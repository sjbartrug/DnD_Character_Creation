Public Class characterSheetForm

    ' Constants
    Const STRING_ZERO As String = "0"
    Const DIE_ROLLS_TOTAL As Integer = 6

    ' Class-level variables
    Dim characterName As String
    Dim characterRace As Integer
    Dim characterClass As Integer
    Dim characterProficiencyBonus As Integer = L1_PROFICIENCY_BONUS
    Dim currentDieRollCount As Integer = 0
    Dim currentDieSum As Integer
    Dim dieRollSums As New List(Of Integer)
    Dim lastAssignedAttributeStack As New Stack(Of AssignedAttribute)
    Dim finalizedAttributes(NUM_OF_ATTRIBUTES) As Integer
    Dim savingThrows(NUM_OF_ATTRIBUTES) As Integer
    Dim skillProficiencies(NUM_OF_SKILLS) As Boolean
    Dim lastAssignedSkillStack As New Stack(Of String)

    'An event handler for when the form loads, this is good for setting initial properties of controls
    Private Sub characterSheetForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rollOneTextField.Enabled = False 'Makes these three text fields for display only
        rollTwoTextField.Enabled = False
        rollThreeTextField.Enabled = False
        rollValueSubmitButton.Enabled = False
        allocateAttributeButton.Enabled = False
        undoAttributeButton.Enabled = False
        finalizeAttributeButton.Enabled = False
        raceGroupBox.Enabled = False
        raceSubmitButton.Enabled = False
        subraceGroupBox.Enabled = False
        subraceSubmitButton.Enabled = False
        humanRadioButton.Checked = True
        highElfRadioButton.Checked = True
        barbarianRadioButton.Checked = True
        classGroupBox.Enabled = False
        classSubmitButton.Enabled = False
        rollDiceButton.Enabled = False

        For currentIndex = 0 To NUM_OF_SKILLS
            skillProficiencies(currentIndex) = False
        Next
    End Sub
    Private Sub nameSubmitButton_Click(sender As Object, e As EventArgs) Handles nameSubmitButton.Click
        Dim tempName As String = nameTextField.Text() 'Get the name from the text field

        If tempName.Length() >= 2 And tempName.Length() <= 25 Then
            characterName = tempName 'Assign the name if it's between 2-25 chars long

            nameTextField.Enabled = False
            nameSubmitButton.Enabled = False 'Disable this action once it's finalized
            raceGroupBox.Enabled = True
            raceSubmitButton.Enabled = True
        End If
    End Sub

    Private Sub raceSubmitButton_Click(sender As Object, e As EventArgs) Handles raceSubmitButton.Click
        If humanRadioButton.Checked = True Then
            characterRace = DndRace.HUMAN

            raceSubmitButton.Enabled = False
            raceGroupBox.Enabled = False
            classGroupBox.Enabled = True
            classSubmitButton.Enabled = True

        ElseIf elfRadioButton.Checked = True Then
            raceSubmitButton.Enabled = False
            raceGroupBox.Enabled = False
            subraceGroupBox.Enabled = True
            subraceSubmitButton.Enabled = True

        Else
            characterRace = DndRace.TIEFLING

            raceSubmitButton.Enabled = False
            raceGroupBox.Enabled = False
            classGroupBox.Enabled = True
            classSubmitButton.Enabled = True
        End If
    End Sub

    Private Sub subraceSubmitButton_Click(sender As Object, e As EventArgs) Handles subraceSubmitButton.Click
        If highElfRadioButton.Checked = True Then
            characterRace = DndRace.HIGH_ELF
        Else
            characterRace = DndRace.WOOD_ELF
        End If

        subraceGroupBox.Enabled = False
        subraceSubmitButton.Enabled = False
        classGroupBox.Enabled = True
        classSubmitButton.Enabled = True
    End Sub

    Private Sub classSubmitButton_Click(sender As Object, e As EventArgs) Handles classSubmitButton.Click
        If barbarianRadioButton.Checked = True Then
            characterClass = DndClass.BARBARIAN
        ElseIf monkRadioButton.Checked = True Then
            characterClass = DndClass.MONK
        Else
            characterClass = DndClass.FIGHTER
        End If

        labelStr.Text() += " (+" + GetRacialBonus(characterRace, DndAttribute.STRENGTH).ToString() + ")"
        labelDex.Text() += " (+" + GetRacialBonus(characterRace, DndAttribute.DEXTERITY).ToString() + ")"
        labelCon.Text() += " (+" + GetRacialBonus(characterRace, DndAttribute.CONSTITUTION).ToString() + ")"
        labelInt.Text() += " (+" + GetRacialBonus(characterRace, DndAttribute.INTELLIGENCE).ToString() + ")"
        labelWis.Text() += " (+" + GetRacialBonus(characterRace, DndAttribute.WISDOM).ToString() + ")"
        labelCha.Text() += " (+" + GetRacialBonus(characterRace, DndAttribute.CHARISMA).ToString() + ")"

        classGroupBox.Enabled = False
        classSubmitButton.Enabled = False
        rollDiceButton.Enabled = True
    End Sub

    Private Sub rollDiceButton_Click(sender As Object, e As EventArgs) Handles rollDiceButton.Click
        Dim firstDieRoll As Integer
        Dim secondDieRoll As Integer
        Dim thirdDieRoll As Integer

        firstDieRoll = RollDndDice(DndDice.ONE_D_SIX) ' Calls (random.nextInt(6) + 1)
        secondDieRoll = RollDndDice(DndDice.ONE_D_SIX)
        thirdDieRoll = RollDndDice(DndDice.ONE_D_SIX)
        rollOneTextField.Text = firstDieRoll.ToString()
        rollTwoTextField.Text = secondDieRoll.ToString()
        rollThreeTextField.Text = thirdDieRoll.ToString()

        currentDieSum = firstDieRoll + secondDieRoll + thirdDieRoll

        rollValueSubmitButton.Enabled = True 'Enable the submit button
        rollDiceButton.Enabled = False 'Don't allow a reroll until the current roll is submitted
    End Sub

    Private Sub rollValueSubmitButton_Click(sender As Object, e As EventArgs) Handles rollValueSubmitButton.Click
        rollValueSubmitButton.Enabled = False

        dieRollSums.Add(currentDieSum) 'Add the sum of the last three die rolls to the list and list box
        rollListBox.Items.Add(dieRollSums.Item(currentDieRollCount).ToString())

        currentDieRollCount += 1 'Keep track of die rolls

        rollOneTextField.Clear() 'Clear the text fields for the next die rolls
        rollTwoTextField.Clear()
        rollThreeTextField.Clear()

        ' In VB, <> means not equal to
        If currentDieRollCount <> DIE_ROLLS_TOTAL Then
            rollDiceButton.Enabled = True 'If 6 rolls have not been made, allow another roll
        Else
            allocateAttributeButton.Enabled = True 'Once 6 rolls are made, enable the allocate button in the next section
            rollListBox.SelectedIndex = 0 'And select the first indices of both lists
            attributeListBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub allocateButton_Click(sender As Object, e As EventArgs) Handles allocateAttributeButton.Click
        ' Keep track of the currently assigned attribute name, point value, and their indices on their lists
        Dim selectedAttributeIndex As Integer = attributeListBox.SelectedIndex
        Dim selectedAttributeName As String = attributeListBox.Items(selectedAttributeIndex).ToString()
        Dim selectedRollIndex As Integer = rollListBox.SelectedIndex
        Dim selectedRollValue As Integer = dieRollSums.Item(selectedRollIndex)

        ' Push this data onto a stack to enable easy reversal of actions
        lastAssignedAttributeStack.Push(New AssignedAttribute(selectedAttributeIndex, selectedAttributeName,
                                                         selectedRollIndex, dieRollSums.Item(selectedRollIndex)))

        ' Find the name of the currently assigned attribute and set its points label to the assigned value
        Select Case selectedAttributeName
            Case "Strength"
                labelStrValue.Text = (selectedRollValue + GetRacialBonus(characterRace, DndAttribute.STRENGTH)).ToString()
            Case "Dexterity"
                labelDexValue.Text = (selectedRollValue + GetRacialBonus(characterRace, DndAttribute.DEXTERITY)).ToString()
            Case "Constitution"
                labelConValue.Text = (selectedRollValue + GetRacialBonus(characterRace, DndAttribute.CONSTITUTION)).ToString()
            Case "Intelligence"
                labelIntValue.Text = (selectedRollValue + GetRacialBonus(characterRace, DndAttribute.INTELLIGENCE)).ToString()
            Case "Wisdom"
                labelWisValue.Text = (selectedRollValue + GetRacialBonus(characterRace, DndAttribute.WISDOM)).ToString()
            Case "Charisma"
                labelChaValue.Text = (selectedRollValue + GetRacialBonus(characterRace, DndAttribute.CHARISMA)).ToString()
        End Select

        ' Remove the currently selected items from the list boxes and list
        attributeListBox.Items.RemoveAt(selectedAttributeIndex)
        rollListBox.Items.RemoveAt(selectedRollIndex)
        dieRollSums.RemoveAt(selectedRollIndex)

        undoAttributeButton.Enabled = True

        If attributeListBox.Items.Count = 0 And rollListBox.Items.Count = 0 Then
            allocateAttributeButton.Enabled = False ' If both lists are now empty, disable the allocate button
            finalizeAttributeButton.Enabled = True
        Else
            rollListBox.SelectedIndex = 0 ' Reset the selected indices to 0
            attributeListBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub ButtonUndoAllocation_Click(sender As Object, e As EventArgs) Handles undoAttributeButton.Click
        Dim lastAttributeIndex As Integer = lastAssignedAttributeStack.Peek().IndexOfLastAttribute
        Dim lastAttributeName As String = lastAssignedAttributeStack.Peek().NameOfLastAttribute
        Dim lastRollIndex As Integer = lastAssignedAttributeStack.Peek().IndexOfLastRoll
        Dim lastRollValue As Integer = lastAssignedAttributeStack.Peek().ValueOfLastRoll

        If attributeListBox.Items.Count = 0 And rollListBox.Items.Count = 0 Then
            allocateAttributeButton.Enabled = True 'If the lists were empty, re-enable the allocate button
            finalizeAttributeButton.Enabled = False 'and disable the finalize button
        End If

        'Find the name of the last assigned attribute and set the points label back to zero
        Select Case lastAttributeName
            Case "Strength"
                labelStrValue.Text = STRING_ZERO ' This is just "0"
            Case "Dexterity"
                labelDexValue.Text = STRING_ZERO
            Case "Constitution"
                labelConValue.Text = STRING_ZERO
            Case "Intelligence"
                labelIntValue.Text = STRING_ZERO
            Case "Wisdom"
                labelWisValue.Text = STRING_ZERO
            Case "Charisma"
                labelChaValue.Text = STRING_ZERO
        End Select

        ' Add the last selected items back into their list boxes and list at the appropriate indices
        attributeListBox.Items.Insert(lastAttributeIndex, lastAttributeName)
        rollListBox.Items.Insert(lastRollIndex, lastRollValue.ToString())
        dieRollSums.Insert(lastRollIndex, lastRollValue)

        lastAssignedAttributeStack.Pop() ' Pop this set of attributes off the stack

        rollListBox.SelectedIndex = 0 ' Reset the selected indices in the list boxes to 0
        attributeListBox.SelectedIndex = 0

        If lastAssignedAttributeStack.Count = 0 Then
            undoAttributeButton.Enabled = False ' If the stack is now empty, disable the undo button
        End If
    End Sub

    Private Sub attributeFinalizeButton_Click(sender As Object, e As EventArgs) Handles finalizeAttributeButton.Click
        Dim skillNames As String()

        allocateAttributeButton.Enabled = False ' Disable all allocation buttons after finalizing assigned attributes
        undoAttributeButton.Enabled = False
        finalizeAttributeButton.Enabled = False

        Do While lastAssignedAttributeStack.Count > 0
            Select Case lastAssignedAttributeStack.Peek().NameOfLastAttribute
                Case "Strength"
                    finalizedAttributes(DndAttribute.STRENGTH) = lastAssignedAttributeStack.Peek().ValueOfLastRoll + GetRacialBonus(characterRace, DndAttribute.STRENGTH)
                Case "Dexterity"
                    finalizedAttributes(DndAttribute.DEXTERITY) = lastAssignedAttributeStack.Peek().ValueOfLastRoll + GetRacialBonus(characterRace, DndAttribute.DEXTERITY)
                Case "Constitution"
                    finalizedAttributes(DndAttribute.CONSTITUTION) = lastAssignedAttributeStack.Peek().ValueOfLastRoll + GetRacialBonus(characterRace, DndAttribute.CONSTITUTION)
                Case "Intelligence"
                    finalizedAttributes(DndAttribute.INTELLIGENCE) = lastAssignedAttributeStack.Peek().ValueOfLastRoll + GetRacialBonus(characterRace, DndAttribute.INTELLIGENCE)
                Case "Wisdom"
                    finalizedAttributes(DndAttribute.WISDOM) = lastAssignedAttributeStack.Peek().ValueOfLastRoll + GetRacialBonus(characterRace, DndAttribute.WISDOM)
                Case "Charisma"
                    finalizedAttributes(DndAttribute.CHARISMA) = lastAssignedAttributeStack.Peek().ValueOfLastRoll + GetRacialBonus(characterRace, DndAttribute.CHARISMA)
            End Select

            lastAssignedAttributeStack.Pop()
        Loop

        skillNames = GetClassSkillList(characterClass)

        For currentIndex = 0 To (skillNames.Length - 1)
            skillsListBox.Items.Add(skillNames(currentIndex))
        Next

        skillsListBox.SelectedIndex = 0
    End Sub

    Private Sub attributeHelpIconBox_Click(sender As Object, e As EventArgs) Handles attributeHelpIconBox.Click
        If attributeHelpFormCount = 0 Then
            Dim attributesHelpForm As New AttributeHelpForm 'Create an instance of a new attribute help form

            attributeHelpFormCount += 1

            attributesHelpForm.Show() 'Load the attribute help form
        End If
    End Sub
    Private Sub allocateSkillsButton_Click(sender As Object, e As EventArgs) Handles allocateSkillsButton.Click
        If assignedSkillsListBox.Items.Count() < 2 Then
            Dim currentIndex As Integer = skillsListBox.SelectedIndex
            Dim currentSkill As String = skillsListBox.Items(currentIndex).ToString()

            skillsListBox.Items.RemoveAt(currentIndex)
            assignedSkillsListBox.Items.Add(currentSkill)
        End If
    End Sub

    Private Sub undoSkillsButton_Click(sender As Object, e As EventArgs) Handles undoSkillsButton.Click

    End Sub

    Private Sub finalizeSkillsButton_Click(sender As Object, e As EventArgs) Handles finalizeSkillsButton.Click
        allocateSkillsButton.Enabled = False
        undoSkillsButton.Enabled = False
        finalizeSkillsButton.Enabled = False
    End Sub
End Class
