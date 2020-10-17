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

    Public Function ObtenerDiagnosticos()

        Comando.CommandText = "Select Diagnostico.Prioridad,Recibe.IdDiagnostico As Id,Informacion,FechaHora
                               From Recibe,Diagnostico
                               Where Recibe.IdDiagnostico=Diagnostico.IdDiagnostico
                               And NombreMedico='Medico'
                               Order by
                                      Case
                                         when Diagnostico.Prioridad= 'Alta' Then 1 
                                         when Diagnostico.Prioridad= 'Media' Then 2
                                         when Diagnostico.Prioridad= 'Baja' Then 3
                                        END;"

        Reader = Comando.ExecuteReader()
        Return Reader

    End Function

End Class
