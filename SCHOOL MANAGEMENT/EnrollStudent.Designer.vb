<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnrollStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnrollStudent))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MotherPhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.MotherTextBox = New System.Windows.Forms.TextBox()
        Me.ClassPassLabel = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EnrollButton = New System.Windows.Forms.Button()
        Me.FatherPhoneTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ClassComboBox = New System.Windows.Forms.ComboBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.FatherTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.UserPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.UserPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.LastNameTextBox)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.MotherPhoneMaskedTextBox)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.MotherTextBox)
        Me.Panel1.Controls.Add(Me.ClassPassLabel)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.EnrollButton)
        Me.Panel1.Controls.Add(Me.FatherPhoneTextBox)
        Me.Panel1.Controls.Add(Me.DateTimePicker)
        Me.Panel1.Controls.Add(Me.ClassComboBox)
        Me.Panel1.Controls.Add(Me.AddressTextBox)
        Me.Panel1.Controls.Add(Me.FatherTextBox)
        Me.Panel1.Controls.Add(Me.FirstNameTextBox)
        Me.Panel1.Controls.Add(Me.UserPictureBox)
        Me.Panel1.Location = New System.Drawing.Point(20, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 744)
        Me.Panel1.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(34, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 15)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Last Name(s)"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LastNameTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LastNameTextBox.Location = New System.Drawing.Point(35, 115)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(446, 29)
        Me.LastNameTextBox.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(34, 617)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 15)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Father's Number"
        '
        'MotherPhoneMaskedTextBox
        '
        Me.MotherPhoneMaskedTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MotherPhoneMaskedTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MotherPhoneMaskedTextBox.Location = New System.Drawing.Point(34, 634)
        Me.MotherPhoneMaskedTextBox.Mask = "(+233) 00-000-0000"
        Me.MotherPhoneMaskedTextBox.Name = "MotherPhoneMaskedTextBox"
        Me.MotherPhoneMaskedTextBox.Size = New System.Drawing.Size(446, 29)
        Me.MotherPhoneMaskedTextBox.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label17.Location = New System.Drawing.Point(32, 550)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 15)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Mother's Name"
        '
        'MotherTextBox
        '
        Me.MotherTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MotherTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MotherTextBox.Location = New System.Drawing.Point(33, 569)
        Me.MotherTextBox.Name = "MotherTextBox"
        Me.MotherTextBox.Size = New System.Drawing.Size(446, 29)
        Me.MotherTextBox.TabIndex = 7
        '
        'ClassPassLabel
        '
        Me.ClassPassLabel.AutoSize = True
        Me.ClassPassLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClassPassLabel.Location = New System.Drawing.Point(33, 540)
        Me.ClassPassLabel.Name = "ClassPassLabel"
        Me.ClassPassLabel.Size = New System.Drawing.Size(49, 15)
        Me.ClassPassLabel.TabIndex = 33
        Me.ClassPassLabel.Text = "              "
        Me.ClassPassLabel.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(538, 237)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 15)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "image from your files "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(613, 221)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 15)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "to select"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(567, 216)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(40, 20)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "here"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(538, 221)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 15)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Click "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(34, 487)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 15)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Father's Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(35, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 15)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Residential Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(35, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Date of Birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(34, 422)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Father's Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(34, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Current Class"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(33, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(292, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 30)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Register"
        '
        'EnrollButton
        '
        Me.EnrollButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.EnrollButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EnrollButton.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EnrollButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EnrollButton.Location = New System.Drawing.Point(33, 682)
        Me.EnrollButton.Name = "EnrollButton"
        Me.EnrollButton.Size = New System.Drawing.Size(644, 40)
        Me.EnrollButton.TabIndex = 10
        Me.EnrollButton.Text = "Register"
        Me.EnrollButton.UseVisualStyleBackColor = False
        '
        'FatherPhoneTextBox
        '
        Me.FatherPhoneTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FatherPhoneTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FatherPhoneTextBox.Location = New System.Drawing.Point(34, 504)
        Me.FatherPhoneTextBox.Mask = "(+233) 00-000-0000"
        Me.FatherPhoneTextBox.Name = "FatherPhoneTextBox"
        Me.FatherPhoneTextBox.Size = New System.Drawing.Size(446, 29)
        Me.FatherPhoneTextBox.TabIndex = 6
        '
        'DateTimePicker
        '
        Me.DateTimePicker.CalendarForeColor = System.Drawing.SystemColors.ControlDark
        Me.DateTimePicker.CalendarTitleBackColor = System.Drawing.Color.DodgerBlue
        Me.DateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker.Location = New System.Drawing.Point(35, 245)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(446, 29)
        Me.DateTimePicker.TabIndex = 3
        '
        'ClassComboBox
        '
        Me.ClassComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClassComboBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ClassComboBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClassComboBox.FormattingEnabled = True
        Me.ClassComboBox.ItemHeight = 21
        Me.ClassComboBox.Items.AddRange(New Object() {"Nursery 1", "Nursery 2", "Kindergarten 1", "Kindergarten 2", "Primary 1", "Primary 2", "Primary 3", "Primary 4", "Primary 5", "Primary 6", "J.H.S 1", "J.H.S 2", "J.H.S 3"})
        Me.ClassComboBox.Location = New System.Drawing.Point(34, 180)
        Me.ClassComboBox.MaxDropDownItems = 20
        Me.ClassComboBox.Name = "ClassComboBox"
        Me.ClassComboBox.Size = New System.Drawing.Size(446, 29)
        Me.ClassComboBox.TabIndex = 2
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AddressTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.AddressTextBox.Location = New System.Drawing.Point(35, 310)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(446, 93)
        Me.AddressTextBox.TabIndex = 4
        '
        'FatherTextBox
        '
        Me.FatherTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FatherTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FatherTextBox.Location = New System.Drawing.Point(35, 439)
        Me.FatherTextBox.Name = "FatherTextBox"
        Me.FatherTextBox.Size = New System.Drawing.Size(446, 29)
        Me.FatherTextBox.TabIndex = 5
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FirstNameTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FirstNameTextBox.Location = New System.Drawing.Point(34, 50)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(446, 29)
        Me.FirstNameTextBox.TabIndex = 0
        '
        'UserPictureBox
        '
        Me.UserPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UserPictureBox.Image = Global.SCHOOL_MANAGEMENT.My.Resources.Resources.user_01
        Me.UserPictureBox.Location = New System.Drawing.Point(529, 32)
        Me.UserPictureBox.Name = "UserPictureBox"
        Me.UserPictureBox.Size = New System.Drawing.Size(148, 174)
        Me.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserPictureBox.TabIndex = 7
        Me.UserPictureBox.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(146, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(431, 30)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "WELCOME TO WOODFORT BLISS ACADEMY"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel2.Location = New System.Drawing.Point(694, 9)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(22, 21)
        Me.LinkLabel2.TabIndex = 54
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "X"
        '
        'EnrollStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(737, 803)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EnrollStudent"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EnrollStudent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.UserPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ClassPassLabel As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EnrollButton As Button
    Friend WithEvents FatherPhoneTextBox As MaskedTextBox
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents ClassComboBox As ComboBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents FatherTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents MotherTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents MotherPhoneMaskedTextBox As MaskedTextBox
    Friend WithEvents UserPictureBox As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label13 As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
