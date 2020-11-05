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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtSesion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TablaDeDiagnosticos = New System.Windows.Forms.DataGridView()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        CType(Me.TablaDeDiagnosticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSesion
        '
        Me.txtSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtSesion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSesion.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSesion.ForeColor = System.Drawing.Color.Snow
        Me.txtSesion.Location = New System.Drawing.Point(63, 211)
        Me.txtSesion.Name = "txtSesion"
        Me.txtSesion.Size = New System.Drawing.Size(28, 24)
        Me.txtSesion.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(12, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sesion"
        '
        'TablaDeDiagnosticos
        '
        Me.TablaDeDiagnosticos.AllowUserToAddRows = False
        Me.TablaDeDiagnosticos.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablaDeDiagnosticos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.TablaDeDiagnosticos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.TablaDeDiagnosticos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaDeDiagnosticos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.TablaDeDiagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDeDiagnosticos.EnableHeadersVisualStyles = False
        Me.TablaDeDiagnosticos.GridColor = System.Drawing.Color.SteelBlue
        Me.TablaDeDiagnosticos.Location = New System.Drawing.Point(13, 12)
        Me.TablaDeDiagnosticos.Name = "TablaDeDiagnosticos"
        Me.TablaDeDiagnosticos.ReadOnly = True
        Me.TablaDeDiagnosticos.RowHeadersVisible = False
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.TablaDeDiagnosticos.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.TablaDeDiagnosticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaDeDiagnosticos.Size = New System.Drawing.Size(611, 180)
        Me.TablaDeDiagnosticos.TabIndex = 6
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSeleccionar.FlatAppearance.BorderSize = 0
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSeleccionar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSeleccionar.Location = New System.Drawing.Point(500, 198)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(124, 37)
        Me.btnSeleccionar.TabIndex = 45
        Me.btnSeleccionar.Text = "Seleccionar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'VentanaHistorialDeDiagnosticosMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(636, 241)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.TablaDeDiagnosticos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSesion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "VentanaHistorialDeDiagnosticosMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Chats antiguos"
        CType(Me.TablaDeDiagnosticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSesion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TablaDeDiagnosticos As DataGridView
    Friend WithEvents btnSeleccionar As Button
End Class
