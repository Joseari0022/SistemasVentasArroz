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
    public partial class ReportesFacturas : Form
    {
        public List<Facturas> Lista = new List<Facturas
            >();
        public ReportesFacturas(List<Facturas> Lista)
        {
            InitializeComponent();
        }

        private void ReportesFacturas_Load(object sender, EventArgs e)
        {
            this.FacturareportViewer.RefreshReport();
            FacturareportViewer.Reset();
            FacturareportViewer.ProcessingMode = ProcessingMode.Local;

            ReportDataSource source = new ReportDataSource("", Lista);
            FacturareportViewer.LocalReport.DataSources.Add(source);
            this.FacturareportViewer.RefreshReport();
        }
    }
}
