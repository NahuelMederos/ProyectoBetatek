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

    Public Function BuscarUltimaSesion()
        Dim m As New ModeloChat(Username, Password)
        If m.UltimaSesion() = "" Then
            Return "0"
        End If
        Return m.UltimaSesion()
    End Function

    Public Function ListarChatsNoLeidos()
        Dim p As New ModeloChat(Sesion.Username, Sesion.Password)

        Return p.ChatsNoRespondidos()

    End Function

End Module
