Imports Capa_Logica

Public Class VentanaSintomas
    Private Sub btnAgregarSintoma_Click(sender As Object, e As EventArgs) Handles btnAgregarSintoma.Click
        Try
            ControladorSintoma.CrearSintoma(txtIdSintoma.Text, txtNombreSintoma.Text, cmbSintoma.SelectedItem)
            MsgBox("Sintoma Creado")
            Listar_Click(sender, e)
        Catch
            MsgBox("Error")
        End Try
    End Sub

    Private Sub btnModificarSintoma_Click(sender As Object, e As EventArgs) Handles btnModificarSintoma.Click
        Try
            ControladorSintoma.ModificarSintoma(txtIdSintoma.Text, txtNombreSintoma.Text, cmbSintoma.SelectedItem)
            MsgBox("Sintoma Modificado")
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
End Class