Public Class AssignedAttribute
	Private lastAttributeIndex As Integer
	Private lastAttributeName As String
	Private lastRollIndex As Integer
	Private lastRollValue As Integer

	' Constructor
	Public Sub New(ByVal attributeIndex As Integer, ByVal attributeName As String,
				   ByVal rollIndex As Integer, ByVal rollValue As Integer)
		lastAttributeIndex = attributeIndex
		lastAttributeName = attributeName
		lastRollIndex = rollIndex
		lastRollValue = rollValue
	End Sub

	' Setters and getters
	Public Property IndexOfLastAttribute() As Integer
		Get
			Return lastAttributeIndex
		End Get
		Set(ByVal attributeIndex As Integer)
			lastAttributeIndex = attributeIndex
		End Set
	End Property

	Public Property NameOfLastAttribute() As String
		Get
			Return lastAttributeName
		End Get
		Set(ByVal attributeName As String)
			lastAttributeName = attributeName
		End Set
	End Property

	Public Property IndexOfLastRoll() As Integer
		Get
			Return lastRollIndex
		End Get
		Set(ByVal rollIndex As Integer)
			lastRollIndex = rollIndex
		End Set
	End Property

	Public Property ValueOfLastRoll() As Integer
		Get
			Return lastRollValue
		End Get
		Set(ByVal rollValue As Integer)
			lastRollValue = rollValue
		End Set
	End Property
End Class
