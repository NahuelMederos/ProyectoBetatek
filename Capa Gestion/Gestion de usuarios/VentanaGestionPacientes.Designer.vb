<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaGestionPacientes
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
        Me.TablaDePacientes = New System.Windows.Forms.DataGridView()
        Me.btnListarPacientes = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregarPaciente = New System.Windows.Forms.Button()
        CType(Me.TablaDePacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TablaDePacientes
        '
        Me.TablaDePacientes.AllowUserToAddRows = False
        Me.TablaDePacientes.AllowUserToDeleteRows = False
        Me.TablaDePacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDePacientes.Location = New System.Drawing.Point(12, 12)
        Me.TablaDePacientes.Name = "TablaDePacientes"
        Me.TablaDePacientes.ReadOnly = True
        Me.TablaDePacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaDePacientes.Size = New System.Drawing.Size(558, 304)
        Me.TablaDePacientes.TabIndex = 0
        '
        'btnListarPacientes
        '
        Me.btnListarPacientes.Enabled = False
        Me.btnListarPacientes.Location = New System.Drawing.Point(0, 222)
        Me.btnListarPacientes.Name = "btnListarPacientes"
        Me.btnListarPacientes.Size = New System.Drawing.Size(10, 23)
        Me.btnListarPacientes.TabIndex = 1
        Me.btnListarPacientes.UseVisualStyleBackColor = True
        Me.btnListarPacientes.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(580, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "CI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(586, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(586, 53)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(94, 20)
        Me.txtNombre.TabIndex = 9
        '
        'txtCi
        '
        Me.txtCi.Location = New System.Drawing.Point(602, 11)
        Me.txtCi.Name = "txtCi"
        Me.txtCi.ReadOnly = True
        Me.txtCi.Size = New System.Drawing.Size(78, 20)
        Me.txtCi.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(583, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Apellido"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(586, 101)
        Me.txtApellido.MaxLength = 30
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(94, 20)
        Me.txtApellido.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(586, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Edad"
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(586, 149)
        Me.txtEdad.MaxLength = 30
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(94, 20)
        Me.txtEdad.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(586, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Mail"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(586, 197)
        Me.txtMail.MaxLength = 30
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(94, 20)
        Me.txtMail.TabIndex = 16
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.Location = New System.Drawing.Point(589, 223)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(87, 23)
        Me.btnModificar.TabIndex = 18
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(589, 252)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 23)
        Me.btnEliminar.TabIndex = 19
        Me.btnEliminar.Text = "Desactivar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregarPaciente
        '
        Me.btnAgregarPaciente.Location = New System.Drawing.Point(589, 281)
        Me.btnAgregarPaciente.Name = "btnAgregarPaciente"
        Me.btnAgregarPaciente.Size = New System.Drawing.Size(87, 35)
        Me.btnAgregarPaciente.TabIndex = 20
        Me.btnAgregarPaciente.Text = "Agregar nuevo paciente"
        Me.btnAgregarPaciente.UseVisualStyleBackColor = True
        '
        'VentanaGestionPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 328)
        Me.Controls.Add(Me.btnAgregarPaciente)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCi)
        Me.Controls.Add(Me.btnListarPacientes)
        Me.Controls.Add(Me.TablaDePacientes)
        Me.Name = "VentanaGestionPacientes"
        Me.Text = "VentanaGestionPacientes"
        CType(Me.TablaDePacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TablaDePacientes As DataGridView
    Friend WithEvents btnListarPacientes As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregarPaciente As Button
End Class
