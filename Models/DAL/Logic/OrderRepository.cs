using Fun_Killerapp_S2.DAL.Interface;
using Fun_Killerapp_S2.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.DAL.Logic
{
    class OrderRepository
    {
        private IOrder context;

        public OrderRepository()
        {
            this.context = new OrderContext();
        }

        public List<Order> GetAllOrder(List<object> allproducts,List<object> allcustomers)
        {
            return this.context.GetAll(allproducts, allcustomers).Cast<Order>().ToList();
        }

        public Order GetOneOrder(List<object> allproducts, List<object> allcustomers, int id)
        {
            return (Order)this.context.GetOne(allproducts, allcustomers,id);
        }

        public void SaveOrder(List<object> orderinput, int customerid)
        {
            this.context.Save(orderinput, customerid);
        }
    }
}
