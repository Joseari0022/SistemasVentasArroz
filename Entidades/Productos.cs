using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        [Key]
        public int IdProductos { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public DateTime FechaCreacion { get; set; }

        //public List<Facturas> Detalle;
        //public void AgregarProductos(string Descripcion, decimal Cantidad, decimal Precio)
        //{
        //    this.Detalle.Add(new Facturas(Descripcion, Cantidad, Precio));
        //}

        public virtual List<Facturas> Factura { get; set;}
        public Productos()
        {
            this.Factura = new List<Facturas>();
        }

        public Productos(int idproductos, string descripcion, int cantidad, int precio)
        {
            this.IdProductos = idproductos;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Factura = new List<Facturas>();
        }
    }

    
}
