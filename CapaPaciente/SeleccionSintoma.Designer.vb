<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionSintoma
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
        Me.lstSintomas = New System.Windows.Forms.ListBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.lblSeleccionDeSintomas = New System.Windows.Forms.Label()
        Me.btmSolicitar = New System.Windows.Forms.Button()
        Me.lstPatologiasAsociadas = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstSintomas
        '
        Me.lstSintomas.FormattingEnabled = True
        Me.lstSintomas.Location = New System.Drawing.Point(39, 56)
        Me.lstSintomas.Name = "lstSintomas"
        Me.lstSintomas.Size = New System.Drawing.Size(316, 355)
        Me.lstSintomas.TabIndex = 0
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnConfirmar.Location = New System.Drawing.Point(39, 426)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(316, 23)
        Me.btnConfirmar.TabIndex = 1
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'lblSeleccionDeSintomas
        '
        Me.lblSeleccionDeSintomas.AutoSize = True
        Me.lblSeleccionDeSintomas.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionDeSintomas.Location = New System.Drawing.Point(34, 25)
        Me.lblSeleccionDeSintomas.Name = "lblSeleccionDeSintomas"
        Me.lblSeleccionDeSintomas.Size = New System.Drawing.Size(227, 28)
        Me.lblSeleccionDeSintomas.TabIndex = 2
        Me.lblSeleccionDeSintomas.Text = "Sección de sintomas"
        '
        'btmSolicitar
        '
        Me.btmSolicitar.Location = New System.Drawing.Point(391, 426)
        Me.btmSolicitar.Name = "btmSolicitar"
        Me.btmSolicitar.Size = New System.Drawing.Size(101, 23)
        Me.btmSolicitar.TabIndex = 3
        Me.btmSolicitar.Text = "Solicitar chat"
        Me.btmSolicitar.UseVisualStyleBackColor = True
        '
        'lstPatologiasAsociadas
        '
        Me.lstPatologiasAsociadas.FormattingEnabled = True
        Me.lstPatologiasAsociadas.Location = New System.Drawing.Point(408, 60)
        Me.lstPatologiasAsociadas.Name = "lstPatologiasAsociadas"
        Me.lstPatologiasAsociadas.Size = New System.Drawing.Size(127, 108)
        Me.lstPatologiasAsociadas.TabIndex = 4
        '
        'SeleccionSintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1140, 493)
        Me.Controls.Add(Me.lstPatologiasAsociadas)
        Me.Controls.Add(Me.btmSolicitar)
        Me.Controls.Add(Me.lblSeleccionDeSintomas)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.lstSintomas)
        Me.Name = "SeleccionSintoma"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstSintomas As ListBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents lblSeleccionDeSintomas As Label
    Friend WithEvents btmSolicitar As Button
    Friend WithEvents lstPatologiasAsociadas As ListBox
End Class
