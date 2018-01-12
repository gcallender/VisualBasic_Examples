Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim opc As String = ""
        Dim n1, n2 As Integer
        Dim resultado As Double

        If rbSuma.Checked Then
            opc = "sumar"
        End If
        If rbResta.Checked Then
            opc = "restar"
        End If
        If rbMultiplicacion.Checked Then
            opc = "multiplicar"
        End If
        If rbDivision.Checked Then
            opc = "dividir"
        End If

        n1 = txtNum1.Text
        n2 = txtNum2.Text

        Select Case opc
            Case "sumar"
                resultado = n1 + n2
            Case "restar"
                resultado = n1 - n2
            Case "multiplicar"
                resultado = n1 * n2
            Case "dividir"
                resultado = n1 / n2
            Case Else
                MsgBox("No ha seleccionado ninguna operacion")
                Exit Sub
        End Select

        MsgBox("El resultado de la operacion es: " + resultado.ToString)

    End Sub
End Class
