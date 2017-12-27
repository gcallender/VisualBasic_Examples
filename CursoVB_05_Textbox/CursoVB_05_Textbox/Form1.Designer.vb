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
        Me.etiqueta = New System.Windows.Forms.Label()
        Me.texto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'etiqueta
        '
        Me.etiqueta.AutoSize = True
        Me.etiqueta.Location = New System.Drawing.Point(12, 9)
        Me.etiqueta.Name = "etiqueta"
        Me.etiqueta.Size = New System.Drawing.Size(75, 13)
        Me.etiqueta.TabIndex = 0
        Me.etiqueta.Text = "Digite un texto"
        '
        'texto
        '
        Me.texto.Location = New System.Drawing.Point(125, 9)
        Me.texto.Name = "texto"
        Me.texto.Size = New System.Drawing.Size(133, 20)
        Me.texto.TabIndex = 1
        Me.texto.Text = "HolaMundo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.texto)
        Me.Controls.Add(Me.etiqueta)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents etiqueta As System.Windows.Forms.Label
    Friend WithEvents texto As System.Windows.Forms.TextBox

End Class
