Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim cadena As String = ""
        'cadena = "Hola Mundo"

        'Dim verifica As Boolean
        'verifica = cadena.Contains("Hola")

        'If (verifica) Then
        '    MsgBox("La cadena contiene la palabra: Hola")
        'Else
        '    MsgBox("La cadena no contiene la palabra: Hola")
        'End If

        Dim comparacion As Integer
        comparacion = StrComp("Texto 1", "Texto 2")
        MsgBox(comparacion.ToString)
        comparacion = StrComp("Texto 1", "Texto 1")
        MsgBox(comparacion.ToString)
        comparacion = StrComp("Texto 3", "Texto 2")
        MsgBox(comparacion.ToString)

    End Sub
End Class
