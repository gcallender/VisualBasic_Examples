Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim num1, num2, operacion As Integer
        num1 = 2
        num2 = 5
        operacion = num1 + num2
        MsgBox(operacion.ToString)

        Dim num3, num4, operacion2 As Double
        num3 = 2
        num4 = 5
        operacion2 = num3 Mod num4
        MsgBox(operacion2.ToString)

        num1 += 1
        MsgBox(num1.ToString)

    End Sub
End Class
