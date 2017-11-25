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
        public string TipoPago { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaCreacion { get; set; }
        public float SubTotal { get; set; }
        public float Total { get; set; }

        public virtual List<Productos> producto { get; set; }
        public Facturas()
        {
            this.producto = new List<Productos>();
        }

        public Facturas(int idfactura, string tipopago, string nombrecliente)
        {
            this.IdFactura = idfactura;
            this.TipoPago = tipopago;
            this.NombreCliente = nombrecliente;
            this.producto = new List<Productos>();
        }
    }
}
