Public Class Form1

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        MsgBox("Hola", MsgBoxStyle.Exclamation, "Saludo")
    End Sub

    Private Sub btn_suma_Click(sender As Object, e As EventArgs) Handles btn_suma.Click
        Dim num1, num2, suma As Integer
        num1 = txtNum1.Text
        num2 = txtNum2.Text
        suma = num1 + num2
        MsgBox("Resultado = " + suma.ToString, , "Resultado")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
