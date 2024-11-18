using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            InitializeDashboard();
        }

        private void InitializeDashboard()
        {
            // Main Form Settings
            this.Text = "Product Dashboard";
            this.Size = new Size(1280, 720);
            this.BackColor = Color.White;

            // FlowLayoutPanel for Product Grid
            FlowLayoutPanel productPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(20),
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true
            };
            this.Controls.Add(productPanel);

            // Example Product Data (you can replace with actual data)
            for (int i = 0; i < 10; i++)
            {
                productPanel.Controls.Add(CreateProductPanel(
                    "Product Name",
                    "$200", // Original Price
                    "$160", // Discounted Price
                    "20% off Original price",
                    Properties.Resources.SampleProductImage // Replace with actual image
                ));
            }
        }

        // Helper Method to Create Individual Product Panels
        private Panel CreateProductPanel(string productName, string originalPrice, string discountedPrice, string discountInfo, Image productImage)
        {
            Panel productContainer = new Panel
            {
                Size = new Size(200, 300),
                Padding = new Padding(10),
                Margin = new Padding(10),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Product Image
            PictureBox productPictureBox = new PictureBox
            {
                Image = productImage,
                Size = new Size(180, 180),
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Top
            };
            productContainer.Controls.Add(productPictureBox);

            // Product Name Label
            Label nameLabel = new Label
            {
                Text = productName,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(0, 5, 0, 0)
            };
            productContainer.Controls.Add(nameLabel);

            // Discounted Price Label
            Label discountedPriceLabel = new Label
            {
                Text = discountedPrice,
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.Red,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter
            };
            productContainer.Controls.Add(discountedPriceLabel);

            // Original Price Label
            Label originalPriceLabel = new Label
            {
                Text = originalPrice,
                Font = new Font("Arial", 8, FontStyle.Strikeout),
                ForeColor = Color.Gray,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter
            };
            productContainer.Controls.Add(originalPriceLabel);

            // Discount Info Label
            Label discountInfoLabel = new Label
            {
                Text = discountInfo,
                Font = new Font("Arial", 8, FontStyle.Regular),
                ForeColor = Color.DarkGreen,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(0, 5, 0, 0)
            };
            productContainer.Controls.Add(discountInfoLabel);

            return productContainer;
        }
    }
}
