Public Class DIAGNOSTICO
    Inherits ModeloConexion

    Public INFORMACION As String
    Public PRIORIDAD As String
    Public SOLICITACHAT As String
    Public IDDIAGNOSTICO As String
    Public CiPaciente As String
    Public NOMBREMEDICO As String
    Public IDSINTOMA As String
    Public IDPATOLOGIA As String
    Public Opcion As Integer

    Public Sub New(username As String, password As String)
        MyBase.New(username, password)

    End Sub

    Public Sub CrearDiagnostico()
        Comando.CommandText = "INSERT INTO DIAGNOSTICO VALUES(LAST_INSERT_ID(),'" + Me.PRIORIDAD + "','" + Me.INFORMACION + "'," + Me.SOLICITACHAT + ")"

        Comando.ExecuteNonQuery()

    End Sub

    Public Sub EnviarDiagnosticoAMedico()
        Comando.CommandText = "INSERT INTO RECIBE VALUES(" + Me.IDDIAGNOSTICO + ",'MEDICO',1)"

        Comando.ExecuteNonQuery()

    End Sub

    Public Function UltimoDiagnostico()
        Me.Comando.CommandText = "SELECT MAX(IDDIAGNOSTICO) FROM DIAGNOSTICO"

        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function UltimoDiagnosticoEnRecibe()
        Me.Comando.CommandText = "SELECT MAX(IDDIAGNOSTICO) FROM RECIBE"

        Return Comando.ExecuteScalar().ToString()
    End Function

    Public Function ObtenerDiagnosticos()

        Comando.CommandText = "Select DIAGNOSTICO.PRIORIDAD,RECIBE.IDDIAGNOSTICO As Id,INFORMACION,GENERA.FECHAHORA,CIPERSONA
                               From RECIBE,DIAGNOSTICO,GENERA
                               Where RECIBE.IDDIAGNOSTICO=DIAGNOSTICO.IDDIAGNOSTICO
                               And ESTADOSESION=1
                               And GENERA.IDDIAGNOSTICO=DIAGNOSTICO.IDDIAGNOSTICO
                               And (NOMBREMEDICO='" + Me.NOMBREMEDICO + "' Or NOMBREMEDICO='MEDICO')
                               Group by GENERA.IDDIAGNOSTICO
                               Order by
                                      Case
                                         when DIAGNOSTICO.PRIORIDAD= 'ALTA' Then 1 
                                         when DIAGNOSTICO.PRIORIDAD= 'MEDIA' Then 2
                                         when DIAGNOSTICO.PRIORIDAD= 'BAJA' Then 3
                                        END;"

        Reader = Comando.ExecuteReader()
        Return Reader

    End Function

    Public Sub PacienteTieneSintomas()
        Comando.CommandText = "INSERT INTO TIENE VALUES('" + Me.CiPaciente + "','" + Me.IDSINTOMA + "')"

        Comando.ExecuteNonQuery()
    End Sub

    Public Sub PacienteGeneraDiagnostico()
        Comando.CommandText = "INSERT INTO GENERA VALUES('" + Me.CiPaciente + "',LAST_INSERT_ID(),'" + Me.IDSINTOMA + "',now())"

        Comando.ExecuteNonQuery()
    End Sub

    Public Sub ModificarNombreEnRecibe()
        Comando.CommandText = "UPDATE RECIBE SET NOMBREMEDICO='" + Me.NOMBREMEDICO + "' WHERE IDDIAGNOSTICO=" + Me.IDDIAGNOSTICO + ""

        Comando.ExecuteNonQuery()
    End Sub

    Public Sub AgregarPatologiaADiagnostico()
        Comando.CommandText = "INSERT INTO PATOLOGIAS VALUES(" + Me.IDDIAGNOSTICO + "," + Me.IDPATOLOGIA + ")"

        Comando.ExecuteNonQuery()

    End Sub

    Public Function ListarDiagnosticos()
        Comando.CommandText = "select DIAGNOSTICO.IDDIAGNOSTICO as Id,INFORMACION,Date(FECHAHORA) as Fecha
                              from DIAGNOSTICO,GENERA 
                              group by Id 
                              order by Id Desc;"

        Reader = Comando.ExecuteReader()
        Return Reader
    End Function

    Public Function ObtenerDiagnosticosAntiguos()
        If Me.Opcion = 1 Then
            Comando.CommandText = "Select Fecha,CONCAT( NOMBRE, "" "", APELLIDO ) AS MEDICO ,INFORMACION,SESION
                                   From (select SESION,date(FECHAHORA) as Fecha,MEDICO.NOMBRE As NOMBRE,MEDICO.APELLIDO As APELLIDO
                                   from PERSONA,CHATEA,MEDICO
                                   where CI=DE 
                                   And CHATEA.PARA=MEDICO.NOMBREUSUARIO
                                   And DE='" + Me.CiPaciente + "' 
                                   and PARA!='MEDICO' 
                                   group by SESION) as A
                                   Join
                                   (Select * 
                                   From DIAGNOSTICO) as B
                                   On a.SESION=B.IDDIAGNOSTICO
                                   Order by Fecha Desc"

            Reader = Comando.ExecuteReader()
            Return Reader
        Else
            Comando.CommandText = "Select RECIBE.IDDIAGNOSTICO As SESION,DIAGNOSTICO.PRIORIDAD,Date(GENERA.FECHAHORA) as Fecha,INFORMACION
                                   From RECIBE,DIAGNOSTICO,GENERA
                                   Where RECIBE.IDDIAGNOSTICO=DIAGNOSTICO.IDDIAGNOSTICO
                                   And ESTADOSESION=0
                                   And GENERA.IDDIAGNOSTICO=DIAGNOSTICO.IDDIAGNOSTICO
                                   And NOMBREMEDICO='" + Me.NOMBREMEDICO + "'
                                   Group by GENERA.IDDIAGNOSTICO
                                   Order by Fecha;"

            Reader = Comando.ExecuteReader()
            Return Reader
        End If
    End Function

End Class
