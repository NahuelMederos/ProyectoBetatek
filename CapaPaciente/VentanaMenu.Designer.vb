<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaMenu
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
        Me.btnSeleccionarSintomas = New System.Windows.Forms.Button()
        Me.btnHistorialChats = New System.Windows.Forms.Button()
        Me.btnModificarDatos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSeleccionarSintomas
        '
        Me.btnSeleccionarSintomas.Location = New System.Drawing.Point(60, 54)
        Me.btnSeleccionarSintomas.Name = "btnSeleccionarSintomas"
        Me.btnSeleccionarSintomas.Size = New System.Drawing.Size(118, 40)
        Me.btnSeleccionarSintomas.TabIndex = 0
        Me.btnSeleccionarSintomas.Text = "Consulta medica"
        Me.btnSeleccionarSintomas.UseVisualStyleBackColor = True
        '
        'btnHistorialChats
        '
        Me.btnHistorialChats.Location = New System.Drawing.Point(60, 121)
        Me.btnHistorialChats.Name = "btnHistorialChats"
        Me.btnHistorialChats.Size = New System.Drawing.Size(118, 40)
        Me.btnHistorialChats.TabIndex = 1
        Me.btnHistorialChats.Text = "Historial de chats"
        Me.btnHistorialChats.UseVisualStyleBackColor = True
        '
        'btnModificarDatos
        '
        Me.btnModificarDatos.Location = New System.Drawing.Point(60, 183)
        Me.btnModificarDatos.Name = "btnModificarDatos"
        Me.btnModificarDatos.Size = New System.Drawing.Size(118, 40)
        Me.btnModificarDatos.TabIndex = 2
        Me.btnModificarDatos.Text = "Modificar datos personales"
        Me.btnModificarDatos.UseVisualStyleBackColor = True
        '
        'VentanaMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 268)
        Me.Controls.Add(Me.btnModificarDatos)
        Me.Controls.Add(Me.btnHistorialChats)
        Me.Controls.Add(Me.btnSeleccionarSintomas)
        Me.Name = "VentanaMenu"
        Me.Text = "VentanaMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSeleccionarSintomas As Button
    Friend WithEvents btnHistorialChats As Button
    Friend WithEvents btnModificarDatos As Button
End Class
