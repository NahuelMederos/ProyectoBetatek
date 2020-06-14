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
        Comando.CommandText = "INSERT INTO Persona (" + Me.Ci + ",'" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Calle + "','" + Me.Esquina + "'," + Me.Numero + "," + Me.Edad + ",'" + Me.Mail + "')"

        Comando.ExecuteNonQuery()

    End Sub


End Class
