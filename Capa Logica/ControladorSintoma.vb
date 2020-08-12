Imports Capa_Fisica

Public Module ControladorSintoma

    Public Sub CrearSintoma(Nombre As String, Prioridad As String)
        Dim s As New Sintoma
        s.Nombre = Nombre
        s.Prioridad = Prioridad

        s.GuardarSintoma()

    End Sub

    Public Sub BorrarSintoma(Id As String)
        Dim s As New Sintoma
        s.IdSintoma = Id

        s.BajaSintoma()

    End Sub

    Public Sub ModificarSintoma(Id As String, Nombre As String, Prioridad As String)
        Dim s As New Sintoma

        s.IdSintoma = Id
        s.Nombre = Nombre
        s.Prioridad = Prioridad

        s.ModificarSintoma()
    End Sub

    Public Function ListarSintomas()
        Dim s As New Sintoma

        Return s.ObtenerSintomas()

    End Function
End Module
