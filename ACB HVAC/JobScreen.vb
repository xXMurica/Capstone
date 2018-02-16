Imports System.Data.OleDb
Imports System.Data

Public Class JobScreen
    Dim provider As String
    Dim dataFile As String
    Dim connstring As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If LNameTextBox.Text = "" Then
            MsgBox("Fill in a Last Name, Please!")
        Else
            Dim querry As String = "SELECT * From Customer WHERE (LastName = '" & LNameTextBox.Text & "')"
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
                    StateComboBox.Text = dr("State").ToString
                    ZipTextBox.Text = dr("Zip").ToString
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
        StateComboBox.Text = String.Empty
        ZipTextBox.Text = String.Empty
        TechTextBox.Text = String.Empty
        TimeTextBox.Text = String.Empty
        BalanceTextBox.Text = String.Empty
        StateComboBox.Text = String.Empty
        ItemNumberTextBox.Text = String.Empty
        AmountTextBox.Text = String.Empty


    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        If LNameTextBox.Text = "" Or PhoneTextBox.Text = "" Or StreetTextBox.Text = "" Or CityTextBox.Text = "" Or StateComboBox.Text = "" Or ZipTextBox.Text = "" Then
            MsgBox("All Fields Must be filled out")
        Else
            provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            dataFile = "C:\capstone\ABC_HVAC1.accdb"
            connstring = provider & dataFile
            myConnection.Close()
            myConnection.ConnectionString = connstring
            myConnection.Open()
            Dim str As String

            str = "Insert into Customer([FirstName],[LastName],[HomePhone],[Address],[City],[State],[Zip],[Balance],[Time],[TID],[ItemCode],[Amount]) Values(?,?,?,?,?,?,?,?,?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            cmd.Parameters.Add(New OleDbParameter("FirstName", CType(FNameTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("LastName", CType(LNameTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("HomePhone", CType(PhoneTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Address", CType(StreetTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("City", CType(CityTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("State", CType(StateComboBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Zip", CType(ZipTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Balance", CType(BalanceTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Time", CType(TimeTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("TID", CType(TechTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("ItemCode", CType(ItemNumberTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Amount", CType(AmountTextBox.Text, String)))



            If IsNumeric(PhoneTextBox.Text) Then
                If IsNumeric(ZipTextBox.Text) Then
                    Try
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        myConnection.Close()
                        MsgBox("Account Created Successful!")
                        LNameTextBox.Text = String.Empty
                        FNameTextBox.Text = String.Empty
                        PhoneTextBox.Text = String.Empty
                        StreetTextBox.Text = String.Empty
                        CityTextBox.Text = String.Empty
                        StateComboBox.Text = String.Empty
                        ZipTextBox.Text = String.Empty
                        TechTextBox.Text = String.Empty
                        TimeTextBox.Text = String.Empty
                        BalanceTextBox.Text = String.Empty
                        StateComboBox.Text = String.Empty
                        ItemNumberTextBox.Text = String.Empty
                        AmountTextBox.Text = String.Empty

                    Catch ex As Exception
                        MessageBox.Show(ex.Message & " - " & ex.Source)
                        MsgBox("Oops! Something Happened")
                    End Try
                Else
                    MsgBox("Zip Code must be numeric")
                End If
            Else
                MsgBox("Phone Number must be numeric")
            End If
        End If
    End Sub

    Private Sub JobScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StateComboBox.Items.Add("AL")
        StateComboBox.Items.Add("AK")
        StateComboBox.Items.Add("AZ")
        StateComboBox.Items.Add("AR")
        StateComboBox.Items.Add("CA")
        StateComboBox.Items.Add("CO")
        StateComboBox.Items.Add("CT")
        StateComboBox.Items.Add("DE")
        StateComboBox.Items.Add("DC")
        StateComboBox.Items.Add("FL")
        StateComboBox.Items.Add("GA")
        StateComboBox.Items.Add("HI")
        StateComboBox.Items.Add("ID")
        StateComboBox.Items.Add("IL")
        StateComboBox.Items.Add("IN")
        StateComboBox.Items.Add("IA")
        StateComboBox.Items.Add("KS")
        StateComboBox.Items.Add("KY")
        StateComboBox.Items.Add("LA")
        StateComboBox.Items.Add("MA")
        StateComboBox.Items.Add("MD")
        StateComboBox.Items.Add("ME")
        StateComboBox.Items.Add("MI")
        StateComboBox.Items.Add("MN")
        StateComboBox.Items.Add("MS")
        StateComboBox.Items.Add("MO")
        StateComboBox.Items.Add("MT")
        StateComboBox.Items.Add("NC")
        StateComboBox.Items.Add("ND")
        StateComboBox.Items.Add("NE")
        StateComboBox.Items.Add("NH")
        StateComboBox.Items.Add("NJ")
        StateComboBox.Items.Add("NM")
        StateComboBox.Items.Add("NV")
        StateComboBox.Items.Add("NY")
        StateComboBox.Items.Add("OH")
        StateComboBox.Items.Add("OK")
        StateComboBox.Items.Add("OR")
        StateComboBox.Items.Add("RI")
        StateComboBox.Items.Add("SC")
        StateComboBox.Items.Add("SD")
        StateComboBox.Items.Add("TN")
        StateComboBox.Items.Add("TX")
        StateComboBox.Items.Add("UT")
        StateComboBox.Items.Add("VT")
        StateComboBox.Items.Add("VA")
        StateComboBox.Items.Add("VI")
        StateComboBox.Items.Add("WA")
        StateComboBox.Items.Add("WV")
        StateComboBox.Items.Add("WI")
        StateComboBox.Items.Add("WY")
    End Sub


End Class