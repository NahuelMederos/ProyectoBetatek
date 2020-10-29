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
        Me.TablaAsociaciones = New System.Windows.Forms.DataGridView()
        Me.btnBorrarAsociacion = New System.Windows.Forms.Button()
        Me.Id = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdA = New System.Windows.Forms.TextBox()
        Me.txtSintA = New System.Windows.Forms.TextBox()
        Me.txtPatA = New System.Windows.Forms.TextBox()
        Me.btnListar = New System.Windows.Forms.Button()
        CType(Me.TablaAsociaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TablaAsociaciones
        '
        Me.TablaAsociaciones.AllowUserToAddRows = False
        Me.TablaAsociaciones.AllowUserToDeleteRows = False
        Me.TablaAsociaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaAsociaciones.Location = New System.Drawing.Point(24, 12)
        Me.TablaAsociaciones.Name = "TablaAsociaciones"
        Me.TablaAsociaciones.ReadOnly = True
        Me.TablaAsociaciones.Size = New System.Drawing.Size(356, 293)
        Me.TablaAsociaciones.TabIndex = 0
        '
        'btnBorrarAsociacion
        '
        Me.btnBorrarAsociacion.Location = New System.Drawing.Point(265, 311)
        Me.btnBorrarAsociacion.Name = "btnBorrarAsociacion"
        Me.btnBorrarAsociacion.Size = New System.Drawing.Size(75, 42)
        Me.btnBorrarAsociacion.TabIndex = 1
        Me.btnBorrarAsociacion.Text = "Borrar Asociacion"
        Me.btnBorrarAsociacion.UseVisualStyleBackColor = True
        '
        'Id
        '
        Me.Id.AutoSize = True
        Me.Id.Location = New System.Drawing.Point(9, 312)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(16, 13)
        Me.Id.TabIndex = 2
        Me.Id.Text = "Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sintoma"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Patologia"
        '
        'txtIdA
        '
        Me.txtIdA.Location = New System.Drawing.Point(12, 328)
        Me.txtIdA.Name = "txtIdA"
        Me.txtIdA.Size = New System.Drawing.Size(28, 20)
        Me.txtIdA.TabIndex = 5
        '
        'txtSintA
        '
        Me.txtSintA.Location = New System.Drawing.Point(159, 328)
        Me.txtSintA.Name = "txtSintA"
        Me.txtSintA.ReadOnly = True
        Me.txtSintA.Size = New System.Drawing.Size(100, 20)
        Me.txtSintA.TabIndex = 6
        '
        'txtPatA
        '
        Me.txtPatA.Location = New System.Drawing.Point(47, 328)
        Me.txtPatA.Name = "txtPatA"
        Me.txtPatA.ReadOnly = True
        Me.txtPatA.Size = New System.Drawing.Size(100, 20)
        Me.txtPatA.TabIndex = 7
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(346, 312)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(45, 40)
        Me.btnListar.TabIndex = 8
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'VentanaVerAsociaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 367)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.txtPatA)
        Me.Controls.Add(Me.txtSintA)
        Me.Controls.Add(Me.txtIdA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Id)
        Me.Controls.Add(Me.btnBorrarAsociacion)
        Me.Controls.Add(Me.TablaAsociaciones)
        Me.Name = "VentanaVerAsociaciones"
        Me.Text = "VerAsociaciones"
        CType(Me.TablaAsociaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TablaAsociaciones As DataGridView
    Friend WithEvents btnBorrarAsociacion As Button
    Friend WithEvents Id As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdA As TextBox
    Friend WithEvents txtSintA As TextBox
    Friend WithEvents txtPatA As TextBox
    Friend WithEvents btnListar As Button
End Class
