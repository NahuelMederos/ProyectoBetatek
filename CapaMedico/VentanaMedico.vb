﻿Imports Capa_Logica


Public Class VentanaMedico

    Private Sub VentanaMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaDeDiagnosticos.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        TablaDeDiagnosticos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        TablaDeDiagnosticos.AutoResizeColumns()
        TablaDeDiagnosticos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Timer1.Start()
        btnVerSolicitudes_Click(sender, e)

    End Sub


    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        ControladorDiagnostico.ModificarNombreRecibe(txtIdDiagnostico.Text)
        ChatMedico.IdDiagnostico = txtIdDiagnostico.Text
        ChatMedico.Ci = txtCiPersona.Text
        ChatMedico.ShowDialog()

    End Sub

    Private Sub TablaDeDiagnosticos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaDeDiagnosticos.CellClick
        Dim Indice As New Integer
        Indice = e.RowIndex

        Dim DSeleccionado As DataGridViewRow
        DSeleccionado = TablaDeDiagnosticos.Rows(Indice)
        txtIdDiagnostico.Text = DSeleccionado.Cells(1).Value.ToString()
        txtCiPersona.Text = DSeleccionado.Cells(4).Value.ToString()


    End Sub

    Public Sub btnVerSolicitudes_Click(sender As Object, e As EventArgs) Handles btnVerSolicitudes.Click
        Dim TablaDiagnosticos As New DataTable
        TablaDiagnosticos.Load(ControladorDiagnostico.ListarDiagnosticos())
        TablaDeDiagnosticos.DataSource = TablaDiagnosticos
        txtContar.Text = ControladorDiagnostico.BuscarUltimoDiagnosticoEnRecibe()
        MensajesNuevos.Visible = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtContar2.Text = ControladorDiagnostico.BuscarUltimoDiagnosticoEnRecibe()
        If txtContar2.Text > txtContar.Text Then
            MensajesNuevos.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VentanaHistorialDeDiagnosticosMedico.ShowDialog()
    End Sub
End Class