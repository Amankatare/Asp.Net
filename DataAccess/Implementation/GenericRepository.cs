using BookStore.DataAccess.Data;
using BookStore.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //GenericRepository that implements IGenericRepository Interface should be given the type-safety of T type class 

        private readonly LearnContext _context;
        public GenericRepository(LearnContext context) 
        {
            _context = context;
        }
        public void Add(T entity)
        {
           _context.Set<T>().Add(entity);
            Save();
        }

        public void Delete(int id)
        {
           var cusid= _context.Set<T>().Find(id);
            _context.Set<T>().Remove(cusid);
            Save();

        }

        public T Get(int id)
        {
           var cusid = _context.Set<T>().Find(id);
            return cusid;

        }

        public IEnumerable<T> GetAll()
        {
          var records =  _context.Set<T>().ToList(); ;
            return records;
        }

        public void Update(T entity)
        {
            var records= _context.Set<T>().Update(entity);
            Save();
        }

        public int Save()
        {
           return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
