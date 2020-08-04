Imports Capa_Logica
Imports System.Data.Odbc
Public Class FormLogin

    Dim pass As String
    Dim user As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            pass = txtPassword.Text
            user = txtUsuario.Text
            ControladorLogin.Autenticarse(user, pass)
            MsgBox("El usuario y la contraseña son correctos")
            VentanaGestion.Visible = True
            Me.Hide()
        Catch
            MsgBox("El usuario o la contraseña son incorrectos")
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
