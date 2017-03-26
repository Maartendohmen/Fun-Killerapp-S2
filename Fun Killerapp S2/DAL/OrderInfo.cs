using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2
{
    class OrderInfo
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=MAARTEN-PC\SQLEXPRESS;Initial Catalog=Webshop;Integrated Security=True");
        public List<string> orders = new List<string>();
        List<int> Productsincart = new List<int>();
        public int Placeorder(int customerid, string placedate)
        {
            conn.Open();
            string querryplaceorder = "insert into Orderm (CustomerID,Date,Status) OUTPUT Inserted.OrderID values('" + customerid + "','" + placedate + "','ordered');";
            SqlCommand placeorder = new SqlCommand(querryplaceorder, conn);
            int lastmadeID = (int)placeorder.ExecuteScalar();
            conn.Close();
            return lastmadeID;
        }

        public void MakeOrderRegel(int OrderID, List<string> products)
        {
            conn.Open();
            foreach (string product in products)
            {
                string queryGetProductID = "Select ProductID From Product where Name = '" + product + "';";


                SqlCommand GetProductID = new SqlCommand(queryGetProductID, conn);

                using (SqlDataReader reader = GetProductID.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int productID = reader.GetInt32(0);
                        Productsincart.Add(productID);
                    }
                }
            }

            foreach (int productID in Productsincart)
            {
                conn.Close();
                conn.Open();
                string queryAddorderregel = "insert into Orderregel(OrderID,ProductID) values ('" + OrderID + "','" + productID + "');";
                SqlCommand querryAddorderregel = new SqlCommand(queryAddorderregel, conn);
                querryAddorderregel.ExecuteNonQuery();
            }
            conn.Close();
        }







        public void Getorders()
        {
            conn.Open();
            string querygetorders = "select OrderID,Status,Date from Orderm;";
            SqlCommand getorders = new SqlCommand(querygetorders, conn);

            using (SqlDataReader reader = getorders.ExecuteReader())
            {
                while (reader.Read())
                {
                    int OrderID = reader.GetInt32(0);
                    string Status = reader.GetString(1);
                    DateTime date = reader.GetDateTime(2);

                    string orderswithfulltime = "OrderID=" + OrderID + "\t" + "\t" + "\t" + "Status=" + Status + "\t" + "\t" + "\t" + "Datetime=" + date;
                    string orderswithout = orderswithfulltime.Replace("00:00:00", "");

                    orders.Add(orderswithout);
                }
            }
            conn.Close();
        }
    }
}
