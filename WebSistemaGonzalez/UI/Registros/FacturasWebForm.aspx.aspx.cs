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
        }

        protected void BindGrid()
        {
            DataTable dt = new DataTable();
            FacturaGridView.DataSource = (DataTable)ViewState["DetalleFactura"];
            FacturaGridView.DataBind();
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

            //factura.producto.Add(new Productos(Convert.ToInt32(IdProductoTextBox.Text), DescripcionTextBox.Text, Convert.ToInt32(CantidadTextBox.Text), Convert.ToInt32(PrecioTextBox.Text)));
            //FacturaGridView.DataSource = null;
            //FacturaGridView.DataSource = factura.producto;
            //FacturaGridView.DataBind();
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

         void FacturaGridView_SelectedIndexChanged(Object sender, GridViewDeleteEventArgs e)
        {
            
        }

        protected void FacturaGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int str_mivariable;
            str_mivariable = FacturaGridView.Rows.Count;

            foreach (DataRow dr_Fila in FacturaGridView.Rows)
            {
                
                    dr_Fila.Delete();
                    FacturaGridView.DataSource = FacturaGridView;
                    FacturaGridView.DataBind();
                    break;
                
            }
        }

        protected void FacturaGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //TableCell cell = FacturaGridView.Rows[e.RowIndex].Cells[0];
            //if (cell.Text == "Beaver")
            //{
            //    e.Cancel = true;
            //    //Message.Text = "You cannot delete customer Beaver.";
            //}
            //else
            //{

            //}
            
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            
        }
       
        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            
            
            Llenar(factura);
            FacturaBll.Guardar(factura);
            // Utilidades.ShowToastr(this, "El Usuario", " Se Guardo Correctamente", "Success");

                
            
        }

        private Facturas Llenar(Facturas factura)
        {
            Productos p = new Productos();

          
            //factura.FechaCreacion = Convert.ToDateTime(FechaTextBox.Text);
            factura.NombreCliente = NombreClienteTextBox.Text;
            //foreach (GridViewRow dr in FacturaGridView.Rows)
            //{
            //    p.Descripcion = dr.Cells[0].Text;
            //    p.Cantidad = Convert.ToInt32(dr.Cells[1].Text);
            //    p.Precio = Convert.ToInt32(dr.Cells[2].Text);
            //}

            return factura;
        }

        
        //private void Detalle()
        //{
        //    using (SqlConnection conn = new SqlConnection("<connection string>"))
        //    {
        //        conn.Open();

        //        string query = "INSERT INTO Factura (Descripcion) VALUES (@param1)";
        //        SqlCommand cmd = new SqlCommand(query, conn);


        //        foreach (GridViewRow row in FacturaGridView.Rows)
        //        {
        //            cmd.Parameters.Clear();

        //            cmd.Parameters.AddWithValue("@param1", Convert.ToString(row.Cells[0].Text));

        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(IdFacturaTextBox.Text);
            //factura = FacturaBll.Buscar(id);

            if (factura != null)
            {

                //PagoTextBox.Text = facturar.formaPago;
                //DescuentoTextBox.Text = Convert.ToString(facturar.descuento);
                //ItbisTextBox.Text = Convert.ToString(facturar.itbis);
                //ComentarioTextBox.Text = Convert.ToString(facturar.comentario);
                //SubTextBox.Text = Convert.ToString(facturar.subTotal);
                //TotalTextBox.Text = Convert.ToString(facturar.total);
                //LogIn.LabelUsuario().nombres = facturar.usuario;
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "scripts", "<script>alert('No existe');</script>");
               // Limpiar();
            }
        }
    }
}