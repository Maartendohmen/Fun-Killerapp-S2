namespace Fun_Killerapp_S2
{
    partial class Supplierinput
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
            this.lbsuppliername = new System.Windows.Forms.Label();
            this.lbsupplierlocation = new System.Windows.Forms.Label();
            this.tbsuppliername = new System.Windows.Forms.TextBox();
            this.tbsupplierlocation = new System.Windows.Forms.TextBox();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbsuppliername
            // 
            this.lbsuppliername.AutoSize = true;
            this.lbsuppliername.Location = new System.Drawing.Point(32, 37);
            this.lbsuppliername.Name = "lbsuppliername";
            this.lbsuppliername.Size = new System.Drawing.Size(38, 13);
            this.lbsuppliername.TabIndex = 0;
            this.lbsuppliername.Text = "Name:";
            // 
            // lbsupplierlocation
            // 
            this.lbsupplierlocation.AutoSize = true;
            this.lbsupplierlocation.Location = new System.Drawing.Point(32, 102);
            this.lbsupplierlocation.Name = "lbsupplierlocation";
            this.lbsupplierlocation.Size = new System.Drawing.Size(51, 13);
            this.lbsupplierlocation.TabIndex = 1;
            this.lbsupplierlocation.Text = "Location:";
            // 
            // tbsuppliername
            // 
            this.tbsuppliername.Location = new System.Drawing.Point(134, 34);
            this.tbsuppliername.Name = "tbsuppliername";
            this.tbsuppliername.Size = new System.Drawing.Size(212, 20);
            this.tbsuppliername.TabIndex = 2;
            // 
            // tbsupplierlocation
            // 
            this.tbsupplierlocation.Location = new System.Drawing.Point(134, 95);
            this.tbsupplierlocation.Name = "tbsupplierlocation";
            this.tbsupplierlocation.Size = new System.Drawing.Size(212, 20);
            this.tbsupplierlocation.TabIndex = 3;
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(151, 144);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(179, 38);
            this.btnconfirm.TabIndex = 4;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // Supplierinput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 194);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.tbsupplierlocation);
            this.Controls.Add(this.tbsuppliername);
            this.Controls.Add(this.lbsupplierlocation);
            this.Controls.Add(this.lbsuppliername);
            this.Name = "Supplierinput";
            this.Text = "Supplier-input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbsuppliername;
        private System.Windows.Forms.Label lbsupplierlocation;
        private System.Windows.Forms.TextBox tbsuppliername;
        private System.Windows.Forms.TextBox tbsupplierlocation;
        private System.Windows.Forms.Button btnconfirm;
    }
}