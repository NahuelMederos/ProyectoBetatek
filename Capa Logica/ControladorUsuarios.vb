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

    Public Function ObtenerDatosPaciente(NombreUsuario As String, Opcion As Integer)
        Dim u As New Usuarios(Username, Password)
        u.NombreUsuario = NombreUsuario

        Select Case Opcion
            Case 1
                Return u.ObtenerNombrePaciente
            Case 2
                Return u.ObtenerApellidoPaciente
            Case 3
                Return u.ObtenerEdadPaciente
            Case 4
                Return u.ObtenerMailPaciente
            Case 5
                u.NombreUsuario = NombreUsuario
                Dim DatosUsuario As New List(Of String) From {u.ObtenerNombrePaciente, u.ObtenerApellidoPaciente, u.ObtenerEdadPaciente, u.ObtenerMailPaciente}
                Return DatosUsuario
        End Select
    End Function

    Public Function ObtenerDatosMedico(NombreUsuario As String, Opcion As Integer)
        Dim u As New Usuarios(Username, Password)
        u.NombreUsuario = NombreUsuario

        Select Case Opcion
            Case 1
                Return u.ObtenerNombreMedico
            Case 2
                Return u.ObtenerApellidoMedico
            Case 3
                Return u.ObtenerCedulaMedico
            Case 5
                Dim DatosUsuario As New List(Of String) From {u.ObtenerNombreMedico, u.ObtenerApellidoMedico, u.ObtenerCedulaMedico}
                Return DatosUsuario
        End Select
    End Function

    Public Function ObtenerDatosGestor(NombreUsuario As String, Opcion As Integer)
        Dim u As New Usuarios(Username, Password)
        u.NombreUsuario = NombreUsuario

        Select Case Opcion
            Case 1
                Return u.ObtenerNombreGestor
            Case 2
                Return u.ObtenerApellidoGestor
            Case 3
                Return u.ObtenerCedulaGestor
            Case 5
                Dim DatosUsuario As New List(Of String) From {u.ObtenerNombreGestor, u.ObtenerApellidoGestor, u.ObtenerCedulaGestor}
                Return DatosUsuario
        End Select
    End Function

    Public Sub ModificarPaciente(Ci As String, Nombre As String, Apellido As String, Edad As String, Mail As String)
        Dim u As New Usuarios(Username, Password)
        u.Cedula = Ci
        u.Nombre = Nombre
        u.Apellido = Apellido
        u.Edad = Edad
        u.Mail = Mail

        u.ModificarPaciente()
    End Sub

    Public Sub ModificarMedico(NombreUsuario As String, Nombre As String, Apellido As String, Cedula As String)
        Dim u As New Usuarios(Username, Password)
        u.NombreUsuario = NombreUsuario
        u.Cedula = Cedula
        u.Nombre = Nombre
        u.Apellido = Apellido

        u.ModificarMedico()
    End Sub

    Public Sub ModificarGestor(NombreUsuario As String, Nombre As String, Apellido As String, Cedula As String)
        Dim u As New Usuarios(Username, Password)
        u.NombreUsuario = NombreUsuario
        u.Cedula = Cedula
        u.Nombre = Nombre
        u.Apellido = Apellido

        u.ModificarGestor()
    End Sub

    Public Function ListarUsuarios(Opcion As Integer)
        Dim u As New Usuarios(Username, Password)
        Select Case Opcion
            Case 1
                Return u.ListarPacientes
            Case 2
                Return u.ListarMedicos
            Case 3
                Return u.ListarGestores()
        End Select
    End Function

    Public Sub DesactivarUsuario(NombreUsuario As String, Opcion As Integer)
        Dim u As New Usuarios(Username, Password)
        u.NombreUsuario = NombreUsuario

        Select Case Opcion
            Case 1
                u.DesactivarPaciente()
            Case 2
                u.DesactivarMedico()
            Case 3
                u.DesactivarGestor()
        End Select
    End Sub

    Public Function VerificarEstadoUsuario(NombreUsuario As String, Opcion As Integer)
        Dim u As New Usuarios(Username, Password)
        u.NombreUsuario = NombreUsuario

        Select Case Opcion
            Case 1
                Return u.EstadoDePaciente
            Case 2
                Return u.EstadoDeMedico
            Case 3
                Return u.EstadoDeGestor
        End Select
    End Function

    Public Sub ActivarUsuario(NombreUsuario As String, Opcion As Integer)
        Dim u As New Usuarios(Username, Password)
        u.NombreUsuario = NombreUsuario

        Select Case Opcion
            Case 1
                u.ActivarPaciente()
            Case 2
                u.ActivarMedico()
            Case 3
                u.ActivarGestor()
        End Select
    End Sub
End Module
