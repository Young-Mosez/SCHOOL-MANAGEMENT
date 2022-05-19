Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class EnrollStudent
    Private Const CmdText As String = "INSERT INTO Students(Index_Number, Student_Name, Current_Class, Year_of_Birth, Father_Name, Father_Phone,
Mother_Name, Mother_Phone, Home_Address, Date_Enrolled, Student_Picture, Fees_Owed) VALUES
(@index, @name, @class, @birthdate, @father, @fnumber, @mother, @mnumber, @address, @enrolleddate, @picture, @fees)"

    Private Const getnumber As String = "SELECT COUNT(*) FROM Students"
    Dim myConn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MOFICT\source\repos\SCHOOL MANAGEMENT\SCHOOL MANAGEMENT\SchoolDatabase.mdf;Integrated Security=True;Connect Timeout=30")

    Dim enrolldate As String        'this picks the current date and time as the enrolled date
    Dim numberOfStudents

    Private Sub getnumberofstudents()
        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If
        myConn.Open()

        Dim comm As New SqlCommand(getnumber, myConn)
        numberOfStudents = comm.ExecuteScalar
        myConn.Close()
    End Sub

    Private Function getfees(selected)
        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If
        myConn.Open()

        Dim fees As Int16
        Dim comm As New SqlCommand("SELECT * FROM Fees WHERE Class='" + selected + "' ", myConn)
        comm.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim ad As New SqlDataAdapter(comm)
        ad.Fill(dt)
        Dim dr As SqlClient.SqlDataReader
        dr = comm.ExecuteReader(CommandBehavior.CloseConnection)

        While dr.Read
            fees = dr.GetInt32(1)
        End While

        Return fees

        dr.Close()
        myConn.Close()

    End Function
    Private Function generateid()
        Dim first = FirstNameTextBox.Text.Substring(0, 1).ToUpper
        Dim second = LastNameTextBox.Text.Substring(0, 1).ToUpper
        Dim number = numberOfStudents + 1

        Dim identity = "ST" + first + second + number.ToString()
        Return identity
    End Function

    Private Sub registertodatabase()

        Dim selectedclass = ClassComboBox.SelectedItem
        Dim fees = getfees(selectedclass)

        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If

        myConn.Open()

        Dim generatedid = generateid()


        Dim comm As New SqlCommand(CmdText, myConn)

        Dim ms As New MemoryStream()
        UserPictureBox.Image.Save(ms, UserPictureBox.Image.RawFormat)


        'now the params
        comm.Parameters.Add("@index", SqlDbType.VarChar).Value = generatedid
        comm.Parameters.Add("@name", SqlDbType.VarChar).Value = FirstNameTextBox.Text + " " + LastNameTextBox.Text
        comm.Parameters.Add("@class", SqlDbType.VarChar).Value = ClassComboBox.SelectedItem.ToString
        comm.Parameters.Add("@birthdate", SqlDbType.VarChar).Value = DateTimePicker.Value.ToString()
        comm.Parameters.Add("@father", SqlDbType.VarChar).Value = FatherTextBox.Text
        comm.Parameters.Add("@fnumber", SqlDbType.VarChar).Value = FatherPhoneTextBox.Text
        comm.Parameters.Add("@mother", SqlDbType.VarChar).Value = MotherTextBox.Text
        comm.Parameters.Add("@mnumber", SqlDbType.VarChar).Value = MotherPhoneMaskedTextBox.Text
        comm.Parameters.Add("@address", SqlDbType.VarChar).Value = AddressTextBox.Text
        comm.Parameters.Add("@enrolleddate", SqlDbType.VarChar).Value = enrolldate.ToString
        comm.Parameters.Add("@picture", SqlDbType.Image).Value = ms.ToArray()
        comm.Parameters.Add("@fees", SqlDbType.Int).Value = fees
        If comm.ExecuteNonQuery() = 1 Then
            MessageBox.Show("")
            Close()

        Else
            MessageBox.Show("There was a problem registering you to the databse. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'This deactivates the camera
        UserPictureBox.Visible = True
        Dim open As New OpenFileDialog()
        open.Filter = "Image Files(*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp"
        If open.ShowDialog() = DialogResult.OK Then
            Dim filename As String = System.IO.Path.GetFullPath(open.FileName)
            UserPictureBox.Image = New Bitmap(open.FileName)
        End If
    End Sub

    Private Sub EnrollStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enrolldate = Date.Now.ToString()
        getnumberofstudents()

    End Sub

    Private Sub EnrollButton_Click(sender As Object, e As EventArgs) Handles EnrollButton.Click
        registertodatabase()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Close()
    End Sub
End Class