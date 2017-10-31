using System;
using System.Data;
using BLL;
using Entidades;
using System.Web;
namespace WebSistemaGonzalez.UI.Registros
{
    public partial class FacturaWebForm : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Descripcion"), new DataColumn("Precio"), new DataColumn("Cantidad"), new DataColumn("Importe") });
                ViewState["DetalleFactura"] = dt;
            }
        }

        Productos producto = null;

        protected void BindGrid()
        {
            GridView1.DataSource = (DataTable)ViewState["DetalleFactura"];
            GridView1.DataBind();
        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            AgregarDataGrid();
        }
        
        protected void IdTextBox_TextChanged(object sender, EventArgs e)
        {
                BuscarProducto();    
        }

        private void BuscarProducto()
        {
            if (!string.IsNullOrEmpty(IdTextBox.Text))
            {
                int id = Utilidades.ToInt(IdTextBox.Text);
                producto = ProductosBll.Buscar(p => p.IdProductos == id);
                if (producto != null)
                {
                    DescripcionTextBox.Text = producto.Descripcion;
                    PrecioTextBox.Text = producto.Precio.ToString();
                    CantidadTextBox.Enabled = true;
                    CantidadTextBox.Focus();
                }
                else
                {
                    IdTextBox.Text = "";
                    DescripcionTextBox.Text = "";
                    PrecioTextBox.Text = "";
                    CantidadTextBox.Text = "";
                }
            }
        }

        private void AgregarDataGrid()
        {
            DataTable dt = (DataTable)ViewState["DetalleFactura"];
            dt.Rows.Add(DescripcionTextBox.Text, PrecioTextBox.Text, CantidadTextBox.Text);
            ViewState["DetalleFactura"] = dt;
            this.BindGrid();
        }
    }
}