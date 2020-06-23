Imports System.Data.Odbc
Public Class Login

    Inherits ModeloConexion

    Public user As String
    Public pass As String

    Shadows DbDriver As String = "MySQL ODBC 8.0 UNICODE Driver"
    Shadows DbPort As String = "3306"
    Shadows DbName As String = "betatek"
    Shadows DbHost As String = "localhost"

    Public Sub Autenticarse()
        Dim Login As New OdbcConnection("DRIVER=" + Me.DbDriver +
                                          ";UID=" + Me.user +
                                          ";PWD=" + Me.pass +
                                          ";PORT=" + Me.DbPort +
                                          ";DATABASE=" + Me.DbName +
                                          ";SERVER=" + Me.DbHost)

        Login.Open()
        Login.Close()

    End Sub

End Class

