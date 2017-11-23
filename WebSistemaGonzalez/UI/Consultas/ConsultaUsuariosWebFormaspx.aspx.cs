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
        public List<Usuarios> Listas { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //ConsultaUsuarioGridView.DataSource = UsuariosBll.ListarTodo();
            //ConsultaUsuarioGridView.DataBind();
            if (IsPostBack)
            {
                Listas = UsuariosBll.ListarTodo();
                ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
                myScriptResDef.Path = "~/Scripts/jquery-1.4.2.min.js";
                myScriptResDef.DebugPath = "~/Scripts/jquery-1.4.2.js";
                myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
                myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
                ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);

            }
            
        }

        public void SeleccionarCombo()
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                Listas = null;
            }
            else if (DropDownList1.SelectedIndex == 1)
            {
                if (FlitrarTextbox.Text == "")
                {
                    Utilidades.ShowToastr(this, "Debes Insertar Id", "error", "error");
                    Listas = null;
                }
                else
                {
                    int id = Convert.ToInt32(FlitrarTextbox.Text);
                    Listas = UsuariosBll.Listar(p => p.IdUsuarios == id);
                    
                }


            }
            else if (DropDownList1.SelectedIndex == 2)
            {
                if (FlitrarTextbox.Text == "")
                {
                    Utilidades.ShowToastr(this, "Debes Insertar Nombre", "error", "error");
                    Listas = null;
                }
                else
                {
                    Listas = UsuariosBll.Listar(p => p.Nombres == FlitrarTextbox.Text);
                    
                }


            }
            else if (DropDownList1.SelectedIndex == 3)
            {
                FlitrarTextbox.Text = "";

                if (DesdeTextBox.Text != "" && HastaTextBox.Text != "")
                {
                    DateTime desde = Convert.ToDateTime(DesdeTextBox.Text);
                    DateTime hasta = Convert.ToDateTime(DesdeTextBox.Text);
                    if (desde <= hasta)
                    {
                        Listas = UsuariosBll.Listar(p => p.Fecha >= desde && p.Fecha <= hasta);
                        
                    }
                    else
                    {
                        Utilidades.ShowToastr(this, "La Primera Fecha debe ser Menor que la Segunda Fecha", "error", "error");
                        Listas = null;
                    }
                }
                else
                {
                    Utilidades.ShowToastr(this, "Debes Insertar las Fechas", "error", "error");
                    Listas = null;
                }



            }
            else if (DropDownList1.SelectedIndex == 4)
            {

                Listas = UsuariosBll.ListarTodo();
                

            }
            ConsultaUsuarioGridView.DataSource = Listas;
            ConsultaUsuarioGridView.DataBind();
        }

        protected void FiltrarButton_Click(object sender, EventArgs e)
        {
            SeleccionarCombo();
        }
    }
}