using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class SpecialOfferDetailForm : Form
    {
        // Fields for product details
        private string productName;
        private decimal productPrice;
        private string productDescription;
        private Image productImage;

        // Constructor to initialize product details
        public SpecialOfferDetailForm(string name, decimal price, string description, Image image)
        {
            InitializeComponent();

            // Store product details
            productName = name;
            productPrice = price;
            productDescription = description;
            productImage = image;

            // Display product details
            DisplayProductDetails();
        }

        public SpecialOfferDetailForm(string name, decimal price, Image image)
        {
            InitializeComponent();

            // Store product details
            productName = name;
            productPrice = price;
            productImage = image;

            // Display product details
            DisplayProductDetails();
        }

        private void DisplayProductDetails()
        {
            // Set product image, name, and price
            productPictureBox.Image = productImage;
            nameLabel.Text = productName;
            priceLabel.Text = $"Price: ${productPrice:F2}";

            // Use a switch statement to determine the description points
            string[] descriptionPoints;
            switch (productName)
            {
                case "Formal Suit":
                    descriptionPoints = new string[]
                    {
                "• Tailored blazer, trousers, and tie",
                "• Crafted from premium wool blend for comfort",
                "• Modern slim-fit design",
                "• Perfect for weddings, corporate events, and formal occasions"
                    };
                    break;

                case "Casual Outfit":
                    descriptionPoints = new string[]
                    {
                "• Stylish jacket with a modern cut",
                "• Comfortable cotton T-shirt",
                "• Slim-fit chinos",
                "• Lightweight and breathable materials",
                "• Ideal for casual outings or relaxed office wear"
                    };
                    break;

                case "Puffer Jacket with Jeans":
                    descriptionPoints = new string[]
                    {
                "• Warm and lightweight puffer jacket",
                "• Classic slim-fit jeans",
                "• Cozy knit sweater",
                "• Insulated for superior warmth in cold weather",
                "• Perfect for outdoor adventures or winter outings"
                    };
                    break;

                case "Bomber Jacket Outfit":
                    descriptionPoints = new string[]
                    {
                "• Sleek bomber jacket with zipper front",
                "• Fitted trousers and relaxed-fit cotton shirt",
                "• Lightweight and perfect for transitional weather",
                "• Combines style and practicality effortlessly"
                    };
                    break;

                case "Denim Jacket Outfit":
                    descriptionPoints = new string[]
                    {
                "• Rugged denim jacket with vintage finish",
                "• Comfortable turtleneck sweater",
                "• Slim-fit jeans with stretch fabric",
                "• Durable and stylish for urban and outdoor settings",
                "• Timeless outfit for casual occasions"
                    };
                    break;

                default:
                    descriptionPoints = new string[]
                    {
                "• Stylish and comfortable design",
                "• Made from high-quality materials",
                "• Perfect for any occasion"
                    };
                    break;
            }

            // Add the description to the descriptionTextBox
            descriptionTextBox.Clear(); // Clear any previous content
            foreach (var point in descriptionPoints)
            {
                descriptionTextBox.AppendText(point + Environment.NewLine); // Append each point with a newline
            }

            // Set default values for size and quantity
            sizeComboBox.SelectedIndex = 0; // Default size
            quantityNumericUpDown.Value = 1; // Default quantity
        }


        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            string selectedSize = sizeComboBox.SelectedItem?.ToString() ?? "Unknown";
            int quantity = (int)quantityNumericUpDown.Value;

            // Confirm adding to the cart
            MessageBox.Show(
                $"Added {quantity} x '{productName}' (Size: {selectedSize}) to your cart!",
                "Cart Confirmation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form and return to the dashboard
        }
    }
}
