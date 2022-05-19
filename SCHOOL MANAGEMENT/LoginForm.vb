'sql connection
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class LoginForm
    Public Shared staffid As String
    Public Shared teacherclass As String

    Dim myConn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MOFICT\source\repos\SCHOOL MANAGEMENT\SCHOOL MANAGEMENT\SchoolDatabase.mdf;Integrated Security=True;Connect Timeout=30")
    'this function verifies the user's credentials
    Function CheckSignIn(id, password)

        Dim stats
        Dim myCommand As New SqlCommand("SELECT * FROM Users WHERE ID_Number='" + id + "' and Password= '" + password + "' ", myConn)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(myCommand)
        Dim dt As DataTable = New DataTable()
        adapter.Fill(dt)
        If (dt.Rows.Count > 0) Then
            stats = True
        Else
            stats = False
        End If
        Return stats

    End Function

    'this sub is fired if the credentials is that of a teacher
    Private Sub Itisteacher()
        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If

        myConn.Open()
        staffid = UserTextBox.Text
        Dim getclass As New SqlCommand
        getclass = myConn.CreateCommand()
        getclass.CommandType = CommandType.Text
        getclass.CommandText = "SELECT * FROM Users WHERE ID_Number='" + staffid + "'"
        getclass.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(getclass)
        da.Fill(dt)
        Dim dr As SqlClient.SqlDataReader
        dr = getclass.ExecuteReader(CommandBehavior.CloseConnection)

        While dr.Read
            teacherclass = dr.GetString(6).ToString()
        End While

        MessageBox.Show(teacherclass)
        TeacherDashboard.Show()
        Close()
    End Sub

    'this sub is fired if the credentials are that of the administration
    Private Sub Itisadmin()
        staffid = UserTextBox.Text
        AdminDashboard.Show()
        Close()
    End Sub

    'this sub is fired when the credentials is that of the management
    Private Sub Itismanagement()
        staffid = UserTextBox.Text
        ManagementDashboard.Show()
        Close()
    End Sub

    'this sub will be called when there is a request for sign in
    Private Sub Signin()
        Try
            Dim stats

            If (UserTextBox.Text = "") Then
                MessageBox.Show("Provide your Staff ID", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UserTextBox.Focus()
                PasswordTextBox.Text = ""
            ElseIf (PasswordTextBox.Text = "") Then
                MessageBox.Show("Provide your Password", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PasswordTextBox.Focus()

            Else
                stats = CheckSignIn(UserTextBox.Text, PasswordTextBox.Text)
                Dim suffix = UserTextBox.Text.Substring(0, 1)
                If (stats = True) Then
                    If (suffix = "T") Then
                        Itisteacher()
                    ElseIf (suffix = "A") Then
                        Itisadmin()
                    ElseIf (suffix = "M") Then
                        Itismanagement()
                    End If

                Else
                    MessageBox.Show("The Credentials provided do not match anything in the database", " ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    UserTextBox.Text = ""
                    PasswordTextBox.Text = ""
                    UserTextBox.Focus()

                End If
            End If
        Catch Ex As Exception
            MessageBox.Show("There was an error connecting to the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RegisterLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RegisterLinkLabel.LinkClicked
        RegisterForm.Show()
        Close()
    End Sub

    Private Sub SigninButton_Click(sender As Object, e As EventArgs) Handles SigninButton.Click
        Signin()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub PasswordTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Signin()
        End If
    End Sub

    Private Sub UserTextBox_TextChanged(sender As Object, e As EventArgs) Handles UserTextBox.TextChanged

    End Sub

    Private Sub UserTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UserTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            PasswordTextBox.Focus()
        End If
    End Sub
End Class