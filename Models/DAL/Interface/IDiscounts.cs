using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.DAL.Interface
{
    interface IDiscounts: IMain
    {
        void Save(int amount, DateTime ending, string comment, List<object> Discountedproducts);
        void Delete(int discountID);
    }
}
