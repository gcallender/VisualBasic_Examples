Public Class Form1
    Dim num1, num2 As Integer
    Dim resultado As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnMayor.Text = "Mayor que"
        btnMenor.Text = "Menor que"
        btnIgual.Text = "Igual que"
        btnMayorIgual.Text = "Mayor o igual que"
        btnMenorIgual.Text = "Menor o igual que"
        btnDiferente.Text = "Diferente que"

        'Dim resultado As Boolean
        'resultado = 1 = 1
        'resultado = 1 > 2
        'resultado = 1 <= 2
        'resultado = 1 <> 1
        'resultado = "Hola" <> "Chao"
        'MsgBox(resultado)
    End Sub

    Private Sub btnMayor_Click(sender As Object, e As EventArgs) Handles btnMayor.Click
        num1 = txtVar1.Text
        num2 = txtVar2.Text
        resultado = num1 > num2
        MsgBox("Resultado = " + resultado.ToString)
    End Sub

    Private Sub btnMenor_Click(sender As Object, e As EventArgs) Handles btnMenor.Click
        num1 = txtVar1.Text
        num2 = txtVar2.Text
        resultado = num1 < num2
        MsgBox("Resultado = " + resultado.ToString)
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        num1 = txtVar1.Text
        num2 = txtVar2.Text
        resultado = num1 = num2
        MsgBox("Resultado = " + resultado.ToString)
    End Sub

    Private Sub btnMayorIgual_Click(sender As Object, e As EventArgs) Handles btnMayorIgual.Click
        num1 = txtVar1.Text
        num2 = txtVar2.Text
        resultado = num1 >= num2
        MsgBox("Resultado = " + resultado.ToString)
    End Sub

    Private Sub btnMenorIgual_Click(sender As Object, e As EventArgs) Handles btnMenorIgual.Click
        num1 = txtVar1.Text
        num2 = txtVar2.Text
        resultado = num1 <= num2
        MsgBox("Resultado = " + resultado.ToString)
    End Sub

    Private Sub btnDiferente_Click(sender As Object, e As EventArgs) Handles btnDiferente.Click
        num1 = txtVar1.Text
        num2 = txtVar2.Text
        resultado = num1 <> num2
        MsgBox("Resultado = " + resultado.ToString)
    End Sub
End Class
