using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
using System.Linq.Expressions;

namespace BLL
{
    public class FacturaBll
    {
        public static bool Guardar(Facturas factura)
        {
            using (var reposi = new Repositorio<Facturas>())
            {
                try
                {
                    if (Buscar(f => f.IdFactura == factura.IdFactura) == null)
                    {
                        return reposi.Guardar(factura);
                    }
                    else
                    {
                        return reposi.Modificar(factura);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

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

        public static Facturas Buscar(Expression<Func<Facturas, bool>> Busqueda)
        {
            Facturas Result = null;
            using (var repoitorio = new Repositorio<Facturas>())
            {
                Result = repoitorio.Buscar(Busqueda);
            }
            return Result;
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
