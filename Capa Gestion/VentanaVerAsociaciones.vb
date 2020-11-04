Imports Capa_Logica

Public Class VentanaVerAsociaciones
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Try
            Dim TablaA As New DataTable
            TablaA.Load(ControladorAsociar.ListarAsociaciones())

            TablaAsociaciones.DataSource = TablaA
        Catch ex As Exception
            MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub TablaAsociaciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaAsociaciones.CellClick
        Dim Indice As New Integer
        Indice = e.RowIndex
        Dim ASeleccionada As DataGridViewRow
        ASeleccionada = TablaAsociaciones.Rows(Indice)
        txtIdA.Text = ASeleccionada.Cells(0).Value.ToString()
        txtPatA.Text = ASeleccionada.Cells(1).Value.ToString()
        txtSintA.Text = ASeleccionada.Cells(2).Value.ToString()

    End Sub

    Private Sub btnBorrarAsociacion_Click(sender As Object, e As EventArgs) Handles btnBorrarAsociacion.Click
        Try
            ControladorAsociar.BorrarAsociacion(txtIdA.Text, txtSintA.Text)
            MsgBox("Asociacion eliminada")
            btnListar_Click(sender, e)
        Catch
            MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub VentanaVerAsociaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnListar_Click(sender, e)
    End Sub


End Class