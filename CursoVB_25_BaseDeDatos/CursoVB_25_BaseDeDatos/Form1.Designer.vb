<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tbcPrincipal = New System.Windows.Forms.TabControl()
        Me.tabInsertar = New System.Windows.Forms.TabPage()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblIdentificacion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.tabActualizar = New System.Windows.Forms.TabPage()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.lblDireccion1 = New System.Windows.Forms.Label()
        Me.lblCorreo1 = New System.Windows.Forms.Label()
        Me.lblApellidos1 = New System.Windows.Forms.Label()
        Me.lblNombres1 = New System.Windows.Forms.Label()
        Me.lblIdentificacion1 = New System.Windows.Forms.Label()
        Me.txtDireccion1 = New System.Windows.Forms.TextBox()
        Me.txtCorreo1 = New System.Windows.Forms.TextBox()
        Me.txtApellidos1 = New System.Windows.Forms.TextBox()
        Me.txtNombres1 = New System.Windows.Forms.TextBox()
        Me.txtIdentificacion1 = New System.Windows.Forms.TextBox()
        Me.tabEliminar = New System.Windows.Forms.TabPage()
        Me.lblDireccion2 = New System.Windows.Forms.Label()
        Me.lblCorreo2 = New System.Windows.Forms.Label()
        Me.lblApellidos2 = New System.Windows.Forms.Label()
        Me.lblNombres2 = New System.Windows.Forms.Label()
        Me.txtDireccion2 = New System.Windows.Forms.TextBox()
        Me.txtCorreo2 = New System.Windows.Forms.TextBox()
        Me.txtApellidos2 = New System.Windows.Forms.TextBox()
        Me.txtNombres2 = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lblIdentificacion2 = New System.Windows.Forms.Label()
        Me.txtIdentificacion2 = New System.Windows.Forms.TextBox()
        Me.btnUpdateDB = New System.Windows.Forms.Button()
        Me.cmbIdentificacion2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcPrincipal.SuspendLayout()
        Me.tabInsertar.SuspendLayout()
        Me.tabActualizar.SuspendLayout()
        Me.tabEliminar.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(319, 25)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(131, 20)
        Me.txtSearch.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(472, 23)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Buscar"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(319, 101)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(370, 212)
        Me.DataGridView1.TabIndex = 2
        '
        'tbcPrincipal
        '
        Me.tbcPrincipal.Controls.Add(Me.tabInsertar)
        Me.tbcPrincipal.Controls.Add(Me.tabActualizar)
        Me.tbcPrincipal.Controls.Add(Me.tabEliminar)
        Me.tbcPrincipal.Location = New System.Drawing.Point(2, 3)
        Me.tbcPrincipal.Name = "tbcPrincipal"
        Me.tbcPrincipal.SelectedIndex = 0
        Me.tbcPrincipal.Size = New System.Drawing.Size(286, 312)
        Me.tbcPrincipal.TabIndex = 3
        '
        'tabInsertar
        '
        Me.tabInsertar.Controls.Add(Me.btnInsertar)
        Me.tabInsertar.Controls.Add(Me.lblDireccion)
        Me.tabInsertar.Controls.Add(Me.lblCorreo)
        Me.tabInsertar.Controls.Add(Me.lblApellidos)
        Me.tabInsertar.Controls.Add(Me.lblNombres)
        Me.tabInsertar.Controls.Add(Me.lblIdentificacion)
        Me.tabInsertar.Controls.Add(Me.txtDireccion)
        Me.tabInsertar.Controls.Add(Me.txtCorreo)
        Me.tabInsertar.Controls.Add(Me.txtApellidos)
        Me.tabInsertar.Controls.Add(Me.txtNombres)
        Me.tabInsertar.Controls.Add(Me.txtIdentificacion)
        Me.tabInsertar.Location = New System.Drawing.Point(4, 22)
        Me.tabInsertar.Name = "tabInsertar"
        Me.tabInsertar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInsertar.Size = New System.Drawing.Size(278, 286)
        Me.tabInsertar.TabIndex = 0
        Me.tabInsertar.Text = "Insertar"
        Me.tabInsertar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(159, 253)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(101, 23)
        Me.btnInsertar.TabIndex = 10
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(7, 204)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 9
        Me.lblDireccion.Text = "Direccion"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(7, 156)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(38, 13)
        Me.lblCorreo.TabIndex = 8
        Me.lblCorreo.Text = "Correo"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Location = New System.Drawing.Point(7, 110)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(49, 13)
        Me.lblApellidos.TabIndex = 7
        Me.lblApellidos.Text = "Apellidos"
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Location = New System.Drawing.Point(7, 61)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(49, 13)
        Me.lblNombres.TabIndex = 6
        Me.lblNombres.Text = "Nombres"
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.AutoSize = True
        Me.lblIdentificacion.Location = New System.Drawing.Point(7, 13)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(70, 13)
        Me.lblIdentificacion.TabIndex = 5
        Me.lblIdentificacion.Text = "Identificacion"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(7, 221)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(265, 20)
        Me.txtDireccion.TabIndex = 4
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(7, 174)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(265, 20)
        Me.txtCorreo.TabIndex = 3
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(7, 127)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(265, 20)
        Me.txtApellidos.TabIndex = 2
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(7, 80)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(265, 20)
        Me.txtNombres.TabIndex = 1
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(7, 32)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(100, 20)
        Me.txtIdentificacion.TabIndex = 0
        '
        'tabActualizar
        '
        Me.tabActualizar.Controls.Add(Me.btnActualizar)
        Me.tabActualizar.Controls.Add(Me.lblDireccion1)
        Me.tabActualizar.Controls.Add(Me.lblCorreo1)
        Me.tabActualizar.Controls.Add(Me.lblApellidos1)
        Me.tabActualizar.Controls.Add(Me.lblNombres1)
        Me.tabActualizar.Controls.Add(Me.lblIdentificacion1)
        Me.tabActualizar.Controls.Add(Me.txtDireccion1)
        Me.tabActualizar.Controls.Add(Me.txtCorreo1)
        Me.tabActualizar.Controls.Add(Me.txtApellidos1)
        Me.tabActualizar.Controls.Add(Me.txtNombres1)
        Me.tabActualizar.Controls.Add(Me.txtIdentificacion1)
        Me.tabActualizar.Location = New System.Drawing.Point(4, 22)
        Me.tabActualizar.Name = "tabActualizar"
        Me.tabActualizar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabActualizar.Size = New System.Drawing.Size(278, 286)
        Me.tabActualizar.TabIndex = 1
        Me.tabActualizar.Text = "Actualizar"
        Me.tabActualizar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Enabled = False
        Me.btnActualizar.Location = New System.Drawing.Point(159, 253)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(101, 23)
        Me.btnActualizar.TabIndex = 21
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'lblDireccion1
        '
        Me.lblDireccion1.AutoSize = True
        Me.lblDireccion1.Location = New System.Drawing.Point(7, 204)
        Me.lblDireccion1.Name = "lblDireccion1"
        Me.lblDireccion1.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion1.TabIndex = 20
        Me.lblDireccion1.Text = "Direccion"
        '
        'lblCorreo1
        '
        Me.lblCorreo1.AutoSize = True
        Me.lblCorreo1.Location = New System.Drawing.Point(7, 156)
        Me.lblCorreo1.Name = "lblCorreo1"
        Me.lblCorreo1.Size = New System.Drawing.Size(38, 13)
        Me.lblCorreo1.TabIndex = 19
        Me.lblCorreo1.Text = "Correo"
        '
        'lblApellidos1
        '
        Me.lblApellidos1.AutoSize = True
        Me.lblApellidos1.Location = New System.Drawing.Point(7, 110)
        Me.lblApellidos1.Name = "lblApellidos1"
        Me.lblApellidos1.Size = New System.Drawing.Size(49, 13)
        Me.lblApellidos1.TabIndex = 18
        Me.lblApellidos1.Text = "Apellidos"
        '
        'lblNombres1
        '
        Me.lblNombres1.AutoSize = True
        Me.lblNombres1.Location = New System.Drawing.Point(7, 61)
        Me.lblNombres1.Name = "lblNombres1"
        Me.lblNombres1.Size = New System.Drawing.Size(49, 13)
        Me.lblNombres1.TabIndex = 17
        Me.lblNombres1.Text = "Nombres"
        '
        'lblIdentificacion1
        '
        Me.lblIdentificacion1.AutoSize = True
        Me.lblIdentificacion1.Location = New System.Drawing.Point(7, 13)
        Me.lblIdentificacion1.Name = "lblIdentificacion1"
        Me.lblIdentificacion1.Size = New System.Drawing.Size(70, 13)
        Me.lblIdentificacion1.TabIndex = 16
        Me.lblIdentificacion1.Text = "Identificacion"
        '
        'txtDireccion1
        '
        Me.txtDireccion1.Location = New System.Drawing.Point(7, 221)
        Me.txtDireccion1.Name = "txtDireccion1"
        Me.txtDireccion1.Size = New System.Drawing.Size(265, 20)
        Me.txtDireccion1.TabIndex = 15
        '
        'txtCorreo1
        '
        Me.txtCorreo1.Location = New System.Drawing.Point(7, 174)
        Me.txtCorreo1.Name = "txtCorreo1"
        Me.txtCorreo1.Size = New System.Drawing.Size(265, 20)
        Me.txtCorreo1.TabIndex = 14
        '
        'txtApellidos1
        '
        Me.txtApellidos1.Location = New System.Drawing.Point(7, 127)
        Me.txtApellidos1.Name = "txtApellidos1"
        Me.txtApellidos1.Size = New System.Drawing.Size(265, 20)
        Me.txtApellidos1.TabIndex = 13
        '
        'txtNombres1
        '
        Me.txtNombres1.Location = New System.Drawing.Point(7, 80)
        Me.txtNombres1.Name = "txtNombres1"
        Me.txtNombres1.Size = New System.Drawing.Size(265, 20)
        Me.txtNombres1.TabIndex = 12
        '
        'txtIdentificacion1
        '
        Me.txtIdentificacion1.Location = New System.Drawing.Point(7, 32)
        Me.txtIdentificacion1.Name = "txtIdentificacion1"
        Me.txtIdentificacion1.Size = New System.Drawing.Size(100, 20)
        Me.txtIdentificacion1.TabIndex = 11
        '
        'tabEliminar
        '
        Me.tabEliminar.Controls.Add(Me.Label1)
        Me.tabEliminar.Controls.Add(Me.cmbIdentificacion2)
        Me.tabEliminar.Controls.Add(Me.lblDireccion2)
        Me.tabEliminar.Controls.Add(Me.lblCorreo2)
        Me.tabEliminar.Controls.Add(Me.lblApellidos2)
        Me.tabEliminar.Controls.Add(Me.lblNombres2)
        Me.tabEliminar.Controls.Add(Me.txtDireccion2)
        Me.tabEliminar.Controls.Add(Me.txtCorreo2)
        Me.tabEliminar.Controls.Add(Me.txtApellidos2)
        Me.tabEliminar.Controls.Add(Me.txtNombres2)
        Me.tabEliminar.Controls.Add(Me.btnEliminar)
        Me.tabEliminar.Controls.Add(Me.lblIdentificacion2)
        Me.tabEliminar.Controls.Add(Me.txtIdentificacion2)
        Me.tabEliminar.Location = New System.Drawing.Point(4, 22)
        Me.tabEliminar.Name = "tabEliminar"
        Me.tabEliminar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEliminar.Size = New System.Drawing.Size(278, 286)
        Me.tabEliminar.TabIndex = 2
        Me.tabEliminar.Text = "Eliminar"
        Me.tabEliminar.UseVisualStyleBackColor = True
        '
        'lblDireccion2
        '
        Me.lblDireccion2.AutoSize = True
        Me.lblDireccion2.Location = New System.Drawing.Point(7, 204)
        Me.lblDireccion2.Name = "lblDireccion2"
        Me.lblDireccion2.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion2.TabIndex = 30
        Me.lblDireccion2.Text = "Direccion"
        '
        'lblCorreo2
        '
        Me.lblCorreo2.AutoSize = True
        Me.lblCorreo2.Location = New System.Drawing.Point(7, 156)
        Me.lblCorreo2.Name = "lblCorreo2"
        Me.lblCorreo2.Size = New System.Drawing.Size(38, 13)
        Me.lblCorreo2.TabIndex = 29
        Me.lblCorreo2.Text = "Correo"
        '
        'lblApellidos2
        '
        Me.lblApellidos2.AutoSize = True
        Me.lblApellidos2.Location = New System.Drawing.Point(7, 110)
        Me.lblApellidos2.Name = "lblApellidos2"
        Me.lblApellidos2.Size = New System.Drawing.Size(49, 13)
        Me.lblApellidos2.TabIndex = 28
        Me.lblApellidos2.Text = "Apellidos"
        '
        'lblNombres2
        '
        Me.lblNombres2.AutoSize = True
        Me.lblNombres2.Location = New System.Drawing.Point(7, 61)
        Me.lblNombres2.Name = "lblNombres2"
        Me.lblNombres2.Size = New System.Drawing.Size(49, 13)
        Me.lblNombres2.TabIndex = 27
        Me.lblNombres2.Text = "Nombres"
        '
        'txtDireccion2
        '
        Me.txtDireccion2.Enabled = False
        Me.txtDireccion2.Location = New System.Drawing.Point(7, 221)
        Me.txtDireccion2.Name = "txtDireccion2"
        Me.txtDireccion2.Size = New System.Drawing.Size(265, 20)
        Me.txtDireccion2.TabIndex = 26
        '
        'txtCorreo2
        '
        Me.txtCorreo2.Enabled = False
        Me.txtCorreo2.Location = New System.Drawing.Point(7, 174)
        Me.txtCorreo2.Name = "txtCorreo2"
        Me.txtCorreo2.Size = New System.Drawing.Size(265, 20)
        Me.txtCorreo2.TabIndex = 25
        '
        'txtApellidos2
        '
        Me.txtApellidos2.Enabled = False
        Me.txtApellidos2.Location = New System.Drawing.Point(7, 127)
        Me.txtApellidos2.Name = "txtApellidos2"
        Me.txtApellidos2.Size = New System.Drawing.Size(265, 20)
        Me.txtApellidos2.TabIndex = 24
        '
        'txtNombres2
        '
        Me.txtNombres2.Enabled = False
        Me.txtNombres2.Location = New System.Drawing.Point(7, 80)
        Me.txtNombres2.Name = "txtNombres2"
        Me.txtNombres2.Size = New System.Drawing.Size(265, 20)
        Me.txtNombres2.TabIndex = 23
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(160, 253)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(101, 23)
        Me.btnEliminar.TabIndex = 22
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'lblIdentificacion2
        '
        Me.lblIdentificacion2.AutoSize = True
        Me.lblIdentificacion2.Location = New System.Drawing.Point(7, 13)
        Me.lblIdentificacion2.Name = "lblIdentificacion2"
        Me.lblIdentificacion2.Size = New System.Drawing.Size(70, 13)
        Me.lblIdentificacion2.TabIndex = 18
        Me.lblIdentificacion2.Text = "Identificacion"
        '
        'txtIdentificacion2
        '
        Me.txtIdentificacion2.Location = New System.Drawing.Point(7, 32)
        Me.txtIdentificacion2.Name = "txtIdentificacion2"
        Me.txtIdentificacion2.Size = New System.Drawing.Size(100, 20)
        Me.txtIdentificacion2.TabIndex = 17
        '
        'btnUpdateDB
        '
        Me.btnUpdateDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateDB.Location = New System.Drawing.Point(586, 68)
        Me.btnUpdateDB.Name = "btnUpdateDB"
        Me.btnUpdateDB.Size = New System.Drawing.Size(103, 23)
        Me.btnUpdateDB.TabIndex = 4
        Me.btnUpdateDB.Text = "Actualizar BD"
        Me.btnUpdateDB.UseVisualStyleBackColor = True
        '
        'cmbIdentificacion2
        '
        Me.cmbIdentificacion2.FormattingEnabled = True
        Me.cmbIdentificacion2.Location = New System.Drawing.Point(137, 32)
        Me.cmbIdentificacion2.Name = "cmbIdentificacion2"
        Me.cmbIdentificacion2.Size = New System.Drawing.Size(121, 21)
        Me.cmbIdentificacion2.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(137, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Identificacion"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 325)
        Me.Controls.Add(Me.btnUpdateDB)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tbcPrincipal)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcPrincipal.ResumeLayout(False)
        Me.tabInsertar.ResumeLayout(False)
        Me.tabInsertar.PerformLayout()
        Me.tabActualizar.ResumeLayout(False)
        Me.tabActualizar.PerformLayout()
        Me.tabEliminar.ResumeLayout(False)
        Me.tabEliminar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tbcPrincipal As System.Windows.Forms.TabControl
    Friend WithEvents tabInsertar As System.Windows.Forms.TabPage
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents lblApellidos As System.Windows.Forms.Label
    Friend WithEvents lblNombres As System.Windows.Forms.Label
    Friend WithEvents lblIdentificacion As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents txtIdentificacion As System.Windows.Forms.TextBox
    Friend WithEvents tabActualizar As System.Windows.Forms.TabPage
    Friend WithEvents btnInsertar As System.Windows.Forms.Button
    Friend WithEvents btnUpdateDB As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents lblDireccion1 As System.Windows.Forms.Label
    Friend WithEvents lblCorreo1 As System.Windows.Forms.Label
    Friend WithEvents lblApellidos1 As System.Windows.Forms.Label
    Friend WithEvents lblNombres1 As System.Windows.Forms.Label
    Friend WithEvents lblIdentificacion1 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreo1 As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidos1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres1 As System.Windows.Forms.TextBox
    Friend WithEvents txtIdentificacion1 As System.Windows.Forms.TextBox
    Friend WithEvents tabEliminar As System.Windows.Forms.TabPage
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents lblIdentificacion2 As System.Windows.Forms.Label
    Friend WithEvents txtIdentificacion2 As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion2 As System.Windows.Forms.Label
    Friend WithEvents lblCorreo2 As System.Windows.Forms.Label
    Friend WithEvents lblApellidos2 As System.Windows.Forms.Label
    Friend WithEvents lblNombres2 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidos2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbIdentificacion2 As System.Windows.Forms.ComboBox

End Class
