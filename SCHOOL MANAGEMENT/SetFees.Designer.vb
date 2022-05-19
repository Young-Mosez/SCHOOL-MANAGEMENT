<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetFees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetFees))
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AmountTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ClassComboBox = New System.Windows.Forms.ComboBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon
        '
        Me.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon.BalloonTipText = "Select the class from the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "list" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "NotifyIcon"
        Me.NotifyIcon.Visible = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.AmountTextBox)
        Me.Panel1.Controls.Add(Me.ClassComboBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(381, 164)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(13, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(354, 36)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Update Fee"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AmountTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AmountTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.AmountTextBox.Location = New System.Drawing.Point(284, 37)
        Me.AmountTextBox.Mask = "0000000"
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(83, 29)
        Me.AmountTextBox.TabIndex = 1
        Me.AmountTextBox.ValidatingType = GetType(Integer)
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
        Me.ClassComboBox.Location = New System.Drawing.Point(13, 37)
        Me.ClassComboBox.MaxDropDownItems = 20
        Me.ClassComboBox.Name = "ClassComboBox"
        Me.ClassComboBox.Size = New System.Drawing.Size(220, 29)
        Me.ClassComboBox.TabIndex = 0
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel2.Location = New System.Drawing.Point(371, 9)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(22, 21)
        Me.LinkLabel2.TabIndex = 55
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "X"
        '
        'SetFees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(405, 228)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SetFees"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents AmountTextBox As MaskedTextBox
    Friend WithEvents ClassComboBox As ComboBox
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
