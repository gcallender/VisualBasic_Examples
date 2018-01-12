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
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.rbSuma = New System.Windows.Forms.RadioButton()
        Me.rbResta = New System.Windows.Forms.RadioButton()
        Me.rbMultiplicacion = New System.Windows.Forms.RadioButton()
        Me.rbDivision = New System.Windows.Forms.RadioButton()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(13, 34)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(53, 20)
        Me.txtNum1.TabIndex = 0
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Location = New System.Drawing.Point(13, 13)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(38, 13)
        Me.lblNum1.TabIndex = 1
        Me.lblNum1.Text = "Num 1"
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(87, 34)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(53, 20)
        Me.txtNum2.TabIndex = 2
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Location = New System.Drawing.Point(84, 13)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(38, 13)
        Me.lblNum2.TabIndex = 3
        Me.lblNum2.Text = "Num 2"
        '
        'rbSuma
        '
        Me.rbSuma.AutoSize = True
        Me.rbSuma.Location = New System.Drawing.Point(12, 73)
        Me.rbSuma.Name = "rbSuma"
        Me.rbSuma.Size = New System.Drawing.Size(52, 17)
        Me.rbSuma.TabIndex = 4
        Me.rbSuma.TabStop = True
        Me.rbSuma.Text = "Suma"
        Me.rbSuma.UseVisualStyleBackColor = True
        '
        'rbResta
        '
        Me.rbResta.AutoSize = True
        Me.rbResta.Location = New System.Drawing.Point(12, 96)
        Me.rbResta.Name = "rbResta"
        Me.rbResta.Size = New System.Drawing.Size(53, 17)
        Me.rbResta.TabIndex = 5
        Me.rbResta.TabStop = True
        Me.rbResta.Text = "Resta"
        Me.rbResta.UseVisualStyleBackColor = True
        '
        'rbMultiplicacion
        '
        Me.rbMultiplicacion.AutoSize = True
        Me.rbMultiplicacion.Location = New System.Drawing.Point(12, 119)
        Me.rbMultiplicacion.Name = "rbMultiplicacion"
        Me.rbMultiplicacion.Size = New System.Drawing.Size(89, 17)
        Me.rbMultiplicacion.TabIndex = 6
        Me.rbMultiplicacion.TabStop = True
        Me.rbMultiplicacion.Text = "Multiplicacion"
        Me.rbMultiplicacion.UseVisualStyleBackColor = True
        '
        'rbDivision
        '
        Me.rbDivision.AutoSize = True
        Me.rbDivision.Location = New System.Drawing.Point(12, 142)
        Me.rbDivision.Name = "rbDivision"
        Me.rbDivision.Size = New System.Drawing.Size(62, 17)
        Me.rbDivision.TabIndex = 7
        Me.rbDivision.TabStop = True
        Me.rbDivision.Text = "Division"
        Me.rbDivision.UseVisualStyleBackColor = True
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(12, 180)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.btnEjecutar.TabIndex = 8
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.rbDivision)
        Me.Controls.Add(Me.rbMultiplicacion)
        Me.Controls.Add(Me.rbResta)
        Me.Controls.Add(Me.rbSuma)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.txtNum1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNum1 As System.Windows.Forms.Label
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents lblNum2 As System.Windows.Forms.Label
    Friend WithEvents rbSuma As System.Windows.Forms.RadioButton
    Friend WithEvents rbResta As System.Windows.Forms.RadioButton
    Friend WithEvents rbMultiplicacion As System.Windows.Forms.RadioButton
    Friend WithEvents rbDivision As System.Windows.Forms.RadioButton
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button

End Class
