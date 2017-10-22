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
    public partial class ConsultasProductos : Form
    {
        public ConsultasProductos()
        {
            InitializeComponent();
            LlenarCombo();
        }

        public List<Productos> Lista { get; set; }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            BuscarSelecCombo();
        }

        private void LlenarCombo()
        {
            FiltrarcomboBox.Items.Insert(0, "Todo");
            FiltrarcomboBox.Items.Insert(1, "IdProductos");
            FiltrarcomboBox.Items.Insert(2, "Descripcion");
            FiltrarcomboBox.Items.Insert(3, "Cantidad");
            FiltrarcomboBox.Items.Insert(4, "Precio");
            FiltrarcomboBox.Items.Insert(5, "FechaCreacion");
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
                cProductoerrorProvider.SetError(FiltrotextBox, "Por favor llenar");
                return false;
            }

            return true;
        }

        private void BuscarSelecCombo()
        {
            int Busqueda = Utilidades.ToInt(FiltrotextBox.Text);
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                Lista = ProductosBll.ListarTodo();
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
                    Lista = ProductosBll.Listar(p => p.IdProductos == Busqueda);
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
                    Lista = ProductosBll.Listar(p => p.Descripcion == FiltrotextBox.Text);
                }
            }

            else if (FiltrarcomboBox.SelectedIndex == 3)
            {
                if (!ValidarTex())
                {
                    MessageBox.Show("Por favor llenar ");
                }
                else
                {
                    Lista = ProductosBll.Listar(p => p.Cantidad == Utilidades.ToInt(FiltrotextBox.Text));
                }
            }

            else if (FiltrarcomboBox.SelectedIndex == 4)
            {
                if (!ValidarTex())
                {
                    MessageBox.Show("Por favor llenar ");
                }
                else
                {
                    Lista = ProductosBll.Listar(p => p.Precio == Utilidades.ToInt(FiltrotextBox.Text));
                }
            }

            else if (FiltrarcomboBox.SelectedIndex == 5)
            {
                if (!ValidarTex())
                {
                    MessageBox.Show("Por favor llenar ");
                }
                else
                {
                    Lista = ProductosBll.Listar(p => p.Precio == Utilidades.ToInt(FiltrotextBox.Text));
                }
            }
            ConsultaClientedataGridView.DataSource = Lista;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            ReportesProductos rp = new ReportesProductos(Lista);
            rp.Show();
        }
    }
}
