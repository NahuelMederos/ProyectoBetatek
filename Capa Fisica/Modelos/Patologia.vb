


Public Class PATOLOGIA

    Inherits ModeloConexion

    Public Sub New(username As String, password As String)
        MyBase.New(username, password)

    End Sub

    Public IDPATOLOGIA As String
    Public NOMBRE As String
    Public PRIORIDAD As String


    Public Function ObtenerPatologia()

        Comando.CommandText = "SELECT IDPATOLOGIA as Id,NOMBRE,PRIORIDAD FROM PATOLOGIA where ACTIVO=1"

        Reader = Comando.ExecuteReader()
        Return Reader

    End Function

    Public Function BuscarIdPatologia()

        Comando.CommandText = "SELECT IDPATOLOGIA FROM PATOLOGIA WHERE NOMBRE='" + NOMBRE + "'"

        Return Comando.ExecuteScalar().ToString()

    End Function

    Public Function IdyNombrePatologia()

        Comando.CommandText = "SELECT IDPATOLOGIA as Id,NOMBRE as PATOLOGIA FROM PATOLOGIA where ACTIVO=1"

        Reader = Comando.ExecuteReader()
        Return Reader

    End Function

    Public Sub AltaPatologia()
        Comando.CommandText = "INSERT INTO PATOLOGIA VALUES(LAST_INSERT_ID(),'" + Me.NOMBRE + "','" + Me.PRIORIDAD + "',default)"

        Comando.ExecuteNonQuery()

    End Sub

    Public Sub BajaPatologia()
        Comando.CommandText = "START TRANSACTION;"
        Comando.ExecuteNonQuery()
        Try
            Comando.CommandText = "update PATOLOGIA set ACTIVO=0 where IDPATOLOGIA=" + Me.IDPATOLOGIA
            Comando.ExecuteNonQuery()
            Comando.CommandText = "delete from PATOLOGIA_SINTOMAS where IDPATOLOGIA_PAT=" + Me.IDPATOLOGIA
            Comando.ExecuteNonQuery()
            Comando.CommandText = "COMMIT;"
            Comando.ExecuteNonQuery()
        Catch ex As Exception
            Comando.CommandText = "ROLLBACK;"
            Comando.ExecuteNonQuery()
        End Try
    End Sub

    Public Sub Modificar()

        Comando.CommandText = "UPDATE PATOLOGIA SET NOMBRE = '" + Me.NOMBRE + "', PRIORIDAD ='" + Me.PRIORIDAD + "' WHERE IDPATOLOGIA = " + Me.IDPATOLOGIA
        Comando.ExecuteNonQuery()
    End Sub

    Public Function ObtenerPrioridadPatologia()

        Comando.CommandText = "SELECT PRIORIDAD FROM PATOLOGIA WHERE NOMBRE='" + NOMBRE + "';"

        Return Comando.ExecuteScalar().ToString()

    End Function

    Public Sub ActivarPatologia()
        Comando.CommandText = "Update PATOLOGIA set ACTIVO=1 where NOMBRE='" + Me.NOMBRE + "'"
        Comando.ExecuteNonQuery()
    End Sub

    Public Function EstadoPatologia()
        Comando.CommandText = "Select ACTIVO from PATOLOGIA where NOMBRE='" + Me.NOMBRE + "'"
        Try
            Return Comando.ExecuteScalar().ToString()
        Catch ex As Exception
            Return 2
        End Try

    End Function

End Class
