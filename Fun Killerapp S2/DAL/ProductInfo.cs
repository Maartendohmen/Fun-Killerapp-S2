using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2
{
     class ProductInfo
    {
        public List<string> Products = new List<string>();
        private SqlConnection conn = new SqlConnection(@"Data Source=MAARTEN-PC\SQLEXPRESS;Initial Catalog=Webshop;Integrated Security=True");


        public void Getallproducts()
        {
            conn.Open();
            string query = "select Name,Catagorie,Price from Product order by Name;";
            SqlCommand getallproducts = new SqlCommand(query, conn);

            using (SqlDataReader reader = getallproducts.ExecuteReader())
            {
                while (reader.Read())
                {
                    string productname = reader.GetString(0);
                    string productcatagorie = reader.GetString(1);
                    decimal productprice = reader.GetDecimal(2);
                    if (productname.Length < 10 && productcatagorie.Length < 8)
                    {
                        Products.Add(productname + "\t" + "\t" + "\t" + productcatagorie + "\t" + "\t" + "\t" + "€" + productprice.ToString() + "," + "-");
                    }
                    else if (productname.Length > 11 && productcatagorie.ToString().Length >= 8)
                    {
                        Products.Add(productname + "\t" + "\t" + "\t" + productcatagorie + "\t" + "\t" + "€" + productprice.ToString() + "," + "-");
                    }
                    else if (productname.Length < 10 && productcatagorie.ToString().Length >= 8)
                    {
                        Products.Add(productname + "\t" + "\t" + "\t" + productcatagorie + "\t" + "\t" + "€" + productprice.ToString() + "," + "-");
                    }
                    else if (productname.Length > 9 && productcatagorie.ToString().Length < 8)
                    {
                        Products.Add(productname + "\t" + "\t" + "\t" + productcatagorie + "\t" + "\t" + "\t" + "€" + productprice.ToString() + "," + "-");
                    }

                }
            }
            conn.Close();
        }
        public void seachproducts(string input)
        {
            Products.Clear();
            conn.Open();
            string query = "select Name,Catagorie,Price from Product where Name like '" + input + "%';";
            SqlCommand filterproducts = new SqlCommand(query, conn);

            using (SqlDataReader reader = filterproducts.ExecuteReader())
            {
                while (reader.Read())
                {
                    string productname = reader.GetString(0);
                    string productcatagorie = reader.GetString(1);
                    decimal productprice = reader.GetDecimal(2);
                    if (productname.Length < 10 && productcatagorie.Length < 8)
                    {
                        Products.Add(productname + "\t" + "\t" + "\t" + productcatagorie + "\t" + "\t" + "\t" + "€" + productprice.ToString() + "," + "-");
                    }
                    else if (productname.Length > 11 && productcatagorie.ToString().Length >= 8)
                    {
                        Products.Add(productname + "\t" + "\t" + "\t" + productcatagorie + "\t" + "\t" + "€" + productprice.ToString() + "," + "-");
                    }
                    else if (productname.Length < 10 && productcatagorie.ToString().Length >= 8)
                    {
                        Products.Add(productname + "\t" + "\t" + "\t" + productcatagorie + "\t" + "\t" + "€" + productprice.ToString() + "," + "-");
                    }
                    else if (productname.Length > 9 && productcatagorie.ToString().Length < 8)
                    {
                        Products.Add(productname + "\t" + "\t" + "\t" + productcatagorie + "\t" + "\t" + "\t" + "€" + productprice.ToString() + "," + "-");
                    }
                }
            }
            conn.Close();
        }

        public void updateprice(string productname, decimal newprice)
        {
            conn.Open();
            string queryupdateprice = "update Product SET Price = " + newprice + " WHERE Name = '" + productname + "' ;";
            SqlCommand updatprice = new SqlCommand(queryupdateprice, conn);
            updatprice.BeginExecuteNonQuery();
            conn.Close();          
        }

    }
}
