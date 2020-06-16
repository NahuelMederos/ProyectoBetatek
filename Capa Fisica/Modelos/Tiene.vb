Public Class Tiene
    Inherits ModeloConexion

    Public CiPersona As String
    Public IdSintoma As String




    Public Sub GuardarSintomasDePersona()
        Comando.CommandText = "INSERT INTO TIENE VALUES(" + Me.CiPersona + ",'" + Me.IdSintoma + "')"

        Comando.ExecuteNonQuery()
    End Sub

End Class
