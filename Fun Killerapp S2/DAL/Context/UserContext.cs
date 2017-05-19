using Fun_Killerapp_S2.DAL;
using Fun_Killerapp_S2.DAL.Interface;
using Fun_Killerapp_S2.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2
{
    class UserContext : Connectionstring, IUser
    {
        public List<object> GetAll()
        {
            List<User> users = new List<User>();
            conn.Open();
            string getallusers = "SELECT UserID, CustomerID, CrewID, Emailadres, Password FROM [User]";
            SqlCommand GetAllUsers = new SqlCommand(getallusers, conn);


            using (SqlDataReader reader = GetAllUsers.ExecuteReader())
            {
                while (reader.Read())
                {
                    int customerid = -1;
                    int crewid = -1;

                    if (reader["CustomerID"] == DBNull.Value)
                    {
                        customerid = Convert.ToInt32(reader["CustomerID"].ToString());
                    }
                    else
                    {
                        crewid = Convert.ToInt32(reader["CrewID"].ToString());
                    }

                    users.Add(new User(Convert.ToInt32(reader["UserID"]),customerid,crewid, reader["Emailadres"].ToString(), reader["Password"].ToString()));
                }
            }
            conn.Close();
            return users.Cast<object>().ToList();
        }

        public object GetOne(string emailadres, string password)
        {
            conn.Open();
            string getuser = "SELECT UserID, CrewID, CustomerID, Emailadres, Password FROM [User] WHERE Emailadres = @adres AND Password = @password";
            SqlCommand GetUser = new SqlCommand(getuser, conn);
            GetUser.Parameters.AddWithValue("adres", emailadres);
            GetUser.Parameters.AddWithValue("Password", password);

            using (SqlDataReader reader = GetUser.ExecuteReader())
            {
                while (reader.Read())
                {
                    int customerid = -1;
                    int crewid = -1;

                    if (reader["CustomerID"] != DBNull.Value)
                    {
                        customerid = Convert.ToInt32(reader["CustomerID"].ToString());
                    }
                    else
                    {
                        crewid = Convert.ToInt32(reader["CrewID"].ToString());
                    }
                    User toadd = (new User(Convert.ToInt32(reader["UserID"]),customerid,crewid,reader["Emailadres"].ToString(),reader["Password"].ToString()));
                    conn.Close();
                    return toadd;
                }
            }
            return null;
        }
    }
}

