Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arreglo(3) As String
        arreglo(0) = "Hola"
        arreglo(1) = "Hola2"
        arreglo(2) = "Hola3"
        MsgBox(arreglo(0) + " " + arreglo(1) + " " + arreglo(2))

        Dim arreglo2() As Integer
        arreglo2 = New Integer() {1, 2, 3}
        MsgBox(arreglo2(0).ToString + arreglo2(1).ToString + arreglo2(2).ToString)

        ReDim Preserve arreglo2(2)
        MsgBox(arreglo2(0).ToString + arreglo2(1).ToString)
        ReDim arreglo2(3)
        MsgBox(arreglo2(0).ToString + arreglo2(1).ToString + arreglo2(2).ToString)

        Dim matriz(,) As Integer = {{1, 2, 3}, {4, 5, 6}}
        MsgBox(matriz(1, 1).ToString)

    End Sub
End Class
