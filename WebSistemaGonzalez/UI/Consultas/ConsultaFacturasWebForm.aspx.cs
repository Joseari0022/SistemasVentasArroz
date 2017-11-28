using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using BLL;

namespace WebSistemaGonzalez.UI.Consultas
{
    public partial class ConsultaFacturasWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FiltrarButton_Click(object sender, EventArgs e)
        {
            BuscarSelecCombo();
        }

         public static List<Facturas> Listas { get; set; }

        private void BuscarSelecCombo()
        {
            if (DropDownList.SelectedIndex == 0)
            {
                int Busqueda = Utilidades.ToInt(FlitrarTextbox.Text);
                Listas = FacturaBll.Listar((p => p.IdFactura == Busqueda));
                ConsultaFacturaGridView.DataSource = Listas;
                ConsultaFacturaGridView.DataBind();
            }
            else if (DropDownList.SelectedIndex == 1)
            {
                if (FlitrarTextbox.Text == "")
                {
                    base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
                }
                else
                {
                    Listas = FacturaBll.Listar((p => p.TipoPago == FlitrarTextbox.Text));
                    ConsultaFacturaGridView.DataSource = Listas;
                    ConsultaFacturaGridView.DataBind();
                }
            }
            else if (DropDownList.SelectedIndex == 2)
            {
                if (FlitrarTextbox.Text == "")
                {
                    base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar el Monto');</script>");
                }
                else
                {
                    Listas = FacturaBll.Listar((p => p.NombreCliente == FlitrarTextbox.Text));
                    ConsultaFacturaGridView.DataSource = Listas;
                    ConsultaFacturaGridView.DataBind();
                }
            }
            else if (DropDownList.SelectedIndex == 3)
            {
                if (FlitrarTextbox.Text == "")
                {
                    base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar el Monto');</script>");
                }
                else
                {
                    //Listas = ProductosBll.Listar((p => p.Precio == Convert.ToInt32(FlitrarTextbox.Text)));
                    ConsultaFacturaGridView.DataSource = Listas;
                    ConsultaFacturaGridView.DataBind();
                }
            }
            else if (DropDownList.SelectedIndex == 4)
            {
                DateTime desde = DateTime.Now;
                DateTime hasta = DateTime.Now;

                //Listas = ProductosBll.Listar(p => p.FechaCreacion >= desde.Date && p.FechaCreacion <= hasta.Date);

                ConsultaFacturaGridView.DataSource = Listas;
                ConsultaFacturaGridView.DataBind();
            }
            ConsultaFacturaGridView.DataSource = Listas;
            ConsultaFacturaGridView.DataBind();
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Reportes/ReportesFacturasWebForm.aspx");
        }
    }
}