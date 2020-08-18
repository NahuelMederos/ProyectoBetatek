Imports Capa_Logica


Public Class IngresoPersona
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            ControladorPersona.DarAlta(txtCi.Text, txtNombre.Text, txtApellido.Text, txtCalle.Text, txtEsquina.Text, txtNumero.Text, txtEdad.Text, txtMail.Text)
            SeleccionSintoma.Visible = True
            Me.Hide()
            Sesion.CiPersona = txtCi.Text

        Catch ex As Exception
            MsgBox("Hubo un error")
        End Try

    End Sub
End Class