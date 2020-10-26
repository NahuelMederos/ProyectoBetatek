Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Capa_Fisica
<TestClass()> Public Class TestModeloDiagnostico

    <TestMethod()> Public Sub TestCrearDiagnostico()
        Dim d As New Diagnostico("root", "1234")
        d.Prioridad = "Alta"
        d.Informacion = "Diagnostico #231"
        d.SolicitaChat = "1"

        Dim resultado As Boolean

        Try
            d.CrearDiagnostico()
            resultado = True

        Catch ex As Odbc.OdbcException

            resultado = False
        End Try

        Assert.IsTrue(resultado)

    End Sub

End Class