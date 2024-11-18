using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class MenCategoryForm : Form
    {
        public MenCategoryForm()
        {
            InitializeComponent();
            InitializeMenCategoryPage();
        }

        private void InitializeMenCategoryPage()
        {
            // Form Settings
            this.Text = "Men's Fashion";
            this.Size = new Size(1280, 720);
            this.BackColor = Color.FromArgb(240, 240, 240); // Light background color

            // Top Navigation Bar
            Panel topNavBar = new Panel
            {
                Dock = DockStyle.Top,
                Height = 70,
                BackColor = Color.Gray
            };
            topNavBar.Paint += (s, e) =>
            {
                using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(topNavBar.ClientRectangle, Color.FromArgb(45, 45, 48), Color.FromArgb(30, 30, 32), 90F))
                {
                    e.Graphics.FillRectangle(brush, topNavBar.ClientRectangle);
                }
            };
            this.Controls.Add(topNavBar);

            Label titleLabel = new Label
            {
                Text = "Men's Fashion",
                Font = new Font("Arial", 18, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(20, 20),
                AutoSize = true
            };
            topNavBar.Controls.Add(titleLabel);

            // New Arrivals Section
            Panel newArrivalsPanel = CreateSectionPanel("New Arrivals", new Point(30, 90), new Size(580, 250));
            this.Controls.Add(newArrivalsPanel);

            PictureBox newArrivalImage1 = CreateImageBox(Properties.Resources.M1, new Point(20, 40), new Size(180, 180));
            PictureBox newArrivalImage2 = CreateImageBox(Properties.Resources.M2, new Point(220, 40), new Size(180, 180));
            newArrivalsPanel.Controls.Add(newArrivalImage1);
            newArrivalsPanel.Controls.Add(newArrivalImage2);

            // Best Sellers Section
            Panel bestSellersPanel = CreateSectionPanel("Best Sellers", new Point(30, 360), new Size(580, 250));
            this.Controls.Add(bestSellersPanel);

            PictureBox bestSellerImage1 = CreateImageBox(Properties.Resources.M3, new Point(20, 40), new Size(180, 180));
            PictureBox bestSellerImage2 = CreateImageBox(Properties.Resources.M1, new Point(220, 40), new Size(180, 180));
            bestSellersPanel.Controls.Add(bestSellerImage1);
            bestSellersPanel.Controls.Add(bestSellerImage2);
        }

        // Helper Method to Create a Section Panel
        private Panel CreateSectionPanel(string title, Point location, Size size)
        {
            Panel panel = new Panel
            {
                Location = location,
                Size = size,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10)
            };

            Label sectionTitle = new Label
            {
                Text = title,
                Font = new Font("Arial", 16, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true,
                ForeColor = Color.FromArgb(45, 45, 48)
            };

            panel.Controls.Add(sectionTitle);
            return panel;
        }

        // Helper Method to Create an Image Box
        private PictureBox CreateImageBox(Image image, Point location, Size size)
        {
            PictureBox pictureBox = new PictureBox
            {
                Image = image,
                Location = location,
                Size = size,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.FixedSingle
            };
            return pictureBox;
        }

        private void MenCategoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
