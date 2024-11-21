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

        
        public SpecialOfferDetailForm(string name, decimal price, string description, Image image)
        {
            InitializeComponent();

           
            productName = name;
            productPrice = price;
            productDescription = description;
            productImage = image;

            DisplayProductDetails();
        }

        public SpecialOfferDetailForm(string name, decimal price, Image image)
        {
            InitializeComponent();

           
            productName = name;
            productPrice = price;
            productImage = image;

            
            DisplayProductDetails();
        }

        private void DisplayProductDetails()
        {
           
            productPictureBox.Image = productImage;
            nameLabel.Text = productName;
            priceLabel.Text = $"Price: ${productPrice:F2}";

           
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

            
            descriptionTextBox.Clear(); 
            foreach (var point in descriptionPoints)
            {
                descriptionTextBox.AppendText(point + Environment.NewLine); 
            }

           
            sizeComboBox.SelectedIndex = 0; 
            quantityNumericUpDown.Value = 1; 
        }


        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            string selectedSize = sizeComboBox.SelectedItem?.ToString() ?? "Unknown";
            int quantity = (int)quantityNumericUpDown.Value;

            
            MessageBox.Show(
                $"Added {quantity} x '{productName}' (Size: {selectedSize}) to your cart!",
                "Cart Confirmation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void SpecialOfferDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToCartButton_Click_1(object sender, EventArgs e)
        {
            string selectedSize = sizeComboBox.SelectedItem?.ToString() ?? "Unknown";
            int quantity = (int)quantityNumericUpDown.Value;

            
            MessageBox.Show(
                $"Added {quantity} x '{productName}' (Size: {selectedSize}) to your cart!",
                "Cart Confirmation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void featuresLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
