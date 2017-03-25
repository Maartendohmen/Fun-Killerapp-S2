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

        public int Placeorder(int customerid, string placedate)
        {
            conn.Open();
            string querryplaceorder = "insert into Orderm (CustomerID,Date,Status) OUTPUT Inserted.OrderID values('" + customerid+"','"+placedate+"','ordered');";
            SqlCommand placeorder = new SqlCommand(querryplaceorder, conn);
            int lastmadeID = (int)placeorder.ExecuteScalar();
            return lastmadeID;
        }

        public void MakeOrderRegel(int OrderID, List<string>products)
        {

        }
    }
}
