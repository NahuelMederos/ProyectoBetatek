Imports Capa_Logica

Public Class Login
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs)
        ControladorUsuarios.setearSesion("Paciente", "123")
        SeleccionSintoma.Visible = True
        Me.Close()
    End Sub

End Class