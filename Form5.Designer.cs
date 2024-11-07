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
            this.lblDeliveryFee = new System.Windows.Forms.Label();
            this.lblEstimatedTotal = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // btnContinueShopping
            // 
            this.btnContinueShopping.Location = new System.Drawing.Point(50, 400);
            this.btnContinueShopping.Name = "btnContinueShopping";
            this.btnContinueShopping.Size = new System.Drawing.Size(180, 50);
            this.btnContinueShopping.TabIndex = 0;
            this.btnContinueShopping.Text = "Continue Shopping";
            this.btnContinueShopping.UseVisualStyleBackColor = true;
            this.btnContinueShopping.Click += new System.EventHandler(this.btnContinueShopping_Click);
            this.btnContinueShopping.BackColor = System.Drawing.Color.FromArgb(0, 123, 0); // Green

            // 
            // btnClearTrolley
            // 
            this.btnClearTrolley.Location = new System.Drawing.Point(250, 400);
            this.btnClearTrolley.Name = "btnClearTrolley";
            this.btnClearTrolley.Size = new System.Drawing.Size(180, 50);
            this.btnClearTrolley.TabIndex = 1;
            this.btnClearTrolley.Text = "Clear Trolley";
            this.btnClearTrolley.UseVisualStyleBackColor = true;
            this.btnClearTrolley.Click += new System.EventHandler(this.btnClearTrolley_Click);
            this.btnClearTrolley.BackColor = System.Drawing.Color.FromArgb(192, 0, 0); // Red

            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(450, 400);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(180, 50);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(0, 102, 204); // Blue

            // 
            // lblTrolleyStatus
            // 
            this.lblTrolleyStatus.AutoSize = true;
            this.lblTrolleyStatus.Location = new System.Drawing.Point(50, 30);
            this.lblTrolleyStatus.Name = "lblTrolleyStatus";
            this.lblTrolleyStatus.Size = new System.Drawing.Size(100, 20);
            this.lblTrolleyStatus.Text = "Trolley: No items";

            // 
            // lblDeliveryFee
            // 
            this.lblDeliveryFee.AutoSize = true;
            this.lblDeliveryFee.Location = new System.Drawing.Point(50, 80);
            this.lblDeliveryFee.Name = "lblDeliveryFee";
            this.lblDeliveryFee.Size = new System.Drawing.Size(100, 20);
            this.lblDeliveryFee.Text = "Delivery Fee: $14.00";

            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(50, 120);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(100, 20);
            this.lblSubtotal.Text = "Subtotal: $0.00";

            // 
            // lblEstimatedTotal
            // 
            this.lblEstimatedTotal.AutoSize = true;
            this.lblEstimatedTotal.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblEstimatedTotal.Location = new System.Drawing.Point(50, 160);
            this.lblEstimatedTotal.Name = "lblEstimatedTotal";
            this.lblEstimatedTotal.Size = new System.Drawing.Size(180, 30);
            this.lblEstimatedTotal.Text = "Estimated Total: $14.00";

            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Location = new System.Drawing.Point(50, 200);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(120, 20);
            this.lblCountdown.Text = "Time Left: 60 seconds";

            // 
            // Form5
            // 
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lblEstimatedTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblDeliveryFee);
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
        private System.Windows.Forms.Label lblDeliveryFee;
        private System.Windows.Forms.Label lblEstimatedTotal;
        private System.Windows.Forms.Label lblCountdown;
    }
}