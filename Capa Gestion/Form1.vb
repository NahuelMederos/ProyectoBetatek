Imports Capa_Logica
Imports System.Data.Odbc
Public Class FormLogin

    Dim pass As String
    Dim user As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            pass = txtPassword.Text
            user = txtUsuario.Text
            Dim conexion As New OdbcConnection("DRIVER=MySQL ODBC 8.0 UNICODE Driver;UID=" + user + ";PWD=" + pass + ";PORT=3306;DATABASE=betatek;SERVER=localhost")
            conexion.Open()
            MsgBox("Se logro la conexion")
            VentanaGestion.Visible = True
            Me.Hide()
        Catch
            MsgBox("Contraseña incorrecta")
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
