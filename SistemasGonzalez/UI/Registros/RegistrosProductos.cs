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
    public partial class RegistrosProductos : Form
    {
        public RegistrosProductos()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(IdtextBox.Text);
            Productos producto = ProductosBll.Buscar(p => p.IdProductos == id);
            if(producto != null)
            {
                DescripciontextBox.Text = producto.Descripcion;
                CantidadtextBox.Text = producto.Cantidad.ToString();
                PreciotextBox.Text = producto.Precio.ToString();
                FechaCreaciondateTimePicker.Value = producto.FechaCreacion;
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
            IdtextBox.Clear();
            DescripciontextBox.Clear();
            CantidadtextBox.Clear();
            PreciotextBox.Clear();
            FechaCreaciondateTimePicker.Value = DateTime.Today;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Productos producto = null;
            if(!Validar())
            {
                MessageBox.Show("Llenar campos por favor");
            }
            else 
            {
                producto = Llenar();
                ProductosBll.Guardar(producto);
                MessageBox.Show("Producto guardado!!!");
                Limpiar();
            }
        }

        private Productos Llenar()
        {
            Productos producto = new Productos();
            producto.Descripcion = DescripciontextBox.Text;
            producto.Cantidad = Convert.ToInt32(CantidadtextBox.Text);
            producto.Precio = Convert.ToInt32(PreciotextBox.Text);
            producto.FechaCreacion = FechaCreaciondateTimePicker.Value;

            return producto;
        }

        private bool Validar()
        {
            bool cambio = true;
            if ((string.IsNullOrEmpty(DescripciontextBox.Text)) || (string.IsNullOrEmpty(CantidadtextBox.Text)) || (string.IsNullOrEmpty(PreciotextBox.Text)))
            {
                ProductoserrorProvider.SetError(DescripciontextBox, "Ingrese la descripcion del producto");
                ProductoserrorProvider.SetError(CantidadtextBox, "Ingrese la cantidad");
                ProductoserrorProvider.SetError(PreciotextBox, "Ingrese el precio");
                cambio = false;
            }
            return cambio;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(IdtextBox.Text);
            Productos producto = ProductosBll.Buscar(p => p.IdProductos == id);
            if (producto != null)
            {
                if (ProductosBll.Eliminar(producto))
                    MessageBox.Show("Producto eliminado!!!");
                else
                    MessageBox.Show("Producto no eliminado!!!");
            }
            else
                MessageBox.Show("Producto no existente!!!");
            Limpiar();
        }
    }
}
