namespace Fun_Killerapp_S2
{
    partial class CustomerForm
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
            this.lbloggedinas = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.btnaddtocart = new System.Windows.Forms.Button();
            this.btnclearcart = new System.Windows.Forms.Button();
            this.lbnumberofproducts = new System.Windows.Forms.Label();
            this.btnplaceorder = new System.Windows.Forms.Button();
            this.btnShowcart = new System.Windows.Forms.Button();
            this.Productsgridview = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Productsgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // lbloggedinas
            // 
            this.lbloggedinas.AutoSize = true;
            this.lbloggedinas.Location = new System.Drawing.Point(553, 23);
            this.lbloggedinas.Name = "lbloggedinas";
            this.lbloggedinas.Size = new System.Drawing.Size(104, 13);
            this.lbloggedinas.TabIndex = 0;
            this.lbloggedinas.Text = "You\'re Logged in as:";
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(39, 26);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(44, 13);
            this.lbSearch.TabIndex = 2;
            this.lbSearch.Text = "Search:";
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(114, 23);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(341, 20);
            this.tbsearch.TabIndex = 3;
            this.tbsearch.TextChanged += new System.EventHandler(this.tbsearch_TextChanged);
            // 
            // btnaddtocart
            // 
            this.btnaddtocart.Location = new System.Drawing.Point(546, 63);
            this.btnaddtocart.Name = "btnaddtocart";
            this.btnaddtocart.Size = new System.Drawing.Size(209, 26);
            this.btnaddtocart.TabIndex = 4;
            this.btnaddtocart.Text = "Add to cart";
            this.btnaddtocart.UseVisualStyleBackColor = true;
            this.btnaddtocart.Click += new System.EventHandler(this.btnaddtocart_Click);
            // 
            // btnclearcart
            // 
            this.btnclearcart.Location = new System.Drawing.Point(546, 162);
            this.btnclearcart.Name = "btnclearcart";
            this.btnclearcart.Size = new System.Drawing.Size(209, 26);
            this.btnclearcart.TabIndex = 5;
            this.btnclearcart.Text = "Clear cart";
            this.btnclearcart.UseVisualStyleBackColor = true;
            this.btnclearcart.Click += new System.EventHandler(this.btnclearcart_Click);
            // 
            // lbnumberofproducts
            // 
            this.lbnumberofproducts.AutoSize = true;
            this.lbnumberofproducts.Location = new System.Drawing.Point(39, 419);
            this.lbnumberofproducts.Name = "lbnumberofproducts";
            this.lbnumberofproducts.Size = new System.Drawing.Size(144, 13);
            this.lbnumberofproducts.TabIndex = 6;
            this.lbnumberofproducts.Text = "Number of products in cart: 0";
            // 
            // btnplaceorder
            // 
            this.btnplaceorder.Location = new System.Drawing.Point(546, 366);
            this.btnplaceorder.Name = "btnplaceorder";
            this.btnplaceorder.Size = new System.Drawing.Size(209, 26);
            this.btnplaceorder.TabIndex = 8;
            this.btnplaceorder.Text = "Place order";
            this.btnplaceorder.UseVisualStyleBackColor = true;
            this.btnplaceorder.Click += new System.EventHandler(this.btnplaceorder_Click);
            // 
            // btnShowcart
            // 
            this.btnShowcart.Location = new System.Drawing.Point(546, 112);
            this.btnShowcart.Name = "btnShowcart";
            this.btnShowcart.Size = new System.Drawing.Size(209, 26);
            this.btnShowcart.TabIndex = 9;
            this.btnShowcart.Text = "Show Cart";
            this.btnShowcart.UseVisualStyleBackColor = true;
            this.btnShowcart.Click += new System.EventHandler(this.btnShowcart_Click);
            // 
            // Productsgridview
            // 
            this.Productsgridview.AllowUserToAddRows = false;
            this.Productsgridview.AllowUserToDeleteRows = false;
            this.Productsgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Productsgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Price,
            this.categorie,
            this.Stock,
            this.Discount});
            this.Productsgridview.Location = new System.Drawing.Point(12, 63);
            this.Productsgridview.MultiSelect = false;
            this.Productsgridview.Name = "Productsgridview";
            this.Productsgridview.ReadOnly = true;
            this.Productsgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Productsgridview.Size = new System.Drawing.Size(521, 331);
            this.Productsgridview.TabIndex = 10;
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
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 445);
            this.Controls.Add(this.Productsgridview);
            this.Controls.Add(this.btnShowcart);
            this.Controls.Add(this.btnplaceorder);
            this.Controls.Add(this.lbnumberofproducts);
            this.Controls.Add(this.btnclearcart);
            this.Controls.Add(this.btnaddtocart);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.lbloggedinas);
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Productsgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbloggedinas;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Button btnaddtocart;
        private System.Windows.Forms.Button btnclearcart;
        private System.Windows.Forms.Label lbnumberofproducts;
        private System.Windows.Forms.Button btnplaceorder;
        private System.Windows.Forms.Button btnShowcart;
        private System.Windows.Forms.DataGridView Productsgridview;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
    }
}