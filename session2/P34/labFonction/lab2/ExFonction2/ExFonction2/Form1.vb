Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Myfunction()
        Button1.Hide()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim value1 As Integer
        Dim value2 As Integer
        Dim EstUnNombre As Boolean = Int32.TryParse(TextBox1.Text, value1) AndAlso Int32.TryParse(TextBox2.Text, value2)


        If EstUnNombre = False Then


            addition(TextBox1.Text, TextBox2.Text)
        Else
            addition(value1, value2)
        End If







    End Sub

    Private Sub Myfunction(chaine As String, Optional boul As Boolean = False)
        If boul = False Then
            Label2.Text = TextBox1.Text
        Else Label3.Text = TextBox1.Text
        End If
    End Sub


    Private Sub Myfunction(Optional boul2 As Boolean = False)

        If boul2 = True Then
            TextBox1.Text = "Enable false"
        End If
    End Sub


    Private Sub addition(chiffre1 As Integer, chiffre2 As Integer)
        Label3.Text = chiffre1 + chiffre2

    End Sub

    Private Sub addition(str1 As String, str2 As String)

        Label2.Text = str1 + str2
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Button1.Show()
        If String.IsNullOrEmpty(TextBox1.Text) And String.IsNullOrEmpty(TextBox2.Text) Then
            Button1.Hide()
        End If
    End Sub
End Class
