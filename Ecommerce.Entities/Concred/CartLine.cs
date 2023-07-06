using Ecommerce.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities.Concred
{
    public class CartLine
    {
        public Product  Product { get; set; }
        public int Quantity { get; set; }
    }
}
