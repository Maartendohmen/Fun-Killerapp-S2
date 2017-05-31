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
            conn.Open();
            List<Product> allproducten = allproducts.Cast<Product>().ToList();
            List<Customer> Customers = allcustomers.Cast<Customer>().ToList();

            List<Product> noproducts = new List<Product>();
            List<Order> Orders = new List<Order>();
            Orderstatus orderstatus = Orderstatus.Ordered;
            Customer current = new Customer(-1, "", "", -1);

            string querygetallorders = "SELECT OrderID,CustomerID,Date,Status,Totalprice From [Order]";
            SqlCommand Getallorders = new SqlCommand(querygetallorders, conn);

            using (SqlDataReader reader = Getallorders.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader["Status"].ToString() == "Verzonden")
                    {
                        orderstatus = Orderstatus.Verzonden;
                    }
                    else if (reader["Status"].ToString() == "Verwerkt")
                    {
                        orderstatus = Orderstatus.Verwerkt;
                    }
                    else if (reader["Status"].ToString() == "Ordered")
                    {
                        orderstatus = Orderstatus.Ordered;
                    }

                    foreach (Customer cus in Customers)
                    {
                        if (cus.CustomerID == Convert.ToInt32(reader["CustomerID"]))
                        {
                            current = cus;
                        }
                    }

                    Orders.Add(new Order(Convert.ToInt32(reader["OrderID"]), current ,DateTime.Parse(reader["Date"].ToString()),orderstatus,noproducts,Convert.ToDecimal(reader["Totalprice"])));
                }
            }
            conn.Close();
            return Orders.Cast<object>().ToList();
        }

        public object GetOne(List<object> allproducts, List<object> allcustomers, int id)
        {
            List<Order> Orders = new List<Order>();

            //for new single order
            DateTime dateordered = DateTime.Now;
            decimal totalprice = 0;
            Orderstatus orderstatus = Orderstatus.Ordered;
            Customer current = new Customer(-1, "", "", -1);
            List<Product> EmptyList = new List<Product>();

            string querygetallorders = "SELECT OrderID,CustomerID,Date,Status,Totalprice FROM [Order] WHERE Orderid = @id";
            SqlCommand Getallorders = new SqlCommand(querygetallorders, conn);
            Getallorders.Parameters.AddWithValue("id", id);

            conn.Open();

            using (SqlDataReader reader = Getallorders.ExecuteReader())
            {
                while (reader.Read())
                {
                    dateordered = DateTime.Parse(reader["Date"].ToString());
                    totalprice = Convert.ToDecimal(reader["Totalprice"]);

                    if (reader["Status"].ToString() == "Verzonden")
                    {
                        orderstatus = Orderstatus.Verzonden;
                    }
                    else if (reader["Status"].ToString() == "Verwerkt")
                    {
                        orderstatus = Orderstatus.Verwerkt;
                    }
                    else if (reader["Status"].ToString() == "Ordered")
                    {
                        orderstatus = Orderstatus.Ordered;
                    }
                    foreach (Customer cus in allcustomers)
                    {
                        if (cus.CustomerID == Convert.ToInt32(reader["CustomerID"]))
                        {
                            current = cus;
                        }
                    }
                }
            }
            string addproductstoorder = @"SELECT ProductID From [Order] inner join Orderregel on [Order].OrderID = Orderregel.OrderID where [Order].OrderID = @id;";
            SqlCommand AddProductsToOrder = new SqlCommand(addproductstoorder, conn);
            AddProductsToOrder.Parameters.AddWithValue("id", id);

            using (SqlDataReader reader = AddProductsToOrder.ExecuteReader())
            {
                while (reader.Read())
                {
                    foreach (Product p in allproducts)
                    {
                        if (p.ProductID ==  Convert.ToUInt32(reader["ProductID"]))
                        {
                            EmptyList.Add(p);
                        }
                    }
                }
            }
            conn.Close();
            return new Order(id, current, dateordered, orderstatus, EmptyList, totalprice);
        }

        public void Save(List<object> orderinput , int customerid)
        { 
            conn.Open();
            string saveorderprocedure = "PlaceOrder";
            SqlCommand SaveOrder = new SqlCommand(saveorderprocedure, conn);
            SaveOrder.CommandType = CommandType.StoredProcedure;

            DataTable datatabel = new DataTable();
            datatabel.Columns.Add("ProductID");

            foreach (Product product in orderinput)
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
            conn.Close();
        }
    }
}


