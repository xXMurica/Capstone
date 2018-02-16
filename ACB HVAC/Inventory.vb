Imports System.Data.OleDb
Imports System.Data

Public Class Inventory
    Dim provider As String
    Dim dataFile As String
    Dim connstring As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

        If ItemTextBox.Text = "" Then
            MsgBox("Fill in a Item Number, Please!")
        Else
            Dim querry As String = "SELECT * From Inventory WHERE (ItemCode = " & ItemTextBox.Text & ")"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\capstone\ABC_HVAC1.accdb"

            Dim conn = New OleDbConnection(dbsource)

            Try
                conn.Open()
                Dim cmd As New OleDbCommand(querry, conn)
                dr = cmd.ExecuteReader
                While dr.Read()
                    BrandTextBox.Text = dr("Make").ToString
                    ModelTextBox.Text = dr("Model").ToString
                    EnergyTextBox.Text = dr("EnergyType").ToString
                    AOCTextBox.Text = dr("AOC").ToString
                    PriceTextBox.Text = dr("Price").ToString
                    DescriptionBox.Text = dr("Description").ToString
                    BTUTextBox.Text = dr("BTU").ToString
                    AvailableTextBox.Text = dr("Available").ToString
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
        ItemTextBox.Text = String.Empty
        BrandTextBox.Text = String.Empty
        ModelTextBox.Text = String.Empty
        EnergyTextBox.Text = String.Empty
        AOCTextBox.Text = String.Empty
        PriceTextBox.Text = String.Empty
        DescriptionBox.Text = String.Empty
        BTUTextBox.Text = String.Empty
        AvailableTextBox.Text = String.Empty
    End Sub
End Class