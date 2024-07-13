Imports System.Data.SqlClient

Public Class Result
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click


        Dim con As New SqlConnection("Data Source=LAPTOP-M5GTDGE4\SQLEXPRESS;Initial Catalog=Voting System;Integrated Security=True")

        ' Query for counting the votes for each candidate
        Dim query As String = "SELECT COUNT(*) FROM [Voting System].[dbo].[vote] WHERE studenthead=@candidate OR sports=@candidate OR arts=@candidate"

        ' SqlCommand object for the first candidate
        Dim cmd1 As New SqlCommand(query, con)
        cmd1.Parameters.AddWithValue("@candidate", "James S")
        con.Open()
        Dim result1 As Integer = cmd1.ExecuteScalar()
        con.Close()

        ' SqlCommand object for the second candidate
        Dim cmd2 As New SqlCommand(query, con)
        cmd2.Parameters.AddWithValue("@candidate", "John K")
        con.Open()
        Dim result2 As Integer = cmd2.ExecuteScalar()
        con.Close()

        ' SqlCommand object for the third candidate
        Dim cmd3 As New SqlCommand(query, con)
        cmd3.Parameters.AddWithValue("@candidate", "Anamika Roy")
        con.Open()
        Dim result3 As Integer = cmd3.ExecuteScalar()
        con.Close()

        ' SqlCommand object for the fourth candidate
        Dim cmd4 As New SqlCommand(query, con)
        cmd4.Parameters.AddWithValue("@candidate", "David K")
        con.Open()
        Dim result4 As Integer = cmd4.ExecuteScalar()
        con.Close()

        ' SqlCommand object for the fifth candidate
        Dim cmd5 As New SqlCommand(query, con)
        cmd5.Parameters.AddWithValue("@candidate", "Nisha US")
        con.Open()
        Dim result5 As Integer = cmd5.ExecuteScalar()
        con.Close()

        ' SqlCommand object for the sixth candidate
        Dim cmd6 As New SqlCommand(query, con)
        cmd6.Parameters.AddWithValue("@candidate", "Sanuja Sharma")
        con.Open()
        Dim result6 As Integer = cmd6.ExecuteScalar()
        con.Close()


        BunifuTextBox1.Text = result1.ToString()
        BunifuTextBox2.Text = result2.ToString()
        BunifuTextBox3.Text = result3.ToString()
        BunifuTextBox4.Text = result4.ToString()
        BunifuTextBox5.Text = result5.ToString()
        BunifuTextBox6.Text = result6.ToString()

    End Sub



End Class