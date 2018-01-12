<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class msgHelp
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
        Me.linkTxt01 = New System.Windows.Forms.LinkLabel()
        Me.lblHelp01 = New System.Windows.Forms.Label()
        Me.lblHelp02 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'linkTxt01
        '
        Me.linkTxt01.AutoSize = True
        Me.linkTxt01.Location = New System.Drawing.Point(12, 79)
        Me.linkTxt01.Name = "linkTxt01"
        Me.linkTxt01.Size = New System.Drawing.Size(59, 13)
        Me.linkTxt01.TabIndex = 0
        Me.linkTxt01.TabStop = True
        Me.linkTxt01.Text = "LinkLabel1"
        '
        'lblHelp01
        '
        Me.lblHelp01.AutoSize = True
        Me.lblHelp01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp01.Location = New System.Drawing.Point(12, 20)
        Me.lblHelp01.Name = "lblHelp01"
        Me.lblHelp01.Size = New System.Drawing.Size(39, 13)
        Me.lblHelp01.TabIndex = 1
        Me.lblHelp01.Text = "Label1"
        '
        'lblHelp02
        '
        Me.lblHelp02.AutoSize = True
        Me.lblHelp02.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp02.Location = New System.Drawing.Point(12, 110)
        Me.lblHelp02.Name = "lblHelp02"
        Me.lblHelp02.Size = New System.Drawing.Size(39, 13)
        Me.lblHelp02.TabIndex = 2
        Me.lblHelp02.Text = "Label2"
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(176, 203)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(95, 27)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'msgHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 254)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblHelp02)
        Me.Controls.Add(Me.lblHelp01)
        Me.Controls.Add(Me.linkTxt01)
        Me.Name = "msgHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ayuda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents linkTxt01 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblHelp01 As System.Windows.Forms.Label
    Friend WithEvents lblHelp02 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class
