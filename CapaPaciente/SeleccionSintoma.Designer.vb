<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SeleccionSintoma
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
        Me.btnListarSintomas = New System.Windows.Forms.Button()
        Me.lblSeleccionDeSintomas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GrillaSintomas = New System.Windows.Forms.DataGridView()
        Me.btnSeleccionarSintoma = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GrillaOtrasPatologias = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtResultadoFinal = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSolicitarChat = New System.Windows.Forms.Button()
        CType(Me.GrillaSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaOtrasPatologias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnListarSintomas
        '
        Me.btnListarSintomas.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnListarSintomas.Location = New System.Drawing.Point(12, 350)
        Me.btnListarSintomas.Name = "btnListarSintomas"
        Me.btnListarSintomas.Size = New System.Drawing.Size(66, 39)
        Me.btnListarSintomas.TabIndex = 1
        Me.btnListarSintomas.Text = "Listar Sintomas"
        Me.btnListarSintomas.UseVisualStyleBackColor = False
        '
        'lblSeleccionDeSintomas
        '
        Me.lblSeleccionDeSintomas.AutoSize = True
        Me.lblSeleccionDeSintomas.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionDeSintomas.Location = New System.Drawing.Point(7, 38)
        Me.lblSeleccionDeSintomas.Name = "lblSeleccionDeSintomas"
        Me.lblSeleccionDeSintomas.Size = New System.Drawing.Size(227, 28)
        Me.lblSeleccionDeSintomas.TabIndex = 2
        Me.lblSeleccionDeSintomas.Text = "Sección de sintomas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(383, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Diagnostico"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(554, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 7
        '
        'GrillaSintomas
        '
        Me.GrillaSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaSintomas.Location = New System.Drawing.Point(12, 69)
        Me.GrillaSintomas.Name = "GrillaSintomas"
        Me.GrillaSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaSintomas.Size = New System.Drawing.Size(201, 275)
        Me.GrillaSintomas.TabIndex = 10
        '
        'btnSeleccionarSintoma
        '
        Me.btnSeleccionarSintoma.Location = New System.Drawing.Point(257, 231)
        Me.btnSeleccionarSintoma.Name = "btnSeleccionarSintoma"
        Me.btnSeleccionarSintoma.Size = New System.Drawing.Size(129, 39)
        Me.btnSeleccionarSintoma.TabIndex = 12
        Me.btnSeleccionarSintoma.Text = "Generar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "diagnostico"
        Me.btnSeleccionarSintoma.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 401)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(316, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "*Por ahora solo funciona si se seleccionan los sintomas con el ctrl"
        '
        'GrillaOtrasPatologias
        '
        Me.GrillaOtrasPatologias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaOtrasPatologias.Location = New System.Drawing.Point(449, 82)
        Me.GrillaOtrasPatologias.Name = "GrillaOtrasPatologias"
        Me.GrillaOtrasPatologias.Size = New System.Drawing.Size(188, 288)
        Me.GrillaOtrasPatologias.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(470, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Todas las posibles patologias"
        '
        'txtResultadoFinal
        '
        Me.txtResultadoFinal.Location = New System.Drawing.Point(239, 102)
        Me.txtResultadoFinal.Name = "txtResultadoFinal"
        Me.txtResultadoFinal.Size = New System.Drawing.Size(188, 103)
        Me.txtResultadoFinal.TabIndex = 27
        Me.txtResultadoFinal.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(236, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 26)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Te da las patologias " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "solo si cumplis todos los sintomas"
        '
        'btnSolicitarChat
        '
        Me.btnSolicitarChat.Enabled = False
        Me.btnSolicitarChat.Location = New System.Drawing.Point(284, 289)
        Me.btnSolicitarChat.Name = "btnSolicitarChat"
        Me.btnSolicitarChat.Size = New System.Drawing.Size(75, 39)
        Me.btnSolicitarChat.TabIndex = 29
        Me.btnSolicitarChat.Text = "Solicitar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chat"
        Me.btnSolicitarChat.UseVisualStyleBackColor = True
        '
        'SeleccionSintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(669, 428)
        Me.Controls.Add(Me.btnSolicitarChat)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtResultadoFinal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GrillaOtrasPatologias)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSeleccionarSintoma)
        Me.Controls.Add(Me.GrillaSintomas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSeleccionDeSintomas)
        Me.Controls.Add(Me.btnListarSintomas)
        Me.Name = "SeleccionSintoma"
        Me.Text = "Form1"
        CType(Me.GrillaSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaOtrasPatologias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnListarSintomas As Button
    Friend WithEvents lblSeleccionDeSintomas As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GrillaSintomas As DataGridView
    Friend WithEvents btnSeleccionarSintoma As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents GrillaOtrasPatologias As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txtResultadoFinal As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSolicitarChat As Button
End Class
