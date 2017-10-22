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
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
       public DateTime FechaCreacion { get; set; }
        

        public Productos()
        {

        }

        public Productos(int idproducto, string descripcion, decimal cantidad, decimal precio, DateTime fechacreacion)
        {
            this.IdProductos = idproducto;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.FechaCreacion = fechacreacion;
        }
    }
}
