using Fun_Killerapp_S2.DAL;
using Fun_Killerapp_S2.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2 
{
    class OrderInfo : Connectionstring,IOrderInfo
    {
        public List<string> orders = new List<string>();
        public void Placeorder(int customerid, string placedate, List<string> Cartproducts)
        {
            
            conn.Open();

            DataTable Producten = new DataTable();
            Producten.Columns.Add("Producten naam",typeof (string));
            Producten.Columns.Add("ProductID", typeof(int));
            int ProductID = 0;

            foreach(string product in Cartproducts)
            {
                Producten.Rows.Add(product,ProductID);
                ProductID++;
                Console.WriteLine(Producten.Rows[0].Field<string>(0));
            }

            SqlCommand placeorder = new SqlCommand("TestProcedure",conn);
            placeorder.CommandType = System.Data.CommandType.StoredProcedure;
            placeorder.Parameters.AddWithValue("id", customerid);
            placeorder.Parameters.AddWithValue("placedate", placedate);
            SqlParameter Productenparameter = placeorder.Parameters.AddWithValue("@List", Producten);
            Productenparameter.SqlDbType = SqlDbType.Structured;
            placeorder.Parameters.AddWithValue("productinCart", Cartproducts.Count);
            
            placeorder.ExecuteNonQuery();
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
