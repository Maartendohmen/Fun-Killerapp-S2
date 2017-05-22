﻿using Fun_Killerapp_S2.Object;
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
            this.Location = new Point(0, 0);
            currentcrewmember = (Crew)type_User;        
        }

        private void Crew_Load(object sender, EventArgs e)
        {
            lbLoggedinas.Text = "You're logged in as: " + currentcrewmember.Name;
            lblastloggedin.Text = "You last login was on: " + currentcrewmember.LasttimeLogin.ToString();
            Showorders(crewoverview.GetAllOrders());
            Showproducts(crewoverview.GetAllProducts());
        }


        private void CrewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            crewoverview.Savelasttimelogin(DateTime.Now, currentcrewmember.CrewID);
        }

        private void Ordersgridview_Click(object sender, EventArgs e)
        {
            int orderid = (int)Ordersgridview.SelectedRows[0].Cells[0].Value;
            Order AskedOrdered = crewoverview.GetOneOrder(orderid);
            OrderedProductsgridview.Rows.Clear();

            foreach (Product p in AskedOrdered.Products)
            {
                OrderedProductsgridview.Rows.Add(p.Name, "€" + p.Price + ",-", p.Categorie, p.Amount);
            }
        }

        private void Showorders(List<Order> Orders)
        {
            foreach (Order order in Orders)
            {
                Ordersgridview.Rows.Add(order.OrderID, order.Customer.Name, order.Dateordered, order.Status, "€ " + order.Totalprice + ",-");
            }
        }

        private void Showproducts(List<Product> products)
        {
            foreach (Product product in products)
            {
                Productsgridoverview.Rows.Add(product.Name, "€" + product.Price + ",-", product.Categorie, product.Amount);
            }
        }

        private void btnaddDiscount_Click(object sender, EventArgs e)
        {
            if 
        }
    }
}
