namespace Fun_Killerapp_S2.UI_Input_screens
{
    partial class Discountinput
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
            this.tbcomment = new System.Windows.Forms.TextBox();
            this.dtpenddate = new System.Windows.Forms.DateTimePicker();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.lbComment = new System.Windows.Forms.Label();
            this.lbenddate = new System.Windows.Forms.Label();
            this.lbamount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcomment
            // 
            this.tbcomment.Location = new System.Drawing.Point(103, 25);
            this.tbcomment.Name = "tbcomment";
            this.tbcomment.Size = new System.Drawing.Size(176, 20);
            this.tbcomment.TabIndex = 0;
            // 
            // dtpenddate
            // 
            this.dtpenddate.Location = new System.Drawing.Point(103, 80);
            this.dtpenddate.Name = "dtpenddate";
            this.dtpenddate.Size = new System.Drawing.Size(193, 20);
            this.dtpenddate.TabIndex = 1;
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(103, 126);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(63, 20);
            this.nudAmount.TabIndex = 2;
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(75, 188);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(129, 67);
            this.btnconfirm.TabIndex = 3;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // lbComment
            // 
            this.lbComment.AutoSize = true;
            this.lbComment.Location = new System.Drawing.Point(34, 32);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(54, 13);
            this.lbComment.TabIndex = 4;
            this.lbComment.Text = "Comment:";
            // 
            // lbenddate
            // 
            this.lbenddate.AutoSize = true;
            this.lbenddate.Location = new System.Drawing.Point(34, 87);
            this.lbenddate.Name = "lbenddate";
            this.lbenddate.Size = new System.Drawing.Size(55, 13);
            this.lbenddate.TabIndex = 5;
            this.lbenddate.Text = "End-Date:";
            // 
            // lbamount
            // 
            this.lbamount.AutoSize = true;
            this.lbamount.Location = new System.Drawing.Point(34, 133);
            this.lbamount.Name = "lbamount";
            this.lbamount.Size = new System.Drawing.Size(46, 13);
            this.lbamount.TabIndex = 6;
            this.lbamount.Text = "Amount:";
            // 
            // Discountinput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 279);
            this.Controls.Add(this.lbamount);
            this.Controls.Add(this.lbenddate);
            this.Controls.Add(this.lbComment);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.dtpenddate);
            this.Controls.Add(this.tbcomment);
            this.Name = "Discountinput";
            this.Text = "Discountinput";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbcomment;
        private System.Windows.Forms.DateTimePicker dtpenddate;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Label lbComment;
        private System.Windows.Forms.Label lbenddate;
        private System.Windows.Forms.Label lbamount;
    }
}