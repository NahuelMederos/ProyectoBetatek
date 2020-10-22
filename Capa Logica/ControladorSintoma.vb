Imports Capa_Fisica

Public Module ControladorSintoma

    Public Sub CrearSintoma(Nombre As String)
        Dim s As New Sintoma(Sesion.Username, Sesion.Password)
        s.Nombre = Nombre


        s.GuardarSintoma()

    End Sub

    Public Sub BorrarSintoma(Id As String)
        Dim s As New Sintoma(Sesion.Username, Sesion.Password)
        s.IdSintoma = Id

        s.BajaSintoma()

    End Sub

    Public Sub ModificarSintoma(Id As String, Nombre As String)
        Dim s As New Sintoma(Sesion.Username, Sesion.Password)

        s.IdSintoma = Id
        s.Nombre = Nombre


        s.ModificarSintoma()
    End Sub

    Public Function ListarSintomas()
        Dim s As New Sintoma(Sesion.Username, Sesion.Password)

        Return s.ObtenerSintomas()

    End Function

    Public Function ListarNombreSintomas()
        Dim s As New Sintoma(Sesion.Username, Sesion.Password)

        Return s.ObtenerNombreSintomas()

    End Function

    Public Function ObtenerIdSintoma(NombreSintoma As String)
        Dim s As New Sintoma(Sesion.Username, Sesion.Password)
        s.Nombre = NombreSintoma

        Return s.ObtenerIdSintomas
    End Function
End Module
