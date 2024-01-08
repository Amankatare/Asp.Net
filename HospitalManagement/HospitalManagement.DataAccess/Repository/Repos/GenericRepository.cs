using HospitalManagement.DataAccess.Data;
using HospitalManagement.DataAccess.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.DataAccess.Repository.Repos
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        public GenericRepository(AppDbContext context) 
        {
            _context = context ;
                
        }
        public void addEntity(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public List<T> addMultipleEntities(List<T> entities)
        {
          
            _context.Set<T>().AddRange(entities);
            return entities;

        }

        public void deleteEntity(int id)
        {
            var value = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(value);
            
        }

        public List<T> deleteMultipleEntities(List<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);

            return entities;
        }

        public T Get(int id)
        {
            var value = _context.Set<T>().Find(id);
            return value;
        }

        public IEnumerable<T> getAll()
        {
            var value = _context.Set<T>().ToList();
            return value;
        }
        
        public T updateEntity(T entity)
        {
            _context.Set<T>().Update(entity);
            return entity;
        }
        
        public List<T> updateMultipleEntities(List<T> entities)
        {
            _context.Set<T>().UpdateRange(entities);
            return entities;
        }
  
       

        void IGenericRepository<T>.updateEntity(T entity)
        {
            throw new NotImplementedException();
        }
    }
    }

