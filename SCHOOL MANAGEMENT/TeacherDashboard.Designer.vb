<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherDashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeacherDashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.TeacherPictureBox = New System.Windows.Forms.PictureBox()
        Me.StudentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.IndexTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.MotherTextBox = New System.Windows.Forms.TextBox()
        Me.StudentPictureBox = New System.Windows.Forms.PictureBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.YearTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FatherTextBox = New System.Windows.Forms.TextBox()
        Me.FatherNumberTextBox = New System.Windows.Forms.TextBox()
        Me.MotherPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EnrolledTextBox = New System.Windows.Forms.TextBox()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.TeacherPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.UsernameLabel)
        Me.Panel1.Controls.Add(Me.DateLabel)
        Me.Panel1.Controls.Add(Me.TeacherPictureBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1056, 52)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.SCHOOL_MANAGEMENT.My.Resources.Resources.settings
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(977, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 26)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UsernameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UsernameLabel.Location = New System.Drawing.Point(497, 31)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(102, 17)
        Me.UsernameLabel.TabIndex = 2
        Me.UsernameLabel.Text = "UsernameLabel"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateLabel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DateLabel.Location = New System.Drawing.Point(-2, 33)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(127, 15)
        Me.DateLabel.TabIndex = 1
        Me.DateLabel.Text = "Current Date and Time"
        '
        'TeacherPictureBox
        '
        Me.TeacherPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TeacherPictureBox.Location = New System.Drawing.Point(1009, 7)
        Me.TeacherPictureBox.Name = "TeacherPictureBox"
        Me.TeacherPictureBox.Size = New System.Drawing.Size(40, 43)
        Me.TeacherPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TeacherPictureBox.TabIndex = 0
        Me.TeacherPictureBox.TabStop = False
        '
        'StudentsDataGridView
        '
        Me.StudentsDataGridView.AllowUserToAddRows = False
        Me.StudentsDataGridView.AllowUserToDeleteRows = False
        Me.StudentsDataGridView.AllowUserToOrderColumns = True
        Me.StudentsDataGridView.AllowUserToResizeColumns = False
        Me.StudentsDataGridView.AllowUserToResizeRows = False
        Me.StudentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StudentsDataGridView.BackgroundColor = System.Drawing.Color.LightGray
        Me.StudentsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.StudentsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.StudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentsDataGridView.Cursor = System.Windows.Forms.Cursors.Help
        Me.StudentsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.StudentsDataGridView.Location = New System.Drawing.Point(489, 140)
        Me.StudentsDataGridView.MultiSelect = False
        Me.StudentsDataGridView.Name = "StudentsDataGridView"
        Me.StudentsDataGridView.ReadOnly = True
        Me.StudentsDataGridView.RowTemplate.Height = 25
        Me.StudentsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.StudentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StudentsDataGridView.ShowCellErrors = False
        Me.StudentsDataGridView.ShowEditingIcon = False
        Me.StudentsDataGridView.ShowRowErrors = False
        Me.StudentsDataGridView.Size = New System.Drawing.Size(579, 664)
        Me.StudentsDataGridView.StandardTab = True
        Me.StudentsDataGridView.TabIndex = 1
        '
        'IndexTextBox
        '
        Me.IndexTextBox.Location = New System.Drawing.Point(167, 121)
        Me.IndexTextBox.Name = "IndexTextBox"
        Me.IndexTextBox.ReadOnly = True
        Me.IndexTextBox.Size = New System.Drawing.Size(301, 23)
        Me.IndexTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(167, 193)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(301, 23)
        Me.NameTextBox.TabIndex = 3
        '
        'MotherTextBox
        '
        Me.MotherTextBox.Location = New System.Drawing.Point(12, 637)
        Me.MotherTextBox.Name = "MotherTextBox"
        Me.MotherTextBox.ReadOnly = True
        Me.MotherTextBox.Size = New System.Drawing.Size(456, 23)
        Me.MotherTextBox.TabIndex = 4
        '
        'StudentPictureBox
        '
        Me.StudentPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.StudentPictureBox.Location = New System.Drawing.Point(12, 99)
        Me.StudentPictureBox.Name = "StudentPictureBox"
        Me.StudentPictureBox.Size = New System.Drawing.Size(149, 195)
        Me.StudentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StudentPictureBox.TabIndex = 5
        Me.StudentPictureBox.TabStop = False
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(12, 337)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.ReadOnly = True
        Me.AddressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.AddressTextBox.Size = New System.Drawing.Size(456, 107)
        Me.AddressTextBox.TabIndex = 6
        '
        'YearTextBox
        '
        Me.YearTextBox.Location = New System.Drawing.Point(167, 265)
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.ReadOnly = True
        Me.YearTextBox.Size = New System.Drawing.Size(301, 23)
        Me.YearTextBox.TabIndex = 7
        '
        'CurrentTimer
        '
        Me.CurrentTimer.Enabled = True
        Me.CurrentTimer.Interval = 500
        '
        'FatherTextBox
        '
        Me.FatherTextBox.Location = New System.Drawing.Point(12, 493)
        Me.FatherTextBox.Name = "FatherTextBox"
        Me.FatherTextBox.ReadOnly = True
        Me.FatherTextBox.Size = New System.Drawing.Size(456, 23)
        Me.FatherTextBox.TabIndex = 8
        '
        'FatherNumberTextBox
        '
        Me.FatherNumberTextBox.Location = New System.Drawing.Point(12, 565)
        Me.FatherNumberTextBox.Name = "FatherNumberTextBox"
        Me.FatherNumberTextBox.ReadOnly = True
        Me.FatherNumberTextBox.Size = New System.Drawing.Size(456, 23)
        Me.FatherNumberTextBox.TabIndex = 9
        '
        'MotherPhoneTextBox
        '
        Me.MotherPhoneTextBox.Location = New System.Drawing.Point(12, 709)
        Me.MotherPhoneTextBox.Name = "MotherPhoneTextBox"
        Me.MotherPhoneTextBox.ReadOnly = True
        Me.MotherPhoneTextBox.Size = New System.Drawing.Size(456, 23)
        Me.MotherPhoneTextBox.TabIndex = 10
        '
        'EnrolledTextBox
        '
        Me.EnrolledTextBox.Location = New System.Drawing.Point(12, 781)
        Me.EnrolledTextBox.Name = "EnrolledTextBox"
        Me.EnrolledTextBox.ReadOnly = True
        Me.EnrolledTextBox.Size = New System.Drawing.Size(456, 23)
        Me.EnrolledTextBox.TabIndex = 11
        '
        'SearchTextBox
        '
        Me.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SearchTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SearchTextBox.Location = New System.Drawing.Point(489, 99)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.PlaceholderText = "       Search Student's Name or Index Number here"
        Me.SearchTextBox.Size = New System.Drawing.Size(579, 25)
        Me.SearchTextBox.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(167, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Index Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(12, 769)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Date Of Enrollment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(12, 698)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 15)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Mother's Contact"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(12, 626)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Mother's Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(12, 554)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 15)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Father's Contact"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(12, 480)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 15)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Father's Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(12, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 15)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(167, 253)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 15)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Date of Birth"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(167, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 15)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Student's Name"
        '
        'ToolTip
        '
        Me.ToolTip.IsBalloon = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.DarkGray
        Me.LinkLabel2.Location = New System.Drawing.Point(1012, 1)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(28, 37)
        Me.LinkLabel2.TabIndex = 29
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "-"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.Location = New System.Drawing.Point(1046, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(22, 21)
        Me.LinkLabel1.TabIndex = 28
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "X"
        '
        'TeacherDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 848)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.EnrolledTextBox)
        Me.Controls.Add(Me.MotherPhoneTextBox)
        Me.Controls.Add(Me.FatherNumberTextBox)
        Me.Controls.Add(Me.FatherTextBox)
        Me.Controls.Add(Me.YearTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.StudentPictureBox)
        Me.Controls.Add(Me.MotherTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.IndexTextBox)
        Me.Controls.Add(Me.StudentsDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TeacherDashboard"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TeacherDashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TeacherPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TeacherPictureBox As PictureBox
    Friend WithEvents StudentsDataGridView As DataGridView
    Friend WithEvents IndexTextBox As TextBox
    Friend WithEvents DateLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents MotherTextBox As TextBox
    Friend WithEvents StudentPictureBox As PictureBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents YearTextBox As TextBox
    Friend WithEvents CurrentTimer As Timer
    Friend WithEvents FatherTextBox As TextBox
    Friend WithEvents FatherNumberTextBox As TextBox
    Friend WithEvents MotherPhoneTextBox As TextBox
    Friend WithEvents EnrolledTextBox As TextBox
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
