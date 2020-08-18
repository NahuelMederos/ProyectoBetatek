Imports Capa_Logica

Public Class Inicio
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        ControladorUsuarios.setearSesion("root", "servidorbetatek2020")
        IngresoPersona.Visible = True
        Me.Hide()
    End Sub

End Class