using Fun_Killerapp_S2.Object;
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
    public partial class CustomerForm : Form
    {

        CustomerOverview customeroverview = new CustomerOverview();
        private Customer currentcustomer;

        public CustomerForm(object type_User)
        {
            InitializeComponent();
            currentcustomer = (Customer)type_User;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
   
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnaddtocart_Click(object sender, EventArgs e)
        {

        }

        private void btnclearcart_Click(object sender, EventArgs e)
        {

        }

        private void btnplaceorder_Click(object sender, EventArgs e)
        {

        }

        private void btnShowcart_Click(object sender, EventArgs e)
        {

        }


    }
}
