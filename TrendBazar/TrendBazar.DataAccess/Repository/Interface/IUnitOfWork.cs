using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendBazar.DataAccess.Repository.Interface
{
    public interface IUnitOfWork
    {
        ICategoryInterface Category { get; }
        ICustomerInterface Customer { get; }

        IProductInterface Product { get; }

        IOrderInterface Order { get; }
        
        IApplicationRoleInterface ApplicationRole { get; }

        IApplicationUserInterface ApplicationUser { get; }

        public int Save();
        public void Dispose();
    }
}
