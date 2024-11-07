namespace Final_Project_for_Studio_2
{
    partial class Form5
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

        private void InitializeComponent()
        {
            this.btnContinueShopping = new System.Windows.Forms.Button();
            this.btnClearTrolley = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblTrolleyStatus = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnContinueShopping
            // 
            this.btnContinueShopping.Location = new System.Drawing.Point(50, 250);
            this.btnContinueShopping.Name = "btnContinueShopping";
            this.btnContinueShopping.Size = new System.Drawing.Size(150, 40);
            this.btnContinueShopping.TabIndex = 0;
            this.btnContinueShopping.Text = "Continue Shopping";
            this.btnContinueShopping.UseVisualStyleBackColor = true;
            this.btnContinueShopping.Click += new System.EventHandler(this.btnContinueShopping_Click);
            // 
            // btnClearTrolley
            // 
            this.btnClearTrolley.Location = new System.Drawing.Point(50, 300);
            this.btnClearTrolley.Name = "btnClearTrolley";
            this.btnClearTrolley.Size = new System.Drawing.Size(150, 40);
            this.btnClearTrolley.TabIndex = 1;
            this.btnClearTrolley.Text = "Clear Trolley";
            this.btnClearTrolley.UseVisualStyleBackColor = true;
            this.btnClearTrolley.Click += new System.EventHandler(this.btnClearTrolley_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(50, 350);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(150, 40);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblTrolleyStatus
            // 
            this.lblTrolleyStatus.AutoSize = true;
            this.lblTrolleyStatus.Location = new System.Drawing.Point(50, 50);
            this.lblTrolleyStatus.Name = "lblTrolleyStatus";
            this.lblTrolleyStatus.Size = new System.Drawing.Size(109, 20);
            this.lblTrolleyStatus.TabIndex = 3;
            this.lblTrolleyStatus.Text = "Trolley Status:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(50, 100);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(77, 20);
            this.lblSubtotal.TabIndex = 4;
            this.lblSubtotal.Text = "Subtotal: ";
            // 
            // Form5
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblTrolleyStatus);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnClearTrolley);
            this.Controls.Add(this.btnContinueShopping);
            this.Name = "Form5";
            this.Text = "Shopping Cart";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinueShopping;
        private System.Windows.Forms.Button btnClearTrolley;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblTrolleyStatus;
        private System.Windows.Forms.Label lblSubtotal;
    }
}