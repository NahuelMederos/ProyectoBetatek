Imports System.Data.Odbc

Public MustInherit Class ModeloConexion

    Public DbDriver As String = "MySQL ODBC 8.0 UNICODE Driver"
    Public DbUser As String = "root"
    Public DbPassword As String = "Tooroot123654"
    Public DbPort As String = "3306"
    Public DbName As String = "betatek"
    Public DbHost As String = "localhost"

    Public Conexion As New OdbcConnection("DRIVER=" + Me.DbDriver +
                                          ";UID=" + Me.DbUser +
                                          ";PWD=" + Me.DbPassword +
                                          ";PORT=" + Me.DbPort +
                                          ";DATABASE=" + Me.DbName +
                                          ";SERVER=" + Me.DbHost)

    Public Comando As New OdbcCommand
    Public Reader As OdbcDataReader

    Public Sub New()
        Me.Conexion.Open()
        Me.Comando.Connection = Me.Conexion

    End Sub

End Class
