
Imports Capa_Fisica

Public Module ControladorTiene

    Public Sub GuardarSintomasPersona(ci As String, idSintoma As String)
        Dim p As New Tiene(Sesion.Username, Sesion.Password)

        p.CiPersona = ci
        p.IdSintoma = idSintoma


        p.GuardarSintomasDePersona()

    End Sub


End Module
