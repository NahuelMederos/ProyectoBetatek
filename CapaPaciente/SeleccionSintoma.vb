Imports Capa_Logica

Public Class SeleccionSintoma



    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnListarSintomas.Click
        Dim tabla As New DataTable
        tabla.Load(ControladorSintoma.ListarNombreSintomas)
        GrillaSintomas.DataSource = tabla
    End Sub




    'Son declarados en private para que se mantengan sus valores despues de ser usados por el boton seleccionar'
    Private contador As Integer = 0
    Private nombreList(contador)

    Private contador2 As Integer = 0
    Private PosiblePatologiaList(contador2)

    Private contador3 As Integer = 0
    Private PatologiasSeguras(contador3)

    'presult nos deja ver los sintomas que se seleccionaron'
    Private presult As String

    'Nos permite ver todas las patologias posibles en un array'
    Private OtrasPatologiasResult As String

    Private Sub btnSeleccionarSintoma_Click_1(sender As Object, e As EventArgs) Handles btnSeleccionarSintoma.Click


        Dim nombre As String

        'Por cada item seleccionado en el datagrid, se guardan los nombres en el array nombreList'
        For Each selectedItem As DataGridViewRow In GrillaSintomas.SelectedRows
            nombre = selectedItem.Cells("NOMBRE").Value
            ReDim Preserve nombreList(contador)
            nombreList(contador) = nombre
            contador += 1
        Next selectedItem




        Dim TablaOtrasPatologias As New DataTable
        TablaOtrasPatologias.Load(ControladorAsociar.ObtenerOtrasPatologias(nombreList))
        GrillaOtrasPatologias.DataSource = TablaOtrasPatologias


        Dim PosiblePatologia As String

        'Crea un array con todas las posibles patologias'
        For Each Item As DataGridViewRow In GrillaOtrasPatologias.Rows
            PosiblePatologia = Item.Cells("NOMBRE").Value
            ReDim Preserve PosiblePatologiaList(contador2)
            PosiblePatologiaList(contador2) = PosiblePatologia
            contador2 += 1
        Next

        'Compara la cantidad de sintomas totales que tiene una patologia, con los sintomas seleccionados por el usuario para cada patologia en la lista "Otras posibles patologias"'
        'En el caso de que la cantidad sea la misma, se agrega la patologia a un nuevo array llamado PatologiasSeguras'
        For Each PosiblePat As String In PosiblePatologiaList
            Dim Cuenta1 As Integer = Convert.ToInt32(ControladorAsociar.ObtenerPatologiasCompletas(PosiblePat))
            Dim Cuenta2 As Integer = Convert.ToInt32(ControladorAsociar.ObtenerAparicionesdePatologiaenBusqueda(PosiblePat, nombreList))
            If (Cuenta1 = Cuenta2) Then
                ReDim Preserve PatologiasSeguras(contador3)
                PatologiasSeguras(contador3) = PosiblePat + vbCrLf
                contador3 += 1
            End If

        Next

        Dim ResultadoFinal As String = ""

        'Por cada Patologia en PatologiasSeguras se agrega al String ResultadoFinal'
        For Each Patologia As String In PatologiasSeguras
            ResultadoFinal &= Patologia
        Next

        If ResultadoFinal = vbCrLf Then
            ResultadoFinal = "No hay ningun diagnostico seguro"
        End If

        txtResultadoFinal.Text = ResultadoFinal

        btnSeleccionarSintoma.Enabled = False
        btnSolicitarChat.Enabled = True
    End Sub

    Private Sub txtResultadoFinal_TextChanged(sender As Object, e As EventArgs) Handles txtResultadoFinal.TextChanged

    End Sub

    Private Sub btnSolicitarChat_Click(sender As Object, e As EventArgs) Handles btnSolicitarChat.Click
        ChatPaciente.Visible = True
        Me.Close()
    End Sub




End Class
