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
            RaceSubmitButton.Enabled = False

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
            FinalizeAttributeButton.Enabled = True
            FinalizeAttributeButton.Visible = True
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

        AllocateAttributeButton.Enabled = True 'If the lists were empty, re-enable the allocate button
        FinalizeAttributeButton.Enabled = False 'and disable the finalize button

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

            If AssignedSkillsListBox.Items.Count = 2 Then
                FinalizeSkillsButton.Enabled = True
                FinalizeSkillsButton.Visible = True
            End If

        End If
    End Sub

    Private Sub UndoSkillsButton_Click(sender As Object, e As EventArgs) Handles UndoSkillsButton.Click
        Dim lastSkillIndex As Integer = lastAssignedSkillStack.Peek().IndexOfLastProficiency
        Dim lastSkillName As String = lastAssignedSkillStack.Peek().NameOfLastProficiency

        AllocateSkillsButton.Enabled = True 'If the lists were empty, re-enable the allocate button
        FinalizeSkillsButton.Enabled = False 'and disable the finalize button

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
        If CharacterRace.Equals(DndRace.HIGH_ELF) Then
            HighElfCantripSelectionLabel.Visible = True
            CantripGroupBox.Visible = True
            CantripHelpButton.Visible = True
            CantripButton.Visible = True
        Else
            FinalSubmitButton.Visible = True
        End If

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
            ClassHelpForm.HelpTextBox.Text = "Choosing a Class:
Pick a class for your Dungeons & Dragons character. Depending on your choice, your character will
use certain attributes (like strength or agility) to their advantage. They will also have access 
to different abilities, weapons, fighting styles, armor, and skills which they exemplify.

Barbarian
Barbarians are a very physical class. They are trained to use a variety of melee weapons and armor,
but they are also able to defend themselves well when unprotected. Barbarians possess a
considerable amount of physical power and vitality, and they are better in a pinch with these
types of situations. Barbarians are vicious, and they use this to their advantage in battle
to do more damage, protect themselves, and further get themselves out of a pinch. Barbarians
can exemplify animal handling, athletics, intimidation, nature, perception, and survival.

Beginner Barbarian
When you are allocating attribute points, strength is the most important. Constitution is also
important across the board, but it is especially important to a barbarian.

Monk
Monks are also a very physical class, but they rely more on agility than brute force. They are
trained to use lighter melee weapons, but they often prefer to protect themselves with their 
agility instead of armor. Monks possess exemplary agility and strength, and they are better in 
a pinch with these types of situations. Monks are trained to use their body as a weapon, causing 
damage through their agility and sometimes landing an extra attack. Monks can exemplify acrobatics,
athletics, history, insight, religion, and stealth.

Beginner Monk
When you are allocating attribute points, dexterity is the most important. Wisdom is also
an important trait for a monk. Constitution is always important, so don't neglect it either.

Fighters
Fighters, another physical class, can be adept in using melee weapons, ranged weapons, and armor.
Fighters typically favor one combat style over another, and they either focus on attacking from
a distance, protecting themselves and their allies, or excelling at close combat. Fighters also
possess considerable physical power and vitality, and they are better in a pinch with these types
of situations. Fighters can sometimes continue battling despite having sustained injuries. Fighters
can exemplify acrobatics, animal handling, athletics, history, insight, intimidation, perception,
and survival.

Beginner Fighter
When you are allocating attribute points, strength and dexterity are equally important. Strength
will favor a melee-based fighter, and dexterity will favor a ranged-based fighter. Constitution
is also important, so don't neglect it either.

Using the Form:
Using your mouse, click on the button next to the race you want to choose. This should place
a small black dot inside of your selection.
When you are satisfied with your choice, click on the Submit button. "

            ClassHelpForm.Show() 'Load the attribute help form
        End If
    End Sub

    Private Sub StatHelpBox_Click(sender As Object, e As EventArgs) Handles StatHelpBox.Click
        If HelpFormNumberInteger = 0 Then
            HelpFormNumberInteger += 1
            Dim StatHelpForm As New HelpForm 'Create an instance of a new attribute help form
            StatHelpForm.HelpTitleLabel.Text = "How to Roll for Stats"
            StatHelpForm.HelpTextBox.Text = "Rolling Stats:
This program rolls three simulated six-sided dice, each containing a random value between 1 and 6.
These three rolls are added together, and the final score (between 3 and 18) can be assigned to
one of the six attributes every Dungeons & Dragons character has. Because there are six attributes,
six scores will be rolled before proceeding to the next step.

