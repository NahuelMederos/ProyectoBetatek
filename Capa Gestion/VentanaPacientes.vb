Imports Capa_Logica
Public Class VentanaPacientes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If String.IsNullOrEmpty(txtCedula.Text) Or String.IsNullOrEmpty(txtContraseña.Text) Or String.IsNullOrEmpty(txtNombre.Text) Or String.IsNullOrEmpty(txtApellido.Text) Or String.IsNullOrEmpty(txtEdad.Text) Or String.IsNullOrEmpty(txtMail.Text) Then
            MsgBox("Todos los campos son obligatorios")
        Else

            If (ControladorUsuarios.VerificarUsuarioMySQL(txtCedula.Text) = "1") Then
                MsgBox("Este usuario ya existe")
            ElseIf (ControladorUsuarios.VerificarExistenciaClaveUnica(txtMail.Text, 3) = "1") Then
                MsgBox("Este mail ya existe")
            Else
                ControladorUsuarios.CrearPaciente(txtCedula.Text, txtContraseña.Text, txtNombre.Text, txtApellido.Text, txtEdad.Text, txtMail.Text)
                MsgBox("Creado")
                Me.Close()
            End If
        End If
    End Sub


    Private Sub txtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEdad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class