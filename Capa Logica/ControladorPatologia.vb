﻿Imports Capa_Fisica

Public Module ControladorPatologia

    Public Sub CrearPatologia(Nombre As String, Prioridad As String)
        Dim p As New Patologia(Sesion.Username, Sesion.Password)
        p.Nombre = Nombre
        p.Prioridad = Prioridad

        If String.Compare(p.EstadoPatologia(), 0) = 0 Then
            p.ActivarPatologia()
        Else
            p.AltaPatologia()
        End If

    End Sub

    Public Sub BorrarPatologia(Id As String)
        Dim p As New Patologia(Sesion.Username, Sesion.Password)
        p.IdPatologia = Id

        p.BajaPatologia()

    End Sub

    Public Sub ModificarPatologia(Id As String, Nombre As String, Prioridad As String)
        Dim p As New Patologia(Sesion.Username, Sesion.Password)

        p.IdPatologia = Id
        p.Nombre = Nombre
        p.Prioridad = Prioridad

        p.Modificar()
    End Sub

    Public Function ListarPatologias()
        Dim p As New Patologia(Sesion.Username, Sesion.Password)

        Return p.ObtenerPatologia()

    End Function

    Public Function ObtenerPrioridad(Nombre As String)
        Dim p As New Patologia(Sesion.Username, Sesion.Password)
        p.Nombre = Nombre

        Return p.ObtenerPrioridadPatologia

    End Function

    Public Function ObtenerIdPatologia(Nombre As String)
        Dim p As New Patologia(Sesion.Username, Sesion.Password)
        p.Nombre = Nombre

        Return p.BuscarIdPatologia

    End Function

End Module
