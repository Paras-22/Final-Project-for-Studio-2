using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1000, 1200);
            this.MaximizeBox = false;
        }

        // Submit Button Click Event
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                MessageBox.Show("Thank you for your feedback!", "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOrderNumber.Clear();
                txtName.Clear();
                txtEmail.Clear();
                cmbProductRating.SelectedIndex = -1;
                cmbServiceRating.SelectedIndex = -1;
                cmbFeedbackType.SelectedIndex = -1;
                txtComments.Clear();
                lblImageStatus.Text = "No image uploaded."; //ResetFields(); // Clear the form after successful submission
            }
        }

        // Validate Fields
        private bool ValidateFields()
        {
            // Check if Order Number is entered
            if (string.IsNullOrWhiteSpace(txtOrderNumber.Text))
            {
                MessageBox.Show("Please enter your order number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOrderNumber.Focus();
                return false;
            }

            // Check if Name is entered
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter your name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            // Validate Email Address
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // Check if Product Rating is selected
            if (cmbProductRating.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product rating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProductRating.Focus();
                return false;
            }

            // Check if Service Rating is selected
            if (cmbServiceRating.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a service rating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbServiceRating.Focus();
                return false;
            }

            // Check if Feedback Type is selected
            if (cmbFeedbackType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a feedback type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbFeedbackType.Focus();
                return false;
            }

            // Check if Comments are entered
            if (string.IsNullOrWhiteSpace(txtComments.Text))
            {
                MessageBox.Show("Please provide your comments.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtComments.Focus();
                return false;
            }

            // All validations passed
            return true;
        }

        // Email Validation Method
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        // Reset Button Click Event
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

        // Upload Image Button Click Event
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lblImageStatus.Text = "Image uploaded successfully.";
                }
            }
        }
    }
}
