Public Class Patologia_Sintoma

    Inherits ModeloConexion

    Public Sub New(username As String, password As String)
        MyBase.New(username, password)

    End Sub

    Public IDPATOLOGIA As String
    Public IDSINTOMA As String
    Public SintomasTotalesDePatologia As String
    Public NombreGestor As String

    'String generado en ControladorAsociar'
    Public ComandoObtenerPatologia As String
    Public ComandoObtenerPatologia2 As String

    Public Sub GuardarAsociacion()
        Comando.CommandText = "INSERT INTO PATOLOGIA_SINTOMAS VALUES(" + Me.IDPATOLOGIA + "," + Me.IDSINTOMA + ")"

        Comando.ExecuteNonQuery()

    End Sub

    Public Sub GuardarAsociacionEnGestiona()
        Comando.CommandText = "INSERT INTO GESTIONA VALUES('" + Me.NombreGestor + "'," + Me.IDSINTOMA + "," + Me.IDPATOLOGIA + ")"

        Comando.ExecuteNonQuery()

    End Sub

    Public Function ObtenerAsociacion()

        Comando.CommandText = "SELECT PATOLOGIA_SINTOMAS.IDPATOLOGIA_PAT as IdP,PATOLOGIA.NOMBRE as PATOLOGIA,PATOLOGIA_SINTOMAS.SINTOMA as IdS,SINTOMA.NOMBRE as SINTOMA
                               FROM PATOLOGIA,PATOLOGIA_SINTOMAS,SINTOMA
                               WHERE PATOLOGIA_SINTOMAS.IDPATOLOGIA_PAT = PATOLOGIA.IDPATOLOGIA
                               AND PATOLOGIA_SINTOMAS.SINTOMA = SINTOMA.IDSINTOMA
                               AND SINTOMA.ACTIVO=1
                               AND PATOLOGIA.ACTIVO=1; "

        Reader = Comando.ExecuteReader()
        Return Reader

    End Function


    Public Sub BorrarAsociacion()
        Comando.CommandText = "DELETE FROM PATOLOGIA_SINTOMAS WHERE IDPATOLOGIA_PAT = " + Me.IDPATOLOGIA + " AND SINTOMA= " + Me.IDSINTOMA + ""

        Comando.ExecuteNonQuery()

    End Sub

    Public Sub BorrarAsociacionEnGestiona()
        Comando.CommandText = "DELETE FROM GESTIONA WHERE IDPATOLOGIA = " + Me.IDPATOLOGIA + " AND IDSINTOMA= " + Me.IDSINTOMA + ""

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
                               WHERE IDPATOLOGIA = IDPATOLOGIA_PAT
                               AND PATOLOGIA.ACTIVO = 1
                               And NOMBRE='" + SintomasTotalesDePatologia + "'"

        Return Comando.ExecuteScalar().ToString()

    End Function

    'Consigue el numero DE sintomas por enfermedad en la busqueda
    Public Function ObtenerNumeroDeSintomasEnBusqueda()

        Comando.CommandText = ComandoObtenerPatologia2

        Return Comando.ExecuteScalar().ToString()

    End Function


End Class
