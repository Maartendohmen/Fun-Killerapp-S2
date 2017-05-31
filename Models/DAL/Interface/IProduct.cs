using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.DAL.Interface
{
    interface IProduct
    {
        List<object> GetAll(List<object> allsuppliers, List<object> alldiscounts);
        object GetOne(int id, List<object> allsuppliers, List<object> alldiscounts);
    }
}
