using Fun_Killerapp_S2.Object.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.Object
{
    public class Orders
    {
        private int orderid;
        private Customer customer;
        DateTime dateordered;
        OrderStatus.Orderstatus status;
        private List<Product> products;

        public int OrderID
        {
            get { return orderid; }
            private set {  orderid = value; }
        }

        public Customer Customer
        {
            get { return customer; }
            private set { customer = value; }
        }

        public DateTime Dateordered
        {
            get { return dateordered; }
            private set { dateordered = value; }
        }

        public OrderStatus.Orderstatus Status
        {
            get { return status; }
            private set { status = value; }
        }

        public List<Product> Products
        {
            get { return products;}
            private set { products = value; }
        }

        public Orders(int orderid, Customer customer, DateTime dateordered,OrderStatus.Orderstatus status, List<Product> products)
        {
            this.orderid = orderid;
            this.customer = customer;
            this.dateordered = dateordered;
            this.status = status;
            this.products = products;
        }

    }
}
