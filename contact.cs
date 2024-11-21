using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your message has been sent successfully!", "Message Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Process.Start(twitterUrl);
            }
        }
    }
}
