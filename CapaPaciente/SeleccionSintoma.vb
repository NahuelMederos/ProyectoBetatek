﻿Imports Capa_Logica

Public Class SeleccionSintoma



    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnListarSintomas.Click
        Dim tabla As New DataTable
        tabla.Load(ControladorSintoma.ListarSintomas)
        GrillaSintomas.DataSource = tabla
    End Sub



    Private Sub btnSeleccionarSintoma_Click_1(sender As Object, e As EventArgs) Handles btnSeleccionarSintoma.Click
        Dim i As Integer
        i = GrillaSintomas.CurrentRow.Index

        Dim idSintoma As String
        Dim ciPersona As String = txtPideCI.Text



        idSintoma = GrillaSintomas.Item(0, i).Value()
        'nombre = (Convert.ToString(GrillaSintomas.Item(1, i).Value()))

        MsgBox(idSintoma)

        GuardarSintomasPersona(ciPersona, idSintoma)


    End Sub

    Private Sub SeleccionSintoma_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnObtenerDiagnosctico_Click(sender As Object, e As EventArgs) Handles btnObtenerDiagnosctico.Click

    End Sub
End Class
