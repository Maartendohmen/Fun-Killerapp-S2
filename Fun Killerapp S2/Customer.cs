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
        int customerid;
        List<string> Cartproducts = new List<string>();
        GetUserInfo getinfo = new GetUserInfo();
        GetProductInfo getproductinfo = new GetProductInfo();


        public Customer(int customderID)
        {
            InitializeComponent();
            customerid = customderID;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            lbproducts.Items.Clear();
            lnboggedinas.Text = "You're logged in as: " + getinfo.GetCustomername(customerid) + "";
            getproductinfo.Getallproducts();
            lbproducts.Items.AddRange(getproductinfo.Products.ToArray());      
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            lbproducts.Items.Clear();
            getproductinfo.seachproducts(tbsearch.Text);
            lbproducts.Items.AddRange(getproductinfo.Products.ToArray());
        }

        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            string selecteditemandcatagory = lbproducts.SelectedItem.ToString();
            string selectedcatagory = selecteditemandcatagory.Substring(selecteditemandcatagory.IndexOf("\t"));
            string selecteditem = selecteditemandcatagory.Replace(selectedcatagory, "");
           Cartproducts.Add(selecteditem);

        }
    }
}
