Public Class ModeloChat

    Inherits ModeloConexion

    Public Sub New(username As String, password As String)
        MyBase.New(username, password)

    End Sub

    Public Id As String
    Public SESION As String
    Public DE As String
    Public PARA As String
    Public Mensaje As String
    Public FECHAHORA As String
    Public LEIDO As Boolean
    Public IDDIAGNOSTICO As String

    Public Sub Guardar()
        Me.Comando.CommandText =
            "
            INSERT INTO CHATEA(SESION,DE,PARA,TEXTO,FECHAHORA)
            VALUES(" + Me.SESION + ",'" + Me.DE + "','" + Me.PARA + "','" + Me.Mensaje + "',now())
            "

        Me.Comando.ExecuteNonQuery()
        Me.Conexion.Close()
    End Sub

    Public Function LeerMensajesNoLeidosParaPaciente()
        Me.Comando.CommandText =
            "
            SELECT 
	           m.DE, Time_Format(m.FECHAHORA, ""%H:%i"") as FECHAHORA, m.TEXTO, m.IDMENSAJE as id_mensaje, u.NOMBRE as emisor, u.NOMBREUSUARIO, u.APELLIDO
            FROM
	            CHATEA m 
            JOIN
                MEDICO u 
                    ON m.DE = u.NOMBREUSUARIO
            

            WHERE 
	            m.PARA = '" + Me.PARA + "' AND
	            m.SESION = '" + Me.SESION + "' AND 
	            m.LEIDO = FALSE
            "
        Dim resultado As New DataTable
        resultado.Load(Me.Comando.ExecuteReader())

        Me.Conexion.Close()
        Return resultado

    End Function

    Public Function LeerMensajesNoLeidosParaMedico()
        Me.Comando.CommandText =
            "
            SELECT 
	           m.DE, Time_Format(m.FECHAHORA, ""%H:%i"") as FECHAHORA, m.TEXTO, m.IDMENSAJE as id_mensaje, u.NOMBRE as emisor, u.APELLIDO
            FROM
	            CHATEA m 
            JOIN
                PERSONA u 
                    ON m.DE = u.CI
            

            WHERE 
	            (m.PARA = '" + Me.PARA + "' OR m.PARA ='MEDICO') AND
	            m.SESION = '" + Me.SESION + "' AND 
	            m.LEIDO = FALSE
            "
        Dim resultado As New DataTable
        resultado.Load(Me.Comando.ExecuteReader())

        Me.Conexion.Close()
        Return resultado

    End Function



    Public Sub MarcarLeido()
        Me.Comando.CommandText =
            "UPDATE CHATEA SET LEIDO = true where IDMENSAJE = " + Me.Id + ";"
        Comando.ExecuteNonQuery()
        Me.Conexion.Close()

    End Sub

    Public Function ChatsNoRespondidos()
        Me.Comando.CommandText = "
            SELECT 
	           SESION,DE As CEDULA,Time_Format(FECHAHORA, ""%H:%i"") as FECHAHORA,NOMBRE
            FROM
	            CHATEA m 
            JOIN
                PERSONA u 
                    ON m.DE = u.CI
            

            WHERE 
                m.LEIDO = FALSE AND
                m.PARA = 'MEDICO'     
            Group by SESION
            "

        Reader = Comando.ExecuteReader()
        Return Reader

    End Function

    Public Function VerificarEstadoDelChat()

        Comando.CommandText = "Select ESTADOSESION from RECIBE where IDDIAGNOSTICO=" + Me.IDDIAGNOSTICO

        Return Comando.ExecuteScalar().ToString()

    End Function

    Public Sub TerminarChat()
        Comando.CommandText = "Update RECIBE SET ESTADOSESION= 0 WHERE IDDIAGNOSTICO=" + Me.IDDIAGNOSTICO

        Comando.ExecuteNonQuery()
    End Sub


    Public Function VerChatCompleto()
        Comando.CommandText = "
        (SELECT 
	           m.DE, Time_Format(m.FECHAHORA, ""%H:%i"") as FECHAHORA, m.TEXTO, m.IDMENSAJE as id_mensaje, u.NOMBRE as emisor, APELLIDO
            FROM
	            CHATEA m 
            JOIN
                MEDICO u 
                    ON m.DE = u.NOMBREUSUARIO
                    where m.SESION=" + Me.SESION + ")
        UNION
        (SELECT 
	           m.DE, Time_Format(m.FECHAHORA, ""%H:%i"") as FECHAHORA, m.TEXTO, m.IDMENSAJE as id_mensaje, u.NOMBRE as emisor, APELLIDO
            FROM
	            CHATEA m 
            JOIN
                PERSONA u 
                    ON m.DE = u.CI
                    where m.SESION=" + Me.SESION + ")
         ORDER BY id_mensaje Asc;
"

        Dim resultado As New DataTable
        resultado.Load(Me.Comando.ExecuteReader())

        Me.Conexion.Close()
        Return resultado

    End Function

    Public Function ObtenerFechaDelChat()

        Comando.CommandText = "SELECT DATE_FORMAT(FECHAHORA,'%d/%m/%Y')
                               FROM CHATEA 
                               WHERE SESION=" + SESION + " 
                               LIMIT 1"

        Return Comando.ExecuteScalar().ToString()

    End Function

    Public Function ObtenerSesionesDeChat()
        Comando.CommandText = "Select SESION,DE,PARA,Date(FECHAHORA) as Fecha 
                               From CHATEA 
                               Group by SESION"

        Reader = Comando.ExecuteReader
        Return Reader
    End Function



End Class
