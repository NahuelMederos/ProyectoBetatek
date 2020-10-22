Public Class Sintoma
    Inherits ModeloConexion

    Public Sub New(username As String, password As String)
        MyBase.New(username, password)

    End Sub

    Public IdSintoma As String
    Public Nombre As String


    Public Function ObtenerSintomas()

        Comando.CommandText = "SELECT * FROM SINTOMA"

        Me.Reader = Comando.ExecuteReader()
        Return Me.Reader

    End Function

    Public Function IdyNombreSintomas()

        Comando.CommandText = "SELECT IDSINTOMA,NOMBRE FROM SINTOMA"

        Me.Reader = Comando.ExecuteReader()
        Return Me.Reader

    End Function

    Public Function ObtenerNombreSintomas()

        Comando.CommandText = "SELECT NOMBRE FROM SINTOMA"

        Me.Reader = Comando.ExecuteReader()
        Return Me.Reader

    End Function

    Public Function ObtenerIdSintomas()

        Comando.CommandText = "SELECT IDSintoma FROM SINTOMA WHERE NOMBRE='" + Me.Nombre + "'"

        Return Comando.ExecuteScalar().ToString()

    End Function

    Public Sub GuardarSintoma()
        Comando.CommandText = "INSERT INTO SINTOMA VALUES(LAST_INSERT_ID(),'" + Me.Nombre + "')"

        Comando.ExecuteNonQuery()

    End Sub

    Public Sub BajaSintoma()
        Comando.CommandText = "DELETE FROM SINTOMA WHERE IDSINTOMA = " + Me.IdSintoma

        Comando.ExecuteNonQuery()

    End Sub

    Public Sub ModificarSintoma()

        Comando.CommandText = "UPDATE SINTOMA SET NOMBRE = '" + Me.Nombre + "' WHERE IdSintoma = " + Me.IdSintoma
        Comando.ExecuteNonQuery()
    End Sub

End Class
