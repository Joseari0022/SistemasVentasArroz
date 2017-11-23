﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Repositorio<TEntity> : IRepository<TEntity> where TEntity : class
    {
        SistemaVentasDb Contex = null;
        public Repositorio()
        {
            Contex = new SistemaVentasDb();
        }

        private DbSet<TEntity> EntitySet
        {
            get
            {
                return Contex.Set<TEntity>();
            }
        }

        public TEntity Buscar(Expression<Func<TEntity, bool>> Busqueda)
        {
            try
            {
                return EntitySet.FirstOrDefault(Busqueda);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Guardar(TEntity Entidad)
        {
            try
            {
                EntitySet.Add(Entidad);
                Contex.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }

            return false;
        }

        public bool Modificar(TEntity Entidad)
        {
            bool Resultado = false;

            try
            {
                EntitySet.Attach(Entidad);
                Contex.Entry<TEntity>(Entidad).State = EntityState.Modified;
                Resultado = Contex.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return Resultado;
        }

        public bool Eliminar(TEntity Entidad)
        {
            bool Resultado = false;

            try
            {
                EntitySet.Attach(Entidad);
                EntitySet.Remove(Entidad);
                Resultado = Contex.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return Resultado;
        }

        public List<TEntity> Lista(Expression<Func<TEntity, bool>> Busqueda)
        {
            try
            {
                return EntitySet.Where(Busqueda).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TEntity> ListaGet()
        {
            try
            {
                return EntitySet.ToList();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Dispose()
        {
            if (Contex != null)
                Contex.Dispose();
        }

        TEntity IRepository<TEntity>.Guardar(TEntity Entidad)
        {
            throw new NotImplementedException();
        }

    }
}
