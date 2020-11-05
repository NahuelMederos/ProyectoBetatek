Imports Capa_Logica

Public Class LoginMedico

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
                VentanaPrincipalMedico.Show()
                Me.Close()

            Else
                MsgBox("Este usuario no es medico")
            End If

        Catch ex As Exception
            MsgBox("Nombre de usuario o contraseña invalido")
        End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        txtPassword.PasswordChar = ""
        PictureBox2.Enabled = False
        PictureBox2.Visible = False
        PictureBox3.Enabled = True
        PictureBox3.Visible = True
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        txtPassword.PasswordChar = "*"
        PictureBox3.Enabled = False
        PictureBox3.Visible = False
        PictureBox2.Enabled = True
        PictureBox2.Visible = True
    End Sub


End Class