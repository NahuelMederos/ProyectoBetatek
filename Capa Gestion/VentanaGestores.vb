Imports Capa_Logica

Public Class VentanaGestores

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ControladorUsuarios.CrearGestor(txtNombreUsuario.Text, txtContraseña.Text, txtNombre.Text, txtApellido.Text, txtCedula.Text)
        MsgBox("Creado")
        Me.Close()
    End Sub


End Class