Imports Capa_Logica
Public Class VentanaMedico
    Private Sub VentanaMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TablaDiagnosticos As New DataTable
        TablaDiagnosticos.Load(ControladorDiagnostico.ListarDiagnosticos())
        TablaDeDiagnosticos.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        TablaDeDiagnosticos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        TablaDeDiagnosticos.AutoResizeColumns()
        TablaDeDiagnosticos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        TablaDeDiagnosticos.DataSource = TablaDiagnosticos
    End Sub
End Class