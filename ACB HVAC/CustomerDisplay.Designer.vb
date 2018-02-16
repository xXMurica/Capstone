<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerDisplay
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
        Me.LNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.FNameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PhoneTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TechTextBox = New System.Windows.Forms.TextBox()
        Me.TimeTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LNameTextBox
        '
        Me.LNameTextBox.Location = New System.Drawing.Point(6, 51)
        Me.LNameTextBox.Name = "LNameTextBox"
        Me.LNameTextBox.ReadOnly = True
        Me.LNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LNameTextBox.Size = New System.Drawing.Size(124, 29)
        Me.LNameTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Account Display"
        '
        'StreetTextBox
        '
        Me.StreetTextBox.Location = New System.Drawing.Point(6, 117)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.ReadOnly = True
        Me.StreetTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StreetTextBox.Size = New System.Drawing.Size(206, 29)
        Me.StreetTextBox.TabIndex = 2
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(6, 158)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.ReadOnly = True
        Me.CityTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CityTextBox.Size = New System.Drawing.Size(156, 29)
        Me.CityTextBox.TabIndex = 3
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(112, 199)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.ReadOnly = True
        Me.ZipTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ZipTextBox.Size = New System.Drawing.Size(100, 29)
        Me.ZipTextBox.TabIndex = 4
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(6, 199)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.ReadOnly = True
        Me.StateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StateTextBox.Size = New System.Drawing.Size(100, 29)
        Me.StateTextBox.TabIndex = 5
        '
        'FNameTextBox
        '
        Me.FNameTextBox.Location = New System.Drawing.Point(136, 51)
        Me.FNameTextBox.Name = "FNameTextBox"
        Me.FNameTextBox.ReadOnly = True
        Me.FNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FNameTextBox.Size = New System.Drawing.Size(116, 29)
        Me.FNameTextBox.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PhoneTextBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LNameTextBox)
        Me.GroupBox1.Controls.Add(Me.FNameTextBox)
        Me.GroupBox1.Controls.Add(Me.ZipTextBox)
        Me.GroupBox1.Controls.Add(Me.StateTextBox)
        Me.GroupBox1.Controls.Add(Me.StreetTextBox)
        Me.GroupBox1.Controls.Add(Me.CityTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 323)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(6, 261)
        Me.PhoneTextBox.Mask = "(999) 000-0000"
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.ReadOnly = True
        Me.PhoneTextBox.Size = New System.Drawing.Size(167, 29)
        Me.PhoneTextBox.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Last Name   First Name"
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.DarkGray
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(531, 433)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(102, 31)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.BalanceTextBox)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TechTextBox)
        Me.GroupBox2.Controls.Add(Me.TimeTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(318, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 216)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Job"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 23)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Time of Day:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tech ID:"
        '
        'TechTextBox
        '
        Me.TechTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TechTextBox.Location = New System.Drawing.Point(177, 74)
        Me.TechTextBox.Name = "TechTextBox"
        Me.TechTextBox.ReadOnly = True
        Me.TechTextBox.Size = New System.Drawing.Size(121, 29)
        Me.TechTextBox.TabIndex = 3
        '
        'TimeTextBox
        '
        Me.TimeTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeTextBox.Location = New System.Drawing.Point(177, 33)
        Me.TimeTextBox.Name = "TimeTextBox"
        Me.TimeTextBox.ReadOnly = True
        Me.TimeTextBox.Size = New System.Drawing.Size(77, 29)
        Me.TimeTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Customers Phone Number:"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextBox.Location = New System.Drawing.Point(265, 67)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(171, 29)
        Me.SearchTextBox.TabIndex = 1
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.DarkGray
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(487, 67)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(102, 31)
        Me.SearchButton.TabIndex = 21
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.DarkGray
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(342, 433)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(102, 31)
        Me.ClearButton.TabIndex = 20
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(84, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 23)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Balance:"
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalanceTextBox.Location = New System.Drawing.Point(177, 115)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.ReadOnly = True
        Me.BalanceTextBox.Size = New System.Drawing.Size(100, 29)
        Me.BalanceTextBox.TabIndex = 40
        '
        'CustomerDisplay
        '
        Me.AcceptButton = Me.SearchButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(672, 493)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "CustomerDisplay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerDisplay"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents FNameTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TimeTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TechTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents PhoneTextBox As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BalanceTextBox As TextBox
End Class
