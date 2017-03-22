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
            this.SuspendLayout();
            // 
            // lnboggedinas
            // 
            this.lnboggedinas.AutoSize = true;
            this.lnboggedinas.Location = new System.Drawing.Point(553, 23);
            this.lnboggedinas.Name = "lnboggedinas";
            this.lnboggedinas.Size = new System.Drawing.Size(35, 13);
            this.lnboggedinas.TabIndex = 0;
            this.lnboggedinas.Text = "label1";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 445);
            this.Controls.Add(this.lnboggedinas);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lnboggedinas;
    }
}