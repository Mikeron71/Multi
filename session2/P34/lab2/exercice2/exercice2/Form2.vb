Public Class Form2
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub






    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 5
            Dim chiffreRandom As New Random




            Button1.BackColor = Color.FromArgb(255, chiffreRandom.Next(255), chiffreRandom.Next(255), chiffreRandom.Next(255))
            Button2.BackColor = Color.FromArgb(255, chiffreRandom.Next(255), chiffreRandom.Next(255), chiffreRandom.Next(255))
            Button3.BackColor = Color.FromArgb(255, chiffreRandom.Next(255), chiffreRandom.Next(255), chiffreRandom.Next(255))
            Button4.BackColor = Color.FromArgb(255, chiffreRandom.Next(255), chiffreRandom.Next(255), chiffreRandom.Next(255))
            Button5.BackColor = Color.FromArgb(255, chiffreRandom.Next(255), chiffreRandom.Next(255), chiffreRandom.Next(255))

        Next



    End Sub
End Class