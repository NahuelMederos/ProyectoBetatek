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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnChat = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GrillaSintomas = New System.Windows.Forms.DataGridView()
        Me.btnSeleccionarSintoma = New System.Windows.Forms.Button()
        Me.txtPideCI = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPatologias = New System.Windows.Forms.RichTextBox()
        Me.txtpresult = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GrillaOtrasPatologias = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOtrasPatologiasResult = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtweon = New System.Windows.Forms.TextBox()
        Me.txtxd = New System.Windows.Forms.RichTextBox()
        Me.txtResultadoFinal = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.GrillaSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaOtrasPatologias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnListarSintomas
        '
        Me.btnListarSintomas.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnListarSintomas.Location = New System.Drawing.Point(39, 426)
        Me.btnListarSintomas.Name = "btnListarSintomas"
        Me.btnListarSintomas.Size = New System.Drawing.Size(316, 23)
        Me.btnListarSintomas.TabIndex = 1
        Me.btnListarSintomas.Text = "Listar Sintomas"
        Me.btnListarSintomas.UseVisualStyleBackColor = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(523, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Diagnostico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(525, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Posibles patologias"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(407, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 7
        '
        'btnChat
        '
        Me.btnChat.Location = New System.Drawing.Point(528, 263)
        Me.btnChat.Name = "btnChat"
        Me.btnChat.Size = New System.Drawing.Size(75, 23)
        Me.btnChat.TabIndex = 8
        Me.btnChat.Text = "Chat remoto"
        Me.btnChat.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(525, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Diagnostico remoto"
        '
        'GrillaSintomas
        '
        Me.GrillaSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaSintomas.Location = New System.Drawing.Point(39, 69)
        Me.GrillaSintomas.Name = "GrillaSintomas"
        Me.GrillaSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaSintomas.Size = New System.Drawing.Size(316, 351)
        Me.GrillaSintomas.TabIndex = 10
        '
        'btnSeleccionarSintoma
        '
        Me.btnSeleccionarSintoma.Location = New System.Drawing.Point(361, 393)
        Me.btnSeleccionarSintoma.Name = "btnSeleccionarSintoma"
        Me.btnSeleccionarSintoma.Size = New System.Drawing.Size(113, 27)
        Me.btnSeleccionarSintoma.TabIndex = 12
        Me.btnSeleccionarSintoma.Text = "Seleccionar"
        Me.btnSeleccionarSintoma.UseVisualStyleBackColor = True
        '
        'txtPideCI
        '
        Me.txtPideCI.Location = New System.Drawing.Point(361, 362)
        Me.txtPideCI.Name = "txtPideCI"
        Me.txtPideCI.Size = New System.Drawing.Size(91, 20)
        Me.txtPideCI.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AllowDrop = True
        Me.Label5.AutoEllipsis = True
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(361, 346)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Digite su CI"
        '
        'txtPatologias
        '
        Me.txtPatologias.Location = New System.Drawing.Point(361, 69)
        Me.txtPatologias.Name = "txtPatologias"
        Me.txtPatologias.Size = New System.Drawing.Size(344, 159)
        Me.txtPatologias.TabIndex = 17
        Me.txtPatologias.Text = ""
        '
        'txtpresult
        '
        Me.txtpresult.Location = New System.Drawing.Point(528, 293)
        Me.txtpresult.Name = "txtpresult"
        Me.txtpresult.Size = New System.Drawing.Size(163, 167)
        Me.txtpresult.TabIndex = 18
        Me.txtpresult.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 452)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(316, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "*Por ahora solo funciona si se seleccionan los sintomas con el ctrl"
        '
        'GrillaOtrasPatologias
        '
        Me.GrillaOtrasPatologias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaOtrasPatologias.Location = New System.Drawing.Point(794, 58)
        Me.GrillaOtrasPatologias.Name = "GrillaOtrasPatologias"
        Me.GrillaOtrasPatologias.Size = New System.Drawing.Size(147, 189)
        Me.GrillaOtrasPatologias.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(804, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Otras posibles patologias"
        '
        'txtOtrasPatologiasResult
        '
        Me.txtOtrasPatologiasResult.Location = New System.Drawing.Point(794, 302)
        Me.txtOtrasPatologiasResult.Name = "txtOtrasPatologiasResult"
        Me.txtOtrasPatologiasResult.Size = New System.Drawing.Size(181, 158)
        Me.txtOtrasPatologiasResult.TabIndex = 22
        Me.txtOtrasPatologiasResult.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(317, 551)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "btnweon"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(410, 551)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "btnweon2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtweon
        '
        Me.txtweon.Location = New System.Drawing.Point(317, 518)
        Me.txtweon.Name = "txtweon"
        Me.txtweon.Size = New System.Drawing.Size(176, 20)
        Me.txtweon.TabIndex = 25
        '
        'txtxd
        '
        Me.txtxd.Location = New System.Drawing.Point(565, 499)
        Me.txtxd.Name = "txtxd"
        Me.txtxd.Size = New System.Drawing.Size(410, 168)
        Me.txtxd.TabIndex = 26
        Me.txtxd.Text = ""
        '
        'txtResultadoFinal
        '
        Me.txtResultadoFinal.Location = New System.Drawing.Point(15, 553)
        Me.txtResultadoFinal.Name = "txtResultadoFinal"
        Me.txtResultadoFinal.Size = New System.Drawing.Size(249, 87)
        Me.txtResultadoFinal.TabIndex = 27
        Me.txtResultadoFinal.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 654)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(295, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Este es el que te da la patologia si cumplis todos los sintomas"
        '
        'SeleccionSintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(987, 679)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtResultadoFinal)
        Me.Controls.Add(Me.txtxd)
        Me.Controls.Add(Me.txtweon)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtOtrasPatologiasResult)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GrillaOtrasPatologias)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtpresult)
        Me.Controls.Add(Me.txtPatologias)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPideCI)
        Me.Controls.Add(Me.btnSeleccionarSintoma)
        Me.Controls.Add(Me.GrillaSintomas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnChat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnChat As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents GrillaSintomas As DataGridView
    Friend WithEvents btnSeleccionarSintoma As Button
    Friend WithEvents txtPideCI As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPatologias As RichTextBox
    Friend WithEvents txtpresult As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GrillaOtrasPatologias As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txtOtrasPatologiasResult As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtweon As TextBox
    Friend WithEvents txtxd As RichTextBox
    Friend WithEvents txtResultadoFinal As RichTextBox
    Friend WithEvents Label8 As Label
End Class
