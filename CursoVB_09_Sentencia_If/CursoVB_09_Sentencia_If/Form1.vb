Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim num1, num2 As Integer
        num1 = 1
        num2 = 2

        If (num1 < num2) Then
            MsgBox("Numero 1 es menor que Numero 2")
        ElseIf (num1 = num2) Then
            MsgBox("Numero 1 es igual que Numero 2")
        Else
            MsgBox("Numero 1 es mayor que Numero 2")
        End If
    End Sub
End Class
