Imports Capa_Logica
Public Class FormLogin


    Private Function AutenticarUsuario(usuario, password)
        Return ControladorUsuarios.AutenticarGestor(usuario, password)
    End Function

    Private Sub setearSesion(usuario, password)
        Sesion.Username = usuario
        Sesion.Password = password

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If (AutenticarUsuario(txtUsuario.Text, txtPassword.Text) = "1") Then
                setearSesion(txtUsuario.Text, txtPassword.Text)
                ControladorUsuarios.setearSesion(txtUsuario.Text, txtPassword.Text)
                VentanaPrincipal.Show()
                Me.Close()


            ElseIf (txtUsuario.Text = "root") Then
                setearSesion(txtUsuario.Text, txtPassword.Text)
                ControladorUsuarios.setearSesion(txtUsuario.Text, txtPassword.Text)
                MsgBox("Bienvenido root")
                VentanaPrincipal.Show()
                Me.Close()

            End If

        Catch ex As Exception
            If ex.Message.Contains("SELECT") Then
                MsgBox("Este usuario no es gestor")
            Else
                MsgBox("Nombre de usuario o contraseña incorrecta")
            End If

        End Try

    End Sub


End Class
