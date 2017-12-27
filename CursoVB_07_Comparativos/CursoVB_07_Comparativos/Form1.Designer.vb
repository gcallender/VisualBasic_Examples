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
        Me.txtVar1 = New System.Windows.Forms.TextBox()
        Me.txtVar2 = New System.Windows.Forms.TextBox()
        Me.btnMayor = New System.Windows.Forms.Button()
        Me.btnMenor = New System.Windows.Forms.Button()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.btnMayorIgual = New System.Windows.Forms.Button()
        Me.btnMenorIgual = New System.Windows.Forms.Button()
        Me.btnDiferente = New System.Windows.Forms.Button()
        Me.labelNum1 = New System.Windows.Forms.Label()
        Me.labelNum2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtVar1
        '
        Me.txtVar1.Location = New System.Drawing.Point(27, 38)
        Me.txtVar1.Name = "txtVar1"
        Me.txtVar1.Size = New System.Drawing.Size(125, 20)
        Me.txtVar1.TabIndex = 0
        '
        'txtVar2
        '
        Me.txtVar2.Location = New System.Drawing.Point(177, 38)
        Me.txtVar2.Name = "txtVar2"
        Me.txtVar2.Size = New System.Drawing.Size(122, 20)
        Me.txtVar2.TabIndex = 1
        '
        'btnMayor
        '
        Me.btnMayor.Location = New System.Drawing.Point(27, 74)
        Me.btnMayor.Name = "btnMayor"
        Me.btnMayor.Size = New System.Drawing.Size(125, 23)
        Me.btnMayor.TabIndex = 2
        Me.btnMayor.Text = "Mayor que"
        Me.btnMayor.UseVisualStyleBackColor = True
        '
        'btnMenor
        '
        Me.btnMenor.Location = New System.Drawing.Point(27, 104)
        Me.btnMenor.Name = "btnMenor"
        Me.btnMenor.Size = New System.Drawing.Size(125, 23)
        Me.btnMenor.TabIndex = 3
        Me.btnMenor.Text = "Menor que"
        Me.btnMenor.UseVisualStyleBackColor = True
        '
        'btnIgual
        '
        Me.btnIgual.Location = New System.Drawing.Point(27, 134)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(125, 23)
        Me.btnIgual.TabIndex = 4
        Me.btnIgual.Text = "Igual que"
        Me.btnIgual.UseVisualStyleBackColor = True
        '
        'btnMayorIgual
        '
        Me.btnMayorIgual.Location = New System.Drawing.Point(177, 74)
        Me.btnMayorIgual.Name = "btnMayorIgual"
        Me.btnMayorIgual.Size = New System.Drawing.Size(122, 23)
        Me.btnMayorIgual.TabIndex = 5
        Me.btnMayorIgual.Text = "Mayor o igual que"
        Me.btnMayorIgual.UseVisualStyleBackColor = True
        '
        'btnMenorIgual
        '
        Me.btnMenorIgual.Location = New System.Drawing.Point(177, 104)
        Me.btnMenorIgual.Name = "btnMenorIgual"
        Me.btnMenorIgual.Size = New System.Drawing.Size(122, 23)
        Me.btnMenorIgual.TabIndex = 6
        Me.btnMenorIgual.Text = "Menor o igual que"
        Me.btnMenorIgual.UseVisualStyleBackColor = True
        '
        'btnDiferente
        '
        Me.btnDiferente.Location = New System.Drawing.Point(177, 133)
        Me.btnDiferente.Name = "btnDiferente"
        Me.btnDiferente.Size = New System.Drawing.Size(122, 23)
        Me.btnDiferente.TabIndex = 7
        Me.btnDiferente.Text = "Diferente que"
        Me.btnDiferente.UseVisualStyleBackColor = True
        '
        'labelNum1
        '
        Me.labelNum1.AutoSize = True
        Me.labelNum1.Location = New System.Drawing.Point(24, 17)
        Me.labelNum1.Name = "labelNum1"
        Me.labelNum1.Size = New System.Drawing.Size(53, 13)
        Me.labelNum1.TabIndex = 8
        Me.labelNum1.Text = "Numero 1"
        '
        'labelNum2
        '
        Me.labelNum2.AutoSize = True
        Me.labelNum2.Location = New System.Drawing.Point(174, 17)
        Me.labelNum2.Name = "labelNum2"
        Me.labelNum2.Size = New System.Drawing.Size(53, 13)
        Me.labelNum2.TabIndex = 9
        Me.labelNum2.Text = "Numero 2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 261)
        Me.Controls.Add(Me.labelNum2)
        Me.Controls.Add(Me.labelNum1)
        Me.Controls.Add(Me.btnDiferente)
        Me.Controls.Add(Me.btnMenorIgual)
        Me.Controls.Add(Me.btnMayorIgual)
        Me.Controls.Add(Me.btnIgual)
        Me.Controls.Add(Me.btnMenor)
        Me.Controls.Add(Me.btnMayor)
        Me.Controls.Add(Me.txtVar2)
        Me.Controls.Add(Me.txtVar1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtVar1 As System.Windows.Forms.TextBox
    Friend WithEvents txtVar2 As System.Windows.Forms.TextBox
    Friend WithEvents btnMayor As System.Windows.Forms.Button
    Friend WithEvents btnMenor As System.Windows.Forms.Button
    Friend WithEvents btnIgual As System.Windows.Forms.Button
    Friend WithEvents btnMayorIgual As System.Windows.Forms.Button
    Friend WithEvents btnMenorIgual As System.Windows.Forms.Button
    Friend WithEvents btnDiferente As System.Windows.Forms.Button
    Friend WithEvents labelNum1 As System.Windows.Forms.Label
    Friend WithEvents labelNum2 As System.Windows.Forms.Label

End Class
