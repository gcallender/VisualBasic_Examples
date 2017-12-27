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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbSuma = New System.Windows.Forms.RadioButton()
        Me.rbResta = New System.Windows.Forms.RadioButton()
        Me.rbMultiplicacion = New System.Windows.Forms.RadioButton()
        Me.rbDivision = New System.Windows.Forms.RadioButton()
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.num2 = New System.Windows.Forms.TextBox()
        Me.bOperacion = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bOperacion)
        Me.GroupBox1.Controls.Add(Me.num2)
        Me.GroupBox1.Controls.Add(Me.num1)
        Me.GroupBox1.Controls.Add(Me.rbDivision)
        Me.GroupBox1.Controls.Add(Me.rbMultiplicacion)
        Me.GroupBox1.Controls.Add(Me.rbResta)
        Me.GroupBox1.Controls.Add(Me.rbSuma)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 136)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'rbSuma
        '
        Me.rbSuma.AutoSize = True
        Me.rbSuma.Location = New System.Drawing.Point(7, 20)
        Me.rbSuma.Name = "rbSuma"
        Me.rbSuma.Size = New System.Drawing.Size(52, 17)
        Me.rbSuma.TabIndex = 0
        Me.rbSuma.TabStop = True
        Me.rbSuma.Text = "Suma"
        Me.rbSuma.UseVisualStyleBackColor = True
        '
        'rbResta
        '
        Me.rbResta.AutoSize = True
        Me.rbResta.Location = New System.Drawing.Point(7, 43)
        Me.rbResta.Name = "rbResta"
        Me.rbResta.Size = New System.Drawing.Size(53, 17)
        Me.rbResta.TabIndex = 1
        Me.rbResta.TabStop = True
        Me.rbResta.Text = "Resta"
        Me.rbResta.UseVisualStyleBackColor = True
        '
        'rbMultiplicacion
        '
        Me.rbMultiplicacion.AutoSize = True
        Me.rbMultiplicacion.Location = New System.Drawing.Point(7, 66)
        Me.rbMultiplicacion.Name = "rbMultiplicacion"
        Me.rbMultiplicacion.Size = New System.Drawing.Size(89, 17)
        Me.rbMultiplicacion.TabIndex = 2
        Me.rbMultiplicacion.TabStop = True
        Me.rbMultiplicacion.Text = "Multiplicacion"
        Me.rbMultiplicacion.UseVisualStyleBackColor = True
        '
        'rbDivision
        '
        Me.rbDivision.AutoSize = True
        Me.rbDivision.Location = New System.Drawing.Point(7, 89)
        Me.rbDivision.Name = "rbDivision"
        Me.rbDivision.Size = New System.Drawing.Size(62, 17)
        Me.rbDivision.TabIndex = 3
        Me.rbDivision.TabStop = True
        Me.rbDivision.Text = "Division"
        Me.rbDivision.UseVisualStyleBackColor = True
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(140, 20)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(100, 20)
        Me.num1.TabIndex = 4
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(140, 46)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(100, 20)
        Me.num2.TabIndex = 5
        '
        'bOperacion
        '
        Me.bOperacion.Location = New System.Drawing.Point(140, 89)
        Me.bOperacion.Name = "bOperacion"
        Me.bOperacion.Size = New System.Drawing.Size(100, 23)
        Me.bOperacion.TabIndex = 6
        Me.bOperacion.Text = "Ejecutar"
        Me.bOperacion.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bOperacion As System.Windows.Forms.Button
    Friend WithEvents num2 As System.Windows.Forms.TextBox
    Friend WithEvents num1 As System.Windows.Forms.TextBox
    Friend WithEvents rbDivision As System.Windows.Forms.RadioButton
    Friend WithEvents rbMultiplicacion As System.Windows.Forms.RadioButton
    Friend WithEvents rbResta As System.Windows.Forms.RadioButton
    Friend WithEvents rbSuma As System.Windows.Forms.RadioButton

End Class