Using the Form:
Using your mouse, click on the Roll button. This will roll the three simulated dice. Once the dice
have been rolled, use your mouse to click on the Submit button. This will add the score to a list
which will be used to assign the six scores to each attribute."

            StatHelpForm.Show() 'Load the attribute help form
        End If
    End Sub

    Private Sub AllocationHelpBox_Click(sender As Object, e As EventArgs) Handles AllocationHelpBox.Click
        If HelpFormNumberInteger = 0 Then
            HelpFormNumberInteger += 1
            Dim AllocationHelpForm As New HelpForm 'Create an instance of a new attribute help form
            AllocationHelpForm.HelpTitleLabel.Text = "How to Allocate Stats"
            AllocationHelpForm.HelpTextBox.Text = "Allocating Attributes:
This is where you choose which scores are assigned to which attributes. Keep in mind that each score
can only be used once, so use the higher scores on attributes that are more important to your class
and gameplay style. Never neglect your constitution.

What Attributes Do:
Strength
Strength is used for anything involving a physical application of force. This is useful for executing
melee attacks, lifting items, carrying a heavier load, or breaking something. Strength also comes in
handy when navigating difficult terrain. Strength is most important to barbarians and melee-based
fighters.

Dexterity
Dexterity is good for anything involving reaction time, speed, and a delicate touch. This is useful
for executing ranged attacks, breaking and entering, stealing, visual distraction, escaping, 
and being covert. Dexterity also comes in handy when navigating unstable terrain. Dexterity is most
important to monks and range-based fighters.

Constitution
Constitution is good for anything involving endurance, being damaged, or otherwise being able to
endure threats to one's life. This is useful for going on long journeys, going without basic
needs, and enduring the effects of things like toxins. Constitution is always important, as it's what
your character's hit points are partially based on. 

Intelligence
Intelligence is good for anything involving wit, memory, or problem-solving. This is useful for
solving puzzles, remembering information, remembering how to do something, and impersonating others.
This can also be used for casting some magical spells.

Wisdom
Wisdom is good for anything involving situational awareness and prudent judgment. This is useful for
detecting subtle stimuli and evidence, determining another's intentions, aiding someone, and
determining the most sound decision to make in a situation. This can also be used for casting some
magical spells.

Charisma
Charisma is good for anything involving persuasion, captivation, and information gathering. This is
useful for distracting others, enticing others, making others let their guard down, being socially
fluid, spying, and making connections. This can also be used for casting some magical spells.

Using the Form:
Using your mouse, navigate to the box on the left. Click on the score you would like to assign.
Navigate to the box on the right using your mouse once again. Click on the attribute you would like
to assign the score to. Click the Allocate button to proceed with the assignment.
If you change your mind, clicking the Undo button will undo your last allocation. This can be
clicked multiple times.
When you are satisfied with all of your allocated attributes, click the Finalize button to proceed
to the next step."

            AllocationHelpForm.Show() 'Load the attribute help form
        End If
    End Sub

    Private Sub AttributeHelpButton_Click(sender As Object, e As EventArgs) Handles AttributeHelpButton.Click
        If HelpFormNumberInteger = 0 Then
            HelpFormNumberInteger += 1
            Dim AttributesHelpForm As New HelpForm 'Create an instance of a new attribute help form
            AttributesHelpForm.HelpTitleLabel.Text = "Character Attributes"
            AttributesHelpForm.HelpTextBox.Text = "Viewing Your Attributes:
This is where your allocated scores are displayed. Racial bonuses are also indicated in this section.
For each attribute, the score is equal to the score assigned in the previous step plus any racial
bonuses.

Using the Form:
This section is purely for display purposes, and does not require any interaction from the user."

            AttributesHelpForm.Show() 'Load the attribute help form
        End If
    End Sub

    Private Sub ProficienciesHelpBox_Click(sender As Object, e As EventArgs) Handles ProficienciesHelpBox.Click
        If HelpFormNumberInteger = 0 Then
            HelpFormNumberInteger += 1
            Dim ProficienciesHelpForm As New HelpForm 'Create an instance of a new attribute help form
            ProficienciesHelpForm.HelpTitleLabel.Text = "How to Allocate Proficiencies"
            ProficienciesHelpForm.HelpTextBox.Text = "Choosing Your Proficiencies:
This is where you choose which skills your character is proficient in. The list of skills is
pre-populated based on skills your class can be proficient in. When you are playing the game,
skill proficiency allows your character to have a better chance of doing certain actions.

What Skills Do:
Acrobatics
Acrobatics allows to you navigate narrow and unstable terrain. It also allows you to do things
a gymnast would do.

