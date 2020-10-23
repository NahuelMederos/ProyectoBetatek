<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaMedico
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
        Me.btnVerSolicitudes = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.TablaDeDiagnosticos = New System.Windows.Forms.DataGridView()
        Me.txtIdDiagnostico = New System.Windows.Forms.TextBox()
        Me.txtCiPersona = New System.Windows.Forms.TextBox()
        Me.txtContar = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MensajesNuevos = New System.Windows.Forms.Label()
        Me.txtContar2 = New System.Windows.Forms.TextBox()
        CType(Me.TablaDeDiagnosticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVerSolicitudes
        '
        Me.btnVerSolicitudes.Location = New System.Drawing.Point(687, 508)
        Me.btnVerSolicitudes.Name = "btnVerSolicitudes"
        Me.btnVerSolicitudes.Size = New System.Drawing.Size(75, 45)
        Me.btnVerSolicitudes.TabIndex = 0
        Me.btnVerSolicitudes.Text = "Actualizar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "solicitudes"
        Me.btnVerSolicitudes.UseVisualStyleBackColor = True
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(54, 530)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccionar.TabIndex = 1
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'TablaDeDiagnosticos
        '
        Me.TablaDeDiagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDeDiagnosticos.Location = New System.Drawing.Point(12, 53)
        Me.TablaDeDiagnosticos.Name = "TablaDeDiagnosticos"
        Me.TablaDeDiagnosticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaDeDiagnosticos.Size = New System.Drawing.Size(787, 368)
        Me.TablaDeDiagnosticos.TabIndex = 2
        '
        'txtIdDiagnostico
        '
        Me.txtIdDiagnostico.Location = New System.Drawing.Point(69, 456)
        Me.txtIdDiagnostico.Name = "txtIdDiagnostico"
        Me.txtIdDiagnostico.Size = New System.Drawing.Size(35, 20)
        Me.txtIdDiagnostico.TabIndex = 3
        '
        'txtCiPersona
        '
        Me.txtCiPersona.Location = New System.Drawing.Point(183, 455)
        Me.txtCiPersona.Name = "txtCiPersona"
        Me.txtCiPersona.Size = New System.Drawing.Size(37, 20)
        Me.txtCiPersona.TabIndex = 4
        '
        'txtContar
        '
        Me.txtContar.Location = New System.Drawing.Point(441, 565)
        Me.txtContar.Name = "txtContar"
        Me.txtContar.Size = New System.Drawing.Size(100, 20)
        Me.txtContar.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'MensajesNuevos
        '
        Me.MensajesNuevos.AutoSize = True
        Me.MensajesNuevos.Location = New System.Drawing.Point(684, 556)
        Me.MensajesNuevos.Name = "MensajesNuevos"
        Me.MensajesNuevos.Size = New System.Drawing.Size(115, 13)
        Me.MensajesNuevos.TabIndex = 6
        Me.MensajesNuevos.Text = "*Hay mensajes nuevos"
        Me.MensajesNuevos.Visible = False
        '
        'txtContar2
        '
        Me.txtContar2.Location = New System.Drawing.Point(268, 565)
        Me.txtContar2.Name = "txtContar2"
        Me.txtContar2.Size = New System.Drawing.Size(100, 20)
        Me.txtContar2.TabIndex = 7
        '
        'VentanaMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 597)
        Me.Controls.Add(Me.txtContar2)
        Me.Controls.Add(Me.MensajesNuevos)
        Me.Controls.Add(Me.txtContar)
        Me.Controls.Add(Me.txtCiPersona)
        Me.Controls.Add(Me.txtIdDiagnostico)
        Me.Controls.Add(Me.TablaDeDiagnosticos)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.btnVerSolicitudes)
        Me.Name = "VentanaMedico"
        Me.Text = "VentanaMedico"
        CType(Me.TablaDeDiagnosticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVerSolicitudes As Button
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents TablaDeDiagnosticos As DataGridView
    Friend WithEvents txtIdDiagnostico As TextBox
    Friend WithEvents txtCiPersona As TextBox
    Friend WithEvents txtContar As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MensajesNuevos As Label
    Friend WithEvents txtContar2 As TextBox
End Class
