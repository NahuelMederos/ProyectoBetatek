<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaPatologia
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
        Me.ListarPat = New System.Windows.Forms.Button()
        Me.TablaDePatologias = New System.Windows.Forms.DataGridView()
        Me.BtnBorrarPat = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbPatologia = New System.Windows.Forms.ComboBox()
        Me.btnModificarPatologia = New System.Windows.Forms.Button()
        Me.txtNombrePatologia = New System.Windows.Forms.TextBox()
        Me.txtIdPatologia = New System.Windows.Forms.TextBox()
        Me.btnAgregarPatologia = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtRutaCsv = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TablaDePatologias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListarPat
        '
        Me.ListarPat.Enabled = False
        Me.ListarPat.Location = New System.Drawing.Point(442, 205)
        Me.ListarPat.Name = "ListarPat"
        Me.ListarPat.Size = New System.Drawing.Size(21, 23)
        Me.ListarPat.TabIndex = 22
        Me.ListarPat.Text = "Listar"
        Me.ListarPat.UseVisualStyleBackColor = True
        Me.ListarPat.Visible = False
        '
        'TablaDePatologias
        '
        Me.TablaDePatologias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDePatologias.Location = New System.Drawing.Point(11, 8)
        Me.TablaDePatologias.Name = "TablaDePatologias"
        Me.TablaDePatologias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TablaDePatologias.Size = New System.Drawing.Size(315, 315)
        Me.TablaDePatologias.TabIndex = 21
        '
        'BtnBorrarPat
        '
        Me.BtnBorrarPat.Location = New System.Drawing.Point(351, 24)
        Me.BtnBorrarPat.Name = "BtnBorrarPat"
        Me.BtnBorrarPat.Size = New System.Drawing.Size(110, 35)
        Me.BtnBorrarPat.TabIndex = 20
        Me.BtnBorrarPat.Text = "Borrar Patologia"
        Me.BtnBorrarPat.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(353, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Prioridad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(353, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(353, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nombre"
        '
        'cmbPatologia
        '
        Me.cmbPatologia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPatologia.FormattingEnabled = True
        Me.cmbPatologia.Items.AddRange(New Object() {"Alta", "Media", "Baja"})
        Me.cmbPatologia.Location = New System.Drawing.Point(353, 305)
        Me.cmbPatologia.Name = "cmbPatologia"
        Me.cmbPatologia.Size = New System.Drawing.Size(110, 21)
        Me.cmbPatologia.TabIndex = 16
        '
        'btnModificarPatologia
        '
        Me.btnModificarPatologia.Location = New System.Drawing.Point(351, 139)
        Me.btnModificarPatologia.Name = "btnModificarPatologia"
        Me.btnModificarPatologia.Size = New System.Drawing.Size(112, 38)
        Me.btnModificarPatologia.TabIndex = 15
        Me.btnModificarPatologia.Text = "Modificar Patologia"
        Me.btnModificarPatologia.UseVisualStyleBackColor = True
        '
        'txtNombrePatologia
        '
        Me.txtNombrePatologia.Location = New System.Drawing.Point(353, 258)
        Me.txtNombrePatologia.MaxLength = 30
        Me.txtNombrePatologia.Name = "txtNombrePatologia"
        Me.txtNombrePatologia.Size = New System.Drawing.Size(110, 20)
        Me.txtNombrePatologia.TabIndex = 14
        '
        'txtIdPatologia
        '
        Me.txtIdPatologia.Location = New System.Drawing.Point(377, 207)
        Me.txtIdPatologia.Name = "txtIdPatologia"
        Me.txtIdPatologia.ReadOnly = True
        Me.txtIdPatologia.Size = New System.Drawing.Size(52, 20)
        Me.txtIdPatologia.TabIndex = 13
        '
        'btnAgregarPatologia
        '
        Me.btnAgregarPatologia.Location = New System.Drawing.Point(351, 80)
        Me.btnAgregarPatologia.Name = "btnAgregarPatologia"
        Me.btnAgregarPatologia.Size = New System.Drawing.Size(112, 38)
        Me.btnAgregarPatologia.TabIndex = 12
        Me.btnAgregarPatologia.Text = "Agregar Patologia"
        Me.btnAgregarPatologia.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtRutaCsv
        '
        Me.txtRutaCsv.Location = New System.Drawing.Point(90, 352)
        Me.txtRutaCsv.Name = "txtRutaCsv"
        Me.txtRutaCsv.Size = New System.Drawing.Size(236, 20)
        Me.txtRutaCsv.TabIndex = 23
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(11, 352)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 21)
        Me.btnBuscar.TabIndex = 24
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(332, 352)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(31, 20)
        Me.btnOk.TabIndex = 25
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Ingresar archivo .csv"
        '
        'VentanaPatologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 380)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtRutaCsv)
        Me.Controls.Add(Me.ListarPat)
        Me.Controls.Add(Me.TablaDePatologias)
        Me.Controls.Add(Me.BtnBorrarPat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbPatologia)
        Me.Controls.Add(Me.btnModificarPatologia)
        Me.Controls.Add(Me.txtNombrePatologia)
        Me.Controls.Add(Me.txtIdPatologia)
        Me.Controls.Add(Me.btnAgregarPatologia)
        Me.Name = "VentanaPatologia"
        Me.Text = "VentanaPatologia"
        CType(Me.TablaDePatologias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListarPat As Button
    Friend WithEvents TablaDePatologias As DataGridView
    Friend WithEvents BtnBorrarPat As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbPatologia As ComboBox
    Friend WithEvents btnModificarPatologia As Button
    Friend WithEvents txtNombrePatologia As TextBox
    Friend WithEvents txtIdPatologia As TextBox
    Friend WithEvents btnAgregarPatologia As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtRutaCsv As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents Label1 As Label
End Class
