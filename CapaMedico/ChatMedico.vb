Imports System.ComponentModel
Imports Capa_Logica

Public Class ChatMedico
    Public IdDiagnostico As String
    Public Ci As String



    Private Sub ChatMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtId.Text = Sesion.Username
        txtSesion.Text = IdDiagnostico
        txtPara.Text = Ci

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
        If (ControladorChat.EstadoDelChat(txtSesion.Text) = 0) Then
            MsgBox("El paciente termino el chat")
            BtnEnviar.Enabled = False
            Timer1.Stop()

        Else
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
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIniciarChat.Click
        Timer1.Enabled = True
        BtnEnviar.Enabled = True
        btnIniciarChat.Enabled = False
    End Sub

    Private Sub ChatMedico_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class