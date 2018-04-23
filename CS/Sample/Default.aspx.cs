using System;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e) {        
        string rtfText = System.IO.File.ReadAllText(Server.MapPath("Image.rtf"));
        ASPxGridViewExporter1.ReportHeader = rtfText;        
    }
    protected void b1_Click(object sender, EventArgs e) {
        ASPxGridViewExporter1.WritePdfToResponse();
    }
}
