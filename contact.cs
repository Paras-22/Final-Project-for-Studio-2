using System;
using System.Windows.Forms; // Required for Windows Forms

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
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string message = txtMessage.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Please fill in all required fields (Name, Email, and Message).", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Thank you, {name}! Your message has been sent.", "Message Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblSubHeader_Click(object sender, EventArgs e)
        {

        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void grpContactForm_Enter(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlContactDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblRefundTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblRefundEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblRefundPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblSalesTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblSalesEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblSalesPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblSupportTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblSupportEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblSupportPhone_Click(object sender, EventArgs e)
        {

        }
    }
}
