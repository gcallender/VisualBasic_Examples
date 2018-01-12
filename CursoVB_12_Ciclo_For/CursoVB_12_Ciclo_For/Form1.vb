Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i, j As Integer

        For i = 0 To 2
            MsgBox("Ciclo externo i = " + i.ToString)
            For j = 0 To 2
                MsgBox("Ciclo externo j = " + j.ToString)
            Next
        Next
    End Sub
End Class
