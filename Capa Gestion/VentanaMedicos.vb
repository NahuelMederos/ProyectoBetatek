Imports Capa_Logica
Public Class VentanaMedicos

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ControladorUsuarios.CrearMedico(txtNombreUsuario.Text, txtContraseña.Text, txtNombre.Text, txtApellido.Text, txtCedula.Text)
        MsgBox("Creado")

    End Sub
End Class