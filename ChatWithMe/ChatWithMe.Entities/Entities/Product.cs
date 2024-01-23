using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWithMe.Entities.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name {  get; set; }

        public string Description { get; set; }

        public double Price {  get; set; }

        public Category Category {  get; set; }

        // Stock Quantity, Images, Ratings,

        public string Reviews {  get; set; }
    }
}
