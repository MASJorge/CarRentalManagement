using System.Linq.Expressions;

namespace CarRentalManagement.Server.IRepository
{
    public interface IGenericRepository<T> where T : class 
    { 
        // al ser una lcase generica le digo que debe recibir una clave T que tiene que ser clase
        // y luego voy a realizar funciones que me sirvan para todas las clases
        Task<IList<T>> GetAll(
            Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<string> includes = null
            );
        Task<IList<T>> Get(  // aqui solo traigo una entidad
            Expression<Func<T, bool>> expression,
            List<string> includes = null
            );
        Task Insert(T entity);
        Task InsertRange(IEnumerable<T> entities);
        Task Delete(string id);
        void DeleteRange(IEnumerable<T> entities);
        void Update (T entity);
    }
}
