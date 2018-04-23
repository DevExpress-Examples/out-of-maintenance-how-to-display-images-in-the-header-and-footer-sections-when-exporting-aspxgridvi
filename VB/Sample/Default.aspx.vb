Imports System

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim rtfText As String = System.IO.File.ReadAllText(Server.MapPath("Image.rtf"))
        ASPxGridViewExporter1.ReportHeader = rtfText
    End Sub
    Protected Sub b1_Click(ByVal sender As Object, ByVal e As EventArgs)
        ASPxGridViewExporter1.WritePdfToResponse()
    End Sub
End Class
