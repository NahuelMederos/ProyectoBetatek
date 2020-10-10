Imports Capa_Logica

Public Class VentanaPatologia
    Private Sub btnAgregarPatologia_Click(sender As Object, e As EventArgs) Handles btnAgregarPatologia.Click
        Try
            ControladorPatologia.CrearPatologia(txtNombrePatologia.Text, cmbPatologia.SelectedItem)
            MsgBox("Patologia creada")
            ListarPat_Click(sender, e)
        Catch
            MsgBox("Error")
        End Try
    End Sub

    Private Sub btnModificarPatologia_Click(sender As Object, e As EventArgs) Handles btnModificarPatologia.Click
        Try
            ControladorPatologia.ModificarPatologia(txtIdPatologia.Text, txtNombrePatologia.Text, cmbPatologia.SelectedItem)
            MsgBox("Patologia modificada")
            ListarPat_Click(sender, e)
        Catch
            MsgBox("Error")
        End Try
    End Sub

    Private Sub VentanaPatologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarPat_Click(sender, e)
    End Sub

    Private Sub ListarPat_Click(sender As Object, e As EventArgs) Handles ListarPat.Click
        Dim TablaPatologias As New DataTable
        TablaPatologias.Load(ControladorPatologia.ListarPatologias())

        TablaDePatologias.DataSource = TablaPatologias
    End Sub

    Private Sub BtnBorrarPat_Click(sender As Object, e As EventArgs) Handles BtnBorrarPat.Click
        Try
            ControladorPatologia.BorrarPatologia(txtIdPatologia.Text)
            ListarPat_Click(sender, e)
            MsgBox("Patologia borrada")
        Catch
            MsgBox("Primero debe borrar las asociaciones de esta patologia")
        End Try
    End Sub


    Private Sub TablaDePatologias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaDePatologias.CellClick
        Dim Indice As New Integer
        Indice = e.RowIndex

        Dim PSeleccionada As DataGridViewRow
        PSeleccionada = TablaDePatologias.Rows(Indice)
        txtIdPatologia.Text = PSeleccionada.Cells(0).Value.ToString()
        txtNombrePatologia.Text = PSeleccionada.Cells(1).Value.ToString()
        cmbPatologia.Text = PSeleccionada.Cells(2).Value.ToString()

    End Sub


End Class