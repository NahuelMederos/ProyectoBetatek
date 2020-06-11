<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IngresoPersona
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtEsquina = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(455, 84)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(159, 20)
        Me.TxtNombre.TabIndex = 0
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(456, 110)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(159, 20)
        Me.txtApellido.TabIndex = 1
        '
        'txtCi
        '
        Me.txtCi.Location = New System.Drawing.Point(455, 136)
        Me.txtCi.Name = "txtCi"
        Me.txtCi.Size = New System.Drawing.Size(159, 20)
        Me.txtCi.TabIndex = 2
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(456, 162)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(159, 20)
        Me.txtCalle.TabIndex = 3
        '
        'txtEsquina
        '
        Me.txtEsquina.Location = New System.Drawing.Point(456, 188)
        Me.txtEsquina.Name = "txtEsquina"
        Me.txtEsquina.Size = New System.Drawing.Size(159, 20)
        Me.txtEsquina.TabIndex = 4
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(456, 214)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(159, 20)
        Me.txtNumero.TabIndex = 5
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(456, 240)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(159, 20)
        Me.txtTel.TabIndex = 6
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(456, 266)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(159, 20)
        Me.txtEdad.TabIndex = 7
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(456, 292)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(159, 20)
        Me.txtMail.TabIndex = 8
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(455, 328)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(159, 37)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'IngresoPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 467)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.txtEsquina)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.txtCi)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Name = "IngresoPersona"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCi As TextBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents txtEsquina As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents btnGuardar As Button
End Class
