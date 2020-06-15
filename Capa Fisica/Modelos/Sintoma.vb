Public Class Sintoma
    Inherits ModeloConexion


    Public IdSintoma As String
    Public Nombre As String
    Public Prioridad As String


    Public Function ObtenerSintomas()

        Comando.CommandText = "SELECT * FROM SINTOMA"

        Me.Reader = Comando.ExecuteReader()
        Return Me.Reader

    End Function

    Public Sub GuardarSintoma()
        Comando.CommandText = "INSERT INTO SINTOMA VALUES(" + Me.IdSintoma + ",'" + Me.Nombre + "','" + Me.Prioridad + "')"

        Comando.ExecuteNonQuery()

    End Sub

    Public Sub BajaSintoma()
        Comando.CommandText = "DELETE FROM SINTOMA WHERE IDSINTOMA = " + Me.IdSintoma

        Comando.ExecuteNonQuery()

    End Sub

    Public Sub ModificarSintoma()

        Comando.CommandText = "UPDATE SINTOMA SET NOMBRE = '" + Me.Nombre + "', PRIORIDAD ='" + Me.Prioridad + "' WHERE IdSintoma = " + Me.IdSintoma
        Comando.ExecuteNonQuery()
    End Sub

End Class
