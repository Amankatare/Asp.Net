using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendBazar.DataAccess.Repository.Interface
{
    public interface IGenericInterface<T> where T : class
    {
        T Get(int id);

        IEnumerable<T> GetValues();

        void Create(T entity);

        void Update(T entity);

        void Delete(int id);

    }
}
