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
    public partial class ConsultaClientesWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static List<Clientes> Listas { get; set; }

        private void BuscarSelecCombo()
        {
            if (DropDownList.SelectedIndex == 0)
            { 
                    int Busqueda = Utilidades.ToInt(FlitrarTextbox.Text);
                    Listas = ClientesBll.Listar(p => p.IdClientes == Busqueda);
                    Utilidades.ShowToastr(this, "Si Existe", "Cliente Encontrado", "Success");
                    ConsultaUsuarioGridView.DataSource = Listas;
                    ConsultaUsuarioGridView.DataBind();
                    
            }
            else if (DropDownList.SelectedIndex == 1)
            {
                if (FlitrarTextbox.Text == "")
                {
                    Utilidades.ShowToastr(this, "Error", "Ingresar Nombre Cliente", "warning");
                }
                else
                {
                    Listas = ClientesBll.Listar(p => p.Nombres == FlitrarTextbox.Text);
                    Utilidades.ShowToastr(this, "Si Existe", "Cliente Encontrado", "Success");
                    ConsultaUsuarioGridView.DataSource = Listas;
                    ConsultaUsuarioGridView.DataBind();
                }
            }
            else if (DropDownList.SelectedIndex == 2)
            {
                DateTime desde = DateTime.Now;
                DateTime hasta = DateTime.Now;

                Listas = ClientesBll.Listar(p => p.FechaNacimiento >= desde.Date && p.FechaNacimiento <= hasta.Date);

                ConsultaUsuarioGridView.DataSource = Listas;
                ConsultaUsuarioGridView.DataBind();
            }
            else if (DropDownList.SelectedIndex == 3)
            {
                if (FlitrarTextbox.Text == "")
                {
                    Utilidades.ShowToastr(this, "Error", "Ingresar Nombre Cliente", "warning");
                }
                else
                {
                    Listas = ClientesBll.Listar(p => p.Cedula == FlitrarTextbox.Text);
                    Utilidades.ShowToastr(this, "Si Existe", "Cedula Encontrado", "Success");
                    ConsultaUsuarioGridView.DataSource = Listas;
                    ConsultaUsuarioGridView.DataBind();
                }
            }
            else if (DropDownList.SelectedIndex == 4)
            {
                if (FlitrarTextbox.Text == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar el Monto');</script>");
                }
                else
                {
                    Listas = ClientesBll.Listar(p => p.Direccion == FlitrarTextbox.Text);
                    Utilidades.ShowToastr(this, "Si Existe", "Direccion Encontrado", "Success");
                    ConsultaUsuarioGridView.DataSource = Listas;
                    ConsultaUsuarioGridView.DataBind();
                }
            }
            else if (DropDownList.SelectedIndex == 5)
            {
                if (FlitrarTextbox.Text == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar el Monto');</script>");
                }
                else
                {
                    Listas = ClientesBll.Listar(p => p.Telefono == FlitrarTextbox.Text);
                    Utilidades.ShowToastr(this, "Si Existe", "Telefono Encontrado", "Success");
                    ConsultaUsuarioGridView.DataSource = Listas;
                    ConsultaUsuarioGridView.DataBind();
                }
            }
            else if (DropDownList.SelectedIndex == 6)
            {
                DateTime desde = DateTime.Now;
                DateTime hasta = DateTime.Now;

                Listas = ClientesBll.Listar(p => p.FechaCreacion >= desde.Date && p.FechaCreacion <= hasta.Date);

                ConsultaUsuarioGridView.DataSource = Listas;
                ConsultaUsuarioGridView.DataBind();
            }
            ConsultaUsuarioGridView.DataSource = Listas;
            ConsultaUsuarioGridView.DataBind();
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Reportes/ReportesClientesWebForm.aspx");
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            BuscarSelecCombo();
        }
    }
}