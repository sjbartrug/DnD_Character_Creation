Module DndValues

	Dim DndDiceRNG As New Random

	Public Enum DndDice As Integer
		ONE_D_SIX = 6
	End Enum

	Public Function RollDndDice(numOfSides As Integer) As Integer
		Return (DndDiceRNG.Next(numOfSides) + 1)
	End Function

End Module
