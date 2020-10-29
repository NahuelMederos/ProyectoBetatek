Public Class VentanaPrincipal
    Private Sub btnSintomas_Click(sender As Object, e As EventArgs) Handles btnSintomas.Click
        VentanaSintomas.ShowDialog()

    End Sub

    Private Sub btnPatologias_Click(sender As Object, e As EventArgs) Handles btnPatologias.Click
        VentanaPatologia.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAsociar.Click
        VentanaAsociar.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        VentanaDatos.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGestionPaciente.Click
        VentanaGestionPacientes.ShowDialog()
    End Sub

    Private Sub btnGestionMedicos_Click(sender As Object, e As EventArgs) Handles btnGestionMedicos.Click
        VentanaGestionMedicos.ShowDialog()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        VentanaGestionGestores.ShowDialog()
    End Sub
End Class