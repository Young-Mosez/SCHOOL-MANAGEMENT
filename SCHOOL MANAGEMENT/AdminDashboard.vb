Imports System.Data.SqlClient
Imports System.IO
Imports System.Data

Public Class AdminDashboard
    Dim currentclass = "Nursery 1"
    Dim staffid
    Dim selected
    Dim myConn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MOFICT\source\repos\SCHOOL MANAGEMENT\SCHOOL MANAGEMENT\SchoolDatabase.mdf;Integrated Security=True;Connect Timeout=30")

    'this get the students's data and fills the data grid view
    Public Sub FilterStudentData(valueToSearch As String, currentclass As String)

        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If

        myConn.Open()

        Dim searcher As String = "SELECT Index_Number, Student_Name FROM Students WHERE CONCAT(Index_Number, Student_Name) like '%" & valueToSearch & "%' AND Current_Class = '" + currentclass + "'  "
        Dim command As New SqlCommand(searcher, myConn)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        AdminDataGridView.DataSource = table

        myConn.Close()



    End Sub


    'this gets all the teacher and fills the data grid view
    Public Sub FilterStaffData(valueToSearch As String)
        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If

        myConn.Open()
        Dim searcher As String = "SELECT ID_Number, Name, Class FROM Users WHERE CONCAT(Name, Class) like '%" & valueToSearch & "%' AND Clearance= 'Teacher' "
        Dim command As New SqlCommand(searcher, myConn)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        AdminDataGridView.DataSource = table

        myConn.Close()

    End Sub

    'this gets the admins details like username and picture
    Private Sub GetInfo(adminid)
        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If

        myConn.Open()

        'this gets other details of the logged in user

        Dim getclass As New SqlCommand
        getclass = myConn.CreateCommand()
        getclass.CommandType = CommandType.Text
        getclass.CommandText = "SELECT * FROM Users WHERE ID_Number='" + adminid + "'"
        getclass.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim ad As New SqlDataAdapter(getclass)
        ad.Fill(dt)
        Dim dr As SqlClient.SqlDataReader
        dr = getclass.ExecuteReader(CommandBehavior.CloseConnection)



        While dr.Read
            Dim picbyte() As Byte = dt.Rows(0).Item("Picture")
            Dim pic As New System.IO.MemoryStream(picbyte)
            UsernameLabel.Text = dr.GetString(1).ToString()
            AdminPictureBox.Image = Image.FromStream(pic)
            pic.Close()
        End While

    End Sub

    'this shows the details of the student selected in the grid view
    Private Sub Showstudentsdetails(selected)
        'calls the studentview to adjust for students' view
        StudentView()

        Dim getstudent As New SqlCommand
        getstudent = myConn.CreateCommand()
        getstudent.CommandType = CommandType.Text
        getstudent.CommandText = "SELECT * FROM Students WHERE Index_Number='" + selected + "'"
        getstudent.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim ad As New SqlDataAdapter(getstudent)
        ad.Fill(dt)
        Dim dr As SqlClient.SqlDataReader
        dr = getstudent.ExecuteReader(CommandBehavior.CloseConnection)

        While dr.Read
            Dim picbyte() As Byte = dt.Rows(0).Item("Student_Picture")
            Dim pic As New System.IO.MemoryStream(picbyte)

            IndexTextBox.Text = dr.GetString(0).ToString()
            NameTextBox.Text = dr.GetString(1).ToString()
            ClassTextBox.Text = dr.GetString(2).ToString()
            DateofbirthPhoneTextBox.Text = dr.GetString(3).ToString()
            AddressTextBox.Text = dr.GetString(8).ToString()
            EmailFatherTextBox.Text = dr.GetString(4).ToString()
            BirthdateFatherNumberTextBox.Text = dr.GetString(5).ToString()
            MotherTextBox.Text = dr.GetString(6).ToString()
            MotherPhoneTextBox.Text = dr.GetString(7).ToString()
            EnrolledTextBox.Text = dr.GetString(9).ToString()
            FeesTextBox.Text = dr.ToString(11)


            ThePictureBox.Image = Image.FromStream(pic)
            pic.Close()
        End While
    End Sub

    'This gets sthe staff details and outputs them to their respective places
    Private Sub ShowStaffdetails(selected)
        'call staffview to adjust for staff view
        StaffView()

        Dim getstaff As New SqlCommand
        getstaff = myConn.CreateCommand()
        getstaff.CommandType = CommandType.Text
        getstaff.CommandText = "SELECT * FROM Users WHERE ID_Number='" + selected + "'"
        getstaff.ExecuteNonQuery()

        Dim dt As New DataTable()
        Dim ad As New SqlDataAdapter(getstaff)
        ad.Fill(dt)
        Dim dr As SqlClient.SqlDataReader
        dr = getstaff.ExecuteReader(CommandBehavior.CloseConnection)

        While dr.Read
            Dim picbyte() As Byte = dt.Rows(0).Item("Picture")
            Dim pic As New System.IO.MemoryStream(picbyte)

            IndexTextBox.Text = dr.GetString(0).ToString()
            NameTextBox.Text = dr.GetString(1).ToString()
            ClassTextBox.Text = dr.GetString(6).ToString()
            DateofbirthPhoneTextBox.Text = dr.GetString(3).ToString()
            AddressTextBox.Text = dr.GetString(5).ToString()
            EmailFatherTextBox.Text = dr.GetString(4).ToString()
            BirthdateFatherNumberTextBox.Text = dr.GetString(2).ToString()


            ThePictureBox.Image = Image.FromStream(pic)
            pic.Close()
        End While

    End Sub

    'this SUB shows the right textboxes and to be displayed
    Private Sub StaffView()
        Cleartextboxes()
        MotherLabel.Visible = False
        MotherTextBox.Visible = False
        MotherPhoneLabel.Visible = False
        MotherPhoneTextBox.Visible = False
        EnrolledLabel.Visible = False
        EnrolledTextBox.Visible = False
        FeesLabel.Visible = False
        FeesTextBox.Visible = False
        DeleteButton.Enabled = False

        ThePictureBox.Image = ThePictureBox.InitialImage

        IDLabel.Text = "Staff ID"
        NameLabel.Text = "Name"
        EmaiFatherLabel.Text = "Email"
        PhoneDateLabel.Text = "Phone Number"
        BirthdatefathercontactLabel.Text = "Date of Birth"

    End Sub

    'this SUB shows the right textboxes for student's view
    Private Sub StudentView()
        Cleartextboxes()
        MotherLabel.Visible = True
        MotherTextBox.Visible = True
        MotherPhoneLabel.Visible = True
        MotherPhoneTextBox.Visible = True
        EnrolledLabel.Visible = True
        EnrolledTextBox.Visible = True
        FeesLabel.Visible = True
        FeesTextBox.Visible = True
        DeleteButton.Enabled = True

        ThePictureBox.Image = ThePictureBox.InitialImage


        IDLabel.Text = "Student ID"
        NameLabel.Text = "Student Name"
        EmaiFatherLabel.Text = "Father's Name"
        PhoneDateLabel.Text = "Date of Birth"
        BirthdatefathercontactLabel.Text = "Father's Contact"
    End Sub

    'this resets the content of the textboxes
    Private Sub Cleartextboxes()
        'make textboxes empty
        IndexTextBox.Text = ""
        NameTextBox.Text = ""
        ClassTextBox.Text = ""
        DateofbirthPhoneTextBox.Text = ""
        AddressTextBox.Text = ""
        EmailFatherTextBox.Text = ""
        BirthdateFatherNumberTextBox.Text = ""
        MotherTextBox.Text = ""
        EnrolledTextBox.Text = ""
        FeesTextBox.Text = ""
        SearchTextBox.Text = ""
    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        staffid = LoginForm.staffid
        GetInfo(staffid)
        StudentsButton.Enabled = False
        StaffButton.Enabled = True

        FilterStudentData(SearchTextBox.Text, currentclass)
        StudentView()
    End Sub

    Private Sub StudentsButton_Click(sender As Object, e As EventArgs) Handles StudentsButton.Click

        SearchTextBox.Text = ""
        StaffButton.Enabled = True
        StudentsButton.Enabled = False
        ClassComboBox.Visible = True
        FilterStudentData(SearchTextBox.Text, currentclass)
        StudentView()
    End Sub

    Private Sub StaffButton_Click(sender As Object, e As EventArgs) Handles StaffButton.Click
        SearchTextBox.Text = ""
        StaffButton.Enabled = False
        StudentsButton.Enabled = True
        FilterStaffData(SearchTextBox.Text)
        ClassComboBox.Visible = False
        StaffView()

    End Sub

    Private Sub ClassComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClassComboBox.SelectedIndexChanged
        currentclass = ClassComboBox.SelectedItem
        FilterStudentData(SearchTextBox.Text, currentclass)
        Cleartextboxes()

    End Sub

    Private Sub CurrentTimer_Tick(sender As Object, e As EventArgs) Handles CurrentTimer.Tick
        DateLabel.Text = Date.Now

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        myConn.Close()
        Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub EnrollNewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnrollNewStudentToolStripMenuItem.Click
        EnrollStudent.ShowDialog()
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If (StudentsButton.Enabled = False) Then
            FilterStudentData(SearchTextBox.Text, currentclass)

        ElseIf (StaffButton.Enabled = False) Then
            FilterStaffData(SearchTextBox.Text)
        End If

        If SearchTextBox.Text = "" Then
            SearchTextBox.PlaceholderText = "       Search Student's Name or Index Number here"
        End If
    End Sub

    Private Sub AdminDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AdminDataGridView.CellContentClick
        Try
            If myConn.State = ConnectionState.Open Then
                myConn.Close()

            End If

            myConn.Open()

            selected = Convert.ToString(AdminDataGridView.SelectedCells.Item(0).Value.ToString())
            MessageBox.Show(selected)

            If (StaffButton.Enabled = False) Then
                ShowStaffdetails(selected)

            ElseIf (StudentsButton.Enabled = False) Then
                Showstudentsdetails(selected)
            End If

        Catch exception As System.ArgumentOutOfRangeException

        End Try


    End Sub

    Private Sub UpdateFeesForNewAcademicYearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateFeesForNewAcademicYearToolStripMenuItem.Click
        SetFees.ShowDialog()

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If
        myConn.Open()

        Dim deletestudent As New SqlCommand
        deletestudent = myConn.CreateCommand()
        deletestudent.CommandType = CommandType.Text
        deletestudent.CommandText = "DELETE FROM Students WHERE Index_Number = '" + selected + "' "

        If (selected <> "") Then


            If MessageBox.Show("Do you want to delete " + NameTextBox.Text + " from the records?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                deletestudent.ExecuteNonQuery()
                MessageBox.Show("Success", " ", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            End If

        End If

    End Sub
End Class