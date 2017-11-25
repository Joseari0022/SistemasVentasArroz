using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using BLL;

namespace WebSistemaGonzalez.UI.Registros
{
    public partial class UsuariosWebForm : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            this.FechaTextBox.Text = string.Format("{0:G}", DateTime.Now);
            ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
            myScriptResDef.Path = "~/Scripts/jquery-1.4.2.min.js";
            myScriptResDef.DebugPath = "~/Scripts/jquery-1.4.2.js";
            myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
            myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
            myScriptResDef.CdnDebugPath = "~/Content/toastr.css";
            myScriptResDef.CdnDebugPath = "~/Content/toastr.min.css";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);
            FechaTextBox.Enabled = false;
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            idUsuarioTextbox.Text = "";
            NombreUsuarioTextBox.Text = "";
            NombresTextBox.Text = "";
            ContraseñaTextBox.Text = "";
            RequiredFieldValidator1.Text = "";
            RequiredFieldValidator2.Text = "";
            RequiredFieldValidator3.Text = "";
            RequiredFieldValidator4.Text = "";
            RequiredFieldValidator5.Text = "";

        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(idUsuarioTextbox.Text);
            Usuarios usuario = UsuariosBll.Buscar(u => u.IdUsuarios == id);
            if (usuario != null)
            {
                NombreUsuarioTextBox.Text = usuario.NombresUsuarios;
                NombresTextBox.Text = usuario.Nombres;
                FechaTextBox.Text = usuario.Fecha.ToString();
                Utilidades.ShowToastr(this, "Si Existe", "Usuario Encontrado", "Success");
                }
            else
            {
                Utilidades.ShowToastr(this, "No Existe", "Ingresar Usuario Existente", "warning");
            }
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            if (IsValid)
            {
                if (usuario.IdUsuarios != 0)
                {
                    UsuariosBll.Modificar(usuario);
                    Utilidades.ShowToastr(this, "El Usuario", " Se Modifico Correctamente", "Success");
                }
                else
                {
                    usuario = Llenar();
                    UsuariosBll.Guardar(usuario);
                    Utilidades.ShowToastr(this, "El Usuario", " Se Guardo Correctamente", "Success");
                    Limpiar();

                }
            }
        }

        private Usuarios Llenar()
        {
            Usuarios usuario = new Usuarios();
            usuario.NombresUsuarios = NombreUsuarioTextBox.Text;
            usuario.Nombres = NombresTextBox.Text;
            usuario.Contrasena = ContraseñaTextBox.Text;
            usuario.Fecha = Convert.ToDateTime(FechaTextBox.Text);

            return usuario;
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(idUsuarioTextbox.Text);
            Usuarios usuario = UsuariosBll.Buscar(u => u.IdUsuarios == id);
            if (usuario != null)
            {
                if (usuario.IdUsuarios != 1)
                {
                    UsuariosBll.Eliminar(usuario);
                    Utilidades.ShowToastr(this, "El Usuario", " Se Elimino Correctamente", "Success");
                    Limpiar();
                }
                else
                {
                    Utilidades.ShowToastr(this, "El Usuario", "No Se Elimino", "warning");
                }
            }
        }
    }
}