Imports System.Data.SqlClient
Public Class addCandidates
    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Me.Hide()
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-M5GTDGE4\SQLEXPRESS;Initial Catalog=Voting System;Integrated Security=True")
        Dim query As String = "insert into [dbo].[addcandidate] Values (@name,@rollno,@position)"
        Dim cmd As SqlCommand = New SqlCommand(query, con)

        Dim NAME As String = BunifuTextBox1.Text
        Dim ROLLNO As String = BunifuTextBox2.Text
        Dim POSITION As String = BunifuTextBox3.Text

        If NAME = "" Or ROLLNO = "" Or POSITION = "" Then
            MessageBox.Show("Please fill in all fields.")
        Else
            cmd.Parameters.AddWithValue("@name", NAME)
            cmd.Parameters.AddWithValue("@rollno", ROLLNO)
            cmd.Parameters.AddWithValue("@position", POSITION)

            Try
                con.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Candidate Added Successfully")
            Catch ex As SqlException
                MessageBox.Show("Candidate Already Exists")
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        BunifuTextBox1.Text = ""
        BunifuTextBox2.Text = ""
        BunifuTextBox3.Text = ""
    End Sub
End Class