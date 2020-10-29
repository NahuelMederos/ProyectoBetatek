Public Class Sintoma
    Inherits ModeloConexion

    Public Sub New(username As String, password As String)
        MyBase.New(username, password)

    End Sub

    Public IdSintoma As String
    Public Nombre As String


    Public Function ObtenerSintomas()

        Comando.CommandText = "SELECT IdSintoma,Nombre FROM SINTOMA where activo=1"

        Me.Reader = Comando.ExecuteReader()
        Return Me.Reader

    End Function


    Public Function ObtenerNombreSintomas()

        Comando.CommandText = "SELECT NOMBRE FROM SINTOMA where activo=1"

        Me.Reader = Comando.ExecuteReader()
        Return Me.Reader

    End Function

    Public Function ObtenerIdSintomas()

        Comando.CommandText = "SELECT IDSintoma FROM SINTOMA WHERE NOMBRE='" + Me.Nombre + "'"

        Return Comando.ExecuteScalar().ToString()

    End Function

    Public Sub GuardarSintoma()
        Comando.CommandText = "INSERT INTO SINTOMA VALUES(LAST_INSERT_ID(),'" + Me.Nombre + "',default)"

        Comando.ExecuteNonQuery()

    End Sub

    Public Function EstadoSintoma()
        Comando.CommandText = "Select Activo from Sintoma where Nombre='" + Me.Nombre + "'"

        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Sub ActivarSintoma()
        Comando.CommandText = "Update sintoma set activo=1 where Nombre='" + Me.Nombre + "'"
        Comando.ExecuteNonQuery()
    End Sub

    Public Sub BajaSintoma()
        Comando.CommandText = "START TRANSACTION;"
        Comando.ExecuteNonQuery()

        Try
            Comando.CommandText = "update sintoma set activo=0 where idsintoma=" + Me.IdSintoma
            Comando.ExecuteNonQuery()
            Comando.CommandText = "delete from patologia_sintomas where Sintoma=" + Me.IdSintoma
            Comando.ExecuteNonQuery()
            Comando.CommandText = "COMMIT;"
            Comando.ExecuteNonQuery()
        Catch ex As Exception
            Comando.CommandText = "ROLLBACK;"
            Comando.ExecuteNonQuery()
        End Try
    End Sub

    Public Sub ModificarSintoma()

        Comando.CommandText = "UPDATE SINTOMA SET NOMBRE = '" + Me.Nombre + "' WHERE IdSintoma = " + Me.IdSintoma
        Comando.ExecuteNonQuery()
    End Sub

End Class
