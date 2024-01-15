using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendBazar.DataAccess.Data;
using TrendBazar.DataAccess.Repository.Interface;
using TrendBazar.Entities.Entities;

namespace TrendBazar.DataAccess.Repository.Implementation
{
    public class CustomerRepository:GenericRepository<Customer>,ICustomerInterface
    {
        public CustomerRepository(ApplicationContext context) : base(context) { }
     
    }
}
