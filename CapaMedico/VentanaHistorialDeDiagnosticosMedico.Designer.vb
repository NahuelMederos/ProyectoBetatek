<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaHistorialDeDiagnosticosMedico
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
        Me.TablaDeDiagnosticos = New System.Windows.Forms.DataGridView()
        Me.txtSesion = New System.Windows.Forms.TextBox()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TablaDeDiagnosticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TablaDeDiagnosticos
        '
        Me.TablaDeDiagnosticos.AllowUserToAddRows = False
        Me.TablaDeDiagnosticos.AllowUserToDeleteRows = False
        Me.TablaDeDiagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDeDiagnosticos.Location = New System.Drawing.Point(13, 13)
        Me.TablaDeDiagnosticos.Name = "TablaDeDiagnosticos"
        Me.TablaDeDiagnosticos.ReadOnly = True
        Me.TablaDeDiagnosticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaDeDiagnosticos.Size = New System.Drawing.Size(569, 180)
        Me.TablaDeDiagnosticos.TabIndex = 0
        '
        'txtSesion
        '
        Me.txtSesion.Location = New System.Drawing.Point(57, 208)
        Me.txtSesion.Name = "txtSesion"
        Me.txtSesion.Size = New System.Drawing.Size(28, 20)
        Me.txtSesion.TabIndex = 1
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(507, 206)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccionar.TabIndex = 4
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sesion"
        '
        'VentanaHistorialDeDiagnosticosMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 241)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.txtSesion)
        Me.Controls.Add(Me.TablaDeDiagnosticos)
        Me.Name = "VentanaHistorialDeDiagnosticosMedico"
        Me.Text = "VentanaHistorialDeChats"
        CType(Me.TablaDeDiagnosticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TablaDeDiagnosticos As DataGridView
    Friend WithEvents txtSesion As TextBox
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents Label1 As Label
End Class
