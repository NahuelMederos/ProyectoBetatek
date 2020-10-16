Public Class Diagnostico
    Inherits ModeloConexion

    Public Informacion As String
    Public Prioridad As String
    Public SolicitaChat As String
    Public IdDiagnostico As String

    Public Sub New(username As String, password As String)
        MyBase.New(username, password)

    End Sub

    Public Sub CrearDiagnostico()
        Comando.CommandText = "INSERT INTO DIAGNOSTICO VALUES(LAST_INSERT_ID(),'" + Me.Prioridad + "','" + Me.Informacion + "'," + SolicitaChat + ")"

        Comando.ExecuteNonQuery()

    End Sub

    Public Sub EnviarDiagnosticoAMedico()
        Comando.CommandText = "INSERT INTO RECIBE VALUES(" + Me.IdDiagnostico + ",'Medico','" + Me.Prioridad + "',now())"

        Comando.ExecuteNonQuery()

    End Sub

    Public Function UltimoDiagnostico()
        Me.Comando.CommandText = "SELECT MAX(IdDiagnostico) FROM Diagnostico"

        Return Comando.ExecuteScalar().ToString()
    End Function


End Class
