Imports Capa_Logica

Public Class VentanaGestores

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (ControladorUsuarios.VerificarUsuarioMySQL(txtNombreUsuario.Text) = "1") Then
            MsgBox("Este usuario ya existe")
        ElseIf (ControladorUsuarios.VerificarExistenciaClaveUnica(txtCedula.Text, 1) = "1") Then
            MsgBox("Esta cedula ya existe")
        Else
            ControladorUsuarios.CrearGestor(txtNombreUsuario.Text, txtContraseña.Text, txtNombre.Text, txtApellido.Text, txtCedula.Text)
            MsgBox("Creado")
            Me.Close()
        End If

    End Sub


End Class