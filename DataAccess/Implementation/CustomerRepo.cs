using BookStore.DataAccess.Data;
using BookStore.Domain.Entities;
using BookStore.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Implementation
{
    public class CustomerRepo : GenericRepository<Customer>, ICustomerRepo //CustomClassRepo that implements Generic Class should be given the type-safety of its Entity class when implementing interfaces IGenericRepository and ICustomRepo 
    {

        public CustomerRepo(LearnContext context):base(context) { }

        
    }
}

