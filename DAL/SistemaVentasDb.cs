using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;

namespace DAL
{
    public class SistemaVentasDb : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<FacturasProductos> FacturasProductos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Facturas> Factura { get; set; }

        public SistemaVentasDb() : base("ConStr")
        {
                
        }

       
    }
}
