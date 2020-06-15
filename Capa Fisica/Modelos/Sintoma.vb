Public Class Sintoma
    Inherits ModeloConexion


    Public IdSintoma As String
    Public Nombre As String
    Public Prioriad As String


    Public Function ObtenerSintomas()

        Comando.CommandText = "SELECT * from SINTOMA"

        Reader = Comando.ExecuteReader()
        Return Reader

    End Function

    Public Sub AltaSintoma()
        Comando.CommandText = "INSERT INTO Persona VALUES(" + Me.IdSintoma + ",'" + Me.Nombre + "','" + Me.Prioriad + "')"

        Comando.ExecuteNonQuery()

    End Sub

    Public Sub BajaSintoma()
        Comando.CommandText = "DELETED FROM SINTOMA WHERE IdSintoma = " + Me.IdSintoma

        Comando.ExecuteNonQuery()

    End Sub

    Public Sub Modificar()

        Comando.CommandText = "UPDATE Sintoma SET nombre = '" + Me.Nombre + "', PRIORIDAD ='" + Me.Prioriad + "' WHERE IdSintoma = " + Me.IdSintoma
        Comando.ExecuteNonQuery()
    End Sub





End Class
