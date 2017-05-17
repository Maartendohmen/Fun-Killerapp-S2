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
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.btnaddsupplier = new System.Windows.Forms.Button();
            this.btnpriceupdate = new System.Windows.Forms.Button();
            this.lbsuppliers = new System.Windows.Forms.ListBox();
            this.lbLoggedinas = new System.Windows.Forms.Label();
            this.lblastloggedin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbproducts
            // 
            this.lbproducts.FormattingEnabled = true;
            this.lbproducts.Location = new System.Drawing.Point(12, 12);
            this.lbproducts.Name = "lbproducts";
            this.lbproducts.Size = new System.Drawing.Size(540, 186);
            this.lbproducts.TabIndex = 2;
            // 
            // lbOrders
            // 
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.Location = new System.Drawing.Point(12, 220);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(540, 225);
            this.lbOrders.TabIndex = 3;
            // 
            // btnaddsupplier
            // 
            this.btnaddsupplier.Location = new System.Drawing.Point(858, 235);
            this.btnaddsupplier.Name = "btnaddsupplier";
            this.btnaddsupplier.Size = new System.Drawing.Size(201, 32);
            this.btnaddsupplier.TabIndex = 5;
            this.btnaddsupplier.Text = "Add supplier";
            this.btnaddsupplier.UseVisualStyleBackColor = true;
            this.btnaddsupplier.Click += new System.EventHandler(this.btnaddsupplier_Click);
            // 
            // btnpriceupdate
            // 
            this.btnpriceupdate.Location = new System.Drawing.Point(858, 301);
            this.btnpriceupdate.Name = "btnpriceupdate";
            this.btnpriceupdate.Size = new System.Drawing.Size(201, 32);
            this.btnpriceupdate.TabIndex = 6;
            this.btnpriceupdate.Text = "Update price";
            this.btnpriceupdate.UseVisualStyleBackColor = true;
            this.btnpriceupdate.Click += new System.EventHandler(this.btnpriceupdate_Click);
            // 
            // lbsuppliers
            // 
            this.lbsuppliers.FormattingEnabled = true;
            this.lbsuppliers.Location = new System.Drawing.Point(248, 161);
            this.lbsuppliers.Name = "lbsuppliers";
            this.lbsuppliers.Size = new System.Drawing.Size(501, 186);
            this.lbsuppliers.TabIndex = 4;
            // 
            // lbLoggedinas
            // 
            this.lbLoggedinas.AutoSize = true;
            this.lbLoggedinas.Location = new System.Drawing.Point(866, 25);
            this.lbLoggedinas.Name = "lbLoggedinas";
            this.lbLoggedinas.Size = new System.Drawing.Size(100, 13);
            this.lbLoggedinas.TabIndex = 7;
            this.lbLoggedinas.Text = "You\'re logged in as:";
            // 
            // lblastloggedin
            // 
            this.lblastloggedin.AutoSize = true;
            this.lblastloggedin.Location = new System.Drawing.Point(866, 57);
            this.lblastloggedin.Name = "lblastloggedin";
            this.lblastloggedin.Size = new System.Drawing.Size(76, 13);
            this.lblastloggedin.TabIndex = 8;
            this.lblastloggedin.Text = "Last logged in:";
            // 
            // CrewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 517);
            this.Controls.Add(this.lblastloggedin);
            this.Controls.Add(this.lbLoggedinas);
            this.Controls.Add(this.btnpriceupdate);
            this.Controls.Add(this.btnaddsupplier);
            this.Controls.Add(this.lbsuppliers);
            this.Controls.Add(this.lbOrders);
            this.Controls.Add(this.lbproducts);
            this.Name = "CrewForm";
            this.Text = "Crew";
            this.Load += new System.EventHandler(this.Crew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbproducts;
        private System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.Button btnaddsupplier;
        private System.Windows.Forms.Button btnpriceupdate;
        private System.Windows.Forms.ListBox lbsuppliers;
        private System.Windows.Forms.Label lbLoggedinas;
        private System.Windows.Forms.Label lblastloggedin;
    }
}