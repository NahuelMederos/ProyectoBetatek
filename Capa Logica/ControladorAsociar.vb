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



    Public Function ObtenerPatologias(nombreList As Array)
        Dim p As New Patologia_Sintoma
        Dim Resultado As String = "SELECT DISTINCT NOMBRE
FROM PATOLOGIA_SINTOMAS,PATOLOGIA
WHERE IDPATOLOGIA_PAT=IDPATOLOGIA AND SINTOMA='Nada'"

        For Each elem2 As String In nombreList
            Resultado &= " OR IDPATOLOGIA_PAT=IDPATOLOGIA
AND SINTOMA='" + elem2 + "'"
        Next

        p.ComandoObtenerPatologia = Resultado
        Return p.ObtenerPatologia()
    End Function
End Module
