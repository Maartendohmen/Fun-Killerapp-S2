using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2
{
    class SupplierInfo
    {
        public List<string> Suppliers = new List<string>();
        private SqlConnection conn = new SqlConnection(@"Data Source=MAARTEN-PC\SQLEXPRESS;Initial Catalog=Webshop;Integrated Security=True");

        public void Getallallsupliers()
        {
            conn.Open();
            string query = "select SupplierID,Name,Location from Supplier;";
            SqlCommand getallsuppliers = new SqlCommand(query, conn);

            using (SqlDataReader reader = getallsuppliers.ExecuteReader())
            {
                while (reader.Read())
                {
                    string supplierID = reader.GetInt32(0).ToString();
                    string Name = reader.GetString(1);
                    string Location = reader.GetString(2);

                    Suppliers.Add(supplierID + "\t" + "\t" + "\t" + Name + "\t" + "\t" + "\t" + Location);
                }
            }
            conn.Close();
        }

        public void Addsupplier(string name, string location)
        {
            conn.Open();
            string queryaddsupplier = "insert into Supplier(Name, Location) values('" + name + "', '" + location + "'); ";
            SqlCommand addsuplier = new SqlCommand(queryaddsupplier, conn);
            addsuplier.ExecuteNonQuery();
            conn.Close();
        }

    }
}
