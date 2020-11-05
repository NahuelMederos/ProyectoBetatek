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
        Me.txtSesion = New System.Windows.Forms.TextBox()
        Me.txtPara = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.RTxtMensaje = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDiagnostico = New System.Windows.Forms.RichTextBox()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.btnChatCompleto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 12)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(719, 336)
        Me.WebBrowser1.TabIndex = 42
        '
        'btnIniciarChat
        '
        Me.btnIniciarChat.Enabled = False
        Me.btnIniciarChat.Location = New System.Drawing.Point(1, 114)
        Me.btnIniciarChat.Name = "btnIniciarChat"
        Me.btnIniciarChat.Size = New System.Drawing.Size(10, 23)
        Me.btnIniciarChat.TabIndex = 41
        Me.btnIniciarChat.Text = "Iniciar Chat"
        Me.btnIniciarChat.UseVisualStyleBackColor = True
        Me.btnIniciarChat.Visible = False
        '
        'txtSesion
        '
        Me.txtSesion.Enabled = False
        Me.txtSesion.Location = New System.Drawing.Point(1, 88)
        Me.txtSesion.Name = "txtSesion"
        Me.txtSesion.Size = New System.Drawing.Size(10, 20)
        Me.txtSesion.TabIndex = 39
        Me.txtSesion.Visible = False
        '
        'txtPara
        '
        Me.txtPara.Enabled = False
        Me.txtPara.Location = New System.Drawing.Point(1, 62)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(10, 20)
        Me.txtPara.TabIndex = 37
        Me.txtPara.Visible = False
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(1, 36)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(10, 20)
        Me.TxtId.TabIndex = 33
        Me.TxtId.Visible = False
        '
        'RTxtMensaje
        '
        Me.RTxtMensaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RTxtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTxtMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RTxtMensaje.ForeColor = System.Drawing.Color.White
        Me.RTxtMensaje.Location = New System.Drawing.Point(12, 366)
        Me.RTxtMensaje.Name = "RTxtMensaje"
        Me.RTxtMensaje.Size = New System.Drawing.Size(719, 88)
        Me.RTxtMensaje.TabIndex = 31
        Me.RTxtMensaje.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(749, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 26)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Diagnóstico"
        '
        'txtDiagnostico
        '
        Me.txtDiagnostico.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDiagnostico.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiagnostico.ForeColor = System.Drawing.Color.Snow
        Me.txtDiagnostico.Location = New System.Drawing.Point(754, 39)
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.Size = New System.Drawing.Size(217, 141)
        Me.txtDiagnostico.TabIndex = 45
        Me.txtDiagnostico.Text = ""
        '
        'BtnEnviar
        '
        Me.BtnEnviar.BackColor = System.Drawing.Color.SkyBlue
        Me.BtnEnviar.FlatAppearance.BorderSize = 0
        Me.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEnviar.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnviar.ForeColor = System.Drawing.Color.LightSlateGray
        Me.BtnEnviar.Location = New System.Drawing.Point(737, 366)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(234, 88)
        Me.BtnEnviar.TabIndex = 46
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = False
        '
        'btnChatCompleto
        '
        Me.btnChatCompleto.BackColor = System.Drawing.Color.SkyBlue
        Me.btnChatCompleto.FlatAppearance.BorderSize = 0
        Me.btnChatCompleto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChatCompleto.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChatCompleto.ForeColor = System.Drawing.Color.LightSlateGray
        Me.btnChatCompleto.Location = New System.Drawing.Point(737, 308)
        Me.btnChatCompleto.Name = "btnChatCompleto"
        Me.btnChatCompleto.Size = New System.Drawing.Size(234, 40)
        Me.btnChatCompleto.TabIndex = 47
        Me.btnChatCompleto.Text = "Ver chat completo"
        Me.btnChatCompleto.UseVisualStyleBackColor = False
        '
        'ChatMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(983, 464)
        Me.Controls.Add(Me.btnChatCompleto)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.txtDiagnostico)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.btnIniciarChat)
        Me.Controls.Add(Me.txtSesion)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.RTxtMensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ChatMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Chat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIniciarChat As Button
    Friend WithEvents txtSesion As TextBox
    Friend WithEvents txtPara As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents RTxtMensaje As RichTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDiagnostico As RichTextBox
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents btnChatCompleto As Button
End Class
