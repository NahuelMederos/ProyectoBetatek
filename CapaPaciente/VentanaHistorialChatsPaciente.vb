﻿Imports Capa_Logica
Public Class VentanaHistorialChatsPaciente
    Private Sub VentanaHistorialChatsPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaDeDiagnosticos.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        TablaDeDiagnosticos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        TablaDeDiagnosticos.AutoResizeColumns()
        TablaDeDiagnosticos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


        Dim TablaDiagnosticos As New DataTable
        TablaDiagnosticos.Load(ControladorDiagnostico.ObtenerDiagnosticosAntiguos(1))

        TablaDeDiagnosticos.DataSource = TablaDiagnosticos
        TablaDeDiagnosticos.Columns("Sesion").Visible = False
    End Sub

    Private Sub TablaDeDiagnosticos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaDeDiagnosticos.CellClick
        Dim Indice As New Integer
        Indice = e.RowIndex

        Dim SesionSeleccionada As DataGridViewRow
        SesionSeleccionada = TablaDeDiagnosticos.Rows(Indice)
        txtSesion.Text = SesionSeleccionada.Cells(3).Value.ToString()
    End Sub

    Private Sub TablaDeDiagnosticos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaDeDiagnosticos.CellContentDoubleClick
        Dim tabla2 As New DataTable
        tabla2 = ControladorChat.VerChatCompleto(txtSesion.Text)

        If tabla2.Rows.Count > 0 Then
            Dim textoWB2 As String
            For Each fila As DataRow In tabla2.Rows
                textoWB2 +=
            "
                <br />
                <b>" + fila("emisor") + " " + fila("Apellido") + " a las " + fila("FechaHora").ToString + " escribio: </b>
                <br />
                " + fila("Texto") + "  
                <br />
                "
            Next
            VentanaHistorialChatPaciente.StrChatCompleto = textoWB2
            VentanaHistorialChatPaciente.ShowDialog()
        End If
    End Sub
End Class