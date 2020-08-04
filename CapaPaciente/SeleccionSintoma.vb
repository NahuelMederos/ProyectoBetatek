Imports Capa_Logica

Public Class SeleccionSintoma



    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnListarSintomas.Click
        Dim tabla As New DataTable
        tabla.Load(ControladorSintoma.ListarSintomas)
        GrillaSintomas.DataSource = tabla
    End Sub


    'Sirve para que se pueda ver el RichTextBox desde esta ventana'

    Private nresult As String = "SELECT DISTINCT NOMBRE FROM PATOLOGIA_SINTOMAS,PATOLOGIA WHERE IDPATOLOGIA_PAT=IDPATOLOGIA AND SINTOMA='Nada'"

    'Son declarados en private para que se mantengan sus valores despues de ser usados por el boton seleccionar'
    Private contador As Integer = 0
    Private nombreList(contador)


    Private Sub btnSeleccionarSintoma_Click_1(sender As Object, e As EventArgs) Handles btnSeleccionarSintoma.Click

        '---------------------------------------------------------------
        'Guarda en la tabla "TIENE" LA ASOCIACION DE SINTOMA CON EL USUARIO
        'ES A FUTURO PARA CUANDO TRABAJE CON LA APLICACION DE MEDICO
        Dim i As Integer
        i = GrillaSintomas.CurrentRow.Index

        Dim idSintoma As String
        Dim ciPersona As String = txtPideCI.Text

        idSintoma = GrillaSintomas.Item(0, i).Value()
        GuardarSintomasPersona(ciPersona, idSintoma)

        '---------------------------------------------------------------


        Dim nombre As String

        'Por cada item seleccionado en el datagrid, se guardan los datos en el array nombreList'
        For Each selectedItem As DataGridViewRow In GrillaSintomas.SelectedRows
            nombre = selectedItem.Cells("NOMBRE").Value
            ReDim Preserve nombreList(contador)
            nombreList(contador) = nombre
            contador += 1
        Next selectedItem


        'Lo que esta aca es lo mismo que en ControladorAsociar, solo sirve para poder ver el comando de mysql en el RichTextBox'
        For Each elem2 As String In nombreList
            nresult &= " OR IDPATOLOGIA_PAT=IDPATOLOGIA
AND SINTOMA='" + elem2 + "'"
        Next

        ControladorAsociar.ObtenerPatologias(nombreList)
        txtPatologias.Text = nresult


    End Sub


End Class
