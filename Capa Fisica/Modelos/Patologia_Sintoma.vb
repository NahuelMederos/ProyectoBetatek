Public Class Patologia_Sintoma

    Inherits ModeloConexion

    Public IdPatologia As String
    Public NombreSintoma As String

    Public Sub GuardarAsociacion()
        Comando.CommandText = "INSERT INTO PATOLOGIA_SINTOMAS VALUES(" + Me.IdPatologia + ",'" + Me.NombreSintoma + "')"

        Comando.ExecuteNonQuery()

    End Sub

    Public Function ObtenerAsociacion()

        Comando.CommandText = "SELECT PATOLOGIA_SINTOMAS.IDPATOLOGIA_PAT,PATOLOGIA.NOMBRE,PATOLOGIA_SINTOMAS.SINTOMA FROM PATOLOGIA,PATOLOGIA_SINTOMAS"

        Reader = Comando.ExecuteReader()
        Return Reader

    End Function

    Public Sub BorrarAsociacion()
        Comando.CommandText = "DELETE FROM PATOLOGIA_SINTOMAS WHERE IDPATOLOGIA_PAT = " + Me.IdPatologia + " AND SINTOMA= '" + Me.NombreSintoma + "'"

        Comando.ExecuteNonQuery()

    End Sub

End Class
