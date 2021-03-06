﻿Imports Capa_Logica

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
            MsgBox("Error, ya existe un sintoma con este nombre")
        End Try

    End Sub

    Private Sub btnModificarSintoma_Click(sender As Object, e As EventArgs) Handles btnModificarSintoma.Click
        If String.IsNullOrEmpty(txtNombreSintoma.Text) Or String.IsNullOrEmpty(txtIdSintoma.Text) Then
            MsgBox("No puede dejar campos vacios")
        Else
            Try
                ControladorSintoma.ModificarSintoma(txtIdSintoma.Text, txtNombreSintoma.Text)
                MsgBox("Sintoma modificado")
                Listar_Click(sender, e)
            Catch
                MsgBox("Ya existe un sintoma con ese nombre")
            End Try
        End If
    End Sub


    Private Sub VentanaSintomas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_Click(sender, e)
    End Sub

    Private Sub Listar_Click(sender As Object, e As EventArgs) Handles Listar.Click
        Try
            Dim TablaSintomas As New DataTable
            TablaSintomas.Load(ControladorSintoma.ListarSintomas())
            TablaDeSintomas.DataSource = TablaSintomas
            TablaDeSintomas.Columns(0).Width = 25
            TablaDeSintomas.Columns(1).Width = 125
        Catch ex As Exception
            MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        If String.IsNullOrEmpty(txtIdSintoma.Text) Then
            MsgBox("Debe seleccionar un sintoma para eliminarlo")
        Else
            Dim BorrarSintoma As DialogResult
            BorrarSintoma = MessageBox.Show("¿Esta seguro de que desea eliminar este sintoma, se borraran todas las asociaciones en las que este involucrado?", "Borrar sintoma", MessageBoxButtons.YesNo)
            If BorrarSintoma = DialogResult.Yes Then
                Try
                    ControladorSintoma.BorrarSintoma(txtIdSintoma.Text)
                    MsgBox("Sintoma eliminado")
                    Listar_Click(sender, e)
                Catch ex As Exception
                    MsgBox("El sistema no se pudo comunicar con la base de datos", MsgBoxStyle.Critical, "Error")
                End Try

            End If
        End If
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