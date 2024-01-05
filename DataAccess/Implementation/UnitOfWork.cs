using BookStore.DataAccess.Data;
using BookStore.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LearnContext _context;
        public UnitOfWork(LearnContext context)
        {
            _context = context;
            Customer = new CustomerRepo(_context);
        }
        public ICustomerRepo Customer {  get; private set; }

        public void Dispose()
        {
            
        }
    }
}
