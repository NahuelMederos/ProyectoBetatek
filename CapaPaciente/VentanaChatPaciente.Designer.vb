<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaChatPaciente
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
        Me.components = New System.ComponentModel.Container()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btnIniciarChat = New System.Windows.Forms.Button()
        Me.txtSesion = New System.Windows.Forms.TextBox()
        Me.txtPara = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.RTxtMensaje = New System.Windows.Forms.RichTextBox()
        Me.RTxtChat = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtDiagnostico = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSintomas = New System.Windows.Forms.RichTextBox()
        Me.txtPrioridad = New System.Windows.Forms.TextBox()
        Me.txtIdDiagnostico = New System.Windows.Forms.TextBox()
        Me.btnTerminarChat = New System.Windows.Forms.Button()
        Me.txtEmisor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(25, 12)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1010, 336)
        Me.WebBrowser1.TabIndex = 27
        '
        'btnIniciarChat
        '
        Me.btnIniciarChat.Enabled = False
        Me.btnIniciarChat.Location = New System.Drawing.Point(9, 375)
        Me.btnIniciarChat.Name = "btnIniciarChat"
        Me.btnIniciarChat.Size = New System.Drawing.Size(10, 23)
        Me.btnIniciarChat.TabIndex = 26
        Me.btnIniciarChat.Text = "Iniciar Chat"
        Me.btnIniciarChat.UseVisualStyleBackColor = True
        Me.btnIniciarChat.Visible = False
        '
        'txtSesion
        '
        Me.txtSesion.Enabled = False
        Me.txtSesion.Location = New System.Drawing.Point(9, 349)
        Me.txtSesion.Name = "txtSesion"
        Me.txtSesion.Size = New System.Drawing.Size(10, 20)
        Me.txtSesion.TabIndex = 24
        Me.txtSesion.Visible = False
        '
        'txtPara
        '
        Me.txtPara.Enabled = False
        Me.txtPara.Location = New System.Drawing.Point(9, 323)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(10, 20)
        Me.txtPara.TabIndex = 22
        Me.txtPara.Visible = False
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(9, 297)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(10, 20)
        Me.TxtId.TabIndex = 18
        Me.TxtId.Visible = False
        '
        'RTxtMensaje
        '
        Me.RTxtMensaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RTxtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTxtMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTxtMensaje.ForeColor = System.Drawing.Color.White
        Me.RTxtMensaje.Location = New System.Drawing.Point(25, 377)
        Me.RTxtMensaje.Name = "RTxtMensaje"
        Me.RTxtMensaje.Size = New System.Drawing.Size(1010, 88)
        Me.RTxtMensaje.TabIndex = 16
        Me.RTxtMensaje.Text = ""
        '
        'RTxtChat
        '
        Me.RTxtChat.Location = New System.Drawing.Point(9, 255)
        Me.RTxtChat.Name = "RTxtChat"
        Me.RTxtChat.ReadOnly = True
        Me.RTxtChat.Size = New System.Drawing.Size(10, 10)
        Me.RTxtChat.TabIndex = 15
        Me.RTxtChat.Text = ""
        Me.RTxtChat.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'txtDiagnostico
        '
        Me.txtDiagnostico.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDiagnostico.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiagnostico.ForeColor = System.Drawing.Color.Snow
        Me.txtDiagnostico.Location = New System.Drawing.Point(12, 516)
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.Size = New System.Drawing.Size(185, 55)
        Me.txtDiagnostico.TabIndex = 28
        Me.txtDiagnostico.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(228, 468)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 46)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Ingreso los siguientes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " síntomas:"
        '
        'txtSintomas
        '
        Me.txtSintomas.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSintomas.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSintomas.ForeColor = System.Drawing.Color.Snow
        Me.txtSintomas.Location = New System.Drawing.Point(232, 516)
        Me.txtSintomas.Name = "txtSintomas"
        Me.txtSintomas.Size = New System.Drawing.Size(166, 55)
        Me.txtSintomas.TabIndex = 30
        Me.txtSintomas.Text = ""
        '
        'txtPrioridad
        '
        Me.txtPrioridad.Enabled = False
        Me.txtPrioridad.Location = New System.Drawing.Point(9, 404)
        Me.txtPrioridad.Name = "txtPrioridad"
        Me.txtPrioridad.Size = New System.Drawing.Size(10, 20)
        Me.txtPrioridad.TabIndex = 34
        Me.txtPrioridad.Visible = False
        '
        'txtIdDiagnostico
        '
        Me.txtIdDiagnostico.Enabled = False
        Me.txtIdDiagnostico.Location = New System.Drawing.Point(9, 271)
        Me.txtIdDiagnostico.Name = "txtIdDiagnostico"
        Me.txtIdDiagnostico.Size = New System.Drawing.Size(10, 20)
        Me.txtIdDiagnostico.TabIndex = 35
        Me.txtIdDiagnostico.Visible = False
        '
        'btnTerminarChat
        '
        Me.btnTerminarChat.BackColor = System.Drawing.Color.IndianRed
        Me.btnTerminarChat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTerminarChat.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerminarChat.Location = New System.Drawing.Point(874, 479)
        Me.btnTerminarChat.Name = "btnTerminarChat"
        Me.btnTerminarChat.Size = New System.Drawing.Size(112, 67)
        Me.btnTerminarChat.TabIndex = 37
        Me.btnTerminarChat.Text = "Terminar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Chat"
        Me.btnTerminarChat.UseVisualStyleBackColor = False
        '
        'txtEmisor
        '
        Me.txtEmisor.Enabled = False
        Me.txtEmisor.Location = New System.Drawing.Point(9, 430)
        Me.txtEmisor.Name = "txtEmisor"
        Me.txtEmisor.Size = New System.Drawing.Size(10, 20)
        Me.txtEmisor.TabIndex = 39
        Me.txtEmisor.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(4, 484)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 26)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Diagnóstico"
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.Color.SkyBlue
        Me.btnEnviar.FlatAppearance.BorderSize = 0
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnviar.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.LightSlateGray
        Me.btnEnviar.Location = New System.Drawing.Point(507, 484)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(138, 52)
        Me.btnEnviar.TabIndex = 41
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(831, 549)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 26)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Si desea enviar la sesión de chat por mail, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "primero deberá terminar el chat."
        '
        'VentanaChatPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1048, 580)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmisor)
        Me.Controls.Add(Me.btnTerminarChat)
        Me.Controls.Add(Me.txtIdDiagnostico)
        Me.Controls.Add(Me.txtPrioridad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSintomas)
        Me.Controls.Add(Me.txtDiagnostico)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.btnIniciarChat)
        Me.Controls.Add(Me.txtSesion)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.RTxtMensaje)
        Me.Controls.Add(Me.RTxtChat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "VentanaChatPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents btnIniciarChat As Button
    Friend WithEvents txtSesion As TextBox
    Friend WithEvents txtPara As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents RTxtMensaje As RichTextBox
    Friend WithEvents RTxtChat As RichTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtDiagnostico As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSintomas As RichTextBox
    Friend WithEvents txtPrioridad As TextBox
    Friend WithEvents txtIdDiagnostico As TextBox
    Friend WithEvents btnTerminarChat As Button
    Friend WithEvents txtEmisor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEnviar As Button
    Friend WithEvents Label2 As Label
End Class
