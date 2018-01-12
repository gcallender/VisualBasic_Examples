Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Conexion a la base de datos
        conectar()
        ' Llenado de la tabla (DataGrid) con los datos de la BD
        fillInGrid()
        ' Actualizar ComboBox con los valores de identificacion presentes en la BD
        fillInComboBox()
    End Sub

    ' Funcion para llenar un DataGrid con la informacion de la base de datos
    Private Sub fillInGrid()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strSQL As String = "SELECT IdPersona, Nombre, Apellido, Correo, Direccion FROM Persona"
        Dim adp As New OleDb.OleDbDataAdapter(strSQL, conn)

        ds.Tables.Add("Tabla")
        adp.Fill(ds.Tables("Tabla"))

        Me.DataGridView1.DataSource = ds.Tables("Tabla")

        Me.DataGridView1.Columns(0).HeaderText = "Identificacion"

    End Sub

    Public Sub fillInComboBox()
        Me.cmbIdentificacion2.Items.Clear()

        sql = "SELECT IdPersona FROM Persona"
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = sql

        dr = cmd.ExecuteReader

        If (dr.HasRows) Then
            While (dr.Read())
                Me.cmbIdentificacion2.Items.Add(dr.GetValue(0))
            End While
        End If

        dr.Close()

    End Sub

    ' Boton para buscar datos en la BD
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim id As String

        id = txtSearch.Text
        Consultar(id)

    End Sub

    ' Boton para insertar datos en la BD
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If (Me.txtIdentificacion.Text = "") Then
            MsgBox("El campo identificacion no puede estar vacio", MsgBoxStyle.Critical, "Atención")
            Me.txtIdentificacion.Select()
        Else
            Dim identificacion As Integer
            Dim nombres As String = ""
            Dim apellidos As String = ""
            Dim correo As String = ""
            Dim direccion As String = ""

            identificacion = Me.txtIdentificacion.Text
            nombres = Me.txtNombres.Text
            apellidos = Me.txtApellidos.Text
            correo = Me.txtCorreo.Text
            direccion = Me.txtDireccion.Text

            cmd.CommandType = CommandType.Text
            cmd.Connection = conn

            sql = "INSERT INTO Persona (IdPersona, Nombre, Apellido, Correo, Direccion) "
            sql += "VALUES (" & identificacion & ",'" & nombres & "', '" & apellidos & "', '" & correo & "', '" & direccion & "')"

            'MsgBox(sql)
            cmd.CommandText = sql

            Try
                ' Ejecucion del comando "cmd.CommandText = sql"
                cmd.ExecuteNonQuery()
                MsgBox("Registro insertado correctamente")
            Catch ex As Exception
                If (ex.ToString.Contains("valores duplicados")) Then
                    MsgBox("El registro ya existe en la base de datos")
                Else
                    MsgBox(ex.ToString)
                End If
            End Try

        End If
    End Sub

    ' Boton para actualizar la visualizacion de datos en el DataGrid
    Private Sub btnUpdateDB_Click(sender As Object, e As EventArgs) Handles btnUpdateDB.Click
        fillInGrid()
    End Sub

    ' Boton para actualizar los datos de la BD
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If (Me.txtIdentificacion1.Text = "") Then
            MsgBox("El campo identificacion no puede estar vacio", MsgBoxStyle.Critical, "Atención")
            Me.txtIdentificacion1.Select()
        Else
            Dim identificacion As Integer
            Dim nombres As String = ""
            Dim apellidos As String = ""
            Dim correo As String = ""
            Dim direccion As String = ""

            identificacion = Me.txtIdentificacion1.Text
            nombres = Me.txtNombres1.Text
            apellidos = Me.txtApellidos1.Text
            correo = Me.txtCorreo1.Text
            direccion = Me.txtDireccion1.Text

            cmd.CommandType = CommandType.Text
            cmd.Connection = conn

            sql = "UPDATE Persona SET "
            sql += "Nombre = '" & nombres & "', "
            sql += "Apellido = '" & apellidos & "', "
            sql += "Correo = '" & correo & "', "
            sql += "Direccion = '" & direccion & "' "
            sql += "WHERE IdPersona = " & identificacion & " "

            'MsgBox(sql)
            cmd.CommandText = sql

            Try
                ' Ejecucion del comando "cmd.CommandText = sql"
                cmd.ExecuteNonQuery()
                Me.txtIdentificacion1.Text = ""
                Me.txtNombres1.Text = ""
                Me.txtApellidos1.Text = ""
                Me.txtCorreo1.Text = ""
                Me.txtDireccion1.Text = ""
                MsgBox("Registro actualizado correctamente")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub

    ' Boton para eliminar datos de la BD
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim identificacion As Integer

        identificacion = Me.txtIdentificacion2.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "DELETE FROM Persona WHERE IdPersona = " & identificacion & " "

        'MsgBox(sql)
        cmd.CommandText = sql

        Try
            ' Ejecucion del comando "cmd.CommandText = sql"
            cmd.ExecuteNonQuery()

            Me.txtIdentificacion2.Text = ""
            Me.txtNombres2.Text = ""
            Me.txtApellidos2.Text = ""
            Me.txtCorreo2.Text = ""
            Me.txtDireccion2.Text = ""

            Me.cmbIdentificacion2.Text = ""
            fillInComboBox()
            Me.txtIdentificacion2.Enabled = True

            MsgBox("Registro eliminado correctamente")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    ' Evento que sucede cuando se deja el campo de texto (i.e. con Tab)
    Private Sub txtIdentificacion1_Leave(sender As Object, e As EventArgs) Handles txtIdentificacion1.Leave
        If (Me.txtIdentificacion1.Text <> "") Then
            consultarPersona(Me.txtIdentificacion1.Text)

            If (dr.Read) Then
                Me.txtNombres1.Text = dr(0).ToString
                Me.txtApellidos1.Text = dr(1).ToString
                Me.txtCorreo1.Text = dr(2).ToString
                Me.txtDireccion1.Text = dr(3).ToString
                ' Habilitar boton actualizar
                Me.btnActualizar.Enabled = True
            Else
                Me.txtIdentificacion1.Text = ""
                Me.txtNombres1.Text = ""
                Me.txtApellidos1.Text = ""
                Me.txtCorreo1.Text = ""
                Me.txtDireccion1.Text = ""
                MsgBox("No se encontró el registro en la base de datos")
                Me.btnActualizar.Enabled = False
            End If

        Else
            Me.btnActualizar.Enabled = False
        End If

        ' No olvidar cerrar el "dataReader"
        dr.Close()

    End Sub

    ' Evento que sucede cuando se deja el TextBox (i.e. con Tab)
    Private Sub txtIdentificacion2_Leave(sender As Object, e As EventArgs) Handles txtIdentificacion2.Leave
        If (Me.txtIdentificacion2.Text <> "") Then
            consultarPersona(Me.txtIdentificacion2.Text)

            If (dr.Read) Then
                Me.txtNombres2.Text = dr(0).ToString
                Me.txtApellidos2.Text = dr(1).ToString
                Me.txtCorreo2.Text = dr(2).ToString
                Me.txtDireccion2.Text = dr(3).ToString
                ' Habilitar boton actualizar
                Me.btnEliminar.Enabled = True
            Else
                Me.txtIdentificacion2.Text = ""
                Me.txtNombres2.Text = ""
                Me.txtApellidos2.Text = ""
                Me.txtCorreo2.Text = ""
                Me.txtDireccion2.Text = ""
                MsgBox("No se encontró el registro en la base de datos")
                Me.btnEliminar.Enabled = False
            End If

        Else
            Me.btnEliminar.Enabled = False
        End If

        ' No olvidar cerrar el "dataReader"
        dr.Close()
    End Sub

    ' Evento (Metodo) que ocurre cuando se elige un valor en el ComboBox
    Private Sub cmbIdentificacion2_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbIdentificacion2.SelectedValueChanged
        Me.txtIdentificacion2.Text = Me.cmbIdentificacion2.SelectedItem.ToString
        Me.txtIdentificacion2.Enabled = False

        If (Me.cmbIdentificacion2.SelectedItem.ToString <> "") Then
            consultarPersona(Me.cmbIdentificacion2.SelectedItem.ToString)

            If (dr.Read) Then
                Me.txtNombres2.Text = dr(0).ToString
                Me.txtApellidos2.Text = dr(1).ToString
                Me.txtCorreo2.Text = dr(2).ToString
                Me.txtDireccion2.Text = dr(3).ToString
                ' Habilitar boton actualizar
                Me.btnEliminar.Enabled = True
            Else
                Me.txtIdentificacion2.Text = ""
                Me.txtNombres2.Text = ""
                Me.txtApellidos2.Text = ""
                Me.txtCorreo2.Text = ""
                Me.txtDireccion2.Text = ""
                MsgBox("No se encontró el registro en la base de datos")
                Me.btnEliminar.Enabled = False
            End If

        Else
            Me.btnEliminar.Enabled = False
        End If

        ' No olvidar cerrar el "dataReader"
        dr.Close()

    End Sub
End Class
