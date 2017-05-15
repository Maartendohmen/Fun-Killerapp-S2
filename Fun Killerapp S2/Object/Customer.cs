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
        private string emailadres;
        private string password;
        private string name;
        private string town;
        private int age;

        public int CustomerID
        {
            get { return customerid; }
            private set { customerid = value; }
        }

        public string Emailadres
        {
            get { return emailadres; }
            private set { emailadres = value; }
        }

        public string Password
        {
            get { return password; }
            private set { password = value; }
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

        public Customer(int customerid, string emailadres, string password, string name, string town, int age)
        {
            this.customerid = customerid;
            this.emailadres = emailadres;
            this.password = password;
            this.name = name;
            this.town = town;
            this.age = age;
        }

    }
}
