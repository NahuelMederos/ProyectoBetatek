Public Class Patologia_Sintoma

    Inherits ModeloConexion

    Public Sub New(username As String, password As String)
        MyBase.New(username, password)

    End Sub

    Public IdPatologia As String
    Public IdSintoma As String
    Public SintomasTotalesDePatologia As String


    'String generado en ControladorAsociar'
    Public ComandoObtenerPatologia As String
    Public ComandoObtenerPatologia2 As String

    Public Sub GuardarAsociacion()
        Comando.CommandText = "INSERT INTO PATOLOGIA_SINTOMAS VALUES(" + Me.IdPatologia + "," + Me.IdSintoma + ")"

        Comando.ExecuteNonQuery()

    End Sub

    Public Function ObtenerAsociacion()

        Comando.CommandText = "SELECT PATOLOGIA_SINTOMAS.IDPATOLOGIA_PAT,PATOLOGIA.NOMBRE,PATOLOGIA_SINTOMAS.SINTOMA,SINTOMA.NOMBRE
                               FROM PATOLOGIA,PATOLOGIA_SINTOMAS,SINTOMA
                               WHERE PATOLOGIA_SINTOMAS.IDPATOLOGIA_PAT = PATOLOGIA.IDPATOLOGIA
                               AND PATOLOGIA_SINTOMAS.SINTOMA = SINTOMA.IDSINTOMA
                               AND SINTOMA.ACTIVO=1
                               AND PATOLOGIA.ACTIVO=1; "

        Reader = Comando.ExecuteReader()
        Return Reader

    End Function

    Public Sub BorrarAsociacion()
        Comando.CommandText = "DELETE FROM PATOLOGIA_SINTOMAS WHERE IDPATOLOGIA_PAT = " + Me.IdPatologia + " AND SINTOMA= " + Me.IdSintoma + ""

        Comando.ExecuteNonQuery()

    End Sub

    Public Function ObtenerPatologia()

        'Hace la busqueda con el String y devuelve un Reader'
        Comando.CommandText = ComandoObtenerPatologia

        Reader = Comando.ExecuteReader()
        Return Reader

    End Function

    Public Function ObtenerNumeroDeSintomasTotalesPorPatologia()

        Comando.CommandText = "SELECT COUNT(NOMBRE) FROM PATOLOGIA_SINTOMAS,PATOLOGIA
                               WHERE IdPatologia = IDPATOLOGIA_PAT
                               AND PATOLOGIA.ACTIVO = 1
                               And NOMBRE='" + SintomasTotalesDePatologia + "'"

        Return Comando.ExecuteScalar().ToString()

    End Function

    'Consigue el numero de sintomas por enfermedad en la busqueda
    Public Function ObtenerNumeroDeSintomasEnBusqueda()

        Comando.CommandText = ComandoObtenerPatologia2

        Return Comando.ExecuteScalar().ToString()

    End Function


End Class
