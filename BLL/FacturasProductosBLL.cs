﻿using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class FacturasProductosBLL
    {

        public static bool Mofidicar(FacturasProductos existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<FacturasProductos>())
            {
                eliminado = repositorio.Modificar(existente);
            }

            return eliminado;

        }


        public static List<Entidades.FacturasProductos> GetListado(Expression<Func<Entidades.FacturasProductos, bool>> criterioBusqueda)
        {
            List<Entidades.FacturasProductos> lista = new List<Entidades.FacturasProductos>();
            using (var db = new SistemaVentasDb())
            {
                try
                {
                    lista = db.FacturasProductos.Where(criterioBusqueda).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }

        public static List<FacturasProductos> GetList(Expression<Func<FacturasProductos, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<FacturasProductos>())
            {
                return repositorio.Lista(criterioBusqueda);
            }
        }

        public static Entidades.FacturasProductos Buscar(Expression<Func<FacturasProductos, bool>> criterioBusqueda)
        {
            using (var repositorio = new DAL.Repositorio<FacturasProductos>())
            {
                return repositorio.Buscar(criterioBusqueda);
            }
        }

        public static Entidades.FacturasProductos BuscarB(int id)
        {

            Entidades.FacturasProductos nuevo;
            using (var db = new SistemaVentasDb())
            {
                try
                {
                    nuevo = db.FacturasProductos.Find(id);


                }
                catch (Exception)
                {

                    throw;
                }
                return nuevo;
            }
        }

        public static bool Guardar(FacturasProductos relacion)
        {
			bool resultado = false;
			using (var conexion = new SistemaVentasDb())
			{
				try
				{
					conexion.FacturasProductos.Add(relacion);
					conexion.SaveChanges();
					resultado = true;
				}
				catch (Exception)
				{

					throw;
				}
			}
			return resultado;
		}

        public static bool Eliminar(Entidades.FacturasProductos detalle)
        {
            using (var repositorio = new Repositorio<Entidades.FacturasProductos>())
            {
                return repositorio.Eliminar(detalle);
            }
        }


        public static bool Guardar(List<FacturasProductos> listado)
        {
            bool resultado = false;
            try
            {
                foreach (var relacion in listado)
                {
                    resultado = Guardar(relacion);
                }

            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }
        public static List<FacturasProductos> GetLista(Expression<Func<FacturasProductos, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<FacturasProductos>())
            {
                return repositorio.Lista(criterioBusqueda);
            }
        }

        public static List<Entidades.FacturasProductos> GetListodo()
        {
            List<Entidades.FacturasProductos> lista = new List<Entidades.FacturasProductos>();
            using (var db = new SistemaVentasDb())
            {
                try
                {
                    lista = db.FacturasProductos.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }


        public static List<Productos> Listar(Expression<Func<FacturasProductos, bool>> criterioBusqueda)
        {
            List<Productos> listado = new List<Productos>();
            List<FacturasProductos> relaciones = null;
            using (var conexion = new SistemaVentasDb())
            {
                try
                {
                    relaciones = conexion.FacturasProductos.Where(criterioBusqueda).ToList();
                    foreach (var item in relaciones)
                    {
                        listado.Add(ProductosBll.BuscarRelacion(item.IdProductos));
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return listado;
        }

    }

}
