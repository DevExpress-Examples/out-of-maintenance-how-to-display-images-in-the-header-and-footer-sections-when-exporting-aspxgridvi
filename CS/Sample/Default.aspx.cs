using System;
using System.Linq;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

        ASPxGridView1.DataSource = Enumerable.Range(0, 10).Select(i => new {
            ID = i,
            Description = "Description " + i
        });
        ASPxGridView1.DataBind();

        string rtfText = System.IO.File.ReadAllText(Server.MapPath("Image.rtf"));
        ASPxGridViewExporter1.ReportHeader = rtfText;
        ASPxGridViewExporter1.ReportFooter = rtfText;
    }
    protected void b1_Click(object sender, EventArgs e) {
        ASPxGridViewExporter1.WritePdfToResponse();
    }

}
