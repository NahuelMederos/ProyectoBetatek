Public Class Patologia
  
    Inherits ModeloConexion

    Public IdPatologia As String
    Public Nombre As String
    Public Prioridad As String


    Public Function ObtenerPatologia()

        Comando.CommandText = "SELECT * FROM PATOLOGIA"

        Reader = Comando.ExecuteReader()
        Return Reader

    End Function

    Public Function IdyNombrePatologia()

        Comando.CommandText = "SELECT IDPATOLOGIA,NOMBRE FROM PATOLOGIA"

        Reader = Comando.ExecuteReader()
        Return Reader

    End Function

    Public Sub AltaPatologia()
        Comando.CommandText = "INSERT INTO PATOLOGIA VALUES(" + Me.IdPatologia + ",'" + Me.Nombre + "','" + Me.Prioridad + "')"

        Comando.ExecuteNonQuery()

    End Sub

    Public Sub BajaPatologia()
        Comando.CommandText = "DELETE FROM PATOLOGIA WHERE IDPATOLOGIA = " + Me.IdPatologia

        Comando.ExecuteNonQuery()

    End Sub

    Public Sub Modificar()

        Comando.CommandText = "UPDATE PATOLOGIA SET NOMBRE = '" + Me.Nombre + "', PRIORIDAD ='" + Me.Prioridad + "' WHERE IDPATOLOGIA = " + Me.IdPatologia
        Comando.ExecuteNonQuery()
    End Sub


End Class
