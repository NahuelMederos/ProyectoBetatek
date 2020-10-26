Imports System.ComponentModel

Public Class VentanaChatCompleto
    Public StrChatCompleto As String

    Private Sub VentanaChatCompleto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.DocumentText = StrChatCompleto
    End Sub


    Private Sub VentanaChatCompleto_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class