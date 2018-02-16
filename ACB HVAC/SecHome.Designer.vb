<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SignOutButton = New System.Windows.Forms.Button()
        Me.InventoryButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.SearchCustomerButton = New System.Windows.Forms.Button()
        Me.AccountRecButton = New System.Windows.Forms.Button()
        Me.AccountPayButton = New System.Windows.Forms.Button()
        Me.CreateJobsButton = New System.Windows.Forms.Button()
        Me.LedgerButton = New System.Windows.Forms.Button()
        Me.NewLedgerButton = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(188, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(462, 77)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.Location = New System.Drawing.Point(133, 26)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(197, 29)
        Me.DateLabel.TabIndex = 3
        Me.DateLabel.Text = "Account Home"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.SignOutButton)
        Me.GroupBox1.Controls.Add(Me.InventoryButton)
        Me.GroupBox1.Controls.Add(Me.HomeButton)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(7)
        Me.GroupBox1.Size = New System.Drawing.Size(179, 408)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ACB_HVAC.My.Resources.Resources.ACBLOGO
        Me.PictureBox1.Location = New System.Drawing.Point(14, 277)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'SignOutButton
        '
        Me.SignOutButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SignOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignOutButton.Location = New System.Drawing.Point(14, 126)
        Me.SignOutButton.Name = "SignOutButton"
        Me.SignOutButton.Size = New System.Drawing.Size(151, 51)
        Me.SignOutButton.TabIndex = 2
        Me.SignOutButton.Text = "Sign Out"
        Me.SignOutButton.UseVisualStyleBackColor = True
        '
        'InventoryButton
        '
        Me.InventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InventoryButton.Location = New System.Drawing.Point(14, 76)
        Me.InventoryButton.Name = "InventoryButton"
        Me.InventoryButton.Size = New System.Drawing.Size(151, 51)
        Me.InventoryButton.TabIndex = 1
        Me.InventoryButton.Text = "Inventory"
        Me.InventoryButton.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeButton.Location = New System.Drawing.Point(14, 26)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(7)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(151, 51)
        Me.HomeButton.TabIndex = 0
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'SearchCustomerButton
        '
        Me.SearchCustomerButton.BackColor = System.Drawing.Color.DarkGray
        Me.SearchCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchCustomerButton.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchCustomerButton.Location = New System.Drawing.Point(326, 156)
        Me.SearchCustomerButton.Name = "SearchCustomerButton"
        Me.SearchCustomerButton.Size = New System.Drawing.Size(195, 34)
        Me.SearchCustomerButton.TabIndex = 8
        Me.SearchCustomerButton.Text = "View Account"
        Me.SearchCustomerButton.UseVisualStyleBackColor = False
        '
        'AccountRecButton
        '
        Me.AccountRecButton.BackColor = System.Drawing.Color.DarkGray
        Me.AccountRecButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccountRecButton.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountRecButton.Location = New System.Drawing.Point(191, 279)
        Me.AccountRecButton.Name = "AccountRecButton"
        Me.AccountRecButton.Size = New System.Drawing.Size(195, 34)
        Me.AccountRecButton.TabIndex = 9
        Me.AccountRecButton.Text = "Accounts Receivable"
        Me.AccountRecButton.UseVisualStyleBackColor = False
        '
        'AccountPayButton
        '
        Me.AccountPayButton.BackColor = System.Drawing.Color.DarkGray
        Me.AccountPayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccountPayButton.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountPayButton.Location = New System.Drawing.Point(191, 319)
        Me.AccountPayButton.Name = "AccountPayButton"
        Me.AccountPayButton.Size = New System.Drawing.Size(195, 34)
        Me.AccountPayButton.TabIndex = 10
        Me.AccountPayButton.Text = "Accounts Payable"
        Me.AccountPayButton.UseVisualStyleBackColor = False
        '
        'CreateJobsButton
        '
        Me.CreateJobsButton.BackColor = System.Drawing.Color.DarkGray
        Me.CreateJobsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateJobsButton.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateJobsButton.Location = New System.Drawing.Point(326, 116)
        Me.CreateJobsButton.Name = "CreateJobsButton"
        Me.CreateJobsButton.Size = New System.Drawing.Size(195, 34)
        Me.CreateJobsButton.TabIndex = 11
        Me.CreateJobsButton.Text = "Create Account"
        Me.CreateJobsButton.UseVisualStyleBackColor = False
        '
        'LedgerButton
        '
        Me.LedgerButton.BackColor = System.Drawing.Color.DarkGray
        Me.LedgerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LedgerButton.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LedgerButton.Location = New System.Drawing.Point(446, 279)
        Me.LedgerButton.Name = "LedgerButton"
        Me.LedgerButton.Size = New System.Drawing.Size(195, 34)
        Me.LedgerButton.TabIndex = 13
        Me.LedgerButton.Text = "Ledger"
        Me.LedgerButton.UseVisualStyleBackColor = False
        '
        'NewLedgerButton
        '
        Me.NewLedgerButton.BackColor = System.Drawing.Color.DarkGray
        Me.NewLedgerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewLedgerButton.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewLedgerButton.Location = New System.Drawing.Point(446, 319)
        Me.NewLedgerButton.Name = "NewLedgerButton"
        Me.NewLedgerButton.Size = New System.Drawing.Size(195, 33)
        Me.NewLedgerButton.TabIndex = 14
        Me.NewLedgerButton.Text = "New Ledger"
        Me.NewLedgerButton.UseVisualStyleBackColor = False
        '
        'SecHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.SignOutButton
        Me.ClientSize = New System.Drawing.Size(666, 412)
        Me.Controls.Add(Me.NewLedgerButton)
        Me.Controls.Add(Me.LedgerButton)
        Me.Controls.Add(Me.CreateJobsButton)
        Me.Controls.Add(Me.AccountPayButton)
        Me.Controls.Add(Me.AccountRecButton)
        Me.Controls.Add(Me.SearchCustomerButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "SecHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SecHome"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SignOutButton As Button
    Friend WithEvents InventoryButton As Button
    Friend WithEvents HomeButton As Button
    Friend WithEvents SearchCustomerButton As Button
    Friend WithEvents AccountRecButton As Button
    Friend WithEvents AccountPayButton As Button
    Friend WithEvents CreateJobsButton As Button
    Friend WithEvents LedgerButton As Button
    Friend WithEvents NewLedgerButton As Button
End Class
