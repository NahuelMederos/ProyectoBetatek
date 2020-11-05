Imports Capa_Logica
Public Class VentanaHistorialDeDiagnosticosMedico
    Private Sub VentanaHistorialDeChatsMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaDeChats.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        TablaDeChats.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        TablaDeChats.AutoResizeColumns()
        TablaDeChats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Dim TablaDiagnosticos As New DataTable
        TablaDiagnosticos.Load(ControladorDiagnostico.ObtenerDiagnosticosAntiguos(2))

        TablaDeChats.DataSource = TablaDiagnosticos
    End Sub


    Private Sub TablaDeDiagnosticos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaDeChats.CellClick
        Dim Indice As New Integer
        Indice = e.RowIndex

        Dim SesionSeleccionada As DataGridViewRow
        SesionSeleccionada = TablaDeChats.Rows(Indice)
        txtSesion.Text = SesionSeleccionada.Cells(0).Value.ToString()
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Try

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
                VentanaHistorialChatCompleto.StrChatCompleto = textoWB2
                VentanaHistorialChatCompleto.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


End Class