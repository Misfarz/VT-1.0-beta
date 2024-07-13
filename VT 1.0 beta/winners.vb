Imports System.Data.SqlClient
Public Class winners


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

        ' Determine the candidate with the highest vote count for each category
        Dim studenthead As String = ""
        Dim sports As String = ""
        Dim arts As String = ""
        If result1 > result2 Then
            studenthead = "James S"
        Else
            studenthead = "John K"
        End If
        If result3 > result4 Then
            sports = "Anamika Roy"
        Else
            sports = "David K"
        End If
        If result5 > result6 Then
            arts = "Nisha US"
        Else
            arts = "Sanuja Sharma"
        End If

        ' Display the candidates with the highest vote count for each category
        Label5.Text = studenthead
        Label6.Text = sports
        Label7.Text = arts
    End Sub

    Private Sub winners_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuButton1.Visible = False

        Dim time As Integer = 10 ' Set the countdown time in seconds
        Dim timer As New Timer()
        timer.Interval = 1000 ' Set the timer interval to 1 second

        ' Subscribe to the Tick event of the timer with a lambda expression
        AddHandler timer.Tick, Function()
                                   ' Update the remaining time and check if the countdown is complete
                                   If time > 0 Then
                                       time -= 1 ' Decrement the remaining time by 1 second
                                       Label10.Text = $"{time \ 60:00}:{time Mod 60:00}" ' Update the label with the remaining time
                                   Else
                                       timer.Stop() ' Stop the timer if the countdown is complete
                                       MessageBox.Show("Election Ended!")
                                       BunifuButton1.Visible = True ' Show the button if the countdown is complete

                                   End If
                                   Return Nothing ' Return value is required for lambda expressions
                               End Function

        ' Start the timer
        timer.Start()


    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Me.Hide()
    End Sub


End Class