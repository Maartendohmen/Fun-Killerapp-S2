using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.Object
{
    public class Supplier
    {
        private int supplierid;
        private string name;
        private string location;

        public int SupplierID
        {
            get { return supplierid; }
            private set { supplierid = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public string Location
        {
            get { return location; }
            private set { location = value; }
        }

        public Supplier(int supplierid, string name,string location)
        {
            this.supplierid = supplierid;
            this.name = name;
            this.location = location;
        }
    }
}
