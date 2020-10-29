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
    Public Edad As String
    Public Mail As String

    Public Sub CrearGestor()
        Try
            Comando.CommandText = "DROP USER '" + Me.NombreUsuario + "'@'localhost'"
            Comando.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Comando.CommandText = "START TRANSACTION;"
        Comando.ExecuteNonQuery()

        Try
            Comando.CommandText = "CREATE USER '" + Me.NombreUsuario + "'@'localhost' IDENTIFIED BY '" + Me.Contraseña + "';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT ALL PRIVILEGES ON betatek.* TO '" + Me.NombreUsuario + "'@'localhost' WITH GRANT OPTION;"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT ON MYSQL.USER TO '" + Me.NombreUsuario + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT CREATE USER ON *.* TO '" + Me.NombreUsuario + "'@'localhost' WITH GRANT OPTION;"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "INSERT INTO ADMINISTRATIVO VALUES('" + Me.NombreUsuario + "','" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Cedula + "',DEFAULT);"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "COMMIT;"
            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Comando.CommandText = "ROLLBACK;"
            Comando.ExecuteNonQuery()

        End Try
    End Sub

    Public Function AutenticarGestor()

        Comando.CommandText = "SELECT COUNT(NombreUsuario) FROM Administrativo
                               WHERE NombreUsuario='" + Me.DbUser + "'
                               And Activo=1;"


        Return Comando.ExecuteScalar().ToString()

    End Function

    Public Sub CrearMedico()
        Try
            Comando.CommandText = "DROP USER '" + Me.NombreUsuario + "'@'localhost'"
            Comando.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Comando.CommandText = "START TRANSACTION;"
        Comando.ExecuteNonQuery()

        Try
            Comando.CommandText = "CREATE USER '" + Me.NombreUsuario + "'@'localhost' IDENTIFIED BY '" + Me.Contraseña + "';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT SELECT on betatek.Medico TO '" + Me.NombreUsuario + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT SELECT,UPDATE on betatek.Recibe TO '" + Me.NombreUsuario + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT SELECT on betatek.Genera TO '" + Me.NombreUsuario + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT SELECT on betatek.Diagnostico TO '" + Me.NombreUsuario + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT INSERT,UPDATE,SELECT ON betatek.Chatea TO '" + Me.NombreUsuario + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT SELECT ON betatek.PERSONA TO '" + Me.NombreUsuario + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "INSERT INTO MEDICO VALUES('" + Me.NombreUsuario + "','" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Cedula + "',DEFAULT);"
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
                               WHERE NombreUsuario='" + Me.DbUser + "'
                               And Activo=1;"


        Return Comando.ExecuteScalar().ToString()

    End Function

    Public Sub CrearPaciente()
        Try
            Comando.CommandText = "DROP USER '" + Me.NombreUsuario + "'@'localhost'"
            Comando.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Comando.CommandText = "START TRANSACTION;"
        Comando.ExecuteNonQuery()

        Try

            Comando.CommandText = "CREATE USER '" + Me.NombreUsuario + "'@'localhost' IDENTIFIED BY '" + Me.Contraseña + "';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT INSERT,UPDATE,SELECT ON betatek.Chatea TO '" + Me.NombreUsuario + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT UPDATE (Nombre,Apellido,Edad,Mail),SELECT ON betatek.Persona TO '" + Me.NombreUsuario + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT SELECT ON betatek.Medico TO '" + Me.NombreUsuario + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT INSERT ON betatek.Genera TO '" + Me.NombreUsuario + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT INSERT ON betatek.Patologias TO '" + Me.NombreUsuario + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT INSERT,SELECT,UPDATE ON betatek.Recibe TO '" + Me.NombreUsuario + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT SELECT,INSERT ON betatek.Diagnostico TO '" + Me.NombreUsuario + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT SELECT ON betatek.Sintoma TO '" + Me.NombreUsuario + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT SELECT ON betatek.Patologia TO '" + Me.NombreUsuario + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT SELECT ON betatek.Patologia_Sintomas TO '" + Me.NombreUsuario + "'@'localhost';"
            Comando.ExecuteNonQuery()


            Comando.CommandText = "INSERT INTO PERSONA VALUES('" + Me.NombreUsuario + "','" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Edad + "','" + Me.Mail + "',DEFAULT);"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "COMMIT;"
            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Comando.CommandText = "ROLLBACK;"
            Comando.ExecuteNonQuery()

        End Try
    End Sub

    Public Function AutenticarPaciente()

        Comando.CommandText = "SELECT COUNT(CI) FROM Persona
                               WHERE CI='" + Me.DbUser + "'
                               And Activo=1;"


        Return Comando.ExecuteScalar().ToString()
    End Function


    Public Sub DesactivarPaciente()
        Comando.CommandText = "update Persona set activo=0 where Ci='" + Me.NombreUsuario + "'"

        Comando.ExecuteNonQuery()
    End Sub

    Public Sub DesactivarMedico()
        Comando.CommandText = "update Medico set activo=0 where NombreUsuario='" + Me.NombreUsuario + "'"

        Comando.ExecuteNonQuery()

    End Sub

    Public Sub DesactivarGestor()
        Comando.CommandText = "update Administrativo set activo=0 where NombreUsuario='" + Me.NombreUsuario + "'"

        Comando.ExecuteNonQuery()
    End Sub



    Public Function VerificarCedulaMedico()
        Comando.CommandText = "SELECT COUNT(Cedula) FROM Medico
                               WHERE Cedula='" + Me.Cedula + "';"
        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function VerificarCedulaGestor()
        Comando.CommandText = "SELECT COUNT(Cedula) FROM Administrativo
                               WHERE Cedula='" + Me.Cedula + "';"
        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function VerificarMailPaciente()
        Comando.CommandText = "SELECT COUNT(Mail) FROM Persona
                               WHERE Mail='" + Me.Mail + "';"
        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function VerificarUsuarioMySQL()
        Comando.CommandText = "SELECT COUNT(USER) FROM mysql.user
                               WHERE USER='" + Me.NombreUsuario + "';"

        Return Comando.ExecuteScalar().ToString()
    End Function


    Public Function ObtenerNombrePaciente()
        Comando.CommandText = "SELECT Nombre 
                               FROM PERSONA 
                               WHERE Ci='" + Me.NombreUsuario + "';"
        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function ObtenerApellidoPaciente()
        Comando.CommandText = "SELECT Apellido
                               FROM PERSONA 
                               WHERE Ci='" + Me.NombreUsuario + "';"

        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function ObtenerEdadPaciente()
        Comando.CommandText = "SELECT Edad
                               FROM PERSONA 
                               WHERE Ci='" + Me.NombreUsuario + "';"

        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function ObtenerMailPaciente()
        Comando.CommandText = "SELECT Mail 
                               FROM PERSONA 
                               WHERE Ci='" + Me.NombreUsuario + "';"

        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function ObtenerNombreMedico()
        Comando.CommandText = "SELECT Nombre
                               FROM Medico
                               WHERE NombreUsuario='" + Me.NombreUsuario + "';"

        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function ObtenerApellidoMedico()
        Comando.CommandText = "SELECT Apellido
                               FROM Medico
                               WHERE NombreUsuario='" + Me.NombreUsuario + "';"

        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function ObtenerCedulaMedico()
        Comando.CommandText = "SELECT Cedula
                               FROM Medico
                               WHERE NombreUsuario='" + Me.NombreUsuario + "';"

        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function ObtenerNombreGestor()
        Comando.CommandText = "SELECT Nombre
                               FROM Administrativo
                               WHERE NombreUsuario='" + Me.NombreUsuario + "';"

        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function ObtenerApellidoGestor()
        Comando.CommandText = "SELECT Apellido
                               FROM Administrativo
                               WHERE NombreUsuario='" + Me.NombreUsuario + "';"

        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function ObtenerCedulaGestor()
        Comando.CommandText = "SELECT Cedula
                               FROM Administrativo
                               WHERE NombreUsuario='" + Me.NombreUsuario + "';"

        Return Comando.ExecuteScalar().ToString()
    End Function


    Public Sub ModificarPaciente()
        Comando.CommandText = "Update Persona set Nombre='" + Me.Nombre + "',Apellido='" + Me.Apellido + "',Edad='" + Me.Edad + "',Mail='" + Me.Mail + "' where Ci='" + Me.Cedula + "'"
        Comando.ExecuteNonQuery()
    End Sub

    Public Sub ModificarMedico()
        Comando.CommandText = "Update Medico set Nombre='" + Me.Nombre + "',Apellido='" + Me.Apellido + "',Cedula='" + Me.Cedula + "' where NombreUsuario='" + Me.NombreUsuario + "'"
        Comando.ExecuteNonQuery()
    End Sub

    Public Sub ModificarGestor()
        Comando.CommandText = "Update Administrativo set Nombre='" + Me.Nombre + "',Apellido='" + Me.Apellido + "',Cedula='" + Me.Cedula + "' where NombreUsuario='" + Me.NombreUsuario + "'"
        Comando.ExecuteNonQuery()
    End Sub

    Public Function ListarPacientes()
        Comando.CommandText = "SELECT Ci,Nombre,Apellido,Edad,Mail FROM Persona where Activo=1"

        Me.Reader = Comando.ExecuteReader()
        Return Me.Reader
    End Function

    Public Function ListarMedicos()
        Comando.CommandText = "SELECT NombreUsuario as Usuario,Nombre,Apellido,Cedula FROM Medico where Activo=1"

        Me.Reader = Comando.ExecuteReader()
        Return Me.Reader
    End Function

    Public Function ListarGestores()
        Comando.CommandText = "SELECT NombreUsuario as Usuario,Nombre,Apellido,Cedula FROM Administrativo where Activo=1"

        Me.Reader = Comando.ExecuteReader()
        Return Me.Reader
    End Function

    Public Function EstadoDePaciente()
        Try
            Comando.CommandText = "Select Activo from persona where Ci='" + Me.NombreUsuario + "'"
            Return Comando.ExecuteScalar().ToString()
        Catch ex As Exception
            Return "1"
        End Try

    End Function

    Public Function EstadoDeMedico()
        Try
            Comando.CommandText = "Select Activo from Medico where NombreUsuario='" + Me.NombreUsuario + "'"
            Return Comando.ExecuteScalar().ToString()
        Catch ex As Exception
            Return "1"
        End Try

    End Function

    Public Function EstadoDeGestor()
        Try
            Comando.CommandText = "Select Activo from Administrativo where NombreUsuario='" + Me.NombreUsuario + "'"
            Return Comando.ExecuteScalar().ToString()
        Catch ex As Exception
            Return "1"
        End Try

    End Function


    Public Sub ActivarPaciente()
        Comando.CommandText = "update Persona set activo=1 where Ci='" + Me.NombreUsuario + "'"

        Comando.ExecuteNonQuery()
    End Sub

    Public Sub ActivarMedico()
        Comando.CommandText = "update Medico set activo=1 where NombreUsuario='" + Me.NombreUsuario + "'"

        Comando.ExecuteNonQuery()
    End Sub

    Public Sub ActivarGestor()
        Comando.CommandText = "update Administrativo set activo=1 where NombreUsuario='" + Me.NombreUsuario + "'"

        Comando.ExecuteNonQuery()
    End Sub
End Class


