Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PremiereFunc()
        PremierSub(15)
        PremierSub("youpi")
        DeuxiemeSub("yes", 1)
        MegaSub()

    End Sub
    Private Sub PremierSub()

    End Sub
    Private Sub PremierSub(premierInt As Integer)

    End Sub
    Private Sub PremierSub(premierString As String)

    End Sub

    Private Sub DeuxiemeSub(str As String, chiffre As Integer)

    End Sub


    Private Function PremiereFunc() As String
        Dim j As String = "coucou"
        Return j
    End Function

    Private Sub MegaSub(Optional param1 As String = "wow")
    End Sub

    Private Function PremiereFunc(superString As String, Optional estActif As Boolean = False)
        Dim j As String = "coucou"
        Return j
    End Function

End Class
