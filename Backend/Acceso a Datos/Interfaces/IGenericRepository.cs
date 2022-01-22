using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Acceso_a_Datos.Interfaces
{
    public interface IGenericRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity)where T : class;
        void Delete<T>(T entity) where T :class;
        IEnumerable<T> GetAll<T>() where T : class;
    }
}
