Imports Capa_Fisica

Public Module ControladorAsociar

    Public Function ListarNombresPatologias()
        Dim p As New Patologia(Sesion.Username, Sesion.Password)

        Return p.IdyNombrePatologia()

    End Function

    Public Function ListarNombresSintomas()
        Dim p As New Sintoma(Sesion.Username, Sesion.Password)

        Return p.IdyNombreSintomas()

    End Function

    Public Sub CrearAsociacion(IdP As String, IdS As String)
        Dim p As New Patologia_Sintoma(Sesion.Username, Sesion.Password)
        p.IdPatologia = IdP
        p.IdSintoma = IdS

        p.GuardarAsociacion()

    End Sub

    Public Function ListarAsociaciones()
        Dim p As New Patologia_Sintoma(Sesion.Username, Sesion.Password)

        Return p.ObtenerAsociacion()
    End Function


    Public Sub BorrarAsociacion(IdS As String, IdP As String)
        Dim p As New Patologia_Sintoma(Sesion.Username, Sesion.Password)
        p.IdPatologia = IdS
        p.IdSintoma = IdP

        p.BorrarAsociacion()

    End Sub


    'La funcion pide el array creado en el boton Generar diagnostico'
    Public Function ObtenerOtrasPatologias(nombreList As Array)
        Dim p As New Patologia_Sintoma(Sesion.Username, Sesion.Password)

        'Comienzo del comando de mysql, para poder recorrer el array con el For Each.'
        'El primer sintoma que busca es "Nada" para poder usar OR cuando se agreguen mas items a la busqueda'
        Dim Resultado As String = "SELECT DISTINCT PATOLOGIA.NOMBRE
        FROM PATOLOGIA_SINTOMAS,PATOLOGIA,SINTOMA
        WHERE IDPATOLOGIA_PAT=IDPATOLOGIA
        AND PATOLOGIA_SINTOMAS.SINTOMA=IDSINTOMA
        AND SINTOMA.NOMBRE='Nada'"

        'Por cada lugar en nombreList se le agrega una nueva busqueda con el nombre del sintoma que pertenece a ese lugar'
        For Each elem2 As String In nombreList
            Resultado &= " OR IDPATOLOGIA_PAT=IDPATOLOGIA
        AND PATOLOGIA_SINTOMAS.SINTOMA=IDSINTOMA
        AND SINTOMA.NOMBRE='" + elem2 + "'"
        Next

        'Se envia un String con el comando para hacer la busqueda al modelo Patologia_Sintoma'
        p.ComandoObtenerPatologia = Resultado

        'Se devuelve la lista con las patologias'
        Return p.ObtenerPatologia()
    End Function

    'Sirve para obtener el numero total de sintomas que tiene una patologia'
    Public Function ObtenerPatologiasCompletas(PosiblePat As String)
        Dim p As New Patologia_Sintoma(Sesion.Username, Sesion.Password)
        p.SintomasTotalesDePatologia = PosiblePat

        Return p.ObtenerNumeroDeSintomasTotalesPorPatologia()

    End Function

    'Cuenta el numero de sintomas seleccionados por el usuario para la PosiblePat'
    Public Function ObtenerAparicionesdePatologiaenBusqueda(PosiblePat2 As String, nombreList As Array)
        Dim p As New Patologia_Sintoma(Sesion.Username, Sesion.Password)
        Dim Resultado As String = "SELECT COUNT(NOMBRE) 
        FROM(SELECT PATOLOGIA.NOMBRE
        FROM PATOLOGIA_SINTOMAS,PATOLOGIA,SINTOMA
        WHERE IDPATOLOGIA_PAT=IDPATOLOGIA
        AND IDSINTOMA=SINTOMA
        AND SINTOMA.NOMBRE='Nada'"

        For Each elem2 As String In nombreList
            Resultado &= " OR 
        IDPATOLOGIA_PAT=IDPATOLOGIA
        AND IDSINTOMA=SINTOMA
        AND SINTOMA.NOMBRE='" + elem2 + "'"
        Next
        Resultado &= ") as Patologias
        WHERE NOMBRE ='" + PosiblePat2 + "' ;"

        'Se envia un String con el comando para hacer la busqueda al modelo Patologia_Sintoma'
        p.ComandoObtenerPatologia2 = Resultado

        'Se devuelve el numero de sintomas seleccionados por el usuario para la PosiblePat'
        Return p.ObtenerNumeroDeSintomasEnBusqueda

    End Function
End Module
