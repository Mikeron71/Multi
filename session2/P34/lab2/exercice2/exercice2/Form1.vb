Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged



    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub terminer_Click(sender As Object, e As EventArgs) Handles terminer.Click


        If (TextBox1.Text = TextBox2.Text) Then
            Label1.Text = "succces"
        Else

            Label2.Text = "diff"
        End If

        If (TextBox3.Text <> TextBox1.Text And TextBox3.Text = TextBox2.Text) Then
            Label3.Visible = False
        End If

        If (TextBox3.Text = TextBox1.Text AndAlso TextBox3.Text = TextBox2.Text) Then
            Label3.Enabled = False
        End If

        If (TextBox3.Text <> TextBox1.Text And TextBox3.Text <> TextBox2.Text) Then
            Label3.Text = TextBox1.Text + TextBox2.Text
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Form2.Show()

    End Sub
End Class
