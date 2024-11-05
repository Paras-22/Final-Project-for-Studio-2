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

        private void Form3_Load(object sender, EventArgs e)
        {
            // This method is called when the form loads
        }

        private void InitializeDashboard()
        {
            // Main Form Settings
            this.Text = "Dashboard";
            this.Size = new Size(1280, 720);
            this.BackColor = Color.FromArgb(240, 240, 240); // Light background color

            // Sidebar Panel
            Panel sidebarPanel = new Panel
            {
                Dock = DockStyle.Left,
                Width = 180,
                BackColor = Color.FromArgb(45, 45, 48), // Dark sidebar color
                Padding = new Padding(10),
            };
            this.Controls.Add(sidebarPanel);

            // Sidebar Category Buttons (Adding Individually)
            Button menButton = CreateSidebarButton("Men");
            sidebarPanel.Controls.Add(menButton);

            Button womenButton = CreateSidebarButton("Women");
            sidebarPanel.Controls.Add(womenButton);

            Button kidButton = CreateSidebarButton("Kid");
            sidebarPanel.Controls.Add(kidButton);

            Button accessoriesButton = CreateSidebarButton("Accessories");
            sidebarPanel.Controls.Add(accessoriesButton);

            Button allButton = CreateSidebarButton("All");
            sidebarPanel.Controls.Add(allButton);

            Button contactSupportButton = CreateSidebarButton("Contact Support - EMAIL");
            sidebarPanel.Controls.Add(contactSupportButton);

            // Top Navigation Bar with Gradient Background
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

            // "Get Your Style" and "Login" Buttons
            Button getStyleButton = CreateTopButton("Get Your Style", new Point(20, 20));
            getStyleButton.Click += GetStyleButton_Click;
            topNavBar.Controls.Add(getStyleButton);

            Button loginButton = CreateTopButton("LOGIN", new Point(this.ClientSize.Width - 150, 20), AnchorStyles.Top | AnchorStyles.Right);
            loginButton.Click += LoginButton_Click;
            topNavBar.Controls.Add(loginButton);

            // New Release Section
            Panel newReleasePanel = CreateRoundedPanel(new Point(200, 90), new Size(700, 250), "New Release");
            this.Controls.Add(newReleasePanel);

            // New Release Images
            PictureBox pictureBox1 = CreateImageBox("C:\\Images\\M2.jpg", new Point(20, 40), new Size(180, 180));
            PictureBox pictureBox2 = CreateImageBox("C:\\Images\\M3.png", new Point(220, 40), new Size(180, 180));
            newReleasePanel.Controls.Add(pictureBox1);
            newReleasePanel.Controls.Add(pictureBox2);

            // View Past Orders Section
            Panel pastOrdersPanel = CreateRoundedPanel(new Point(200, 360), new Size(700, 300), "View Past Orders");
            this.Controls.Add(pastOrdersPanel);

            // Past Orders Image
            PictureBox pastOrdersPictureBox = CreateImageBox("C:\\Images\\M1.jpg", new Point(20, 40), new Size(250, 250));
            pastOrdersPanel.Controls.Add(pastOrdersPictureBox);
        }

        // Helper Method to Create Sidebar Buttons with Consistent Style
        private Button CreateSidebarButton(string text)
        {
            Button button = new Button
            {
                Text = text,
                Width = 150,
                Height = 40,
                TextAlign = ContentAlignment.MiddleLeft,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = Color.FromArgb(60, 63, 65),
                Font = new Font("Arial", 10, FontStyle.Regular),
                Margin = new Padding(0, 10, 0, 0),
                Cursor = Cursors.Hand,
                Dock = DockStyle.Top
            };
            button.FlatAppearance.BorderSize = 0;
            button.MouseEnter += (sender, e) => { button.BackColor = Color.FromArgb(80, 80, 85); };
            button.MouseLeave += (sender, e) => { button.BackColor = Color.FromArgb(60, 63, 65); };
            return button;
        }

        // Helper Method to Create Top Buttons
        private Button CreateTopButton(string text, Point location, AnchorStyles anchor = AnchorStyles.None)
        {
            Button button = new Button
            {
                Text = text,
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                Location = location,
                AutoSize = true,
                Cursor = Cursors.Hand,
                Anchor = anchor
            };
            button.FlatAppearance.BorderSize = 0;
            return button;
        }

        // Helper Method to Create a Rounded Panel with Shadow
        private Panel CreateRoundedPanel(Point location, Size size, string title)
        {
            Panel panel = new Panel
            {
                Location = location,
                Size = size,
                BackColor = Color.White,
                BorderStyle = BorderStyle.None,
                Padding = new Padding(10)
            };
            panel.Paint += (s, e) =>
            {
                // Shadow effect
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(200, 200, 200), 10), new Rectangle(new Point(-5, -5), new Size(panel.Width + 10, panel.Height + 10)));

                // Rounded corners effect
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, panel.Width, panel.Height));
                e.Graphics.DrawString(title, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            };
            return panel;
        }

        // Helper Method to Create an Image Box
        private PictureBox CreateImageBox(string imagePath, Point location, Size size)
        {
            PictureBox pictureBox = new PictureBox
            {
                Image = Image.FromFile(imagePath),
                Location = location,
                Size = size,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.None
            };
            return pictureBox;
        }

        // Event handlers for the buttons
        private void GetStyleButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Get Your Style button clicked!");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login button clicked!");
        }
    }
}
