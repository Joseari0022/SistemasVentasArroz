using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
using System.Linq.Expressions;
using System.Data.Entity;

namespace BLL
{
    public class FacturaBll
    {
        //public static bool Guardar(Facturas factura)
        //{
        //    using (var reposi = new Repositorio<Facturas>())
        //    {
        //        try
        //        {
        //            if (Buscar(f => f.IdFactura == factura.IdFactura) == null)
        //            {
        //                return reposi.Guardar(factura);
        //            }
        //            else
        //            {
        //                return reposi.Modificar(factura);
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //    }
        //}

        public static bool Guardar(Facturas gr)
        {
            bool re = false;
            try
            {
                var db = new SistemaVentasDb();

                db.Factura.Add(gr);
                var gp = db.Factura.Add(gr);
                foreach (var estud in gr.producto)
                {
                    db.Entry(estud).State = EntityState.Unchanged;
                }
                db.SaveChanges();
                db.Dispose();
                re = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return re;
        }

        //public static void Insertar(Facturas f)
        //{
        //    try
        //    {
        //        SistemaVentasDb db = new SistemaVentasDb();
        //        db.Factura.Add(f);
        //        db.SaveChanges();
        //        db.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public static bool Modificar(Facturas factura)
        {
            bool modifica = false;
            using (var reposi = new Repositorio<Facturas>())
            {
                modifica = reposi.Modificar(factura);
            }

            return modifica;
        }

        public static bool Eliminar(Facturas factura)
        {
            bool eliminado = false;
            using (var reposi = new Repositorio<Facturas>())
            {
                eliminado = reposi.Eliminar(factura);
            }
            return eliminado;
        }

        public static Facturas Buscar(Expression<Func<Facturas, bool>> criterioBusqueda)
        {

            using (var repositorio = new DAL.Repositorio<Facturas>())
            {
                return repositorio.Buscar(criterioBusqueda);
            }
        }

        public static List<Facturas> Listar(Expression<Func<Facturas, bool>> busqueda)
        {
            List<Facturas> Result = null;
            using (var repoitorio = new Repositorio<Facturas>())
            {
                try
                {
                    Result = repoitorio.Lista(busqueda).ToList();
                }
                catch
                {

                }
                return Result;
            }
        }

        public static List<Entidades.Facturas> ListarTodo()
        {
            List<Entidades.Facturas> Result = null;
            using (var repoitorio = new Repositorio<Entidades.Facturas>())
            {
                try
                {
                    Result = repoitorio.ListaGet().ToList();
                }
                catch { }
                return Result;
            }
        }
    }
}
