using Backend.Acceso_a_Datos;
using Backend.Acceso_a_Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Dominio
{
    
    public class GenericRepository : IGenericRepository
    {
        private readonly ApplicationDbContext Context;

        public GenericRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
        }

        public void Delete<T>(T entity) where T : class
        {
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
        }

        public IEnumerable<T> GetAll<T>() where T : class
        {
            return Context.Set<T>().ToList();
        }

        public void Update<T>(T entity) where T : class
        {
            Context.Set<T>().Update(entity);
            Context.SaveChanges();
        }
    }
}
