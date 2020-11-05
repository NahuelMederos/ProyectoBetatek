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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSeleccionarSintomas
        '
        Me.btnSeleccionarSintomas.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSeleccionarSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSeleccionarSintomas.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarSintomas.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSeleccionarSintomas.Location = New System.Drawing.Point(0, 67)
        Me.btnSeleccionarSintomas.Name = "btnSeleccionarSintomas"
        Me.btnSeleccionarSintomas.Size = New System.Drawing.Size(458, 92)
        Me.btnSeleccionarSintomas.TabIndex = 0
        Me.btnSeleccionarSintomas.Text = "Consulta médica"
        Me.btnSeleccionarSintomas.UseVisualStyleBackColor = False
        '
        'btnHistorialChats
        '
        Me.btnHistorialChats.BackColor = System.Drawing.Color.SkyBlue
        Me.btnHistorialChats.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHistorialChats.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorialChats.ForeColor = System.Drawing.Color.Snow
        Me.btnHistorialChats.Location = New System.Drawing.Point(0, 161)
        Me.btnHistorialChats.Name = "btnHistorialChats"
        Me.btnHistorialChats.Size = New System.Drawing.Size(239, 110)
        Me.btnHistorialChats.TabIndex = 1
        Me.btnHistorialChats.Text = "Historial de chats"
        Me.btnHistorialChats.UseVisualStyleBackColor = False
        '
        'btnModificarDatos
        '
        Me.btnModificarDatos.BackColor = System.Drawing.Color.SkyBlue
        Me.btnModificarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificarDatos.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarDatos.ForeColor = System.Drawing.Color.Snow
        Me.btnModificarDatos.Location = New System.Drawing.Point(242, 161)
        Me.btnModificarDatos.Name = "btnModificarDatos"
        Me.btnModificarDatos.Size = New System.Drawing.Size(216, 110)
        Me.btnModificarDatos.TabIndex = 2
        Me.btnModificarDatos.Text = "Modificar datos personales"
        Me.btnModificarDatos.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.CapaPaciente.My.Resources.Resources.FondoLogin
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 72)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.CapaPaciente.My.Resources.Resources.Logo_2_sin_fondo
        Me.PictureBox1.Location = New System.Drawing.Point(366, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
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
        'VentanaMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(458, 271)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnModificarDatos)
        Me.Controls.Add(Me.btnHistorialChats)
        Me.Controls.Add(Me.btnSeleccionarSintomas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "VentanaMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSeleccionarSintomas As Button
    Friend WithEvents btnHistorialChats As Button
    Friend WithEvents btnModificarDatos As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
