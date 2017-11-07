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
    public class ClientesBll
    {
        public static bool Guardar(Clientes cliente)
        {
            using (var reposi = new Repositorio<Clientes>())
            {
                try
                {
                    if (Buscar(c => c.IdClientes == cliente.IdClientes) == null)
                    {
                         return reposi.Guardar(cliente);
                    }
                    else
                    {
                        return reposi.Modificar(cliente);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static bool Modificar(Clientes cliente)
        {
            bool modifica = false;
            using (var reposi = new Repositorio<Clientes>())
            {
                modifica = reposi.Modificar(cliente);
            }

            return modifica;
        }

        public static bool Eliminar(Clientes cliente)
        {
            bool eliminado = false;
            using (var reposi = new Repositorio<Clientes>())
            {
                eliminado = reposi.Eliminar(cliente);
            }
            return eliminado;
        }

        public static Clientes Buscar(Expression<Func<Entidades.Clientes, bool>> Busqueda)
        {
            Clientes Result = null;
            using (var repoitorio = new Repositorio<Clientes>())
            {
                Result = repoitorio.Buscar(Busqueda);
            }
            return Result;
        }

        public static List<Clientes> Listar(Expression<Func<Clientes, bool>> busqueda)
        {
            List<Clientes> Result = null;
            using (var repoitorio = new Repositorio<Clientes>())
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

        public static List<Entidades.Clientes> ListarTodo()
        {
            List<Clientes> Result = null;
            using (var repoitorio = new Repositorio<Clientes>())
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
