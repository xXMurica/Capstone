﻿Public NotInheritable Class SplashScreen1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            LoginScreen.Show()
            Me.Hide()
            Timer1.Enabled = False
        End If
    End Sub
End Class
