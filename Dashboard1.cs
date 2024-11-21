using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class Dashboard1 : Form
    {
        private Form5 checkoutForm; // Shared instance of Form5

        public Dashboard1()
        {
            InitializeComponent();
            checkoutForm = new Form5(); // Initialize shared Form5 instance
            LoadProducts();
        }

        private void LoadProducts()
        {
            this.ClientSize = new System.Drawing.Size(980, 768);

            FlowLayoutPanel productsFlowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(20),
                WrapContents = true,
                FlowDirection = FlowDirection.LeftToRight
            };

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

            var products = new List<(string Name, decimal Price, string Description, Image Image)>
            {
                ("Formal Suit", 129.99m, "Elegant and professional.", Properties.Resources.outfit1),
                ("Casual Outfit", 199.99m, "Comfortable and stylish.", Properties.Resources.outfit2),
                ("Puffer Jacket with Jeans", 109.99m, "Stay warm in style.", Properties.Resources.outfit41),
                ("Bomber Jacket Outfit", 110.99m, "Light and breezy.", Properties.Resources.outfit4),
                ("Denim Jacket Outfit", 149.99m, "Stylish and attractive.", Properties.Resources.outfit5)
            };

            foreach (var product in products)
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
                    // Pass shared Form5 to SpecialOfferDetailForm
                    SpecialOfferDetailForm detailForm = new SpecialOfferDetailForm(
                        product.Name,
                        product.Price,
                        product.Description,
                        product.Image,
                        checkoutForm
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

                productsFlowPanel.Controls.Add(productPanel);
            }
        }

        private void btnMen_Click(object sender, EventArgs e)
        {
            MenCategoryForm1 menCategoryForm = new MenCategoryForm1();
            menCategoryForm.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void cartIconPictureBox_Click(object sender, EventArgs e)
        {
            checkoutForm.Show();
            this.Hide();
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
