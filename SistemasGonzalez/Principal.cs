using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasGonzalez
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.RegistrosUsuarios ru = new UI.Registros.RegistrosUsuarios();
            ru.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UI.Registros.RegistrosClientes rc = new UI.Registros.RegistrosClientes();
            rc.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.RegistrosProductos rp = new UI.Registros.RegistrosProductos();
            rp.Show();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.RegistrosFactura rf = new UI.Registros.RegistrosFactura();
            rf.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Consultas.ConsultasUsuarios cu = new UI.Consultas.ConsultasUsuarios();
            cu.Show();
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UI.Consultas.ConsultasClientes cc = new UI.Consultas.ConsultasClientes();
            cc.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UI.Consultas.ConsultasProductos cp = new UI.Consultas.ConsultasProductos();
            cp.Show();
        }

        private void facturarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UI.Consultas.ConsultasFacturas cf = new UI.Consultas.ConsultasFacturas();
            cf.Show();
        }
    }
}
