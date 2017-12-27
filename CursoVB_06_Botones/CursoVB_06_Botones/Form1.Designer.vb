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
        Me.btn = New System.Windows.Forms.Button()
        Me.btn_suma = New System.Windows.Forms.Button()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(13, 13)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(75, 23)
        Me.btn.TabIndex = 0
        Me.btn.Text = "Saludar"
        Me.btn.UseVisualStyleBackColor = True
        '
        'btn_suma
        '
        Me.btn_suma.Location = New System.Drawing.Point(13, 129)
        Me.btn_suma.Name = "btn_suma"
        Me.btn_suma.Size = New System.Drawing.Size(75, 23)
        Me.btn_suma.TabIndex = 1
        Me.btn_suma.Text = "Sumar"
        Me.btn_suma.UseVisualStyleBackColor = True
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(13, 97)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(75, 20)
        Me.txtNum1.TabIndex = 2
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(108, 97)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(75, 20)
        Me.txtNum2.TabIndex = 3
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Location = New System.Drawing.Point(12, 70)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(53, 13)
        Me.lblNum1.TabIndex = 4
        Me.lblNum1.Text = "Numero 1"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Location = New System.Drawing.Point(105, 70)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(53, 13)
        Me.lblNum2.TabIndex = 5
        Me.lblNum2.Text = "Numero 2"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(191, 128)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 261)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.btn_suma)
        Me.Controls.Add(Me.btn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents btn_suma As System.Windows.Forms.Button
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents lblNum1 As System.Windows.Forms.Label
    Friend WithEvents lblNum2 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
