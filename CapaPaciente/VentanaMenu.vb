﻿Public Class VentanaMenu
    Private Sub btnSeleccionarSintomas_Click(sender As Object, e As EventArgs) Handles btnSeleccionarSintomas.Click
        VentanaSeleccionSintoma.ShowDialog()

    End Sub

    Private Sub btnHistorialChats_Click(sender As Object, e As EventArgs) Handles btnHistorialChats.Click
        VentanaListaChatsPaciente.ShowDialog()
    End Sub

    Private Sub btnModificarDatos_Click(sender As Object, e As EventArgs) Handles btnModificarDatos.Click
        VentanaModificarDatos.ShowDialog()
    End Sub
End Class