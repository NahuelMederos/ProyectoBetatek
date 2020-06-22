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


    'La funcion pide el array creado en el boton Seleccionar'
    Public Function ObtenerPatologias(nombreList As Array)
        Dim p As New Patologia_Sintoma
        'Comienzo del comando de mysql, para poder recorrer el array con el for each, el primer sintoma que busca es "Nada" el cual no va a devolver ninguna Patologia'
        Dim Resultado As String = "SELECT DISTINCT NOMBRE
FROM PATOLOGIA_SINTOMAS,PATOLOGIA
WHERE IDPATOLOGIA_PAT=IDPATOLOGIA AND SINTOMA='Nada'"

        'Por cada lugar en nombreList se le agrega una nueva busqueda con el nombre del sintoma que pertenece a ese lugar'
        For Each elem2 As String In nombreList
            Resultado &= " OR IDPATOLOGIA_PAT=IDPATOLOGIA
AND SINTOMA='" + elem2 + "'"
        Next

        'Se envia un String con el comando para hacer la busqueda al modelo Patologia_Sintoma'
        p.ComandoObtenerPatologia = Resultado

        'Se devuelve la lista con las patologias'
        Return p.ObtenerPatologia()
    End Function
End Module
