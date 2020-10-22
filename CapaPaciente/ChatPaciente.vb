Imports System.Net.Mail
Imports Capa_Logica

Public Class ChatPaciente
    Public Sintomas As String
    Public Prioridad As String
    Public Diagnostico As String


    Private Sub btnMail_Click(sender As Object, e As EventArgs) Handles btnMail.Click
        Dim Mail As String
        Mail = "Registro de chat con el medico " + txtEmisor.Text + ", con fecha " + ControladorChat.ObtenerFechaChat(txtSesion.Text) + "." + Environment.NewLine + Environment.NewLine + RTxtChat.Text + Environment.NewLine + "Fin de la conversacion." + Environment.NewLine + Environment.NewLine + "Este email se envía automáticamente. Por favor no responder."
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("betatek2020@gmail.com", "proyectobetatek2020")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("betatek2020@gmail.com")
            e_mail.To.Add(ControladorUsuarios.ObtenerMailPaciente(TxtId.Text))
            e_mail.Subject = "Chat con medico " + txtEmisor.Text + "."
            e_mail.IsBodyHtml = False
            e_mail.Body = Mail
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent")

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub

    Private Sub ChatPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtId.Text = Sesion.CI
        txtPara.Text = "Medico"
        txtIdDiagnostico.Text = Convert.ToInt32(ControladorDiagnostico.BuscarUltimoDiagnostico)
        txtSesion.Text = txtIdDiagnostico.Text
        txtSintomas.Text = Sintomas
        txtPrioridad.Text = Prioridad
        txtDiagnostico.Text = Diagnostico
        ControladorDiagnostico.EnviarDiagnostico(txtIdDiagnostico.Text)
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        ControladorChat.Guardar(txtSesion.Text, TxtId.Text, txtPara.Text, RTxtMensaje.Text)
        RTxtChat.Text += "[" + TimeOfDay.Hour.ToString + ":" + TimeOfDay.Minute.ToString + "] " + "Yo: " + RTxtMensaje.Text + Environment.NewLine
        WebBrowser1.DocumentText +=
            "
                <br />
                <b>YO: </b> 
                <br / >
                " + RTxtMensaje.Text + " 
            "
        RTxtMensaje.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim tabla As New DataTable
        tabla = ControladorChat.BuscarMensajeNoLeidoParaPaciente(txtSesion.Text, TxtId.Text)

        If tabla.Rows.Count > 0 Then
            'textoWB sirve para lo mismo que en ChatMedico
            Dim textoWB As String
            For Each fila As DataRow In tabla.Rows
                RTxtChat.Text += "[" + Strings.Left(Strings.Right(fila("FechaHora").ToString, 8), 5) + "] " + fila("emisor") + " " + fila("apellido") + ": " + fila("Texto").ToString + Environment.NewLine

                textoWB +=
            "
                <br />
                <b>" + fila("emisor") + " " + fila("apellido") + " a las " + fila("FechaHora") + " escribio: </b>
                <br />
                " + fila("Texto") + " 
                <br />
            "

                ControladorChat.MarcarMensajeLeido(fila("id_mensaje").ToString)
                txtPara.Text = fila("NombreUsuario").ToString
                txtEmisor.Text = fila("emisor").ToString + " " + fila("apellido")
            Next
            WebBrowser1.DocumentText += textoWB
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIniciarChat.Click

        Timer1.Enabled = True
        BtnEnviar.Enabled = True
        btnIniciarChat.Enabled = False

    End Sub

    Private Sub btnTerminarChat_Click(sender As Object, e As EventArgs) Handles btnTerminarChat.Click
        ControladorChat.TerminarChat(txtIdDiagnostico.Text)
        BtnEnviar.Enabled = False
        btnTerminarChat.Enabled = False
        btnMail.Enabled = True

    End Sub


End Class