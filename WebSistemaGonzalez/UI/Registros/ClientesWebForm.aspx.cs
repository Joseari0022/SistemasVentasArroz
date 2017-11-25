using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Entidades;

namespace WebSistemaGonzalez.UI.Registros
{
    public partial class ClientesWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.FechaCreacTextBox.Text = string.Format("{0:G}", DateTime.Now);
            FechaCreacTextBox.Enabled = false;
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(idClienteTextbox.Text);
            Clientes clientes = ClientesBll.Buscar(u => u.IdClientes == id);
            if (clientes != null)
            {
                NombreTextBox.Text = clientes.Nombres;
                CedulaTextBox.Text = clientes.Cedula;
                DireccionTextBox.Text = clientes.Direccion;
                TelefonoTextBox.Text = clientes.Telefono;
                FechaTextBox.Text = clientes.FechaNacimiento.ToString();
                FechaCreacTextBox.Text = clientes.FechaCreacion.ToString();
                Utilidades.ShowToastr(this, "Si Existe", "Cliente Encontrado", "Success");
            }
            else
            {
                Utilidades.ShowToastr(this, "No Existe", "Ingresar Cliente Existente", "warning");
            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            idClienteTextbox.Text = " ";
            NombreTextBox.Text = " ";
            CedulaTextBox.Text = " ";
            DireccionTextBox.Text = " ";
            TelefonoTextBox.Text = " ";
            RequiredFieldValidator1.Text = " ";
            RequiredFieldValidator2.Text = " ";
            RequiredFieldValidator3.Text = " ";
            RequiredFieldValidator4.Text = " ";
            RequiredFieldValidator5.Text = " ";
            RequiredFieldValidator6.Text = " ";
            RequiredFieldValidator7.Text = " ";
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            if (IsValid)
            {
                if (clientes.IdClientes != 0)
                {
                    ClientesBll.Modificar(clientes);
                    Utilidades.ShowToastr(this, "El Usuario", " Se Modifico Correctamente", "Success");
                }
                else
                {
                    clientes = Llenar();
                    ClientesBll.Guardar(clientes);
                    Utilidades.ShowToastr(this, "El Usuario", " Se Guardo Correctamente", "Success");
                    Limpiar();

                }
            }
        }

        private Clientes Llenar()
        {
            Clientes clientes = new Clientes();
            clientes.Nombres = NombreTextBox.Text;
            clientes.Cedula = CedulaTextBox.Text;
            clientes.Direccion = DireccionTextBox.Text;
            clientes.Telefono = TelefonoTextBox.Text;
            clientes.FechaNacimiento = Convert.ToDateTime(FechaTextBox.Text);
            clientes.FechaCreacion = Convert.ToDateTime(FechaCreacTextBox.Text);

            return clientes;
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(idClienteTextbox.Text);
            Clientes clientes = ClientesBll.Buscar(u => u.IdClientes == id);
            if (clientes != null)
            {
                if (clientes.IdClientes != 1)
                {
                    ClientesBll.Eliminar(clientes);
                    Utilidades.ShowToastr(this, "El Cliente", " Se Elimino Correctamente", "Success");
                    Limpiar();
                }
                else
                {
                    Utilidades.ShowToastr(this, "El Cliente", "No Se Elimino", "warning");
                }
            }
        }
    }
}