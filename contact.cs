using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TrendMart
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        // Event handler for the "Send Message" button
        private void btnSend_Click(object sender, EventArgs e)
        {
            // Example of form submission logic (you can enhance it with real backend functionality)
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string message = txtMessage.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Thank you, {name}. Your message has been sent successfully!", "Message Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
