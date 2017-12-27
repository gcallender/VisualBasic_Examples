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
        Me.opcion1 = New System.Windows.Forms.CheckBox()
        Me.opcion2 = New System.Windows.Forms.CheckBox()
        Me.opcion3 = New System.Windows.Forms.CheckBox()
        Me.opcion4 = New System.Windows.Forms.CheckBox()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'opcion1
        '
        Me.opcion1.AutoSize = True
        Me.opcion1.Location = New System.Drawing.Point(13, 47)
        Me.opcion1.Name = "opcion1"
        Me.opcion1.Size = New System.Drawing.Size(69, 17)
        Me.opcion1.TabIndex = 0
        Me.opcion1.Text = "Opcion 1"
        Me.opcion1.UseVisualStyleBackColor = True
        '
        'opcion2
        '
        Me.opcion2.AutoSize = True
        Me.opcion2.Location = New System.Drawing.Point(12, 70)
        Me.opcion2.Name = "opcion2"
        Me.opcion2.Size = New System.Drawing.Size(69, 17)
        Me.opcion2.TabIndex = 1
        Me.opcion2.Text = "Opcion 2"
        Me.opcion2.UseVisualStyleBackColor = True
        '
        'opcion3
        '
        Me.opcion3.AutoSize = True
        Me.opcion3.Location = New System.Drawing.Point(12, 93)
        Me.opcion3.Name = "opcion3"
        Me.opcion3.Size = New System.Drawing.Size(69, 17)
        Me.opcion3.TabIndex = 2
        Me.opcion3.Text = "Opcion 3"
        Me.opcion3.UseVisualStyleBackColor = True
        '
        'opcion4
        '
        Me.opcion4.AutoSize = True
        Me.opcion4.Location = New System.Drawing.Point(13, 116)
        Me.opcion4.Name = "opcion4"
        Me.opcion4.Size = New System.Drawing.Size(69, 17)
        Me.opcion4.TabIndex = 3
        Me.opcion4.Text = "Opcion 4"
        Me.opcion4.UseVisualStyleBackColor = True
        '
        'lblPregunta
        '
        Me.lblPregunta.AutoSize = True
        Me.lblPregunta.Location = New System.Drawing.Point(13, 13)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(127, 13)
        Me.lblPregunta.TabIndex = 4
        Me.lblPregunta.Text = "Elija una o más opciones:"
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(16, 150)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 5
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.lblPregunta)
        Me.Controls.Add(Me.opcion4)
        Me.Controls.Add(Me.opcion3)
        Me.Controls.Add(Me.opcion2)
        Me.Controls.Add(Me.opcion1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents opcion1 As System.Windows.Forms.CheckBox
    Friend WithEvents opcion2 As System.Windows.Forms.CheckBox
    Friend WithEvents opcion3 As System.Windows.Forms.CheckBox
    Friend WithEvents opcion4 As System.Windows.Forms.CheckBox
    Friend WithEvents lblPregunta As System.Windows.Forms.Label
    Friend WithEvents btnEnviar As System.Windows.Forms.Button

End Class
