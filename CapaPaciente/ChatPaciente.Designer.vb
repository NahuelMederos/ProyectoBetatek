<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChatPaciente
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
        Me.components = New System.ComponentModel.Container()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btnIniciarChat = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSesion = New System.Windows.Forms.TextBox()
        Me.lblPara = New System.Windows.Forms.Label()
        Me.txtPara = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.RTxtMensaje = New System.Windows.Forms.RichTextBox()
        Me.RTxtChat = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtDiagnostico = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSintomas = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrioridad = New System.Windows.Forms.TextBox()
        Me.txtIdDiagnostico = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(187, 50)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1010, 336)
        Me.WebBrowser1.TabIndex = 27
        '
        'btnIniciarChat
        '
        Me.btnIniciarChat.Location = New System.Drawing.Point(56, 102)
        Me.btnIniciarChat.Name = "btnIniciarChat"
        Me.btnIniciarChat.Size = New System.Drawing.Size(100, 23)
        Me.btnIniciarChat.TabIndex = 26
        Me.btnIniciarChat.Text = "Iniciar Chat"
        Me.btnIniciarChat.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Sesion"
        '
        'txtSesion
        '
        Me.txtSesion.Enabled = False
        Me.txtSesion.Location = New System.Drawing.Point(56, 76)
        Me.txtSesion.Name = "txtSesion"
        Me.txtSesion.Size = New System.Drawing.Size(100, 20)
        Me.txtSesion.TabIndex = 24
        '
        'lblPara
        '
        Me.lblPara.AutoSize = True
        Me.lblPara.Location = New System.Drawing.Point(13, 53)
        Me.lblPara.Name = "lblPara"
        Me.lblPara.Size = New System.Drawing.Size(29, 13)
        Me.lblPara.TabIndex = 23
        Me.lblPara.Text = "Para"
        '
        'txtPara
        '
        Me.txtPara.Enabled = False
        Me.txtPara.Location = New System.Drawing.Point(56, 50)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(100, 20)
        Me.txtPara.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Id"
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(56, 24)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 18
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Enabled = False
        Me.BtnEnviar.ForeColor = System.Drawing.Color.Red
        Me.BtnEnviar.Location = New System.Drawing.Point(670, 509)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(98, 57)
        Me.BtnEnviar.TabIndex = 17
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'RTxtMensaje
        '
        Me.RTxtMensaje.Location = New System.Drawing.Point(187, 415)
        Me.RTxtMensaje.Name = "RTxtMensaje"
        Me.RTxtMensaje.Size = New System.Drawing.Size(1010, 88)
        Me.RTxtMensaje.TabIndex = 16
        Me.RTxtMensaje.Text = ""
        '
        'RTxtChat
        '
        Me.RTxtChat.Location = New System.Drawing.Point(7, 528)
        Me.RTxtChat.Name = "RTxtChat"
        Me.RTxtChat.Size = New System.Drawing.Size(127, 32)
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
        Me.txtDiagnostico.Location = New System.Drawing.Point(-4, 161)
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.Size = New System.Drawing.Size(138, 56)
        Me.txtDiagnostico.TabIndex = 28
        Me.txtDiagnostico.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-1, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Diagnostico:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-1, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Ingreso los siguientes sintomas"
        '
        'txtSintomas
        '
        Me.txtSintomas.Location = New System.Drawing.Point(2, 244)
        Me.txtSintomas.Name = "txtSintomas"
        Me.txtSintomas.Size = New System.Drawing.Size(138, 47)
        Me.txtSintomas.TabIndex = 30
        Me.txtSintomas.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-1, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Prioridad"
        '
        'txtPrioridad
        '
        Me.txtPrioridad.Location = New System.Drawing.Point(2, 313)
        Me.txtPrioridad.Name = "txtPrioridad"
        Me.txtPrioridad.Size = New System.Drawing.Size(100, 20)
        Me.txtPrioridad.TabIndex = 34
        '
        'txtIdDiagnostico
        '
        Me.txtIdDiagnostico.Location = New System.Drawing.Point(4, 355)
        Me.txtIdDiagnostico.Name = "txtIdDiagnostico"
        Me.txtIdDiagnostico.Size = New System.Drawing.Size(100, 20)
        Me.txtIdDiagnostico.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "IdDiagnostico"
        '
        'ChatPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 579)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtIdDiagnostico)
        Me.Controls.Add(Me.txtPrioridad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSintomas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDiagnostico)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.btnIniciarChat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSesion)
        Me.Controls.Add(Me.lblPara)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.RTxtMensaje)
        Me.Controls.Add(Me.RTxtChat)
        Me.Name = "ChatPaciente"
        Me.Text = "Chat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents btnIniciarChat As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSesion As TextBox
    Friend WithEvents lblPara As Label
    Friend WithEvents txtPara As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents RTxtMensaje As RichTextBox
    Friend WithEvents RTxtChat As RichTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtDiagnostico As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSintomas As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrioridad As TextBox
    Friend WithEvents txtIdDiagnostico As TextBox
    Friend WithEvents Label6 As Label
End Class
