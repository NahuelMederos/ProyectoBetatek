Imports Capa_Logica
Public Class VentanaHistorialDiagnosticos
    Private Sub VentanaHistorialDiagnosticos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TablaDeDiagnosticos.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        TablaDeDiagnosticos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        TablaDeDiagnosticos.AutoResizeColumns()
        TablaDeDiagnosticos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Try
            Dim TablaDiagnosticos As New DataTable
            TablaDiagnosticos.Load(ControladorDiagnostico.HistorialDeDiagnosticos())

            TablaDeDiagnosticos.DataSource = TablaDiagnosticos
        Catch ex As Exception
            MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
End Class