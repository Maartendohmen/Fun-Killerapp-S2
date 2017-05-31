using Fun_Killerapp_S2.DAL;
using Fun_Killerapp_S2.DAL.Context;
using Fun_Killerapp_S2.DAL.Interface;
using Fun_Killerapp_S2.DAL.Logic;
using Fun_Killerapp_S2.Object;
using Fun_Killerapp_S2.Object.Enum;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Fun_Killerapp_S2.Object.Enum.ProductCatagorie;

namespace Fun_Killerapp_S2
{
     class ProductContext : Connectionstring,IProduct
    {
        public List<object> GetAll(List<object> allsuppliers, List<object> alldiscounts)
        {
            conn.Open();

            List<Product> products = new List<Product>();            
            Supplier productsupplier = new Supplier(-1,"","");

            string querygetallproducts = "SELECT ProductID, SupplierID, Price,Name,Catagorie,Amount FROM Product";
            SqlCommand Getallproducts = new SqlCommand(querygetallproducts, conn);

            using (SqlDataReader reader = Getallproducts.ExecuteReader())
            {
                while (reader.Read())
                {
                    foreach (Supplier sup in allsuppliers)
                    {
                        if (sup.SupplierID == Convert.ToInt32(reader["SupplierID"]))
                        {
                            productsupplier = sup;
                        }
                    }
                    ProductCatagorie.Productsoort productsoort = (Productsoort)Enum.Parse(typeof(Productsoort), reader["Catagorie"].ToString(), true);
                    products.Add(new Product(Convert.ToInt32(reader["ProductID"]), productsupplier, Convert.ToDecimal(reader["Price"]), reader["Name"].ToString(), productsoort, Convert.ToInt32(reader["Amount"])));
                }
            }
            string adddiscounts = "SELECT Discount_Product.ProductID,Discount_Product.DiscountID from Discount_Product;";
            SqlCommand AddDiscounts = new SqlCommand(adddiscounts, conn);

            using (SqlDataReader reader = AddDiscounts.ExecuteReader())
            {
                while (reader.Read())
                {
                    foreach (Product testje in products)
                    {
                        if (testje.ProductID == Convert.ToInt32(reader["ProductID"]))
                        {
                            foreach (Discount dis in alldiscounts)
                            {
                                if (dis.DiscountID == Convert.ToInt32(reader["DiscountID"]))
                                {
                                    testje.Discount.Add(dis);
                                }
                            }
                        }
                    }
                }
            }

            conn.Close();
            return products.Cast<object>().ToList();
        }

        public object GetOne(int id, List<object> allsuppliers, List<object> alldiscounts)
        {
            Product toadd = new Product(-1, new Supplier(-1, "", ""), -2, "", Productsoort.Boeken, -1);
            string getoneproductquery = "SELECT ProductID, SupplierID, Price,Name,Catagorie,Amount FROM Product WHERE ProductID = @id";
            SqlCommand GetOneProduct = new SqlCommand(getoneproductquery, conn);
            GetOneProduct.Parameters.AddWithValue("id", id);
            Supplier productsupplier = new Supplier(-1, "", "");

            conn.Open();

            using (SqlDataReader reader = GetOneProduct.ExecuteReader())
            {
                while (reader.Read())
                {
                    foreach (Supplier sup in allsuppliers)
                    {
                        if (sup.SupplierID == Convert.ToInt32(reader["SupplierID"]))
                        {
                            productsupplier = sup;
                        }
                    }
                    ProductCatagorie.Productsoort productsoort = (Productsoort)Enum.Parse(typeof(Productsoort), reader["Catagorie"].ToString(), true);
                    toadd = new Product(Convert.ToInt32(reader["ProductID"]), productsupplier, Convert.ToDecimal(reader["Price"]), reader["Name"].ToString(), productsoort, Convert.ToInt32(reader["Amount"]));
                }
            }

            string adddiscounts = "SELECT Discount_Product.ProductID,Discount_Product.DiscountID from Discount_Product where ProductID = @id;";
            SqlCommand AddDiscounts = new SqlCommand(adddiscounts, conn);
            AddDiscounts.Parameters.AddWithValue("id", id);

            using (SqlDataReader reader = AddDiscounts.ExecuteReader())
            {
                while (reader.Read())
                {
                            foreach (Discount dis in alldiscounts)
                            {
                                if (dis.DiscountID == Convert.ToInt32(reader["DiscountID"]))
                                {
                                    toadd.Discount.Add(dis);
                                }
                            }
                 }
            }
            conn.Close();
            return toadd;
        }
    }
}
