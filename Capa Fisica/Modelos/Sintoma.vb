Public Class SINTOMA
    Inherits ModeloConexion

    Public Sub New(username As String, password As String)
        MyBase.New(username, password)

    End Sub

    Public IDSINTOMA As String
    Public NOMBRE As String


    Public Function ObtenerSintomas()

        Comando.CommandText = "SELECT IDSINTOMA as ID,NOMBRE FROM SINTOMA where ACTIVO=1"

        Me.Reader = Comando.ExecuteReader()
        Return Me.Reader

    End Function


    Public Function ObtenerNombreSintomas()

        Comando.CommandText = "SELECT NOMBRE as Sintomas FROM SINTOMA where ACTIVO=1"

        Me.Reader = Comando.ExecuteReader()
        Return Me.Reader

    End Function

    Public Function ObtenerIdSintomas()

        Comando.CommandText = "SELECT IDSINTOMA FROM SINTOMA WHERE NOMBRE='" + Me.NOMBRE + "'"

        Return Comando.ExecuteScalar().ToString()

    End Function

    Public Sub GuardarSintoma()
        Comando.CommandText = "INSERT INTO SINTOMA VALUES(LAST_INSERT_ID(),'" + Me.NOMBRE + "',DEFAULT)"

        Comando.ExecuteNonQuery()

    End Sub

    Public Function EstadoSintoma()
        Comando.CommandText = "SELECT ACTIVO from SINTOMA where NOMBRE='" + Me.NOMBRE + "'"
        Try
            Return Comando.ExecuteScalar().ToString()
        Catch ex As Exception
            Return 2
        End Try

    End Function

    Public Sub ActivarSintoma()
        Comando.CommandText = "Update SINTOMA set ACTIVO=1 where NOMBRE='" + Me.NOMBRE + "'"
        Comando.ExecuteNonQuery()
    End Sub

    Public Sub BajaSintoma()
        Comando.CommandText = "START TRANSACTION;"
        Comando.ExecuteNonQuery()

        Try
            Comando.CommandText = "update SINTOMA set ACTIVO=0 where IDSINTOMA=" + Me.IDSINTOMA
            Comando.ExecuteNonQuery()
            Comando.CommandText = "delete from PATOLOGIA_SINTOMAS where SINTOMA=" + Me.IDSINTOMA
            Comando.ExecuteNonQuery()
            Comando.CommandText = "COMMIT;"
            Comando.ExecuteNonQuery()
        Catch ex As Exception
            Comando.CommandText = "ROLLBACK;"
            Comando.ExecuteNonQuery()
        End Try
    End Sub

    Public Sub ModificarSintoma()

        Comando.CommandText = "UPDATE SINTOMA SET NOMBRE = '" + Me.NOMBRE + "' WHERE IDSINTOMA = " + Me.IDSINTOMA
        Comando.ExecuteNonQuery()
    End Sub

End Class