Animal Handling
Animal handling allows you to exert more effective control over animals and assess their demeanor.

Arcana
Arcana allows you to know more about alternate realities, spells, and anything related to magic.

Athletics
Athletics allows you to navigate difficult terrain. It also helps you avoid hurting yourself when
going through treacherous physical environments.

Deception
Deception allows you to effectively mislead, get one over on others, and be a better liar.

History
History allows you to know more about past occurences and important background information on
places and people.

Insight
Insight allows you to better determine the demeanor of other living things.

Intimidation
Intimidation allows you to better accomplish your goals via threatening others and using aggression.

Investigation
Investigation allows you to examine physical evidence and make inferences based on it.

Medicine
Medicine allows you to determine what is afflicting others and provide medical care to
others who are gravely injured.

Nature
Nature allows you to know more about the environment and the life within it.

Perception
Perception allows you to better sense external stimuli and pick up on more subtle stimuli.

Performance
Performance allows you to better captivate others through your actions.

Persuasion
Persuasion allows you to become better at changing the minds of others. In many ways, this is
the opposite of deception, and it is usually used on those who possess integrity or are in a
position of authority.

Religion
Religion allows you to know more about religious practices, icons, and texts.

Sleight of Hand
Sleight of hand is useful for stealing things, hiding things, and doing things requiring a light
touch undetected.

Stealth
Stealth is useful for escaping dangerous situations, remaining covert, and inching close to
someone without them noticing.

Survival
Survival allows you to navigate unknown terrain, avoid injurious terrain, and locate and
subdue animals.

Using the Form:
Using your mouse, navigate to the box on the left. Click on the skill you would like to assign.
Click the Allocate button to proceed with the assignment.
If you change your mind, clicking the Undo button will undo your last allocation. This can be
clicked multiple times.
When you are satisfied with all of your allocated attributes, click the Finalize button to proceed
to the next step."

            ProficienciesHelpForm.Show() 'Load the attribute help form
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles CantripHelpButton.Click
        If HelpFormNumberInteger = 0 Then
            HelpFormNumberInteger += 1
            Dim ProficienciesHelpForm As New HelpForm 'Create an instance of a new attribute help form
            ProficienciesHelpForm.HelpTitleLabel.Text = "How to Choose a Cantrip"
            ProficienciesHelpForm.HelpTextBox.Text =
                "A cantrip is a spell that can be cast at will, without
using a spell slot and without being prepared in
advance. Repeated practice has fixed the spell in the
caster’s mind and infused the caster with the magic
needed to produce the effect over and over. A cantrip’s
spell level is 0.

Spells have different components, which are Verbal, Somatic, and Material (I.e Material costs).

Verbal(V):
Most spells require the chanting of mystic words. The
words themselves aren’t the source of the spell’s power;
rather, the particular com bination of sounds, with
specific pitch and resonance, sets the threads of magic
in motion. Thus, a character who is gagged or in an area
of silence, such as one created by the silence spell, can’t
cast a spell with a verbal component.

Somatic(S):
Spellcasting gestures might include a forceful
gesticulation or an intricate set of gestures. If a spell
requires a somatic component, the caster must have free
use of at least one hand to perform these gestures

Material(M):
Casting some spells requires particular objects,
specified in parentheses in the component entry.
A character can use a component pouch or a
spellcasting focus in place of
the components specified for a spell. But if a cost is
indicated for a component, a character must have that
specific com ponent before he or she can cast the spell.
If a spell states that a material com ponent is
consum ed by the spell, the caster must provide this
com ponent for each casting of the spell.
A spellcaster must have a hand free to access these
com ponents, but it can be the same hand that he or she
uses to perform som atic com ponents.


Here are a list of the different cantrips that you have access to as a High Elf:


Acid Splash
Conjuration cantrip
Casting Time: 1 action 
Range: 60 feet 
Components: V, S 
Duration: Instantaneous
You hurl a bubble of acid. Choose one creature within 
range, or choose two creatures within range that are 
within 5 feet of each other. A target must succeed on a 
Dexterity saving throw or take 1d6 acid damage.
This spell’s damage increases by 1d6 when you reach 
5th level (2d6), 11th level (3d6), and 17th level (4d6).

Blade Ward
Abjuration cantrip
Casting Time: 1 action 
Range: Self 
Components: V, S 
Duration: 1 round You extend your hand and trace a sigil of warding in the 
air. Until the end of your next turn, you have resistance 
against bludgeoning, piercing, and slashing damage 
dealt by weapon attacks.

