using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(1000, 1200);
            this.AutoScroll = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Get values from text boxes
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string message = txtMessage.Text.Trim();

            // Validate fields
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email) || !IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrEmpty(phone) || !IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Please enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please enter your message.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMessage.Focus();
                return;
            }

            // If all validations pass
            MessageBox.Show("Your message has been sent successfully!", "Message Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear fields after successful submission
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtMessage.Clear();
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            // Contact details to share
            string contactDetails = "TrendMart Contact Details:\n" +
                                    "Refund: refund@trendmart.co.nz | +64 22 333 4444\n" +
                                    "Sales: sales@trendmart.co.nz | +64 22 111 3333\n" +
                                    "Support: support@trendmart.co.nz | +64 21 234 5678";

            // Copy to clipboard
            Clipboard.SetText(contactDetails);

            // Open social platform links (example: Twitter share link)
            string twitterUrl = "https://twitter.com/intent/tweet?text=" + Uri.EscapeDataString(contactDetails);
            DialogResult result = MessageBox.Show("Contact details copied to clipboard. Do you want to share on Twitter?",
                "Share Contact Details",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Process.Start(new ProcessStartInfo(twitterUrl) { UseShellExecute = true });
            }
        }

        private void grpContactForm_Enter(object sender, EventArgs e)
        {
        }

        private void Contact_Load(object sender, EventArgs e)
        {
        }

        // Email validation method
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        // Phone number validation method
        private bool IsValidPhoneNumber(string phone)
        {
            return phone.All(char.IsDigit) && phone.Length >= 7 && phone.Length <= 15;
        }
    }
}
