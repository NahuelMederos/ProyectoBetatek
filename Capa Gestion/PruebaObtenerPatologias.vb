Imports Capa_Logica

Public Class VentanaObtener

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim TablaSintomas As New DataTable
        TablaSintomas.Load(ControladorSintoma.ListarSintomas())

        TablaDeSintomas.DataSource = TablaSintomas
    End Sub
    Private nresult As String = "SELECT DISTINCT NOMBRE
FROM PATOLOGIA_SINTOMAS,PATOLOGIA
WHERE IDPATOLOGIA_PAT=IDPATOLOGIA AND SINTOMA='Nada'"
    Private contador As Integer = 0
    Private nombreList(contador)
    Public Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Dim nombre As String


        For Each selectedItem As DataGridViewRow In TablaDeSintomas.SelectedRows
            nombre = selectedItem.Cells("NOMBRE").Value
            ReDim Preserve nombreList(contador)
            nombreList(contador) = nombre
            contador += 1
        Next selectedItem

        For Each elem2 As String In nombreList
            nresult &= " OR IDPATOLOGIA_PAT=IDPATOLOGIA
AND SINTOMA='" + elem2 + "'"
        Next

        ControladorAsociar.ObtenerPatologias(nombreList)
        txtPrueba.Text = nresult



    End Sub

    Private Sub btnListarPatologias_Click(sender As Object, e As EventArgs) Handles btnListarPatologias.Click
        Dim TablaPatologias As New DataTable
        TablaPatologias.Load(ControladorAsociar.ObtenerPatologias(nombreList))

        TablaDePatologias.DataSource = TablaPatologias
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        VentanaGestion.Visible = True
        Me.Close()
    End Sub
End Class