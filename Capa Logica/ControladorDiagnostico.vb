Imports Capa_Fisica

Public Module ControladorDiagnostico

    Public Sub CrearDiagnostico(Sintomas As String, Patologias As String, Usuario As String, Prioridad As String, SolicitaChat As String)
        Dim d As New Diagnostico(Sesion.Username, Sesion.Password)
        Dim Informacion As String = "El paciente " + Usuario + " solicito un diagnostico presentando los siguientes sintomas: " + Sintomas + "El Diagnostico automatico le dio como resultado:" + Patologias
        d.Informacion = Informacion
        d.Prioridad = Prioridad
        d.SolicitaChat = SolicitaChat

        d.CrearDiagnostico()
    End Sub

    Public Sub EnviarDiagnostico(IdDiagnostico As String, Prioridad As String)
        Dim d As New Diagnostico(Sesion.Username, Sesion.Password)
        d.IdDiagnostico = IdDiagnostico
        d.Prioridad = Prioridad

        d.EnviarDiagnosticoAMedico()

    End Sub

    Public Function BuscarUltimoDiagnostico()
        Dim d As New Diagnostico(Username, Password)
        Return d.UltimoDiagnostico()

    End Function

    Public Function ListarDiagnosticos()
        Dim d As New Diagnostico(Sesion.Username, Sesion.Password)

        Return d.ObtenerDiagnosticos

    End Function
End Module
