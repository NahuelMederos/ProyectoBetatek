<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaAsociar
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
        Me.TablaPat = New System.Windows.Forms.DataGridView()
        Me.TablaSint = New System.Windows.Forms.DataGridView()
        Me.ListarTodo = New System.Windows.Forms.Button()
        Me.txtIdPatologia = New System.Windows.Forms.TextBox()
        Me.txtNombrePatologia = New System.Windows.Forms.TextBox()
        Me.txtNombreSintoma = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAsociar = New System.Windows.Forms.Button()
        Me.btnVerAsociaciones = New System.Windows.Forms.Button()
        CType(Me.TablaPat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaSint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TablaPat
        '
        Me.TablaPat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaPat.Location = New System.Drawing.Point(12, 12)
        Me.TablaPat.Name = "TablaPat"
        Me.TablaPat.Size = New System.Drawing.Size(247, 339)
        Me.TablaPat.TabIndex = 0
        '
        'TablaSint
        '
        Me.TablaSint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaSint.Location = New System.Drawing.Point(391, 12)
        Me.TablaSint.Name = "TablaSint"
        Me.TablaSint.Size = New System.Drawing.Size(192, 339)
        Me.TablaSint.TabIndex = 1
        '
        'ListarTodo
        '
        Me.ListarTodo.Location = New System.Drawing.Point(13, 366)
        Me.ListarTodo.Name = "ListarTodo"
        Me.ListarTodo.Size = New System.Drawing.Size(75, 23)
        Me.ListarTodo.TabIndex = 2
        Me.ListarTodo.Text = "Listar"
        Me.ListarTodo.UseVisualStyleBackColor = True
        '
        'txtIdPatologia
        '
        Me.txtIdPatologia.Location = New System.Drawing.Point(276, 92)
        Me.txtIdPatologia.Name = "txtIdPatologia"
        Me.txtIdPatologia.Size = New System.Drawing.Size(100, 20)
        Me.txtIdPatologia.TabIndex = 4
        '
        'txtNombrePatologia
        '
        Me.txtNombrePatologia.Location = New System.Drawing.Point(276, 131)
        Me.txtNombrePatologia.Name = "txtNombrePatologia"
        Me.txtNombrePatologia.Size = New System.Drawing.Size(100, 20)
        Me.txtNombrePatologia.TabIndex = 5
        '
        'txtNombreSintoma
        '
        Me.txtNombreSintoma.Location = New System.Drawing.Point(276, 261)
        Me.txtNombreSintoma.Name = "txtNombreSintoma"
        Me.txtNombreSintoma.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreSintoma.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(273, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Id Patologia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(273, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Patologia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(273, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Sintoma"
        '
        'btnAsociar
        '
        Me.btnAsociar.Location = New System.Drawing.Point(289, 186)
        Me.btnAsociar.Name = "btnAsociar"
        Me.btnAsociar.Size = New System.Drawing.Size(75, 23)
        Me.btnAsociar.TabIndex = 10
        Me.btnAsociar.Text = "Asociar"
        Me.btnAsociar.UseVisualStyleBackColor = True
        '
        'btnVerAsociaciones
        '
        Me.btnVerAsociaciones.Location = New System.Drawing.Point(468, 366)
        Me.btnVerAsociaciones.Name = "btnVerAsociaciones"
        Me.btnVerAsociaciones.Size = New System.Drawing.Size(106, 23)
        Me.btnVerAsociaciones.TabIndex = 11
        Me.btnVerAsociaciones.Text = "Ver asociaciones"
        Me.btnVerAsociaciones.UseVisualStyleBackColor = True
        '
        'VentanaAsociar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 401)
        Me.Controls.Add(Me.btnVerAsociaciones)
        Me.Controls.Add(Me.btnAsociar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombreSintoma)
        Me.Controls.Add(Me.txtNombrePatologia)
        Me.Controls.Add(Me.txtIdPatologia)
        Me.Controls.Add(Me.ListarTodo)
        Me.Controls.Add(Me.TablaSint)
        Me.Controls.Add(Me.TablaPat)
        Me.Name = "VentanaAsociar"
        Me.Text = "VentanaAsociar"
        CType(Me.TablaPat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaSint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TablaPat As DataGridView
    Friend WithEvents TablaSint As DataGridView
    Friend WithEvents ListarTodo As Button
    Friend WithEvents txtIdPatologia As TextBox
    Friend WithEvents txtNombrePatologia As TextBox
    Friend WithEvents txtNombreSintoma As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAsociar As Button
    Friend WithEvents btnVerAsociaciones As Button
End Class
