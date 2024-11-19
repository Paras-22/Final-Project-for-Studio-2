using System;
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
            // Load the sections in the desired order
            AddCategory("Shirts/T-Shirts", new[]
            {
                ((Image)Properties.Resources.S1, "Casual Shirt", 39.99m, "Perfect for casual wear."),
                ((Image)Properties.Resources.S2, "Formal Shirt", 49.99m, "Great for office wear."),
                ((Image)Properties.Resources.S3, "T-Shirt", 19.99m, "Comfortable and stylish."),
                ((Image)Properties.Resources.S4, "Sports T-Shirt", 29.99m, "Ideal for workouts.")
            });

            AddSeparator();

            AddCategory("Pants", new[]
            {
                ((Image)Properties.Resources.P1, "Chinos", 44.99m, "Versatile and comfortable."),
                ((Image)Properties.Resources.P2, "Formal Trousers", 59.99m, "Perfect for office wear."),
                ((Image)Properties.Resources.P3, "Jeans", 39.99m, "Classic and durable."),
                ((Image)Properties.Resources.P4, "Joggers", 29.99m, "Ideal for casual outings.")
            });

            AddSeparator();

            AddCategory("Shoes", new[]
            {
                ((Image)Properties.Resources.S1, "Sneakers", 69.99m, "Comfortable and trendy."),
                ((Image)Properties.Resources.S2, "Formal Shoes", 89.99m, "Perfect for business."),
                ((Image)Properties.Resources.S3, "Boots", 79.99m, "Durable and stylish."),
                ((Image)Properties.Resources.S4, "Loafers", 59.99m, "Great for casual wear.")
            });

            AddSeparator();

            AddCategory("Accessories", new[]
            {
                ((Image)Properties.Resources.A1, "Watch", 99.99m, "Stylish and functional."),
                ((Image)Properties.Resources.A2, "Sunglasses", 49.99m, "Trendy and protective."),
                ((Image)Properties.Resources.A3, "Belt", 19.99m, "Classic leather design."),
                ((Image)Properties.Resources.A4, "Wallet", 24.99m, "Slim and durable.")
            });
        }

        private void AddCategory(string categoryTitle, (Image Image, string Name, decimal Price, string Description)[] products)
        {
            // Add a title label for the category
            Label categoryLabel = new Label
            {
                Text = categoryTitle,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.Black,
                Dock = DockStyle.Top,
                Height = 40,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10)
            };
            mainFlowLayoutPanel.Controls.Add(categoryLabel);

            // Create a grid layout for the category products
            TableLayoutPanel productTable = new TableLayoutPanel
            {
                ColumnCount = 2, // 2 columns
                RowCount = 2, // 2 rows
                Dock = DockStyle.Top,
                AutoSize = true,
                Padding = new Padding(10),
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            };

            productTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            productTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            // Add products into the grid layout
            foreach (var product in products)
            {
                Panel productPanel = new Panel
                {
                    Width = 200,
                    Height = 300,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                PictureBox productImage = new PictureBox
                {
                    Image = product.Image,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top,
                    Height = 150
                };

                Label productName = new Label
                {
                    Text = product.Name,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Height = 30
                };

                Label productPrice = new Label
                {
                    Text = $"Price: ${product.Price:F2}",
                    Font = new Font("Segoe UI", 10F),
                    ForeColor = Color.Green,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Height = 20
                };

                Button viewDetailsButton = new Button
                {
                    Text = "View Details",
                    Dock = DockStyle.Bottom,
                    BackColor = Color.DarkOrange,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Height = 40
                };

                // Add click event to View Details button
                viewDetailsButton.Click += (s, e) =>
                {
                    SpecialOfferDetailForm detailForm = new SpecialOfferDetailForm(
                        product.Name,
                        product.Price,
                        product.Description,
                        product.Image
                    );
                    detailForm.ShowDialog();
                };

                productPanel.Controls.Add(viewDetailsButton);
                productPanel.Controls.Add(productPrice);
                productPanel.Controls.Add(productName);
                productPanel.Controls.Add(productImage);

                // Add the product panel to the table
                productTable.Controls.Add(productPanel);
            }

            // Add the product table to the main flow layout
            mainFlowLayoutPanel.Controls.Add(productTable);
        }

        private void AddSeparator()
        {
            // Add a separator line between categories
            Panel separatorPanel = new Panel
            {
                Height = 2,
                Dock = DockStyle.Top,
                BackColor = Color.Gray,
                Margin = new Padding(0, 20, 0, 20)
            };
            mainFlowLayoutPanel.Controls.Add(separatorPanel);
        }
    }
}
