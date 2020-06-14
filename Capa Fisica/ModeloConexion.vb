Imports System.Data.Odbc


Public MustInherit Class ModeloConexion

    Public DbDriver As String = "MySQL ODBC 8.0 ANSI Driver"
    Public DbUser As String = "root"
    Public dbPassword As String = ""
    Public DbName As String = ""
    Public dbHost As String = "LocalHost"

    Public Conexion As New OdbcConnection("DRIVER =" + Me.DbDriver +
                                           ";UID = " + Me.DbUser +
                                           ";PWD = " + Me.dbPassword +
                                           ";DATABASE = " + Me.DbName +
                                           ";SERVER = " + Me.dbHost)

    Public Comando As New OdbcCommand
    Public Reader As OdbcDataReader


    Public Sub New()
        Me.conexion.Open()
        Me.Comando.Connection = Me.Conexion

    End Sub


End Class
