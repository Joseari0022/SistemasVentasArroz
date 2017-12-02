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
        DataTable dt = new DataTable();
        Productos producto = new Productos();
        private static List<FacturasProductos> listaRelaciones;
        Facturas factura;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            this.FechaTextBox.Text = string.Format("{0:G}", DateTime.Now);
            ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
            myScriptResDef.Path = "~/Scripts/jquery-1.4.2.min.js";
            myScriptResDef.DebugPath = "~/Scripts/jquery-1.4.2.js";
            myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
            myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);

            if (!IsPostBack)
            {
                dt.Columns.AddRange(new DataColumn[] { new DataColumn("Id Producto"), new DataColumn("Descripcion"), new DataColumn("Precio"), new DataColumn("Cantidad") });
                ViewState["Detalle"] = dt;

                producto = new Productos();
                listaRelaciones = new List<FacturasProductos>();
                factura = new Facturas();
            }
            FechaTextBox.Enabled = false;
            ComboCliente();
        }

        public void llenarR(List<FacturasProductos> llenar)
        {
            foreach(var li in llenar)
            {
                dt = (DataTable)ViewState["Detalle"];
                    dt.Rows.Add(li.IdProductos, li.Descripcion, li.Cantidad, li.Precio);
                ViewState["Detalle"] = dt;
                this.BindGrid();
            }
        }

        protected void BindGrid()
        {
           
            FacturaGridView.DataSource = (DataTable)ViewState["Detalle"];
            FacturaGridView.DataBind();
            CalcularMonto();
        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            
            AgregarDataGrid();
        }

        private void AgregarDataGrid()
        {
            int id = Utilidades.ToInt(IdProductoTextBox.Text);
            producto = BLL.ProductosBll.Buscar(p => p.IdProductos == id);

            if (Utilidades.ToInt(CantidadTextBox.Text) > producto.Cantidad)
            {
                Utilidades.ShowToastr(this, "Cantidad execede existencia", "info");
            }
            else
            {
                bool agregado = false;

                foreach (GridViewRow pro in FacturaGridView.Rows)
                {
                    int prueba = Utilidades.ToInt(pro.Cells[0].Text);
                    if (producto.IdProductos == Utilidades.ToInt(pro.Cells[0].Text))
                    {
                        agregado = true;
                        break;
                    }
                }
                if (agregado)
                {

                    Utilidades.ShowToastr(this, "El Producto ya esta Agregado -Selecione otro", "Error", "info");

                }
                else
                {
                    DataTable dt = (DataTable)ViewState["Detalle"];
                    dt.Rows.Add(IdProductoTextBox.Text, DescripcionTextBox.Text, PrecioTextBox.Text, CantidadTextBox.Text);
                    ViewState["Detalle"] = dt;
                    this.BindGrid();
                }
            }
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
            Entidades.FacturasProductos detallef = new Entidades.FacturasProductos();
            Llenar(detallef);

            if (detallef.Detalle.Count == 0)
            {
                Utilidades.ShowToastr(this, "Agregue un Producto", "Consejo", "info");

            }
            else
            {
                if (FacturaBll.Guardar(factura, detallef.Detalle))
                {
                    Utilidades.ShowToastr(this, "Guardo", "Correcto", "success");
                }
                else
                {
                    Utilidades.ShowToastr(this, "Error", "Error", "error");

                }
            }
        }
        Facturas facturas = new Facturas();
        public void Llenar(FacturasProductos detalle)
        {
            
            foreach(GridViewRow dr in FacturaGridView.Rows)
            {
                detalle.AgregarDetalle(Utilidades.ToInt(dr.Cells[0].Text),
                    dr.Cells[1].Text, Convert.ToInt32(dr.Cells[2].Text), Convert.ToInt32(dr.Cells[3].Text));
            }
            
            facturas.TipoPago = TipoPagoDropDownList.SelectedValue.ToString();
            facturas.NombreCliente = ClienteDropDownList.SelectedValue.ToString();
            facturas.FechaCreacion = Convert.ToDateTime(FechaTextBox.Text);
            //facturas.SubTotal = SubTotalTextBox.ToString();
            facturas.Total = Convert.ToInt32(TotalTextBox.Text;
    
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
            ClienteDropDownList.DataValueField = "Nombres";
            ClienteDropDownList.DataValueField = "IdClientes";
            ClienteDropDownList.DataBind();
        }

        public void CalcularMonto()
        {
            decimal total = 0;
            decimal subTotal = 0m;
            decimal itbis = 0;
            decimal juan = 0;

            if (FacturaGridView.Rows.Count > 0)
            {
                foreach (GridViewRow precio in FacturaGridView.Rows)
                {
                    Math.Round(subTotal += Convert.ToDecimal(precio.Cells[2].Text));
                    Math.Round(juan += Convert.ToDecimal(precio.Cells[3].Text));
                    //Math.Round(itbis += (subTotal * ));
                    Math.Round(total += (subTotal * juan));

                    SubTotalTextBox.Text = subTotal.ToString();

                    TotalTextBox.Text = total.ToString();

                }
            }
        }

        private void Limpiar()
        {
            FacturaGridView.DataSource = null;
            FacturaGridView.DataBind();
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}