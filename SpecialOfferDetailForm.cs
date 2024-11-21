using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class SpecialOfferDetailForm : Form
    {
        private string productName;
        private decimal productPrice;
        private string productDescription;
        private Image productImage;
        private Form5 checkoutForm;

        public SpecialOfferDetailForm(string name, decimal price, string description, Image image, Form5 checkoutForm)
        {
            InitializeComponent();
            productName = name;
            productPrice = price;
            productDescription = description;
            productImage = image;
            this.checkoutForm = checkoutForm;

            DisplayProductDetails();
        }

        private void DisplayProductDetails()
        {
            productPictureBox.Image = productImage;
            nameLabel.Text = productName;
            priceLabel.Text = $"Price: ${productPrice:F2}";

            sizeComboBox.SelectedIndex = 0;
            quantityNumericUpDown.Value = 1;
        }

        private void addToCartButton_Click_1(object sender, EventArgs e)
        {
            int quantity = (int)quantityNumericUpDown.Value;

            checkoutForm.AddToCart(productName, quantity, productPrice);

            MessageBox.Show(
                $"Added {quantity} x '{productName}' to your cart!",
                "Cart Confirmation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }
        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SpecialOfferDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void featuresLabel_Click(object sender, EventArgs e)
        {

        }


    }
}
