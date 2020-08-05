Imports Capa_Fisica



Public Module ControladorUsuarios


    Public Sub AltaMedico(ci As String, Nombre As String, apellido As String, edad As String, mail As String, tipo As String, estado As String)
        Dim u As New Usuario

        u.CI = ci
        u.Nombre = Nombre
        u.Apellido = apellido
        u.edad = edad
        u.Mail = mail
        u.Tipo = tipo
        u.Estado = estado
        u.AltaMedico()


    End Sub

    Public Sub AltaAdmin(ci As String, Nombre As String, apellido As String, edad As String, mail As String, tipo As String, estado As String)
        Dim u As New Usuario

        u.CI = ci
        u.Nombre = Nombre
        u.Apellido = apellido
        u.edad = edad
        u.Mail = mail
        u.Tipo = tipo
        u.Estado = estado
        u.AltaAdmin()


    End Sub

    Public Sub BajaMedico(ci As String)
        Dim u As New Usuario
        u.CI = ci

    End Sub

    Public Sub BajaAdmin(ci As String)
        Dim u As New Usuario
        u.CI = ci

    End Sub

End Module
