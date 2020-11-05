Imports System.ComponentModel
Imports Capa_Logica

Public Class ChatMedico
    Public IdDiagnostico As String
    Public Ci As String
    Public Diagnostico As String


    Private Sub ChatMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


        Timer1.Enabled = True

        TxtId.Text = Sesion.Username
        txtSesion.Text = IdDiagnostico
        txtPara.Text = Ci
        txtDiagnostico.Text = Diagnostico
        btnIniciarChat_Click(sender, e)

    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        ControladorChat.Guardar(txtSesion.Text, TxtId.Text, txtPara.Text, RTxtMensaje.Text)
        WebBrowser1.DocumentText += "<p class=Nombre><b>YO: </b> <br />" + RTxtMensaje.Text + " </p>"

        RTxtMensaje.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (ControladorChat.EstadoDelChat(txtSesion.Text) = 0) Then
            Timer1.Stop()
            MsgBox("El paciente termino el chat")
            BtnEnviar.Enabled = False
            VentanaPrincipalMedico.btnVerSolicitudes_Click(sender, e)
            VentanaPrincipalMedico.txtIdDiagnostico.Text = ""
            VentanaPrincipalMedico.txtCiPersona.Text = ""

        Else
            Dim tabla As New DataTable
            tabla = ControladorChat.BuscarMensajeNoLeidoParaMedico(txtSesion.Text, TxtId.Text)

            If tabla.Rows.Count > 0 Then


                'Teniendo el WebBrowser dentro del ForEach hace que no aparezcan los mensajes sin leer si son mas de uno(Por alguna razon que desconozco)
                'textoWB sirve para evitar este problema
                Dim textoWB As String
                For Each fila As DataRow In tabla.Rows
                    textoWB +=
                "
                <br />
                <p><b>" + fila("emisor") + " a las " + fila("fechahora").ToString + " escribio: </b>
                <br />
                " + fila("Texto") + "</p>"

                    ControladorChat.MarcarMensajeLeido(fila("id_mensaje").ToString)
                Next
                WebBrowser1.DocumentText += textoWB
            End If
        End If
    End Sub

    Private Sub btnIniciarChat_Click(sender As Object, e As EventArgs) Handles btnIniciarChat.Click
        BtnEnviar.Enabled = True
        btnIniciarChat.Enabled = False
    End Sub

    Private Sub ChatMedico_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnChatCompleto.Click
        Try
            Dim tabla2 As New DataTable
            tabla2 = ControladorChat.VerChatCompleto(txtSesion.Text)

            If tabla2.Rows.Count > 0 Then
                Dim textoWB2 As String
                For Each fila As DataRow In tabla2.Rows
                    textoWB2 +=
                "
                <br />
                <b>" + fila("emisor") + " a las " + fila("FechaHora").ToString + " escribio: </b>
                <br />
                " + fila("Texto") + "  
                "
                Next
                ChatCompleto.StrChatCompleto = textoWB2
                ChatCompleto.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Me.WebBrowser1.Document.Window.ScrollTo(0, WebBrowser1.Document.Body.ScrollRectangle.Size.Height)
    End Sub


End Class