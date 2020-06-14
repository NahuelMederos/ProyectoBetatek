Public Class Sintoma
    Inherits ModeloConexion


    Public IdSintoma As String
    Public Nombre As String
    Public Prioriad As String


    Public Function obtenerSintomas()

        Comando.CommandText = "SELECT * from SINTOMA"

        Reader = Comando.ExecuteReader()
        Return Reader

    End Function




End Class
