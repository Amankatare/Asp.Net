using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.DataAccess.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> getAll();
        T Get(int id);
        void addEntity(T entity);
        List<T> addMultipleEntities(List<T> entities);
        void updateEntity(T entity);
        List<T> updateMultipleEntities(List<T> entities);
        void deleteEntity(int id);

        List<T> deleteMultipleEntities(List<T> entities);

    }
}
