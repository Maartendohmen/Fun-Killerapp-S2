using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.DAL.Interface
{
    interface IProductInfo
    {
        void Getallproducts();
        void seachproducts(string input);
        void updateprice(string productname, decimal newprice);
    }
}
