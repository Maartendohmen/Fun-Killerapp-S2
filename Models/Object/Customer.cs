using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.Object
{
    public class Customer
    {
        private int customerid;
        private string name;
        private string town;
        private int age;

        public int CustomerID
        {
            get { return customerid; }
            private set { customerid = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public string Town
        {
            get { return town; }
            private set { town = value; }
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public Customer(int customerid, string name, string town, int age)
        {
            this.customerid = customerid;
            this.name = name;
            this.town = town;
            this.age = age;
        }

    }
}
