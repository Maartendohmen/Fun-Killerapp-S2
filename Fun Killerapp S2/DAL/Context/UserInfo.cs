using Fun_Killerapp_S2.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2
{
    class GetUserInfo : IUserInfo
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=MAARTEN-PC\SQLEXPRESS;Initial Catalog=Webshop;Integrated Security=True");
        public string error;

        public int getID(bool crewmember, string username, string password)
        {
            conn.Close();
            if (crewmember == false)
            {
                    conn.Open();
                    string query = "select [User].CustomerID from [User] where [User].Emailadres = '" + username + "' and [User].Password = '" + password + "'";
                    SqlCommand getid = new SqlCommand(query, conn);

                    using (SqlDataReader reader = getid.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idcustomer = reader.GetInt32(0);
                            return idcustomer;
                        }
                    }
            }
            
            else
            {
                conn.Open();
                string query = "select [User].CrewID from [User] where [User].Emailadres = '" + username + "' and [User].Password = '" + password + "'";
                    SqlCommand getid = new SqlCommand(query, conn);

                    using (SqlDataReader reader = getid.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idcrewmember = reader.GetInt32(0);
                            return idcrewmember;
                        }
                    }
                }               
            return -1; //error
        }


        public string GetCustomername(int customerID)
        {
            conn.Open();
            string query = "select Customer.Name from Customer where CustomerID = "+customerID+";";
            SqlCommand getcustomername = new SqlCommand(query, conn);

            using (SqlDataReader reader = getcustomername.ExecuteReader())
            {
                while (reader.Read())
                {
                    string customername = reader.GetString(0);
                    return customername;
                }
            }
            conn.Close();
            return "Name was not found";
        }
    }
}
