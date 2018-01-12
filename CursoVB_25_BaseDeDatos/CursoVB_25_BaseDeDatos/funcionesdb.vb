Module funcionesdb
    ' Variable de conexion a una base de datos
    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BaseDeDatos01.accdb;Persist Security Info=False")
    ' Variable de comandos a enviar a la base de datos
    Public cmd As New OleDb.OleDbCommand
    ' Variable que almacena la informacion entregada por la base de datos
    Public dr As OleDb.OleDbDataReader
    ' Variable para instrucciones SQL
    Public sql As String = ""

    ' Funcion para conectar a una base de datos
    Public Sub conectar()
        Try
            conn.Open()
            MsgBox("Conexion exitosa")
        Catch ex As Exception
            MsgBox(ex.ToString)
            If ex.ToString.Contains("'Microsoft.ACE.OLEDB.12.0' no está registrado en el equipo local") Then
                'MsgBox("1.- Cerrar visual studio. " + vbCrLf +
                '       "2.- Reinstala el driver: https://www.microsoft.com/es-es/download/details.aspx?id=23734" + vbCrLf + vbCrLf +
                '       "OBS: Si el programa fue desarrollado en una maquina 32 bits o el access es 2007" + vbCrLf +
                '       "1.- Ir a propiedades del proyecto." + vbCrLf +
                '       "2.- Click en la seccion de Compile (o compilacion)." + vbCrLf +
                '       "3.- En donde dice Target CPU, cambiar por x86.")
                msgHelp.ShowDialog()
            End If

        End Try
    End Sub

    ' Funcion para consultar datos a una base de datos
    Public Sub Consultar(ByRef identificacion As String)
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        If (identificacion <> "") Then
            cmd.CommandText = "SELECT Nombre, Apellido, Correo, Direccion FROM Persona WHERE IdPersona=" + identificacion
        Else
            cmd.CommandText = "SELECT Nombre, Apellido, Correo, Direccion FROM Persona"
        End If

        Try
            dr = cmd.ExecuteReader()

            If (dr.HasRows) Then
                While (dr.Read())
                    MsgBox(dr(0).ToString + " " + dr(1).ToString + " " +
                           dr(2).ToString + " " + dr(3).ToString + " ")
                End While
            Else
                MsgBox("No existen registros para la consulta")
            End If

            dr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Public Sub consultarPersona(ByRef identificacion As String)
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT Nombre, Apellido, Correo, Direccion FROM Persona WHERE IdPersona=" + identificacion

        Try
            dr = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


End Module
