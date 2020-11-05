<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaVerAsociaciones
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtIdA = New System.Windows.Forms.TextBox()
        Me.txtSintA = New System.Windows.Forms.TextBox()
        Me.txtPatA = New System.Windows.Forms.TextBox()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.TablaAsociaciones = New System.Windows.Forms.DataGridView()
        Me.btnBorrarAsociacion = New System.Windows.Forms.Button()
        CType(Me.TablaAsociaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdA
        '
        Me.txtIdA.Enabled = False
        Me.txtIdA.Location = New System.Drawing.Point(281, 181)
        Me.txtIdA.Name = "txtIdA"
        Me.txtIdA.Size = New System.Drawing.Size(10, 20)
        Me.txtIdA.TabIndex = 5
        Me.txtIdA.Visible = False
        '
        'txtSintA
        '
        Me.txtSintA.Enabled = False
        Me.txtSintA.Location = New System.Drawing.Point(281, 155)
        Me.txtSintA.Name = "txtSintA"
        Me.txtSintA.ReadOnly = True
        Me.txtSintA.Size = New System.Drawing.Size(10, 20)
        Me.txtSintA.TabIndex = 6
        Me.txtSintA.Visible = False
        '
        'txtPatA
        '
        Me.txtPatA.Enabled = False
        Me.txtPatA.Location = New System.Drawing.Point(281, 83)
        Me.txtPatA.Name = "txtPatA"
        Me.txtPatA.ReadOnly = True
        Me.txtPatA.Size = New System.Drawing.Size(10, 20)
        Me.txtPatA.TabIndex = 7
        Me.txtPatA.Visible = False
        '
        'btnListar
        '
        Me.btnListar.Enabled = False
        Me.btnListar.Location = New System.Drawing.Point(281, 109)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(10, 40)
        Me.btnListar.TabIndex = 8
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        Me.btnListar.Visible = False
        '
        'TablaAsociaciones
        '
        Me.TablaAsociaciones.AllowUserToAddRows = False
        Me.TablaAsociaciones.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablaAsociaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TablaAsociaciones.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.TablaAsociaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaAsociaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TablaAsociaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaAsociaciones.EnableHeadersVisualStyles = False
        Me.TablaAsociaciones.GridColor = System.Drawing.Color.SteelBlue
        Me.TablaAsociaciones.Location = New System.Drawing.Point(12, 8)
        Me.TablaAsociaciones.Name = "TablaAsociaciones"
        Me.TablaAsociaciones.ReadOnly = True
        Me.TablaAsociaciones.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.TablaAsociaciones.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.TablaAsociaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaAsociaciones.Size = New System.Drawing.Size(263, 297)
        Me.TablaAsociaciones.TabIndex = 9
        '
        'btnBorrarAsociacion
        '
        Me.btnBorrarAsociacion.BackColor = System.Drawing.Color.SkyBlue
        Me.btnBorrarAsociacion.FlatAppearance.BorderSize = 0
        Me.btnBorrarAsociacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBorrarAsociacion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarAsociacion.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBorrarAsociacion.Location = New System.Drawing.Point(12, 311)
        Me.btnBorrarAsociacion.Name = "btnBorrarAsociacion"
        Me.btnBorrarAsociacion.Size = New System.Drawing.Size(160, 46)
        Me.btnBorrarAsociacion.TabIndex = 46
        Me.btnBorrarAsociacion.Text = "Borrar asociación"
        Me.btnBorrarAsociacion.UseVisualStyleBackColor = False
        '
        'VentanaVerAsociaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(291, 361)
        Me.Controls.Add(Me.btnBorrarAsociacion)
        Me.Controls.Add(Me.TablaAsociaciones)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.txtPatA)
        Me.Controls.Add(Me.txtSintA)
        Me.Controls.Add(Me.txtIdA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "VentanaVerAsociaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lista asociaciones"
        CType(Me.TablaAsociaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIdA As TextBox
    Friend WithEvents txtSintA As TextBox
    Friend WithEvents txtPatA As TextBox
    Friend WithEvents btnListar As Button
    Friend WithEvents TablaAsociaciones As DataGridView
    Friend WithEvents btnBorrarAsociacion As Button
End Class
