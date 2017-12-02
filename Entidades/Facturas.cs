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
        public int SubTotal { get; set; }
        public int Total { get; set; }

        public List<Productos> Detalle;
        public virtual ICollection<FacturasProductos> Relacion { get; set; }
        public Facturas()
        {
            this.Relacion = new HashSet<FacturasProductos>();
        }

        public Facturas(DateTime fecha, int subtotal, int total,  string nombrecliente, int idfactura, string tipopago)
        {
            this.FechaCreacion = fecha;
            this.SubTotal = subtotal;
            this.Total = total;
            this.NombreCliente = nombrecliente;
            this.IdFactura = idfactura;
            this.TipoPago = tipopago; 
        }
    }
}
