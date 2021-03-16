Public Class characterSheetForm

    ' Constants
    Const STRING_ZERO As String = "0"
    Const DIE_ROLLS_TOTAL As Integer = 6

    ' Class-level variables
    Dim currentDieRollCount As Integer = 0
    Dim currentDieSum As Integer
    Dim dieRollSums As New List(Of Integer)
    Dim lastAssignedStack As New Stack(Of AssignedAttribute)

    'An event handler for when the form loads, this is good for setting initial properties of controls
    Private Sub characterSheetForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rollOneTextField.Enabled = False 'Makes these three text fields for display only
        rollTwoTextField.Enabled = False
        rollThreeTextField.Enabled = False
        rollValueSubmitButton.Enabled = False
        allocateButton.Enabled = False
        buttonUndoAllocation.Enabled = False
        attributeFinalizeButton.Enabled = False
    End Sub
    Private Sub nameSubmitButton_Click(sender As Object, e As EventArgs) Handles nameSubmitButton.Click

    End Sub

    Private Sub nameTextField_TextChanged(sender As Object, e As EventArgs) Handles nameTextField.TextChanged

    End Sub

    Private Sub humanRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles humanRadioButton.CheckedChanged

    End Sub

    Private Sub elfRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles elfRadioButton.CheckedChanged

    End Sub

    Private Sub tieflingRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles tieflingRadioButton.CheckedChanged

    End Sub

    Private Sub raceSubmitButton_Click(sender As Object, e As EventArgs) Handles raceSubmitButton.Click

    End Sub

    Private Sub barbarianRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles barbarianRadioButton.CheckedChanged

    End Sub

    Private Sub monkRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles monkRadioButton.CheckedChanged

    End Sub

    Private Sub fighterRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles fighterRadioButton.CheckedChanged

    End Sub

    Private Sub classSubmitButton_Click(sender As Object, e As EventArgs) Handles classSubmitButton.Click

    End Sub

    Private Sub woodElfRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles woodElfRadioButton.CheckedChanged

    End Sub

    Private Sub subraceSubmitButton_Click(sender As Object, e As EventArgs) Handles subraceSubmitButton.Click

    End Sub

    Private Sub highElfRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles highElfRadioButton.CheckedChanged

    End Sub

    Private Sub subraceLabel_Click(sender As Object, e As EventArgs) Handles subrace.Click

    End Sub

    Private Sub raceLabel_Click(sender As Object, e As EventArgs) Handles raceLabel.Click

    End Sub

    Private Sub nameLabel_Click(sender As Object, e As EventArgs) Handles nameLabel.Click

    End Sub

    Private Sub classLabel_Click(sender As Object, e As EventArgs) Handles classLabel.Click

    End Sub

    Private Sub dndLabel_Click(sender As Object, e As EventArgs) Handles dndLabel.Click

    End Sub

    Private Sub rollOneTextField_TextChanged(sender As Object, e As EventArgs) Handles rollOneTextField.TextChanged

    End Sub

    Private Sub rollTwoTextField_TextChanged(sender As Object, e As EventArgs) Handles rollTwoTextField.TextChanged

    End Sub

    Private Sub rollThreeTextField_TextChanged(sender As Object, e As EventArgs) Handles rollThreeTextField.TextChanged

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

    Private Sub attributeAllocationLabel_Click(sender As Object, e As EventArgs) Handles attributeAllocationLabel.Click

    End Sub

    Private Sub attributeListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles attributeListBox.SelectedIndexChanged

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
            allocateButton.Enabled = True 'Once 6 rolls are made, enable the allocate button in the next section
            rollListBox.SelectedIndex = 0 'And select the first indices of both lists
            attributeListBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub allocateButton_Click(sender As Object, e As EventArgs) Handles allocateButton.Click
        ' Keep track of the currently assigned attribute name, point value, and their indices on their lists
        Dim selectedAttributeIndex As Integer = attributeListBox.SelectedIndex
        Dim selectedAttributeName As String = attributeListBox.Items(selectedAttributeIndex).ToString()
        Dim selectedRollIndex As Integer = rollListBox.SelectedIndex
        Dim selectedRollValueText As String = dieRollSums.Item(selectedRollIndex).ToString()

        ' Push this data onto a stack to enable easy reversal of actions
        lastAssignedStack.Push(New AssignedAttribute(selectedAttributeIndex, selectedAttributeName,
                                                         selectedRollIndex, dieRollSums.Item(selectedRollIndex)))

        ' Find the name of the currently assigned attribute and set its points label to the assigned value
        Select Case selectedAttributeName
            Case "Strength"
                labelStrValue.Text = selectedRollValueText
            Case "Dexterity"
                labelDexValue.Text = selectedRollValueText
            Case "Constitution"
                labelConValue.Text = selectedRollValueText
            Case "Intelligence"
                labelIntValue.Text = selectedRollValueText
            Case "Wisdom"
                labelWisValue.Text = selectedRollValueText
            Case "Charisma"
                labelChaValue.Text = selectedRollValueText
        End Select

        ' Remove the currently selected items from the list boxes and list
        attributeListBox.Items.RemoveAt(selectedAttributeIndex)
        rollListBox.Items.RemoveAt(selectedRollIndex)
        dieRollSums.RemoveAt(selectedRollIndex)

        buttonUndoAllocation.Enabled = True

        If attributeListBox.Items.Count = 0 And rollListBox.Items.Count = 0 Then
            allocateButton.Enabled = False ' If both lists are now empty, disable the allocate button
            attributeFinalizeButton.Enabled = True
        Else
            rollListBox.SelectedIndex = 0 ' Reset the selected indices to 0
            attributeListBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub ButtonUndoAllocation_Click(sender As Object, e As EventArgs) Handles buttonUndoAllocation.Click
        Dim lastAttributeIndex As Integer = lastAssignedStack.Peek().IndexOfLastAttribute
        Dim lastAttributeName As String = lastAssignedStack.Peek().NameOfLastAttribute
        Dim lastRollIndex As Integer = lastAssignedStack.Peek().IndexOfLastRoll
        Dim lastRollValue As Integer = lastAssignedStack.Peek().ValueOfLastRoll

        If attributeListBox.Items.Count = 0 And rollListBox.Items.Count = 0 Then
            allocateButton.Enabled = True 'If the lists were empty, re-enable the allocate button
            attributeFinalizeButton.Enabled = False 'and disable the finalize button
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

        lastAssignedStack.Pop() ' Pop this set of attributes off the stack

        rollListBox.SelectedIndex = 0 ' Reset the selected indices in the list boxes to 0
        attributeListBox.SelectedIndex = 0

        If lastAssignedStack.Count = 0 Then
            buttonUndoAllocation.Enabled = False ' If the stack is now empty, disable the undo button
        End If
    End Sub

    Private Sub attributeFinalizeButton_Click(sender As Object, e As EventArgs) Handles attributeFinalizeButton.Click
        allocateButton.Enabled = False ' Disable all allocation buttons after finalizing assigned attributes
        buttonUndoAllocation.Enabled = False
        attributeFinalizeButton.Enabled = False
    End Sub
End Class
