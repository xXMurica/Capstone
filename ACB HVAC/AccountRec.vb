Imports System.Data.OleDb
Imports System.Data
Public Class AccountRec
    Dim provider As String
    Dim dataFile As String
    Dim connstring As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Private Sub Pay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PayComboBox.Items.Add("")
        PayComboBox.Items.Add("VISA")
        PayComboBox.Items.Add("Mastercard")
        PayComboBox.Items.Add("Discover")
        PayComboBox.Items.Add("American Express")

        MonthComboBox.Items.Add("")
        MonthComboBox.Items.Add("Jan")
        MonthComboBox.Items.Add("Feb")
        MonthComboBox.Items.Add("Mar")
        MonthComboBox.Items.Add("Apr")
        MonthComboBox.Items.Add("May")
        MonthComboBox.Items.Add("Jun")
        MonthComboBox.Items.Add("Jul")
        MonthComboBox.Items.Add("Aug")
        MonthComboBox.Items.Add("Sep")
        MonthComboBox.Items.Add("Oct")
        MonthComboBox.Items.Add("Nov")
        MonthComboBox.Items.Add("Dec")

        DateComboBox.Items.Add("")
        DateComboBox.Items.Add("2017")
        DateComboBox.Items.Add("2018")
        DateComboBox.Items.Add("2019")
        DateComboBox.Items.Add("2020")
        DateComboBox.Items.Add("2021")



    End Sub
    Private Sub SecurityTextBox_TextChanged(sender As Object, e As EventArgs) Handles SecurityTextBox.TextChanged
        If PayComboBox.Text = "American Express" Then
            SecurityTextBox.MaxLength = 4
        Else
            SecurityTextBox.MaxLength = 3
        End If
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If AccountTextBox.Text = "" Then
            MsgBox("Fill in a Job Number, Please!")
        Else
            Dim querry As String = "SELECT * From Customer WHERE (CID = " & AccountTextBox.Text & ")"
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
                End While
            Catch ex As Exception

                MessageBox.Show(ex.Message & " - " & ex.Source)
                MsgBox("Oops! Try Again!")

            End Try
            conn.Close()
        End If
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim NewTotal As Integer
        If CreditCardTextBox.Text = "" Or SecurityTextBox.Text = "" Or AmountTextBox.Text = "" Or NameTextBox.Text = "" Then
            MsgBox("All Fields Must be filled out!")
        Else
            provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            dataFile = "C:\capstone\ABC_HVAC1.accdb"
            connstring = provider & dataFile
            myConnection.Close()
            myConnection.ConnectionString = connstring
            myConnection.Open()
            Dim str As String
            NewTotal = Convert.ToDouble(Double.Parse(BalanceTextBox.Text)) - Convert.ToDouble(Double.Parse(AmountTextBox.Text))
            str = "Update [Customer] set [Balance] = '" & NewTotal & "'Where ([CID]= " & AccountTextBox.Text & ")"


            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

            If IsNumeric(CreditCardTextBox.Text) Then
                If IsNumeric(SecurityTextBox.Text) Then
                    BalanceTextBox.Text = NewTotal
                    Try
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        myConnection.Close()
                        MsgBox("Payment Recieved!")
                        SecurityTextBox.Text = String.Empty
                        CreditCardTextBox.Text = String.Empty
                        NameTextBox.Text = String.Empty
                        PayComboBox.Text = ""
                        AmountTextBox.Text = String.Empty
                        DateComboBox.Text = ""
                        MonthComboBox.Text = ""
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    MsgBox("Security Box Must be Numeric")
                    End If
                Else
                    MsgBox("Credit Card Must Be Numeric")
                End If

        End If
    End Sub


End Class