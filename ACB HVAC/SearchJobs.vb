Imports System.Data.OleDb
Imports System.Data

Public Class SearchJobs
    Dim provider As String
    Dim dataFile As String
    Dim connstring As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

        If JobTextBox.Text = "" Then
            MsgBox("Fill in a Job Number, Please!")
        Else
            Dim querry As String = "SELECT * From Schedule WHERE (JobID = " & JobTextBox.Text & ")"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\capstone\ABC_HVAC1.accdb"
            Dim conn = New OleDbConnection(dbsource)

            Try
                conn.Open()
                Dim cmd As New OleDbCommand(querry, conn)
                dr = cmd.ExecuteReader
                While dr.Read()
                    My.Forms.CustomerDisplay.Show()
                    My.Forms.CustomerDisplay.TimeTextBox.Text = dr("Time")
                    My.Forms.CustomerDisplay.TechTextBox.Text = dr("Job.TID")
                    My.Forms.CustomerDisplay.FNameTextBox.Text = dr("FirstName").ToString
                    My.Forms.CustomerDisplay.LNameTextBox.Text = dr("LastName").ToString
                    My.Forms.CustomerDisplay.PhoneTextBox.Text = dr("HomePhone").ToString
                    My.Forms.CustomerDisplay.StreetTextBox.Text = dr("Address").ToString
                    My.Forms.CustomerDisplay.CityTextBox.Text = dr("City").ToString
                    My.Forms.CustomerDisplay.StateTextBox.Text = dr("State").ToString
                    My.Forms.CustomerDisplay.ZipTextBox.Text = dr("Zip").ToString
                End While
            Catch ex As Exception
                'Catch doesnt catch anything error check
                MessageBox.Show(ex.Message & " - " & ex.Source)
                MsgBox("Oops! Try Again!")

            End Try
            conn.Close()
        End If
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