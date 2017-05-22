namespace Fun_Killerapp_S2
{
    partial class CrewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbproducts = new System.Windows.Forms.ListBox();
            this.lbLoggedinas = new System.Windows.Forms.Label();
            this.lblastloggedin = new System.Windows.Forms.Label();
            this.Ordersgridview = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderedProductsgridview = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productsgridoverview = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnaddDiscount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ordersgridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderedProductsgridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Productsgridoverview)).BeginInit();
            this.SuspendLayout();
            // 
            // lbproducts
            // 
            this.lbproducts.FormattingEnabled = true;
            this.lbproducts.Location = new System.Drawing.Point(12, 25);
            this.lbproducts.Name = "lbproducts";
            this.lbproducts.Size = new System.Drawing.Size(631, 316);
            this.lbproducts.TabIndex = 2;
            // 
            // lbLoggedinas
            // 
            this.lbLoggedinas.AutoSize = true;
            this.lbLoggedinas.Location = new System.Drawing.Point(1346, 35);
            this.lbLoggedinas.Name = "lbLoggedinas";
            this.lbLoggedinas.Size = new System.Drawing.Size(100, 13);
            this.lbLoggedinas.TabIndex = 7;
            this.lbLoggedinas.Text = "You\'re logged in as:";
            // 
            // lblastloggedin
            // 
            this.lblastloggedin.AutoSize = true;
            this.lblastloggedin.Location = new System.Drawing.Point(1346, 78);
            this.lblastloggedin.Name = "lblastloggedin";
            this.lblastloggedin.Size = new System.Drawing.Size(76, 13);
            this.lblastloggedin.TabIndex = 8;
            this.lblastloggedin.Text = "Last logged in:";
            // 
            // Ordersgridview
            // 
            this.Ordersgridview.AllowUserToAddRows = false;
            this.Ordersgridview.AllowUserToDeleteRows = false;
            this.Ordersgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ordersgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.Customer,
            this.DateOrdered,
            this.Status,
            this.TotalPrice});
            this.Ordersgridview.Location = new System.Drawing.Point(24, 387);
            this.Ordersgridview.MultiSelect = false;
            this.Ordersgridview.Name = "Ordersgridview";
            this.Ordersgridview.ReadOnly = true;
            this.Ordersgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Ordersgridview.Size = new System.Drawing.Size(561, 317);
            this.Ordersgridview.TabIndex = 9;
            this.Ordersgridview.Click += new System.EventHandler(this.Ordersgridview_Click);
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // DateOrdered
            // 
            this.DateOrdered.HeaderText = "DateOrdered";
            this.DateOrdered.Name = "DateOrdered";
            this.DateOrdered.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // OrderedProductsgridview
            // 
            this.OrderedProductsgridview.AllowUserToAddRows = false;
            this.OrderedProductsgridview.AllowUserToDeleteRows = false;
            this.OrderedProductsgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderedProductsgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Price,
            this.categorie,
            this.Stock});
            this.OrderedProductsgridview.Location = new System.Drawing.Point(642, 373);
            this.OrderedProductsgridview.MultiSelect = false;
            this.OrderedProductsgridview.Name = "OrderedProductsgridview";
            this.OrderedProductsgridview.ReadOnly = true;
            this.OrderedProductsgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderedProductsgridview.Size = new System.Drawing.Size(422, 331);
            this.OrderedProductsgridview.TabIndex = 11;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // categorie
            // 
            this.categorie.HeaderText = "Categorie";
            this.categorie.Name = "categorie";
            this.categorie.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 78;
            // 
            // Productsgridoverview
            // 
            this.Productsgridoverview.AllowUserToAddRows = false;
            this.Productsgridoverview.AllowUserToDeleteRows = false;
            this.Productsgridoverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Productsgridoverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.Productsgridoverview.Location = new System.Drawing.Point(682, 25);
            this.Productsgridoverview.MultiSelect = false;
            this.Productsgridoverview.Name = "Productsgridoverview";
            this.Productsgridoverview.ReadOnly = true;
            this.Productsgridoverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Productsgridoverview.Size = new System.Drawing.Size(422, 331);
            this.Productsgridoverview.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Price";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Categorie";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Stock";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 78;
            // 
            // btnaddDiscount
            // 
            this.btnaddDiscount.Location = new System.Drawing.Point(1359, 130);
            this.btnaddDiscount.Name = "btnaddDiscount";
            this.btnaddDiscount.Size = new System.Drawing.Size(204, 71);
            this.btnaddDiscount.TabIndex = 13;
            this.btnaddDiscount.Text = "Add new discount";
            this.btnaddDiscount.UseVisualStyleBackColor = true;
            this.btnaddDiscount.Click += new System.EventHandler(this.btnaddDiscount_Click);
            // 
            // CrewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 821);
            this.Controls.Add(this.btnaddDiscount);
            this.Controls.Add(this.Productsgridoverview);
            this.Controls.Add(this.OrderedProductsgridview);
            this.Controls.Add(this.Ordersgridview);
            this.Controls.Add(this.lblastloggedin);
            this.Controls.Add(this.lbLoggedinas);
            this.Controls.Add(this.lbproducts);
            this.Name = "CrewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Crew";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrewForm_FormClosing);
            this.Load += new System.EventHandler(this.Crew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ordersgridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderedProductsgridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Productsgridoverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbproducts;
        private System.Windows.Forms.Label lbLoggedinas;
        private System.Windows.Forms.Label lblastloggedin;
        private System.Windows.Forms.DataGridView Ordersgridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridView OrderedProductsgridview;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridView Productsgridoverview;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnaddDiscount;
    }
}