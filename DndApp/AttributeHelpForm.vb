Public Class AttributeHelpForm
    Private Sub closeAttributeHelpButton_Click(sender As Object, e As EventArgs) Handles closeAttributeHelpButton.Click
        attributeHelpFormCount -= 1

        Me.Close()
    End Sub
End Class