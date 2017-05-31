using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.DAL.Interface
{
    interface IOrder
    {
        List<object> GetAll(List<object> allproducts,List<object> allcustomers);
        object GetOne(List<object> allproducts, List<object> allcustomers, int id);
        void Save(List<object> orderinput, int customerid);
    }
}
