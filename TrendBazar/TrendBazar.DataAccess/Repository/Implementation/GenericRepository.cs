using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendBazar.DataAccess.Data;
using TrendBazar.DataAccess.Repository.Interface;

namespace TrendBazar.DataAccess.Repository.Implementation
{
    public class GenericRepository<T> : IGenericInterface<T> where T : class
    {
        private readonly ApplicationContext _context;
      
        public GenericRepository(ApplicationContext context)
        {
            _context = context;

        }
        public void Create(T entity)
        {

            _context.Set<T>().Add(entity);
            Save();
            
        }

        public void Delete(int id)
        {
            var entity = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entity);
            Save();

        }

        public T Get(int id)
        {
            var entity = _context.Set<T>().Find(id);
            Save();
            return entity;
        }

        public IEnumerable<T> GetValues()
        {
          var entity = _context.Set<T>().ToList();
            Save();
            return entity;
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            Save();

        }

        public int Save(){ return _context.SaveChanges();}
        public void Dispose() { _context.Dispose(); }
    }
    
}
