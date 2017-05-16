using Fun_Killerapp_S2;
using Fun_Killerapp_S2.DAL;
using Fun_Killerapp_S2.DAL.Interface;
using Fun_Killerapp_S2.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Fun_Killerapp_S2.Object.Enum.OrderStatus;

namespace Fun_Killerapp_S2 
{
    class OrderContext : Connectionstring
    {
        public List<object> GetAll(List<Product> allproducts, List<Customer> allcustomers)
        {
            List<Product> noproducts = new List<Product>();
            List<Order> Orders = new List<Order>();
            Orderstatus orderstatus = Orderstatus.ordered;
            Customer current = new Customer(-1, "", "", -1);

            string querygetallorders = "SELECT OrderID,CustomerID,Date,Status From Order";
            SqlCommand Getallorders = new SqlCommand(querygetallorders, conn);

            using (SqlDataReader reader = Getallorders.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader["Status"].ToString() == "Verzonden")
                    {
                        orderstatus = Orderstatus.verzonden;
                    }
                    else if (reader["Status"].ToString() == "Verwerkt")
                    {
                        orderstatus = Orderstatus.verwerkt;
                    }
                    else if (reader["Status"].ToString() == "Ordered")
                    {
                        orderstatus = Orderstatus.ordered;
                    }

                    foreach (Customer cus in allcustomers)
                    {
                        if (cus.CustomerID == Convert.ToInt32(reader["CustomerID"]))
                        {
                            current = cus;
                        }
                    }
                    Orders.Add(new Order(Convert.ToInt32(reader["OrderID"]), current ,DateTime.Parse(reader["Date"].ToString()),orderstatus,noproducts));
                }
            }
            return Orders.Cast<object>().ToList();
        }

        public object GetOne(List<Product> allproducts, List<Customer> allcustomers, int id)
        {
            List<Product> noproducts = new List<Product>();
            List<Order> Orders = new List<Order>();
            Orderstatus orderstatus = Orderstatus.ordered;
            Customer current = new Customer(-1,"", "", -1);

            string querygetallorders = "SELECT OrderID,CustomerID,Date,Status FROM Product WHERE Orderid = @id";
            SqlCommand Getallorders = new SqlCommand(querygetallorders, conn);
            Getallorders.Parameters.AddWithValue("id", id);

            using (SqlDataReader reader = Getallorders.ExecuteReader())
            {
                while (reader.Read())
                {

                    if (reader["Status"].ToString() == "Verzonden")
                    {
                        orderstatus = Orderstatus.verzonden;
                    }
                    else if (reader["Status"].ToString() == "Verwerkt")
                    {
                        orderstatus = Orderstatus.verwerkt;
                    }
                    else if (reader["Status"].ToString() == "Ordered")
                    {
                        orderstatus = Orderstatus.ordered;
                    }
                    foreach (Customer cus in allcustomers)
                    {
                        if (cus.CustomerID == Convert.ToInt32(reader["CustomerID"]))
                        {
                            current = cus;
                        }
                    }
                    Order toadd = (new Order(Convert.ToInt32(reader["OrderID"]), current, DateTime.Parse(reader["Date"].ToString()), orderstatus, noproducts));
                    return toadd;
                }
            }
            return null;
        }
    }
}


