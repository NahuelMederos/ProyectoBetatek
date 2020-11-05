
Imports System.ComponentModel
Imports Capa_Logica

Public Class VentanaChatPaciente
    Public Sintomas As String
    Public Prioridad As String
    Public Diagnostico As String

    'Darle a elegir al paciente despues de terminar el chat si desea enviar la sesion por correo, en caso de poner que no enviarlo al menu principal.
    Private Sub EnviarMail()
        Dim Chat As String
        Chat = "Registro de chat con el medico " + txtEmisor.Text + ", con fecha " + ControladorChat.ObtenerFechaChat(txtSesion.Text) + "." + Environment.NewLine + Environment.NewLine + RTxtChat.Text + Environment.NewLine + "Fin de la conversacion." + Environment.NewLine + Environment.NewLine + "Este email se envía automáticamente. Por favor no responder."

        Try
            ControladorChat.EnviarMail(txtEmisor.Text, (ControladorUsuarios.ObtenerDatosPaciente(TxtId.Text, 4)), Chat)
            MsgBox("Email enviado")
            VentanaMenu.Show()
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Su email " + ControladorUsuarios.ObtenerDatosPaciente(TxtId.Text, 4) + " no es valido")
        End Try
    End Sub

    Private Sub ChatPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.DocumentText = "<style>
                                      body {
                                          background-color:#1c1e22;
                                            }
                                     p{
                                          font-size: 12pt;
                                          color: white;
                                     }
                                     .Nombre{
                                          text-align:right;
                                          font-size: 12pt;
                                          color: white
                                     }
                                   </style>"
        TxtId.Text = Sesion.CI
        txtPara.Text = "Medico"
        txtIdDiagnostico.Text = ControladorDiagnostico.BuscarUltimoDiagnostico
        txtSesion.Text = txtIdDiagnostico.Text
        txtSintomas.Text = Sintomas
        txtPrioridad.Text = Prioridad
        txtDiagnostico.Text = Diagnostico
        ControladorDiagnostico.EnviarDiagnostico(txtIdDiagnostico.Text)
        btnIniciarChat_Click(sender, e)
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        ControladorChat.Guardar(txtSesion.Text, TxtId.Text, txtPara.Text, RTxtMensaje.Text)

        RTxtChat.Text += "[" + TimeOfDay.Hour.ToString + ":" + TimeOfDay.Minute.ToString + "] " + "Yo: " + RTxtMensaje.Text + Environment.NewLine
        WebBrowser1.DocumentText += "<p class=Nombre><b>YO: </b> <br />" + RTxtMensaje.Text + " </p>"
        RTxtMensaje.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim tabla As New DataTable
        tabla = ControladorChat.BuscarMensajeNoLeidoParaPaciente(txtSesion.Text, TxtId.Text)

        If tabla.Rows.Count > 0 Then
            'textoWB sirve para lo mismo que en ChatMedico
            Dim textoWB As String
            For Each fila As DataRow In tabla.Rows
                RTxtChat.Text += "[" + fila("FechaHora").ToString + "] " + fila("emisor") + " " + fila("apellido") + ": " + fila("Texto").ToString + Environment.NewLine

                textoWB +=
                "
                <br />
                <p><b>" + fila("emisor") + " " + fila("apellido") + " a las " + fila("FechaHora").ToString + " escribio: </b>
                <br />
                " + fila("Texto") + "</p>"

                ControladorChat.MarcarMensajeLeido(fila("id_mensaje").ToString)
                txtPara.Text = fila("NombreUsuario").ToString
                txtEmisor.Text = fila("emisor").ToString + " " + fila("apellido")
            Next
            WebBrowser1.DocumentText += textoWB
        End If
    End Sub



    Private Sub btnIniciarChat_Click(sender As Object, e As EventArgs) Handles btnIniciarChat.Click

        Timer1.Enabled = True
        BtnEnviar.Enabled = True
        btnIniciarChat.Enabled = False

    End Sub

    Private Sub btnTerminarChat_Click(sender As Object, e As EventArgs) Handles btnTerminarChat.Click
        ControladorChat.TerminarChat(txtIdDiagnostico.Text)
        BtnEnviar.Enabled = False
        btnTerminarChat.Enabled = False
        Dim SolicitarMail As DialogResult
        SolicitarMail = MessageBox.Show("¿Desea enviar esta sesion de chat a su e-mail?", "Solicitar Mail", MessageBoxButtons.YesNo)
        If SolicitarMail = DialogResult.Yes Then
            EnviarMail()
        Else
            VentanaMenu.Show()
            Me.Dispose()
        End If


    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Me.WebBrowser1.Document.Window.ScrollTo(0, WebBrowser1.Document.Body.ScrollRectangle.Size.Height)
    End Sub

    Private Sub VentanaChatPaciente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        btnTerminarChat_Click(sender, e)
    End Sub


End Class