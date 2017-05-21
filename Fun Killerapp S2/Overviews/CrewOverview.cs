using Fun_Killerapp_S2.DAL.Logic;
using Fun_Killerapp_S2.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2
{
    class CrewOverview 
    {
        CrewRepository crewrepository = new CrewRepository();
        OrderRepository orderrepository = new OrderRepository();
        ProductRepository productrepository = new ProductRepository();
        SupplierRepository supplierrepository = new SupplierRepository();
        CustomerRepository customerrepository = new CustomerRepository();

        public void Savelasttimelogin(DateTime lasttimelogin, int crewid)
        {
            crewrepository.SaveLastlogin(lasttimelogin, crewid);
        }

        public List<Order> GetAllOrders()
        {
            List<Order> allorders = orderrepository.GetAllOrder(productrepository.GetAllProducts(supplierrepository.GetAllSuppliers().Cast<object>().ToList(), new List<object>()).Cast<object>().ToList(), customerrepository.GetAllCustomers().Cast<object>().ToList());
            return allorders;            
       }
    }
}
