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
        Me.btnAsociar = New System.Windows.Forms.Button()
        Me.btnGestionPaciente = New System.Windows.Forms.Button()
        Me.btnGestionMedicos = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnHistorialDeChats = New System.Windows.Forms.Button()
        Me.btnDiagnosticosGenerados = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSintomas
        '
        Me.btnSintomas.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSintomas.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnSintomas.ForeColor = System.Drawing.Color.Snow
        Me.btnSintomas.Location = New System.Drawing.Point(217, 72)
        Me.btnSintomas.Name = "btnSintomas"
        Me.btnSintomas.Size = New System.Drawing.Size(219, 77)
        Me.btnSintomas.TabIndex = 0
        Me.btnSintomas.Text = "Gestion de sintomas"
        Me.btnSintomas.UseVisualStyleBackColor = False
        '
        'btnPatologias
        '
        Me.btnPatologias.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPatologias.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPatologias.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnPatologias.ForeColor = System.Drawing.Color.Snow
        Me.btnPatologias.Location = New System.Drawing.Point(217, 148)
        Me.btnPatologias.Name = "btnPatologias"
        Me.btnPatologias.Size = New System.Drawing.Size(219, 77)
        Me.btnPatologias.TabIndex = 1
        Me.btnPatologias.Text = "Gestion de patologias"
        Me.btnPatologias.UseVisualStyleBackColor = False
        '
        'btnAsociar
        '
        Me.btnAsociar.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAsociar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAsociar.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnAsociar.ForeColor = System.Drawing.Color.Snow
        Me.btnAsociar.Location = New System.Drawing.Point(217, 223)
        Me.btnAsociar.Name = "btnAsociar"
        Me.btnAsociar.Size = New System.Drawing.Size(219, 77)
        Me.btnAsociar.TabIndex = 3
        Me.btnAsociar.Text = "Asociar Patologias con Sintomas"
        Me.btnAsociar.UseVisualStyleBackColor = False
        '
        'btnGestionPaciente
        '
        Me.btnGestionPaciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnGestionPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGestionPaciente.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestionPaciente.ForeColor = System.Drawing.Color.Snow
        Me.btnGestionPaciente.Location = New System.Drawing.Point(0, 72)
        Me.btnGestionPaciente.Name = "btnGestionPaciente"
        Me.btnGestionPaciente.Size = New System.Drawing.Size(219, 77)
        Me.btnGestionPaciente.TabIndex = 8
        Me.btnGestionPaciente.Text = "Gestion pacientes"
        Me.btnGestionPaciente.UseVisualStyleBackColor = False
        '
        'btnGestionMedicos
        '
        Me.btnGestionMedicos.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnGestionMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGestionMedicos.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestionMedicos.ForeColor = System.Drawing.Color.Snow
        Me.btnGestionMedicos.Location = New System.Drawing.Point(0, 148)
        Me.btnGestionMedicos.Name = "btnGestionMedicos"
        Me.btnGestionMedicos.Size = New System.Drawing.Size(219, 77)
        Me.btnGestionMedicos.TabIndex = 9
        Me.btnGestionMedicos.Text = "Gestion medicos"
        Me.btnGestionMedicos.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Snow
        Me.Button2.Location = New System.Drawing.Point(0, 223)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(219, 77)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Gestion administradores"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnHistorialDeChats
        '
        Me.btnHistorialDeChats.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnHistorialDeChats.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHistorialDeChats.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnHistorialDeChats.ForeColor = System.Drawing.Color.Snow
        Me.btnHistorialDeChats.Location = New System.Drawing.Point(433, 72)
        Me.btnHistorialDeChats.Name = "btnHistorialDeChats"
        Me.btnHistorialDeChats.Size = New System.Drawing.Size(219, 116)
        Me.btnHistorialDeChats.TabIndex = 11
        Me.btnHistorialDeChats.Text = "Ver sesiones de chats"
        Me.btnHistorialDeChats.UseVisualStyleBackColor = False
        '
        'btnDiagnosticosGenerados
        '
        Me.btnDiagnosticosGenerados.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnDiagnosticosGenerados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDiagnosticosGenerados.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnDiagnosticosGenerados.ForeColor = System.Drawing.Color.Snow
        Me.btnDiagnosticosGenerados.Location = New System.Drawing.Point(433, 183)
        Me.btnDiagnosticosGenerados.Name = "btnDiagnosticosGenerados"
        Me.btnDiagnosticosGenerados.Size = New System.Drawing.Size(219, 116)
        Me.btnDiagnosticosGenerados.TabIndex = 12
        Me.btnDiagnosticosGenerados.Text = "Ver diagnosticos generados"
        Me.btnDiagnosticosGenerados.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.FondoLogin
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(651, 72)
        Me.Panel1.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.Logo_2_sin_fondo
        Me.PictureBox1.Location = New System.Drawing.Point(570, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'VentanaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(651, 299)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnDiagnosticosGenerados)
        Me.Controls.Add(Me.btnHistorialDeChats)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnGestionMedicos)
        Me.Controls.Add(Me.btnGestionPaciente)
        Me.Controls.Add(Me.btnAsociar)
        Me.Controls.Add(Me.btnPatologias)
        Me.Controls.Add(Me.btnSintomas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "VentanaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu principal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSintomas As Button
    Friend WithEvents btnPatologias As Button
    Friend WithEvents btnAsociar As Button
    Friend WithEvents btnGestionPaciente As Button
    Friend WithEvents btnGestionMedicos As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnHistorialDeChats As Button
    Friend WithEvents btnDiagnosticosGenerados As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
