Imports Capa_Logica
Public Class VentanaMedico
    Private Sub VentanaMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TablaDiagnosticos As New DataTable
        TablaDiagnosticos.Load(ControladorDiagnostico.ListarDiagnosticos())

        TablaDeDiagnosticos.DataSource = TablaDiagnosticos
    End Sub
End Class