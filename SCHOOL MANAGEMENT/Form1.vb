'sql connection
Imports System.Data.SqlClient
Imports System.Data

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        Dim myConn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MOFICT\source\repos\SCHOOL MANAGEMENT\SCHOOL MANAGEMENT\SchoolDatabase.mdf;Integrated Security=True;Connect Timeout=30")
        Try
            myConn.Open()
            LoginForm.Show()
            Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to the database servers at the moment.", "Cannot reach database", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SplashTimer.Enabled = False
            SplashTimer.Stop()
        End Try
    End Sub
End Class
