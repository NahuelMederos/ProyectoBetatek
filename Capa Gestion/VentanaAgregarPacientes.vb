Imports Capa_Logica
Public Class VentanaAgregarPacientes

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(txtCedula.Text) Or String.IsNullOrEmpty(txtContraseña.Text) Or String.IsNullOrEmpty(txtNombre.Text) Or String.IsNullOrEmpty(txtApellido.Text) Or String.IsNullOrEmpty(txtEdad.Text) Or String.IsNullOrEmpty(txtMail.Text) Then
            MsgBox("Todos los campos son obligatorios")
        Else

            If (ControladorUsuarios.VerificarExistenciaClaveUnica(txtMail.Text, 3) = "1") Then
                MsgBox("Este mail ya existe")
            ElseIf (ControladorUsuarios.VerificarUsuarioMySQL(txtCedula.Text) = "1") Then

                If ControladorUsuarios.VerificarEstadoUsuario(txtCedula.Text, 1) = "1" Then
                    MsgBox("Este usuario ya existe")
                Else

                    Dim ActivarUsuario As DialogResult
                    ActivarUsuario = MessageBox.Show("Este usuario se encuentra desabilitado" + Environment.NewLine + " ¿Desea reactivarlo?", "Activar usuario", MessageBoxButtons.YesNo)
                    If ActivarUsuario = DialogResult.Yes Then
                        Try
                            ControladorUsuarios.ActivarUsuario(txtCedula.Text, 1)
                            MsgBox("Usuario activado." + Environment.NewLine + "Ahora puede modificarle los datos si lo desea")
                            VentanaGestionPacientes.btnListarPacientes_Click(sender, e)
                            Me.Dispose()
                        Catch ex As Exception
                            MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
                        End Try
                    End If
                End If

            Else
                Try
                    ControladorUsuarios.CrearPaciente(txtCedula.Text, txtContraseña.Text, txtNombre.Text, txtApellido.Text, txtEdad.Text, txtMail.Text)
                    MsgBox("Usuario creado")
                    VentanaGestionPacientes.btnListarPacientes_Click(sender, e)
                    Me.Dispose()
                Catch ex As Exception
                    MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
                End Try

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