Imports System.Data
Imports System.Data.SqlClient
Public Class Form2
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        SignUp.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-M5GTDGE4\SQLEXPRESS;Initial Catalog=Voting System;Integrated Security=True")
        Dim query As String = "INSERT INTO [dbo].[register] VALUES (@Id,@password)"
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        Dim UserId As String = BunifuTextBox1.Text
        Dim Password As String = BunifuTextBox2.Text
        con.Open()



        If BunifuTextBox1.Text = Nothing Or BunifuTextBox2.Text = Nothing Then
            MessageBox.Show("Enter User Id and Password")
        Else
            cmd.Parameters.AddWithValue("@Id", UserId)
            cmd.Parameters.AddWithValue("@Password", Password)
        End If
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Registration Success")

        Catch ex As Exception
            MessageBox.Show("Id already exists")
            con.Close()
        End Try

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class