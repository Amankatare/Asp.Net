using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendBazar.Entities.Entities
{
    public class Order
    {
        public Guid Id { get; set; }

        public Customer Customer { get; set; }

        public DateTime OrderDate { get; set; }

    }
}
