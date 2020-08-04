Imports Capa_Fisica

Public Module ControladorLogin

    Public Sub Autenticarse(User As String, Password As String)
        Dim a As New Login
        a.user = User
        a.pass = Password

        a.Autenticarse()

    End Sub

End Module
