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

        public Productos()
        {

        }

    }
}
