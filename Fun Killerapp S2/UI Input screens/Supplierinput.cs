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
    public partial class Supplierinput : Form
    {
        SupplierInfo supplierinfo = new SupplierInfo();
        public Supplierinput()
        {
            InitializeComponent();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            supplierinfo.Addsupplier(tbsuppliername.Text, tbsupplierlocation.Text);
            this.Close();
        }
    }
}
