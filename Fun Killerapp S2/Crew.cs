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
        GetProductInfo getproductinfo = new GetProductInfo();
        OrderInfo orderinfo = new OrderInfo();
        public Crew()
        {
            InitializeComponent();
        }

        private void Crew_Load(object sender, EventArgs e)
        {
            lbproducts.Items.Clear();
            getproductinfo.Getallproducts();
            lbproducts.Items.AddRange(getproductinfo.Products.ToArray());
            orderinfo.Getorders();
            lbOrders.Items.AddRange(orderinfo.orders.ToArray());
            
        }
    }
}
