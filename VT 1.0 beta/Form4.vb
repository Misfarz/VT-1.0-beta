Imports System.Data.SqlClient
Public Class Form4
    Dim ppspn As New TimeSpan
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user As String = If(String.IsNullOrEmpty(SignUp.BunifuTextBox1.Text), "", SignUp.BunifuTextBox1.Text)
        Label1.Text = user
        Panel2.Visible = False

        BunifuButton4.Visible = False
        BunifuButton8.Visible = False



        If String.Compare(user, "admin", StringComparison.OrdinalIgnoreCase) = 0 Then
            BunifuButton2.Visible = False
            BunifuButton3.Visible = False
            BunifuButton5.Visible = False
            BunifuButton9.Visible = False


            Timer1.Enabled = False

            BunifuButton4.Visible = True
            BunifuButton8.Visible = True

        End If




        Dim time As Integer = 180 ' Set the countdown time in seconds
        Dim timer As New Timer()
        timer.Interval = 1000 ' Set the timer interval to 1 second

        ' Subscribe to the Tick event of the timer with a lambda expression
        AddHandler timer.Tick, Function()
                                   ' Update the remaining time and check if the countdown is complete
                                   If time > 0 Then
                                       time -= 1 ' Decrement the remaining time by 1 second
                                       Label5.Text = $"{time \ 60:00}:{time Mod 60:00}" ' Update the label with the remaining time
                                   Else
                                       timer.Stop() ' Stop the timer if the countdown is complete
                                       MessageBox.Show("Time Out!")
                                       Me.Hide()
                                       ' Show the button if the countdown is complete
                                   End If
                                   Return Nothing ' Return value is required for lambda expressions
                               End Function

        ' Start the timer
        timer.Start()



    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        CandidatesInfo.Show()
        Panel2.Visible = False
    End Sub
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim user As String
        user = SignUp.BunifuTextBox1.Text
        Dim headstudent = ComboBox1.SelectedItem
        Dim sports = ComboBox2.SelectedItem
        Dim arts = ComboBox3.SelectedItem
        Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-M5GTDGE4\SQLEXPRESS;Initial Catalog=Voting System;Integrated Security=True")
        Dim query As String = "insert into [dbo].[vote] Values (@user,@studenthead,@sports,@arts)"
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        con.Open()

        cmd.Parameters.AddWithValue("@user", user)
        cmd.Parameters.AddWithValue("@studenthead", headstudent)
        cmd.Parameters.AddWithValue("@sports", sports)
        cmd.Parameters.AddWithValue("@arts", arts)


        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Thank You For Voting")




        Catch ex As Exception
            MessageBox.Show("error" & ex.Message)
        End Try
    End Sub
    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        winners.Show()
        CandidatesInfo.Hide()
        Panel2.Hide()

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        SignUp.Show()
    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles BunifuButton6.Click
        Me.Close()
        SignUp.Show()
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Panel2.Show()
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Result.Show()
    End Sub

    Private Sub BunifuButton8_Click(sender As Object, e As EventArgs) Handles BunifuButton8.Click
        addCandidates.Show()

    End Sub

    Private Sub BunifuButton9_Click(sender As Object, e As EventArgs) Handles BunifuButton9.Click
        Panel2.Show()
    End Sub

    Private Sub BunifuButton7_Click(sender As Object, e As EventArgs) Handles BunifuButton7.Click
        Me.Close()
        SignUp.Show()
    End Sub
End Class