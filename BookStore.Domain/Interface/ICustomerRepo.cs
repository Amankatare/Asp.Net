using BookStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Interface
{
    public interface ICustomerRepo:IGenericRepository<Customer> //ICustomClassRepo that implements Generic Class should be given the type-safety of its Entity class when creating interfaces
    {
        
    }
}
