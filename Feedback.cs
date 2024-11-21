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

        // Submit Button Click Event
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your feedback!", "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
