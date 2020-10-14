Imports Capa_Fisica

Public Module ControladorUsuarios

    Public Sub CrearGestor(NombreUsuario As String, Contraseña As String, Nombre As String, Apellido As String, Cedula As String)
        Dim s As New Usuarios(Username, Password)

        s.NombreUsuario = NombreUsuario
        s.Contraseña = Contraseña
        s.Nombre = Nombre
        s.Apellido = Apellido
        s.Cedula = Cedula

        s.CrearGestor()

    End Sub

    Public Function AutenticarGestor(usuario As String, contraseña As String)
        Dim u As New Usuarios(usuario, contraseña)
        Return u.AutenticarGestor()

    End Function

    Public Sub CrearMedico(NombreUsuario As String, Contraseña As String, Nombre As String, Apellido As String, Cedula As String)
        Dim s As New Usuarios(Username, Password)

        s.NombreUsuario = NombreUsuario
        s.Contraseña = Contraseña
        s.Nombre = Nombre
        s.Apellido = Apellido
        s.Cedula = Cedula

        s.CrearMedico()

    End Sub

    Public Function AutenticarMedico(usuario As String, contraseña As String)
        Dim u As New Usuarios(usuario, contraseña)
        Return u.AutenticarMedico()

    End Function

    Public Sub CrearPaciente(NombreUsuario As String, Contraseña As String, Nombre As String, Apellido As String, Edad As String, Mail As String)
        Dim s As New Usuarios(Username, Password)

        s.NombreUsuario = NombreUsuario
        s.Contraseña = Contraseña
        s.Nombre = Nombre
        s.Apellido = Apellido
        s.Edad = Edad
        s.Mail = Mail

        s.CrearPaciente()

    End Sub

    Public Function AutenticarPaciente(usuario As String, contraseña As String)
        Dim u As New Usuarios(usuario, contraseña)
        Return u.AutenticarPaciente()

    End Function

    Public Sub setearSesion(usuario, password)
        Sesion.Username = usuario
        Sesion.Password = password

    End Sub

    Public Function VerificarUsuarioMySQL(usuario As String)
        Dim u As New Usuarios(Username, Password)
        u.NombreUsuario = usuario
        Return u.VerificarUsuarioMySQL

        Return 0
    End Function

    Public Function VerificarExistenciaClaveUnica(Clave As String, tipo As Integer)
        Dim u As New Usuarios(Username, Password)
        Select Case tipo
            Case 1
                u.Cedula = Clave
                Return u.VerificarCedulaGestor
            Case 2
                u.Cedula = Clave
                Return u.VerificarCedulaMedico
            Case 3
                u.Mail = Clave
                Return u.VerificarMailPaciente
        End Select

        Return 0
    End Function


End Module
