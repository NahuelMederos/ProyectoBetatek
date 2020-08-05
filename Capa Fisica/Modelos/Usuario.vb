Public Class Usuario
    Inherits ModeloConexion

    Public IdUsuario As String
    Public CI As String
    Public Nombre As String
    Public Apellido As String
    Public edad As String
    Public Mail As String
    Public Tipo As String
    Public Estado As String

    Public Sub AltaUsuario()

        Comando.CommandText() = "INSERT INTO USUARIO VALUES(null," + Me.CI + ",'" + Me.Nombre + "','" + Me.Apellido + "'," + Me.edad + ",'" + Me.Mail + "');"

        Comando.ExecuteNonQuery()
    End Sub

    Public Sub AltaMedico()

        Comando.CommandText = "SET AUTOCOMMIT = OFF"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "LOCK TABLES Usuario ,Medico READ"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "START TRANSACTION"
        Comando.ExecuteNonQuery()
        Try
            Comando.CommandText = "INSERT INTO Usuario VALUES(null," + Me.CI + ",'" + Me.Nombre + "','" + Me.Apellido + "'," + Me.edad + ",'" + Me.Mail + "');"

            Comando.ExecuteNonQuery()

            Me.IdUsuario = Comando.CommandText() = "SELECT IdUsuario FROM USUARIO WEHRE CI =" + Me.CI

            Comando.ExecuteNonQuery()

            Comando.CommandText = "INSERT INTO Medico VALUES(" + Me.IdUsuario + ")"

            Comando.ExecuteNonQuery()

            Comando.CommandText = "COMMIT"
            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Comando.CommandText = "ROLLBACK"
            Comando.ExecuteNonQuery()


        End Try
        Comando.CommandText = "UNLOKE TABLES"
        Comando.ExecuteNonQuery()

    End Sub

    Public Sub AltaAdmin()


        Comando.CommandText = "SET AUTOCOMMIT = OFF"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "LOCK TABLES Usuario ,Medico READ"
        Comando.ExecuteNonQuery()

        Comando.CommandText = "START TRANSACTION"
        Comando.ExecuteNonQuery()

        Try
            Comando.CommandText = "INSERT INTO Usuario VALUES(null," + Me.CI + ",'" + Me.Nombre + "','" + Me.Apellido + "'," + Me.edad + ",'" + Me.Mail + "');"

            Comando.ExecuteNonQuery()

            Me.IdUsuario = Comando.CommandText() = "SELECT IdUsuario FROM USUARIO WEHRE CI =" + Me.CI

            Comando.ExecuteNonQuery()

            Comando.CommandText = "INSERT INTO Administrador VALUES(" + Me.IdUsuario + ")"

            Comando.ExecuteNonQuery()

            Comando.CommandText = "COMMIT"
            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Comando.CommandText = "ROLLBACK"
            Comando.ExecuteNonQuery()


        End Try
        Comando.CommandText = "UNLOKE TABLES"
        Comando.ExecuteNonQuery()
    End Sub


    Public Sub BajaUsuario(ci As String)
        Comando.CommandText = "UPDATE Usuario SET Estado = " + Me.Estado + "WHERE CI =" + ci
        Comando.ExecuteNonQuery()
    End Sub

    Public Function listar()
        'listar de acuerdo al tipo y al estado, Puedes listar, solo admins, solo medicos y determinar su baja o alta.
        Comando.CommandText = "SELECT * FROM Usuario where Tipo ='" + Me.Tipo + "' AND Estado = " + Me.Estado
        Comando.ExecuteReader()


        Return Reader
    End Function






End Class


