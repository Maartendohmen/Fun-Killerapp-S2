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
    public partial class CrewForm : Form
    {
        CrewOverview crewoverview = new CrewOverview();
        private Crew currentcrewmember;

        public CrewForm(object type_User)
        {
            InitializeComponent();
            currentcrewmember = (Crew)type_User;        
        }

        private void Crew_Load(object sender, EventArgs e)
        {
            lbLoggedinas.Text = "You're logged in as: " + currentcrewmember.Name;
            lblastloggedin.Text = "You last login was on: " + currentcrewmember.LasttimeLogin.ToString();
        }

        private void btnaddsupplier_Click(object sender, EventArgs e)
        {

        }

        private void btnpriceupdate_Click(object sender, EventArgs e)
        {

        }
    }
}
