using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace SistemasGonzalez.UI.Reportes
{
    public partial class ReportesProductos : Form
    {
        public List<Productos> Lista = new List<Productos>();
        public ReportesProductos(List<Productos> lista)
        {
            InitializeComponent();
        }

        private void ReportesProductos_Load(object sender, EventArgs e)
        {
            
            ReporteProductosreportViewer.Reset();
            ReporteProductosreportViewer.ProcessingMode = ProcessingMode.Local;
            this.ReporteProductosreportViewer.RefreshReport();

            ReportDataSource source = new ReportDataSource("", Lista);
            ReporteProductosreportViewer.LocalReport.DataSources.Add(source);
            this.ReporteProductosreportViewer.RefreshReport();
        }
    }
}
