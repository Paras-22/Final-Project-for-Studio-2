using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class Dashboard1 : Form
    {

        private void LoadProducts()
        {
            // Adjust the form size
            this.ClientSize = new System.Drawing.Size(1024, 768);

            // Create a FlowLayoutPanel to hold product items
            FlowLayoutPanel productsFlowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,        // Fills the main content area
                AutoScroll = true,           // Enables scrolling
                Padding = new Padding(20),   // Space around the edges
                WrapContents = true,         // Allows items to wrap into multiple rows
                FlowDirection = FlowDirection.LeftToRight // Arrange items left-to-right in rows
            };

            // Add a title to indicate "Special Offers"
            Label specialOffersTitle = new Label
            {
                Text = "🌟 Special Offers 🌟",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.DarkOrange,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(10),
                AutoSize = false,
                Height = 50
            };

            mainContentPanel.Controls.Add(specialOffersTitle);
            mainContentPanel.Controls.Add(productsFlowPanel);

            // Sample product data for demonstration
            var products = new List<(string Name, decimal Price, string Description, Image Image)>
    {
        ("Formal Suit", 129.99m, "Elegant and professional.", Properties.Resources.outfit1),
        ("Casual Outfit", 199.99m, "Comfortable and stylish.", Properties.Resources.outfit2),
        ("Puffer Jacket with Jeans", 109.99m, "Stay warm in style.", Properties.Resources.outfit41),
        ("Bomber Jacket Outfit", 110.99m, "Light and breezy.", Properties.Resources.outfit4),
        ("Denim Jacket Outfit", 149.99m, "Stylish and attractive.", Properties.Resources.outfit5)
    };

            // Dynamically add product panels
            foreach (var product in products)
            {
                // Create a panel for each product
                Panel productPanel = new Panel
                {
                    Width = 220,             // Adjust width for grid alignment
                    Height = 320,            // Adjust height for uniformity
                    Margin = new Padding(15), // Space between items
                    BorderStyle = BorderStyle.FixedSingle // Adds a border for better visibility
                };

                // Add a PictureBox for the product image
                PictureBox productPictureBox = new PictureBox
                {
                    Image = product.Image, // Product image from resources
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top,
                    Height = 180 // Larger image height for better visibility
                };

                // Add hover effect for the PictureBox
                productPictureBox.MouseEnter += (sender, e) =>
                {
                    productPictureBox.BackColor = Color.LightGray; // Highlight the image on hover
                };

                productPictureBox.MouseLeave += (sender, e) =>
                {
                    productPictureBox.BackColor = Color.Transparent; // Reset background on leave
                };

                // Add click event for PictureBox to navigate to product detail form
                //productPictureBox.Click += (sender, e) =>
                //{
                //    ProductDetailForm detailForm = new ProductDetailForm(product.Name, product.Price, product.Description, product.Image);
                //    detailForm.ShowDialog(); // Open the product detail form as a dialog
                //};

                productPanel.Controls.Add(productPictureBox);

                // Add a Label for the product name
                Label nameLabel = new Label
                {
                    Text = product.Name,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                    Height = 30, // Adjust label height
                    ForeColor = Color.Black
                };
                productPanel.Controls.Add(nameLabel);

                // Add a Label for the product price
                Label priceLabel = new Label
                {
                    Text = $"Price: ${product.Price:F2}",
                    Font = new Font("Segoe UI", 11, FontStyle.Regular),
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                    Height = 25,
                    ForeColor = Color.Green
                };
                productPanel.Controls.Add(priceLabel);

                // Add a Label for the product description
                Label descriptionLabel = new Label
                {
                    Text = product.Description,
                    Font = new Font("Segoe UI", 10, FontStyle.Italic),
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                    Height = 60,
                    ForeColor = Color.Gray
                };
                productPanel.Controls.Add(descriptionLabel);

                // Add a "Special" label at the bottom
                Label specialLabel = new Label
                {
                    Text = "🔥 Limited Time Offer 🔥",
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                    Height = 25,
                    ForeColor = Color.Red
                };
                productPanel.Controls.Add(specialLabel);

                // Add the product panel to the FlowLayoutPanel
                productsFlowPanel.Controls.Add(productPanel);
            }
        }





        public Dashboard1()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void topBarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void mainContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
