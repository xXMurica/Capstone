<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobScreen
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ItemNumberTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.StateComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LNameTextBox = New System.Windows.Forms.TextBox()
        Me.FNameTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TechTextBox = New System.Windows.Forms.TextBox()
        Me.TimeTextBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Item Code:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(60, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 23)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Amount:"
        '
        'ItemNumberTextBox
        '
        Me.ItemNumberTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemNumberTextBox.Location = New System.Drawing.Point(153, 171)
        Me.ItemNumberTextBox.Name = "ItemNumberTextBox"
        Me.ItemNumberTextBox.Size = New System.Drawing.Size(92, 29)
        Me.ItemNumberTextBox.TabIndex = 12
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTextBox.Location = New System.Drawing.Point(151, 203)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(69, 29)
        Me.AmountTextBox.TabIndex = 13
        '
        'CreateButton
        '
        Me.CreateButton.BackColor = System.Drawing.Color.DarkGray
        Me.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateButton.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateButton.Location = New System.Drawing.Point(462, 348)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(95, 32)
        Me.CreateButton.TabIndex = 28
        Me.CreateButton.Text = "Create"
        Me.CreateButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.DarkGray
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(325, 432)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(95, 32)
        Me.ClearButton.TabIndex = 29
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.DarkGray
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(462, 432)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(95, 32)
        Me.CancelButton.TabIndex = 30
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PhoneTextBox)
        Me.GroupBox1.Controls.Add(Me.StreetTextBox2)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.StateComboBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LNameTextBox)
        Me.GroupBox1.Controls.Add(Me.FNameTextBox)
        Me.GroupBox1.Controls.Add(Me.ZipTextBox)
        Me.GroupBox1.Controls.Add(Me.StreetTextBox)
        Me.GroupBox1.Controls.Add(Me.CityTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 371)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(6, 336)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(151, 29)
        Me.PhoneTextBox.TabIndex = 8
        '
        'StreetTextBox2
        '
        Me.StreetTextBox2.Location = New System.Drawing.Point(6, 157)
        Me.StreetTextBox2.Name = "StreetTextBox2"
        Me.StreetTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StreetTextBox2.Size = New System.Drawing.Size(206, 29)
        Me.StreetTextBox2.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 189)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 23)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "City"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 247)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(172, 23)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "State                  Zip"
        '
        'StateComboBox
        '
        Me.StateComboBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateComboBox.FormattingEnabled = True
        Me.StateComboBox.Location = New System.Drawing.Point(6, 273)
        Me.StateComboBox.Name = "StateComboBox"
        Me.StateComboBox.Size = New System.Drawing.Size(100, 31)
        Me.StateComboBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Phone Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Last Name   First Name"
        '
        'LNameTextBox
        '
        Me.LNameTextBox.Location = New System.Drawing.Point(6, 60)
        Me.LNameTextBox.Name = "LNameTextBox"
        Me.LNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LNameTextBox.Size = New System.Drawing.Size(124, 29)
        Me.LNameTextBox.TabIndex = 1
        '
        'FNameTextBox
        '
        Me.FNameTextBox.Location = New System.Drawing.Point(136, 60)
        Me.FNameTextBox.Name = "FNameTextBox"
        Me.FNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FNameTextBox.Size = New System.Drawing.Size(116, 29)
        Me.FNameTextBox.TabIndex = 2
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(112, 273)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ZipTextBox.Size = New System.Drawing.Size(100, 29)
        Me.ZipTextBox.TabIndex = 7
        '
        'StreetTextBox
        '
        Me.StreetTextBox.Location = New System.Drawing.Point(6, 124)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StreetTextBox.Size = New System.Drawing.Size(206, 29)
        Me.StreetTextBox.TabIndex = 3
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(6, 215)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CityTextBox.Size = New System.Drawing.Size(156, 29)
        Me.CityTextBox.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 23)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Units Needed"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(81, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 29)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Create Job"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.BalanceTextBox)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TechTextBox)
        Me.GroupBox2.Controls.Add(Me.TimeTextBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ItemNumberTextBox)
        Me.GroupBox2.Controls.Add(Me.AmountTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(295, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 281)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Job"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 23)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Time of Day:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(62, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 23)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Tech ID:"
        '
        'TechTextBox
        '
        Me.TechTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TechTextBox.Location = New System.Drawing.Point(156, 80)
        Me.TechTextBox.Name = "TechTextBox"
        Me.TechTextBox.Size = New System.Drawing.Size(121, 29)
        Me.TechTextBox.TabIndex = 10
        '
        'TimeTextBox
        '
        Me.TimeTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeTextBox.Location = New System.Drawing.Point(156, 39)
        Me.TimeTextBox.Name = "TimeTextBox"
        Me.TimeTextBox.Size = New System.Drawing.Size(77, 29)
        Me.TimeTextBox.TabIndex = 9
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.DarkGray
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(325, 348)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(95, 32)
        Me.SearchButton.TabIndex = 40
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalanceTextBox.Location = New System.Drawing.Point(151, 237)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.Size = New System.Drawing.Size(100, 29)
        Me.BalanceTextBox.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 23)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Balance:"
        '
        'JobScreen
        '
        Me.AcceptButton = Me.CreateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.CancelButton
        Me.ClientSize = New System.Drawing.Size(610, 498)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CreateButton)
        Me.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "JobScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JobScreen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ItemNumberTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents CreateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LNameTextBox As TextBox
    Friend WithEvents FNameTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TechTextBox As TextBox
    Friend WithEvents TimeTextBox As TextBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents StateComboBox As ComboBox
    Friend WithEvents StreetTextBox2 As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BalanceTextBox As TextBox
End Class
