using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using BLL;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WebSistemaGonzalez.UI.Registros
{
    public partial class FacturasWebForm2aspx : System.Web.UI.Page
    {
        Productos producto = new Productos();
        Facturas factura = new Facturas();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            this.FechaTextBox.Text = string.Format("{0:G}", DateTime.Now);
            ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
            myScriptResDef.Path = "~/Scripts/jquery-1.4.2.min.js";
            myScriptResDef.DebugPath = "~/Scripts/jquery-1.4.2.js";
            myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
            myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);

            if (!IsPostBack)
            {
                dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Descripcion"), new DataColumn("Precio"), new DataColumn("Cantidad"), new DataColumn("Importe") });
                ViewState["DetalleFactura"] = dt;
            }
            FechaTextBox.Enabled = false;
            ComboCliente();
        }

        protected void BindGrid()
        {
            DataTable dt = new DataTable();
            //FacturaGridView.DataSource = (DataTable)ViewState["DetalleFactura"];
            //FacturaGridView.DataBind();
        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            AgregarDataGrid();
        }

        private void AgregarDataGrid()
        {
            DataTable dt = (DataTable)ViewState["DetalleFactura"];
            dt.Rows.Add(DescripcionTextBox.Text, PrecioTextBox.Text, CantidadTextBox.Text);
            ViewState["DetalleFactura"] = dt;
            this.BindGrid();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void BuscarProducto()
        {
            if (!string.IsNullOrEmpty(IdProductoTextBox.Text))
            {
                int id = Utilidades.ToInt(IdProductoTextBox.Text);
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
                    IdProductoTextBox.Text = "";
                    DescripcionTextBox.Text = "";
                    PrecioTextBox.Text = "";
                    CantidadTextBox.Text = "";
                }
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {

        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Facturas facturas = new Facturas();
            if (IsValid)
            {
                if (factura.IdFactura != 0)
                {
                    FacturaBll.Modificar(factura);
                    Utilidades.ShowToastr(this, "El Usuario", " Se Modifico Correctamente", "Success");
                }
                else
                {
                    factura = Llenar();
                    FacturaBll.Guardar(factura);
                    Utilidades.ShowToastr(this, "El Usuario", " Se Guardo Correctamente", "Success");
                    //Limpiar();

                }
            }

        }

        private Facturas Llenar()
        {
            factura.TipoPago = TipoPagoDropDownList.SelectedValue.ToString();
            factura.NombreCliente = ClienteDropDownList.SelectedValue.ToString();
            factura.FechaCreacion = Convert.ToDateTime(FechaTextBox.Text);
            factura.SubTotal = Convert.ToInt32(SubTotalTextBox.Text);
            factura.Total = Convert.ToInt32(TotalTextBox.Text);
            return factura;
        }




        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(IdFacturaTextBox.Text);
            Facturas factura = FacturaBll.Buscar(u => u.IdFactura == id);
            if (factura != null)
            {
                ClienteDropDownList.SelectedValue = factura.NombreCliente;
                TipoPagoDropDownList.SelectedValue = factura.TipoPago;
                FechaTextBox.Text = factura.FechaCreacion.ToString();
                SubTotalTextBox.Text = Convert.ToString(factura.SubTotal);
                TotalTextBox.Text = Convert.ToString(factura.Total);
                Utilidades.ShowToastr(this, "Si Existe", "Factura Encontrado", "Success");
            }
            else
            {
                Utilidades.ShowToastr(this, "No Existe", "Ingresar Factura Existente", "warning");
            }
        }

        public void ComboCliente()
        {
            List<Clientes> lista = ClientesBll.ListarTodo();
            ClienteDropDownList.DataSource = lista;
            ClienteDropDownList.DataTextField = "Nombres";
            ClienteDropDownList.DataValueField = "IdClientes";
            ClienteDropDownList.DataBind();
        }
    }
}