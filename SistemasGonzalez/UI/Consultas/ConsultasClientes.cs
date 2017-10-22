using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;
using BLL;
using SistemasGonzalez.Reportes;

namespace SistemasGonzalez.UI.Consultas
{
    public partial class ConsultasClientes : Form
    {
        public ConsultasClientes()
        {
            InitializeComponent();
           // LlenarCombo();
        }

        public List<Clientes> Lista { get; set; }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            BuscarSelecCombo();
            
        }

        private void LlenarCombo()
        {
            FiltrarcomboBox.Items.Insert(0, "Todo");
            FiltrarcomboBox.Items.Insert(1, "IdClientes");
            FiltrarcomboBox.Items.Insert(2, "Nombres");
            FiltrarcomboBox.Items.Insert(3, "FechaNacimiento");
            FiltrarcomboBox.Items.Insert(4, "Cedula");
            FiltrarcomboBox.Items.Insert(5, "Direccion");
            FiltrarcomboBox.Items.Insert(6, "Telefono");
            FiltrarcomboBox.Items.Insert(7, "FechaCreacion");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Todo";

            if(FiltrarcomboBox.Items.Count >= 1)
            {
                FiltrarcomboBox.SelectedIndex = -1;
            }
        }

        private bool ValidarTex()
        {
            if(string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                cClienteserrorProvider.SetError(FiltrotextBox, "Por favor llenar");
                return false;
            }

            return true;
        }

        private void BuscarSelecCombo()
        {
            int Busqueda = Utilidades.ToInt(FiltrotextBox.Text);
            if(FiltrarcomboBox.SelectedIndex == 0 )
            {
                Lista = ClientesBll.ListarTodo();
                FiltrotextBox.Enabled = false;
            }

            else if(FiltrarcomboBox.SelectedIndex == 1)
            {
                if(!ValidarTex())
                {
                    MessageBox.Show("Por favor llenar ");
                }
                else
                {
                    Lista = ClientesBll.Listar(c => c.IdClientes == Busqueda);
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
                    Lista = ClientesBll.Listar(c => c.Nombres == FiltrotextBox.Text);
                }
            }

            else if (FiltrarcomboBox.SelectedIndex == 3)
            {
                DesdeDateTimePicke.Enabled = true;
                HastadateTimePicker.Enabled = true;
                if (DesdeDateTimePicke.Value.Date > DesdeDateTimePicke.Value.Date)
                {
                   // Lista = ClientesBll.Listar(p => p.Fecha >= desdedateTimePicker.Value.Date && p.Fecha < hastadateTimePicker.Value.Date);
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
                    Lista = ClientesBll.Listar(c => c.Cedula == FiltrotextBox.Text);
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
                    Lista = ClientesBll.Listar(c => c.Direccion == FiltrotextBox.Text);
                }
            }

            else if (FiltrarcomboBox.SelectedIndex == 6)
            {
                if (!ValidarTex())
                {
                    MessageBox.Show("Por favor llenar ");
                }
                else
                {
                    Lista = ClientesBll.Listar(c => c.Telefono == FiltrotextBox.Text);
                }
            }

            else if (FiltrarcomboBox.SelectedIndex == 7)
            {
                if (!ValidarTex())
                {
                    MessageBox.Show("Por favor llenar ");
                }
                else
                {
                   // Lista = ClientesBll.Listar(c => c.FechaCreacion == FiltrotextBox.Text);
                }
            }

            ConsultaClientedataGridView.DataSource = Lista;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            ReportesClientes rc = new ReportesClientes(Lista);
            rc.Show();
        }

        private void ConsultasClientes_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }
    }
}
