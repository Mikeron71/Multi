Public Class Form1

    Public truc As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SonNom As String = "nom"










    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Public Sub LesVariables()

        Static POU As String

    End Sub
    Public tableau As Integer() = New Integer(10) {2, 3, 4, 5, 6, 7, 5, 5, 5, 5, 5}

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Erase tableau
    End Sub

End Class
