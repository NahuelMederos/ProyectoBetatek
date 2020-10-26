Imports Capa_Logica
Public Class VentanaHistorialDiagnosticos
    Private Sub VentanaHistorialDiagnosticos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaDeDiagnosticos.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        TablaDeDiagnosticos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        TablaDeDiagnosticos.AutoResizeColumns()
        TablaDeDiagnosticos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Dim TablaDiagnosticos As New DataTable
        TablaDiagnosticos.Load(ControladorDiagnostico.HistorialDeDiagnosticos())

        TablaDeDiagnosticos.DataSource = TablaDiagnosticos
    End Sub
End Class