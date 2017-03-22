using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2
{
    class Getinfo
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=MAARTEN-PC\SQLEXPRESS;Initial Catalog=Webshop;Integrated Security=True");
        public List<string> Products = new List<string>();


        public int getID(bool crewmember, string username, string password)
        {
            conn.Close();
            if (crewmember == false)
            {
                conn.Open();
                string query = "select Userm.CustomerID from Userm where Userm.Emailadres = '"+username+"' and userm.Password = '"+password+"'";
                SqlCommand getid = new SqlCommand(query, conn);

                using (SqlDataReader reader = getid.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idcustomer = reader.GetInt32(0);
                        return idcustomer;
                    }
                }
                conn.Close();
            }
            else
            {
                conn.Open();
                string query = "select Userm.CrewID from Userm where Userm.Emailadres = '" + username + "' and userm.Password = '" + password + "'";
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
            return 10000000; //error
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



        public void Getallproducts()
        {
            string query = "select Name,Catagorie from Product order by Name;;";
            SqlCommand getallproducts = new SqlCommand(query, conn);

            using (SqlDataReader reader = getallproducts.ExecuteReader())
            {
                while (reader.Read())
                {
                    string productname = reader.GetString(0);
                    string productcatagorie = reader.GetString(1);
                    if (productname.Length < 10)
                    {
                        Products.Add(productname + "\t" + "\t" + "\t" + productcatagorie);
                    }
                    else
                    {
                        Products.Add(productname + "\t" + "\t" + productcatagorie);
                    }                 
                }
            }
            conn.Close();
        }
        public void seachproducts(string input)
        {
            Products.Clear();
            conn.Open();
            string query = "select Name,Catagorie from Product where Name like '"+input+"%';";
            SqlCommand filterproducts = new SqlCommand(query, conn);

            using (SqlDataReader reader = filterproducts.ExecuteReader())
            {
                while (reader.Read())
                {
                    string productname = reader.GetString(0);
                    string productcatagorie = reader.GetString(1);
                    if (productname.Length < 10)
                    {
                        Products.Add(productname + "\t" + "\t" + "\t" + productcatagorie);
                    }
                    else
                    {
                        Products.Add(productname + "\t" + "\t" + productcatagorie);
                    }
                }
            }
            conn.Close();
        }






    }
}
