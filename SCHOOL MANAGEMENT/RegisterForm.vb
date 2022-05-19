'sql connection
Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
'camera api
Imports AForge.Video
Imports AForge.Video.DirectShow


Public Class RegisterForm
    Private Const CmdText As String = "INSERT INTO Users(ID_Number, Name, Date_of_Birth, Phone_Number, Email, Address, Class, Picture, Clearance, Password) VALUES
(@number, @name, @date, @phone, @email, @address, @class, @picture, @clearance, @password)"
    'camera avriables
    Dim CAMERA As VideoCaptureDevice
    Dim bmp As Bitmap
    'connection string
    Dim myConn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MOFICT\source\repos\SCHOOL MANAGEMENT\SCHOOL MANAGEMENT\SchoolDatabase.mdf;Integrated Security=True;Connect Timeout=30")

    Dim id, classes
    'Camera status
    Dim cameraStat = False
    Dim cameraimage



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If (CameraPictureBox.Visible = True) Then
            CAMERA.SignalToStop()
            CAMERA.WaitForStop()
        End If
        'This deactivates the camera
        UserPictureBox.Visible = True
        CameraPictureBox.Visible = False
        CaptureButton.Visible = False
        ChangeImageLabel.Visible = False
        Dim open As New OpenFileDialog()
        open.Filter = "Image Files(*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp"
        If open.ShowDialog() = DialogResult.OK Then
            Dim filename As String = System.IO.Path.GetFullPath(open.FileName)
            UserPictureBox.Image = New Bitmap(open.FileName)
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If (CameraPictureBox.Visible = True) Then
            CAMERA.SignalToStop()
            CAMERA.WaitForStop()
        End If

        LoginForm.Show()
        Close()
    End Sub

    Private Sub PositionComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PositionComboBox.SelectedIndexChanged
        If (PositionComboBox.Text = "Teacher") Then
            ClassComboBox.Visible = True
            PasscodeTextBox.Visible = False
            ClassPassLabel.Text = "Class"
            ClassPassLabel.Visible = True
        ElseIf (PositionComboBox.Text = "Administration") Then
            PasscodeTextBox.Visible = True
            ClassComboBox.Visible = False
            ClassPassLabel.Text = "Passcode (Contact the System Admin for the passcode)"
            ClassPassLabel.Visible = True
        ElseIf (PositionComboBox.Text = "Management") Then
            PasscodeTextBox.Visible = True
            ClassComboBox.Visible = False
            ClassPassLabel.Text = "Passcode (Contact the System Admin for the passcode)"
            ClassPassLabel.Visible = True
        End If
    End Sub

    'when the picturebox is clicked
    Private Sub UserPictureBox_Click(sender As Object, e As EventArgs) Handles UserPictureBox.Click
        If (cameraStat = True) Then
            CAMERA.SignalToStop()
            CAMERA.WaitForStop()
        End If
        UserPictureBox.Visible = False
        CameraPictureBox.Visible = True
        CaptureButton.Visible = True
        ChangeImageLabel.Visible = False

        'We display a form for the user to select a camera to use
        Dim cameraoption As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If cameraoption.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CAMERA = cameraoption.VideoDevice
            AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            CAMERA.Start()
        End If
    End Sub

    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        CameraPictureBox.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    'when the form loads initially
    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CameraPictureBox.Visible = False
        CaptureButton.Visible = False
        UserPictureBox.Visible = True
    End Sub

    'when the camera capture button is clicked
    Private Sub CaptureButton_Click(sender As Object, e As EventArgs) Handles CaptureButton.Click
        Dim ms As New MemoryStream()
        CameraPictureBox.Image.Save(ms, CameraPictureBox.Image.RawFormat)

        UserPictureBox.Image = Image.FromStream(ms)
        CAMERA.SignalToStop()
        CAMERA.WaitForStop()
        CameraPictureBox.Visible = False
        CaptureButton.Visible = False
        UserPictureBox.Visible = True
        ChangeImageLabel.Visible = True

    End Sub

    Private Sub CameraPictureBox_Click(sender As Object, e As EventArgs) Handles CameraPictureBox.Click
        CAMERA.SignalToStop()
        CAMERA.WaitForStop()
        ChangeImageLabel.Visible = False
        CAMERA.Start()
    End Sub

    'this function generates user ID for teachers using TC, FIRST 2 CHARS IN THEIR NAME, AND A RANDOM NUMBER BETWEEN 0 AND 99
    'this is returned as id
    Private Function Generateteacherid()
        Dim random As New Random()
        Dim first = FirstNameTextBox.Text.Substring(0, 1).ToUpper
        Dim second = LastNameTextBox.Text.Substring(0, 1).ToUpper
        Dim number = Convert.ToString(random.Next(0, 99))

        id = "TC" + first + second + number
        Return id
    End Function

    Private Function Generateadminid()
        Dim random As New Random()
        Dim first = FirstNameTextBox.Text.Substring(0, 1).ToUpper
        Dim second = LastNameTextBox.Text.Substring(0, 1).ToUpper
        Dim number = Convert.ToString(random.Next(0, 99))

        id = "AD" + first + second + number
        Return id
    End Function

    Private Function Generatemanageid()
        Dim random As New Random()
        Dim first = FirstNameTextBox.Text.Substring(0, 1).ToUpper
        Dim second = LastNameTextBox.Text.Substring(0, 1).ToUpper
        Dim number = Convert.ToString(random.Next(0, 99))

        id = "MG" + first + second + number
        Return id
    End Function

    'this sub adds the data of a bew registration to the database
    Private Sub RegistertoDatabase(clearance)
        ' Try
        Dim comm As New SqlCommand(CmdText, myConn)

        'the sql command uses parameters instead of direct values to preveny possible sql injection attacks
        'the user image will be saved into a memory stream before inserted into the database
        Dim ms As New MemoryStream()
        UserPictureBox.Image.Save(ms, UserPictureBox.Image.RawFormat)

        'gets the id number generated
        If (clearance = "Teacher") Then
                classes = ClassComboBox.SelectedItem.ToString()     'if a teacher is selected, this assigns the teacher  the class selected
                Dim idnumber = Generateteacherid()
                Dim mess As String = "Your assigned ID number is " + idnumber + ". Please take note of that"
                MessageBox.Show(mess, "Take Note, very important", MessageBoxButtons.OK, MessageBoxIcon.Information)
                comm.Parameters.Add("@number", SqlDbType.VarChar).Value = idnumber
            ElseIf (clearance = "Administration") Then
                classes = "None"        'if admin is selected, this assigns the admin with a none class
                Dim idnumber = Generateadminid()
                Dim mess As String = "Your assigned ID number is " + idnumber + ". Please take note of that"
                MessageBox.Show(mess, "Take Note, very important", MessageBoxButtons.OK, MessageBoxIcon.Information)
                comm.Parameters.Add("@number", SqlDbType.VarChar).Value = idnumber
            ElseIf (clearance = "Management") Then
            classes = "None"         'if management is selected, this assigns the manager with a none class
            Dim idnumber = Generatemanageid()
                Dim mess As String = "Your assigned ID number is " + idnumber + ". Please take note of that"
                MessageBox.Show(mess, "Take Note, very important", MessageBoxButtons.OK, MessageBoxIcon.Information)
                comm.Parameters.Add("@number", SqlDbType.VarChar).Value = idnumber
            End If

            'now the params
            comm.Parameters.Add("@name", SqlDbType.VarChar).Value = FirstNameTextBox.Text + " " + LastNameTextBox.Text
            comm.Parameters.Add("@date", SqlDbType.VarChar).Value = DateTimePicker1.Value.ToString()
            comm.Parameters.Add("@phone", SqlDbType.VarChar).Value = PhoneTextBox.Text
            comm.Parameters.Add("@email", SqlDbType.VarChar).Value = EmailTextBox.Text
            comm.Parameters.Add("@address", SqlDbType.VarChar).Value = AddressTextBox.Text
            comm.Parameters.Add("@class", SqlDbType.VarChar).Value = classes
            comm.Parameters.Add("@picture", SqlDbType.Image).Value = ms.ToArray()
            comm.Parameters.Add("@clearance", SqlDbType.VarChar).Value = PositionComboBox.SelectedItem.ToString()
            comm.Parameters.Add("@password", SqlDbType.VarChar).Value = PasswordTextBox.Text

            myConn.Open()
            If comm.ExecuteNonQuery() = 1 Then
                LoginForm.Show()
                Close()

            Else
                MessageBox.Show("There was a problem registering you to the databse. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        '  Catch e As Exception
        ' MessageBox.Show(e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ' End Try
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs)
        If (CameraPictureBox.Visible = True) Then
            CAMERA.SignalToStop()
            CAMERA.WaitForStop()
        End If

        Close()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        If (CameraPictureBox.Visible = True) Then
            CAMERA.SignalToStop()
            CAMERA.WaitForStop()
        End If

        Close()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (FirstNameTextBox.Text = "" Or FirstNameTextBox.Text = " ") Then
            FirstNameTextBox.Text = ""
            FirstNameTextBox.Focus()
        ElseIf (LastNameTextBox.Text = "" Or LastNameTextBox.Text = " ") Then
            LastNameTextBox.Text = ""
            LastNameTextBox.Focus()
        Else
            If (PositionComboBox.Text = "") Then
                MessageBox.Show("Select your position or role", "Requirement", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If (PositionComboBox.Text = "Teacher") Then
                    If (ClassComboBox.Text = "") Then
                        MessageBox.Show("Select the class you have been assigned to", "Requirement", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        If (PasswordTextBox.Text = "") Then
                            MessageBox.Show("Provide and confirm password", "Requirement", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ConfirmTextBox.Text = ""
                            PasswordTextBox.Focus()
                        Else
                            If (ConfirmTextBox.Text = "") Then
                                MessageBox.Show("Confirm the password you provided", "Requirement", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ConfirmTextBox.Focus()
                            Else
                                If (PasswordTextBox.Text = ConfirmTextBox.Text) Then

                                    RegistertoDatabase(PositionComboBox.SelectedItem.ToString())

                                Else
                                    MessageBox.Show("The passwords you provided do not match", "Requirement", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    PasswordTextBox.Text = ""
                                    ConfirmTextBox.Text = ""
                                    PasswordTextBox.Focus()
                                End If
                            End If
                        End If
                    End If
                ElseIf (PositionComboBox.Text = "Administration" Or PositionComboBox.Text = "Management") Then
                    'checks if passcode has been provided when admin is selected
                    If (PasscodeTextBox.Text = "") Then
                        MessageBox.Show("The passcode to the system is required", "Requirement", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        PasscodeTextBox.Focus()
                    Else
                        If (PasswordTextBox.Text = ConfirmTextBox.Text) Then
                            RegistertoDatabase(PositionComboBox.SelectedItem.ToString())
                        Else
                            MessageBox.Show("The passwords provided do not match", "Requirement", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            PasswordTextBox.Text = ""
                            ConfirmTextBox.Text = ""
                            PasswordTextBox.Focus()
                        End If
                    End If

                End If
            End If
        End If

    End Sub
End Class