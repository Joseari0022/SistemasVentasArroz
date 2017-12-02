using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FacturasProductos
    {
        [Key]
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public int IdProductos { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        

        public Productos productos { get; set; }

        public List<FacturasProductos> Detalle;
        public static List<FacturasProductos> impresion;

        public FacturasProductos()
        {
            Detalle = new List<FacturasProductos>();
            impresion = new List<FacturasProductos>();
        }

        public void AgregarDetalle(int productoId, string descripcion, int precio, int cantidad)
        {
            this.Detalle.Add(new FacturasProductos(productoId, descripcion, precio, cantidad));

            impresion = Detalle;
        }

        public FacturasProductos(int productoId, string descripcion, int precio, int cantidad)
        {
            this.IdProductos = productoId;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Cantidad = cantidad;
            Detalle = new List<FacturasProductos>();
            impresion = new List<FacturasProductos>();
        }
    }
}
