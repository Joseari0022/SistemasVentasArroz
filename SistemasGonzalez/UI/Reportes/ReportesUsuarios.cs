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
    public partial class ReportesUsuarios : Form
    {
        public List<Usuarios> Lista = new List<Usuarios>();
        public ReportesUsuarios(List<Usuarios> Lista)
        {
            InitializeComponent();
        }

        private void ReportesUsuarios_Load(object sender, EventArgs e)
        {
            this.UsuariosreportViewer.RefreshReport();
            UsuariosreportViewer.Reset();
            UsuariosreportViewer.ProcessingMode = ProcessingMode.Local;


            ReportDataSource source = new ReportDataSource("", Lista);
            UsuariosreportViewer.LocalReport.DataSources.Add(source);
            this.UsuariosreportViewer.RefreshReport();
        }
    }
}
