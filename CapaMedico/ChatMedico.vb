Imports Capa_Logica

Public Class ChatMedico

    Private Sub ChatMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtId.Text = Sesion.Username
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        ControladorChat.Guardar(txtSesion.Text, TxtId.Text, txtPara.Text, RTxtMensaje.Text)
        RTxtChat.Text += Environment.NewLine + "YO:" + Environment.NewLine + RTxtMensaje.Text
        WebBrowser1.DocumentText +=
            "
                <br />
                <b>YO: </b> 
                <br / >
                " + RTxtMensaje.Text + " 
            "
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim tabla As New DataTable
        tabla = ControladorChat.BuscarMensajeNoLeidoParaMedico(txtSesion.Text, TxtId.Text)

        If tabla.Rows.Count > 0 Then

            For Each fila As DataRow In tabla.Rows
                RTxtChat.Text += Environment.NewLine + fila("emisor").ToString + " - " + fila("FechaHora").ToString + Environment.NewLine + fila("Texto").ToString

                WebBrowser1.DocumentText +=
            "
                <br />
                <b>" + fila("emisor") + " a las " + fila("FechaHora") + " escribio: </b>
                <br />
                " + fila("Texto") + " 
                <br />
            "

                ControladorChat.MarcarMensajeLeido(fila("id_mensaje").ToString)
            Next





        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIniciarChat.Click
        Timer1.Enabled = True
        BtnEnviar.Enabled = True
        btnIniciarChat.Enabled = False
        btnListar.Enabled = False
    End Sub



    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim TablaChatsSinResponder As New DataTable
        TablaChatsSinResponder.Load(ControladorChat.ListarChatsNoLeidos())

        TablaChats.DataSource = TablaChatsSinResponder
    End Sub

    Private Sub TablaChats_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaChats.CellClick
        Dim Indice As New Integer
        Indice = e.RowIndex
        Dim ChatSeleccionado As DataGridViewRow
        ChatSeleccionado = TablaChats.Rows(Indice)
        txtSesion.Text = ChatSeleccionado.Cells(0).Value.ToString
        txtPara.Text = ChatSeleccionado.Cells(1).Value.ToString

    End Sub


End Class