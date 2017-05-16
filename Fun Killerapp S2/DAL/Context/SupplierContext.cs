using Fun_Killerapp_S2.DAL;
using Fun_Killerapp_S2.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2
{
    class SupplierContext : Connectionstring
    {
        public List<object> GetAll()
        {
            conn.Open();
            List<Supplier> Suppliers = new List<Supplier>();
            string getallsuppliers = "SELECT SupplierID, Name, Location FROM Supplier";
            SqlCommand GetAllSuppliers = new SqlCommand(getallsuppliers, conn);

            using (SqlDataReader reader = GetAllSuppliers.ExecuteReader())
            {
                while (reader.Read())
                {
                    Suppliers.Add(new Supplier(Convert.ToInt32(reader["SupplierID"]), reader["Name"].ToString(), reader["Location"].ToString()));
                }
            }
            conn.Close();
            return Suppliers.Cast<object>().ToList();
        }

        public object GetOne(int id)
        {
            conn.Open();
            string getallsuppliers = "SELECT SupplierID, Name, Location FROM Supplier WHERE SupplierID = @id";
            SqlCommand GetAllSuppliers = new SqlCommand(getallsuppliers, conn);
            GetAllSuppliers.Parameters.AddWithValue("id", id);
            using (SqlDataReader reader = GetAllSuppliers.ExecuteReader())
            {
                while (reader.Read())
                {
                   Supplier toadd = (new Supplier(Convert.ToInt32(reader["SupplierID"]), reader["Name"].ToString(), reader["Location"].ToString()));
                    conn.Close();
                    return toadd;
                }
            }
            return null;
        }
    }
}
