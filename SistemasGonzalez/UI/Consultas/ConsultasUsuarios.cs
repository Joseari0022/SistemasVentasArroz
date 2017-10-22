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
    public partial class ConsultasUsuarios : Form
    {
        public ConsultasUsuarios()
        {
            InitializeComponent();
            LlenarCombo();
        }

        public List<Usuarios> Lista { get; set; }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            BuscarSelecCombo();
        }

        private void LlenarCombo()
        {
            FiltrarcomboBox.Items.Insert(0, "Todo");
            FiltrarcomboBox.Items.Insert(1, "IdUsuarios");
            FiltrarcomboBox.Items.Insert(2, "NombresUsuarios");
            FiltrarcomboBox.Items.Insert(3, "Nombres");
            FiltrarcomboBox.Items.Insert(4, "Contrasena");
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
                cUsuarioerrorProvider.SetError(FiltrotextBox, "Por favor llenar");
                return false;
            }

            return true;
        }

        private void BuscarSelecCombo()
        {
            int Busqueda = Utilidades.ToInt(FiltrotextBox.Text);
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                Lista = UsuariosBll.ListarTodo();
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
                    Lista = UsuariosBll.Listar(u => u.IdUsuarios == Busqueda);
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
                    Lista = UsuariosBll.Listar(u => u.NombresUsuarios == FiltrotextBox.Text);
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
                    Lista = UsuariosBll.Listar(u => u.Nombres == FiltrotextBox.Text);
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
                    Lista = UsuariosBll.Listar(u => u.Contrasena == FiltrotextBox.Text);
                }
            }

            ConsultaClientedataGridView.DataSource = Lista;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            ReportesUsuarios ru = new ReportesUsuarios(Lista);
            ru.Show();
        }

        private void FiltrarcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
