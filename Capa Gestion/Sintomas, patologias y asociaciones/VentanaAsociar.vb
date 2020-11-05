Imports Capa_Logica

Public Class VentanaAsociar
    Private Sub ListarTodo_Click(sender As Object, e As EventArgs) Handles ListarTodo.Click
        Try
            Dim TablaP As New DataTable
            TablaP.Load(ControladorAsociar.ListarNombresPatologias())

            TablaPat.DataSource = TablaP
            TablaPat.Columns(0).Width = 25
            TablaPat.Columns(1).Width = 100

            Dim TablaS As New DataTable
            TablaS.Load(ControladorSintoma.ListarSintomas())

            TablaSint.DataSource = TablaS
            TablaSint.Columns(0).Width = 25
            TablaSint.Columns(1).Width = 100
            TablaSint.Columns(1).HeaderText = "Sintoma"
        Catch ex As Exception
            MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub


    Private Sub TablaPat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaPat.CellClick

        Dim Indice As New Integer
        Indice = e.RowIndex
        Dim PatSeleccionada As DataGridViewRow
        PatSeleccionada = TablaPat.Rows(Indice)
        txtIdPatologia.Text = PatSeleccionada.Cells(0).Value.ToString()
        txtNombrePatologia.Text = PatSeleccionada.Cells(1).Value.ToString()
    End Sub

    Private Sub TablaSint_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaSint.CellClick

        Dim Indice2 As New Integer
        Indice2 = e.RowIndex
        Dim SintSeleccionada As DataGridViewRow
        SintSeleccionada = TablaSint.Rows(Indice2)
        txtIdSintoma.Text = SintSeleccionada.Cells(0).Value.ToString()
        txtNombreSintoma.Text = SintSeleccionada.Cells(1).Value.ToString()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAsociar.Click
        If String.IsNullOrEmpty(txtIdSintoma.Text) Or String.IsNullOrEmpty(txtIdPatologia.Text) Then
            MsgBox("Debe seleccionar un sintoma y una patologia")
        Else
            Try
                ControladorAsociar.CrearAsociacion(txtIdPatologia.Text, txtIdSintoma.Text)
                MsgBox("Asociacion creada")
                ListarTodo_Click(sender, e)
            Catch
                MsgBox("Esta asociacion ya existe")
            End Try
        End If
    End Sub

    Private Sub VentanaAsociar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarTodo_Click(sender, e)
    End Sub

    Private Sub btnVerAsociaciones_Click(sender As Object, e As EventArgs) Handles btnVerAsociaciones.Click
        VentanaVerAsociaciones.ShowDialog()
    End Sub


End Class