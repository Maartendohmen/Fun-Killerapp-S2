using Fun_Killerapp_S2;
using Fun_Killerapp_S2.DAL;
using Fun_Killerapp_S2.DAL.Interface;
using Fun_Killerapp_S2.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Fun_Killerapp_S2.Object.Enum.OrderStatus;

namespace Fun_Killerapp_S2 
{
    class OrderContext : Connectionstring, IOrder
    {
        public List<object> GetAll(List<object> allproducts, List<object> allcustomers)
        {
            List<Product> allproducten = allproducts.Cast<Product>().ToList();
            List<Customer> Customers = allcustomers.Cast<Customer>().ToList();

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

                    foreach (Customer cus in Customers)
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

        public object GetOne(List<object> allproducts, List<object> allcustomers, int id)
        {
            List<Product> allproducten = allproducts.Cast<Product>().ToList();
            List<Customer> Customers = allcustomers.Cast<Customer>().ToList();

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

        public void Save(List<object> orderinput , int customerid)
        {
            List<Product> Allproducts = orderinput.Cast<Product>().ToList();
            conn.Open();
            string saveorderprocedure = "TestProcedure";
            SqlCommand SaveOrder = new SqlCommand(saveorderprocedure, conn);
            SaveOrder.CommandType = CommandType.StoredProcedure;

            DataTable datatabel = new DataTable();
            datatabel.Columns.Add("ProductID");

            foreach (Product product in Allproducts)
            {
                datatabel.Rows.Add(product.ProductID);
            }
            //need to add all the parameters
            SqlParameter Givelist = new SqlParameter();
            Givelist.ParameterName = "@List";
            Givelist.Value = datatabel;

            SaveOrder.Parameters.Add(Givelist);
            SaveOrder.Parameters.AddWithValue("id", customerid);
            SaveOrder.Parameters.AddWithValue("placedate", DateTime.Now);
            SaveOrder.ExecuteNonQuery();

        }
    }
}


