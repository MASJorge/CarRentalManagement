using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace CarRentalManagement.Server.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context; // esta es la conexion a la base de datos el datacontext
        private readonly DbSet<T> _db; //donde tengo la base de datos establecida
        
        public GenericRepository(ApplicationDbContext context) //lo mismo que makescontroller inyecto el Aplicationdecontext //constuructor generico
        {
            _context = context; // inicializamos nuestra copia local en el objeto inyectado
            _db = _context.Set<T>(); //representa un conjunto de bases de dados conectadas de tipo T 
            // inicializo mi objeto db 
        }
        public async Task Delete(string id)
        {
            //siempre que trabajemos con algo asincronico tenemos que poner delante la palabra await 
            var record = await _db.FindAsync(id); // que sea asincronico hace que la aplicacion pueda seguir ejecutandose sin esperar el resultado de la accion, esto ultimo lo hace en segundo plano
            _db.Remove(record);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _db.RemoveRange(entities);
        }

        public async Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null)
        {
            IQueryable<T> query = _db; // primero se inicializa una cunsulta

            if (includes != null)
            {
                foreach (var prop in includes)
                {
                    query = query.Include(prop);
                }
            }

            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public async Task<IList<T>> GetAll(Expression<Func<T, bool>> expression = null, 
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, 
            List<string> includes = null)
        {
            IQueryable<T> query = _db; //esto trae todas las tablas de la base de datos

            if (expression != null)
            {
                query = query.Where(expression); // aqui le digo especificcamente que quiero de esa base de datos, que tabla, a travez de la expresion lambda que se recibe
            }

            if (includes != null)
            {
                foreach (var prop in includes)
                {
                    query = query.Include(prop);
                }
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task Insert(T entity)
        {
            await _db.AddAsync(entity);
        }

        public async Task InsertRange(IEnumerable<T> entities)
        {
            await _db.AddRangeAsync(entities);
        }

        public void Update(T entity)
        {
            _db.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        Task<IList<T>> IGenericRepository<T>.Get(Expression<Func<T, bool>> expression, List<string> includes)
        {
            throw new NotImplementedException();
        }
    }
}
