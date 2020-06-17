Imports Capa_Fisica


Module ControladorPersona


    Public Sub DarAlta(ci As String, nombre As String, apellido As String, calle As String, esquina As String, numero As String, edad As String, mail As String)
        Dim p As New Persona
        p.Ci = ci
        p.Nombre = nombre
        p.Apellido = apellido
        p.Calle = calle
        p.Esquina = esquina
        p.Numero = numero
        p.Edad = edad
        p.Mail = mail

        p.AltaPersona()
    End Sub




End Module
