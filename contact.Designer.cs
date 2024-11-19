namespace TrendMart
{
    partial class Contact
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblRefundContact;
        private System.Windows.Forms.Label lblRefundEmail;
        private System.Windows.Forms.Label lblRefundPhone;
        private System.Windows.Forms.Label lblSalesContact;
        private System.Windows.Forms.Label lblSalesEmail;
        private System.Windows.Forms.Label lblSalesPhone;
        private System.Windows.Forms.Label lblSupportContact;
        private System.Windows.Forms.Label lblSupportEmail;
        private System.Windows.Forms.Label lblSupportPhone;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblRefundContact = new System.Windows.Forms.Label();
            this.lblRefundEmail = new System.Windows.Forms.Label();
            this.lblRefundPhone = new System.Windows.Forms.Label();
            this.lblSalesContact = new System.Windows.Forms.Label();
            this.lblSalesEmail = new System.Windows.Forms.Label();
            this.lblSalesPhone = new System.Windows.Forms.Label();
            this.lblSupportContact = new System.Windows.Forms.Label();
            this.lblSupportEmail = new System.Windows.Forms.Label();
            this.lblSupportPhone = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(100, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(157, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Contact Us";

            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(40, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 22);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "John Doe";  // Random name

            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(40, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 17);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";

            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 22);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "johndoe@example.com";  // Random email

            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(40, 160);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 17);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone:";

            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 157);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 22);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.Text = "+64 21 123 4567";  // Random New Zealand phone number

            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(40, 200);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(74, 17);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "Message:";

            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(120, 197);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(250, 100);
            this.txtMessage.TabIndex = 8;
            this.txtMessage.Text = "I have a question regarding the services.";  // Random message

            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(120, 320);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 30);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send Message";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // 
            // lblRefundContact
            // 
            this.lblRefundContact.AutoSize = true;
            this.lblRefundContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblRefundContact.Location = new System.Drawing.Point(40, 370);
            this.lblRefundContact.Name = "lblRefundContact";
            this.lblRefundContact.Size = new System.Drawing.Size(138, 20);
            this.lblRefundContact.TabIndex = 10;
            this.lblRefundContact.Text = "Refund Contact:";

            // 
            // lblRefundEmail
            // 
            this.lblRefundEmail.AutoSize = true;
            this.lblRefundEmail.Location = new System.Drawing.Point(40, 400);
            this.lblRefundEmail.Name = "lblRefundEmail";
            this.lblRefundEmail.Size = new System.Drawing.Size(234, 17);
            this.lblRefundEmail.TabIndex = 11;
            this.lblRefundEmail.Text = "Email: refund@trendmart.co.nz";

            // 
            // lblRefundPhone
            // 
            this.lblRefundPhone.AutoSize = true;
            this.lblRefundPhone.Location = new System.Drawing.Point(40, 430);
            this.lblRefundPhone.Name = "lblRefundPhone";
            this.lblRefundPhone.Size = new System.Drawing.Size(191, 17);
            this.lblRefundPhone.TabIndex = 12;
            this.lblRefundPhone.Text = "Phone: +64 27 765 4321";

            // 
            // lblSalesContact
            // 
            this.lblSalesContact.AutoSize = true;
            this.lblSalesContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblSalesContact.Location = new System.Drawing.Point(40, 460);
            this.lblSalesContact.Name = "lblSalesContact";
            this.lblSalesContact.Size = new System.Drawing.Size(131, 20);
            this.lblSalesContact.TabIndex = 13;
            this.lblSalesContact.Text = "Sales Contact:";

            // 
            // lblSalesEmail
            // 
            this.lblSalesEmail.AutoSize = true;
            this.lblSalesEmail.Location = new System.Drawing.Point(40, 490);
            this.lblSalesEmail.Name = "lblSalesEmail";
            this.lblSalesEmail.Size = new System.Drawing.Size(242, 17);
            this.lblSalesEmail.TabIndex = 14;
            this.lblSalesEmail.Text = "Email: sales@trendmart.co.nz";

            // 
            // lblSalesPhone
            // 
            this.lblSalesPhone.AutoSize = true;
            this.lblSalesPhone.Location = new System.Drawing.Point(40, 520);
            this.lblSalesPhone.Name = "lblSalesPhone";
            this.lblSalesPhone.Size = new System.Drawing.Size(181, 17);
            this.lblSalesPhone.TabIndex = 15;
            this.lblSalesPhone.Text = "Phone: +64 22 111 3333";

            // 
            // lblSupportContact
            // 
            this.lblSupportContact.AutoSize = true;
            this.lblSupportContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblSupportContact.Location = new System.Drawing.Point(40, 550);
            this.lblSupportContact.Name = "lblSupportContact";
            this.lblSupportContact.Size = new System.Drawing.Size(153, 20);
            this.lblSupportContact.TabIndex = 16;
            this.lblSupportContact.Text = "Support Contact:";

            // 
            // lblSupportEmail
            // 
            this.lblSupportEmail.AutoSize = true;
            this.lblSupportEmail.Location = new System.Drawing.Point(40, 580);
            this.lblSupportEmail.Name = "lblSupportEmail";
            this.lblSupportEmail.Size = new System.Drawing.Size(246, 17);
            this.lblSupportEmail.TabIndex = 17;
            this.lblSupportEmail.Text = "Email: support@trendmart.co.nz";

            // 
            // lblSupportPhone
            // 
            this.lblSupportPhone.AutoSize = true;
            this.lblSupportPhone.Location = new System.Drawing.Point(40, 610);
            this.lblSupportPhone.Name = "lblSupportPhone";
            this.lblSupportPhone.Size = new System.Drawing.Size(181, 17);
            this.lblSupportPhone.TabIndex = 18;
            this.lblSupportPhone.Text = "Phone: +64 21 234 5678";

            // 
            // Contact
            // 
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.lblSupportPhone);
            this.Controls.Add(this.lblSupportEmail);
            this.Controls.Add(this.lblSupportContact);
            this.Controls.Add(this.lblSalesPhone);
            this.Controls.Add(this.lblSalesEmail);
            this.Controls.Add(this.lblSalesContact);
            this.Controls.Add(this.lblRefundPhone);
            this.Controls.Add(this.lblRefundEmail);
            this.Controls.Add(this.lblRefundContact);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHeader);
            this.Name = "Contact";
            this.Text = "Contact Us";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
