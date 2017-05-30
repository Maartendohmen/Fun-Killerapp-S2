using Fun_Killerapp_S2.DAL.Interface;
using Fun_Killerapp_S2.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.DAL.Context
{
    class DiscountContext : Connectionstring,IDiscounts
    {
        public List<object> GetAll()
        {
            List<Discount> discounts = new List<Discount>();
            conn.Open();
            string getallDiscounts = "SELECT DiscountID,Amount,date,Comment FROM Discount;";
            SqlCommand GetAllDiscounts = new SqlCommand(getallDiscounts, conn);

            using (SqlDataReader reader = GetAllDiscounts.ExecuteReader())
            {
                while (reader.Read())
                {
                        discounts.Add(new Discount(Convert.ToInt32(reader["DiscountID"]), Convert.ToInt32(reader["Amount"]), DateTime.Parse(reader["Date"].ToString()), reader["Comment"].ToString()));
                }
            }
            conn.Close();
            return discounts.Cast<object>().ToList();
        }

        public object GetOne(int discountid)
        {
            conn.Open();
            string getdiscount = "SELECT DiscountID,Amount,date,Comment FROM Discount WHERE DiscountID = @id;";
            SqlCommand GetDiscount = new SqlCommand(getdiscount, conn);
            GetDiscount.Parameters.AddWithValue("id", discountid);

            using (SqlDataReader reader = GetDiscount.ExecuteReader())
            {
                while (reader.Read())
                {
                    Discount toadd = new Discount(Convert.ToInt32(reader["DiscountID"]), Convert.ToInt32(reader["Amount"]), DateTime.Parse(reader["Date"].ToString()), reader["Comment"].ToString());
                    conn.Close();
                    return toadd;
                }
            }
            conn.Close();
            return null;
        }

        public void Save(int amount, DateTime ending, string comment, List<object> Discountedproducts)
        {
            conn.Open();
            string savediscountprocedure = "Discounts";
            SqlCommand SaveDiscount = new SqlCommand(savediscountprocedure, conn);
            SaveDiscount.CommandType = CommandType.StoredProcedure;

            DataTable datatabel = new DataTable();
            datatabel.Columns.Add("ProductID");

            foreach (Product product in Discountedproducts)
            {
                datatabel.Rows.Add(product.ProductID);
            }
            //need to add all the parameters
            SqlParameter Givelist = new SqlParameter();
            Givelist.ParameterName = "@List";
            Givelist.Value = datatabel;


            SaveDiscount.Parameters.Add(Givelist);
            SaveDiscount.Parameters.AddWithValue("amount", amount);
            SaveDiscount.Parameters.AddWithValue("date", ending);
            SaveDiscount.Parameters.AddWithValue("comment", comment);
            SaveDiscount.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(int discountID)
        {
            string deletediscounts = "DeleteDiscount";
            SqlCommand DeleteDiscount = new SqlCommand(deletediscounts, conn);
            DeleteDiscount.CommandType = CommandType.StoredProcedure;
            DeleteDiscount.Parameters.AddWithValue("DiscountID", discountID);
            conn.Open();
            DeleteDiscount.ExecuteNonQuery();
            conn.Close();
        }
    }
}
