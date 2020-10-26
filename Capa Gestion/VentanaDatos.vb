Public Class VentanaDatos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VentanaHistorialDeChats.ShowDialog()
    End Sub

    Private Sub btnDiagnosticos_Click(sender As Object, e As EventArgs) Handles btnDiagnosticos.Click
        VentanaHistorialDiagnosticos.ShowDialog()
    End Sub
End Class