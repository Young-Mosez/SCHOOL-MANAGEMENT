<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ClassComboBox = New System.Windows.Forms.ComboBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.AdminPictureBox = New System.Windows.Forms.PictureBox()
        Me.AdminDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StudentsButton = New System.Windows.Forms.Button()
        Me.StaffButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FeesLabel = New System.Windows.Forms.Label()
        Me.FeesTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneDateLabel = New System.Windows.Forms.Label()
        Me.DateofbirthPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.ClassLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.EmaiFatherLabel = New System.Windows.Forms.Label()
        Me.BirthdatefathercontactLabel = New System.Windows.Forms.Label()
        Me.MotherLabel = New System.Windows.Forms.Label()
        Me.MotherPhoneLabel = New System.Windows.Forms.Label()
        Me.EnrolledLabel = New System.Windows.Forms.Label()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.EnrolledTextBox = New System.Windows.Forms.TextBox()
        Me.MotherPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.BirthdateFatherNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailFatherTextBox = New System.Windows.Forms.TextBox()
        Me.ClassTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.ThePictureBox = New System.Windows.Forms.PictureBox()
        Me.MotherTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.IndexTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnrollNewStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStudentsOwingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateFeesForNewAcademicYearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteButton = New System.Windows.Forms.Button()
        CType(Me.AdminPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ThePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.Location = New System.Drawing.Point(1046, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(22, 21)
        Me.LinkLabel1.TabIndex = 53
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "X"
        '
        'ToolTip
        '
        Me.ToolTip.IsBalloon = True
        '
        'ClassComboBox
        '
        Me.ClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClassComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ClassComboBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ClassComboBox.ForeColor = System.Drawing.Color.Gray
        Me.ClassComboBox.FormattingEnabled = True
        Me.ClassComboBox.Items.AddRange(New Object() {"None", "Nursery 1", "Nursery 2", "Kindergarten 1", "Kindergarten 2", "Primary 1", "Primary 2", "Primary 3", "Primary 4", "Primary 5", "Primary 6", "J.H.S 1", "J.H.S 2", "J.H.S 3"})
        Me.ClassComboBox.Location = New System.Drawing.Point(489, 161)
        Me.ClassComboBox.Name = "ClassComboBox"
        Me.ClassComboBox.Size = New System.Drawing.Size(579, 25)
        Me.ClassComboBox.TabIndex = 61
        Me.ToolTip.SetToolTip(Me.ClassComboBox, "Select a class to view the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "students in that class")
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.DarkGray
        Me.LinkLabel2.Location = New System.Drawing.Point(1012, 1)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(28, 37)
        Me.LinkLabel2.TabIndex = 54
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "-"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SearchTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SearchTextBox.Location = New System.Drawing.Point(489, 99)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.PlaceholderText = "       Search Name or ID Number here"
        Me.SearchTextBox.Size = New System.Drawing.Size(579, 25)
        Me.SearchTextBox.TabIndex = 42
        '
        'CurrentTimer
        '
        Me.CurrentTimer.Enabled = True
        Me.CurrentTimer.Interval = 1000
        '
        'SettingsButton
        '
        Me.SettingsButton.BackgroundImage = Global.SCHOOL_MANAGEMENT.My.Resources.Resources.settings
        Me.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingsButton.Location = New System.Drawing.Point(977, 7)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(26, 26)
        Me.SettingsButton.TabIndex = 3
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UsernameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UsernameLabel.Location = New System.Drawing.Point(463, 20)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(162, 30)
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
        'AdminPictureBox
        '
        Me.AdminPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AdminPictureBox.Location = New System.Drawing.Point(1009, 7)
        Me.AdminPictureBox.Name = "AdminPictureBox"
        Me.AdminPictureBox.Size = New System.Drawing.Size(40, 43)
        Me.AdminPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AdminPictureBox.TabIndex = 0
        Me.AdminPictureBox.TabStop = False
        '
        'AdminDataGridView
        '
        Me.AdminDataGridView.AllowUserToAddRows = False
        Me.AdminDataGridView.AllowUserToDeleteRows = False
        Me.AdminDataGridView.AllowUserToOrderColumns = True
        Me.AdminDataGridView.AllowUserToResizeColumns = False
        Me.AdminDataGridView.AllowUserToResizeRows = False
        Me.AdminDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AdminDataGridView.BackgroundColor = System.Drawing.Color.LightGray
        Me.AdminDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.AdminDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.AdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.AdminDataGridView.Cursor = System.Windows.Forms.Cursors.Help
        Me.AdminDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.AdminDataGridView.Location = New System.Drawing.Point(489, 189)
        Me.AdminDataGridView.MultiSelect = False
        Me.AdminDataGridView.Name = "AdminDataGridView"
        Me.AdminDataGridView.ReadOnly = True
        Me.AdminDataGridView.RowTemplate.Height = 25
        Me.AdminDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AdminDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AdminDataGridView.ShowCellErrors = False
        Me.AdminDataGridView.ShowEditingIcon = False
        Me.AdminDataGridView.ShowRowErrors = False
        Me.AdminDataGridView.Size = New System.Drawing.Size(579, 603)
        Me.AdminDataGridView.StandardTab = True
        Me.AdminDataGridView.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.SettingsButton)
        Me.Panel1.Controls.Add(Me.UsernameLabel)
        Me.Panel1.Controls.Add(Me.DateLabel)
        Me.Panel1.Controls.Add(Me.AdminPictureBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1056, 52)
        Me.Panel1.TabIndex = 30
        '
        'StudentsButton
        '
        Me.StudentsButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StudentsButton.Location = New System.Drawing.Point(489, 129)
        Me.StudentsButton.Name = "StudentsButton"
        Me.StudentsButton.Size = New System.Drawing.Size(289, 30)
        Me.StudentsButton.TabIndex = 57
        Me.StudentsButton.Text = "STUDENTS"
        Me.StudentsButton.UseVisualStyleBackColor = True
        '
        'StaffButton
        '
        Me.StaffButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StaffButton.Location = New System.Drawing.Point(776, 129)
        Me.StaffButton.Name = "StaffButton"
        Me.StaffButton.Size = New System.Drawing.Size(292, 30)
        Me.StaffButton.TabIndex = 58
        Me.StaffButton.Text = "STAFF"
        Me.StaffButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.FeesLabel)
        Me.Panel2.Controls.Add(Me.FeesTextBox)
        Me.Panel2.Controls.Add(Me.PhoneDateLabel)
        Me.Panel2.Controls.Add(Me.DateofbirthPhoneTextBox)
        Me.Panel2.Controls.Add(Me.NameLabel)
        Me.Panel2.Controls.Add(Me.ClassLabel)
        Me.Panel2.Controls.Add(Me.AddressLabel)
        Me.Panel2.Controls.Add(Me.EmaiFatherLabel)
        Me.Panel2.Controls.Add(Me.BirthdatefathercontactLabel)
        Me.Panel2.Controls.Add(Me.MotherLabel)
        Me.Panel2.Controls.Add(Me.MotherPhoneLabel)
        Me.Panel2.Controls.Add(Me.EnrolledLabel)
        Me.Panel2.Controls.Add(Me.IDLabel)
        Me.Panel2.Controls.Add(Me.EnrolledTextBox)
        Me.Panel2.Controls.Add(Me.MotherPhoneTextBox)
        Me.Panel2.Controls.Add(Me.BirthdateFatherNumberTextBox)
        Me.Panel2.Controls.Add(Me.EmailFatherTextBox)
        Me.Panel2.Controls.Add(Me.ClassTextBox)
        Me.Panel2.Controls.Add(Me.AddressTextBox)
        Me.Panel2.Controls.Add(Me.ThePictureBox)
        Me.Panel2.Controls.Add(Me.MotherTextBox)
        Me.Panel2.Controls.Add(Me.NameTextBox)
        Me.Panel2.Controls.Add(Me.IndexTextBox)
        Me.Panel2.Location = New System.Drawing.Point(12, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(471, 693)
        Me.Panel2.TabIndex = 62
        '
        'FeesLabel
        '
        Me.FeesLabel.AutoSize = True
        Me.FeesLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FeesLabel.Location = New System.Drawing.Point(11, 632)
        Me.FeesLabel.Name = "FeesLabel"
        Me.FeesLabel.Size = New System.Drawing.Size(64, 15)
        Me.FeesLabel.TabIndex = 50
        Me.FeesLabel.Text = "Fees Owed"
        '
        'FeesTextBox
        '
        Me.FeesTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FeesTextBox.Location = New System.Drawing.Point(11, 645)
        Me.FeesTextBox.Name = "FeesTextBox"
        Me.FeesTextBox.ReadOnly = True
        Me.FeesTextBox.Size = New System.Drawing.Size(448, 22)
        Me.FeesTextBox.TabIndex = 49
        '
        'PhoneDateLabel
        '
        Me.PhoneDateLabel.AutoSize = True
        Me.PhoneDateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PhoneDateLabel.Location = New System.Drawing.Point(162, 143)
        Me.PhoneDateLabel.Name = "PhoneDateLabel"
        Me.PhoneDateLabel.Size = New System.Drawing.Size(73, 15)
        Me.PhoneDateLabel.TabIndex = 48
        Me.PhoneDateLabel.Text = "Date of Birth"
        '
        'DateofbirthPhoneTextBox
        '
        Me.DateofbirthPhoneTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateofbirthPhoneTextBox.Location = New System.Drawing.Point(162, 157)
        Me.DateofbirthPhoneTextBox.Name = "DateofbirthPhoneTextBox"
        Me.DateofbirthPhoneTextBox.ReadOnly = True
        Me.DateofbirthPhoneTextBox.Size = New System.Drawing.Size(301, 22)
        Me.DateofbirthPhoneTextBox.TabIndex = 47
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.NameLabel.Location = New System.Drawing.Point(162, 49)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(91, 15)
        Me.NameLabel.TabIndex = 46
        Me.NameLabel.Text = "Student's Name"
        '
        'ClassLabel
        '
        Me.ClassLabel.AutoSize = True
        Me.ClassLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClassLabel.Location = New System.Drawing.Point(162, 96)
        Me.ClassLabel.Name = "ClassLabel"
        Me.ClassLabel.Size = New System.Drawing.Size(77, 15)
        Me.ClassLabel.TabIndex = 45
        Me.ClassLabel.Text = "Current Class"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.AddressLabel.Location = New System.Drawing.Point(15, 198)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(49, 15)
        Me.AddressLabel.TabIndex = 44
        Me.AddressLabel.Text = "Address"
        '
        'EmaiFatherLabel
        '
        Me.EmaiFatherLabel.AutoSize = True
        Me.EmaiFatherLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.EmaiFatherLabel.Location = New System.Drawing.Point(16, 337)
        Me.EmaiFatherLabel.Name = "EmaiFatherLabel"
        Me.EmaiFatherLabel.Size = New System.Drawing.Size(83, 15)
        Me.EmaiFatherLabel.TabIndex = 43
        Me.EmaiFatherLabel.Text = "Father's Name"
        '
        'BirthdatefathercontactLabel
        '
        Me.BirthdatefathercontactLabel.AutoSize = True
        Me.BirthdatefathercontactLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BirthdatefathercontactLabel.Location = New System.Drawing.Point(16, 399)
        Me.BirthdatefathercontactLabel.Name = "BirthdatefathercontactLabel"
        Me.BirthdatefathercontactLabel.Size = New System.Drawing.Size(93, 15)
        Me.BirthdatefathercontactLabel.TabIndex = 42
        Me.BirthdatefathercontactLabel.Text = "Father's Contact"
        '
        'MotherLabel
        '
        Me.MotherLabel.AutoSize = True
        Me.MotherLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MotherLabel.Location = New System.Drawing.Point(12, 456)
        Me.MotherLabel.Name = "MotherLabel"
        Me.MotherLabel.Size = New System.Drawing.Size(89, 15)
        Me.MotherLabel.TabIndex = 41
        Me.MotherLabel.Text = "Mother's Name"
        '
        'MotherPhoneLabel
        '
        Me.MotherPhoneLabel.AutoSize = True
        Me.MotherPhoneLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MotherPhoneLabel.Location = New System.Drawing.Point(11, 517)
        Me.MotherPhoneLabel.Name = "MotherPhoneLabel"
        Me.MotherPhoneLabel.Size = New System.Drawing.Size(99, 15)
        Me.MotherPhoneLabel.TabIndex = 40
        Me.MotherPhoneLabel.Text = "Mother's Contact"
        '
        'EnrolledLabel
        '
        Me.EnrolledLabel.AutoSize = True
        Me.EnrolledLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.EnrolledLabel.Location = New System.Drawing.Point(11, 576)
        Me.EnrolledLabel.Name = "EnrolledLabel"
        Me.EnrolledLabel.Size = New System.Drawing.Size(108, 15)
        Me.EnrolledLabel.TabIndex = 39
        Me.EnrolledLabel.Text = "Date Of Enrollment"
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IDLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.IDLabel.Location = New System.Drawing.Point(162, 2)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(83, 15)
        Me.IDLabel.TabIndex = 38
        Me.IDLabel.Text = "Index Number"
        '
        'EnrolledTextBox
        '
        Me.EnrolledTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EnrolledTextBox.Location = New System.Drawing.Point(11, 586)
        Me.EnrolledTextBox.Name = "EnrolledTextBox"
        Me.EnrolledTextBox.ReadOnly = True
        Me.EnrolledTextBox.Size = New System.Drawing.Size(448, 22)
        Me.EnrolledTextBox.TabIndex = 37
        '
        'MotherPhoneTextBox
        '
        Me.MotherPhoneTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MotherPhoneTextBox.Location = New System.Drawing.Point(11, 527)
        Me.MotherPhoneTextBox.Name = "MotherPhoneTextBox"
        Me.MotherPhoneTextBox.ReadOnly = True
        Me.MotherPhoneTextBox.Size = New System.Drawing.Size(448, 22)
        Me.MotherPhoneTextBox.TabIndex = 36
        '
        'BirthdateFatherNumberTextBox
        '
        Me.BirthdateFatherNumberTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BirthdateFatherNumberTextBox.Location = New System.Drawing.Point(15, 409)
        Me.BirthdateFatherNumberTextBox.Name = "BirthdateFatherNumberTextBox"
        Me.BirthdateFatherNumberTextBox.ReadOnly = True
        Me.BirthdateFatherNumberTextBox.Size = New System.Drawing.Size(448, 22)
        Me.BirthdateFatherNumberTextBox.TabIndex = 35
        '
        'EmailFatherTextBox
        '
        Me.EmailFatherTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EmailFatherTextBox.Location = New System.Drawing.Point(15, 350)
        Me.EmailFatherTextBox.Name = "EmailFatherTextBox"
        Me.EmailFatherTextBox.ReadOnly = True
        Me.EmailFatherTextBox.Size = New System.Drawing.Size(448, 22)
        Me.EmailFatherTextBox.TabIndex = 34
        '
        'ClassTextBox
        '
        Me.ClassTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ClassTextBox.Location = New System.Drawing.Point(162, 110)
        Me.ClassTextBox.Name = "ClassTextBox"
        Me.ClassTextBox.ReadOnly = True
        Me.ClassTextBox.Size = New System.Drawing.Size(301, 22)
        Me.ClassTextBox.TabIndex = 33
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AddressTextBox.Location = New System.Drawing.Point(15, 207)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.ReadOnly = True
        Me.AddressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.AddressTextBox.Size = New System.Drawing.Size(448, 107)
        Me.AddressTextBox.TabIndex = 32
        '
        'ThePictureBox
        '
        Me.ThePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ThePictureBox.Location = New System.Drawing.Point(15, 4)
        Me.ThePictureBox.Name = "ThePictureBox"
        Me.ThePictureBox.Size = New System.Drawing.Size(141, 179)
        Me.ThePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ThePictureBox.TabIndex = 31
        Me.ThePictureBox.TabStop = False
        '
        'MotherTextBox
        '
        Me.MotherTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MotherTextBox.Location = New System.Drawing.Point(11, 468)
        Me.MotherTextBox.Name = "MotherTextBox"
        Me.MotherTextBox.ReadOnly = True
        Me.MotherTextBox.Size = New System.Drawing.Size(448, 22)
        Me.MotherTextBox.TabIndex = 30
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NameTextBox.Location = New System.Drawing.Point(162, 63)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(301, 22)
        Me.NameTextBox.TabIndex = 29
        '
        'IndexTextBox
        '
        Me.IndexTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IndexTextBox.Location = New System.Drawing.Point(162, 16)
        Me.IndexTextBox.Name = "IndexTextBox"
        Me.IndexTextBox.ReadOnly = True
        Me.IndexTextBox.Size = New System.Drawing.Size(301, 22)
        Me.IndexTextBox.TabIndex = 28
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1080, 28)
        Me.MenuStrip1.TabIndex = 63
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnrollNewStudentToolStripMenuItem, Me.ViewStudentsOwingToolStripMenuItem, Me.GenerateReportToolStripMenuItem, Me.UpdateFeesForNewAcademicYearToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.MenuToolStripMenuItem.Text = "     Menu"
        '
        'EnrollNewStudentToolStripMenuItem
        '
        Me.EnrollNewStudentToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EnrollNewStudentToolStripMenuItem.Image = Global.SCHOOL_MANAGEMENT.My.Resources.Resources.child
        Me.EnrollNewStudentToolStripMenuItem.Name = "EnrollNewStudentToolStripMenuItem"
        Me.EnrollNewStudentToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.EnrollNewStudentToolStripMenuItem.Text = "Enroll new student"
        '
        'ViewStudentsOwingToolStripMenuItem
        '
        Me.ViewStudentsOwingToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ViewStudentsOwingToolStripMenuItem.Image = Global.SCHOOL_MANAGEMENT.My.Resources.Resources.owedfees
        Me.ViewStudentsOwingToolStripMenuItem.Name = "ViewStudentsOwingToolStripMenuItem"
        Me.ViewStudentsOwingToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.ViewStudentsOwingToolStripMenuItem.Text = "View Students owing"
        '
        'GenerateReportToolStripMenuItem
        '
        Me.GenerateReportToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GenerateReportToolStripMenuItem.Image = Global.SCHOOL_MANAGEMENT.My.Resources.Resources.report
        Me.GenerateReportToolStripMenuItem.Name = "GenerateReportToolStripMenuItem"
        Me.GenerateReportToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.GenerateReportToolStripMenuItem.Text = "Generate Report"
        '
        'UpdateFeesForNewAcademicYearToolStripMenuItem
        '
        Me.UpdateFeesForNewAcademicYearToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UpdateFeesForNewAcademicYearToolStripMenuItem.Image = Global.SCHOOL_MANAGEMENT.My.Resources.Resources.newfees
        Me.UpdateFeesForNewAcademicYearToolStripMenuItem.Name = "UpdateFeesForNewAcademicYearToolStripMenuItem"
        Me.UpdateFeesForNewAcademicYearToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.UpdateFeesForNewAcademicYearToolStripMenuItem.Text = "Update fees for new academic year"
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeleteButton.ForeColor = System.Drawing.Color.OrangeRed
        Me.DeleteButton.Location = New System.Drawing.Point(383, 803)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(312, 28)
        Me.DeleteButton.TabIndex = 64
        Me.DeleteButton.Text = "Delete from database"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 848)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ClassComboBox)
        Me.Controls.Add(Me.StaffButton)
        Me.Controls.Add(Me.StudentsButton)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.AdminDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AdminDashboard"
        Me.Opacity = 0.95R
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WOODFORT BLISS MANAGEMENT SYSTEM"
        CType(Me.AdminPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ThePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents CurrentTimer As Timer
    Friend WithEvents SettingsButton As Button
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents DateLabel As Label
    Friend WithEvents AdminPictureBox As PictureBox
    Friend WithEvents AdminDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StudentsButton As Button
    Friend WithEvents StaffButton As Button
    Friend WithEvents ClassComboBox As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FeesLabel As Label
    Friend WithEvents FeesTextBox As TextBox
    Friend WithEvents PhoneDateLabel As Label
    Friend WithEvents DateofbirthPhoneTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents ClassLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents EmaiFatherLabel As Label
    Friend WithEvents BirthdatefathercontactLabel As Label
    Friend WithEvents MotherLabel As Label
    Friend WithEvents MotherPhoneLabel As Label
    Friend WithEvents EnrolledLabel As Label
    Friend WithEvents IDLabel As Label
    Friend WithEvents EnrolledTextBox As TextBox
    Friend WithEvents MotherPhoneTextBox As TextBox
    Friend WithEvents BirthdateFatherNumberTextBox As TextBox
    Friend WithEvents EmailFatherTextBox As TextBox
    Friend WithEvents ClassTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents ThePictureBox As PictureBox
    Friend WithEvents MotherTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents IndexTextBox As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnrollNewStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewStudentsOwingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateFeesForNewAcademicYearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteButton As Button
    Friend WithEvents GenerateReportToolStripMenuItem As ToolStripMenuItem
End Class
