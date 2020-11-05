Imports Capa_Logica

Public Class LoginPaciente

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
                VentanaMenu.Show()
                Me.Close()
            Else
                MsgBox("Este usuario no es el de un paciente")

            End If

        Catch ex As Exception
            MsgBox("Nombre de usuario o contraseña incorrecta")
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