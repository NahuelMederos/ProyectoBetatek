Imports System.Data.Odbc

Public MustInherit Class ModeloConexion

    Public DbDriver As String = "MySQL ODBC 8.0 UNICODE Driver"
    Public DbUser As String
    Public DbPassword As String
    Public DbPort As String = "3306"
    Public DbName As String = "betatek"
    Public DbHost As String = "localhost"

    Public Conexion As New OdbcConnection()

    Public Comando As New OdbcCommand
    Public Reader As OdbcDataReader

    Public Sub New(username As String, password As String)
        Me.DbUser = username
        Me.DbPassword = password

        Me.Conexion.ConnectionString = "DRIVER=" + Me.DbDriver +
                                          ";UID=" + Me.DbUser +
                                          ";PWD=" + Me.DbPassword +
                                          ";PORT=" + Me.DbPort +
                                          ";DATABASE=" + Me.DbName +
                                          ";SERVER=" + Me.DbHost
        Me.Conexion.Open()
        Me.Comando.Connection = Me.Conexion
    End Sub




End Class
