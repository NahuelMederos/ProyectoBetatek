Imports Capa_Logica
Public Class VentanaPacientes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ControladorUsuarios.CrearPaciente(txtCedula.Text, txtContraseña.Text, txtNombre.Text, txtApellido.Text, txtEdad.Text, txtMail.Text)
        MsgBox("Creado")
        Me.Close()
    End Sub
End Class