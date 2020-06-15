Public Class FormGestion
    Private Sub btnSintomas_Click(sender As Object, e As EventArgs) Handles btnSintomas.Click
        VentanaSintomas.Visible = True
        Me.Hide()
    End Sub
End Class