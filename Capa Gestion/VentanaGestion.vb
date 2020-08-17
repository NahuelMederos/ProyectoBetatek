Public Class VentanaGestion
    Private Sub btnSintomas_Click(sender As Object, e As EventArgs) Handles btnSintomas.Click
        VentanaSintomas.Visible = True
        Me.Hide()
    End Sub

    Private Sub btnPatologias_Click(sender As Object, e As EventArgs) Handles btnPatologias.Click
        VentanaPatologia.Visible = True
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VentanaAsociar.Visible = True
        Me.Hide()
    End Sub

    Private Sub btnAgregarGestor_Click(sender As Object, e As EventArgs) Handles btnAgregarGestor.Click
        VentanaGestores.Visible = True
        Me.Hide()
    End Sub
End Class