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

End Class
