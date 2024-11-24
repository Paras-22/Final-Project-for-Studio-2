using System.Drawing;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    partial class SpecialOfferDetailForm
    {
        private System.ComponentModel.IContainer components = null;

        private PictureBox productPictureBox;
        private Label nameLabel;
        private Label descriptionTitleLabel;
        private TextBox descriptionTextBox;
        private Label priceLabel;
        private ComboBox sizeComboBox;
        private NumericUpDown quantityNumericUpDown;
        private Button addToCartButton;
        private Button backButton;
        private Label featuresTitleLabel;
        private Label featuresLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionTitleLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.featuresTitleLabel = new System.Windows.Forms.Label();
            this.featuresLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // productPictureBox
            // 
            this.productPictureBox.Location = new System.Drawing.Point(20, 20);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(300, 300);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPictureBox.TabIndex = 0;
            this.productPictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(340, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(400, 40);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // descriptionTitleLabel
            // 
            this.descriptionTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.descriptionTitleLabel.Location = new System.Drawing.Point(340, 70);
            this.descriptionTitleLabel.Name = "descriptionTitleLabel";
            this.descriptionTitleLabel.Size = new System.Drawing.Size(400, 30);
            this.descriptionTitleLabel.TabIndex = 2;
            this.descriptionTitleLabel.Text = "Description";
            this.descriptionTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.descriptionTextBox.Location = new System.Drawing.Point(340, 110);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(400, 100);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.priceLabel.ForeColor = System.Drawing.Color.Green;
            this.priceLabel.Location = new System.Drawing.Point(340, 230);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(400, 40);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.priceLabel.Click += new System.EventHandler(this.priceLabel_Click);
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeComboBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "Extra Large"});
            this.sizeComboBox.Location = new System.Drawing.Point(340, 280);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(150, 28);
            this.sizeComboBox.TabIndex = 5;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(520, 280);
            this.quantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(80, 26);
            this.quantityNumericUpDown.TabIndex = 6;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addToCartButton
            // 
            this.addToCartButton.BackColor = System.Drawing.Color.Orange;
            this.addToCartButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addToCartButton.ForeColor = System.Drawing.Color.White;
            this.addToCartButton.Location = new System.Drawing.Point(340, 330);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(150, 40);
            this.addToCartButton.TabIndex = 7;
            this.addToCartButton.Text = "Add to Cart";
            this.addToCartButton.UseVisualStyleBackColor = false;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click_1);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Gray;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(520, 330);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(150, 40);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // featuresTitleLabel
            // 
            this.featuresTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.featuresTitleLabel.Location = new System.Drawing.Point(340, 380);
            this.featuresTitleLabel.Name = "featuresTitleLabel";
            this.featuresTitleLabel.Size = new System.Drawing.Size(400, 30);
            this.featuresTitleLabel.TabIndex = 9;
            this.featuresTitleLabel.Text = "Key Features";
            this.featuresTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // featuresLabel
            // 
            this.featuresLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.featuresLabel.Location = new System.Drawing.Point(340, 420);
            this.featuresLabel.Name = "featuresLabel";
            this.featuresLabel.Size = new System.Drawing.Size(400, 100);
            this.featuresLabel.TabIndex = 10;
            this.featuresLabel.Text = "- Stylish and comfortable\n- Made from high-quality materials\n- Perfect for any oc" +
    "casion";
            this.featuresLabel.Click += new System.EventHandler(this.featuresLabel_Click);
            // 
            // SpecialOfferDetailForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.productPictureBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.descriptionTitleLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.sizeComboBox);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.featuresTitleLabel);
            this.Controls.Add(this.featuresLabel);
            this.MaximizeBox = false;
            this.Name = "SpecialOfferDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Special Offer Details";
            this.Load += new System.EventHandler(this.SpecialOfferDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
