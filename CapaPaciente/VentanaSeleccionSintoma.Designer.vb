<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaSeleccionSintoma
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblSeleccionDeSintomas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GrillaSintomas = New System.Windows.Forms.DataGridView()
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnSeleccionarSintoma = New System.Windows.Forms.Button()
        Me.GrillaOtrasPatologias = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPatologiasSeguras = New System.Windows.Forms.TextBox()
        Me.txtIdPatologias = New System.Windows.Forms.TextBox()
        CType(Me.GrillaSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaOtrasPatologias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSeleccionDeSintomas
        '
        Me.lblSeleccionDeSintomas.AutoSize = True
        Me.lblSeleccionDeSintomas.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionDeSintomas.Location = New System.Drawing.Point(7, 38)
        Me.lblSeleccionDeSintomas.Name = "lblSeleccionDeSintomas"
        Me.lblSeleccionDeSintomas.Size = New System.Drawing.Size(227, 28)
        Me.lblSeleccionDeSintomas.TabIndex = 2
        Me.lblSeleccionDeSintomas.Text = "Sección de sintomas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(383, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Diagnostico"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(554, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 7
        '
        'GrillaSintomas
        '
        Me.GrillaSintomas.AllowUserToAddRows = False
        Me.GrillaSintomas.AllowUserToDeleteRows = False
        Me.GrillaSintomas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GrillaSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaSintomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GrillaSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaSintomas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Check})
        Me.GrillaSintomas.EnableHeadersVisualStyles = False
        Me.GrillaSintomas.GridColor = System.Drawing.Color.SteelBlue
        Me.GrillaSintomas.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.GrillaSintomas.Location = New System.Drawing.Point(12, 69)
        Me.GrillaSintomas.Name = "GrillaSintomas"
        Me.GrillaSintomas.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.GrillaSintomas.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.GrillaSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaSintomas.Size = New System.Drawing.Size(203, 157)
        Me.GrillaSintomas.TabIndex = 10
        '
        'Check
        '
        Me.Check.DataPropertyName = "Check"
        Me.Check.HeaderText = ""
        Me.Check.Name = "Check"
        Me.Check.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Check.Width = 20
        '
        'btnSeleccionarSintoma
        '
        Me.btnSeleccionarSintoma.Location = New System.Drawing.Point(257, 231)
        Me.btnSeleccionarSintoma.Name = "btnSeleccionarSintoma"
        Me.btnSeleccionarSintoma.Size = New System.Drawing.Size(129, 39)
        Me.btnSeleccionarSintoma.TabIndex = 12
        Me.btnSeleccionarSintoma.Text = "Generar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "diagnostico"
        Me.btnSeleccionarSintoma.UseVisualStyleBackColor = True
        '
        'GrillaOtrasPatologias
        '
        Me.GrillaOtrasPatologias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaOtrasPatologias.Location = New System.Drawing.Point(449, 82)
        Me.GrillaOtrasPatologias.Name = "GrillaOtrasPatologias"
        Me.GrillaOtrasPatologias.RowHeadersVisible = False
        Me.GrillaOtrasPatologias.Size = New System.Drawing.Size(188, 215)
        Me.GrillaOtrasPatologias.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(470, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Todas las posibles patologias"
        '
        'txtPatologiasSeguras
        '
        Me.txtPatologiasSeguras.Location = New System.Drawing.Point(449, 338)
        Me.txtPatologiasSeguras.Name = "txtPatologiasSeguras"
        Me.txtPatologiasSeguras.Size = New System.Drawing.Size(100, 20)
        Me.txtPatologiasSeguras.TabIndex = 30
        '
        'txtIdPatologias
        '
        Me.txtIdPatologias.Location = New System.Drawing.Point(312, 347)
        Me.txtIdPatologias.Name = "txtIdPatologias"
        Me.txtIdPatologias.Size = New System.Drawing.Size(100, 20)
        Me.txtIdPatologias.TabIndex = 31
        '
        'VentanaSeleccionSintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(688, 379)
        Me.Controls.Add(Me.txtIdPatologias)
        Me.Controls.Add(Me.txtPatologiasSeguras)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GrillaOtrasPatologias)
        Me.Controls.Add(Me.btnSeleccionarSintoma)
        Me.Controls.Add(Me.GrillaSintomas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSeleccionDeSintomas)
        Me.Name = "VentanaSeleccionSintoma"
        Me.Text = "Form1"
        CType(Me.GrillaSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaOtrasPatologias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSeleccionDeSintomas As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GrillaSintomas As DataGridView
    Friend WithEvents btnSeleccionarSintoma As Button
    Friend WithEvents GrillaOtrasPatologias As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPatologiasSeguras As TextBox
    Friend WithEvents txtIdPatologias As TextBox
    Friend WithEvents Check As DataGridViewCheckBoxColumn
End Class
