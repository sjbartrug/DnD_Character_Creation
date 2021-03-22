Public Class HelpForm
    Private Sub closeAttributeHelpButton_Click(sender As Object, e As EventArgs) Handles closeAttributeHelpButton.Click
        Me.Close()
    End Sub

    Private Sub HelpForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        HelpFormNumberInteger -= 1
    End Sub
End Class