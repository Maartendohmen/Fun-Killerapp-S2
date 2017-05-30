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
            this.btnaddDiscount = new System.Windows.Forms.Button();
            this.btnProductDiscount = new System.Windows.Forms.Button();
            this.Discountgridoverview = new System.Windows.Forms.DataGridView();
            this.DiscountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnremovediscount = new System.Windows.Forms.Button();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Ordersgridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderedProductsgridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Productsgridoverview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Discountgridoverview)).BeginInit();
            this.SuspendLayout();
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
            this.Ordersgridview.Location = new System.Drawing.Point(37, 410);
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
            this.OrderedProductsgridview.Location = new System.Drawing.Point(687, 396);
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
            this.ProductID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Tss,
            this.Discount});
            this.Productsgridoverview.Location = new System.Drawing.Point(593, 12);
            this.Productsgridoverview.MultiSelect = false;
            this.Productsgridoverview.Name = "Productsgridoverview";
            this.Productsgridoverview.ReadOnly = true;
            this.Productsgridoverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Productsgridoverview.Size = new System.Drawing.Size(622, 331);
            this.Productsgridoverview.TabIndex = 12;
            // 
            // btnaddDiscount
            // 
            this.btnaddDiscount.Location = new System.Drawing.Point(1349, 238);
            this.btnaddDiscount.Name = "btnaddDiscount";
            this.btnaddDiscount.Size = new System.Drawing.Size(204, 71);
            this.btnaddDiscount.TabIndex = 13;
            this.btnaddDiscount.Text = "Add new discount";
            this.btnaddDiscount.UseVisualStyleBackColor = true;
            this.btnaddDiscount.Click += new System.EventHandler(this.btnaddDiscount_Click);
            // 
            // btnProductDiscount
            // 
            this.btnProductDiscount.Location = new System.Drawing.Point(1349, 138);
            this.btnProductDiscount.Name = "btnProductDiscount";
            this.btnProductDiscount.Size = new System.Drawing.Size(204, 71);
            this.btnProductDiscount.TabIndex = 14;
            this.btnProductDiscount.Text = "Add product Discount";
            this.btnProductDiscount.UseVisualStyleBackColor = true;
            this.btnProductDiscount.Click += new System.EventHandler(this.btnProductDiscount_Click);
            // 
            // Discountgridoverview
            // 
            this.Discountgridoverview.AllowUserToAddRows = false;
            this.Discountgridoverview.AllowUserToDeleteRows = false;
            this.Discountgridoverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Discountgridoverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiscountID,
            this.Amount,
            this.EndDate,
            this.Comment});
            this.Discountgridoverview.Location = new System.Drawing.Point(53, 25);
            this.Discountgridoverview.MultiSelect = false;
            this.Discountgridoverview.Name = "Discountgridoverview";
            this.Discountgridoverview.ReadOnly = true;
            this.Discountgridoverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Discountgridoverview.Size = new System.Drawing.Size(444, 331);
            this.Discountgridoverview.TabIndex = 15;
            // 
            // DiscountID
            // 
            this.DiscountID.HeaderText = "DiscountID";
            this.DiscountID.Name = "DiscountID";
            this.DiscountID.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "End-Date";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            // 
            // btnremovediscount
            // 
            this.btnremovediscount.Location = new System.Drawing.Point(1349, 333);
            this.btnremovediscount.Name = "btnremovediscount";
            this.btnremovediscount.Size = new System.Drawing.Size(204, 71);
            this.btnremovediscount.TabIndex = 16;
            this.btnremovediscount.Text = "Remove Discount";
            this.btnremovediscount.UseVisualStyleBackColor = true;
            this.btnremovediscount.Click += new System.EventHandler(this.btnremovediscount_Click);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
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
            // Tss
            // 
            this.Tss.HeaderText = "Stock";
            this.Tss.Name = "Tss";
            this.Tss.ReadOnly = true;
            this.Tss.Width = 78;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // CrewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 821);
            this.Controls.Add(this.btnremovediscount);
            this.Controls.Add(this.Discountgridoverview);
            this.Controls.Add(this.btnProductDiscount);
            this.Controls.Add(this.btnaddDiscount);
            this.Controls.Add(this.Productsgridoverview);
            this.Controls.Add(this.OrderedProductsgridview);
            this.Controls.Add(this.Ordersgridview);
            this.Controls.Add(this.lblastloggedin);
            this.Controls.Add(this.lbLoggedinas);
            this.Name = "CrewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Crew";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrewForm_FormClosing);
            this.Load += new System.EventHandler(this.Crew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ordersgridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderedProductsgridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Productsgridoverview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Discountgridoverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btnaddDiscount;
        private System.Windows.Forms.Button btnProductDiscount;
        private System.Windows.Forms.DataGridView Discountgridoverview;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.Button btnremovediscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tss;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
    }
}