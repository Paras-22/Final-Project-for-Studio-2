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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.grpContactForm = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.grpContactDetails = new System.Windows.Forms.GroupBox();
            this.lblRefundTitle = new System.Windows.Forms.Label();
            this.lblRefundEmail = new System.Windows.Forms.Label();
            this.lblRefundPhone = new System.Windows.Forms.Label();
            this.lblSalesTitle = new System.Windows.Forms.Label();
            this.lblSalesEmail = new System.Windows.Forms.Label();
            this.lblSalesPhone = new System.Windows.Forms.Label();
            this.lblSupportTitle = new System.Windows.Forms.Label();
            this.lblSupportEmail = new System.Windows.Forms.Label();
            this.lblSupportPhone = new System.Windows.Forms.Label();
            this.grpContactForm.SuspendLayout();
            this.grpContactDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(362, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(300, 40);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Contact Us";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSubHeader.Location = new System.Drawing.Point(129, 72);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(717, 30);
            this.lblSubHeader.TabIndex = 1;
            this.lblSubHeader.Text = "We\'d love to hear from you! Fill in the form or reach us directly.";
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
            this.grpContactForm.TabIndex = 2;
            this.grpContactForm.TabStop = false;
            this.grpContactForm.Text = "Send us a message";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(20, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(20, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(20, 130);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 23);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 130);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(300, 26);
            this.txtPhone.TabIndex = 5;
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(20, 180);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(100, 23);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "Message:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(120, 180);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(600, 80);
            this.txtMessage.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(120, 280);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 30);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
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
            this.grpContactDetails.Name = "grpContactDetails";
            this.grpContactDetails.Size = new System.Drawing.Size(900, 150);
            this.grpContactDetails.TabIndex = 3;
            this.grpContactDetails.TabStop = false;
            this.grpContactDetails.Text = "Contact Information";
            // 
            // lblRefundTitle
            // 
            this.lblRefundTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblRefundTitle.Location = new System.Drawing.Point(20, 30);
            this.lblRefundTitle.Name = "lblRefundTitle";
            this.lblRefundTitle.Size = new System.Drawing.Size(100, 23);
            this.lblRefundTitle.TabIndex = 0;
            this.lblRefundTitle.Text = "Refund";
            // 
            // lblRefundEmail
            // 
            this.lblRefundEmail.Location = new System.Drawing.Point(20, 60);
            this.lblRefundEmail.Name = "lblRefundEmail";
            this.lblRefundEmail.Size = new System.Drawing.Size(244, 30);
            this.lblRefundEmail.TabIndex = 1;
            this.lblRefundEmail.Text = "Email: refund@trendmart.co.nz";
            // 
            // lblRefundPhone
            // 
            this.lblRefundPhone.Location = new System.Drawing.Point(20, 90);
            this.lblRefundPhone.Name = "lblRefundPhone";
            this.lblRefundPhone.Size = new System.Drawing.Size(200, 23);
            this.lblRefundPhone.TabIndex = 2;
            this.lblRefundPhone.Text = "Phone: +64 22 333 4444";
            // 
            // lblSalesTitle
            // 
            this.lblSalesTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblSalesTitle.Location = new System.Drawing.Point(320, 30);
            this.lblSalesTitle.Name = "lblSalesTitle";
            this.lblSalesTitle.Size = new System.Drawing.Size(100, 23);
            this.lblSalesTitle.TabIndex = 3;
            this.lblSalesTitle.Text = "Sales";
            // 
            // lblSalesEmail
            // 
            this.lblSalesEmail.Location = new System.Drawing.Point(320, 60);
            this.lblSalesEmail.Name = "lblSalesEmail";
            this.lblSalesEmail.Size = new System.Drawing.Size(223, 30);
            this.lblSalesEmail.TabIndex = 4;
            this.lblSalesEmail.Text = "Email: sales@trendmart.co.nz";
            // 
            // lblSalesPhone
            // 
            this.lblSalesPhone.Location = new System.Drawing.Point(320, 90);
            this.lblSalesPhone.Name = "lblSalesPhone";
            this.lblSalesPhone.Size = new System.Drawing.Size(223, 23);
            this.lblSalesPhone.TabIndex = 5;
            this.lblSalesPhone.Text = "Phone: +64 22 111 3333";
            // 
            // lblSupportTitle
            // 
            this.lblSupportTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblSupportTitle.Location = new System.Drawing.Point(620, 30);
            this.lblSupportTitle.Name = "lblSupportTitle";
            this.lblSupportTitle.Size = new System.Drawing.Size(100, 23);
            this.lblSupportTitle.TabIndex = 6;
            this.lblSupportTitle.Text = "Support";
            // 
            // lblSupportEmail
            // 
            this.lblSupportEmail.Location = new System.Drawing.Point(620, 60);
            this.lblSupportEmail.Name = "lblSupportEmail";
            this.lblSupportEmail.Size = new System.Drawing.Size(254, 23);
            this.lblSupportEmail.TabIndex = 7;
            this.lblSupportEmail.Text = "Email: support@trendmart.co.nz";
            // 
            // lblSupportPhone
            // 
            this.lblSupportPhone.Location = new System.Drawing.Point(620, 90);
            this.lblSupportPhone.Name = "lblSupportPhone";
            this.lblSupportPhone.Size = new System.Drawing.Size(217, 23);
            this.lblSupportPhone.TabIndex = 8;
            this.lblSupportPhone.Text = "Phone: +64 21 234 5678";
            // 
            // Contact
            // 
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblSubHeader);
            this.Controls.Add(this.grpContactForm);
            this.Controls.Add(this.grpContactDetails);
            this.Name = "Contact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Us - TrendMart";
            this.grpContactForm.ResumeLayout(false);
            this.grpContactForm.PerformLayout();
            this.grpContactDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
