Imports Capa_Logica

Public Class SeleccionSintoma



    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnListarSintomas.Click
        Dim tabla As New DataTable
        tabla.Load(ControladorSintoma.ListarSintomas)
        GrillaSintomas.DataSource = tabla
    End Sub



    Private Sub btnSeleccionarSintoma_Click_1(sender As Object, e As EventArgs) Handles btnSeleccionarSintoma.Click
        Dim i As Integer
        i = GrillaSintomas.CurrentRow.Index

        Dim id As String
        Dim nombre As String
        Dim prioridad As String

        id = GrillaSintomas.Item(0, i).Value()
        nombre = (Convert.ToString(GrillaSintomas.Item(1, i).Value()))


        MsgBox(nombre)
        MsgBox(id)


    End Sub
End Class
