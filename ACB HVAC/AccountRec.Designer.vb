<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountRec
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PhoneTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.LNameTextBox = New System.Windows.Forms.TextBox()
        Me.FNameTextBox = New System.Windows.Forms.TextBox()
        Me.AccountTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateComboBox = New System.Windows.Forms.ComboBox()
        Me.MonthComboBox = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SecurityTextBox = New System.Windows.Forms.TextBox()
        Me.CreditCardTextBox = New System.Windows.Forms.TextBox()
        Me.PayComboBox = New System.Windows.Forms.ComboBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.DarkGray
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(502, 538)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(89, 36)
        Me.ExitButton.TabIndex = 10
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Account #"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PhoneTextBox)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.BalanceTextBox)
        Me.GroupBox1.Controls.Add(Me.ZipTextBox)
        Me.GroupBox1.Controls.Add(Me.StateTextBox)
        Me.GroupBox1.Controls.Add(Me.StreetTextBox)
        Me.GroupBox1.Controls.Add(Me.CityTextBox)
        Me.GroupBox1.Controls.Add(Me.LNameTextBox)
        Me.GroupBox1.Controls.Add(Me.FNameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 249)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTextBox.Location = New System.Drawing.Point(320, 45)
        Me.PhoneTextBox.Mask = "(999) 000-0000"
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.ReadOnly = True
        Me.PhoneTextBox.Size = New System.Drawing.Size(188, 31)
        Me.PhoneTextBox.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(315, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 23)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Phone"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 23)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(213, 23)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Last Name   First Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(238, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 23)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Amount Due:"
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalanceTextBox.Location = New System.Drawing.Point(374, 143)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.ReadOnly = True
        Me.BalanceTextBox.Size = New System.Drawing.Size(147, 29)
        Me.BalanceTextBox.TabIndex = 16
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZipTextBox.Location = New System.Drawing.Point(116, 187)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.ReadOnly = True
        Me.ZipTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ZipTextBox.Size = New System.Drawing.Size(100, 31)
        Me.ZipTextBox.TabIndex = 12
        '
        'StateTextBox
        '
        Me.StateTextBox.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateTextBox.Location = New System.Drawing.Point(10, 187)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.ReadOnly = True
        Me.StateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StateTextBox.Size = New System.Drawing.Size(100, 31)
        Me.StateTextBox.TabIndex = 13
        '
        'StreetTextBox
        '
        Me.StreetTextBox.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StreetTextBox.Location = New System.Drawing.Point(10, 105)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.ReadOnly = True
        Me.StreetTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StreetTextBox.Size = New System.Drawing.Size(206, 31)
        Me.StreetTextBox.TabIndex = 10
        '
        'CityTextBox
        '
        Me.CityTextBox.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox.Location = New System.Drawing.Point(10, 146)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.ReadOnly = True
        Me.CityTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CityTextBox.Size = New System.Drawing.Size(156, 31)
        Me.CityTextBox.TabIndex = 11
        '
        'LNameTextBox
        '
        Me.LNameTextBox.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNameTextBox.Location = New System.Drawing.Point(10, 45)
        Me.LNameTextBox.Name = "LNameTextBox"
        Me.LNameTextBox.ReadOnly = True
        Me.LNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LNameTextBox.Size = New System.Drawing.Size(124, 31)
        Me.LNameTextBox.TabIndex = 8
        '
        'FNameTextBox
        '
        Me.FNameTextBox.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNameTextBox.Location = New System.Drawing.Point(140, 45)
        Me.FNameTextBox.Name = "FNameTextBox"
        Me.FNameTextBox.ReadOnly = True
        Me.FNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FNameTextBox.Size = New System.Drawing.Size(116, 31)
        Me.FNameTextBox.TabIndex = 9
        '
        'AccountTextBox
        '
        Me.AccountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AccountTextBox.Location = New System.Drawing.Point(140, 14)
        Me.AccountTextBox.Name = "AccountTextBox"
        Me.AccountTextBox.Size = New System.Drawing.Size(158, 28)
        Me.AccountTextBox.TabIndex = 1
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTextBox.Location = New System.Drawing.Point(456, 146)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(100, 29)
        Me.AmountTextBox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(137, -41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Type Of Payment:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 23)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Security Code:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Credit Card Number:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 23)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Name On Card:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(365, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 23)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 23)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Type Of Payment:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(203, 114)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(164, 29)
        Me.NameTextBox.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateComboBox)
        Me.GroupBox2.Controls.Add(Me.MonthComboBox)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.SecurityTextBox)
        Me.GroupBox2.Controls.Add(Me.CreditCardTextBox)
        Me.GroupBox2.Controls.Add(Me.PayComboBox)
        Me.GroupBox2.Controls.Add(Me.NameTextBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.AmountTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 303)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(578, 229)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment"
        '
        'DateComboBox
        '
        Me.DateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DateComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DateComboBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateComboBox.FormattingEnabled = True
        Me.DateComboBox.Location = New System.Drawing.Point(296, 181)
        Me.DateComboBox.Name = "DateComboBox"
        Me.DateComboBox.Size = New System.Drawing.Size(71, 31)
        Me.DateComboBox.TabIndex = 7
        '
        'MonthComboBox
        '
        Me.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MonthComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MonthComboBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthComboBox.FormattingEnabled = True
        Me.MonthComboBox.Location = New System.Drawing.Point(204, 181)
        Me.MonthComboBox.Name = "MonthComboBox"
        Me.MonthComboBox.Size = New System.Drawing.Size(61, 31)
        Me.MonthComboBox.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(271, 184)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 23)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "/"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(104, 184)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 23)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Exp. Date:"
        '
        'SecurityTextBox
        '
        Me.SecurityTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityTextBox.Location = New System.Drawing.Point(203, 146)
        Me.SecurityTextBox.MaxLength = 6
        Me.SecurityTextBox.Name = "SecurityTextBox"
        Me.SecurityTextBox.Size = New System.Drawing.Size(100, 29)
        Me.SecurityTextBox.TabIndex = 5
        '
        'CreditCardTextBox
        '
        Me.CreditCardTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditCardTextBox.Location = New System.Drawing.Point(204, 82)
        Me.CreditCardTextBox.MaxLength = 16
        Me.CreditCardTextBox.Name = "CreditCardTextBox"
        Me.CreditCardTextBox.Size = New System.Drawing.Size(195, 29)
        Me.CreditCardTextBox.TabIndex = 3
        '
        'PayComboBox
        '
        Me.PayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PayComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PayComboBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayComboBox.FormattingEnabled = True
        Me.PayComboBox.Location = New System.Drawing.Point(203, 48)
        Me.PayComboBox.Name = "PayComboBox"
        Me.PayComboBox.Size = New System.Drawing.Size(196, 31)
        Me.PayComboBox.TabIndex = 2
        '
        'SubmitButton
        '
        Me.SubmitButton.BackColor = System.Drawing.Color.DarkGray
        Me.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubmitButton.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitButton.Location = New System.Drawing.Point(337, 538)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(100, 36)
        Me.SubmitButton.TabIndex = 9
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = False
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.DarkGray
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(318, 6)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(100, 36)
        Me.SearchButton.TabIndex = 22
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'AccountRec
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(619, 592)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.AccountTextBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "AccountRec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccountRec"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AccountTextBox As TextBox
    Friend WithEvents LNameTextBox As TextBox
    Friend WithEvents FNameTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BalanceTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SecurityTextBox As TextBox
    Friend WithEvents CreditCardTextBox As TextBox
    Friend WithEvents PayComboBox As ComboBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents MonthComboBox As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DateComboBox As ComboBox
    Friend WithEvents PhoneTextBox As MaskedTextBox
End Class
