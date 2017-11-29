using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Entidades;

namespace WebSistemaGonzalez.UI.Consultas
{
    public partial class ConsultaUsuariosWebFormaspx : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public static List<Usuarios> Listas { get; set; }

        private void BuscarSelecCombo()
        {
            if (DropDownList.SelectedIndex == 0)
            {
                int Busqueda = Utilidades.ToInt(FlitrarTextbox.Text);
                Listas = UsuariosBll.Listar(p => p.IdUsuarios == Busqueda);
                ConsultaUsuarioGridView.DataSource = Listas;
                ConsultaUsuarioGridView.DataBind();
            }
            else if (DropDownList.SelectedIndex == 1)
            {
                if (FlitrarTextbox.Text == "")
                {
                    //Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
                }
                else
                {
                    Listas = UsuariosBll.Listar(p => p.NombresUsuarios == FlitrarTextbox.Text);
                    ConsultaUsuarioGridView.DataSource = Listas;
                    ConsultaUsuarioGridView.DataBind();
                }
            }
            else if (DropDownList.SelectedIndex == 2)
            {
                if (FlitrarTextbox.Text == "")
                {
                    //Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar el Monto');</script>");
                }
                else
                {
                    Listas = UsuariosBll.Listar(p => p.Nombres == FlitrarTextbox.Text);
                    ConsultaUsuarioGridView.DataSource = Listas;
                    ConsultaUsuarioGridView.DataBind();
                }
            }
            ConsultaUsuarioGridView.DataSource = Listas;
            ConsultaUsuarioGridView.DataBind();
        }

        protected void FiltrarButton_Click(object sender, EventArgs e)
        {
            
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            BuscarSelecCombo();
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Reportes/ReportesUsuariosWebForm.aspx");
        }
    }
}