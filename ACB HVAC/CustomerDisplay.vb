Imports System.Data.OleDb
Imports System.Data

Public Class CustomerDisplay
    Dim provider As String
    Dim dataFile As String
    Dim connstring As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim LastName As String = ""
        Dim LName As String = ""
        If SearchTextBox.Text = "" Then
            MsgBox("Fill in a Last Name, Please!")
        Else
            Dim querry As String = "SELECT * From Customer WHERE (HomePhone = '" & SearchTextBox.Text & "')"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\capstone\ABC_HVAC1.accdb"

            Dim conn = New OleDbConnection(dbsource)

            Try
                conn.Open()
                Dim cmd As New OleDbCommand(querry, conn)
                dr = cmd.ExecuteReader
                While dr.Read()
                    FNameTextBox.Text = dr("FirstName").ToString
                    LNameTextBox.Text = dr("LastName").ToString
                    PhoneTextBox.Text = dr("HomePhone").ToString
                    StreetTextBox.Text = dr("Address").ToString
                    CityTextBox.Text = dr("City").ToString
                    StateTextBox.Text = dr("State").ToString
                    ZipTextBox.Text = dr("Zip").ToString
                    BalanceTextBox.Text = dr("Balance").ToString
                    TimeTextBox.Text = dr("Time").ToString
                    TechTextBox.Text = dr("TID").ToString
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
        LNameTextBox.Text = String.Empty
        FNameTextBox.Text = String.Empty
        PhoneTextBox.Text = String.Empty
        StreetTextBox.Text = String.Empty
        CityTextBox.Text = String.Empty
        StateTextBox.Text = String.Empty
        ZipTextBox.Text = String.Empty
        TechTextBox.Text = String.Empty
        TimeTextBox.Text = String.Empty
        BalanceTextBox.Text = String.Empty
        SearchTextBox.Text = String.Empty

    End Sub


End Class