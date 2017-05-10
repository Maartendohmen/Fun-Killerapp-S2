using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fun_Killerapp_S2
{
    public partial class Customer : Form
    {
        CustomerOverview customeroverview = new CustomerOverview();
        int customerid;
        public List<string> Cartproducts = new List<string>();

        public Customer(int customderID)
        {
            InitializeComponent();
            customerid = customderID;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            lbproducts.Items.Clear();
            lnboggedinas.Text = customeroverview.Getnaam(customerid);
            lbproducts.Items.AddRange(customeroverview.loadproducts());     
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            lbproducts.Items.Clear();
            lbproducts.Items.AddRange(customeroverview.searchproducts(tbsearch.Text));
        }

        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            string selecteditemandcatagory = lbproducts.SelectedItem.ToString();
            string selectedcatagory = selecteditemandcatagory.Substring(selecteditemandcatagory.IndexOf("\t"));
            string selecteditem = selecteditemandcatagory.Replace(selectedcatagory, "");
            Cartproducts.Add(selecteditem);
            lbProductsincart.Text = Cartproducts.Count.ToString();
        }

        private void btnclearcart_Click(object sender, EventArgs e)
        {
            Cartproducts.Clear();
            lbProductsincart.Text = Cartproducts.Count.ToString();
        }

        private void btnplaceorder_Click(object sender, EventArgs e)
        {
            customeroverview.placeorder(customerid, Cartproducts);
            MessageBox.Show("You're Order has been placed");
        }

        private void btnShowcart_Click(object sender, EventArgs e)
        {
            lbproducts.Items.Clear();
            lbproducts.Items.Add("The Products in you're car are:");
            lbproducts.Items.Add("");

            foreach (string product in Cartproducts)
            {
                lbproducts.Items.Add(product);
            }

            lbproducts.Items.Add("");
            lbproducts.Items.Add("Your total price is = " + customeroverview.Gettotalprice(Cartproducts));
        }


    }
}
