Imports Capa_Logica

Public Class VentanaGestores

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If String.IsNullOrEmpty(txtNombreUsuario.Text) Or String.IsNullOrEmpty(txtContraseña.Text) Or String.IsNullOrEmpty(txtNombre.Text) Or String.IsNullOrEmpty(txtApellido.Text) Or String.IsNullOrEmpty(txtCedula.Text) Then
            MsgBox("Todos los campos son obligatorios")
        Else

            If (ControladorUsuarios.VerificarUsuarioMySQL(txtNombreUsuario.Text) = "1") Then
                MsgBox("Este usuario ya existe")
            ElseIf (ControladorUsuarios.VerificarExistenciaClaveUnica(txtCedula.Text, 1) = "1") Then
                MsgBox("Esta cedula ya existe")
            Else
                ControladorUsuarios.CrearGestor(txtNombreUsuario.Text, txtContraseña.Text, txtNombre.Text, txtApellido.Text, txtCedula.Text)
                MsgBox("Creado")
                Me.Close()
            End If

        End If
    End Sub



End Class