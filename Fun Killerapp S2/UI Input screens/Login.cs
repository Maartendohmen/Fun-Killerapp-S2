using Fun_Killerapp_S2.Object;
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
        CustomerOverview customeroverview = new CustomerOverview();
        CrewOverview crewoverview = new CrewOverview();

        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            object type_user = customeroverview.GetCurrentUser(tbUsername.Text, tbPassword.Text);
            if (type_user is Customer)
            {
                CustomerForm customerform = new CustomerForm(type_user);
                customerform.Show();
                this.Hide();
            }
            else if (type_user is Crew)
            {
                CrewForm crewform = new CrewForm(type_user);
                crewform.Show();
                this.Hide();
            }

        }

    }
}
 
 



