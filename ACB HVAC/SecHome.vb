Imports Excel = Microsoft.Office.Interop.Excel

Public Class SecHome
    Dim xlWorkBook As Excel.Workbook
    Dim xlApp As New Excel.Application

    Private Sub LedgerButton_Click(sender As Object, e As EventArgs) Handles LedgerButton.Click

        xlWorkBook = xlApp.Workbooks.Open("C:\capstone\ACBAFR.xlsx")
        xlApp.Visible = True
    End Sub

    Private Sub NewLedgerButton_Click(sender As Object, e As EventArgs) Handles NewLedgerButton.Click
        xlWorkBook = xlApp.Workbooks.Add
        xlApp.Visible = True
    End Sub

    Private Sub SignOutButton_Click(sender As Object, e As EventArgs) Handles SignOutButton.Click
        Application.Exit()
    End Sub

    Private Sub InventoryButton_Click(sender As Object, e As EventArgs) Handles InventoryButton.Click
        My.Forms.Inventory.Text = Now.ToString
        My.Forms.Inventory.Show()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        My.Forms.SecHome.Text = Now.ToString
        My.Forms.SecHome.Show()

    End Sub

    Private Sub AccountRecButton_Click(sender As Object, e As EventArgs) Handles AccountRecButton.Click
        My.Forms.AccountRec.Text = Now.ToString
        My.Forms.AccountRec.Show()
    End Sub

    Private Sub AccountPayButton_Click(sender As Object, e As EventArgs) Handles AccountPayButton.Click
        My.Forms.AccountsPay.Text = Now.ToString
        My.Forms.AccountsPay.Show()
    End Sub

    Private Sub CreateJobsButton_Click(sender As Object, e As EventArgs) Handles CreateJobsButton.Click
        My.Forms.JobScreen.Text = Now.ToString
        My.Forms.JobScreen.Show()
    End Sub


    Private Sub SearchCustomerButton_Click(sender As Object, e As EventArgs) Handles SearchCustomerButton.Click
        My.Forms.CustomerDisplay.Text = Now.ToString
        My.Forms.CustomerDisplay.Show()
    End Sub

End Class