Imports Capa_Logica
Public Class VentanaModificarDatos
    Private Sub VentanaModificarDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Datos As New List(Of String)
        Datos = ControladorUsuarios.ObtenerDatosPaciente(Sesion.CI, 5)
        txtNombre.Text = Datos(0)
        txtApellido.Text = Datos(1)
        txtEdad.Text = Datos(2)
        txtEmail.Text = Datos(3)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If String.Compare(txtEmail.Text, ControladorUsuarios.ObtenerDatosPaciente(Sesion.CI, 4)) = 0 Or ControladorUsuarios.VerificarExistenciaClaveUnica(txtEmail.Text, 3) = "0" Then
            Try
                ControladorUsuarios.ModificarPaciente(Sesion.CI, txtNombre.Text, txtApellido.Text, txtEdad.Text, txtEmail.Text)
                MsgBox("Datos modificados")
                Me.Dispose()
            Catch ex As Exception
                MsgBox("Hubo un error", MsgBoxStyle.Critical, "Error")
            End Try
        Else
            MsgBox("Ese mail ya existe")
        End If
    End Sub
End Class