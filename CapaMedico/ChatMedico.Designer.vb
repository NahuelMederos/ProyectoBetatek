<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChatMedico
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
        Me.btnChatCompleto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(491, 27)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(719, 336)
        Me.WebBrowser1.TabIndex = 42
        '
        'btnIniciarChat
        '
        Me.btnIniciarChat.Location = New System.Drawing.Point(90, 461)
        Me.btnIniciarChat.Name = "btnIniciarChat"
        Me.btnIniciarChat.Size = New System.Drawing.Size(100, 23)
        Me.btnIniciarChat.TabIndex = 41
        Me.btnIniciarChat.Text = "Iniciar Chat"
        Me.btnIniciarChat.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 435)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Sesion"
        '
        'txtSesion
        '
        Me.txtSesion.Enabled = False
        Me.txtSesion.Location = New System.Drawing.Point(90, 435)
        Me.txtSesion.Name = "txtSesion"
        Me.txtSesion.Size = New System.Drawing.Size(100, 20)
        Me.txtSesion.TabIndex = 39
        '
        'lblPara
        '
        Me.lblPara.AutoSize = True
        Me.lblPara.Location = New System.Drawing.Point(47, 409)
        Me.lblPara.Name = "lblPara"
        Me.lblPara.Size = New System.Drawing.Size(29, 13)
        Me.lblPara.TabIndex = 38
        Me.lblPara.Text = "Para"
        '
        'txtPara
        '
        Me.txtPara.Enabled = False
        Me.txtPara.Location = New System.Drawing.Point(90, 409)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(100, 20)
        Me.txtPara.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 383)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Id"
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(90, 383)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 33
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Enabled = False
        Me.BtnEnviar.ForeColor = System.Drawing.Color.Red
        Me.BtnEnviar.Location = New System.Drawing.Point(665, 497)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(98, 57)
        Me.BtnEnviar.TabIndex = 32
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'RTxtMensaje
        '
        Me.RTxtMensaje.Location = New System.Drawing.Point(491, 403)
        Me.RTxtMensaje.Name = "RTxtMensaje"
        Me.RTxtMensaje.Size = New System.Drawing.Size(701, 88)
        Me.RTxtMensaje.TabIndex = 31
        Me.RTxtMensaje.Text = ""
        '
        'RTxtChat
        '
        Me.RTxtChat.Location = New System.Drawing.Point(212, 96)
        Me.RTxtChat.Name = "RTxtChat"
        Me.RTxtChat.Size = New System.Drawing.Size(233, 267)
        Me.RTxtChat.TabIndex = 30
        Me.RTxtChat.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'btnChatCompleto
        '
        Me.btnChatCompleto.Location = New System.Drawing.Point(977, 510)
        Me.btnChatCompleto.Name = "btnChatCompleto"
        Me.btnChatCompleto.Size = New System.Drawing.Size(75, 44)
        Me.btnChatCompleto.TabIndex = 43
        Me.btnChatCompleto.Text = "Ver chat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "completo"
        Me.btnChatCompleto.UseVisualStyleBackColor = True
        '
        'ChatMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 644)
        Me.Controls.Add(Me.btnChatCompleto)
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
        Me.Name = "ChatMedico"
        Me.Text = "Form1"
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
    Friend WithEvents btnChatCompleto As Button
End Class
