Imports Capa_Logica

Public Class VentanaSintomas
    Private Sub btnAgregarSintoma_Click(sender As Object, e As EventArgs) Handles btnAgregarSintoma.Click
        Try
            ControladorSintoma.CrearSintoma(txtNombreSintoma.Text, cmbSintoma.SelectedItem)
            MsgBox("Sintoma creado")
            Listar_Click(sender, e)
        Catch ex As Exception
            MsgBox("Error")
        End Try


    End Sub

    Private Sub btnModificarSintoma_Click(sender As Object, e As EventArgs) Handles btnModificarSintoma.Click
        Try
            ControladorSintoma.ModificarSintoma(txtIdSintoma.Text, txtNombreSintoma.Text, cmbSintoma.SelectedItem)
            MsgBox("Sintoma modificado")
            Listar_Click(sender, e)
        Catch
            MsgBox("Error")
        End Try
    End Sub


    Private Sub VentanaSintomas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_Click(sender, e)
    End Sub

    Private Sub Listar_Click(sender As Object, e As EventArgs) Handles Listar.Click
        Dim TablaSintomas As New DataTable
        TablaSintomas.Load(ControladorSintoma.ListarSintomas())

        TablaDeSintomas.DataSource = TablaSintomas
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Try
            ControladorSintoma.BorrarSintoma(txtIdSintoma.Text)
            MsgBox("Sintoma eliminado")
            Listar_Click(sender, e)
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub



    Private Sub TablaDeSintomas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaDeSintomas.CellClick
        Dim Indice As New Integer
        Indice = e.RowIndex
        Dim SSeleccionada As DataGridViewRow
        SSeleccionada = TablaDeSintomas.Rows(Indice)
        txtIdSintoma.Text = SSeleccionada.Cells(0).Value.ToString()
        txtNombreSintoma.Text = SSeleccionada.Cells(1).Value.ToString()
        cmbSintoma.Text = SSeleccionada.Cells(2).Value.ToString()
    End Sub



End Class