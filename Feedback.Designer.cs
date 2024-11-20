using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    partial class Feedback
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private Label lblHeader;
        private GroupBox grpFeedbackForm;
        private Label lblName;
        private TextBox txtName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblRating;
        private ComboBox cmbRating;
        private Label lblComments;
        private TextBox txtComments;
        private Button btnSubmit;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new Label();
            this.grpFeedbackForm = new GroupBox();
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblRating = new Label();
            this.cmbRating = new ComboBox();
            this.lblComments = new Label();
            this.txtComments = new TextBox();
            this.btnSubmit = new Button();

            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(362, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(300, 40);
            this.lblHeader.Text = "Feedback";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // grpFeedbackForm
            // 
            this.grpFeedbackForm.Controls.Add(this.lblName);
            this.grpFeedbackForm.Controls.Add(this.txtName);
            this.grpFeedbackForm.Controls.Add(this.lblEmail);
            this.grpFeedbackForm.Controls.Add(this.txtEmail);
            this.grpFeedbackForm.Controls.Add(this.lblRating);
            this.grpFeedbackForm.Controls.Add(this.cmbRating);
            this.grpFeedbackForm.Controls.Add(this.lblComments);
            this.grpFeedbackForm.Controls.Add(this.txtComments);
            this.grpFeedbackForm.Controls.Add(this.btnSubmit);
            this.grpFeedbackForm.Location = new System.Drawing.Point(50, 100);
            this.grpFeedbackForm.Name = "grpFeedbackForm";
            this.grpFeedbackForm.Size = new System.Drawing.Size(900, 400);
            this.grpFeedbackForm.Text = "Submit Your Feedback";

            // 
            // Name
            // 
            this.lblName.Text = "Name:";
            this.lblName.Location = new System.Drawing.Point(20, 30);
            this.txtName.Location = new System.Drawing.Point(120, 30);
            this.txtName.Size = new System.Drawing.Size(300, 25);

            // 
            // Email
            // 
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(20, 80);
            this.txtEmail.Location = new System.Drawing.Point(120, 80);
            this.txtEmail.Size = new System.Drawing.Size(300, 25);

            // 
            // Rating
            // 
            this.lblRating.Text = "Rating (1-5):";
            this.lblRating.Location = new System.Drawing.Point(20, 130);
            this.cmbRating.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            this.cmbRating.Location = new System.Drawing.Point(120, 130);
            this.cmbRating.Size = new System.Drawing.Size(100, 25);

            // 
            // Comments
            // 
            this.lblComments.Text = "Comments:";
            this.lblComments.Location = new System.Drawing.Point(20, 180);
            this.txtComments.Location = new System.Drawing.Point(120, 180);
            this.txtComments.Size = new System.Drawing.Size(600, 80);
            this.txtComments.Multiline = true;

            // 
            // Submit Button
            // 
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Location = new System.Drawing.Point(120, 280);
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // 
            // Feedback
            // 
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.grpFeedbackForm);
            this.Text = "Feedback - TrendMart";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
