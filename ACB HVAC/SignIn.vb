Imports System.Data.OleDb
Imports System.Data

Public Class SignIn

    Private Sub SignInButton_Click(sender As Object, e As EventArgs) Handles SignInButton.Click
        Dim UserName As String = ""
        Dim Password As String = ""
        Dim usname As String = ""
        Dim pass As String = ""
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Enter Username / Password")
        Else
            UserName = TextBox1.Text
            Password = TextBox2.Text
            Dim querry As String = "Select Password From EMPLOYEE where UserName= '" & UserName & "';"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\capstone\ABC_HVAC1.accdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MsgBox("Username Incorrect.")
            End Try
            If (Password = pass) Then
                MsgBox("Login success!")
                SecHome.Show()
                If SecHome.Visible Then
                    Me.Hide()
                End If
            Else
                MsgBox("Login Failed, check password.")
            End If
        End If

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        My.Forms.LoginScreen.Text = Now.ToString
        My.Forms.LoginScreen.Show()
        Me.Close()
    End Sub

    Private Sub ForgotButton_Click(sender As Object, e As EventArgs) Handles ForgotButton.Click
        ErrorLabel.Text = "Please Call 614/867-5309 to get Password Reset"
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Dim a As Control

        For Each a In Me.Controls

            If TypeOf a Is TextBox Then

                a.Text = Nothing

            End If
        Next

    End Sub

End Class