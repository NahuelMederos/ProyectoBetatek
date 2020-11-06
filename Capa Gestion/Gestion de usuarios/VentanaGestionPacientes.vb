Imports Capa_Logica
Public Class VentanaGestionPacientes
    Private Sub VentanaGestionPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnListarPacientes_Click(sender, e)
    End Sub

    Public Sub btnListarPacientes_Click(sender As Object, e As EventArgs) Handles btnListarPacientes.Click
        Dim TablaPacientes As New DataTable
        Try
            TablaPacientes.Load(ControladorUsuarios.ListarUsuarios(1))

            TablaDePacientes.DataSource = TablaPacientes
            TablaDePacientes.Columns(3).Width = 40
            TablaDePacientes.Columns(4).Width = 200
        Catch ex As Exception
            MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TablaDePacientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaDePacientes.CellClick
        Dim Indice As New Integer
        Indice = e.RowIndex
        Dim Paciente As DataGridViewRow
        Paciente = TablaDePacientes.Rows(Indice)
        txtCi.Text = Paciente.Cells(0).Value.ToString()
        txtNombre.Text = Paciente.Cells(1).Value.ToString()
        txtApellido.Text = Paciente.Cells(2).Value.ToString()
        txtEdad.Text = Paciente.Cells(3).Value.ToString()
        txtMail.Text = Paciente.Cells(4).Value.ToString()


    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If String.IsNullOrEmpty(txtCi.Text) Or String.IsNullOrEmpty(txtNombre.Text) Or String.IsNullOrEmpty(txtApellido.Text) Or String.IsNullOrEmpty(txtEdad.Text) Or String.IsNullOrEmpty(txtMail.Text) Then
            MsgBox("Todos los campos son obligatorios")
        Else

            If String.Compare(txtMail.Text, ControladorUsuarios.ObtenerDatosPaciente(txtCi.Text, 4)) = 0 Or ControladorUsuarios.VerificarExistenciaClaveUnica(txtMail.Text, 3) = "0" Then
                Try
                    ControladorUsuarios.ModificarPaciente(txtCi.Text, txtNombre.Text, txtApellido.Text, txtEdad.Text, txtMail.Text)
                    MsgBox("Datos modificados")
                    btnListarPacientes_Click(sender, e)
                Catch ex As Exception
                    MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
                End Try
            Else
                MsgBox("Ese mail ya existe")
            End If
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrEmpty(txtCi.Text) Then
            MsgBox("Debe seleccionar el paciente primero")
        Else
            Try
                ControladorUsuarios.DesactivarUsuario(txtCi.Text, 1)
                MsgBox("Usuario desactivado")
                btnListarPacientes_Click(sender, e)
            Catch ex As Exception
                MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub btnAgregarPaciente_Click(sender As Object, e As EventArgs) Handles btnAgregarPaciente.Click
        VentanaAgregarPacientes.ShowDialog()
    End Sub

    Private Sub txtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEdad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtCi_TextChanged_1(sender As Object, e As EventArgs) Handles txtCi.TextChanged
        If Not String.IsNullOrEmpty(txtCi.Text) Then
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        End If
    End Sub


End Class