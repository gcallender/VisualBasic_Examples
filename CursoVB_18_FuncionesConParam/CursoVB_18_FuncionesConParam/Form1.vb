Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim var As String
        var = "variable sin cambiar"

        'porValor(var)
        porReferencia(var)

        MsgBox(var)

    End Sub

    Private Sub porValor(ByVal variable As String)
        MsgBox(variable)
        variable = "variable cambiada"
        MsgBox(variable)
    End Sub

    Private Sub porReferencia(ByRef variable As String)
        MsgBox(variable)
        variable = "variable cambiada"
        MsgBox(variable)
    End Sub


End Class
