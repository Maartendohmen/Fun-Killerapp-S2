using Fun_Killerapp_S2.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.DAL.Context
{
    class CustomerContext : Connectionstring
    {
        public List<object> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            conn.Open();
            string getallcustomers = "SELECT CustomerID, Name, Town, Age FROM Customer";
            SqlCommand GetAllCustomers = new SqlCommand(getallcustomers, conn);

            using (SqlDataReader reader = GetAllCustomers.ExecuteReader())
            {
                while (reader.Read())
                {
                    customers.Add(new Customer(Convert.ToInt32(reader["CustomerID"].ToString()),reader["Name"].ToString(),reader["Town"].ToString(),Convert.ToInt32(reader["Age"].ToString())));
                }
            }
            conn.Close();
            return customers.Cast<object>().ToList();
        }

        public object GetOne(int customerid)
        {
            conn.Open();
            string getcustomer = "SELECT CustomerID, Name, Town, Age FROM Customer WHERE CustomerID = @id";
            SqlCommand GetUser = new SqlCommand(getcustomer, conn);
            GetUser.Parameters.AddWithValue("id", customerid);

            using (SqlDataReader reader = GetUser.ExecuteReader())
            {
                while (reader.Read())
                {
                    Customer toadd = new Customer(Convert.ToInt32(reader["CustomerID"].ToString()), reader["Name"].ToString(), reader["Town"].ToString(), Convert.ToInt32(reader["Age"].ToString()));
                    conn.Close();
                    return toadd;
                }
            }
            return null;
        }
    }
}
