Public Class Usuarios
    Inherits ModeloConexion

    Public Sub New(username As String, password As String)
        MyBase.New(username, password)

    End Sub

    Public NombreUsuario As String
    Public Contraseña As String
    Public Nombre As String
    Public Apellido As String
    Public Cedula As String


    Public Sub CrearGestor()
        Comando.CommandText = "START TRANSACTION;"
        Comando.ExecuteNonQuery()

        Try
            Comando.CommandText = "CREATE USER '" + Me.NombreUsuario + "'@'localhost' IDENTIFIED BY '" + Me.Contraseña + "';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT ALL PRIVILEGES ON betatek.* TO '" + Me.NombreUsuario + "'@'localhost' WITH GRANT OPTION;"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT CREATE USER ON *.* TO '" + Me.NombreUsuario + "'@'localhost' WITH GRANT OPTION;"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "INSERT INTO ADMINISTRATIVO VALUES('" + Me.NombreUsuario + "','" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Cedula + "');"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "COMMIT;"
            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Comando.CommandText = "ROLLBACK;"
        Comando.ExecuteNonQuery()

        End Try
    End Sub

    Public Function AutenticarGestor()

        Comando.CommandText = "SELECT COUNT(NombreUsuario) FROM ADMINISTRATIVO
                               WHERE NombreUsuario='" + Me.DbUser + "';"


        Return Comando.ExecuteScalar().ToString()

    End Function

    Public Sub CrearMedico()
        Comando.CommandText = "START TRANSACTION;"
        Comando.ExecuteNonQuery()

        Try
            Comando.CommandText = "CREATE USER '" + Me.NombreUsuario + "'@'localhost' IDENTIFIED BY '" + Me.Contraseña + "';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT ALL PRIVILEGES  ON betatek.* TO '" + Me.NombreUsuario + "'@'localhost' WITH GRANT OPTION;"
            Comando.ExecuteNonQuery()


            Comando.CommandText = "INSERT INTO MEDICO VALUES('" + Me.NombreUsuario + "','" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Cedula + "');"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "COMMIT;"
            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Comando.CommandText = "ROLLBACK;"
            Comando.ExecuteNonQuery()

        End Try

    End Sub

    Public Function AutenticarMedico()

        Comando.CommandText = "SELECT COUNT(NombreUsuario) FROM Medico
                               WHERE NombreUsuario='" + Me.DbUser + "';"


        Return Comando.ExecuteScalar().ToString()

    End Function

End Class


