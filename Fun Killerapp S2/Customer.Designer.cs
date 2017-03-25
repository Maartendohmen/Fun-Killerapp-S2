namespace Fun_Killerapp_S2
{
    partial class Customer
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
            this.lnboggedinas = new System.Windows.Forms.Label();
            this.lbproducts = new System.Windows.Forms.ListBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.btnaddtocart = new System.Windows.Forms.Button();
            this.btnclearcart = new System.Windows.Forms.Button();
            this.lbnumberofproducts = new System.Windows.Forms.Label();
            this.lbProductsincart = new System.Windows.Forms.Label();
            this.btnplaceorder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lnboggedinas
            // 
            this.lnboggedinas.AutoSize = true;
            this.lnboggedinas.Location = new System.Drawing.Point(553, 23);
            this.lnboggedinas.Name = "lnboggedinas";
            this.lnboggedinas.Size = new System.Drawing.Size(63, 13);
            this.lnboggedinas.TabIndex = 0;
            this.lnboggedinas.Text = "!willchange!";
            // 
            // lbproducts
            // 
            this.lbproducts.FormattingEnabled = true;
            this.lbproducts.Location = new System.Drawing.Point(39, 76);
            this.lbproducts.Name = "lbproducts";
            this.lbproducts.Size = new System.Drawing.Size(416, 329);
            this.lbproducts.TabIndex = 1;
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
            this.btnaddtocart.Location = new System.Drawing.Point(479, 76);
            this.btnaddtocart.Name = "btnaddtocart";
            this.btnaddtocart.Size = new System.Drawing.Size(209, 26);
            this.btnaddtocart.TabIndex = 4;
            this.btnaddtocart.Text = "Add to cart";
            this.btnaddtocart.UseVisualStyleBackColor = true;
            this.btnaddtocart.Click += new System.EventHandler(this.btnaddtocart_Click);
            // 
            // btnclearcart
            // 
            this.btnclearcart.Location = new System.Drawing.Point(479, 122);
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
            this.lbnumberofproducts.Size = new System.Drawing.Size(135, 13);
            this.lbnumberofproducts.TabIndex = 6;
            this.lbnumberofproducts.Text = "Number of products in cart:";
            // 
            // lbProductsincart
            // 
            this.lbProductsincart.AutoSize = true;
            this.lbProductsincart.Location = new System.Drawing.Point(180, 419);
            this.lbProductsincart.Name = "lbProductsincart";
            this.lbProductsincart.Size = new System.Drawing.Size(13, 13);
            this.lbProductsincart.TabIndex = 7;
            this.lbProductsincart.Text = "0";
            // 
            // btnplaceorder
            // 
            this.btnplaceorder.Location = new System.Drawing.Point(479, 379);
            this.btnplaceorder.Name = "btnplaceorder";
            this.btnplaceorder.Size = new System.Drawing.Size(209, 26);
            this.btnplaceorder.TabIndex = 8;
            this.btnplaceorder.Text = "Place order";
            this.btnplaceorder.UseVisualStyleBackColor = true;
            this.btnplaceorder.Click += new System.EventHandler(this.btnplaceorder_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 445);
            this.Controls.Add(this.btnplaceorder);
            this.Controls.Add(this.lbProductsincart);
            this.Controls.Add(this.lbnumberofproducts);
            this.Controls.Add(this.btnclearcart);
            this.Controls.Add(this.btnaddtocart);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.lbproducts);
            this.Controls.Add(this.lnboggedinas);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lnboggedinas;
        private System.Windows.Forms.ListBox lbproducts;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Button btnaddtocart;
        private System.Windows.Forms.Button btnclearcart;
        private System.Windows.Forms.Label lbnumberofproducts;
        private System.Windows.Forms.Label lbProductsincart;
        private System.Windows.Forms.Button btnplaceorder;
    }
}