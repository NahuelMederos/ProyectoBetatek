Public Class VentanaGestion
    Private Sub btnSintomas_Click(sender As Object, e As EventArgs) Handles btnSintomas.Click
        VentanaSintomas.ShowDialog()

    End Sub

    Private Sub btnPatologias_Click(sender As Object, e As EventArgs) Handles btnPatologias.Click
        VentanaPatologia.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAsociar.Click
        VentanaAsociar.ShowDialog()

    End Sub

    Private Sub btnAgregarGestor_Click(sender As Object, e As EventArgs) Handles btnAgregarGestor.Click
        VentanaGestores.ShowDialog()

    End Sub

    Private Sub btnAgregarMedicos_Click(sender As Object, e As EventArgs) Handles btnAgregarMedicos.Click
        VentanaMedicos.ShowDialog()
    End Sub

    Private Sub btnAgregarPacientes_Click(sender As Object, e As EventArgs) Handles btnAgregarPacientes.Click
        VentanaPacientes.ShowDialog()
    End Sub
End Class