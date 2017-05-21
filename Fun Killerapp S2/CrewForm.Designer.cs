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
            this.btnaddsupplier = new System.Windows.Forms.Button();
            this.btnpriceupdate = new System.Windows.Forms.Button();
            this.lbsuppliers = new System.Windows.Forms.ListBox();
            this.lbLoggedinas = new System.Windows.Forms.Label();
            this.lblastloggedin = new System.Windows.Forms.Label();
            this.Ordersgridview = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Ordersgridview)).BeginInit();
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
            // btnaddsupplier
            // 
            this.btnaddsupplier.Location = new System.Drawing.Point(1349, 416);
            this.btnaddsupplier.Name = "btnaddsupplier";
            this.btnaddsupplier.Size = new System.Drawing.Size(201, 32);
            this.btnaddsupplier.TabIndex = 5;
            this.btnaddsupplier.Text = "Add supplier";
            this.btnaddsupplier.UseVisualStyleBackColor = true;
            this.btnaddsupplier.Click += new System.EventHandler(this.btnaddsupplier_Click);
            // 
            // btnpriceupdate
            // 
            this.btnpriceupdate.Location = new System.Drawing.Point(1349, 492);
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
            this.lbsuppliers.Location = new System.Drawing.Point(682, 25);
            this.lbsuppliers.Name = "lbsuppliers";
            this.lbsuppliers.Size = new System.Drawing.Size(641, 316);
            this.lbsuppliers.TabIndex = 4;
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
            this.Ordersgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ordersgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.Customer,
            this.DateOrdered,
            this.Status,
            this.TotalPrice});
            this.Ordersgridview.Location = new System.Drawing.Point(56, 482);
            this.Ordersgridview.Name = "Ordersgridview";
            this.Ordersgridview.Size = new System.Drawing.Size(545, 279);
            this.Ordersgridview.TabIndex = 9;
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.Name = "OrderID";
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            // 
            // DateOrdered
            // 
            this.DateOrdered.HeaderText = "DateOrdered";
            this.DateOrdered.Name = "DateOrdered";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // CrewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 821);
            this.Controls.Add(this.Ordersgridview);
            this.Controls.Add(this.lblastloggedin);
            this.Controls.Add(this.lbLoggedinas);
            this.Controls.Add(this.btnpriceupdate);
            this.Controls.Add(this.btnaddsupplier);
            this.Controls.Add(this.lbsuppliers);
            this.Controls.Add(this.lbproducts);
            this.Name = "CrewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Crew";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrewForm_FormClosing);
            this.Load += new System.EventHandler(this.Crew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ordersgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbproducts;
        private System.Windows.Forms.Button btnaddsupplier;
        private System.Windows.Forms.Button btnpriceupdate;
        private System.Windows.Forms.ListBox lbsuppliers;
        private System.Windows.Forms.Label lbLoggedinas;
        private System.Windows.Forms.Label lblastloggedin;
        private System.Windows.Forms.DataGridView Ordersgridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}