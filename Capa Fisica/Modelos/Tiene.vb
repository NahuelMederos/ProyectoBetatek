Public Class Tiene
    Inherits ModeloConexion

    Public CiPersona As String
    Public IdSintoma As String




    Public Sub GuardarSintomasDePersona()
        Try
            Comando.CommandText = "INSERT INTO TIENE VALUES(" + Me.CiPersona + ",'" + Me.IdSintoma + "')"

            Comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error")

        End Try

    End Sub

    Public Function ListarPosiblesPatologias()
        'La idea es listar la patologia con su nombre.
        'Si corresponde con lo que el usuario selecciono, que todo lo que el usuario paciente selecciona se guarde en la Tabla TIENE.
        'Basicamente lo unico que hace es comparar primero todos los Sintomas de "TIENE" con sintomas de patologia, y luego solo muestra los que correspondan con la CI del usuario
        Comando.CommandText = "SELECT Patologia.Nombre, Patologia.Prioridad FROM Patologia JOIN Patologia_Sintoma ON Patologia_Sintoma = Tiene.Sintoma WHERE" + Me.CiPersona + "= Tiene.Ci_Persona"
        Comando.ExecuteReader()

        Return Reader

    End Function

    Public Function ListarPorqueConsulta()
        'Para mostrarle al Medico ademas de las posibles patologias y
        'el Diagnostico primario(Que logicamente no es exacto, sirve como gía al medico para saber donde ver y nada mas)
        'los sintomas que el paciente selecciono y el si, dar con un diagnostico final o mejor.
        Comando.CommandText = "SELECT * FROM TIENE WHERE CI=" + Me.CiPersona
        Comando.ExecuteReader()
        Return Reader

    End Function

End Class
