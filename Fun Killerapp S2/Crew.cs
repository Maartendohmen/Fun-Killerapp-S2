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
    public partial class Crew : Form
    {
        CrewOverview crewoverview = new CrewOverview();
        public Crew()
        {
            InitializeComponent();          
        }

        private void Crew_Load(object sender, EventArgs e)
        {
            lbproducts.Items.Clear();           
            lbproducts.Items.AddRange(crewoverview.loadproducts());            
            lbOrders.Items.AddRange(crewoverview.loadorders());            
            lbsuppliers.Items.AddRange(crewoverview.loadsuppliers());   
        }

        private void btnaddsupplier_Click(object sender, EventArgs e)
        {
            Supplierinput supplierinput = new Supplierinput();
            supplierinput.ShowDialog();
            lbsuppliers.Items.Clear();
            crewoverview.clearsupplierslist();
            lbsuppliers.Items.AddRange(crewoverview.loadsuppliers());
        }

        private void btnpriceupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string currentselected = lbproducts.SelectedItem.ToString();
                string notselectedproductname = currentselected.Substring(currentselected.IndexOf("\t"));
                string result = currentselected.Replace(notselectedproductname, "");
                Pricechange pricechange = new Pricechange(result);
                pricechange.ShowDialog();
                lbproducts.Items.Clear();
                crewoverview.clearproductlist();
                lbproducts.Items.AddRange(crewoverview.loadproducts());
            }
            catch
            {
                MessageBox.Show("Please select a product to update the price");
            }
        }
    }
}
