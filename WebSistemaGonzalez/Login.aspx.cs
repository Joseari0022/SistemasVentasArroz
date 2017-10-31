using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;


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
                Utilidades.ShowToastr(this, "Por Favor", " llenar Nombre", "warning");
                return false;
            }
            return true;
        }
        public bool ValidarContrasena()
        {
            if (UsuariosBll.GetContrasena(ContrasenaTextBox.Text).Count() == 0)
            {
                Utilidades.ShowToastr(this, "Por Favor", " llenar Contraseña", "warning");
                return false;
            }
            return true;
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (ValidarUsuario() && ValidarContrasena() == true)
            {

                Response.Redirect("Default.aspx");
                Utilidades.ShowToastr(this, "Muy bien sicario", "Correcto", "Success");
            }
            else
            {
                Utilidades.ShowToastr(this, "Muy bien sicario", "Correcto", "Success");
            }
        }
    }
}