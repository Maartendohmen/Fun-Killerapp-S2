using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fun_Killerapp_S2.UI_Input_screens
{
    public partial class Discountinput : Form
    {
        CrewOverview crewoverview = new CrewOverview();
        List<Product> neededproducts;
        public Discountinput(List<Product> Neededproducts)
        {
            InitializeComponent();
            this.neededproducts = Neededproducts;
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            crewoverview.SaveDiscounts(Convert.ToInt32(nudAmount.Value), dtpenddate.Value, tbcomment.Text, neededproducts);
        }
    }
}
