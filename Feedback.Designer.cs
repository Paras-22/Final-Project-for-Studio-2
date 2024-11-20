using System;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    partial class Feedback
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private Label lblHeader;
        private Label lblSubHeader;
        private GroupBox grpFeedbackForm;
        private Label lblOrderNumber;
        private TextBox txtOrderNumber;
        private Label lblName;
        private TextBox txtName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblProductRating;
        private ComboBox cmbProductRating;
        private Label lblServiceRating;
        private ComboBox cmbServiceRating;
        private Label lblFeedbackType;
        private ComboBox cmbFeedbackType;
        private Label lblComments;
        private TextBox txtComments;
        private Button btnSubmit;
        private Button btnReset;
        private Label lblImageUpload;
        private Button btnUploadImage;
        private Label lblImageStatus;

        // Dispose method to clean up resources
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Form initialization method
        private void InitializeComponent()
        {
            // Form Properties
            this.ClientSize = new System.Drawing.Size(1024, 768); // Set the form size
            this.Text = "Feedback - TrendMart"; // Form Title

            // Header Label
            this.lblHeader = new Label
            {
                Text = "Feedback Form",
                Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Black,
                Location = new System.Drawing.Point(362, 20),
                Size = new System.Drawing.Size(300, 40),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };

            // Subheader Label
            this.lblSubHeader = new Label
            {
                Text = "We value your feedback. Please let us know about your experience!",
                Font = new System.Drawing.Font("Arial", 12F),
                ForeColor = System.Drawing.Color.Gray,
                Location = new System.Drawing.Point(250, 70),
                Size = new System.Drawing.Size(500, 30),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };

            // Feedback Form GroupBox
            this.grpFeedbackForm = new GroupBox
            {
                Text = "Your Feedback",
                Location = new System.Drawing.Point(50, 120),
                Size = new System.Drawing.Size(900, 500),
            };

            // Controls Initialization
            this.InitializeFormControls();

            // Add Controls to GroupBox
            this.grpFeedbackForm.Controls.Add(this.lblOrderNumber);
            this.grpFeedbackForm.Controls.Add(this.txtOrderNumber);
            this.grpFeedbackForm.Controls.Add(this.lblName);
            this.grpFeedbackForm.Controls.Add(this.txtName);
            this.grpFeedbackForm.Controls.Add(this.lblEmail);
            this.grpFeedbackForm.Controls.Add(this.txtEmail);
            this.grpFeedbackForm.Controls.Add(this.lblProductRating);
            this.grpFeedbackForm.Controls.Add(this.cmbProductRating);
            this.grpFeedbackForm.Controls.Add(this.lblServiceRating);
            this.grpFeedbackForm.Controls.Add(this.cmbServiceRating);
            this.grpFeedbackForm.Controls.Add(this.lblFeedbackType);
            this.grpFeedbackForm.Controls.Add(this.cmbFeedbackType);
            this.grpFeedbackForm.Controls.Add(this.lblComments);
            this.grpFeedbackForm.Controls.Add(this.txtComments);
            this.grpFeedbackForm.Controls.Add(this.btnSubmit);
            this.grpFeedbackForm.Controls.Add(this.btnReset);
            this.grpFeedbackForm.Controls.Add(this.lblImageUpload);
            this.grpFeedbackForm.Controls.Add(this.btnUploadImage);
            this.grpFeedbackForm.Controls.Add(this.lblImageStatus);

            // Add GroupBox and other Controls to Form
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblSubHeader);
            this.Controls.Add(this.grpFeedbackForm);
        }

        // Initialize all form controls
        private void InitializeFormControls()
        {
            // Order Number
            this.lblOrderNumber = new Label { Text = "Order Number:", Location = new System.Drawing.Point(20, 30) };
            this.txtOrderNumber = new TextBox { Location = new System.Drawing.Point(150, 30), Size = new System.Drawing.Size(300, 25) };

            // Name
            this.lblName = new Label { Text = "Your Name:", Location = new System.Drawing.Point(20, 80) };
            this.txtName = new TextBox { Location = new System.Drawing.Point(150, 80), Size = new System.Drawing.Size(300, 25) };

            // Email
            this.lblEmail = new Label { Text = "Email Address:", Location = new System.Drawing.Point(20, 130) };
            this.txtEmail = new TextBox { Location = new System.Drawing.Point(150, 130), Size = new System.Drawing.Size(300, 25) };

            // Product Rating
            this.lblProductRating = new Label { Text = "Product Rating (1-5):", Location = new System.Drawing.Point(20, 180) };
            this.cmbProductRating = new ComboBox { Items = { "1", "2", "3", "4", "5" }, Location = new System.Drawing.Point(150, 180), Size = new System.Drawing.Size(100, 25) };

            // Service Rating
            this.lblServiceRating = new Label { Text = "Service Rating (1-5):", Location = new System.Drawing.Point(20, 230) };
            this.cmbServiceRating = new ComboBox { Items = { "1", "2", "3", "4", "5" }, Location = new System.Drawing.Point(150, 230), Size = new System.Drawing.Size(100, 25) };

            // Feedback Type
            this.lblFeedbackType = new Label { Text = "Feedback Type:", Location = new System.Drawing.Point(20, 280) };
            this.cmbFeedbackType = new ComboBox { Items = { "Product", "Service", "Both" }, Location = new System.Drawing.Point(150, 280), Size = new System.Drawing.Size(150, 25) };

            // Comments
            this.lblComments = new Label { Text = "Comments:", Location = new System.Drawing.Point(20, 330) };
            this.txtComments = new TextBox { Location = new System.Drawing.Point(150, 330), Size = new System.Drawing.Size(600, 80), Multiline = true };

            // Submit Button
            this.btnSubmit = new Button
            {
                Text = "Submit Feedback",
                Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.White,
                BackColor = System.Drawing.Color.Green,
                Location = new System.Drawing.Point(150, 430),
                Size = new System.Drawing.Size(200, 40)
            };
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // Reset Button
            this.btnReset = new Button
            {
                Text = "Reset Form",
                Font = new System.Drawing.Font("Arial", 12F),
                ForeColor = System.Drawing.Color.White,
                BackColor = System.Drawing.Color.Gray,
                Location = new System.Drawing.Point(370, 430),
                Size = new System.Drawing.Size(150, 40)
            };
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // Image Upload
            this.lblImageUpload = new Label { Text = "Upload Image (Optional):", Location = new System.Drawing.Point(450, 30) };
            this.btnUploadImage = new Button { Text = "Choose File", Location = new System.Drawing.Point(600, 30), Size = new System.Drawing.Size(100, 30) };
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);

            // Image Status
            this.lblImageStatus = new Label { Location = new System.Drawing.Point(450, 70), Size = new System.Drawing.Size(250, 20), Text = "No image uploaded." };
        }
    }
}
