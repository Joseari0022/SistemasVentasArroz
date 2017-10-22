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
        public SistemaVentasDb() : base("ConStr")
        {
                
        }

        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Facturas> Factura { get; set; }
        public DataTable O { get; set; }

        public DataTable ObtenerDatos(string v)
        {
            throw new NotImplementedException();
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Productos>()
        //        .HasMany(p => p.Factura)
        //        .WithMany(f => f.ProductoLis)
        //        .Map(empleadoRetencion =>
        //        {
        //            empleadoRetencion.MapLeftKey("FacturaId");
        //            empleadoRetencion.MapRightKey("ProductoId");
        //            empleadoRetencion.ToTable("FacturasProductos");
        //        });
        //}
    }
}
