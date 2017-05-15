using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.Object
{
    public class Supplier
    {
        private string name;
        private string location;

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

        public Supplier(string name,string location)
        {
            this.name = name;
            this.location = location;
        }
    }
}
