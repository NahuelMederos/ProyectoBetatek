Imports Capa_Fisica

Public Module ControladorPatologia

    Public Sub CrearPatologia(Id As String, Nombre As String, Prioridad As String)
        Dim p As New Patologia
        p.IdPatologia = Id
        p.Nombre = Nombre
        p.Prioridad = Prioridad

        p.AltaPatologia()

    End Sub

    Public Sub BorrarPatologia(Id As String)
        Dim p As New Patologia
        p.IdPatologia = Id

        p.BajaPatologia()

    End Sub

    Public Sub ModificarPatologia(Id As String, Nombre As String, Prioridad As String)
        Dim p As New Patologia

        p.IdPatologia = Id
        p.Nombre = Nombre
        p.Prioridad = Prioridad

        p.Modificar()
    End Sub

    Public Function ListarPatologias()
        Dim p As New Patologia

        Return p.ObtenerPatologia()

    End Function

End Module
