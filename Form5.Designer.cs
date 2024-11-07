using System.Security.Policy;

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
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDeliveryFee = new System.Windows.Forms.Label();
            this.lblEstimatedTotal = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.pnlTrolleyInfo = new System.Windows.Forms.Panel();
            this.tblLayoutPrices = new System.Windows.Forms.TableLayoutPanel();
            this.pnlActions = new System.Windows.Forms.Panel();

            this.SuspendLayout();

            // 
            // pnlTrolleyInfo
            // 
            this.pnlTrolleyInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTrolleyInfo.Controls.Add(this.lblTrolleyStatus);
            this.pnlTrolleyInfo.Controls.Add(this.lblCountdown);
            this.pnlTrolleyInfo.Controls.Add(this.tblLayoutPrices);
            this.pnlTrolleyInfo.Location = new System.Drawing.Point(50, 30);
            this.pnlTrolleyInfo.Name = "pnlTrolleyInfo";
            this.pnlTrolleyInfo.Size = new System.Drawing.Size(600, 300);
            this.pnlTrolleyInfo.BackColor = System.Drawing.Color.WhiteSmoke;

            // 
            // lblTrolleyStatus
            // 
            this.lblTrolleyStatus.AutoSize = true;
            this.lblTrolleyStatus.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTrolleyStatus.Location = new System.Drawing.Point(20, 20);
            this.lblTrolleyStatus.Name = "lblTrolleyStatus";
            this.lblTrolleyStatus.Text = "Trolley: No items";

            // 
            // tblLayoutPrices
            // 
            this.tblLayoutPrices.ColumnCount = 2;
            this.tblLayoutPrices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblLayoutPrices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLayoutPrices.Controls.Add(this.lblDeliveryFee, 0, 0);
            this.tblLayoutPrices.Controls.Add(this.lblSubtotal, 0, 1);
            this.tblLayoutPrices.Controls.Add(this.lblEstimatedTotal, 0, 2);
            this.tblLayoutPrices.Location = new System.Drawing.Point(20, 60);
            this.tblLayoutPrices.Name = "tblLayoutPrices";
            this.tblLayoutPrices.RowCount = 3;
            this.tblLayoutPrices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblLayoutPrices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblLayoutPrices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblLayoutPrices.Size = new System.Drawing.Size(560, 150);

            // 
            // lblDeliveryFee
            // 
            this.lblDeliveryFee.AutoSize = true;
            this.lblDeliveryFee.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDeliveryFee.Location = new System.Drawing.Point(3, 0);
            this.lblDeliveryFee.Text = "Delivery Fee:";
            this.tblLayoutPrices.SetCellPosition(this.lblDeliveryFee, new System.Windows.Forms.TableLayoutPanelCellPosition(0, 0));

            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSubtotal.Location = new System.Drawing.Point(3, 50);
            this.lblSubtotal.Text = "Subtotal:";
            this.tblLayoutPrices.SetCellPosition(this.lblSubtotal, new System.Windows.Forms.TableLayoutPanelCellPosition(0, 1));

            // 
            // lblEstimatedTotal
            // 
            this.lblEstimatedTotal.AutoSize = true;
            this.lblEstimatedTotal.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblEstimatedTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEstimatedTotal.Location = new System.Drawing.Point(3, 100);
            this.lblEstimatedTotal.Text = "Estimated Total: $14.00";
            this.tblLayoutPrices.SetCellPosition(this.lblEstimatedTotal, new System.Windows.Forms.TableLayoutPanelCellPosition(0, 2));

            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCountdown.ForeColor = System.Drawing.Color.Red;
            this.lblCountdown.Location = new System.Drawing.Point(20, 240);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Text = "Time Left: 60 seconds";

            // 
            // pnlActions
            // 
            this.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActions.Controls.Add(this.btnContinueShopping);
            this.pnlActions.Controls.Add(this.btnClearTrolley);
            this.pnlActions.Controls.Add(this.btnCheckout);
            this.pnlActions.Location = new System.Drawing.Point(50, 350);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(600, 100);

            // 
            // btnContinueShopping
            // 
            this.btnContinueShopping.Location = new System.Drawing.Point(20, 20);
            this.btnContinueShopping.Name = "btnContinueShopping";
            this.btnContinueShopping.Size = new System.Drawing.Size(160, 50);
            this.btnContinueShopping.Text = "Continue Shopping";
            this.btnContinueShopping.UseVisualStyleBackColor = true;
            this.btnContinueShopping.Click += new System.EventHandler(this.btnContinueShopping_Click);
            this.btnContinueShopping.BackColor = System.Drawing.Color.FromArgb(0, 123, 0);
            this.btnContinueShopping.ForeColor = System.Drawing.Color.White;
            this.btnContinueShopping.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);

            // 
            // btnClearTrolley
            // 
            this.btnClearTrolley.Location = new System.Drawing.Point(220, 20);
            this.btnClearTrolley.Name = "btnClearTrolley";
            this.btnClearTrolley.Size = new System.Drawing.Size(160, 50);
            this.btnClearTrolley.Text = "Clear Trolley";
            this.btnClearTrolley.UseVisualStyleBackColor = true;
            this.btnClearTrolley.Click += new System.EventHandler(this.btnClearTrolley_Click);
            this.btnClearTrolley.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.btnClearTrolley.ForeColor = System.Drawing.Color.White;
            this.btnClearTrolley.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);

            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(420, 20);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(160, 50);
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);

            // 
            // Form5
            // 
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.pnlTrolleyInfo);
            this.Controls.Add(this.pnlActions);
            this.Text = "Shopping Cart";
            this.Load += new System.EventHandler(this.Form5_Load);

            this.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlTrolleyInfo;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPrices;
        private System.Windows.Forms.Panel pnlActions;
    }
}
