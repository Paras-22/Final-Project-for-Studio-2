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

                case "Casual Shirt":
                    descriptionPoints = new string[]
                    {
            "• Light and stylish shirt",
            "• Comfortable fit for everyday use",
            "• Perfect for casual outings or layering",
            "• Available in vibrant colors and patterns"
                    };
                    break;

                case "Olive T-Shirt":
                    descriptionPoints = new string[]
                    {
            "• Classic olive color for a versatile look",
            "• Made from breathable cotton fabric",
            "• Ideal for both casual and semi-casual occasions"
                    };
                    break;

                case "Baggy T-Shirt":
                    descriptionPoints = new string[]
                    {
            "• Relaxed and comfy fit",
            "• Trendy oversized design",
            "• Great for lounging or casual wear"
                    };
                    break;

                case "Formal Shirt":
                    descriptionPoints = new string[]
                    {
            "• Elegant design with a polished finish",
            "• Perfect for office wear or formal events",
            "• High-quality fabric for a neat appearance"
                    };
                    break;

                case "Jeans":
                    descriptionPoints = new string[]
                    {
            "• Durable and trendy denim material",
            "• Comfortable fit for everyday wear",
            "• Classic style that pairs well with any outfit"
                    };
                    break;

                case "Formal Trousers":
                    descriptionPoints = new string[]
                    {
            "• Sharp and professional design",
            "• Suitable for business meetings or formal events",
            "• Comfortable fabric for all-day wear"
                    };
                    break;

                case "Black Jeans":
                    descriptionPoints = new string[]
                    {
            "• Sleek and classic black denim",
            "• A versatile staple for any wardrobe",
            "• Stylish and durable for a modern look"
                    };
                    break;

                case "Joggers":
                    descriptionPoints = new string[]
                    {
            "• Comfortable joggers for relaxed wear",
            "• Sporty and casual style",
            "• Made from soft, breathable fabric"
                    };
                    break;

                case "Sneakers":
                    descriptionPoints = new string[]
                    {
            "• Stylish and comfortable footwear",
            "• Great for casual outings or light workouts",
            "• Durable and trendy design"
                    };
                    break;

                case "Formal Shoes":
                    descriptionPoints = new string[]
                    {
            "• Elegant shoes for formal events",
            "• Crafted with premium materials",
            "• Perfect complement to suits or formal wear"
                    };
                    break;

                case "Flat Shoes":
                    descriptionPoints = new string[]
                    {
            "• Stylish flats for all-day wear",
            "• Durable and comfortable design",
            "• Perfect for casual or semi-formal occasions"
                    };
                    break;

                case "Loafers":
                    descriptionPoints = new string[]
                    {
            "• Classic loafers with a modern twist",
            "• Easy to wear and versatile",
            "• Great for casual or business-casual settings"
                    };
                    break;

                case "Wallet":
                    descriptionPoints = new string[]
                    {
            "• Sleek and timeless leather wallet",
            "• Compact design with multiple compartments",
            "• Durable and stylish accessory"
                    };
                    break;

                case "Watch":
                    descriptionPoints = new string[]
                    {
            "• Stylish and functional watch",
            "• Perfect for everyday use or special occasions",
            "• Adds a touch of elegance to your look"
                    };
                    break;

                case "Formal Watch":
                    descriptionPoints = new string[]
                    {
            "• Elegant formal watch for special events",
            "• Sleek design with high-quality materials",
            "• A timeless accessory for any wardrobe"
                    };
                    break;

                case "Sunglasses":
                    descriptionPoints = new string[]
                    {
            "• Chic sunglasses with UV protection",
            "• Trendy design for a stylish look",
            "• Perfect for sunny days or outdoor activities"
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

            // Clear the text box and add the description points
            descriptionTextBox.Clear();
            foreach (var point in descriptionPoints)
            {
                descriptionTextBox.AppendText(point + Environment.NewLine);
            }


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

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
