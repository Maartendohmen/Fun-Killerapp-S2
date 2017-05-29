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
        DiscountRepository discountrepository = new DiscountRepository();

        public void Savelasttimelogin(DateTime lasttimelogin, int crewid)
        {
            crewrepository.SaveLastlogin(lasttimelogin, crewid);
        }

        public Product GetOneProduct(int ProductID)
        {
            return productrepository.GetOneProduct(ProductID, supplierrepository.GetAllSuppliers().Cast<object>().ToList(), discountrepository.GetAllDiscount().Cast<object>().ToList());
        }

        public Order GetOneOrder(int orderid)
        {
            return orderrepository.GetOneOrder(productrepository.GetAllProducts(supplierrepository.GetAllSuppliers().Cast<object>().ToList(), discountrepository.GetAllDiscount().Cast<object>().ToList()).Cast<object>().ToList(), customerrepository.GetAllCustomers().Cast<object>().ToList(),orderid);
        }

        public void SaveDiscounts(int amount, DateTime ending, string comment, List<Product> DiscountedProducts)
        {
            discountrepository.SaveDiscount(amount, ending, comment, DiscountedProducts);
        }

        public List<Order> GetAllOrders()
        {
            List<Order> allorders = orderrepository.GetAllOrder(productrepository.GetAllProducts(supplierrepository.GetAllSuppliers().Cast<object>().ToList(), discountrepository.GetAllDiscount().Cast<object>().ToList()).Cast<object>().ToList(), customerrepository.GetAllCustomers().Cast<object>().ToList());
            return allorders;            
       }

        public List<Product> GetAllProducts()
        {
            List<Product> allproducts = productrepository.GetAllProducts(supplierrepository.GetAllSuppliers().Cast<object>().ToList(),discountrepository.GetAllDiscount().Cast<object>().ToList());
            return allproducts;
        }

        public List<Discount> GetAllDiscounts()
        {
            List<Discount> alldiscounts = discountrepository.GetAllDiscount();
            return alldiscounts;
        }
    }
}
