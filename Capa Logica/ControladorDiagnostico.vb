﻿Imports Capa_Fisica

Public Module ControladorDiagnostico

    Public Sub CrearDiagnostico(Sintomas As String, Patologias As String, Usuario As String, Prioridad As String, SolicitaChat As String, ListaSintomas As List(Of String))
        Dim d As New Diagnostico(Sesion.Username, Sesion.Password)
        Dim Informacion As String = "El paciente " + Usuario + " solicito un diagnostico presentando los siguientes sintomas: " + Sintomas + " El Diagnostico automatico le dio como resultado: " & Chr(34) + Patologias & Chr(34)
        d.CiPaciente = Usuario
        d.Informacion = Informacion
        d.Prioridad = Prioridad
        d.SolicitaChat = SolicitaChat

        Try
            d.CrearDiagnostico()
            For Each Sintoma In ListaSintomas
                d.IdSintoma = Sintoma
                d.PacienteGeneraDiagnostico()
                Try
                    d.PacienteTieneSintomas()
                Catch ex As Exception
                End Try
            Next
        Catch ex As Exception
        End Try

    End Sub

    Public Sub EnviarDiagnostico(IdDiagnostico As String)
        Dim d As New Diagnostico(Sesion.Username, Sesion.Password)
        d.IdDiagnostico = IdDiagnostico

        d.EnviarDiagnosticoAMedico()

    End Sub

    Public Sub DiagnosticoTienePatologias(IdDiagnostico As String, ListaPatologias As List(Of String))
        Dim d As New Diagnostico(Sesion.Username, Sesion.Password)
        d.IdDiagnostico = IdDiagnostico

        For Each Patologia In ListaPatologias
            d.IdPatologia = Patologia
            d.AgregarPatologiaADiagnostico()
        Next

    End Sub

    Public Function BuscarUltimoDiagnostico()
        Dim d As New Diagnostico(Username, Password)
        Return d.UltimoDiagnostico()

    End Function

    Public Function BuscarUltimoDiagnosticoEnRecibe()
        Dim d As New Diagnostico(Username, Password)
        Return d.UltimoDiagnosticoEnRecibe()

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

    Public Function HistorialDeDiagnosticos()
        Dim d As New Diagnostico(Username, Password)
        Return d.ListarDiagnosticos()

    End Function

    Public Function ObtenerDiagnosticosAntiguos(Opcion As Integer)
        Dim d As New Diagnostico(Username, Password)
        d.Opcion = Opcion
        If Opcion = 1 Then
            d.CiPaciente = Sesion.Username
            Return d.ObtenerDiagnosticosAntiguos
        Else
            d.NombreMedico = Sesion.Username
            Return d.ObtenerDiagnosticosAntiguos
        End If

    End Function

End Module
