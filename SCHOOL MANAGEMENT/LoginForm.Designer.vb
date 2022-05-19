<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.SigninButton = New System.Windows.Forms.Button()
        Me.RegisterLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserTextBox
        '
        Me.UserTextBox.AutoCompleteCustomSource.AddRange(New String() {"TC", "AD", "MG"})
        Me.UserTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.UserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UserTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UserTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UserTextBox.Location = New System.Drawing.Point(30, 225)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.PlaceholderText = "  Staff ID"
        Me.UserTextBox.Size = New System.Drawing.Size(339, 29)
        Me.UserTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PasswordTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PasswordTextBox.Location = New System.Drawing.Point(30, 292)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PlaceholderText = "  Password"
        Me.PasswordTextBox.ShortcutsEnabled = False
        Me.PasswordTextBox.Size = New System.Drawing.Size(339, 29)
        Me.PasswordTextBox.TabIndex = 2
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'SigninButton
        '
        Me.SigninButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.SigninButton.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SigninButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SigninButton.Location = New System.Drawing.Point(30, 348)
        Me.SigninButton.Name = "SigninButton"
        Me.SigninButton.Size = New System.Drawing.Size(339, 45)
        Me.SigninButton.TabIndex = 0
        Me.SigninButton.Text = "Login"
        Me.SigninButton.UseVisualStyleBackColor = False
        '
        'RegisterLinkLabel
        '
        Me.RegisterLinkLabel.AutoSize = True
        Me.RegisterLinkLabel.Font = New System.Drawing.Font("Segoe UI Historic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RegisterLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.RegisterLinkLabel.LinkColor = System.Drawing.Color.DodgerBlue
        Me.RegisterLinkLabel.Location = New System.Drawing.Point(69, 421)
        Me.RegisterLinkLabel.Name = "RegisterLinkLabel"
        Me.RegisterLinkLabel.Size = New System.Drawing.Size(261, 17)
        Me.RegisterLinkLabel.TabIndex = 3
        Me.RegisterLinkLabel.TabStop = True
        Me.RegisterLinkLabel.Text = "Don't have an account yet? Click here"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SCHOOL_MANAGEMENT.My.Resources.Resources.child
        Me.PictureBox1.Location = New System.Drawing.Point(107, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.Location = New System.Drawing.Point(347, 7)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(22, 21)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "X"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.DarkGray
        Me.LinkLabel2.Location = New System.Drawing.Point(323, -4)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(28, 37)
        Me.LinkLabel2.TabIndex = 11
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "-"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(394, 639)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RegisterLinkLabel)
        Me.Controls.Add(Me.SigninButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UserTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.Opacity = 0.95R
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents SigninButton As Button
    Friend WithEvents RegisterLinkLabel As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
