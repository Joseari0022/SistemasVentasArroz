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

        public static  bool Guardar(Entidades.Facturas Facturag, List<Entidades.FacturasProductos> listaRelaciones)
        {
            using (var repositorio = new Repositorio<Facturas>())
            {
                bool FacuraGuardada;
                bool relacionesGuardadas = false;
                if (Buscar(P => P.IdFactura == Facturag.IdFactura) == null)
                {
                    FacuraGuardada = repositorio.Guardar(Facturag);
                }
                else
                {
                    FacuraGuardada = repositorio.Modificar(Facturag);
                }
                if (FacuraGuardada)
                {
                    relacionesGuardadas = true;
                    if (listaRelaciones != null)
                    {

                        foreach (var relacion in listaRelaciones)
                        {
                            relacion.IdFactura = Facturag.IdFactura;
                            if (!BLL.FacturasProductosBLL.Guardar(relacion))
                            {
                                relacionesGuardadas = false;

                            }
                        }
                    }

                }
                return relacionesGuardadas;
            }
        }

        //public static bool Guardar(Facturas facturas)
        //{
        //    using (var context = new Repositorio<Facturas>())
        //    {
        //        try
        //        {
        //            if (Buscar(p => p.IdFactura == facturas.IdFactura) == null)
        //            {
        //                return context.Guardar(facturas);
        //            }
        //            else
        //            {
        //                return context.Modificar(facturas);
        //            }
        //        }
        //        catch (Exception)
        //        {

        //            throw;
        //        }
        //    }
        //}

        //public static bool Guardar(Facturas gr)
        //{
        //    bool re = false;
        //    try
        //    {
        //        var db = new SistemaVentasDb();

        //        db.Factura.Add(gr);
        //        var gp = db.Factura.Add(gr);
        //        foreach (var estud in gr.producto)
        //        {
        //            db.Entry(estud).State = EntityState.Unchanged;
        //        }
        //        db.SaveChanges();
        //        db.Dispose();
        //        re = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return re;
        //}

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
