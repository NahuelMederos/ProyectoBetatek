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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ListarPat = New System.Windows.Forms.Button()
        Me.cmbPatologia = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MensajesNuevos = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNombrePatologia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdPatologia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnModificarPatologia = New System.Windows.Forms.Button()
        Me.btnAgregarPatologia = New System.Windows.Forms.Button()
        Me.BtnBorrarPat = New System.Windows.Forms.Button()
        Me.TablaDePatologias = New System.Windows.Forms.DataGridView()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtRutaCsv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.TablaDePatologias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListarPat
        '
        Me.ListarPat.Enabled = False
        Me.ListarPat.Location = New System.Drawing.Point(1, 149)
        Me.ListarPat.Name = "ListarPat"
        Me.ListarPat.Size = New System.Drawing.Size(10, 23)
        Me.ListarPat.TabIndex = 22
        Me.ListarPat.Text = "Listar"
        Me.ListarPat.UseVisualStyleBackColor = True
        Me.ListarPat.Visible = False
        '
        'cmbPatologia
        '
        Me.cmbPatologia.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.cmbPatologia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPatologia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbPatologia.ForeColor = System.Drawing.Color.White
        Me.cmbPatologia.FormattingEnabled = True
        Me.cmbPatologia.Items.AddRange(New Object() {"Alta", "Media", "Baja"})
        Me.cmbPatologia.Location = New System.Drawing.Point(232, 297)
        Me.cmbPatologia.Name = "cmbPatologia"
        Me.cmbPatologia.Size = New System.Drawing.Size(110, 21)
        Me.cmbPatologia.TabIndex = 16
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MensajesNuevos
        '
        Me.MensajesNuevos.AutoSize = True
        Me.MensajesNuevos.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MensajesNuevos.ForeColor = System.Drawing.Color.White
        Me.MensajesNuevos.Location = New System.Drawing.Point(9, 325)
        Me.MensajesNuevos.Name = "MensajesNuevos"
        Me.MensajesNuevos.Size = New System.Drawing.Size(122, 15)
        Me.MensajesNuevos.TabIndex = 71
        Me.MensajesNuevos.Text = "Ingresar archivo .csv" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.MensajesNuevos.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(236, 207)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(30, 1)
        Me.Panel2.TabIndex = 70
        '
        'txtNombrePatologia
        '
        Me.txtNombrePatologia.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtNombrePatologia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombrePatologia.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePatologia.ForeColor = System.Drawing.Color.White
        Me.txtNombrePatologia.Location = New System.Drawing.Point(233, 240)
        Me.txtNombrePatologia.Name = "txtNombrePatologia"
        Me.txtNombrePatologia.Size = New System.Drawing.Size(86, 19)
        Me.txtNombrePatologia.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(230, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Nombre"
        '
        'txtIdPatologia
        '
        Me.txtIdPatologia.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtIdPatologia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdPatologia.Enabled = False
        Me.txtIdPatologia.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdPatologia.ForeColor = System.Drawing.Color.White
        Me.txtIdPatologia.Location = New System.Drawing.Point(236, 189)
        Me.txtIdPatologia.Name = "txtIdPatologia"
        Me.txtIdPatologia.Size = New System.Drawing.Size(30, 19)
        Me.txtIdPatologia.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Location = New System.Drawing.Point(233, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 15)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "ID"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(233, 259)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(86, 1)
        Me.Panel3.TabIndex = 69
        '
        'btnModificarPatologia
        '
        Me.btnModificarPatologia.BackColor = System.Drawing.Color.SkyBlue
        Me.btnModificarPatologia.FlatAppearance.BorderSize = 0
        Me.btnModificarPatologia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificarPatologia.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPatologia.ForeColor = System.Drawing.SystemColors.Control
        Me.btnModificarPatologia.Location = New System.Drawing.Point(233, 116)
        Me.btnModificarPatologia.Name = "btnModificarPatologia"
        Me.btnModificarPatologia.Size = New System.Drawing.Size(109, 46)
        Me.btnModificarPatologia.TabIndex = 64
        Me.btnModificarPatologia.Text = "Modificar patologia"
        Me.btnModificarPatologia.UseVisualStyleBackColor = False
        '
        'btnAgregarPatologia
        '
        Me.btnAgregarPatologia.BackColor = System.Drawing.Color.SkyBlue
        Me.btnAgregarPatologia.FlatAppearance.BorderSize = 0
        Me.btnAgregarPatologia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregarPatologia.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPatologia.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregarPatologia.Location = New System.Drawing.Point(233, 64)
        Me.btnAgregarPatologia.Name = "btnAgregarPatologia"
        Me.btnAgregarPatologia.Size = New System.Drawing.Size(109, 46)
        Me.btnAgregarPatologia.TabIndex = 63
        Me.btnAgregarPatologia.Text = "Agregar patologia"
        Me.btnAgregarPatologia.UseVisualStyleBackColor = False
        '
        'BtnBorrarPat
        '
        Me.BtnBorrarPat.BackColor = System.Drawing.Color.SkyBlue
        Me.BtnBorrarPat.FlatAppearance.BorderSize = 0
        Me.BtnBorrarPat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBorrarPat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrarPat.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnBorrarPat.Location = New System.Drawing.Point(233, 12)
        Me.BtnBorrarPat.Name = "BtnBorrarPat"
        Me.BtnBorrarPat.Size = New System.Drawing.Size(109, 46)
        Me.BtnBorrarPat.TabIndex = 62
        Me.BtnBorrarPat.Text = "Baja patologia"
        Me.BtnBorrarPat.UseVisualStyleBackColor = False
        '
        'TablaDePatologias
        '
        Me.TablaDePatologias.AllowUserToAddRows = False
        Me.TablaDePatologias.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablaDePatologias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.TablaDePatologias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.TablaDePatologias.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaDePatologias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.TablaDePatologias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDePatologias.EnableHeadersVisualStyles = False
        Me.TablaDePatologias.GridColor = System.Drawing.Color.SteelBlue
        Me.TablaDePatologias.Location = New System.Drawing.Point(12, 12)
        Me.TablaDePatologias.Name = "TablaDePatologias"
        Me.TablaDePatologias.ReadOnly = True
        Me.TablaDePatologias.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.TablaDePatologias.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.TablaDePatologias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaDePatologias.Size = New System.Drawing.Size(212, 310)
        Me.TablaDePatologias.TabIndex = 61
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.SkyBlue
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(311, 348)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(31, 20)
        Me.btnOk.TabIndex = 60
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.SkyBlue
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(12, 347)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 21)
        Me.btnBuscar.TabIndex = 59
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtRutaCsv
        '
        Me.txtRutaCsv.Location = New System.Drawing.Point(91, 347)
        Me.txtRutaCsv.Name = "txtRutaCsv"
        Me.txtRutaCsv.Size = New System.Drawing.Size(214, 20)
        Me.txtRutaCsv.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(233, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Prioridad"
        '
        'VentanaPatologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(354, 380)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MensajesNuevos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtNombrePatologia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdPatologia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnModificarPatologia)
        Me.Controls.Add(Me.btnAgregarPatologia)
        Me.Controls.Add(Me.BtnBorrarPat)
        Me.Controls.Add(Me.TablaDePatologias)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtRutaCsv)
        Me.Controls.Add(Me.ListarPat)
        Me.Controls.Add(Me.cmbPatologia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "VentanaPatologia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Patologias"
        CType(Me.TablaDePatologias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListarPat As Button
    Friend WithEvents cmbPatologia As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MensajesNuevos As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtNombrePatologia As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdPatologia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnModificarPatologia As Button
    Friend WithEvents btnAgregarPatologia As Button
    Friend WithEvents BtnBorrarPat As Button
    Friend WithEvents TablaDePatologias As DataGridView
    Friend WithEvents btnOk As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtRutaCsv As TextBox
    Friend WithEvents Label2 As Label
End Class
