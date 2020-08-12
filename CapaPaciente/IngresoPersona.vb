Imports Capa_Logica


Public Class IngresoPersona
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ControladorPersona.DarAlta(txtCi.Text, TxtNombre.Text, txtApellido.Text, txtCalle.Text, txtEsquina.Text, txtNumero.Text, txtEdad.Text, txtMail.Text)
            MsgBox("Persona creada")
        Catch ex As Exception
            MsgBox("Hubo un error")
        End Try
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim s = New SeleccionSintoma
        s.Show()
    End Sub

    Private Sub IngresoPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub
End Class