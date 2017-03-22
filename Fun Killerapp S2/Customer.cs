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
        Getinfo getinfo = new Getinfo();


        public Customer(int customderID)
        {
            InitializeComponent();
            customerid = customderID;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            lbproducts.Items.Clear();
            lnboggedinas.Text = "You're logged in as: " + getinfo.GetCustomername(customerid) + "";
            getinfo.Getallproducts();
            lbproducts.Items.AddRange(getinfo.Products.ToArray());      
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            lbproducts.Items.Clear();
            getinfo.seachproducts(tbsearch.Text);
            lbproducts.Items.AddRange(getinfo.Products.ToArray());
        }
    }
}
