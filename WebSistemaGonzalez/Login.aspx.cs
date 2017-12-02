using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Entidades;
using System.Data;
using System.Web.Security;

namespace WebSistemaGonzalez
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //public bool ValidarUsuario()
        //{
        //    if (UsuariosBll.GetListaNombre(NombreTextBox.Text).Count() == 0)
        //    {
        //        Utilidades.ShowToastr(this, "Por Favor", " llenar Nombre", "warning");
        //        return false;
        //    }
        //    return true;
        //}
        //public bool ValidarContrasena()
        //{
        //    if (UsuariosBll.GetContrasena(ContrasenaTextBox.Text).Count() == 0)
        //    {
        //        Utilidades.ShowToastr(this, "Por Favor", " llenar Contraseña", "warning");
        //        return false;
        //    }
        //    return true;
        //}

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            //if (ValidarUsuario() && ValidarContrasena() == true)
            //{

            //    Response.Redirect("/Default.aspx");
            //    Utilidades.ShowToastr(this, "Usuario", "Correcto", "Success");
            //}
            //else
            //{
            //    Utilidades.ShowToastr(this, "Usuario", "Incorrecto", "warning");
            //}
            Usuarios usuario = new Usuarios();
            usuario = UsuariosBll.Buscar(p => p.NombresUsuarios == NombreTextBox.Text);
            //usuarioLabel = user;

            if (usuario != null)
            {
                if (usuario.Contrasena == ContrasenaTextBox.Text)
                {

                    FormsAuthentication.RedirectFromLoginPage(NombreTextBox.Text, true);

                }
                else
                {
                    Utilidades.ShowToastr(this, "No coinciden", "Volverlo a intentar", "warning");

                    //Limpiar();
                }
            }
            else
            {


                //Utilidades.MostrarToastr(this, "No Exite Usuario", "Error", "Error");
                Utilidades.ShowToastr(this, "No Existe", "Usuario Incorrecto", "warning");
                //Limpiar();
            }
        }
    }
}