namespace Final_Project_for_Studio_2
{
    partial class Dashboard1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel sideNavPanel;
        private System.Windows.Forms.Panel mainContentPanel;
        private System.Windows.Forms.Panel topBarPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnWomen;
        private System.Windows.Forms.Button btnKids;
        private System.Windows.Forms.Button btnOthers;
        private System.Windows.Forms.Button btnContactUs;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.PictureBox cartIconPictureBox;

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
            this.sideNavPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnWomen = new System.Windows.Forms.Button();
            this.btnKids = new System.Windows.Forms.Button();
            this.btnOthers = new System.Windows.Forms.Button();
            this.btnContactUs = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelTrendMart = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.cartIconPictureBox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.sideNavPanel.SuspendLayout();
            this.topBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sideNavPanel
            // 
            this.sideNavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.sideNavPanel.Controls.Add(this.button2);
            this.sideNavPanel.Controls.Add(this.button1);
            this.sideNavPanel.Controls.Add(this.btnFeedback);
            this.sideNavPanel.Controls.Add(this.btnWomen);
            this.sideNavPanel.Controls.Add(this.btnKids);
            this.sideNavPanel.Controls.Add(this.btnOthers);
            this.sideNavPanel.Controls.Add(this.btnContactUs);
            this.sideNavPanel.Controls.Add(this.btnViewOrders);
            this.sideNavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideNavPanel.Location = new System.Drawing.Point(0, 52);
            this.sideNavPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sideNavPanel.Name = "sideNavPanel";
            this.sideNavPanel.Size = new System.Drawing.Size(133, 505);
            this.sideNavPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 295);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "View Orders";
            // 
            // btnFeedback
            // 
            this.btnFeedback.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.Location = new System.Drawing.Point(0, 241);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(133, 54);
            this.btnFeedback.TabIndex = 0;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnWomen
            // 
            this.btnWomen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWomen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWomen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWomen.Location = new System.Drawing.Point(0, 193);
            this.btnWomen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWomen.Name = "btnWomen";
            this.btnWomen.Size = new System.Drawing.Size(133, 48);
            this.btnWomen.TabIndex = 1;
            this.btnWomen.Text = "Contact us";
            this.btnWomen.Click += new System.EventHandler(this.btnContactus_Click);
            // 
            // btnKids
            // 
            this.btnKids.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKids.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKids.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKids.Location = new System.Drawing.Point(0, 146);
            this.btnKids.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKids.Name = "btnKids";
            this.btnKids.Size = new System.Drawing.Size(133, 47);
            this.btnKids.TabIndex = 2;
            this.btnKids.Text = "Others";
            // 
            // btnOthers
            // 
            this.btnOthers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOthers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOthers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOthers.Location = new System.Drawing.Point(0, 99);
            this.btnOthers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.Size = new System.Drawing.Size(133, 47);
            this.btnOthers.TabIndex = 3;
            this.btnOthers.Text = "Kids";
            // 
            // btnContactUs
            // 
            this.btnContactUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContactUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactUs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactUs.Location = new System.Drawing.Point(0, 50);
            this.btnContactUs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnContactUs.Name = "btnContactUs";
            this.btnContactUs.Size = new System.Drawing.Size(133, 49);
            this.btnContactUs.TabIndex = 4;
            this.btnContactUs.Text = "Women";
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.Location = new System.Drawing.Point(0, 0);
            this.btnViewOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(133, 50);
            this.btnViewOrders.TabIndex = 5;
            this.btnViewOrders.Text = "Men";
            this.btnViewOrders.Click += new System.EventHandler(this.btnMen_Click);
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.BackColor = System.Drawing.Color.White;
            this.mainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContentPanel.Location = new System.Drawing.Point(133, 52);
            this.mainContentPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Size = new System.Drawing.Size(840, 505);
            this.mainContentPanel.TabIndex = 0;
            this.mainContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainContentPanel_Paint);
            // 
            // topBarPanel
            // 
            this.topBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.topBarPanel.Controls.Add(this.buttonLogout);
            this.topBarPanel.Controls.Add(this.labelTrendMart);
            this.topBarPanel.Controls.Add(this.titleLabel);
            this.topBarPanel.Controls.Add(this.cartIconPictureBox);
            this.topBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarPanel.Location = new System.Drawing.Point(0, 0);
            this.topBarPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(973, 52);
            this.topBarPanel.TabIndex = 2;
            this.topBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topBarPanel_Paint);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonLogout.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogout.Location = new System.Drawing.Point(8, 9);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(93, 36);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelTrendMart
            // 
            this.labelTrendMart.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrendMart.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelTrendMart.Location = new System.Drawing.Point(536, 6);
            this.labelTrendMart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTrendMart.Name = "labelTrendMart";
            this.labelTrendMart.Size = new System.Drawing.Size(209, 33);
            this.labelTrendMart.TabIndex = 2;
            this.labelTrendMart.Text = "to TrendMart";
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(409, 6);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(157, 33);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Welcome to";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // cartIconPictureBox
            // 
            this.cartIconPictureBox.Image = global::Final_Project_for_Studio_2.Properties.Resources.cart;
            this.cartIconPictureBox.Location = new System.Drawing.Point(896, 0);
            this.cartIconPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cartIconPictureBox.Name = "cartIconPictureBox";
            this.cartIconPictureBox.Size = new System.Drawing.Size(59, 52);
            this.cartIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cartIconPictureBox.TabIndex = 1;
            this.cartIconPictureBox.TabStop = false;
            this.cartIconPictureBox.Click += new System.EventHandler(this.cartIconPictureBox_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 349);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 54);
            this.button2.TabIndex = 7;
            this.button2.Text = "Alternative Dashboard";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dashboard1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 557);
            this.Controls.Add(this.mainContentPanel);
            this.Controls.Add(this.sideNavPanel);
            this.Controls.Add(this.topBarPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Dashboard1";
            this.Text = "Dashboard";
            this.sideNavPanel.ResumeLayout(false);
            this.topBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartIconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTrendMart;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
