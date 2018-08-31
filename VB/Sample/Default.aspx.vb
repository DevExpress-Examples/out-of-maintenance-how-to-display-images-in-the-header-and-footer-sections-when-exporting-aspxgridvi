Imports System
Imports System.Linq

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

        ASPxGridView1.DataSource = Enumerable.Range(0, 10).Select(Function(i) New With { _
            Key .ID = i, _
            Key .Description = "Description " & i _
        })
        ASPxGridView1.DataBind()

        Dim rtfText As String = System.IO.File.ReadAllText(Server.MapPath("Image.rtf"))
        ASPxGridViewExporter1.ReportHeader = rtfText
        ASPxGridViewExporter1.ReportFooter = rtfText
    End Sub
    Protected Sub b1_Click(ByVal sender As Object, ByVal e As EventArgs)
        ASPxGridViewExporter1.WritePdfToResponse()
    End Sub

End Class
