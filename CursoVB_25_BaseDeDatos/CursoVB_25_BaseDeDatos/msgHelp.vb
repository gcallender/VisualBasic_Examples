Public Class msgHelp

    Private Sub msgHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHelp01.Text = "Para corregir el error siga los siguiente pasos: " + vbCrLf + vbCrLf +
                            "1.- Cerrar visual studio. " + vbCrLf +
                            "2.- Reinstalar el driver: "
        linkTxt01.Text = "https://www.microsoft.com/es-es/download/details.aspx?id=23734"
        lblHelp02.Text = "OBS: Si el programa fue desarrollado en una maquina 32 bits o el access es 2007" + vbCrLf + vbCrLf +
                            "1.- Ir a propiedades del proyecto." + vbCrLf +
                            "2.- Click en la seccion de Compile (o compilacion)." + vbCrLf +
                            "3.- En donde dice Target CPU, cambiar por x86."
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()

    End Sub

    Private Sub linkTxt01_Click(sender As Object, e As EventArgs) Handles linkTxt01.Click
        Try
            VisitLink()
        Catch ex As Exception
            MsgBox("Unable to open link that was clicked.")
        End Try
    End Sub

    Private Sub VisitLink()
        linkTxt01.LinkVisited = True
        Process.Start("https://www.microsoft.com/es-es/download/details.aspx?id=23734")
    End Sub

End Class