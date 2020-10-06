Public Class WindowsFormAppForm

    Private Sub WindowsFormAppForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim tempNumber As Integer
        Try
            tempNumber = CInt(UserInputTextBox.Text) 'Could crash program
            Me.Text = tempNumber.ToString 'won't happen if exception is raise
            Select Case tempNumber
                Case 0 To 3
                    MsgBox("Where are your parents?")
                Case 3 To 5
                    MsgBox("You're too short go back to the kiddy rides?")
                Case 6 To 12
                    MsgBox("Sometimes the parts fall off.. don't worry we have extra.. enjoy the ride!")
                Case Else
                    MsgBox("Are you lost??")
            End Select

        Catch
            MsgBox("Huh?....")

        End Try
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        Dim temp As String

        Me.Text = "You changed the title!"
        temp = UserInputTextBox.Text
        UserInputTextBox.Text = StrReverse(temp)

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


End Class
