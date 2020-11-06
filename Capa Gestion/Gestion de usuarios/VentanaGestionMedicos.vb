Imports Capa_Logica
Public Class VentanaGestionMedicos
    Public Sub btnListarMedicos_Click(sender As Object, e As EventArgs) Handles btnListarMedicos.Click
        Try
            Dim TablaMedicos As New DataTable
            TablaMedicos.Load(ControladorUsuarios.ListarUsuarios(2))

            TablaDeMedicos.DataSource = TablaMedicos
        Catch ex As Exception
            MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub VentanaGestionMedicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnListarMedicos_Click(sender, e)
    End Sub


    Private Sub TablaDeMedicos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaDeMedicos.CellClick
        Dim Indice As New Integer
        Indice = e.RowIndex
        Dim Medico As DataGridViewRow
        Medico = TablaDeMedicos.Rows(Indice)
        txtNombreUsuario.Text = Medico.Cells(0).Value.ToString()
        txtNombre.Text = Medico.Cells(1).Value.ToString()
        txtApellido.Text = Medico.Cells(2).Value.ToString()
        txtCedula.Text = Medico.Cells(3).Value.ToString()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If String.IsNullOrEmpty(txtNombreUsuario.Text) Or String.IsNullOrEmpty(txtNombre.Text) Or String.IsNullOrEmpty(txtApellido.Text) Or String.IsNullOrEmpty(txtCedula.Text) Then
            MsgBox("Todos los campos son obligatorios")
        Else
            If String.Compare(txtCedula.Text, ControladorUsuarios.ObtenerDatosMedico(txtNombreUsuario.Text, 3)) = 0 Or ControladorUsuarios.VerificarExistenciaClaveUnica(txtCedula.Text, 2) = "0" Then
                Try
                    ControladorUsuarios.ModificarMedico(txtNombreUsuario.Text, txtNombre.Text, txtApellido.Text, txtCedula.Text)
                    MsgBox("Datos modificados")
                    btnListarMedicos_Click(sender, e)
                Catch ex As Exception
                    MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
                End Try
            Else
                MsgBox("Esta cedula ya existe")
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrEmpty(txtNombreUsuario.Text) Then
            MsgBox("Debe seleccionar el Medico primero")
        Else
            Try
                ControladorUsuarios.DesactivarUsuario(txtNombreUsuario.Text, 2)
                MsgBox("Usuario desactivado")
                btnListarMedicos_Click(sender, e)
            Catch ex As Exception
                MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
            End Try

        End If
    End Sub

    Private Sub btnAgregarMedico_Click(sender As Object, e As EventArgs) Handles btnAgregarMedico.Click
        VentanaAgregarMedicos.ShowDialog()
    End Sub

    Private Sub txtNombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtNombreUsuario.TextChanged
        If Not String.IsNullOrEmpty(txtNombreUsuario.Text) Then
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        End If
    End Sub


End Class