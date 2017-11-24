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
    public partial class ConsultaProductosWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FiltrarButton_Click(object sender, EventArgs e)
        {
            BuscarSelecCombo();
        }
        public List<Productos> Listas { get; set; }

        private void BuscarSelecCombo()
        {
            if (DropDownList.SelectedIndex == 0)
            {
                int Busqueda = Utilidades.ToInt(FlitrarTextbox.Text);
                Listas = ProductosBll.Listar((p => p.IdProductos == Busqueda));
                ConsultaproductoGridView.DataSource = Listas;
                ConsultaproductoGridView.DataBind();
            }
            else if (DropDownList.SelectedIndex == 1)
            {
                if (FlitrarTextbox.Text == "")
                {
                    base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
                }
                else
                {
                    Listas = ProductosBll.Listar((p => p.Descripcion == FlitrarTextbox.Text));
                    ConsultaproductoGridView.DataSource = Listas;
                    ConsultaproductoGridView.DataBind();
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
                    Listas = ProductosBll.Listar((p => p.Cantidad == Convert.ToInt32(FlitrarTextbox.Text)));
                    ConsultaproductoGridView.DataSource = Listas;
                    ConsultaproductoGridView.DataBind();
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
                    Listas = ProductosBll.Listar((p => p.Precio == Convert.ToInt32(FlitrarTextbox.Text)));
                    ConsultaproductoGridView.DataSource = Listas;
                    ConsultaproductoGridView.DataBind();
                }
            }
            else if (DropDownList.SelectedIndex == 4)
            {
                DateTime desde = DateTime.Now;
                DateTime hasta = DateTime.Now;

                Listas = ProductosBll.Listar(p => p.FechaCreacion >= desde.Date && p.FechaCreacion <= hasta.Date);

                ConsultaproductoGridView.DataSource = Listas;
                ConsultaproductoGridView.DataBind();
            }
            ConsultaproductoGridView.DataSource = Listas;
            ConsultaproductoGridView.DataBind();
        }
    }
}