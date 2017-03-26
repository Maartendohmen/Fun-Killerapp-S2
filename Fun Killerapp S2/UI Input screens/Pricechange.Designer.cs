namespace Fun_Killerapp_S2
{
    partial class Pricechange
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
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbinputpricechange = new System.Windows.Forms.TextBox();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(26, 34);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(34, 13);
            this.lbPrice.TabIndex = 0;
            this.lbPrice.Text = "Price:";
            // 
            // tbinputpricechange
            // 
            this.tbinputpricechange.Location = new System.Drawing.Point(107, 31);
            this.tbinputpricechange.Name = "tbinputpricechange";
            this.tbinputpricechange.Size = new System.Drawing.Size(123, 20);
            this.tbinputpricechange.TabIndex = 1;
            this.tbinputpricechange.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(107, 94);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(80, 25);
            this.btnconfirm.TabIndex = 2;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // Pricechange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 147);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.tbinputpricechange);
            this.Controls.Add(this.lbPrice);
            this.Name = "Pricechange";
            this.Text = "Pricechange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox tbinputpricechange;
        private System.Windows.Forms.Button btnconfirm;
    }
}