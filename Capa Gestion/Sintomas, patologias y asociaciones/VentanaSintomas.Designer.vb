<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaSintomas
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Listar = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtRutaCsv = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TablaDeSintomas = New System.Windows.Forms.DataGridView()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.btnAgregarSintoma = New System.Windows.Forms.Button()
        Me.btnModificarSintoma = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNombreSintoma = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdSintoma = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MensajesNuevos = New System.Windows.Forms.Label()
        CType(Me.TablaDeSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Listar
        '
        Me.Listar.Enabled = False
        Me.Listar.Location = New System.Drawing.Point(2, 86)
        Me.Listar.Name = "Listar"
        Me.Listar.Size = New System.Drawing.Size(10, 23)
        Me.Listar.TabIndex = 11
        Me.Listar.UseVisualStyleBackColor = True
        Me.Listar.Visible = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.SkyBlue
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(278, 293)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(31, 20)
        Me.btnOk.TabIndex = 29
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.SkyBlue
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(6, 293)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 21)
        Me.btnBuscar.TabIndex = 28
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtRutaCsv
        '
        Me.txtRutaCsv.Location = New System.Drawing.Point(85, 293)
        Me.txtRutaCsv.Name = "txtRutaCsv"
        Me.txtRutaCsv.Size = New System.Drawing.Size(187, 20)
        Me.txtRutaCsv.TabIndex = 27
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TablaDeSintomas
        '
        Me.TablaDeSintomas.AllowUserToAddRows = False
        Me.TablaDeSintomas.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablaDeSintomas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.TablaDeSintomas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.TablaDeSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaDeSintomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.TablaDeSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDeSintomas.EnableHeadersVisualStyles = False
        Me.TablaDeSintomas.GridColor = System.Drawing.Color.SteelBlue
        Me.TablaDeSintomas.Location = New System.Drawing.Point(18, 12)
        Me.TablaDeSintomas.Name = "TablaDeSintomas"
        Me.TablaDeSintomas.ReadOnly = True
        Me.TablaDeSintomas.RowHeadersVisible = False
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.TablaDeSintomas.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.TablaDeSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaDeSintomas.Size = New System.Drawing.Size(176, 252)
        Me.TablaDeSintomas.TabIndex = 31
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackColor = System.Drawing.Color.SkyBlue
        Me.BtnBorrar.FlatAppearance.BorderSize = 0
        Me.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBorrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnBorrar.Location = New System.Drawing.Point(200, 16)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(109, 46)
        Me.BtnBorrar.TabIndex = 47
        Me.BtnBorrar.Text = "Baja sintoma"
        Me.BtnBorrar.UseVisualStyleBackColor = False
        '
        'btnAgregarSintoma
        '
        Me.btnAgregarSintoma.BackColor = System.Drawing.Color.SkyBlue
        Me.btnAgregarSintoma.FlatAppearance.BorderSize = 0
        Me.btnAgregarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregarSintoma.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarSintoma.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregarSintoma.Location = New System.Drawing.Point(200, 68)
        Me.btnAgregarSintoma.Name = "btnAgregarSintoma"
        Me.btnAgregarSintoma.Size = New System.Drawing.Size(109, 46)
        Me.btnAgregarSintoma.TabIndex = 48
        Me.btnAgregarSintoma.Text = "Agregar sintoma"
        Me.btnAgregarSintoma.UseVisualStyleBackColor = False
        '
        'btnModificarSintoma
        '
        Me.btnModificarSintoma.BackColor = System.Drawing.Color.SkyBlue
        Me.btnModificarSintoma.FlatAppearance.BorderSize = 0
        Me.btnModificarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificarSintoma.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarSintoma.ForeColor = System.Drawing.SystemColors.Control
        Me.btnModificarSintoma.Location = New System.Drawing.Point(200, 120)
        Me.btnModificarSintoma.Name = "btnModificarSintoma"
        Me.btnModificarSintoma.Size = New System.Drawing.Size(109, 46)
        Me.btnModificarSintoma.TabIndex = 49
        Me.btnModificarSintoma.Text = "Modificar sintoma"
        Me.btnModificarSintoma.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(203, 211)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(30, 1)
        Me.Panel2.TabIndex = 55
        '
        'txtNombreSintoma
        '
        Me.txtNombreSintoma.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtNombreSintoma.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreSintoma.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreSintoma.ForeColor = System.Drawing.Color.White
        Me.txtNombreSintoma.Location = New System.Drawing.Point(200, 244)
        Me.txtNombreSintoma.Name = "txtNombreSintoma"
        Me.txtNombreSintoma.Size = New System.Drawing.Size(86, 19)
        Me.txtNombreSintoma.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(197, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Nombre"
        '
        'txtIdSintoma
        '
        Me.txtIdSintoma.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtIdSintoma.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdSintoma.Enabled = False
        Me.txtIdSintoma.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdSintoma.ForeColor = System.Drawing.Color.White
        Me.txtIdSintoma.Location = New System.Drawing.Point(203, 193)
        Me.txtIdSintoma.Name = "txtIdSintoma"
        Me.txtIdSintoma.Size = New System.Drawing.Size(30, 19)
        Me.txtIdSintoma.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Location = New System.Drawing.Point(200, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 15)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "ID"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(200, 263)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(86, 1)
        Me.Panel3.TabIndex = 54
        '
        'MensajesNuevos
        '
        Me.MensajesNuevos.AutoSize = True
        Me.MensajesNuevos.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MensajesNuevos.ForeColor = System.Drawing.Color.White
        Me.MensajesNuevos.Location = New System.Drawing.Point(3, 271)
        Me.MensajesNuevos.Name = "MensajesNuevos"
        Me.MensajesNuevos.Size = New System.Drawing.Size(122, 15)
        Me.MensajesNuevos.TabIndex = 56
        Me.MensajesNuevos.Text = "Ingresar archivo .csv" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.MensajesNuevos.Visible = False
        '
        'VentanaSintomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(313, 326)
        Me.Controls.Add(Me.MensajesNuevos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtNombreSintoma)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtIdSintoma)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnModificarSintoma)
        Me.Controls.Add(Me.btnAgregarSintoma)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.TablaDeSintomas)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtRutaCsv)
        Me.Controls.Add(Me.Listar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "VentanaSintomas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sintomas"
        CType(Me.TablaDeSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Listar As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtRutaCsv As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TablaDeSintomas As DataGridView
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents btnAgregarSintoma As Button
    Friend WithEvents btnModificarSintoma As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtNombreSintoma As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdSintoma As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MensajesNuevos As Label
End Class
