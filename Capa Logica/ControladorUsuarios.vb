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

    Public Sub setearSesion(usuario, password)
        Sesion.Username = usuario
        Sesion.Password = password

    End Sub

    Public Function AutenticarGestor(usuario As String, contraseña As String)
        Dim u As New Usuarios(usuario, contraseña)
        Return u.AutenticarGestor()

    End Function

End Module
