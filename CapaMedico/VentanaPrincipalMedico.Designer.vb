<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaPrincipalMedico
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TablaDeDiagnosticos = New System.Windows.Forms.DataGridView()
        Me.txtIdDiagnostico = New System.Windows.Forms.TextBox()
        Me.txtCiPersona = New System.Windows.Forms.TextBox()
        Me.txtContar = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MensajesNuevos = New System.Windows.Forms.Label()
        Me.txtContar2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHistorialChats = New System.Windows.Forms.Button()
        Me.btnVerSolicitudes = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.txtDiagnostico = New System.Windows.Forms.RichTextBox()
        CType(Me.TablaDeDiagnosticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TablaDeDiagnosticos
        '
        Me.TablaDeDiagnosticos.AllowUserToAddRows = False
        Me.TablaDeDiagnosticos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablaDeDiagnosticos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TablaDeDiagnosticos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.TablaDeDiagnosticos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaDeDiagnosticos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TablaDeDiagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDeDiagnosticos.EnableHeadersVisualStyles = False
        Me.TablaDeDiagnosticos.GridColor = System.Drawing.Color.SteelBlue
        Me.TablaDeDiagnosticos.Location = New System.Drawing.Point(17, 53)
        Me.TablaDeDiagnosticos.Name = "TablaDeDiagnosticos"
        Me.TablaDeDiagnosticos.ReadOnly = True
        Me.TablaDeDiagnosticos.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.TablaDeDiagnosticos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.TablaDeDiagnosticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaDeDiagnosticos.Size = New System.Drawing.Size(705, 368)
        Me.TablaDeDiagnosticos.TabIndex = 2
        '
        'txtIdDiagnostico
        '
        Me.txtIdDiagnostico.Location = New System.Drawing.Point(1, 310)
        Me.txtIdDiagnostico.Name = "txtIdDiagnostico"
        Me.txtIdDiagnostico.ReadOnly = True
        Me.txtIdDiagnostico.Size = New System.Drawing.Size(10, 20)
        Me.txtIdDiagnostico.TabIndex = 3
        Me.txtIdDiagnostico.Visible = False
        '
        'txtCiPersona
        '
        Me.txtCiPersona.Location = New System.Drawing.Point(1, 232)
        Me.txtCiPersona.Name = "txtCiPersona"
        Me.txtCiPersona.ReadOnly = True
        Me.txtCiPersona.Size = New System.Drawing.Size(10, 20)
        Me.txtCiPersona.TabIndex = 4
        Me.txtCiPersona.Visible = False
        '
        'txtContar
        '
        Me.txtContar.Location = New System.Drawing.Point(1, 284)
        Me.txtContar.Name = "txtContar"
        Me.txtContar.ReadOnly = True
        Me.txtContar.Size = New System.Drawing.Size(10, 20)
        Me.txtContar.TabIndex = 5
        Me.txtContar.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'MensajesNuevos
        '
        Me.MensajesNuevos.AutoSize = True
        Me.MensajesNuevos.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MensajesNuevos.ForeColor = System.Drawing.Color.Red
        Me.MensajesNuevos.Location = New System.Drawing.Point(507, 427)
        Me.MensajesNuevos.Name = "MensajesNuevos"
        Me.MensajesNuevos.Size = New System.Drawing.Size(76, 30)
        Me.MensajesNuevos.TabIndex = 6
        Me.MensajesNuevos.Text = "*Hay nuevas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "solicitudes"
        Me.MensajesNuevos.Visible = False
        '
        'txtContar2
        '
        Me.txtContar2.Location = New System.Drawing.Point(1, 258)
        Me.txtContar2.Name = "txtContar2"
        Me.txtContar2.ReadOnly = True
        Me.txtContar2.Size = New System.Drawing.Size(10, 20)
        Me.txtContar2.TabIndex = 7
        Me.txtContar2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 26)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Lista de solicitudes"
        '
        'btnHistorialChats
        '
        Me.btnHistorialChats.BackColor = System.Drawing.Color.SkyBlue
        Me.btnHistorialChats.FlatAppearance.BorderSize = 0
        Me.btnHistorialChats.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHistorialChats.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorialChats.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHistorialChats.Location = New System.Drawing.Point(17, 427)
        Me.btnHistorialChats.Name = "btnHistorialChats"
        Me.btnHistorialChats.Size = New System.Drawing.Size(155, 48)
        Me.btnHistorialChats.TabIndex = 42
        Me.btnHistorialChats.Text = "Historial de chats antiguos"
        Me.btnHistorialChats.UseVisualStyleBackColor = False
        '
        'btnVerSolicitudes
        '
        Me.btnVerSolicitudes.BackColor = System.Drawing.Color.SkyBlue
        Me.btnVerSolicitudes.FlatAppearance.BorderSize = 0
        Me.btnVerSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVerSolicitudes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerSolicitudes.ForeColor = System.Drawing.SystemColors.Control
        Me.btnVerSolicitudes.Location = New System.Drawing.Point(589, 427)
        Me.btnVerSolicitudes.Name = "btnVerSolicitudes"
        Me.btnVerSolicitudes.Size = New System.Drawing.Size(155, 48)
        Me.btnVerSolicitudes.TabIndex = 43
        Me.btnVerSolicitudes.Text = "Actualizar solicitudes"
        Me.btnVerSolicitudes.UseVisualStyleBackColor = False
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSeleccionar.FlatAppearance.BorderSize = 0
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSeleccionar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSeleccionar.Location = New System.Drawing.Point(295, 427)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(155, 48)
        Me.btnSeleccionar.TabIndex = 44
        Me.btnSeleccionar.Text = "Seleccionar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'txtDiagnostico
        '
        Me.txtDiagnostico.Location = New System.Drawing.Point(1, 336)
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.ReadOnly = True
        Me.txtDiagnostico.Size = New System.Drawing.Size(10, 16)
        Me.txtDiagnostico.TabIndex = 45
        Me.txtDiagnostico.Text = ""
        Me.txtDiagnostico.Visible = False
        '
        'VentanaPrincipalMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(747, 482)
        Me.Controls.Add(Me.txtDiagnostico)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.btnVerSolicitudes)
        Me.Controls.Add(Me.btnHistorialChats)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtContar2)
        Me.Controls.Add(Me.MensajesNuevos)
        Me.Controls.Add(Me.txtContar)
        Me.Controls.Add(Me.txtCiPersona)
        Me.Controls.Add(Me.txtIdDiagnostico)
        Me.Controls.Add(Me.TablaDeDiagnosticos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "VentanaPrincipalMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitudes de chat"
        CType(Me.TablaDeDiagnosticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TablaDeDiagnosticos As DataGridView
    Friend WithEvents txtIdDiagnostico As TextBox
    Friend WithEvents txtCiPersona As TextBox
    Friend WithEvents txtContar As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MensajesNuevos As Label
    Friend WithEvents txtContar2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHistorialChats As Button
    Friend WithEvents btnVerSolicitudes As Button
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents txtDiagnostico As RichTextBox
End Class
