Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = TextBox1.Text
        If (Label1.Text = "allo") Then
            CheckBox1.Checked = True
            CheckBox1.Enabled = False
            Button1.Enabled = False

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) = True Then
            BoitierNom.Location = New System.Drawing.Point(200, 250)
        Else BoitierNom.Location = New System.Drawing.Point(665, 189)
        End If
    End Sub

    Private Sub BoitierNom_TextChanged(sender As Object, e As EventArgs) Handles BoitierNom.TextChanged

    End Sub


End Class
