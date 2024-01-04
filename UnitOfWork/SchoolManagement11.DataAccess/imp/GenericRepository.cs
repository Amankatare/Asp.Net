using SchoolManagement11.DataAccess.DataContext;
using SchoolManagement11.Domains.Repository;
using System.Linq.Expressions;

namespace SchoolManagement11.DataAccess.imp
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly SchoolManagement11DbContext _context;
    

        public GenericRepository(SchoolManagement11DbContext context)
        {
          
        }

        public void AddStudent(T entity)
        {
            _context.Set<T>().Add(entity);

        }

        public void AddRange(IEnumerable<T> entity)
        {
            _context.Set<T>().AddRange(entity);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetbyId(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            _context.Set<T>().RemoveRange(entity);
        }
    }
}
