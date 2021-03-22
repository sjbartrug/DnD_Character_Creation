Public Class AssignedProficiencies
	Private ProficiencyIndex As Integer
	Private ProficiencyName As String
	' Constructor
	Public Sub New(ByVal ProfIndex As Integer, ByVal ProfName As String)
		ProficiencyIndex = ProfIndex
		ProficiencyName = ProfName

	End Sub

	' Setters and getters
	Public Property IndexOfLastProficiency() As Integer
		Get
			Return ProficiencyIndex
		End Get
		Set(ByVal ProfIndex As Integer)
			ProficiencyIndex = ProfIndex
		End Set
	End Property

	Public Property NameOfLastProficiency() As String
		Get
			Return ProficiencyName
		End Get
		Set(ByVal ProfName As String)
			ProficiencyName = ProfName
		End Set
	End Property

End Class
