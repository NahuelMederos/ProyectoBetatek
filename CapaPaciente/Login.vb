Imports Capa_Logica

Public Class Login

    Private Function AutenticarUsuario(usuario, password)
        Return ControladorUsuarios.AutenticarPaciente(usuario, password)
    End Function

    Private Sub setearSesion(usuario, password)
        Sesion.CI = usuario
        Sesion.Password = password
    End Sub


    Private Sub btnIngresar_Click_1(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If (AutenticarUsuario(txtUsuario.Text, txtPassword.Text) = "1") Then
                setearSesion(txtUsuario.Text, txtPassword.Text)
                ControladorUsuarios.setearSesion(txtUsuario.Text, txtPassword.Text)
                SeleccionSintoma.Show()
                Me.Close()
            Else
                MsgBox("Este usuario no es el de un paciente")

            End If

        Catch ex As Exception
            MsgBox("Nombre de usuario o contraseña incorrecta")
        End Try
    End Sub
End Class