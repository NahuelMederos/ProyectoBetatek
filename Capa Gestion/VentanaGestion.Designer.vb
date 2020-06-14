<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSintomas = New System.Windows.Forms.Button()
        Me.btnPatologias = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Label1.Font = New System.Drawing.Font("Liberation Mono", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Gestion Betatek"
        '
        'FormGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 284)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPatologias)
        Me.Controls.Add(Me.btnSintomas)
        Me.Name = "FormGestion"
        Me.Text = "Gestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSintomas As Button
    Friend WithEvents btnPatologias As Button
    Friend WithEvents Label1 As Label
End Class
