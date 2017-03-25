using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fun_Killerapp_S2
{
    public partial class frmlogin : Form
    {
      GetUserInfo getuserinfo = new GetUserInfo();
      public int CrewmemberID;
      public int customerID;

       public bool crewmember = false;

        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            if (chbCrewmember.Checked == true)
            {
                crewmember = true;
                int CrewmemberID = getuserinfo.getID(crewmember, tbUsername.Text, tbPassword.Text);            
            }
            else
            {
                crewmember = false;
                int customerID = getuserinfo.getID(crewmember, tbUsername.Text, tbPassword.Text);
                confirmuser(customerID);
            }         
        }























        public void confirmuser(int customerID)
        {
            if (customerID == 10000000)
            {
                MessageBox.Show("Sorry, wrong username or password");
                tbPassword.Text = "";
            }
            else
            {
                Customer customer = new Customer(customerID);
                customer.Show();
            }
        }

    }
}
 
 



