<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaPrincipal
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGestionPaciente = New System.Windows.Forms.Button()
        Me.btnGestionMedicos = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSintomas
        '
        Me.btnSintomas.Location = New System.Drawing.Point(50, 103)
        Me.btnSintomas.Name = "btnSintomas"
        Me.btnSintomas.Size = New System.Drawing.Size(178, 49)
        Me.btnSintomas.TabIndex = 0
        Me.btnSintomas.Text = "Gestion de sintomas"
        Me.btnSintomas.UseVisualStyleBackColor = True
        '
        'btnPatologias
        '
        Me.btnPatologias.Location = New System.Drawing.Point(50, 180)
        Me.btnPatologias.Name = "btnPatologias"
        Me.btnPatologias.Size = New System.Drawing.Size(178, 49)
        Me.btnPatologias.TabIndex = 1
        Me.btnPatologias.Text = "Gestion de patologias"
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
        Me.btnAsociar.Location = New System.Drawing.Point(50, 257)
        Me.btnAsociar.Name = "btnAsociar"
        Me.btnAsociar.Size = New System.Drawing.Size(178, 49)
        Me.btnAsociar.TabIndex = 3
        Me.btnAsociar.Text = "Asociar Patologias con Sintomas"
        Me.btnAsociar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(50, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 49)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Gestion de datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnGestionPaciente
        '
        Me.btnGestionPaciente.Location = New System.Drawing.Point(50, 403)
        Me.btnGestionPaciente.Name = "btnGestionPaciente"
        Me.btnGestionPaciente.Size = New System.Drawing.Size(178, 49)
        Me.btnGestionPaciente.TabIndex = 8
        Me.btnGestionPaciente.Text = "Gestion pacientes"
        Me.btnGestionPaciente.UseVisualStyleBackColor = True
        '
        'btnGestionMedicos
        '
        Me.btnGestionMedicos.Location = New System.Drawing.Point(50, 485)
        Me.btnGestionMedicos.Name = "btnGestionMedicos"
        Me.btnGestionMedicos.Size = New System.Drawing.Size(178, 49)
        Me.btnGestionMedicos.TabIndex = 9
        Me.btnGestionMedicos.Text = "Gestion medicos"
        Me.btnGestionMedicos.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(50, 559)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(178, 49)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Gestion administradores"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'VentanaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 635)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnGestionMedicos)
        Me.Controls.Add(Me.btnGestionPaciente)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAsociar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPatologias)
        Me.Controls.Add(Me.btnSintomas)
        Me.Name = "VentanaPrincipal"
        Me.Text = "Gestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSintomas As Button
    Friend WithEvents btnPatologias As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAsociar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnGestionPaciente As Button
    Friend WithEvents btnGestionMedicos As Button
    Friend WithEvents Button2 As Button
End Class
