Imports Capa_Logica

Public Class VentanaPatologia

    Private Sub btnAgregarPatologia_Click(sender As Object, e As EventArgs) Handles btnAgregarPatologia.Click
        Try
            If String.IsNullOrEmpty(txtNombrePatologia.Text) Then
                MsgBox("Debe ingresar un nombre para la patologia")
            Else
                ControladorPatologia.CrearPatologia(txtNombrePatologia.Text, cmbPatologia.SelectedItem)
                MsgBox("Patologia creada")
                ListarPat_Click(sender, e)
            End If
        Catch
            MsgBox("Ya existe una patologia con ese nombre")
        End Try
    End Sub

    Private Sub btnModificarPatologia_Click(sender As Object, e As EventArgs) Handles btnModificarPatologia.Click
        If String.IsNullOrEmpty(txtNombrePatologia.Text) Or String.IsNullOrEmpty(txtIdPatologia.Text) Then
            MsgBox("Debe ingresar un nombre para la patologia")
        Else
            Try
                ControladorPatologia.ModificarPatologia(txtIdPatologia.Text, txtNombrePatologia.Text, cmbPatologia.SelectedItem)
                MsgBox("Patologia modificada")
                ListarPat_Click(sender, e)
            Catch
                MsgBox("Ya existe una patologia con ese nombre")
            End Try
        End If
    End Sub

    Private Sub VentanaPatologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarPat_Click(sender, e)
        If cmbPatologia.Items.Count > 0 Then
            cmbPatologia.SelectedIndex = 0
        End If
    End Sub

    Private Sub ListarPat_Click(sender As Object, e As EventArgs) Handles ListarPat.Click
        Try
            Dim TablaPatologias As New DataTable
            TablaPatologias.Load(ControladorPatologia.ListarPatologias())

            TablaDePatologias.DataSource = TablaPatologias
            TablaDePatologias.Columns(0).Width = 25
            TablaDePatologias.Columns(1).Width = 100
            TablaDePatologias.Columns(2).Width = 75
        Catch ex As Exception
            MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnBorrarPat_Click(sender As Object, e As EventArgs) Handles BtnBorrarPat.Click
        If String.IsNullOrEmpty(txtIdPatologia.Text) Then
            MsgBox("Debe seleccionar una patologia para eliminarla")
        Else
            Dim BorrarPatologia As DialogResult
            BorrarPatologia = MessageBox.Show("¿Esta seguro de que desea eliminar esta patologia, se borraran todas las asociaciones en las que este involucrada?", "Borrar patologia", MessageBoxButtons.YesNo)
            If BorrarPatologia = DialogResult.Yes Then
                Try
                    ControladorPatologia.BorrarPatologia(txtIdPatologia.Text)
                    ListarPat_Click(sender, e)
                    MsgBox("Patologia eliminada")
                Catch
                    MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
                End Try
            End If
        End If

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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        OpenFileDialog1.ShowDialog()
        txtRutaCsv.Text = OpenFileDialog1.FileName
    End Sub


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtRutaCsv.Text = "" Then
            MsgBox("Por favor, seleccione un archivo", MsgBoxStyle.Critical, "Error")
        ElseIf String.Compare(Strings.Right(txtRutaCsv.Text, 4), ".csv", StringComparison.OrdinalIgnoreCase) <> 0 Then
            MsgBox("El formato del archivo debe ser .csv", MsgBoxStyle.Critical, "Error")
        Else
            Using archivo As New Microsoft.VisualBasic.
                      FileIO.TextFieldParser(
                        txtRutaCsv.Text)

                archivo.TextFieldType = FileIO.FieldType.Delimited
                archivo.SetDelimiters(",")
                Dim currentRow As String()
                Dim Contador As Integer = 0
                Dim Prioridades As String() = {"Alta", "Media", "Baja"}
                While Not archivo.EndOfData
                    Contador += 1
                    Try
                        currentRow = archivo.ReadFields()
                        Dim linea As String() = currentRow.ToArray()
                        If String.IsNullOrEmpty(linea(1)) Then
                            MsgBox("Linea " + Contador.ToString +
                            " no es valida y sera salteada.")
                        Else
                            Try
                                If Prioridades.Contains(linea(1)) Then
                                    ControladorPatologia.CrearPatologia(linea(0), linea(1))
                                    MsgBox("Patologia " + Chr(34) + linea(0) + Chr(34) + " fue ingresada")

                                Else
                                    MsgBox("La prioridad debe ser Alta, Media o Baja en linea " + Contador.ToString)
                                End If

                            Catch ex As Exception
                                MsgBox("Patologia " + Chr(34) + linea(0) + Chr(34) + " ya existe en el sistema")
                            End Try
                        End If
                    Catch ex As Exception
                        MsgBox("Linea " + Contador.ToString +
                        " no es valida y sera salteada.")
                    End Try
                    ListarPat_Click(sender, e)
                End While
            End Using
        End If
    End Sub


End Class