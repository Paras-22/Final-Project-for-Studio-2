using System.Windows.Forms; // Required for Windows Forms

namespace Final_Project_for_Studio_2
{
    partial class Contact
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private Label lblHeader;
        private Label lblSubHeader;
        private GroupBox grpContactForm;
        private Label lblName;
        private TextBox txtName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblMessage;
        private TextBox txtMessage;
        private Button btnSend;
        private GroupBox grpContactDetails;
        private Label lblRefundTitle;
        private Label lblRefundEmail;
        private Label lblRefundPhone;
        private Label lblSalesTitle;
        private Label lblSalesEmail;
        private Label lblSalesPhone;
        private Label lblSupportTitle;
        private Label lblSupportEmail;
        private Label lblSupportPhone;

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
            this.lblSubHeader = new Label();
            this.grpContactForm = new GroupBox();
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblPhone = new Label();
            this.txtPhone = new TextBox();
            this.lblMessage = new Label();
            this.txtMessage = new TextBox();
            this.btnSend = new Button();
            this.grpContactDetails = new GroupBox();
            this.lblRefundTitle = new Label();
            this.lblRefundEmail = new Label();
            this.lblRefundPhone = new Label();
            this.lblSalesTitle = new Label();
            this.lblSalesEmail = new Label();
            this.lblSalesPhone = new Label();
            this.lblSupportTitle = new Label();
            this.lblSupportEmail = new Label();
            this.lblSupportPhone = new Label();

            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(362, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(300, 40);
            this.lblHeader.Text = "Contact Us";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblSubHeader
            // 
            this.lblSubHeader.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSubHeader.Location = new System.Drawing.Point(250, 70);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(500, 30);
            this.lblSubHeader.Text = "We'd love to hear from you! Fill in the form or reach us directly.";
            this.lblSubHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // grpContactForm
            // 
            this.grpContactForm.Controls.Add(this.lblName);
            this.grpContactForm.Controls.Add(this.txtName);
            this.grpContactForm.Controls.Add(this.lblEmail);
            this.grpContactForm.Controls.Add(this.txtEmail);
            this.grpContactForm.Controls.Add(this.lblPhone);
            this.grpContactForm.Controls.Add(this.txtPhone);
            this.grpContactForm.Controls.Add(this.lblMessage);
            this.grpContactForm.Controls.Add(this.txtMessage);
            this.grpContactForm.Controls.Add(this.btnSend);
            this.grpContactForm.Location = new System.Drawing.Point(50, 120);
            this.grpContactForm.Name = "grpContactForm";
            this.grpContactForm.Size = new System.Drawing.Size(900, 350);
            this.grpContactForm.Text = "Send us a message";

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
            // Phone
            // 
            this.lblPhone.Text = "Phone:";
            this.lblPhone.Location = new System.Drawing.Point(20, 130);
            this.txtPhone.Location = new System.Drawing.Point(120, 130);
            this.txtPhone.Size = new System.Drawing.Size(300, 25);

            // 
            // Message
            // 
            this.lblMessage.Text = "Message:";
            this.lblMessage.Location = new System.Drawing.Point(20, 180);
            this.txtMessage.Location = new System.Drawing.Point(120, 180);
            this.txtMessage.Size = new System.Drawing.Size(600, 80);
            this.txtMessage.Multiline = true;

            // 
            // Send Button
            // 
            this.btnSend.Text = "Send";
            this.btnSend.Location = new System.Drawing.Point(120, 280);
            this.btnSend.Size = new System.Drawing.Size(100, 30);
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // 
            // grpContactDetails
            // 
            this.grpContactDetails.Controls.Add(this.lblRefundTitle);
            this.grpContactDetails.Controls.Add(this.lblRefundEmail);
            this.grpContactDetails.Controls.Add(this.lblRefundPhone);
            this.grpContactDetails.Controls.Add(this.lblSalesTitle);
            this.grpContactDetails.Controls.Add(this.lblSalesEmail);
            this.grpContactDetails.Controls.Add(this.lblSalesPhone);
            this.grpContactDetails.Controls.Add(this.lblSupportTitle);
            this.grpContactDetails.Controls.Add(this.lblSupportEmail);
            this.grpContactDetails.Controls.Add(this.lblSupportPhone);
            this.grpContactDetails.Location = new System.Drawing.Point(50, 500);
            this.grpContactDetails.Size = new System.Drawing.Size(900, 150);
            this.grpContactDetails.Text = "Contact Information";

            // Refund
            this.lblRefundTitle.Text = "Refund";
            this.lblRefundTitle.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.lblRefundTitle.Location = new System.Drawing.Point(20, 30);
            this.lblRefundEmail.Text = "Email: refund@trendmart.co.nz";
            this.lblRefundEmail.Location = new System.Drawing.Point(20, 60);
            this.lblRefundPhone.Text = "Phone: +64 22 333 4444";
            this.lblRefundPhone.Location = new System.Drawing.Point(20, 90);

            // Sales
            this.lblSalesTitle.Text = "Sales";
            this.lblSalesTitle.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.lblSalesTitle.Location = new System.Drawing.Point(320, 30);
            this.lblSalesEmail.Text = "Email: sales@trendmart.co.nz";
            this.lblSalesEmail.Location = new System.Drawing.Point(320, 60);
            this.lblSalesPhone.Text = "Phone: +64 22 111 3333";
            this.lblSalesPhone.Location = new System.Drawing.Point(320, 90);

            // Support
            this.lblSupportTitle.Text = "Support";
            this.lblSupportTitle.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.lblSupportTitle.Location = new System.Drawing.Point(620, 30);
            this.lblSupportEmail.Text = "Email: support@trendmart.co.nz";
            this.lblSupportEmail.Location = new System.Drawing.Point(620, 60);
            this.lblSupportPhone.Text = "Phone: +64 21 234 5678";
            this.lblSupportPhone.Location = new System.Drawing.Point(620, 90);

            // 
            // Contact
            // 
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblSubHeader);
            this.Controls.Add(this.grpContactForm);
            this.Controls.Add(this.grpContactDetails);
            this.Text = "Contact Us - TrendMart";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
