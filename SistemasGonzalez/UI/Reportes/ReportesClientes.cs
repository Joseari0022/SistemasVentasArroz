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

namespace SistemasGonzalez.Reportes
{
    public partial class ReportesClientes : Form
    {
        public List<Clientes> Lista = new List<Clientes>();
        public ReportesClientes(List<Clientes> lista)
        {
            InitializeComponent();
        }

        private void ReportesClientes_Load(object sender, EventArgs e)
        {
            this.ClientesreportViewer.RefreshReport();
            ClientesreportViewer.Reset();
            ClientesreportViewer.ProcessingMode = ProcessingMode.Local;


            ReportDataSource source = new ReportDataSource("", Lista);
            ClientesreportViewer.LocalReport.DataSources.Add(source);
            this.ClientesreportViewer.RefreshReport();
        }
    }
}
