Public Class ModeloChat

    Inherits ModeloConexion

    Public Sub New(username As String, password As String)
        MyBase.New(username, password)

    End Sub

    Public Id As String
    Public Sesion As String
    Public De As String
    Public Para As String
    Public Mensaje As String
    Public FechaHora As String
    Public Leido As Boolean
    Public IdDiagnostico As String

    Public Sub Guardar()
        Me.Comando.CommandText =
            "
            INSERT INTO CHATEA(Sesion,De,Para,Texto,FechaHora)
            VALUES(" + Me.Sesion + ",'" + Me.De + "','" + Me.Para + "','" + Me.Mensaje + "',now())
            "

        Me.Comando.ExecuteNonQuery()
        Me.Conexion.Close()
    End Sub

    Public Function LeerMensajesNoLeidosParaPaciente()
        Me.Comando.CommandText =
            "
            SELECT 
	           m.de, (m.fechahora) as fechahora, m.texto, m.idmensaje as id_mensaje, u.nombre as emisor, u.NombreUsuario, u.apellido
            FROM
	            Chatea m 
            JOIN
                Medico u 
                    ON m.de = u.NombreUsuario
            

            WHERE 
	            m.para = '" + Me.Para + "' AND
	            m.sesion = '" + Me.Sesion + "' AND 
	            m.leido = FALSE
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
	           m.de, Time(m.fechahora) as fechahora, m.texto, m.idmensaje as id_mensaje, u.nombre as emisor, u.apellido
            FROM
	            chatea m 
            JOIN
                Persona u 
                    ON m.de = u.Ci
            

            WHERE 
	            (m.para = '" + Me.Para + "' OR m.para ='Medico') AND
	            m.sesion = '" + Me.Sesion + "' AND 
	            m.leido = FALSE
            "
        Dim resultado As New DataTable
        resultado.Load(Me.Comando.ExecuteReader())

        Me.Conexion.Close()
        Return resultado

    End Function



    Public Sub MarcarLeido()
        Me.Comando.CommandText =
            "UPDATE Chatea SET Leido = true where IdMensaje = " + Me.Id + ";"
        Comando.ExecuteNonQuery()
        Me.Conexion.Close()

    End Sub

    Public Function ChatsNoRespondidos()
        Me.Comando.CommandText = "
            SELECT 
	           sesion,de As Cedula,Time(FechaHora) as FechaHora,Nombre
            FROM
	            chatea m 
            JOIN
                Persona u 
                    ON m.de = u.Ci
            

            WHERE 
                m.leido = FALSE AND
                m.para = 'Medico'     
            Group by Sesion
            "

        Reader = Comando.ExecuteReader()
        Return Reader

    End Function

    Public Function VerificarEstadoDelChat()

        Comando.CommandText = "Select ESTADOSESION from Recibe where IdDiagnostico=" + Me.IdDiagnostico

        Return Comando.ExecuteScalar().ToString()

    End Function

    Public Sub TerminarChat()
        Comando.CommandText = "Update RECIBE SET ESTADOSESION= 0 WHERE IDDIAGNOSTICO=" + Me.IdDiagnostico

        Comando.ExecuteNonQuery()
    End Sub


    Public Function VerChatCompleto()
        Comando.CommandText = "
        (SELECT 
	           m.de, TIME(m.fechahora) as fechahora, m.texto, m.idmensaje as id_mensaje, u.nombre as emisor, apellido
            FROM
	            chatea m 
            JOIN
                Medico u 
                    ON m.de = u.NombreUsuario
                    where m.sesion=" + Me.Sesion + ")
        UNION
        (SELECT 
	           m.de, TIME(m.fechahora) as fechahora, m.texto, m.idmensaje as id_mensaje, u.nombre as emisor, apellido
            FROM
	            chatea m 
            JOIN
                Persona u 
                    ON m.de = u.Ci
                    where m.sesion=" + Me.Sesion + ")
         ORDER BY id_mensaje Asc;
"

        Dim resultado As New DataTable
        resultado.Load(Me.Comando.ExecuteReader())

        Me.Conexion.Close()
        Return resultado

    End Function

    Public Function ObtenerFechaDelChat()

        Comando.CommandText = "SELECT DATE_FORMAT(FechaHora,'%d/%m/%Y')
                               FROM CHATEA 
                               WHERE SESION=" + Sesion + " 
                               LIMIT 1"

        Return Comando.ExecuteScalar().ToString()

    End Function

    Public Function ObtenerSesionesDeChat()
        Comando.CommandText = "Select Sesion,De,Para,Date(FechaHora) as Fecha 
                               From chatea 
                               Group by sesion"

        Reader = Comando.ExecuteReader
        Return Reader
    End Function
End Class
