using System.Linq.Expressions;

namespace SchoolManagement11.Domains.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetbyId(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void AddStudent(T entity);

        void AddRange(IEnumerable<T> entity);
        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entity);
    }
}