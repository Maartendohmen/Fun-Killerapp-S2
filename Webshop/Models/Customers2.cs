using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webshop.Models
{
    public class Customers2
    {
        public static List<Customers2> Allcustomers = new List<Customers2>()
        {
            new Customers2(80,"Henk","Heel",10),
            new Customers2(81,"Sjaak","Kal",-5),
        };

        public int Customerid;
        public string Name;
        public string Town;
        public int Age;

        public Customers2(int customerid, string name, string town, int age)
        {
            this.Customerid = customerid;
            this.Name = name;
            this.Town = town;
            this.Age = age;
        }
    }
}