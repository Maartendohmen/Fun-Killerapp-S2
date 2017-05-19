using Fun_Killerapp_S2.DAL;
using Fun_Killerapp_S2.DAL.Interface;
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
            List < Supplier > Supliers = allsuppliers.Cast<Supplier>().ToList();
            List<Discount> Discounts = alldiscounts.Cast<Discount>().ToList();

            List<Product> products = new List<Product>();
            List<Discount> discounts = new List<Discount>();            
            Supplier productsupplier = new Supplier(-1,"","");
            Productsoort productsoort = Productsoort.Boeken;

            string querygetallproducts = "SELECT ProductID, SupplierID, Price,Name,Catagorie,Amount FROM Product";
            SqlCommand Getallproducts = new SqlCommand(querygetallproducts, conn);

            using (SqlDataReader reader = Getallproducts.ExecuteReader())
            {
                while (reader.Read())
                {
                    foreach (Supplier sup in Supliers)
                    {
                        if (sup.SupplierID == Convert.ToInt32(reader["SupplierID"]))
                        {
                            productsupplier = sup;
                        }
                    }

                    if (reader["Catagorie"].ToString() == "Schoenen")
                    {
                        productsoort = Productsoort.Schoenen;
                    }
                    else if (reader["Catagorie"].ToString() == "Camera")
                    {
                        productsoort = Productsoort.Camera;
                    }
                    else if (reader["Catagorie"].ToString() == "Spellen")
                    {
                        productsoort = Productsoort.Spellen;
                    }
                    else if (reader["Catagorie"].ToString() == "Boeken")
                    {
                        productsoort = Productsoort.Boeken;
                    }
                    else if (reader["Catagorie"].ToString() == "Voeding")
                    {
                        productsoort = Productsoort.Voeding;
                    }
                    products.Add(new Product(Convert.ToInt32(reader["ProductID"]), productsupplier, discounts, Convert.ToDecimal(reader["Price"]), reader["Name"].ToString(), productsoort, Convert.ToInt32(reader["Amount"])));
                }
            }
            conn.Close();
            return products.Cast<object>().ToList();
        }

        public object GetOne(int id, List<object> allsuppliers, List<object> alldiscounts)
        {
            List<Supplier> Suppliers = allsuppliers.Cast<Supplier>().ToList();
            List<Discount> Discounts = alldiscounts.Cast<Discount>().ToList();

            string getoneproductquery = "SELECT ProductID, SupplierID, DiscountID, Price,Name,Catagorie,Amount FROM Product WHERE ProductID = @id";
            SqlCommand GetOneProduct = new SqlCommand(getoneproductquery, conn);
            GetOneProduct.Parameters.AddWithValue("id", id);
            List<Discount> discounts = new List<Discount>();
            Supplier productsupplier = new Supplier(-1, "", "");
            Productsoort productsoort = Productsoort.Boeken;

            using (SqlDataReader reader =GetOneProduct.ExecuteReader())
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

                    if (reader["Catagorie"].ToString() == "Schoenen")
                    {
                        productsoort = Productsoort.Schoenen;
                    }
                    else if (reader["Catagorie"].ToString() == "Camera")
                    {
                        productsoort = Productsoort.Camera;
                    }
                    else if (reader["Catagorie"].ToString() == "Spellen")
                    {
                        productsoort = Productsoort.Spellen;
                    }
                    else if (reader["Catagorie"].ToString() == "Boeken")
                    {
                        productsoort = Productsoort.Boeken;
                    }
                    else if (reader["Catagorie"].ToString() == "Voeding")
                    {
                        productsoort = Productsoort.Voeding;
                    }

                    Product toadd = new Product(Convert.ToInt32(reader["ProductID"]), productsupplier, discounts, Convert.ToDecimal(reader["Price"]), reader["Name"].ToString(), productsoort, Convert.ToInt32(reader["Amount"]));
                    return toadd;
                }
            }
            return null;
        }
    }
}
