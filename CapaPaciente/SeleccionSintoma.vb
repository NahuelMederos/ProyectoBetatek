Imports Capa_Logica

Public Class SeleccionSintoma



    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnListarSintomas.Click
        Dim tabla As New DataTable
        tabla.Load(ControladorSintoma.ListarSintomas)
        GrillaSintomas.DataSource = tabla
    End Sub

    Private Sub btnSeleccionarSintoma_Click(sender As Object, e As EventArgs) Handles btnSeleccionarSintoma.Click
        Dim i As Integer
        i = GrillaSintomas.CurrentRow.Index

        GrillaSintomaDePaciente.DataSource = GrillaSintomas.Item(0, i).Value()
    End Sub
End Class
