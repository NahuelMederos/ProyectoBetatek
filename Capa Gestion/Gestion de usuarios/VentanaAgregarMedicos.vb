Imports Capa_Logica
Public Class VentanaAgregarMedicos

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(txtNombreUsuario.Text) Or String.IsNullOrEmpty(txtContraseña.Text) Or String.IsNullOrEmpty(txtNombre.Text) Or String.IsNullOrEmpty(txtApellido.Text) Or String.IsNullOrEmpty(txtCedula.Text) Then
            MsgBox("Todos los campos son obligatorios")
        Else


            If (ControladorUsuarios.VerificarExistenciaClaveUnica(txtCedula.Text, 2) = "1") Then
                MsgBox("Esta cedula ya existe")
            ElseIf (ControladorUsuarios.VerificarUsuarioMySQL(txtNombreUsuario.Text) = "1") Or txtNombreUsuario.Text = "Medico" Then

                If ControladorUsuarios.VerificarEstadoUsuario(txtNombreUsuario.Text, 2) = "1" Or txtNombreUsuario.Text = "Medico" Then
                    MsgBox("Este usuario ya existe")
                Else
                    Dim ActivarUsuario As DialogResult
                    ActivarUsuario = MessageBox.Show("Este usuario se encuentra desabilitado" + Environment.NewLine + " ¿Desea reactivarlo?", "Activar usuario", MessageBoxButtons.YesNo)
                    If ActivarUsuario = DialogResult.Yes Then
                        Try
                            ControladorUsuarios.ActivarUsuario(txtNombreUsuario.Text, 2)
                            MsgBox("Usuario activado." + Environment.NewLine + "Ahora puede modificarle los datos si lo desea")
                            VentanaGestionMedicos.btnListarMedicos_Click(sender, e)
                            Me.Dispose()
                        Catch ex As Exception
                            MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
                        End Try

                    End If
                End If
            Else
                Try
                    ControladorUsuarios.CrearMedico(txtNombreUsuario.Text, txtContraseña.Text, txtNombre.Text, txtApellido.Text, txtCedula.Text)
                    MsgBox("Usuario creado")
                    VentanaGestionMedicos.btnListarMedicos_Click(sender, e)
                    Me.Dispose()
                Catch ex As Exception
                    MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
                End Try
            End If
        End If
    End Sub


End Class