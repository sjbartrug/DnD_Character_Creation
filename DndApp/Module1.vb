Module DndValues

	Dim DndDiceRNG As New Random

	Public Function RollDndDice(numOfSides As Integer) As Integer
		Return (DndDiceRNG.Next(numOfSides) + 1)
	End Function
	Public Enum DndDice As Integer
		ONE_D_SIX = 6
	End Enum

End Module
