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
        ProductInfo getproductinfo = new ProductInfo();
        OrderInfo orderinfo = new OrderInfo();
        SupplierInfo supplierinfo = new SupplierInfo();
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
            supplierinfo.Getallallsupliers();
            lbsuppliers.Items.AddRange(supplierinfo.Suppliers.ToArray());   
        }

        private void btnaddsupplier_Click(object sender, EventArgs e)
        {
            Supplierinput supplierinput = new Supplierinput();
            supplierinput.ShowDialog();
            lbsuppliers.Items.Clear();
            supplierinfo.Suppliers.Clear();
            supplierinfo.Getallallsupliers();
            lbsuppliers.Items.AddRange(supplierinfo.Suppliers.ToArray());
        }
    }
}
