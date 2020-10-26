Imports Capa_Logica

Public Class VentanaSintomas
    Private Sub btnAgregarSintoma_Click(sender As Object, e As EventArgs) Handles btnAgregarSintoma.Click
        Try
            If String.IsNullOrEmpty(txtNombreSintoma.Text) Then
                MsgBox("Debe ingresar un nombre para el sintoma")
            Else
                ControladorSintoma.CrearSintoma(txtNombreSintoma.Text)
                MsgBox("Sintoma creado")
                Listar_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try


    End Sub

    Private Sub btnModificarSintoma_Click(sender As Object, e As EventArgs) Handles btnModificarSintoma.Click
        Try
            ControladorSintoma.ModificarSintoma(txtIdSintoma.Text, txtNombreSintoma.Text)
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
            MsgBox("Primero debe borrar las asociaciones de este sintoma")
        End Try
    End Sub



    Private Sub TablaDeSintomas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaDeSintomas.CellClick
        Dim Indice As New Integer
        Indice = e.RowIndex
        Dim SSeleccionada As DataGridViewRow
        SSeleccionada = TablaDeSintomas.Rows(Indice)
        txtIdSintoma.Text = SSeleccionada.Cells(0).Value.ToString()
        txtNombreSintoma.Text = SSeleccionada.Cells(1).Value.ToString()
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
                While Not archivo.EndOfData
                    Contador += 1
                    Try
                        currentRow = archivo.ReadFields()
                        Dim linea As String() = currentRow.ToArray()
                        Try
                                ControladorSintoma.CrearSintoma(linea(0))
                                MsgBox("Sintoma " + Chr(34) + linea(0) + Chr(34) + " fue ingresado")
                            Catch ex As Exception
                                MsgBox("Sintoma " + Chr(34) + linea(0) + Chr(34) + " ya existe en el sistema")
                            End Try

                    Catch ex As Exception
                        MsgBox("Linea " + Contador.ToString +
                        " no es valida y sera salteada.")
                    End Try
                    Listar_Click(sender, e)
                End While
            End Using
        End If
    End Sub
End Class