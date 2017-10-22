using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace SistemasGonzalez.UI.Registros
{
    public partial class RegistrosFactura : Form
    {  
        public RegistrosFactura()
        {
            InitializeComponent();
            LlenarPago();
        }

        Productos producto = null;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            FacturaerrorProvider.Clear();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(IdtextBox.Text);
            Facturas factura = FacturaBll.Buscar(f => f.IdFactura == id);
            if(factura != null)
            {
                TipoPagocomboBox.Text = factura.TipoPago;
                NombretextBox.Text = factura.NombreCliente;
                DirecciontextBox.Text = factura.Direccion;
                TelefonotextBox.Text = factura.Telefono.ToString();
                TotaltextBox.Text = factura.Total.ToString();
            }
            else
            {
                MessageBox.Show("No exite!!!"); 
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            IdClientetextBox.Clear();
            NombretextBox.Clear();
            DirecciontextBox.Clear();
            TelefonotextBox.Clear();
            TelefonotextBox.Clear();
            FacturadataGridView.DataSource = null;
            TotaltextBox.Clear();
            FechaCreaciondateTimePicker.Value = DateTime.Now;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Facturas factura = null;
            factura = Llenar();
            FacturaBll.Guardar(factura);
            MessageBox.Show("Factura guardada!!!");
            Limpiar();
        }

        private bool Validar()
        {
            bool cambio = true;
            if((string.IsNullOrEmpty(NombretextBox.Text)) || (string.IsNullOrEmpty(ProductoIdtextBox.Text)) || (string.IsNullOrEmpty(DescripciontextBox.Text)) || (FacturadataGridView.DataSource == null))
            {
                FacturaerrorProvider.SetError(NombretextBox, "Elegir cliente");
                FacturaerrorProvider.SetError(ProductoIdtextBox, "Elegir producto");
                FacturaerrorProvider.SetError(FacturadataGridView, "Agregar datos");
                return false;
            }
            return cambio;
        }


        private Facturas Llenar()
        {
            Facturas factura = new Facturas();
            factura.FechaCreacion = FechaCreaciondateTimePicker.Value;
            factura.NombreCliente = NombretextBox.Text;
            factura.Direccion = DirecciontextBox.Text;
            factura.Telefono = Utilidades.ToInt(TelefonotextBox.Text);
            factura.TipoPago = TipoPagocomboBox.Text;
            factura.Total = Utilidades.ToInt(TotaltextBox.Text);
            if (TipoPagocomboBox.SelectedIndex == 0)
                factura.TipoPago = "Credito";
            else
                factura.TipoPago = "Contado";

            return factura;
        }

       

        private void LlenarPago()
        {
            TipoPagocomboBox.Items.Insert(0, "Credito");
            TipoPagocomboBox.Items.Insert(1, "Contado");
            TipoPagocomboBox.DataSource = TipoPagocomboBox.Items;
            TipoPagocomboBox.DisplayMember = "Credito";
        }

        private void BuscarProducto()
        {
            if(!string.IsNullOrEmpty(ProductoIdtextBox.Text))
            {
                int id = Utilidades.ToInt(ProductoIdtextBox.Text);
                producto = ProductosBll.Buscar(p => p.IdProductos == id);
                if(producto != null)
                {
                    DescripciontextBox.Text = producto.Descripcion;
                    PreciotextBox.Text = producto.Precio.ToString();
                    CantidadnumericUpDown.Enabled = true;
                    CantidadnumericUpDown.Focus();
                }
                else
                {
                    ProductoIdtextBox.Clear();
                    FacturaerrorProvider.SetError(ProductoIdtextBox, "Producto no exite!!!");
                    DescripciontextBox.Clear();
                    PreciotextBox.Clear();
                    CantidadnumericUpDown.Enabled = false;
                }
            }
        }

        private void BuscarCliente()
        {
            if(!string.IsNullOrEmpty(IdClientetextBox.Text))
            {
                int id = Utilidades.ToInt(IdClientetextBox.Text);
                Clientes cliente = ClientesBll.Buscar(c => c.IdClientes == id);
                if(cliente != null)
                {
                    NombretextBox.Text = cliente.Nombres;
                    DirecciontextBox.Text = cliente.Direccion;
                    TelefonotextBox.Text = cliente.Telefono;
                }
                else
                {
                    IdClientetextBox.Clear();
                    FacturaerrorProvider.SetError(IdClientetextBox, "Cliente no exite!!");
                    NombretextBox.Clear();
                    DirecciontextBox.Clear();
                    TelefonotextBox.Clear();
                }
            }
        }
        private void ProductoIdtextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ProductoIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                BuscarProducto();
            }
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)FacturadataGridView.Rows[0].Clone();
            row.Cells[0].Value = producto.Descripcion;
            row.Cells[2].Value = CantidadnumericUpDown.Value;
            row.Cells[1].Value = producto.Precio;
            row.Cells[3].Value = Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[1].Value);
            FacturadataGridView.Rows.Add(row);
            CalcularTotal();
            ProductoIdtextBox.Clear();
            DescripciontextBox.Clear();
            PreciotextBox.Clear();
            CantidadnumericUpDown.Text = "0";
            CantidadnumericUpDown.Enabled = false; 
        }
 
        private void CalcularTotal()
        {
            double total = 0;
            foreach (DataGridViewRow rows in FacturadataGridView.Rows)
            {
                total += Convert.ToDouble(rows.Cells[3].Value);
            }
            TotaltextBox.Text = Convert.ToString(total);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            //Facturas factura = null;
            int id = Utilidades.ToInt(IdtextBox.Text);
            Facturas factura = FacturaBll.Buscar(f => f.IdFactura == id);
            if (factura != null)
            {
                if (FacturaBll.Eliminar(factura))
                    MessageBox.Show("Factura eliminada!!!");
                else
                    MessageBox.Show("Factura no eliminado!!!");
            }
            else
                MessageBox.Show("Factura no existente!!!");
            Limpiar();
        }

        private void EliminarDatabutton_Click(object sender, EventArgs e)
        {
            
            if(FacturadataGridView.DataSource != null)
            {
                MessageBox.Show("Por favor selecciona una fila a eliminar");
            }
            else
            {
                FacturadataGridView.Rows.RemoveAt(FacturadataGridView.CurrentRow.Index);
            }
        }

        private void IdClientetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                BuscarCliente();
            }
        }

        private void RegistrosFactura_Load(object sender, EventArgs e)
        {
            CantidadnumericUpDown.Enabled = false;
        }
    }
}
