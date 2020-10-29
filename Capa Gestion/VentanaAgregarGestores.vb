Imports Capa_Logica

Public Class VentanaAgregarGestores

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If String.IsNullOrEmpty(txtNombreUsuario.Text) Or String.IsNullOrEmpty(txtContraseña.Text) Or String.IsNullOrEmpty(txtNombre.Text) Or String.IsNullOrEmpty(txtApellido.Text) Or String.IsNullOrEmpty(txtCedula.Text) Then
            MsgBox("Todos los campos son obligatorios")
        Else

            If (ControladorUsuarios.VerificarExistenciaClaveUnica(txtCedula.Text, 1) = "1") Then
                MsgBox("Esta cedula ya existe")
            ElseIf (ControladorUsuarios.VerificarUsuarioMySQL(txtNombreUsuario.Text) = "1") Then

                If ControladorUsuarios.VerificarEstadoUsuario(txtNombreUsuario.Text, 3) = "1" Then
                    MsgBox("Este usuario ya existe")
                Else
                    Dim ActivarUsuario As DialogResult
                    ActivarUsuario = MessageBox.Show("Este usuario se encuentra desabilitado" + Environment.NewLine + " ¿Desea reactivarlo?", "Activar usuario", MessageBoxButtons.YesNo)
                    If ActivarUsuario = DialogResult.Yes Then
                        ControladorUsuarios.ActivarUsuario(txtNombreUsuario.Text, 3)
                        MsgBox("Usuario activado." + Environment.NewLine + "Ahora puede modificarle los datos si lo desea")
                        VentanaGestionGestores.btnListarGestores_Click(sender, e)
                        Me.Dispose()
                    End If
                End If
            Else
                ControladorUsuarios.CrearGestor(txtNombreUsuario.Text, txtContraseña.Text, txtNombre.Text, txtApellido.Text, txtCedula.Text)
                MsgBox("Usuario creado")
                VentanaGestionGestores.btnListarGestores_Click(sender, e)
                Me.Dispose()
            End If

        End If
    End Sub



End Class