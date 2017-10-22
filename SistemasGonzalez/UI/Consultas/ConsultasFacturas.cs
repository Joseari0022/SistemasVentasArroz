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
using BLL;
using SistemasGonzalez.UI.Reportes;

namespace SistemasGonzalez.UI.Consultas
{
    public partial class ConsultasFacturas : Form
    {
        public ConsultasFacturas()
        {
            InitializeComponent();
            LlenarCombo();
        }

        public List<Facturas> Lista { get; set; }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void LlenarCombo()
        {
            FiltrarcomboBox.Items.Insert(0, "Todo");
            FiltrarcomboBox.Items.Insert(1, "IdFactura");
            FiltrarcomboBox.Items.Insert(2, "NombreCliente");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Todo";

            if (FiltrarcomboBox.Items.Count >= 1)
            {
                FiltrarcomboBox.SelectedIndex = -1;
            }
        }

        private bool ValidarTex()
        {
            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                cFacturaerrorProvider.SetError(FiltrotextBox, "Por favor llenar");
                return false;
            }

            return true;
        }

        private void BuscarSelecCombo()
        {
            int Busqueda = Utilidades.ToInt(FiltrotextBox.Text);
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                ConsultaFacturadataGridView.DataSource = FacturaBll.ListarTodo();
                FiltrotextBox.Enabled = false;
            }

            else if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!ValidarTex())
                {
                    MessageBox.Show("Por favor llenar ");
                }
                else
                {
                    Lista = FacturaBll.Listar(f => f.IdFactura == Busqueda);
                }
            }

            else if (FiltrarcomboBox.SelectedIndex == 2)
            {
                if (!ValidarTex())
                {
                    MessageBox.Show("Por favor llenar ");
                }
                else
                {
                    Lista = FacturaBll.Listar(f => f.NombreCliente == FiltrotextBox.Text);
                }
            }

            ConsultaFacturadataGridView.DataSource = Lista;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            ReportesFacturas rf = new ReportesFacturas(Lista);
            rf.Show();
        }
    }
}
