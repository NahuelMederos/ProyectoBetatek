Imports System.ComponentModel
Imports System.Net.Mail
Imports Capa_Fisica

Public Module ControladorChat

    Public Sub Guardar(Sesion As String, De As String, Para As String, Mensaje As String)
        Dim m As New ModeloChat(Username, Password)
        m.Sesion = Sesion
        m.De = De
        m.Para = Para
        m.Mensaje = Mensaje


        m.Guardar()


    End Sub

    Public Function ListarSesionesDeChat()
        Dim m As New ModeloChat(Username, Password)

        Return m.ObtenerSesionesDeChat
    End Function

    Public Function BuscarMensajeNoLeidoParaMedico(Sesion As String, Para As String)

        Dim m As New ModeloChat(Username, Password)
        m.Sesion = Sesion
        m.Para = Para
        Return m.LeerMensajesNoLeidosParaMedico

    End Function

    Public Function BuscarMensajeNoLeidoParaPaciente(Sesion As String, Para As String)

        Dim m As New ModeloChat(Username, Password)
        m.Sesion = Sesion
        m.Para = Para
        Return m.LeerMensajesNoLeidosParaPaciente

    End Function

    Public Sub MarcarMensajeLeido(id As String)
        Dim m As New ModeloChat(Username, Password)
        m.Id = id
        m.MarcarLeido()

    End Sub



    Public Function ListarChatsNoLeidos()
        Dim p As New ModeloChat(Sesion.Username, Sesion.Password)

        Return p.ChatsNoRespondidos()

    End Function

    Public Function EstadoDelChat(IdDiagnostico As String)
        Dim c As New ModeloChat(Sesion.Username, Sesion.Password)
        c.IdDiagnostico = IdDiagnostico

        Return c.VerificarEstadoDelChat

    End Function

    Public Sub TerminarChat(IdDiagnostico As String)
        Dim c As New ModeloChat(Sesion.Username, Sesion.Password)
        c.IdDiagnostico = IdDiagnostico

        c.TerminarChat()
    End Sub

    Public Function VerChatCompleto(Sesion As String)
        Dim c As New ModeloChat(Username, Password)
        c.Sesion = Sesion

        Return c.VerChatCompleto()
    End Function

    Public Function ObtenerFechaChat(Sesion As String)
        Dim c As New ModeloChat(Username, Password)
        c.Sesion = Sesion

        Return c.ObtenerFechaDelChat
    End Function

    Public Sub EnviarMail(Emisor As String, Mail As String, Chat As String)
        Dim Smtp_Server As New SmtpClient
        Dim e_mail As New MailMessage()
        Smtp_Server.UseDefaultCredentials = False
        Smtp_Server.Credentials = New Net.NetworkCredential("betatek2020@gmail.com", "proyectobetatek2020")
        Smtp_Server.Port = 587
        Smtp_Server.EnableSsl = True
        Smtp_Server.Host = "smtp.gmail.com"

        e_mail = New MailMessage()
        e_mail.From = New MailAddress("betatek2020@gmail.com")
        e_mail.To.Add(Mail)
        e_mail.Subject = "Chat con medico " + Emisor + "."
        e_mail.IsBodyHtml = False
        e_mail.Body = Chat
        Smtp_Server.Send(e_mail)

    End Sub
End Module
