Imports System.ComponentModel

Public Class ChatCompleto
    Public StrChatCompleto As String

    Private Sub ChatCompleto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser2.DocumentText = StrChatCompleto
    End Sub

    Private Sub ChatCompleto_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class