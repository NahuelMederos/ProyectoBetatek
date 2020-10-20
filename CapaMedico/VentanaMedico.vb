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

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        ControladorDiagnostico.ModificarNombreRecibe(txtIdDiagnostico.Text)
        ChatMedico.IdDiagnostico = txtIdDiagnostico.Text
        ChatMedico.Ci = txtCiPersona.Text
        ChatMedico.ShowDialog()
    End Sub

    Private Sub TablaDeDiagnosticos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaDeDiagnosticos.CellClick
        Dim Indice As New Integer
        Indice = e.RowIndex

        Dim DSeleccionado As DataGridViewRow
        DSeleccionado = TablaDeDiagnosticos.Rows(Indice)
        txtIdDiagnostico.Text = DSeleccionado.Cells(1).Value.ToString()
        txtCiPersona.Text = DSeleccionado.Cells(4).Value.ToString()
    End Sub
End Class