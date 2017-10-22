using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Facturas
    {
        [Key]
        public int IdFactura { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string TipoPago { get; set; }
        public string NombreCliente { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public decimal Total { get; set; }

       

        public Facturas()
        {
            
        }

        
    }
}
