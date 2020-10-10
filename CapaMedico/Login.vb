Imports Capa_Logica

Public Class Login

    Private Function AutenticarUsuario(usuario, password)
        Return ControladorUsuarios.AutenticarMedico(usuario, password)
    End Function

    Private Sub setearSesion(usuario, password)
        Sesion.Username = usuario
        Sesion.Password = password

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If (AutenticarUsuario(txtUsuario.Text, txtPassword.Text) = "1") Then
                setearSesion(txtUsuario.Text, txtPassword.Text)
                ControladorUsuarios.setearSesion(txtUsuario.Text, txtPassword.Text)
                ChatMedico.Show()
                Me.Close()

            Else
                MsgBox("Este usuario no es medico")
            End If

        Catch ex As Exception
            MsgBox("Nombre de usuario o contraseña invalido")
        End Try

    End Sub

End Class