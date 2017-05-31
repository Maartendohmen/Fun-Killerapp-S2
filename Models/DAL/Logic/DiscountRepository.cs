using Fun_Killerapp_S2.DAL.Context;
using Fun_Killerapp_S2.DAL.Interface;
using Fun_Killerapp_S2.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.DAL.Logic
{
    class DiscountRepository
    {
        private IDiscounts context;

        public DiscountRepository()
        {
            this.context = new DiscountContext();
        }

        public List<Discount> GetAllDiscount()
        {
            return this.context.GetAll().Cast<Discount>().ToList();
        }

        public Discount GetOneDiscount(int id)
        {
            return (Discount)this.context.GetOne(id);
        }

        public void SaveDiscount(int amount, DateTime ending, string comment, List<Product> Discountedproducts)
        {
            List<object> discountedproduct = Discountedproducts.Cast<object>().ToList();
            context.Save(amount, ending, comment, discountedproduct);
        }  

        public void DeleteDiscount(int discountID)
        {
            context.Delete(discountID);
        }
    }
}
