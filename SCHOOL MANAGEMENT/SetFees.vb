Imports System.Data.SqlClient
Imports System.IO

Public Class SetFees
    Dim myConn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MOFICT\source\repos\SCHOOL MANAGEMENT\SCHOOL MANAGEMENT\SchoolDatabase.mdf;Integrated Security=True;Connect Timeout=30")

    'this updates the fee value for the selected class
    Private Sub Updater(selectedclass, fee)
        Dim myCommand As New SqlCommand("UPDATE Fees SET Fee='" + fee + "' WHERE Class='" + selectedclass + "'  ", myConn)
        If myCommand.ExecuteNonQuery = 1 Then
            MessageBox.Show("The Fee for " + selectedclass + "has been UPDATED successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AmountTextBox.Text = ""
            ClassComboBox.ResetText()
        Else
            MessageBox.Show("There was a problem updating the fees for " + selectedclass, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'this creates a new class and it's corresponding fee in the database
    Private Sub Creator(selectedclass, fee)
        Dim myCommand As New SqlCommand("INSERT INTO Fees(Class, Fee) VALUES('" + selectedclass + "', '" + fee + "') ", myConn)
        If myCommand.ExecuteNonQuery = 1 Then
            MessageBox.Show("The Fee for " + selectedclass + "has been CREATED successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AmountTextBox.Text = ""
            ClassComboBox.ResetText()
        Else
            MessageBox.Show("There was a problem updating the fees for " + selectedclass, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'this function updates the database with the fees
    Private Sub UpdateFees(selectedclass, fee)
        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If
        myConn.Open()

        'this checks if a fee already exists for the class selected
        Dim myCommand As New SqlCommand("SELECT * FROM Fees WHERE Class='" + ClassComboBox.SelectedItem + "' ", myConn)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(myCommand)
        Dim dt As DataTable = New DataTable()
        adapter.Fill(dt)
        'this determines what function will be called
        'if the class already exists, UPDATE will be called
        'if the class doesn't exist, CREATE will be called

        If (dt.Rows.Count > 0) Then
            Updater(selectedclass, fee)
        Else
            Creator(selectedclass, fee)
        End If
    End Sub


    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ClassComboBox.SelectedItem = "" Then
            MessageBox.Show("Select a class", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf AmountTextBox.Text = "" Then
            MessageBox.Show("Select a class", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            UpdateFees(ClassComboBox.SelectedItem, AmountTextBox.Text)
        End If



    End Sub
End Class