Public Class Form1

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim opt1, opt2, opt3, opt4 As Boolean

        If (Me.opcion1.Checked) Then
            opt1 = True
        Else
            opt1 = False
        End If
        If (Me.opcion2.Checked) Then
            opt2 = True
        Else
            opt2 = False
        End If
        If (Me.opcion3.Checked) Then
            opt3 = True
        Else
            opt3 = False
        End If
        If (Me.opcion4.Checked) Then
            opt4 = True
        Else
            opt4 = False
        End If

        MsgBox("Las opciones elegidas " + vbLf + "son: ")
        If (opt1) Then
            MsgBox("OPCION 1")
        End If
        If (opt2) Then
            MsgBox("OPCION 2")
        End If
        If (opt3) Then
            MsgBox("OPCION 3")
        End If
        If (opt4) Then
            MsgBox("OPCION 4")
        End If

    End Sub
End Class
