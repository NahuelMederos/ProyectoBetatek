Public Class Persona
    Inherits ModeloConexion

    Public Ci As String
    Public Nombre As String
    Public Apellido As String
    Public Calle As String
    Public Esquina As String
    Public Numero As String
    Public Edad As String
    Public Mail As String

    Public Sub AltaPersona()
        Comando.CommandText = "INSERT INTO Persona VALUES(" + Me.Ci + ",'" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Calle + "','" + Me.Esquina + "'," + Me.Numero + "," + Me.Edad + ",'" + Me.Mail + "')"

        Comando.ExecuteNonQuery()

    End Sub


    Public Sub Borrar()
        Comando.CommandText = "DELETE FROM Persona WHERE Ci = " + Me.Ci
        Comando.ExecuteNonQuery()

    End Sub

    Public Sub listar()

    End Sub




    Public Function obtenerDiagnostico()

        Comando.CommandText = "SELECT * FROM GENERA WHERE CI_PERSONA = " + Me.Ci
        Reader = Comando.ExecuteReader()
        Return Reader

    End Function






End Class
