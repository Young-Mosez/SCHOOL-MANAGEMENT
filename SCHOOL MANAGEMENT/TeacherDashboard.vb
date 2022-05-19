Imports System.Data.SqlClient

Public Class TeacherDashboard
    Dim teacherid
    Dim teacherclass
    Dim selected
    Dim myConn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MOFICT\source\repos\SCHOOL MANAGEMENT\SCHOOL MANAGEMENT\SchoolDatabase.mdf;Integrated Security=True;Connect Timeout=30")


    Private Sub GetInfo(teacherid)
        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If

        myConn.Open()

        'this gets other details of the user

        Dim getclass As New SqlCommand
        getclass = myConn.CreateCommand()
        getclass.CommandType = CommandType.Text
        getclass.CommandText = "SELECT * FROM Users WHERE ID_Number='" + teacherid + "'"
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
            TeacherPictureBox.Image = Image.FromStream(pic)
            pic.Close()

        End While

    End Sub
    Private Sub CurrentTimer_Tick(sender As Object, e As EventArgs) Handles CurrentTimer.Tick
        DateLabel.Text = Date.Now()
    End Sub

    Private Sub TeacherDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        teacherid = LoginForm.staffid
        teacherclass = LoginForm.teacherclass

        GetInfo(teacherid)
        FilterData("")

        myConn.Close()
    End Sub

    Public Sub FilterData(valueToSearch As String)

        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If

        myConn.Open()

        Dim searcher As String = "SELECT Index_Number, Student_Name FROM Students WHERE CONCAT(Index_Number, Student_Name) like '%" & valueToSearch & "%' AND Current_Class = '%" & teacherclass & "%'  "
        Dim command As New SqlCommand(searcher, myConn)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        StudentsDataGridView.DataSource = table

        myConn.Close()

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs)
        FilterData(SearchTextBox.Text)
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If SearchTextBox.Text = "" Then
            SearchTextBox.PlaceholderText = "       Search Student's Name or Index Number here"
        End If
        FilterData(SearchTextBox.Text)
    End Sub

    Private Sub StudentsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentsDataGridView.CellContentClick

        If myConn.State = ConnectionState.Open Then
            myConn.Close()

        End If

        myConn.Open()

        selected = Convert.ToString(StudentsDataGridView.SelectedCells.Item(0).Value.ToString())
        MessageBox.Show(selected)

        Dim getstudent As New SqlCommand
        getstudent = myConn.CreateCommand()
        getstudent.CommandType = CommandType.Text
        getstudent.CommandText = "SELECT * FROM Users WHERE ID_Number='" + selected + "'"
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
            YearTextBox.Text = dr.GetString(3).ToString()
            AddressTextBox.Text = dr.GetString(8).ToString()
            FatherTextBox.Text = dr.GetString(4).ToString()
            FatherNumberTextBox.Text = dr.GetString(5).ToString()
            MotherTextBox.Text = dr.GetString(6).ToString()
            MotherPhoneTextBox.Text = dr.GetString(7).ToString()
            EnrolledTextBox.Text = dr.GetString(9).ToString()

            StudentPictureBox.Image = Image.FromStream(pic)
            pic.Close()
        End While

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim result As DialogResult = MessageBox.Show("Do you really want to exit?", " ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            myConn.Close()
            Close()
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class