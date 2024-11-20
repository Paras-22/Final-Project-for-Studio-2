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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.grpFeedbackForm = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpFeedbackForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(362, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(300, 55);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Feedback Form";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSubHeader.ForeColor = System.Drawing.Color.Gray;
            this.lblSubHeader.Location = new System.Drawing.Point(119, 75);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(762, 30);
            this.lblSubHeader.TabIndex = 1;
            this.lblSubHeader.Text = "We appreciate your feedback. Please let us know your thoughts!";
            this.lblSubHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSubHeader.Click += new System.EventHandler(this.lblSubHeader_Click);
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
            this.grpFeedbackForm.Location = new System.Drawing.Point(50, 120);
            this.grpFeedbackForm.Name = "grpFeedbackForm";
            this.grpFeedbackForm.Size = new System.Drawing.Size(900, 400);
            this.grpFeedbackForm.TabIndex = 2;
            this.grpFeedbackForm.TabStop = false;
            this.grpFeedbackForm.Text = "Your Feedback";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(20, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Your Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtName.Location = new System.Drawing.Point(120, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 30);
            this.txtName.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(20, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email Address:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 10F);
            this.txtEmail.Location = new System.Drawing.Point(120, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 30);
            this.txtEmail.TabIndex = 3;
            // 
            // lblRating
            // 
            this.lblRating.Location = new System.Drawing.Point(20, 130);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(100, 25);
            this.lblRating.TabIndex = 4;
            this.lblRating.Text = "Rating (1-5):";
            // 
            // cmbRating
            // 
            this.cmbRating.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbRating.Location = new System.Drawing.Point(120, 130);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(100, 31);
            this.cmbRating.TabIndex = 5;
            // 
            // lblComments
            // 
            this.lblComments.Location = new System.Drawing.Point(20, 180);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(100, 25);
            this.lblComments.TabIndex = 6;
            this.lblComments.Text = "Comments:";
            // 
            // txtComments
            // 
            this.txtComments.Font = new System.Drawing.Font("Arial", 10F);
            this.txtComments.Location = new System.Drawing.Point(120, 180);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(600, 80);
            this.txtComments.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Green;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(120, 280);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 40);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit Feedback";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Feedback
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblSubHeader);
            this.Controls.Add(this.grpFeedbackForm);
            this.Name = "Feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrendMart - Customer Feedback";
            this.grpFeedbackForm.ResumeLayout(false);
            this.grpFeedbackForm.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
