<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaAsociar
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ListarTodo = New System.Windows.Forms.Button()
        Me.txtIdPatologia = New System.Windows.Forms.TextBox()
        Me.txtIdSintoma = New System.Windows.Forms.TextBox()
        Me.TablaPat = New System.Windows.Forms.DataGridView()
        Me.TablaSint = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAsociar = New System.Windows.Forms.Button()
        Me.txtNombrePatologia = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtNombreSintoma = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnVerAsociaciones = New System.Windows.Forms.Button()
        CType(Me.TablaPat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaSint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListarTodo
        '
        Me.ListarTodo.Location = New System.Drawing.Point(173, 0)
        Me.ListarTodo.Name = "ListarTodo"
        Me.ListarTodo.Size = New System.Drawing.Size(10, 10)
        Me.ListarTodo.TabIndex = 2
        Me.ListarTodo.Text = "Listar"
        Me.ListarTodo.UseVisualStyleBackColor = True
        Me.ListarTodo.Visible = False
        '
        'txtIdPatologia
        '
        Me.txtIdPatologia.Location = New System.Drawing.Point(189, 0)
        Me.txtIdPatologia.Name = "txtIdPatologia"
        Me.txtIdPatologia.ReadOnly = True
        Me.txtIdPatologia.Size = New System.Drawing.Size(10, 20)
        Me.txtIdPatologia.TabIndex = 4
        Me.txtIdPatologia.Visible = False
        '
        'txtIdSintoma
        '
        Me.txtIdSintoma.Location = New System.Drawing.Point(205, 0)
        Me.txtIdSintoma.Name = "txtIdSintoma"
        Me.txtIdSintoma.ReadOnly = True
        Me.txtIdSintoma.Size = New System.Drawing.Size(10, 20)
        Me.txtIdSintoma.TabIndex = 12
        Me.txtIdSintoma.Visible = False
        '
        'TablaPat
        '
        Me.TablaPat.AllowUserToAddRows = False
        Me.TablaPat.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablaPat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.TablaPat.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.TablaPat.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaPat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.TablaPat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaPat.EnableHeadersVisualStyles = False
        Me.TablaPat.GridColor = System.Drawing.Color.SteelBlue
        Me.TablaPat.Location = New System.Drawing.Point(12, 36)
        Me.TablaPat.Name = "TablaPat"
        Me.TablaPat.ReadOnly = True
        Me.TablaPat.RowHeadersVisible = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.TablaPat.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.TablaPat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaPat.Size = New System.Drawing.Size(143, 310)
        Me.TablaPat.TabIndex = 62
        '
        'TablaSint
        '
        Me.TablaSint.AllowUserToAddRows = False
        Me.TablaSint.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablaSint.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.TablaSint.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.TablaSint.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaSint.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.TablaSint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaSint.EnableHeadersVisualStyles = False
        Me.TablaSint.GridColor = System.Drawing.Color.SteelBlue
        Me.TablaSint.Location = New System.Drawing.Point(294, 36)
        Me.TablaSint.Name = "TablaSint"
        Me.TablaSint.ReadOnly = True
        Me.TablaSint.RowHeadersVisible = False
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.TablaSint.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.TablaSint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaSint.Size = New System.Drawing.Size(160, 310)
        Me.TablaSint.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(170, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Sintoma"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(169, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Patologia"
        '
        'btnAsociar
        '
        Me.btnAsociar.BackColor = System.Drawing.Color.SkyBlue
        Me.btnAsociar.FlatAppearance.BorderSize = 0
        Me.btnAsociar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAsociar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsociar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAsociar.Location = New System.Drawing.Point(171, 170)
        Me.btnAsociar.Name = "btnAsociar"
        Me.btnAsociar.Size = New System.Drawing.Size(101, 46)
        Me.btnAsociar.TabIndex = 66
        Me.btnAsociar.Text = "Asociar"
        Me.btnAsociar.UseVisualStyleBackColor = False
        '
        'txtNombrePatologia
        '
        Me.txtNombrePatologia.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtNombrePatologia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombrePatologia.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePatologia.ForeColor = System.Drawing.Color.White
        Me.txtNombrePatologia.Location = New System.Drawing.Point(171, 88)
        Me.txtNombrePatologia.Name = "txtNombrePatologia"
        Me.txtNombrePatologia.Size = New System.Drawing.Size(86, 19)
        Me.txtNombrePatologia.TabIndex = 67
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(171, 107)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(86, 1)
        Me.Panel3.TabIndex = 68
        '
        'txtNombreSintoma
        '
        Me.txtNombreSintoma.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtNombreSintoma.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreSintoma.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreSintoma.ForeColor = System.Drawing.Color.White
        Me.txtNombreSintoma.Location = New System.Drawing.Point(171, 131)
        Me.txtNombreSintoma.Name = "txtNombreSintoma"
        Me.txtNombreSintoma.Size = New System.Drawing.Size(86, 19)
        Me.txtNombreSintoma.TabIndex = 69
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(171, 150)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(86, 1)
        Me.Panel1.TabIndex = 70
        '
        'btnVerAsociaciones
        '
        Me.btnVerAsociaciones.BackColor = System.Drawing.Color.SkyBlue
        Me.btnVerAsociaciones.FlatAppearance.BorderSize = 0
        Me.btnVerAsociaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVerAsociaciones.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerAsociaciones.ForeColor = System.Drawing.SystemColors.Control
        Me.btnVerAsociaciones.Location = New System.Drawing.Point(161, 297)
        Me.btnVerAsociaciones.Name = "btnVerAsociaciones"
        Me.btnVerAsociaciones.Size = New System.Drawing.Size(127, 49)
        Me.btnVerAsociaciones.TabIndex = 71
        Me.btnVerAsociaciones.Text = "Ver asociaciones"
        Me.btnVerAsociaciones.UseVisualStyleBackColor = False
        '
        'VentanaAsociar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(457, 358)
        Me.Controls.Add(Me.btnVerAsociaciones)
        Me.Controls.Add(Me.txtNombreSintoma)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtNombrePatologia)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnAsociar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TablaSint)
        Me.Controls.Add(Me.TablaPat)
        Me.Controls.Add(Me.txtIdSintoma)
        Me.Controls.Add(Me.txtIdPatologia)
        Me.Controls.Add(Me.ListarTodo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "VentanaAsociar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asociar"
        CType(Me.TablaPat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaSint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListarTodo As Button
    Friend WithEvents txtIdPatologia As TextBox
    Friend WithEvents txtIdSintoma As TextBox
    Friend WithEvents TablaPat As DataGridView
    Friend WithEvents TablaSint As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAsociar As Button
    Friend WithEvents txtNombrePatologia As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtNombreSintoma As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnVerAsociaciones As Button
End Class
