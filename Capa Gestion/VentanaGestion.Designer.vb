<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaGestion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSintomas = New System.Windows.Forms.Button()
        Me.btnPatologias = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAsociar = New System.Windows.Forms.Button()
        Me.btnAgregarGestor = New System.Windows.Forms.Button()
        Me.btnAgregarMedicos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSintomas
        '
        Me.btnSintomas.Location = New System.Drawing.Point(77, 106)
        Me.btnSintomas.Name = "btnSintomas"
        Me.btnSintomas.Size = New System.Drawing.Size(178, 49)
        Me.btnSintomas.TabIndex = 0
        Me.btnSintomas.Text = "Ingreso de Sintomas"
        Me.btnSintomas.UseVisualStyleBackColor = True
        '
        'btnPatologias
        '
        Me.btnPatologias.Location = New System.Drawing.Point(77, 183)
        Me.btnPatologias.Name = "btnPatologias"
        Me.btnPatologias.Size = New System.Drawing.Size(178, 49)
        Me.btnPatologias.TabIndex = 1
        Me.btnPatologias.Text = "Ingreso de Patologias"
        Me.btnPatologias.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Gestion Betatek"
        '
        'btnAsociar
        '
        Me.btnAsociar.Location = New System.Drawing.Point(77, 260)
        Me.btnAsociar.Name = "btnAsociar"
        Me.btnAsociar.Size = New System.Drawing.Size(178, 49)
        Me.btnAsociar.TabIndex = 3
        Me.btnAsociar.Text = "Asociar Patologias con Sintomas"
        Me.btnAsociar.UseVisualStyleBackColor = True
        '
        'btnAgregarGestor
        '
        Me.btnAgregarGestor.Location = New System.Drawing.Point(77, 336)
        Me.btnAgregarGestor.Name = "btnAgregarGestor"
        Me.btnAgregarGestor.Size = New System.Drawing.Size(178, 49)
        Me.btnAgregarGestor.TabIndex = 4
        Me.btnAgregarGestor.Text = "Agregar gestor"
        Me.btnAgregarGestor.UseVisualStyleBackColor = True
        '
        'btnAgregarMedicos
        '
        Me.btnAgregarMedicos.Location = New System.Drawing.Point(77, 417)
        Me.btnAgregarMedicos.Name = "btnAgregarMedicos"
        Me.btnAgregarMedicos.Size = New System.Drawing.Size(178, 49)
        Me.btnAgregarMedicos.TabIndex = 5
        Me.btnAgregarMedicos.Text = "Agregar medico"
        Me.btnAgregarMedicos.UseVisualStyleBackColor = True
        '
        'VentanaGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 503)
        Me.Controls.Add(Me.btnAgregarMedicos)
        Me.Controls.Add(Me.btnAgregarGestor)
        Me.Controls.Add(Me.btnAsociar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPatologias)
        Me.Controls.Add(Me.btnSintomas)
        Me.Name = "VentanaGestion"
        Me.Text = "Gestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSintomas As Button
    Friend WithEvents btnPatologias As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAsociar As Button
    Friend WithEvents btnAgregarGestor As Button
    Friend WithEvents btnAgregarMedicos As Button
End Class
