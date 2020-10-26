Imports Capa_Logica
Public Class VentanaHistorialDeChats
    Private Sub VentanaHistorialDeChats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TablaChats As New DataTable
        TablaChats.Load(ControladorChat.ListarSesionesDeChat())

        TablaDeChats.DataSource = TablaChats
    End Sub

    Private Sub TablaDeChats_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaDeChats.CellClick
        Dim Indice As New Integer
        Indice = e.RowIndex

        Dim SesionSeleccionada As DataGridViewRow
        SesionSeleccionada = TablaDeChats.Rows(Indice)
        txtSesion.Text = SesionSeleccionada.Cells(0).Value.ToString()

    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Dim tabla2 As New DataTable
        tabla2 = ControladorChat.VerChatCompleto(txtSesion.Text)

        If tabla2.Rows.Count > 0 Then
            Dim textoWB2 As String
            For Each fila As DataRow In tabla2.Rows
                textoWB2 +=
            "
                <br />
                <b>" + fila("emisor") + fila("Apellido") + " a las " + fila("FechaHora").ToString + " escribio: </b>
                <br />
                " + fila("Texto") + "  
                <br />
                "
            Next
            VentanaChatCompleto.StrChatCompleto = textoWB2
            VentanaChatCompleto.ShowDialog()
        End If
    End Sub
End Class