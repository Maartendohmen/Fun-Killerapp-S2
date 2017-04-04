using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2
{
    class CustomerOverview
    {
        ProductInfo productinfo = new ProductInfo();
        OrderInfo orderinfo = new OrderInfo();
        SupplierInfo supplierinfo = new SupplierInfo();
        GetUserInfo userinfo = new GetUserInfo();


        public string Getnaam(int customerid)
        {
           string naam = "You're logged in as: " + userinfo.GetCustomername(customerid) + "";
           return naam;
        }

        public string[] loadproducts()
        {
            productinfo.Getallproducts();
            string[] allproducts = productinfo.Products.ToArray();
            return allproducts;
        }

        public string[] searchproducts(string searchtext)
        {
            productinfo.Products.Clear();
            productinfo.seachproducts(searchtext);
            string[] searchedproducts = productinfo.Products.ToArray();
            return searchedproducts;
        }

        public void placeorder(int customerid, List<string> cartproducts)
        {
            int OrderID = orderinfo.Placeorder(customerid, DateTime.Today.ToString("yyyy / MM / dd"));
            orderinfo.MakeOrderRegel(OrderID, cartproducts);
        }
    }
}
