Public Class HelpForm
    Private Sub closeAttributeHelpButton_Click(sender As Object, e As EventArgs) Handles closeAttributeHelpButton.Click
        HelpFormNumberInteger -= 1
        Me.Close()
    End Sub
End Class