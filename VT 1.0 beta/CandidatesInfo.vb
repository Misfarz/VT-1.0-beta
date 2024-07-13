Public Class CandidatesInfo

    Private Sub CandidatesInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Voting_SystemDataSet.addcandidate' table. You can move, or remove it, as needed.
        Me.AddcandidateTableAdapter.Fill(Me.Voting_SystemDataSet.addcandidate)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Me.Hide()
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Form4.Panel2.Show()
        Me.Hide()

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class