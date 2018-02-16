Imports System.Data.OleDb
Imports System.Data
Imports System.Text.RegularExpressions

Public Class CreateAccount

    Dim provider As String
    Dim dataFile As String
    Dim connstring As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        My.Forms.LoginScreen.Text = Now.ToString
        My.Forms.LoginScreen.Show()
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Dim a As Control

        For Each a In Me.Controls

            If TypeOf a Is TextBox Then

                a.Text = Nothing

            End If

        Next

    End Sub

    Public Function validateEmail(emailAddress) As Boolean

        Dim TextBox3 As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If TextBox3.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or PhoneTextBox.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Then
            MsgBox("All Fields Must be filled out")
        Else
            provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            dataFile = "C:\capstone\ABC_HVAC1.accdb"
            connstring = provider & dataFile
            myConnection.Close()
            myConnection.ConnectionString = connstring
            myConnection.Open()
            Dim str As String

            str = "Insert into Employee([EmployeeFirst],[EmployeeLast],[Department],[Job],[Phone],[Email],[UserName],[Password]) Values(?,?,?,?,?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            cmd.Parameters.Add(New OleDbParameter("EmployeeFirst", CType(TextBox1.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("EmployeeLast", CType(TextBox2.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Department", CType(TextBox4.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Job", CType(TextBox5.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Phone", CType(PhoneTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Email", CType(TextBox3.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("UserName", CType(TextBox7.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Password", CType(TextBox8.Text, String)))


            If validateEmail(TextBox3.Text) = True Then
                If IsNumeric(PhoneTextBox.Text) = True Then
                    If (TextBox8.Text = TextBox9.Text) Then

                        Try
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                            myConnection.Close()
                            MsgBox("Account Created Successful!")
                            Dim a As Control

                            For Each a In Me.Controls

                                If TypeOf a Is TextBox Then

                                    a.Text = Nothing

                                End If

                            Next
                        Catch ex As Exception
                            MessageBox.Show(ex.Message & " - " & ex.Source)
                            MsgBox("Oops! Something Happened")
                        End Try

                    Else
                        MsgBox("Passwords do not match")
                    End If
                Else
                    MsgBox("Phone Number is not numeric")
                End If
            Else
                    MsgBox("Email is not Valid")

            End If
        End If
    End Sub
End Class