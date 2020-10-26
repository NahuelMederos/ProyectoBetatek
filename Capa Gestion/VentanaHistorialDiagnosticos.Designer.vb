<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaHistorialDiagnosticos
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
        CType(Me.TablaDeDiagnosticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TablaDeDiagnosticos
        '
        Me.TablaDeDiagnosticos.AllowUserToAddRows = False
        Me.TablaDeDiagnosticos.AllowUserToDeleteRows = False
        Me.TablaDeDiagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDeDiagnosticos.Location = New System.Drawing.Point(2, 1)
        Me.TablaDeDiagnosticos.Name = "TablaDeDiagnosticos"
        Me.TablaDeDiagnosticos.ReadOnly = True
        Me.TablaDeDiagnosticos.Size = New System.Drawing.Size(505, 449)
        Me.TablaDeDiagnosticos.TabIndex = 0
        '
        'VentanaHistorialDiagnosticos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 450)
        Me.Controls.Add(Me.TablaDeDiagnosticos)
        Me.Name = "VentanaHistorialDiagnosticos"
        Me.Text = "VentanaHistorialDiagnosticos"
        CType(Me.TablaDeDiagnosticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TablaDeDiagnosticos As DataGridView
End Class
