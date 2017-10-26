using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebSistemaGonzalez
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public bool ValidarUsuario()
        {
            if (UsuariosBll.GetListaNombre(NombreTextBox.Text).Count() == 0)
            {
              //  Label1.Text = "Usuario No Registrado";
                return false;
            }
            return true;
        }
        public bool ValidarContrasena()
        {
         //   if (UsuarioBLL.GetContrasena(ClaveTextBox.Text).Count() == 0)
            {
               /// Label1.Text = "Contrasena Invalida";
                return false;
            }
            return true;
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
         
        }
    }
}