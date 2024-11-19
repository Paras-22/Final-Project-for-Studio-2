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
            this.productPictureBox = new PictureBox();
            this.nameLabel = new Label();
            this.descriptionTitleLabel = new Label();
            this.descriptionTextBox = new TextBox();
            this.priceLabel = new Label();
            this.sizeComboBox = new ComboBox();
            this.quantityNumericUpDown = new NumericUpDown();
            this.addToCartButton = new Button();
            this.backButton = new Button();
            this.featuresTitleLabel = new Label();
            this.featuresLabel = new Label();

            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();

            // 
            // productPictureBox
            // 
            this.productPictureBox.Location = new System.Drawing.Point(20, 20);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(300, 300);
            this.productPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.productPictureBox.TabIndex = 0;

            // 
            // nameLabel
            // 
            this.nameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(340, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(400, 40);
            this.nameLabel.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // descriptionTitleLabel
            // 
            this.descriptionTitleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.descriptionTitleLabel.Location = new System.Drawing.Point(340, 70);
            this.descriptionTitleLabel.Name = "descriptionTitleLabel";
            this.descriptionTitleLabel.Size = new System.Drawing.Size(400, 30);
            this.descriptionTitleLabel.Text = "Description";
            this.descriptionTitleLabel.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(340, 110);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(400, 100);
            this.descriptionTextBox.ScrollBars = ScrollBars.Vertical;
            this.descriptionTextBox.Font = new Font("Segoe UI", 10F);

            // 
            // priceLabel
            // 
            this.priceLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.priceLabel.ForeColor = Color.Green;
            this.priceLabel.Location = new System.Drawing.Point(340, 230);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(400, 40);
            this.priceLabel.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // sizeComboBox
            // 
            this.sizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.sizeComboBox.Items.AddRange(new object[] { "Small", "Medium", "Large", "Extra Large" });
            this.sizeComboBox.Location = new System.Drawing.Point(340, 280);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(150, 28);

            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(520, 280);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(80, 28);
            this.quantityNumericUpDown.Minimum = 1;
            this.quantityNumericUpDown.Maximum = 100;

            // 
            // addToCartButton
            // 
            this.addToCartButton.BackColor = Color.Orange;
            this.addToCartButton.ForeColor = Color.White;
            this.addToCartButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.addToCartButton.Location = new System.Drawing.Point(340, 330);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(150, 40);
            this.addToCartButton.Text = "Add to Cart";
            this.addToCartButton.UseVisualStyleBackColor = false;
            this.addToCartButton.Click += AddToCartButton_Click;

            // 
            // backButton
            // 
            this.backButton.BackColor = Color.Gray;
            this.backButton.ForeColor = Color.White;
            this.backButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.backButton.Location = new System.Drawing.Point(520, 330);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(150, 40);
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += BackButton_Click;

            // 
            // featuresTitleLabel
            // 
            this.featuresTitleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.featuresTitleLabel.Location = new System.Drawing.Point(340, 380);
            this.featuresTitleLabel.Name = "featuresTitleLabel";
            this.featuresTitleLabel.Size = new System.Drawing.Size(400, 30);
            this.featuresTitleLabel.Text = "Key Features";
            this.featuresTitleLabel.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // featuresLabel
            // 
            this.featuresLabel.Font = new Font("Segoe UI", 10F);
            this.featuresLabel.Location = new System.Drawing.Point(340, 420);
            this.featuresLabel.Name = "featuresLabel";
            this.featuresLabel.Size = new System.Drawing.Size(400, 100);
            this.featuresLabel.Text = "- Stylish and comfortable\n- Made from high-quality materials\n- Perfect for any occasion";
            this.featuresLabel.TextAlign = ContentAlignment.TopLeft;

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
            this.Text = "Special Offer Details";

            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
