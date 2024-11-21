using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class MenCategoryForm1 : Form

    {
        public MenCategoryForm1()
        {
            InitializeComponent();
            LoadMenCategoryProducts();
        }

        private void LoadMenCategoryProducts()
        {
            this.ClientSize = new Size(850, 768);

            FlowLayoutPanel menProductsFlowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(20),
                WrapContents = true,
                FlowDirection = FlowDirection.LeftToRight
            };

            Label menCategoryTitle = new Label
            {
                Text = "👔 Men's Category 👔",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(5),
                AutoSize = false,
                Height = 50
            };

            Controls.Clear();
            Controls.Add(menCategoryTitle);
            Controls.Add(menProductsFlowPanel);

            var menProducts = new List<(string Name, decimal Price, string Description, Image Image)>
            {
                ("Casual Shirt", 39.99m, "Light and stylish.", Properties.Resources.S1),
                ("Olive T-Shirt", 49.99m, "Classic and versatile.", Properties.Resources.S2),
                ("Baggy T-Shirt", 19.99m, "Relaxed and comfy.", Properties.Resources.S3),
                ("Formal Shirt", 29.99m, "Elegant and neat.", Properties.Resources.S4),
                ("Jeans", 44.99m, "Durable and trendy.", Properties.Resources.P1),
                ("Formal Trousers", 59.99m, "Sharp and professional.", Properties.Resources.P2),
                ("Black Jeans", 39.99m, "Classic and sleek.", Properties.Resources.P3),
                ("Joggers", 29.99m, "Comfortable and sporty.", Properties.Resources.P4),
                ("Sneakers", 69.99m, "Comfortable and trendy.", Properties.Resources.H1),
                ("Formal Shoes", 89.99m, "Perfect for business.", Properties.Resources.H2),
                ("Flat Shoes", 79.99m, "Durable and stylish.", Properties.Resources.H3),
                ("Loafers", 59.99m, "Great for casual wear.", Properties.Resources.H4),
                ("Wallet", 99.99m, "Classic leather design.", Properties.Resources.A1),
                ("Watch", 49.99m, "Stylish and functional.", Properties.Resources.A2),
                ("Formal Watch", 19.99m, "Elegant design.", Properties.Resources.A3),
                ("Sunglasses", 24.99m, "UV protection with style.", Properties.Resources.A4)
            };

            foreach (var product in menProducts)
            {
                Panel productPanel = new Panel
                {
                    Width = 220,
                    Height = 320,
                    Margin = new Padding(15),
                    BorderStyle = BorderStyle.FixedSingle
                };

                PictureBox productPictureBox = new PictureBox
                {
                    Image = product.Image,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top,
                    Height = 180
                };
                Form5 checkoutForm = new Form5();
                productPictureBox.MouseEnter += (sender, e) =>
                {
                    productPictureBox.BackColor = Color.LightGray;
                };

                productPictureBox.MouseLeave += (sender, e) =>
                {
                    productPictureBox.BackColor = Color.Transparent;
                };

                productPictureBox.Click += (sender, e) =>
                {
                    SpecialOfferDetailForm detailForm = new SpecialOfferDetailForm(
                        product.Name,
                        product.Price,
                        product.Description,
                        product.Image,
                        checkoutForm // Pass the checkout form as an argument
                    );
                    detailForm.ShowDialog();
                };
                productPanel.Controls.Add(productPictureBox);

                Label nameLabel = new Label
                {
                    Text = product.Name,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                    Height = 30,
                    ForeColor = Color.Black
                };
                productPanel.Controls.Add(nameLabel);

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

                menProductsFlowPanel.Controls.Add(productPanel);
            }
        }

        private void mainFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
