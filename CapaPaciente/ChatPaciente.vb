Imports Capa_Logica



Public Class ChatPaciente
    Public Sintomas As String
    Public Prioridad As String
    Public Diagnostico As String

    Private Sub ChatPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtId.Text = Sesion.CI
        txtPara.Text = "Medico"
        txtIdDiagnostico.Text = Convert.ToInt32(ControladorDiagnostico.BuscarUltimoDiagnostico)
        txtSesion.Text = Convert.ToInt32(ControladorChat.BuscarUltimaSesion) + 1
        txtSesion.Text = txtIdDiagnostico.Text
        txtSintomas.Text = Sintomas
        txtPrioridad.Text = Prioridad
        txtDiagnostico.Text = Diagnostico
        ControladorDiagnostico.EnviarDiagnostico(txtIdDiagnostico.Text, Prioridad)
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
        tabla = ControladorChat.BuscarMensajeNoLeidoParaPaciente(txtSesion.Text, TxtId.Text)

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
                txtPara.Text = fila("NombreUsuario").ToString
            Next

        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIniciarChat.Click

        Timer1.Enabled = True
        BtnEnviar.Enabled = True
        btnIniciarChat.Enabled = False

    End Sub


End Class