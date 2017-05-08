using Fun_Killerapp_S2.DAL;
using Fun_Killerapp_S2.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2 
{
    class OrderInfo : Connectionstring,IOrderInfo
    {
        public List<string> orders = new List<string>();
        List<int> Productsincart = new List<int>();
        public int Placeorder(int customerid, string placedate)
        {
            conn.Open();

            SqlCommand placeorder = new SqlCommand("Placeorder",conn);
            placeorder.CommandType = System.Data.CommandType.StoredProcedure;
            placeorder.Parameters.AddWithValue("id", customerid);
            placeorder.Parameters.AddWithValue("placedate", placedate);

            placeorder.ExecuteNonQuery();

            int lastmadeID = (int)placeorder.ExecuteScalar();
            conn.Close();
            return lastmadeID;
        }

        public void MakeOrderRegel(int OrderID, List<string> products)
        {
            conn.Open();

            SqlCommand makeorderregel = new SqlCommand("Makeorderregel",conn);
            makeorderregel.CommandType = System.Data.CommandType.StoredProcedure;

            foreach (string product in products)
            {
                makeorderregel.Parameters.AddWithValue("productname", product);
                makeorderregel.Parameters.AddWithValue("orderid", OrderID);                
                makeorderregel.ExecuteNonQuery();
                makeorderregel.Parameters.Clear();
            }

            conn.Close();
        }

        public void Getorders()
        {
            conn.Open();
            string querygetorders = "select OrderID,Status,Date from [Order];";
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
