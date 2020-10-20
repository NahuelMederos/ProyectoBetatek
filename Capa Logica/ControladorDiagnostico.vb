Imports Capa_Fisica

Public Module ControladorDiagnostico

    Public Sub CrearDiagnostico(Sintomas As String, Patologias As String, Usuario As String, Prioridad As String, SolicitaChat As String)
        Dim d As New Diagnostico(Sesion.Username, Sesion.Password)
        Dim Informacion As String = "El paciente " + Usuario + " solicito un diagnostico presentando los siguientes sintomas: " + Sintomas + " El Diagnostico automatico le dio como resultado: " & Chr(34) + Patologias & Chr(34)
        d.CiPaciente = Usuario
        d.Informacion = Informacion
        d.Prioridad = Prioridad
        d.SolicitaChat = SolicitaChat

        d.CrearDiagnostico()
        d.PacienteGeneraDiagnostico

    End Sub

    Public Sub EnviarDiagnostico(IdDiagnostico As String)
        Dim d As New Diagnostico(Sesion.Username, Sesion.Password)
        d.IdDiagnostico = IdDiagnostico

        d.EnviarDiagnosticoAMedico()

    End Sub

    Public Function BuscarUltimoDiagnostico()
        Dim d As New Diagnostico(Username, Password)
        Return d.UltimoDiagnostico()

    End Function

    Public Function ListarDiagnosticos()
        Dim d As New Diagnostico(Sesion.Username, Sesion.Password)
        d.NombreMedico = Sesion.Username

        Return d.ObtenerDiagnosticos

    End Function

    Public Sub ModificarNombreRecibe(IdDiagnostico As String)
        Dim d As New Diagnostico(Sesion.Username, Sesion.Password)
        d.IdDiagnostico = IdDiagnostico
        d.NombreMedico = Sesion.Username

        d.ModificarNombreEnRecibe
    End Sub
End Module
