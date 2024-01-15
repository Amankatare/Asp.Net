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
    public class ProductRepository :GenericRepository<Product>,IProductInterface
    {
        public ProductRepository(ApplicationContext context) : base(context) { }
    }
}
