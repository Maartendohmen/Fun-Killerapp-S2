using Fun_Killerapp_S2.DAL.Context;
using Fun_Killerapp_S2.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2
{
    class CustomerOverview
    {
        OrderContext ordercontext = new OrderContext();
        ProductContext productcontext = new ProductContext();
        SupplierContext suppliercontext = new SupplierContext();
        UserContext usercontext = new UserContext();
        CustomerContext customercontext = new CustomerContext();
        CrewContext crewcontext = new CrewContext();

        public object GetCurrentUser(string emailadres, string password)
        {
            User currentuser = (User)usercontext.GetOne(emailadres, password);
            
            if (currentuser.CustomerID != -1)
            {
                return customercontext.GetOne(currentuser.CustomerID);
            }
            else
            {
                return crewcontext.GetOne(currentuser.CrewID);
            }
        }

        public List<Product> GetAllProducts()
        {
            List<Product> allproducts = productcontext.GetAll(suppliercontext.GetAll().Cast<Supplier>().ToList(), new List<Discount>()).Cast<Product>().ToList();
            return allproducts;
        }

        public void placeorder(List<Product> producten, int customerid)
        {
            List<object> Orderinput = producten.Cast<object>().ToList();
            ordercontext.Save(Orderinput, customerid);
        }
        
    }
}
