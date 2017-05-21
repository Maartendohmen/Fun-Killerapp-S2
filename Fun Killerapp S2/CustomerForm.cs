using Fun_Killerapp_S2.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace Fun_Killerapp_S2
{
    public partial class CustomerForm : Form
    {

        CustomerOverview customeroverview = new CustomerOverview();
        private Customer currentcustomer;
        private List<Product> shopcart = new List<Product>();

        public CustomerForm(object type_User)
        {
            InitializeComponent();
            currentcustomer = (Customer)type_User;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            lbloggedinas.Text = "You're logged in as: " + currentcustomer.Name;
            Showproducts(customeroverview.GetAllProducts());
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            Productsgridview.Rows.Clear();
            List<Product> filterlist = new List<Product>();
            foreach (Product p in customeroverview.GetAllProducts())
            {               
                if (p.Name.IndexOf(tbsearch.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    filterlist.Add(p);
                }
            }
            Showproducts(filterlist);
        }

        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            string nameproduct = (string)Productsgridview.SelectedRows[0].Cells[0].Value;
            foreach (Product p in customeroverview.GetAllProducts())
            {
                if (nameproduct == p.Name)
                {
                    Product added = p;
                    shopcart.Add(added);
                }
            }
            lbnumberofproducts.Text = "Number of products in cart : " + shopcart.Count();
        }

        private void btnclearcart_Click(object sender, EventArgs e)
        {
            shopcart.Clear();
            lbnumberofproducts.Text = "Number of products in cart : " + shopcart.Count();
        }

        private void btnplaceorder_Click(object sender, EventArgs e)
        {
            customeroverview.placeorder(shopcart, currentcustomer.CustomerID);
        }

        private void btnShowcart_Click(object sender, EventArgs e)
        {
            Productsgridview.Rows.Clear();
            Showproducts(shopcart);
            decimal totaalprijs = 0;
            foreach (Product p in shopcart)
            {
                totaalprijs = totaalprijs + p.Price;
            }
            Productsgridview.Rows.Add("Totaalprijs"," € " + totaalprijs + ",-", "-", "-");
        }
















        private void Showproducts(List<Product> products)
        {
            foreach (Product product in products)
            {
                Productsgridview.Rows.Add(product.Name, "€" + product.Price + ",-", product.Categorie, product.Amount);
            }
        }


    }
}
