Public Class Usuarios
    Inherits ModeloConexion

    Public Sub New(username As String, password As String)
        MyBase.New(username, password)

    End Sub

    Public NOMBREUSUARIO As String
    Public Contraseña As String
    Public NOMBRE As String
    Public APELLIDO As String
    Public CEDULA As String
    Public EDAD As String
    Public MAIL As String

    Public Sub CrearGestor()
        Try
            Comando.CommandText = "DROP USER '" + Me.NOMBREUSUARIO + "'@'localhost'"
            Comando.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Comando.CommandText = "START TRANSACTION;"
        Comando.ExecuteNonQuery()

        Try
            Comando.CommandText = "CREATE USER '" + Me.NOMBREUSUARIO + "'@'localhost' IDENTIFIED BY '" + Me.Contraseña + "';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT ALL PRIVILEGES ON betatek.* TO '" + Me.NOMBREUSUARIO + "'@'localhost' WITH GRANT OPTION;"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT SELECT ON MYSQL.USER TO '" + Me.NOMBREUSUARIO + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "GRANT CREATE USER ON *.* TO '" + Me.NOMBREUSUARIO + "'@'localhost' WITH GRANT OPTION;"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "INSERT INTO ADMINISTRATIVO VALUES('" + Me.NOMBREUSUARIO + "','" + Me.NOMBRE + "','" + Me.APELLIDO + "','" + Me.CEDULA + "',DEFAULT);"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "COMMIT;"
            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Comando.CommandText = "ROLLBACK;"
            Comando.ExecuteNonQuery()

        End Try
    End Sub

    Public Function AutenticarGestor()

        Comando.CommandText = "SELECT COUNT(NOMBREUSUARIO) FROM ADMINISTRATIVO
                               WHERE NOMBREUSUARIO='" + Me.DbUser + "'
                               AND ACTIVO=1;"


        Return Comando.ExecuteScalar().ToString()

    End Function

    Public Sub CrearMedico()
        Try
            Comando.CommandText = "DROP USER '" + Me.NOMBREUSUARIO + "'@'localhost'"
            Comando.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Comando.CommandText = "START TRANSACTION;"
        Comando.ExecuteNonQuery()

        Try
            Comando.CommandText = "CREATE USER '" + Me.NOMBREUSUARIO + "'@'localhost' IDENTIFIED BY '" + Me.Contraseña + "';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT SELECT on betatek.MEDICO TO '" + Me.NOMBREUSUARIO + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT SELECT,UPDATE on betatek.RECIBE TO '" + Me.NOMBREUSUARIO + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT SELECT on betatek.GENERA TO '" + Me.NOMBREUSUARIO + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT SELECT on betatek.DIAGNOSTICO TO '" + Me.NOMBREUSUARIO + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT INSERT,UPDATE,SELECT ON betatek.CHATEA TO '" + Me.NOMBREUSUARIO + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT SELECT ON betatek.PERSONA TO '" + Me.NOMBREUSUARIO + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "INSERT INTO MEDICO VALUES('" + Me.NOMBREUSUARIO + "','" + Me.NOMBRE + "','" + Me.APELLIDO + "','" + Me.CEDULA + "',DEFAULT);"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "COMMIT;"
            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Comando.CommandText = "ROLLBACK;"
            Comando.ExecuteNonQuery()

        End Try

    End Sub

    Public Function AutenticarMedico()

        Comando.CommandText = "SELECT COUNT(NOMBREUSUARIO) FROM MEDICO
                               WHERE NOMBREUSUARIO='" + Me.DbUser + "'
                               AND ACTIVO=1;"


        Return Comando.ExecuteScalar().ToString()

    End Function

    Public Sub CrearPaciente()
        Try
            Comando.CommandText = "DROP USER '" + Me.NOMBREUSUARIO + "'@'localhost'"
            Comando.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Comando.CommandText = "START TRANSACTION;"
        Comando.ExecuteNonQuery()

        Try

            Comando.CommandText = "CREATE USER '" + Me.NOMBREUSUARIO + "'@'localhost' IDENTIFIED BY '" + Me.Contraseña + "';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT INSERT,UPDATE,SELECT ON betatek.CHATEA TO '" + Me.NOMBREUSUARIO + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT UPDATE (NOMBRE,APELLIDO,EDAD,MAIL),SELECT ON betatek.PERSONA TO '" + Me.NOMBREUSUARIO + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT SELECT ON betatek.MEDICO TO '" + Me.NOMBREUSUARIO + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT INSERT ON betatek.GENERA TO '" + Me.NOMBREUSUARIO + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT INSERT ON betatek.PATOLOGIAS TO '" + Me.NOMBREUSUARIO + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT INSERT,SELECT,UPDATE ON betatek.RECIBE TO '" + Me.NOMBREUSUARIO + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT SELECT,INSERT ON betatek.DIAGNOSTICO TO '" + Me.NOMBREUSUARIO + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT SELECT ON betatek.SINTOMA TO '" + Me.NOMBREUSUARIO + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT SELECT ON betatek.PATOLOGIA TO '" + Me.NOMBREUSUARIO + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT SELECT ON betatek.PATOLOGIA_SINTOMAS TO '" + Me.NOMBREUSUARIO + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = " GRANT INSERT ON betatek.TIENE TO '" + Me.NOMBREUSUARIO + "'@'localhost';"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "INSERT INTO PERSONA VALUES('" + Me.NOMBREUSUARIO + "','" + Me.NOMBRE + "','" + Me.APELLIDO + "','" + Me.EDAD + "','" + Me.MAIL + "',DEFAULT);"
            Comando.ExecuteNonQuery()

            Comando.CommandText = "COMMIT;"
            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Comando.CommandText = "ROLLBACK;"
            Comando.ExecuteNonQuery()

        End Try
    End Sub

    Public Function AutenticarPaciente()

        Comando.CommandText = "SELECT COUNT(CI) FROM PERSONA
                               WHERE CI='" + Me.DbUser + "'
                               AND ACTIVO=1;"


        Return Comando.ExecuteScalar().ToString()
    End Function


    Public Sub DesactivarPaciente()
        Comando.CommandText = "update PERSONA set ACTIVO=0 where CI='" + Me.NOMBREUSUARIO + "'"

        Comando.ExecuteNonQuery()
    End Sub

    Public Sub DesactivarMedico()
        Comando.CommandText = "update MEDICO set ACTIVO=0 where NOMBREUSUARIO='" + Me.NOMBREUSUARIO + "'"

        Comando.ExecuteNonQuery()

    End Sub

    Public Sub DesactivarGestor()
        Comando.CommandText = "update ADMINISTRATIVO set ACTIVO=0 where NOMBREUSUARIO='" + Me.NOMBREUSUARIO + "'"

        Comando.ExecuteNonQuery()
    End Sub



    Public Function VerificarCedulaMedico()
        Comando.CommandText = "SELECT COUNT(CEDULA) FROM MEDICO
                               WHERE CEDULA='" + Me.CEDULA + "';"
        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function VerificarCedulaGestor()
        Comando.CommandText = "SELECT COUNT(CEDULA) FROM ADMINISTRATIVO
                               WHERE CEDULA='" + Me.CEDULA + "';"
        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function VerificarMailPaciente()
        Comando.CommandText = "SELECT COUNT(MAIL) FROM PERSONA
                               WHERE MAIL='" + Me.MAIL + "';"
        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function VerificarUsuarioMySQL()
        Comando.CommandText = "SELECT COUNT(USER) FROM mysql.user
                               WHERE USER='" + Me.NOMBREUSUARIO + "';"

        Return Comando.ExecuteScalar().ToString()
    End Function


    Public Function ObtenerNombrePaciente()
        Comando.CommandText = "SELECT NOMBRE
                               FROM PERSONA 
                               WHERE CI='" + Me.NOMBREUSUARIO + "';"
        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function ObtenerApellidoPaciente()
        Comando.CommandText = "SELECT APELLIDO
                               FROM PERSONA 
                               WHERE CI='" + Me.NOMBREUSUARIO + "';"

        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function ObtenerEdadPaciente()
        Comando.CommandText = "SELECT EDAD
                               FROM PERSONA 
                               WHERE CI='" + Me.NOMBREUSUARIO + "';"

        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function ObtenerMailPaciente()
        Comando.CommandText = "SELECT MAIL 
                               FROM PERSONA 
                               WHERE CI='" + Me.NOMBREUSUARIO + "';"

        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function ObtenerNombreMedico()
        Comando.CommandText = "SELECT NOMBRE
                               FROM MEDICO
                               WHERE NOMBREUSUARIO='" + Me.NOMBREUSUARIO + "';"

        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function ObtenerApellidoMedico()
        Comando.CommandText = "SELECT APELLIDO
                               FROM MEDICO
                               WHERE NOMBREUSUARIO='" + Me.NOMBREUSUARIO + "';"

        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function ObtenerCedulaMedico()
        Comando.CommandText = "SELECT CEDULA
                               FROM MEDICO
                               WHERE NOMBREUSUARIO='" + Me.NOMBREUSUARIO + "';"

        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function ObtenerNombreGestor()
        Comando.CommandText = "SELECT NOMBRE
                               FROM ADMINISTRATIVO
                               WHERE NOMBREUSUARIO='" + Me.NOMBREUSUARIO + "';"

        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function ObtenerApellidoGestor()
        Comando.CommandText = "SELECT APELLIDO
                               FROM ADMINISTRATIVO
                               WHERE NOMBREUSUARIO='" + Me.NOMBREUSUARIO + "';"

        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function ObtenerCedulaGestor()
        Comando.CommandText = "SELECT CEDULA
                               FROM ADMINISTRATIVO
                               WHERE NOMBREUSUARIO='" + Me.NOMBREUSUARIO + "';"

        Return Comando.ExecuteScalar().ToString()
    End Function


    Public Sub ModificarPaciente()
        Comando.CommandText = "Update PERSONA set NOMBRE='" + Me.NOMBRE + "',APELLIDO='" + Me.APELLIDO + "',EDAD='" + Me.EDAD + "',MAIL='" + Me.MAIL + "' where CI='" + Me.CEDULA + "'"
        Comando.ExecuteNonQuery()
    End Sub

    Public Sub ModificarMedico()
        Comando.CommandText = "Update MEDICO set NOMBRE='" + Me.NOMBRE + "',APELLIDO='" + Me.APELLIDO + "',CEDULA='" + Me.CEDULA + "' where NOMBREUSUARIO='" + Me.NOMBREUSUARIO + "'"
        Comando.ExecuteNonQuery()
    End Sub

    Public Sub ModificarGestor()
        Comando.CommandText = "Update ADMINISTRATIVO set NOMBRE='" + Me.NOMBRE + "',APELLIDO='" + Me.APELLIDO + "',CEDULA='" + Me.CEDULA + "' where NOMBREUSUARIO='" + Me.NOMBREUSUARIO + "'"
        Comando.ExecuteNonQuery()
    End Sub

    Public Function ListarPacientes()
        Comando.CommandText = "SELECT CI,NOMBRE,APELLIDO,EDAD,MAIL FROM PERSONA where ACTIVO=1"

        Me.Reader = Comando.ExecuteReader()
        Return Me.Reader
    End Function

    Public Function ListarMedicos()
        Comando.CommandText = "SELECT NOMBREUSUARIO as USUARIO,NOMBRE,APELLIDO,CEDULA FROM MEDICO where ACTIVO=1"

        Me.Reader = Comando.ExecuteReader()
        Return Me.Reader
    End Function

    Public Function ListarGestores()
        Comando.CommandText = "SELECT NOMBREUSUARIO as USUARIO,NOMBRE,APELLIDO,CEDULA FROM ADMINISTRATIVO where ACTIVO=1"

        Me.Reader = Comando.ExecuteReader()
        Return Me.Reader
    End Function

    Public Function EstadoDePaciente()
        Try
            Comando.CommandText = "Select ACTIVO from PERSONA where CI='" + Me.NOMBREUSUARIO + "'"
            Return Comando.ExecuteScalar().ToString()
        Catch ex As Exception
            Return "1"
        End Try

    End Function

    Public Function EstadoDeMedico()
        Try
            Comando.CommandText = "Select ACTIVO from MEDICO where NOMBREUSUARIO='" + Me.NOMBREUSUARIO + "'"
            Return Comando.ExecuteScalar().ToString()
        Catch ex As Exception
            Return "1"
        End Try

    End Function

    Public Function EstadoDeGestor()
        Try
            Comando.CommandText = "Select ACTIVO from ADMINISTRATIVO where NOMBREUSUARIO='" + Me.NOMBREUSUARIO + "'"
            Return Comando.ExecuteScalar().ToString()
        Catch ex As Exception
            Return "1"
        End Try

    End Function


    Public Sub ActivarPaciente()
        Comando.CommandText = "update PERSONA set ACTIVO=1 where CI='" + Me.NOMBREUSUARIO + "'"

        Comando.ExecuteNonQuery()
    End Sub

    Public Sub ActivarMedico()
        Comando.CommandText = "update MEDICO set ACTIVO=1 where NOMBREUSUARIO='" + Me.NOMBREUSUARIO + "'"

        Comando.ExecuteNonQuery()
    End Sub

    Public Sub ActivarGestor()
        Comando.CommandText = "update ADMINISTRATIVO set ACTIVO=1 where NOMBREUSUARIO='" + Me.NOMBREUSUARIO + "'"

        Comando.ExecuteNonQuery()
    End Sub
End Class


