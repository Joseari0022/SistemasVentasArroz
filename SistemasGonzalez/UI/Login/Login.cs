using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasGonzalez.UI.Login
{
    public partial class Login : Form
    {
        private static Usuarios Usuario = null;

        public Login()
        {
            InitializeComponent();
        }

        private void IniciarSesionbutton_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private bool ValidarSesion()
        {
            if (UsuariotextBox.Text == "Admin" && Usuario == null)
            {
                Usuario = new Usuarios();
                UsuariosBll.Guardar(Usuario);

                var cliente = new Clientes();
                ClientesBll.Guardar(cliente);

                var producto = new Productos();
                ProductosBll.Guardar(producto);

                var p = new Productos();
                ProductosBll.Guardar(p);
            }
            else
            {
                Usuario = UsuariosBll.Buscar(p => p.NombresUsuarios == UsuariotextBox.Text);
            }

            if (Usuario != null)
            {
                if (ContraseñatextBox.Text == Usuario.Contrasena)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("La clave no coinside con el usuario.");
                    ContraseñatextBox.Clear();
                    ContraseñatextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("El usuario digitado no existe.");
                UsuariotextBox.Clear();
                UsuariotextBox.Focus();
            }

            return false;
        }

        public static Entidades.Usuarios GetUsuario()
        {
            return Usuario;
        }

        public bool ValidTextB()
        {
            if (string.IsNullOrEmpty(UsuariotextBox.Text) && string.IsNullOrEmpty(ContraseñatextBox.Text))
            {
                LoginerrorProvider.SetError(UsuariotextBox, "Ingrese el usuario");
                LoginerrorProvider.SetError(ContraseñatextBox, "Ingrese contraseña");
                MessageBox.Show("Llenar todos los campos");
            }
            if (string.IsNullOrEmpty(UsuariotextBox.Text))
            {
                LoginerrorProvider.SetError(UsuariotextBox, "Ingrese el usuario por favor");
                return false;
            }
            if (string.IsNullOrEmpty(ContraseñatextBox.Text))
            {
                LoginerrorProvider.Clear();
                LoginerrorProvider.SetError(ContraseñatextBox, "Ingrese contraseña por favor");
                return false;
            }
            return true;
        }

        private void IniciarSesion()
        {
            if (!ValidTextB())
            {
                MessageBox.Show("Por favor llenar los campos vacios");
            }
            else
            {
                if (ValidarSesion())
                {
                    new SistemasGonzalez.Principal().Show();
                    this.Hide();
                }
            }
        }
    }
}
