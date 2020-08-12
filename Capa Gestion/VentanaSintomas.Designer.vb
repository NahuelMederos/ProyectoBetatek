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
        Me.btnAgregarSintoma = New System.Windows.Forms.Button()
        Me.txtIdSintoma = New System.Windows.Forms.TextBox()
        Me.txtNombreSintoma = New System.Windows.Forms.TextBox()
        Me.btnModificarSintoma = New System.Windows.Forms.Button()
        Me.cmbSintoma = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.TablaDeSintomas = New System.Windows.Forms.DataGridView()
        Me.Listar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.TablaDeSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgregarSintoma
        '
        Me.btnAgregarSintoma.Location = New System.Drawing.Point(352, 84)
        Me.btnAgregarSintoma.Name = "btnAgregarSintoma"
        Me.btnAgregarSintoma.Size = New System.Drawing.Size(112, 38)
        Me.btnAgregarSintoma.TabIndex = 0
        Me.btnAgregarSintoma.Text = "Agregar Sintoma"
        Me.btnAgregarSintoma.UseVisualStyleBackColor = True
        '
        'txtIdSintoma
        '
        Me.txtIdSintoma.Location = New System.Drawing.Point(378, 211)
        Me.txtIdSintoma.Name = "txtIdSintoma"
        Me.txtIdSintoma.ReadOnly = True
        Me.txtIdSintoma.Size = New System.Drawing.Size(52, 20)
        Me.txtIdSintoma.TabIndex = 1
        '
        'txtNombreSintoma
        '
        Me.txtNombreSintoma.Location = New System.Drawing.Point(354, 262)
        Me.txtNombreSintoma.Name = "txtNombreSintoma"
        Me.txtNombreSintoma.Size = New System.Drawing.Size(110, 20)
        Me.txtNombreSintoma.TabIndex = 2
        '
        'btnModificarSintoma
        '
        Me.btnModificarSintoma.Location = New System.Drawing.Point(352, 143)
        Me.btnModificarSintoma.Name = "btnModificarSintoma"
        Me.btnModificarSintoma.Size = New System.Drawing.Size(112, 38)
        Me.btnModificarSintoma.TabIndex = 3
        Me.btnModificarSintoma.Text = "Modificar Sintoma"
        Me.btnModificarSintoma.UseVisualStyleBackColor = True
        '
        'cmbSintoma
        '
        Me.cmbSintoma.FormattingEnabled = True
        Me.cmbSintoma.Items.AddRange(New Object() {"Alta", "Media", "Baja"})
        Me.cmbSintoma.Location = New System.Drawing.Point(354, 309)
        Me.cmbSintoma.Name = "cmbSintoma"
        Me.cmbSintoma.Size = New System.Drawing.Size(110, 21)
        Me.cmbSintoma.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(354, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(354, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Prioridad"
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(352, 28)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(110, 35)
        Me.BtnBorrar.TabIndex = 9
        Me.BtnBorrar.Text = "Borrar Sintoma"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'TablaDeSintomas
        '
        Me.TablaDeSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDeSintomas.Location = New System.Drawing.Point(12, 12)
        Me.TablaDeSintomas.Name = "TablaDeSintomas"
        Me.TablaDeSintomas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TablaDeSintomas.Size = New System.Drawing.Size(315, 315)
        Me.TablaDeSintomas.TabIndex = 10
        '
        'Listar
        '
        Me.Listar.Location = New System.Drawing.Point(12, 333)
        Me.Listar.Name = "Listar"
        Me.Listar.Size = New System.Drawing.Size(75, 23)
        Me.Listar.TabIndex = 11
        Me.Listar.Text = "Listar"
        Me.Listar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(419, 333)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(45, 23)
        Me.btnVolver.TabIndex = 24
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'VentanaSintomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 361)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Listar)
        Me.Controls.Add(Me.TablaDeSintomas)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbSintoma)
        Me.Controls.Add(Me.btnModificarSintoma)
        Me.Controls.Add(Me.txtNombreSintoma)
        Me.Controls.Add(Me.txtIdSintoma)
        Me.Controls.Add(Me.btnAgregarSintoma)
        Me.Name = "VentanaSintomas"
        Me.Text = "VentanaSintomas"
        CType(Me.TablaDeSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgregarSintoma As Button
    Friend WithEvents txtIdSintoma As TextBox
    Friend WithEvents txtNombreSintoma As TextBox
    Friend WithEvents btnModificarSintoma As Button
    Friend WithEvents cmbSintoma As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents TablaDeSintomas As DataGridView
    Friend WithEvents Listar As Button
    Friend WithEvents btnVolver As Button
End Class
