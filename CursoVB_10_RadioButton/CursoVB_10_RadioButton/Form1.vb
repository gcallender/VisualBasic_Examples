Public Class Form1

    Private Sub bOperacion_Click(sender As Object, e As EventArgs) Handles bOperacion.Click
        Dim n1, n2 As Integer
        Dim resultado As Double

        n1 = num1.Text
        n2 = num2.Text

        If (rbSuma.Checked) Then
            resultado = n1 + n2
        ElseIf (rbResta.Checked) Then
            resultado = n1 - n2
        ElseIf (rbMultiplicacion.Checked) Then
            resultado = n1 * n2
        Else
            resultado = n1 / n2
        End If

        MsgBox("El resultado de la operacion es: " + resultado.ToString)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbSuma.Checked = True
    End Sub
End Class
