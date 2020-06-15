

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

    Public Sub AltaSintoma()
        Comando.CommandText = "INSERT INTO Patologia VALUES(" + Me.IdPatologia + ",'" + Me.Nombre + "','" + Me.Prioridad + "')"

        Comando.ExecuteNonQuery()

    End Sub

    Public Sub BajaSintoma()
        Comando.CommandText = "DELETED FROM PATOLOGIA WHERE IdPatologia = " + Me.IdPatologia

        Comando.ExecuteNonQuery()

    End Sub

    Public Sub Modificar()

        Comando.CommandText = "UPDATE PATOLOGIA SET nombre = '" + Me.Nombre + "', PRIORIDAD ='" + Me.Prioridad + "' WHERE IdPatologia = " + Me.IdPatologia
        Comando.ExecuteNonQuery()
    End Sub


End Class
