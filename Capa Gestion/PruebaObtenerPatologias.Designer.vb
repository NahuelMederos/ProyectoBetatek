<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaObtener
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
        Me.TablaDeSintomas = New System.Windows.Forms.DataGridView()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.btnListarPatologias = New System.Windows.Forms.Button()
        Me.TablaDePatologias = New System.Windows.Forms.DataGridView()
        Me.txtPrueba = New System.Windows.Forms.RichTextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.TablaDeSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaDePatologias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TablaDeSintomas
        '
        Me.TablaDeSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDeSintomas.Location = New System.Drawing.Point(12, 12)
        Me.TablaDeSintomas.Name = "TablaDeSintomas"
        Me.TablaDeSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaDeSintomas.Size = New System.Drawing.Size(367, 354)
        Me.TablaDeSintomas.TabIndex = 0
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(36, 393)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(75, 23)
        Me.btnListar.TabIndex = 1
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(136, 393)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccionar.TabIndex = 2
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'btnListarPatologias
        '
        Me.btnListarPatologias.Location = New System.Drawing.Point(580, 393)
        Me.btnListarPatologias.Name = "btnListarPatologias"
        Me.btnListarPatologias.Size = New System.Drawing.Size(157, 23)
        Me.btnListarPatologias.TabIndex = 3
        Me.btnListarPatologias.Text = "Listar Patologias"
        Me.btnListarPatologias.UseVisualStyleBackColor = True
        '
        'TablaDePatologias
        '
        Me.TablaDePatologias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDePatologias.Location = New System.Drawing.Point(457, 12)
        Me.TablaDePatologias.Name = "TablaDePatologias"
        Me.TablaDePatologias.Size = New System.Drawing.Size(309, 354)
        Me.TablaDePatologias.TabIndex = 4
        '
        'txtPrueba
        '
        Me.txtPrueba.Location = New System.Drawing.Point(279, 409)
        Me.txtPrueba.Name = "txtPrueba"
        Me.txtPrueba.Size = New System.Drawing.Size(259, 96)
        Me.txtPrueba.TabIndex = 5
        Me.txtPrueba.Text = ""
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(710, 515)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 6
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'VentanaObtener
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 550)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtPrueba)
        Me.Controls.Add(Me.TablaDePatologias)
        Me.Controls.Add(Me.btnListarPatologias)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.TablaDeSintomas)
        Me.Name = "VentanaObtener"
        Me.Text = "PruebaObtenerPatologias"
        CType(Me.TablaDeSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaDePatologias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TablaDeSintomas As DataGridView
    Friend WithEvents btnListar As Button
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents btnListarPatologias As Button
    Friend WithEvents TablaDePatologias As DataGridView
    Friend WithEvents txtPrueba As RichTextBox
    Friend WithEvents btnVolver As Button
End Class