Chill Touch
Necromancy cantrip
Casting Time: 1 action 
Range: 120 feet 
Components: V, S 
Duration: 1 round
You create a ghostly, skeletal hand in the space of a 
creature within range. Make a ranged spell attack 
against the creature to assail it with the chill of the 
grave. On a hit, the target takes 1d8 necrotic damage, 
and it can’t regain hit points until the start of your next 
turn. Until then, the hand clings to the target.
If you hit an undead target, it also has disadvantage on 
attack rolls against you until the end of your next turn.
This spell’s damage increases by 1d8 when you reach 
5th level (2d8), 11th level (3d8), and 17th level (4d8).

Dancing Lights
Evocation cantrip
Casting Time: 1 action 
Range: 120 feet
Components: V, S, M (a bit of phosphorus or wychwood, 
or a glowworm )
Duration: Concentration, up to 1 minute
You create up to four torch-sized lights within range, 
making them appear as torches, lanterns, or glowing 
orbs that hover in the air for the duration. You can 
also combine the four lights into one glowing vaguely 
humanoid form of Medium size. Whichever form you 
choose, each light sheds dim light in a 10-foot radius.
As a bonus action on your turn, you can move the 
lights up to 60 feet to a new spot within range. A light 
must be within 20 feet of another light created by this 
spell, and a light winks out if it exceeds the spell’s range.

Fire Bolt
Evocation cantrip
Casting Time: 1 action
Range: 120 feet 
Components: V, S 
Duration: Instantaneous
You hurl a mote of fire at a creature or object within 
range. Make a ranged spell attack against the 
target. On a hit, the target takes 1d10 fire damage. A 
flammable object hit by this spell ignites if it isn't being 
worn or carried.
This spell’s damage increases by 1d10 when you reach 
5th level (2d10), 11th level (3d10), and 17th level (4d10).

Friends
Enchantment cantrip
Casting Time: 1 action 
Range: Self
Components: S, M (a small amount of makeup applied 
to the face as this spell is cast)
Duration: Concentration, up to 1 minute
For the duration, you have advantage on all Charisma 
checks directed at one creature of your choice that isn’t 
hostile toward you. When the spell ends, the creature 
realizes that you used magic to influence its mood 
and becomes hostile toward you. A creature prone 
to violence might attack you. Another creature might 
seek retribution in other ways (at the DM ’s discretion), 
depending on the nature of your interaction with it.

Light
Evocation cantrip
Casting Time: 1 action 
Range: Touch
Components: V, M (a firefly or phosphorescent moss) 
Duration: 1 hour
You touch one object that is no larger than 10 feet in any 
dimension. Until the spell ends, the object sheds bright 
light in a 20-foot radius and dim light for an additional 
20 feet. The light can be colored as you like. Completely 
covering the object with something opaque blocks the 
light. The spell ends if you cast it again or dismiss it 
as an action.
If you target an object held or worn by a hostile 
creature, that creature must succeed on a Dexterity 
saving throw to avoid the spell.

Mage Hand
Conjuration cantrip
Casting Time: 1 action 
Range: 30 feet 
Components: V, S 
Duration: 1 minute
A spectral, floating hand appears at a point you choose 
within range. The hand lasts for the duration or until 
you dismiss it as an action. The hand vanishes if it is 
ever m ore than 30 feet away from you or if you cast 
this spell again.
You can use your action to control the hand. You can 
use the hand to manipulate an object, open an unlocked 
door or container, stow or retrieve an item from an open 
container, or pour the contents out of a vial. You can 
move the hand up to 30 feet each time you use it.
The hand can’t attack, activate magic items, or carry 
more than 10 pounds.

Mending
Transmutation cantrip
Casting Time: 1 minute 
Range: Touch
Components: V, S, M (two lodestones)
Duration: Instantaneous
This spell repairs a single break or tear in an object 
you touch, such as a broken chain link, two halves of 
a broken key, a torn cloak, or a leaking wineskin. As 
long as the break or tear is no larger than 1 foot in 
any dimension, you mend it. leaving no trace of the 
former damage.
This spell can physically repair a magic item 
or construct, but the spell can’t restore magic to 
such an object.

Message
Transmutation cantrip
Casting Time: 1 action 
Range: 120 feet
Components: V, S, M (a short piece of copper wire) 
Duration: 1 round
You point your finger toward a creature within range 
and whisper a message. The target (and only the target) 
hears the message and can reply in a whisper that only 
you can hear.
You can cast this spell through solid objects if you 
are familiar with the target and know it is beyond 
the barrier. Magical silence. 1 foot of stone, 1 inch of 
com m on metal, a thin sheet of lead, or 3 feet of wood 
blocks the spell. The spell doesn’t have to follow a 
straight line and can travel freely around corners or 
through openings.

