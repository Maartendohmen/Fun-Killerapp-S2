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
    public partial class Pricechange : Form
    {
        string productname;
        ProductContext productinfo = new ProductContext();
        public Pricechange(string Productname)
        {
            InitializeComponent();
             productname = Productname;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbinputpricechange.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tbinputpricechange.Text = tbinputpricechange.Text.Remove(tbinputpricechange.Text.Length - 1);
            }
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
