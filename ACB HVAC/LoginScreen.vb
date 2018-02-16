Public Class LoginScreen
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        My.Forms.SignIn.Text = Now.ToString
        My.Forms.SignIn.Show()
        Me.Close()
    End Sub

    Private Sub CreateAccount_Click(sender As Object, e As EventArgs) Handles CreateAccount.Click
        My.Forms.CreateAccount.Text = Now.ToString
        My.Forms.CreateAccount.Show()
        Me.Close()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub
End Class