Minor Illusion
Illusion cantrip
Casting Time: 1 action 
Range: 30 feet
Components: S, M (a bit of fleece)
Duration: 1 minute
You create a sound or an image of an object within 
range that lasts for the duration. The illusion also ends if 
you dismiss it as an action or cast this spell again.
If you create a sound, its volume can range from a 
whisper to a scream . It can be your voice, someone 
else’s voice, a lion’s roar, a beating of drums, or any 
other sound you choose. The sound continues unabated 
throughout the duration, or you can make discrete 
sounds at different times before the spell ends.
If you create an image of an object—such as a chair, 
muddy footprints, or a small chest—it must be no larger 
than a 5-foot cube. The image can’t create sound, light, 
smell, or any other sensory effect. Physical interaction 
with the image reveals it to be an illusion, because 
things can pass through it.
If a creature uses its action to examine the sound or 
image, the creature can determine that it is an illusion 
with a successful Intelligence (Investigation) check 
against your spell save DC. If a creature discerns the 
illusion for what it is, the illusion becomes faint to 
the creature.

Poison Spray
Conjuration cantrip
Casting Time: 1 action
Range: 10 feet 
Components: V, S 
Duration: Instantaneous
You extend your hand toward a creature you can see 
within range and project a puff of noxious gas from your 
palm. The creature must succeed on a Constitution 
saving throw or take 1d12 poison damage.
This spell’s damage increases by 1d12 when you reach 
5th level (2d12), 11th level (3d12), and 17th level (4d12).

Prestidigitation
Transmutation cantrip
Casting Time: 1 action 
Range: 10 feet 
Components: V, S 
Duration: Up to 1 hour
This spell is a m inormagical trick that novice 
spellcasters use for practice. You create one of the 
following magical effects within range:
• You create an instantaneous, harm less sensory effect, 
such as a shower of sparks, a puff of wind, faint musical notes, or an odd odor.
• You instantaneously light or snuff out a candle, a 
torch, or a small campfire.
• You instantaneously clean or soil an object no larger 
than 1 cubic foot.
• You chill, warm, or flavor up to 1 cubic foot of nonliving material for 1 hour.
• You make a color, a small mark, or a symbol appear 
on an object or a surface for 1 hour.
• You create a nonmagical trinket or an illusory image 
that can fit in your hand and that lasts until the end of 
your next turn.
If you cast this spell multiple times, you can have up to 
three o f its non-instantaneous effects active at a time, 
and you can dismiss such an effect as an action.

Ray of Frost
Evocation cantrip
Casting Time: 1 action 
Range: 60 feet 
Components: V, S 
Duration: Instantaneous
A frigid beam o f blue-white light streaks toward a 
creature within range. Make a ranged spell attack 
against the target. On a hit, it takes 1d8 cold damage, 
and its speed is reduced by 10 feet until the start of 
your next turn.
The spell’s damage increases by 1d8 when you reach 
5th level (2d8), 11th level (3d8), and 17th level (4d8).

Shocking Grasp
Evocation cantrip
Casting Time: 1 action 
Range: Touch 
Components: V, S
Duration: Instantaneous
Lightning springs from your hand to deliver a shock to 
a creature you try to touch. Make a melee spell attack 
against the target. You have advantage on the attack roll 
if the target is wearing arm or made of metal. On a hit, 
the target takes 1d8 lightning damage, and it can’t take 
reactions until the start of its next turn.
The spell’s damage increases by 1d8 when you reach 
5th level (2d8), 11th level (3d8), and 17th level (4d8).

True Strike
Divination cantrip
Casting Time: 1 action 
Range: 30 feet 
Components: S
Duration: Concentration, up to 1 round
You extend your hand and point a finger at a target in 
range. Your magic grants you a brief insight into the
target’s defenses. On your next turn, you gain advantage 
on your first attack roll against the target, provided that 
this spell hasn’t ended."
            ProficienciesHelpForm.Show()
        End If
    End Sub

    Private Sub CantripButton_Click(sender As Object, e As EventArgs) Handles CantripButton.Click
        CantripGroupBox.Enabled = False
        CantripButton.Enabled = False
        FinalSubmitButton.Visible = True
    End Sub

    Private Sub FinalSubmitButton_Click(sender As Object, e As EventArgs) Handles FinalSubmitButton.Click
        Dim CharacterSheet As New FinalCharacterSheet
        CharacterSheet.Show()
    End Sub

End Class
