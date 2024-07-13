Imports System.Data.SqlClient


Public Class SignUp
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        BunifuTextBox2.PlaceholderText = Visible
        If CheckBox1.Checked = True Then
            BunifuTextBox2.PasswordChar = ""
        Else
            BunifuTextBox2.PasswordChar = "•"
        End If
    End Sub

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim id = BunifuTextBox1.Text
        Dim passwoord = BunifuTextBox2.Text
        Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-M5GTDGE4\SQLEXPRESS;Initial Catalog=Voting System;Integrated Security=True")
        Dim query As String = "Select*from dbo.register where id=@id and password=@password"
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        Dim reader As SqlDataReader
        con.Open()
        cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = BunifuTextBox1.Text
        cmd.Parameters.Add("password", SqlDbType.VarChar).Value = BunifuTextBox2.Text
        reader = cmd.ExecuteReader()

        If reader.Read() Then
            MessageBox.Show("sucess")
            Me.Hide()
            Form4.Show()
        Else
            MessageBox.Show("invalid")

        End If
    End Sub

End Class