Module DndValues

	'Program level
	Public Const NUM_OF_ATTRIBUTES As Integer = 6
	Public Const NUM_OF_SKILLS As Integer = 18
	Public Const L1_PROFICIENCY_BONUS As Integer = 2

	Public attributeHelpFormCount As Integer = 0

	'Module level
	Dim DndDiceRNG As New Random

	Dim humanBonuses() As Integer = {1, 1, 1, 1, 1, 1}
	Dim highElfBonuses() As Integer = {0, 2, 0, 1, 0, 0}
	Dim woodElfBonuses() As Integer = {0, 2, 0, 0, 1, 0}
	Dim tieflingBonuses() As Integer = {0, 0, 0, 1, 0, 2}

	Dim barbarianThrowProficiencies() As Boolean = {True, False, True, False, False, False}
	Dim monkThrowProficiencies() As Boolean = {True, True, False, False, False, False}
	Dim fighterThrowProficiencies() As Boolean = {True, False, True, False, False, False}

	Dim raceNames() As String = {"Human", "High Elf", "Wood Elf", "Tiefling"}

	Dim skillNames() As String = {"Acrobatics", "Animal Handling", "Arcana", "Athletics",
		"Deception", "History", "Insight", "Intimidation", "Investigation", "Medicine",
		"Nature", "Perception", "Performance", "Persuasion", "Religion", "Sleight of Hand",
		"Stealth", "Survival"}

	Dim barbarianSkills() As String = {"Animal Handling", "Athletics", "Intimidation",
		"Nature", "Perception", "Survivial"}

	Dim monkSkills() As String = {"Acrobatics", "Athletics", "History", "Insight",
		"Religion", "Stealth"}

	Dim fighterSkills() As String = {"Acrobatics", "Animal Handling", "Athletics",
		"History", "Insight", "Intimidation", "Perception", "Survival"}

	Public Enum DndDice As Integer
		ONE_D_SIX = 6
	End Enum

	Public Enum DndRace As Integer
		HUMAN = 0
		HIGH_ELF = 1
		WOOD_ELF = 2
		TIEFLING = 3
	End Enum

	Public Enum DndClass As Integer
		BARBARIAN = 0
		MONK = 1
		FIGHTER = 2
	End Enum

	Public Enum DndAttribute As Integer
		STRENGTH = 0
		DEXTERITY = 1
		CONSTITUTION = 2
		INTELLIGENCE = 3
		WISDOM = 4
		CHARISMA = 5
	End Enum

	Public Enum DndSkill As Integer
		ACROBATICS = 0
		ANIMAL_HANDLING = 1
		ARCANA = 2
		ATHLETICS = 3
		DECEPTION = 4
		HISTORY = 5
		INSIGHT = 6
		INTIMIDATION = 7
		INVESTIGATION = 8
		MEDICINE = 9
		NATURE = 10
		PERCEPTION = 11
		PERFORMANCE = 12
		PERSUASION = 13
		RELIGION = 14
		SLEIGHT_OF_HAND = 15
		STEALTH = 16
		SURVIVAL = 17
	End Enum

	Public Function RollDndDice(ByVal numOfSides As Integer) As Integer
		Return (DndDiceRNG.Next(numOfSides) + 1)
	End Function

	Public Function GetRaceName(ByVal race As Integer) As String
		Return raceNames(race)
	End Function

	Public Function GetBaseModifier(ByVal attributeValue As Integer) As Integer
		Return (attributeValue - 10) / 2
	End Function

	Public Function GetSkillIndex(ByVal skillName As String) As Integer
		For currentIndex = 0 To (skillNames.Length - 1)
			If skillName = skillNames(currentIndex) Then
				Return currentIndex
			End If
		Next

		Return 0
	End Function

	Public Function GetSkillName(ByVal skill As Integer) As String
		Return skillNames(skill)
	End Function

	Public Function GetClassSkillList(ByVal playerClass As Integer) As String()
		Select Case playerClass
			Case DndClass.BARBARIAN
				Return barbarianSkills
			Case DndClass.MONK
				Return monkSkills
			Case DndClass.FIGHTER
				Return fighterSkills
			Case Else
				Return {}
		End Select
	End Function

	Public Function GetRacialBonus(ByVal race As Integer, ByVal attribute As Integer) As Integer
		Select Case race
			Case DndRace.HUMAN
				Return humanBonuses(attribute)
			Case DndRace.HIGH_ELF
				Return highElfBonuses(attribute)
			Case DndRace.WOOD_ELF
				Return woodElfBonuses(attribute)
			Case DndRace.TIEFLING
				Return tieflingBonuses(attribute)
			Case Else
				Return 0
		End Select
	End Function

	Public Function GetSavingThrowBonus(ByVal playerClass As Integer, ByVal attribute As Integer, ByVal proficencyBonus As Integer) As Integer
		Select Case playerClass
			Case DndClass.BARBARIAN
				If barbarianThrowProficiencies(attribute) = True Then
					Return proficencyBonus
				End If
			Case DndClass.MONK
				If barbarianThrowProficiencies(attribute) = True Then
					Return proficencyBonus
				End If
			Case DndClass.FIGHTER
				If barbarianThrowProficiencies(attribute) = True Then
					Return proficencyBonus
				End If
		End Select

		Return 0
	End Function

End Module
