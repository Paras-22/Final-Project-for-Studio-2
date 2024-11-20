using System;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string orderNumber = txtOrderNumber.Text;
            string name = txtName.Text;
            string email = txtEmail.Text;
            string productRating = cmbProductRating.SelectedItem?.ToString();
            string serviceRating = cmbServiceRating.SelectedItem?.ToString();
            string feedbackType = cmbFeedbackType.SelectedItem?.ToString();
            string comments = txtComments.Text;

            if (string.IsNullOrEmpty(orderNumber) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(productRating) || string.IsNullOrEmpty(serviceRating))
            {
                MessageBox.Show("Please fill in all required fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Thank you, {name}, for your feedback!\nOrder Number: {orderNumber}\n" +
                                 $"Product Rating: {productRating}\nService Rating: {serviceRating}\n" +
                                 $"Feedback Type: {feedbackType}\nComments: {comments}",
                                 "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the form after submission
                txtOrderNumber.Clear();
                txtName.Clear();
                txtEmail.Clear();
                cmbProductRating.SelectedIndex = -1;
                cmbServiceRating.SelectedIndex = -1;
                cmbFeedbackType.SelectedIndex = -1;
                txtComments.Clear();
                lblImageStatus.Text = "No image uploaded.";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtOrderNumber.Clear();
            txtName.Clear();
            txtEmail.Clear();
            cmbProductRating.SelectedIndex = -1;
            cmbServiceRating.SelectedIndex = -1;
            cmbFeedbackType.SelectedIndex = -1;
            txtComments.Clear();
            lblImageStatus.Text = "No image uploaded.";
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblImageStatus.Text = $"Image uploaded: {openFileDialog.FileName}";
            }
        }
    }
}
