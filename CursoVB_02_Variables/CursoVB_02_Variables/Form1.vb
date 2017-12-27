Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim entero As Integer = 1
        MsgBox(entero)
        'entero = 2
        'MsgBox(entero)
        Dim numero As Double = 123.456
        MsgBox(numero)
        Dim texto As String = "Hola Mundo"
        MsgBox(texto)
        Dim texto2 As String = " etc"
        MsgBox(texto + texto2)
        Dim fecha As Date = "01-01-12"
        MsgBox(fecha)
        Dim fecha2 As Date = "01-Jan-2012"
        MsgBox(fecha2)
    End Sub
End Class
