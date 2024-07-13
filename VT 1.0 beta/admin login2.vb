Public Class admin_login2
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BunifuTextBox1_GotFocus(sender As Object, e As EventArgs) Handles BunifuTextBox1.GotFocus
        If BunifuTextBox1.Text = "Username" Then
            BunifuTextBox1.Text = ""
            BunifuTextBox1.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub BunifuTextBox1_LostFocus(sender As Object, e As EventArgs) Handles BunifuTextBox1.LostFocus
        If BunifuTextBox1.Text = "" Then
            BunifuTextBox1.Text = "Username"
            BunifuTextBox1.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub BunifuTextBox2_GotFocus(sender As Object, e As EventArgs) Handles BunifuTextBox2.GotFocus
        If BunifuTextBox2.Text = "Password" Then
            BunifuTextBox2.Text = ""
            BunifuTextBox2.PasswordChar = "•"
            BunifuTextBox2.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub BunifuTextBox2_LostFocus(sender As Object, e As EventArgs) Handles BunifuTextBox2.LostFocus
        If BunifuTextBox2.Text = "" Then
            BunifuTextBox2.Text = "Password"
            BunifuTextBox2.PasswordChar = "•"
            BunifuTextBox2.ForeColor = Color.DarkGray
        End If
    End Sub


    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        If BunifuTextBox1.Text = "admin" And BunifuTextBox2.Text = "pass123" Then
            Result.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Username Or Password")
        End If
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Process.Start("https://www.website.com/forgot-password/?source=SC")


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        BunifuTextBox2.PlaceholderText = Visible
        If CheckBox1.Checked = True Then
            BunifuTextBox2.PasswordChar = ""
        Else
            BunifuTextBox2.PasswordChar = "•"
        End If
    End Sub
End Class