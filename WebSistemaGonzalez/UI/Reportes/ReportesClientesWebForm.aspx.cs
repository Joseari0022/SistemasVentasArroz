using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSistemaGonzalez.UI.Reportes
{
    public partial class ReportesClientesWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportViewerUsuario.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
            ReportViewerUsuario.Reset();

            ReportViewerUsuario.LocalReport.ReportPath = Server.MapPath(@"ClientesReport.rdlc");
            ReportViewerUsuario.LocalReport.DataSources.Clear();



            ReportViewerUsuario.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSetClientes",
                Consultas.ConsultaClientesWebForm.Listas));

            ReportViewerUsuario.LocalReport.Refresh();
        }
    }
}