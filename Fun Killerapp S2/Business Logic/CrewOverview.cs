using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2
{
    class CrewOverview 
    {
        ProductInfo productinfo = new ProductInfo();
        OrderInfo orderinfo = new OrderInfo();
        SupplierInfo supplierinfo = new SupplierInfo();

        public string[] loadproducts()
        {
            productinfo.Getallproducts();
            string [] allproducts = productinfo.Products.ToArray();
            return allproducts;       
        }

        public string[] loadorders()
        {
            orderinfo.Getorders();
            string[] allorders = orderinfo.orders.ToArray();
            return allorders;
        }

        public string[] loadsuppliers()
        {
            supplierinfo.Getallallsupliers();
            string[] allsuppliers = supplierinfo.Suppliers.ToArray();
            return allsuppliers;
        }

        public void clearsupplierslist()
        {
            supplierinfo.Suppliers.Clear();
        }

        public void clearproductlist()
        {
            productinfo.Products.Clear();
        }
        
    }
}
