Imports Capa_Fisica

Public Module ControladorAsociar

    Public Function ListarNombresPatologias()
        Dim p As New Patologia

        Return p.IdyNombrePatologia()

    End Function

    Public Function ListarNombresSintomas()
        Dim p As New Sintoma

        Return p.ObtenerNombreSintomas()

    End Function

    Public Sub CrearAsociacion(Id As String, Nombre As String)
        Dim p As New Patologia_Sintoma
        p.IdPatologia = Id
        p.NombreSintoma = Nombre

        p.GuardarAsociacion()

    End Sub

    Public Function ListarAsociaciones()
        Dim p As New Patologia_Sintoma

        Return p.ObtenerAsociacion()
    End Function

    Public Sub BorrarAsociacion(Id As String, Nombre As String)
        Dim p As New Patologia_Sintoma
        p.IdPatologia = Id
        p.NombreSintoma = Nombre

        p.BorrarAsociacion()

    End Sub

End Module
