﻿namespace Fun_Killerapp_S2
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
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 445);
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
    }
}