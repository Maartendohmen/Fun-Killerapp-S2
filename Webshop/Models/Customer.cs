using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webshop.Models
{
    public class Customer
    {
        public int CustomerID{ get; set; }

        public string Name { get; set; }

        public string Town { get; set; }

        public decimal Age { get; set; }
    }
}