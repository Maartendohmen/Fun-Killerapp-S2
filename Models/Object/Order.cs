using Fun_Killerapp_S2.Object.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.Object
{
    public class Order
    {
        private int orderid;
        private Customer customer;
        DateTime dateordered;
        OrderStatus.Orderstatus status;
        private List<Product> products;
        decimal totalprice;

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

        public decimal Totalprice
        {
            get { return totalprice; }
            private set { totalprice = value; }
        }

        public Order(int orderid, Customer customer, DateTime dateordered,OrderStatus.Orderstatus status, List<Product> products, decimal totalprice)
        {
            this.orderid = orderid;
            this.customer = customer;
            this.dateordered = dateordered;
            this.status = status;
            this.products = products;
            this.totalprice = totalprice;
        }

    }
}
