<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128539493/12.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1935)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/Sample/Default.aspx) (VB: [Default.aspx](./VB/Sample/Default.aspx))
* **[Default.aspx.cs](./CS/Sample/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Sample/Default.aspx.vb))**
<!-- default file list end -->
# How to display images in the Header and Footer sections when exporting ASPxGridView
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1935/)**
<!-- run online end -->


<p>By default, the ASPxGridViewExporter doesn't provide methods or properties for setting images as a header or footer for the resulting report.  This sample illustrates the approach which allows you to achieve the desired effect.</p><p>The main idea is to convert an image to RTF text, and then load this text to the ASPxGridViewExporter's <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewExportASPxGridViewExporter_ReportHeadertopic"><u>ReportHeader</u></a> and/or <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewExportASPxGridViewExporter_ReportFootertopic"><u>ReportFooter</u></a> properties. You can generate the necessary RTF text using any text processing editor with RTF support (e.g. MS Word).</p><p>See also:<br />
<a href="https://www.devexpress.com/Support/Center/p/E3184">How to display images and text in the Header and Footer sections when exporting ASPxGridView by using CompositeLink</a></p>

<br/>


