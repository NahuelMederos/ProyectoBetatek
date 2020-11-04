Imports Capa_Logica

Public Class VentanaGestionGestores
    Public Sub btnListarGestores_Click(sender As Object, e As EventArgs) Handles btnListarGestores.Click
        Try
            Dim TablaGestores As New DataTable
            TablaGestores.Load(ControladorUsuarios.ListarUsuarios(3))

            TablaDeGestores.DataSource = TablaGestores
        Catch ex As Exception
            MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub VentanaGestionGestores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnListarGestores_Click(sender, e)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If String.IsNullOrEmpty(txtNombreUsuario.Text) Or String.IsNullOrEmpty(txtNombre.Text) Or String.IsNullOrEmpty(txtApellido.Text) Or String.IsNullOrEmpty(txtCedula.Text) Then
            MsgBox("Todos los campos son obligatorios")
        Else
            If String.Compare(txtCedula.Text, ControladorUsuarios.ObtenerDatosGestor(txtNombreUsuario.Text, 3)) = 0 Or ControladorUsuarios.VerificarExistenciaClaveUnica(txtCedula.Text, 3) = "0" Then
                Try
                    ControladorUsuarios.ModificarGestor(txtNombreUsuario.Text, txtNombre.Text, txtApellido.Text, txtCedula.Text)
                    MsgBox("Datos modificados")
                    btnListarGestores_Click(sender, e)
                Catch ex As Exception
                    MsgBox("Hubo un error", MsgBoxStyle.Critical, "Error")
                End Try
            Else
                MsgBox("Esta cedula ya existe")
            End If
        End If
    End Sub

    Private Sub TablaDeGestores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaDeGestores.CellClick
        Dim Indice As New Integer
        Indice = e.RowIndex
        Dim Gestor As DataGridViewRow
        Gestor = TablaDeGestores.Rows(Indice)
        txtNombreUsuario.Text = Gestor.Cells(0).Value.ToString()
        txtNombre.Text = Gestor.Cells(1).Value.ToString()
        txtApellido.Text = Gestor.Cells(2).Value.ToString()
        txtCedula.Text = Gestor.Cells(3).Value.ToString()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrEmpty(txtNombreUsuario.Text) Then
            MsgBox("Debe seleccionar el Gestor primero")
        Else
            Try
                ControladorUsuarios.DesactivarUsuario(txtNombreUsuario.Text, 3)
                MsgBox("Usuario desactivado")
                btnListarGestores_Click(sender, e)
            Catch ex As Exception
                MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub btnAgregarGestor_Click(sender As Object, e As EventArgs) Handles btnAgregarGestor.Click
        VentanaAgregarGestores.ShowDialog()
    End Sub

    Private Sub txtNombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtNombreUsuario.TextChanged
        If Not String.IsNullOrEmpty(txtNombreUsuario.Text) Then
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        End If
    End Sub
End Class