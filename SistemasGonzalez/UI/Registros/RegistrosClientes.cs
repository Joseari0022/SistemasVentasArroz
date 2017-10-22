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

namespace SistemasGonzalez.UI.Registros
{
    public partial class RegistrosClientes : Form
    {
        public RegistrosClientes()
        {
            InitializeComponent();
        }

        private void RegistrosClientes_Load(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(IdtextBox.Text);
            Clientes cliente = ClientesBll.Buscar(c => c.IdClientes == id);
            if(cliente != null)
            {
                NombretextBox.Text = cliente.Nombres;
                CedulatextBox.Text = cliente.Cedula;
                FechaNacimientodateTimePicker.Value = cliente.FechaNacimiento;
                DirecciontextBox.Text = cliente.Direccion;
                TelefonotextBox.Text = cliente.Telefono;
                FechaCreaciondateTimePicker.Value = cliente.FechaCreacion;
            }
            else
            {
                MessageBox.Show("No existe!!!");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            IdtextBox.Clear();
            NombretextBox.Clear();
            FechaNacimientodateTimePicker.Value = DateTime.Today;
            CedulatextBox.Clear();
            DirecciontextBox.Clear();
            TelefonotextBox.Clear();
            FechaCreaciondateTimePicker.Value = DateTime.Today;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Clientes cliente = null;
            if(!Validar())
            {
                MessageBox.Show("Llenar campos por favor");
            }
            else
            {
                cliente = Llenar();
                ClientesBll.Guardar(cliente);
                MessageBox.Show("Cliente guardado!!!");
                Limpiar();
            }
        }

        private Clientes Llenar()
        {
            Clientes cliente = new Clientes();
            cliente.Nombres = NombretextBox.Text;
            cliente.FechaNacimiento = FechaNacimientodateTimePicker.Value;
            cliente.Cedula = CedulatextBox.Text;
            cliente.Direccion = DirecciontextBox.Text;
            cliente.Telefono = TelefonotextBox.Text;
            cliente.FechaCreacion = FechaCreaciondateTimePicker.Value;

            return cliente;
        }
        private bool Validar()
        {
            bool cambio = true;
            if ((string.IsNullOrEmpty(NombretextBox.Text)) || (string.IsNullOrEmpty(NombretextBox.Text)) || (string.IsNullOrEmpty(CedulatextBox.Text)) || (string.IsNullOrEmpty(DirecciontextBox.Text)) || (string.IsNullOrEmpty(TelefonotextBox.Text)))
            {
                ClienteerrorProvider.SetError(NombretextBox, "Ingrese el nombre del cliente");
                ClienteerrorProvider.SetError(CedulatextBox, "Ingrese la cedula");
                ClienteerrorProvider.SetError(DirecciontextBox, "Ingrese la direccion");
                ClienteerrorProvider.SetError(TelefonotextBox, "Ingrese el telefono");
                cambio = false;
            }
            return cambio;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(IdtextBox.Text);
            Clientes cliente = ClientesBll.Buscar(c => c.IdClientes == id);
            if (cliente != null)
            {
                if (ClientesBll.Eliminar(cliente))
                    MessageBox.Show("Cliente eliminado!!!");
                else
                    MessageBox.Show("Cliente no eliminado!!!");
            }
            else
                MessageBox.Show("Cliente no existente!!!");
            Limpiar();
        }
    }
}
