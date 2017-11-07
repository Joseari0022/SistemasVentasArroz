using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using System.Linq.Expressions;

namespace BLL
{
    public class ProductosBll
    {
        public static bool Guardar(Productos producto)
        {
            using (var reposi = new Repositorio<Productos>())
            {
                try
                {
                    if (Buscar(p => p.IdProductos == producto.IdProductos) == null)
                    {
                        return reposi.Guardar(producto);
                    }
                    else
                    {
                        return reposi.Modificar(producto);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static bool Modificar(Productos producto)
        {
            bool modifica = false;
            using (var reposi = new Repositorio<Productos>())
            {
                modifica = reposi.Modificar(producto);
            }

            return modifica;
        }

        public static bool Eliminar(Productos producto)
        {
            bool eliminado = false;
            using (var reposi = new Repositorio<Productos>())
            {
                eliminado = reposi.Eliminar(producto);
            }
            return eliminado;
        }

        public static Productos Buscar(Expression<Func<Entidades.Productos, bool>> Busqueda)
        {
            Productos Result = null;
            using (var repoitorio = new Repositorio<Productos>())
            {
                Result = repoitorio.Buscar(Busqueda);
            }
            return Result;
        }

        public static List<Productos> Listar(Expression<Func<Productos, bool>> busqueda)
        {
            List<Productos> Result = null;
            using (var repoitorio = new Repositorio<Productos>())
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

        public static List<Productos> ListarTodo()
        {
            List<Productos> Result = null;
            using (var repoitorio = new Repositorio<Productos>())
            {
                try
                {
                    Result = repoitorio.ListaGet().ToList();
                }
                catch { }
                return Result;
            }
        }

        public static Productos BuscarRelacion(int id)
        {
            Productos estudiante = null;
            using (var conexion = new SistemaVentasDb())
            {
                try
                {
                    estudiante = conexion.Productos.Find(id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return estudiante;
        }
    }
}
