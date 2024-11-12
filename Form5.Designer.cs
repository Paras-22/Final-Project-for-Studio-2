namespace Final_Project_for_Studio_2
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lstItems = new System.Windows.Forms.ListBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDeliveryFee = new System.Windows.Forms.Label();
            this.lblEstimatedTotal = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.pnlTrolleyInfo = new System.Windows.Forms.Panel();
            this.tblLayoutPrices = new System.Windows.Forms.TableLayoutPanel();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.pnlTrolleyInfo.SuspendLayout();
            this.tblLayoutPrices.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContinueShopping
            // 
            this.btnContinueShopping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(0)))));
            this.btnContinueShopping.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnContinueShopping.ForeColor = System.Drawing.Color.White;
            this.btnContinueShopping.Location = new System.Drawing.Point(50, 20);
            this.btnContinueShopping.Name = "btnContinueShopping";
            this.btnContinueShopping.Size = new System.Drawing.Size(200, 50);
            this.btnContinueShopping.TabIndex = 0;
            this.btnContinueShopping.Text = "Continue Shopping";
            this.btnContinueShopping.UseVisualStyleBackColor = false;
            this.btnContinueShopping.Click += new System.EventHandler(this.btnContinueShopping_Click);
            // 
            // btnClearTrolley
            // 
            this.btnClearTrolley.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClearTrolley.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearTrolley.ForeColor = System.Drawing.Color.White;
            this.btnClearTrolley.Location = new System.Drawing.Point(280, 20);
            this.btnClearTrolley.Name = "btnClearTrolley";
            this.btnClearTrolley.Size = new System.Drawing.Size(200, 50);
            this.btnClearTrolley.TabIndex = 1;
            this.btnClearTrolley.Text = "Clear Trolley";
            this.btnClearTrolley.UseVisualStyleBackColor = false;
            this.btnClearTrolley.Click += new System.EventHandler(this.btnClearTrolley_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCheckout.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(510, 20);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(200, 50);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblTrolleyStatus
            // 
            this.lblTrolleyStatus.AutoSize = true;
            this.lblTrolleyStatus.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTrolleyStatus.Location = new System.Drawing.Point(20, 32);
            this.lblTrolleyStatus.Name = "lblTrolleyStatus";
            this.lblTrolleyStatus.Size = new System.Drawing.Size(224, 37);
            this.lblTrolleyStatus.TabIndex = 0;
            this.lblTrolleyStatus.Text = "Trolley Items:";
            // 
            // lstItems
            // 
            this.lstItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstItems.Font = new System.Drawing.Font("Arial", 10F);
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 23;
            this.lstItems.Location = new System.Drawing.Point(27, 80);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(300, 301);
            this.lstItems.TabIndex = 1;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSubtotal.Location = new System.Drawing.Point(3, 47);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(175, 27);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "Subtotal: $0.00";
            // 
            // lblDeliveryFee
            // 
            this.lblDeliveryFee.AutoSize = true;
            this.lblDeliveryFee.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDeliveryFee.Location = new System.Drawing.Point(3, 0);
            this.lblDeliveryFee.Name = "lblDeliveryFee";
            this.lblDeliveryFee.Size = new System.Drawing.Size(218, 27);
            this.lblDeliveryFee.TabIndex = 0;
            this.lblDeliveryFee.Text = "Delivery Fee: $0.00";
            // 
            // lblEstimatedTotal
            // 
            this.lblEstimatedTotal.AutoSize = true;
            this.lblEstimatedTotal.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblEstimatedTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEstimatedTotal.Location = new System.Drawing.Point(3, 169);
            this.lblEstimatedTotal.Name = "lblEstimatedTotal";
            this.lblEstimatedTotal.Size = new System.Drawing.Size(242, 66);
            this.lblEstimatedTotal.TabIndex = 2;
            this.lblEstimatedTotal.Text = "Estimated Total: $0.00";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.lblCountdown.ForeColor = System.Drawing.Color.Red;
            this.lblCountdown.Location = new System.Drawing.Point(36, 440);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(208, 24);
            this.lblCountdown.TabIndex = 2;
            this.lblCountdown.Text = "Time Left: 60 seconds";
            // 
            // pnlTrolleyInfo
            // 
            this.pnlTrolleyInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTrolleyInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTrolleyInfo.Controls.Add(this.lblTrolleyStatus);
            this.pnlTrolleyInfo.Controls.Add(this.lstItems);
            this.pnlTrolleyInfo.Controls.Add(this.lblCountdown);
            this.pnlTrolleyInfo.Controls.Add(this.tblLayoutPrices);
            this.pnlTrolleyInfo.Location = new System.Drawing.Point(86, 36);
            this.pnlTrolleyInfo.Name = "pnlTrolleyInfo";
            this.pnlTrolleyInfo.Size = new System.Drawing.Size(842, 501);
            this.pnlTrolleyInfo.TabIndex = 0;
            // 
            // tblLayoutPrices
            // 
            this.tblLayoutPrices.ColumnCount = 2;
            this.tblLayoutPrices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.34328F));
            this.tblLayoutPrices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.65672F));
            this.tblLayoutPrices.Controls.Add(this.lblDeliveryFee, 0, 0);
            this.tblLayoutPrices.Controls.Add(this.lblSubtotal, 0, 1);
            this.tblLayoutPrices.Controls.Add(this.lblEstimatedTotal, 0, 2);
            this.tblLayoutPrices.Location = new System.Drawing.Point(349, 80);
            this.tblLayoutPrices.Name = "tblLayoutPrices";
            this.tblLayoutPrices.RowCount = 3;
            this.tblLayoutPrices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tblLayoutPrices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblLayoutPrices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblLayoutPrices.Size = new System.Drawing.Size(413, 301);
            this.tblLayoutPrices.TabIndex = 3;
            this.tblLayoutPrices.Paint += new System.Windows.Forms.PaintEventHandler(this.tblLayoutPrices_Paint);
            // 
            // pnlActions
            // 
            this.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActions.Controls.Add(this.btnContinueShopping);
            this.pnlActions.Controls.Add(this.btnClearTrolley);
            this.pnlActions.Controls.Add(this.btnCheckout);
            this.pnlActions.Location = new System.Drawing.Point(120, 588);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(729, 112);
            this.pnlActions.TabIndex = 1;
            // 
            // Form5
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.pnlTrolleyInfo);
            this.Controls.Add(this.pnlActions);
            this.Name = "Form5";
            this.Text = "Shopping Cart";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.pnlTrolleyInfo.ResumeLayout(false);
            this.pnlTrolleyInfo.PerformLayout();
            this.tblLayoutPrices.ResumeLayout(false);
            this.tblLayoutPrices.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContinueShopping;
        private System.Windows.Forms.Button btnClearTrolley;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblTrolleyStatus;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDeliveryFee;
        private System.Windows.Forms.Label lblEstimatedTotal;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Panel pnlTrolleyInfo;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPrices;
        private System.Windows.Forms.Panel pnlActions;
    }
}