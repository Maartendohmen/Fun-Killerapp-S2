using Fun_Killerapp_S2.DAL.Logic;
using Fun_Killerapp_S2.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2
{
    public  class CustomerOverview
    {
        OrderRepository orderrepository = new OrderRepository();
        ProductRepository productrepository = new ProductRepository();
        SupplierRepository supplierrepository = new SupplierRepository();
        UserRepository userrepository = new UserRepository();
        CustomerRepository customerrepository = new CustomerRepository();
        CrewRepository crewrepository = new CrewRepository();
        DiscountRepository discountrepository = new DiscountRepository();


        public object GetCurrentUser(string emailadres, string password)
        {
            User currentuser = (User)userrepository.GetOneUser(emailadres, password);

            if (currentuser != null)
            {
                if (currentuser.CustomerID != -1)
                {
                    return customerrepository.GetOneCustomer(currentuser.CustomerID);
                }
                else
                {
                    return crewrepository.GetOneCrew(currentuser.CrewID);
                }
            }
            else
            {
                return null;
            }
        }

        public List<Product> GetAllProducts()
        {
            List<Product> allproducts = productrepository.GetAllProducts(supplierrepository.GetAllSuppliers().Cast<object>().ToList(),discountrepository.GetAllDiscount().Cast<object>().ToList());
            return allproducts;
        }

        public void placeorder(List<Product> producten, int customerid)
        {
            List<object> Orderinput = producten.Cast<object>().ToList();
            orderrepository.SaveOrder(Orderinput, customerid);
        }
    }
}
